using EcommerceApiWeb.Core;
using EcommerceApiWeb.Models;

namespace EcommerceApiWeb.Services
{
    public interface IDonHangRepository
    {
        public DonHangDto GetById(int id);
    }
}
