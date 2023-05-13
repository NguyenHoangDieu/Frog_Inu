using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiEcommerceApp.Model.Abstract;

namespace WebApiEcommerceApp.Data
{
    [Table("ChiTietDatHang")]
    public class ChiTietDatHang : Auditable
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public double Total { get; set; }
        public int IdThanhToan { get; set; }
        public bool TrangThai { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { set; get; }
    }
}
