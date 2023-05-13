using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiEcommerceApp.Model.Abstract;

namespace WebApiEcommerceApp.Data
{
    [Table("KhoHang")]
    public class KhoHang : Auditable
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SoLuong { get; set; }
        [Required]
        public bool TrangThai { get; set; }
    }
}
