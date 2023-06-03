using EcommerceApiWeb.Models;
using WebApiEcommerceApp.Data;

namespace EcommerceApiWeb.Services
{
    public interface IDanhMucSanPhamRepository
    {
        List<DanhMucSanPhamModel> GetAllCategory();
        DanhMucSanPhamModel GetCategoryById(int id);
        List<SanPham> GetProductsByCategory(int categoryId);
    }
}
