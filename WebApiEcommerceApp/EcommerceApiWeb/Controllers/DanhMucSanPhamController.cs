using EcommerceApiWeb.Data.Entity;
using EcommerceApiWeb.Models;
using EcommerceApiWeb.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiEcommerceApp.Data;

namespace EcommerceApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucSanPhamController : ControllerBase
    {
        private readonly EcommerceAppDbContext _context;
        private IDanhMucSanPhamRepository _danhMucSanPhamRepository;
        public DanhMucSanPhamController(EcommerceAppDbContext context, IDanhMucSanPhamRepository danhMucSanPhamRepository)
        {
            _context = context;
            _danhMucSanPhamRepository = danhMucSanPhamRepository;
        }
        [HttpGet("GetAllCategory")]
        public IActionResult GetAllDanhMuc()
        {
            try
            {
                return Ok(_danhMucSanPhamRepository.GetAllCategory());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetCategoryById")]
        public IActionResult GetCategoryById(int id)
        {
            try
            {
                return Ok(_danhMucSanPhamRepository.GetCategoryById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetProductsByCategory")]
        public IActionResult GetProductsByCategory(int idDanhMuc)
        {
            try
            {
                return Ok(_danhMucSanPhamRepository.GetProductsByCategory(idDanhMuc));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
