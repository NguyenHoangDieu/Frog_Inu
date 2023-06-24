using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using WebApiEcommerceApp.Model.Abstract;

namespace WebApiEcommerceApp.Data
{
    [Table("SanPham")]
    public class SanPham : Auditable
    {
        [Key]
        public int Id { get; set; }
        public string TenSanPham { get; set; }
        public string MoTa { get;set; }
        public string SKU { get; set; }
        public decimal GiaSanPham { get;set; }
        public bool TrangThai { get; set; }
        public string Image { get; set; }
        public string MoreImages { get; set; }
        public int IdDanhMuc { get; set; }
        public int IdKhoHang { get; set; }
        public int? IdGiamGia { get; set; }

    }
}
