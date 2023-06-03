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
        public List<DanhMucSanPham> GetAllCategory()
        {
            var categories = _context.DanhMucSanPhams.Select(x => new DanhMucSanPham
            {
                Id = x.Id,
                TenDanhMuc = x.TenDanhMuc,
                MoTa = x.MoTa,
                TrangThai = x.TrangThai,
                Created_at = x.Created_at,

            });
            return categories.ToList();
        }

        public DanhMucSanPham GetCategoryById(int id)
        {
            var category = _context.DanhMucSanPhams.FirstOrDefault(x => x.Id == id);
            if (category != null)
            {
                return new DanhMucSanPham
                {
                    Id = category.Id,
                    TenDanhMuc = category.TenDanhMuc,
                    MoTa = category.MoTa,
                    TrangThai = category.TrangThai,
                    Created_at = category.Created_at,
                
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
