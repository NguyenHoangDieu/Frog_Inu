using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiEcommerceApp.Data
{
    public class SanPham
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(256)]
        public string TenSanPham { get; set; }
        public string MoTa { get; set; }
        public string SKU { get; set; }
        public double GiaSanPham { get;set; }
        public int IdDanhMuc { get; set; }
        public int IdKhoHang { get; set; }
        public int IdGiamGia { get; set; }

    }
}
