using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiEcommerceApp.Data;

namespace EcommerceApiWeb.Data.Entity

{
    [Table("ChiTietDonHang")]
    public class ChiTietDonHang
    {
        [Key]
        public int Id { get; set; }
        public int IdDonHang { get; set; }
        public int IdSanPham { get; set; }
        public int SoLuong { get; set; }
    }
}
