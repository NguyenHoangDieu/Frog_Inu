using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiEcommerceApp.Model.Abstract;

namespace WebApiEcommerceApp.Data
{
    [Table("DanhMucSanPham")]
    public class DanhMucSanPham : Auditable
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string TenDanhMuc { get; set; }
        public string MoTa { get; set; }
        [Required]
        public bool TrangThai { get; set; }

    }
}
