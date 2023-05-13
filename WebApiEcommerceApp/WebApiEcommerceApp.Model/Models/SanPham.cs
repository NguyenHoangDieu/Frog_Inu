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
        [Required]
        [StringLength(250)]
        public string? TenSanPham { get; set; }
        [StringLength(500)]
        public string? MoTa { get;set; }
        [StringLength(50)]
        public string? SKU { get; set; }
        [Required]
        public double GiaSanPham { get;set; }
        [Required]
        public bool TrangThai { get; set; }
        public string? Image { get; set; }
        public string? MoreImage { get; set; }
        public long IdDanhMuc { get; set; }
        public long IdKhoHang { get; set; }
        public long IdGiamGia { get; set; }

        //[ForeignKey("IdDanhMuc")]
        //public virtual DanhMucSanPham DanhMucSanPham { set; get; }
        //[ForeignKey("IdKhoHang")]
        //public virtual KhoHang KhoHang { set; get; }
        //[ForeignKey("IdGiamGia")]
        //public virtual GiamGia GiamGia { set; get; }

    }
}
