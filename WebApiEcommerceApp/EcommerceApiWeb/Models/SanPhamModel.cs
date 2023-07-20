using System.ComponentModel.DataAnnotations;

namespace EcommerceApiWeb.Models
{
    public class SanPhamModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string TenSanPham { get; set; }
        [StringLength(500)]
        public string MoTa { get; set; }
        [Required]
        public decimal GiaSanPham { get; set; }
        [Required]
        public int IdDanhMuc { get; set; }
        public int IdKhoHang { get; set; }
        public int? IdGiamGia { get; set; }
        public string Image { get;set; }
    }
}
