using EcommerceApiWeb.Data.Entity;
using EcommerceApiWeb.Models;
using Nest;
using WebApiEcommerceApp.Data;

namespace EcommerceApiWeb.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly EcommerceAppDbContext _context;
        public UserRepository(EcommerceAppDbContext context)
        {
            _context = context;
        }
        public User GetUserInfo(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                return new User
                {
                   Id = user.Id,
                   HoVaTen = user.HoVaTen,
                   DienThoai = user.DienThoai,
                   Username = user.Username,
                   Password = user.Password,
                };

            }
            return null;
        }

        public User ChangeInfoUser(User model)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == model.Id);
            if (user != null)
            {

                user.HoVaTen = model.HoVaTen;
                user.DienThoai = model.DienThoai;
                user.Username = model.Username;
                user.Password = model.Password;
                _context.SaveChanges();
            }
            return null;

        }
    }
}
