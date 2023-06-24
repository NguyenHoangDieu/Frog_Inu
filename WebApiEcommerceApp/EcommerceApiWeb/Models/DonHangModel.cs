using System.ComponentModel.DataAnnotations;

namespace EcommerceApiWeb.Models
{
    public class DonHangModel
    {
        public int Id { get; set; }
        public List<SanPhamDonHang> SanPham { get; set; }
        public long IdUser { get; set; }
        public DateTime? NgayMua { get; set; }
        public string TypeNhanHang { get; set; }
        public string TypeThanhToan { get; set; }
        public string TrangThai { get; set; }
        public string DiaDiemNhanHang { get; set; }
        public decimal GiaTamTinh { get; set; }
        public decimal GiaDonHang { get; set; }
        public long? IdKhoHang { get; set; }
    }

    public class SanPhamDonHang
    {
        public long IdGioHang { get; set; }
        public int IdSanPham { get; set; }
        public int SoLuong { get; set; }

    }
}
