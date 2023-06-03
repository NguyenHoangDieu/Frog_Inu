using EcommerceApiWeb.Models;
using WebApiEcommerceApp.Data;

namespace EcommerceApiWeb.Services
{
    public interface IDanhMucSanPhamRepository
    {
        List<DanhMucSanPham> GetAllCategory();
        DanhMucSanPham GetCategoryById(int id);
        List<SanPham> GetProductsByCategory(int categoryId);
    }
}
