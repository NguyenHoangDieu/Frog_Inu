using EcommerceApiWeb.Data.Entity;
using WebApiEcommerceApp.Data;

namespace EcommerceApiWeb.Models
{
    public class DonHangDto : DonHang
    {
        public List<ChiTietDonHang> ChiTietDonHang { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    }

    public class ChiTietDonhangDto : ChiTietDonHang
    {
        public SanPham sanpham { get; set; }
    }
}
