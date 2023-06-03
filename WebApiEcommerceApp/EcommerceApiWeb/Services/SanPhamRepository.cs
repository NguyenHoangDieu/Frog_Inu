using EcommerceApiWeb.Data.Entity;
using EcommerceApiWeb.Models;

namespace EcommerceApiWeb.Services
{
    public class SanPhamRepository : ISanPhamRepository
    {
        private readonly EcommerceAppDbContext _context;

        public SanPhamRepository(EcommerceAppDbContext context) 
        {
            _context = context;
        }
        public List<SanPhamModel> GetAllProduct()
        {
            var products = _context.SanPhams.Select(x => new SanPhamModel
            {
                TenSanPham = x.TenSanPham,
                MoTa = x.MoTa,
                GiaSanPham = x.GiaSanPham,
                IdDanhMuc = x.IdDanhMuc,
                IdGiamGia = x.IdGiamGia,
                IdKhoHang = x.IdKhoHang,

            });
            return products.ToList();
        }

        public SanPhamModel GetProductById(int id)
        {
            var product = _context.SanPhams.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                return new SanPhamModel
                {
                    TenSanPham = product.TenSanPham,
                    MoTa = product.MoTa,
                    GiaSanPham= product.GiaSanPham,
                    IdKhoHang= product.IdKhoHang,
                    IdDanhMuc= product.IdDanhMuc,
                    IdGiamGia = product.IdGiamGia,
                };
          
            }
            return null;
        }
    }
}
