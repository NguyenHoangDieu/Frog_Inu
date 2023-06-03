using EcommerceApiWeb.Data.Entity;
using EcommerceApiWeb.Models;
using WebApiEcommerceApp.Data;

namespace EcommerceApiWeb.Services
{
    public class DanhMucSanPhamRepository : IDanhMucSanPhamRepository
    {
        private readonly EcommerceAppDbContext _context;

        public DanhMucSanPhamRepository(EcommerceAppDbContext context)
        {
            _context = context;
        }
        public List<DanhMucSanPhamModel> GetAllCategory()
        {
            var categories = _context.DanhMucSanPhams.Select(x => new DanhMucSanPhamModel
            {
                TenDanhMuc = x.TenDanhMuc,
                MoTa = x.MoTa,
                TrangThai = x.TrangThai,

            });
            return categories.ToList();
        }

        public DanhMucSanPhamModel GetCategoryById(int id)
        {
            var category = _context.DanhMucSanPhams.FirstOrDefault(x => x.Id == id);
            if (category != null)
            {
                return new DanhMucSanPhamModel
                {
                    TenDanhMuc = category.TenDanhMuc,
                    MoTa = category.MoTa,
                    TrangThai = category.TrangThai,
                
                };

            }
            return null;
        }

        public List<SanPham> GetProductsByCategory(int categoryId)
        {
            var products = _context.SanPhams.Where(x => x.IdDanhMuc == categoryId).ToList();
            return products;
        } 
    }
}
