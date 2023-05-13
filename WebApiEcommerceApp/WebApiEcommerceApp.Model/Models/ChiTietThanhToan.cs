using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiEcommerceApp.Model.Abstract;

namespace WebApiEcommerceApp.Data
{
    [Table("ChiTietThanhToan")]
    public class ChiTietThanhToan : Auditable
    {
        [Key]
        public int Id { get; set; }
        public int IdChiTietDH { get; set; }
        public int SoLuong { get; set; }
        [StringLength(50)]
        public string NhaCungCap { get;set; }
        public string TrangThai { get; set; }
        [ForeignKey("IdChiTietDH")]
        public virtual ChiTietDatHang ChiTietDatHang { set; get; }
    }
}
