using EcommerceApiWeb.Models;

namespace EcommerceApiWeb.Services
{
    public interface ISanPhamRepository
    {
        List<SanPhamModel> GetAllProduct();
        SanPhamModel GetProductById(int id);
       
    }
}
