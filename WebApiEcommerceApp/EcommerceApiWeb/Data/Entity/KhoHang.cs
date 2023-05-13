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
        public int SoLuong { get; set; }
        public bool TrangThai { get; set; }
    }
}
