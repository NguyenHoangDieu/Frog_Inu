using EcommerceApiWeb.Models;
using WebApiEcommerceApp.Data;

namespace EcommerceApiWeb.Services
{
    public interface IUserRepository
    {
        User GetUserInfo(int id);
        User ChangeInfoUser(User model);
    }
}
