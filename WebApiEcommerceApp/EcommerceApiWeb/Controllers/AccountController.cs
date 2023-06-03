using EcommerceApiWeb.Data.Entity;
using EcommerceApiWeb.Models;
using EcommerceApiWeb.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Nest;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApiEcommerceApp.Data;

namespace EcommerceApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly EcommerceAppDbContext _context;
        private IUserRepository _userRepository;

        public AccountController(IConfiguration config,IUserRepository userRepository, EcommerceAppDbContext context)
        {
            _configuration = config;
            _context = context;
            _userRepository = userRepository;
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(UserModel _userData)
        {
            if (_userData != null)
            {
                var resultLoginCheck = _context.Users
                    .Where(e => e.Username == _userData.Username && e.Password == _userData.Password)
                    .FirstOrDefault();
                if (resultLoginCheck == null)
                {
                    return BadRequest("Invalid Credentials");
                }
                else
                {
                    _userData.UserMessage = "Login Success";

                    var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("UserId", _userData.Id.ToString()),
                        new Claim("DisplayName", _userData.Username),
                        new Claim("UserName", _userData.Username),
                        new Claim("Email", _userData.Username)
                    };


                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        _configuration["Jwt:Issuer"],
                        _configuration["Jwt:Audience"],
                        claims,
                        expires: DateTime.UtcNow.AddMinutes(10),
                        signingCredentials: signIn);


                    _userData.AccessToken = new JwtSecurityTokenHandler().WriteToken(token);

                    return Ok(_userData);
                }
            }
            else
            {
                return BadRequest("No Data Posted");
            }
        }



        [HttpPost("Register")]
        public IActionResult Register(User user)
        {
            try
            {
                var userData = new User
                {
                    Username = user.Username,
                    Password = user.Password,
                    HoVaTen = user.HoVaTen,
                    DienThoai = user.DienThoai,
                };
                _context.Add(userData);
                _context.SaveChanges();
                return Ok(userData);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpGet("GetUserInfo")]
        public IActionResult GetUserInfo(int id)
        {
            try
            {
                return Ok(_userRepository.GetUserInfo(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpPost("ChangeInfoUser")]
        public IActionResult ChangeInfoUser(User user)
        {
            try
            {
                return Ok(_userRepository.ChangeInfoUser(user));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



    }
}
