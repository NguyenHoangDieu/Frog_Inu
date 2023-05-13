using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiEcommerceApp.Model.Abstract;

namespace WebApiEcommerceApp.Data
{
    [Table("DatHang")]
    public class DatHang : Auditable
    {
        [Key]
        public int Id { get; set; }
        public int IdChiTietDH { get; set; }
        public int IdSanPham { get;set; }
        public bool TrangThai { get; set; }
        [ForeignKey("IdChiTietDH")]
        public virtual ChiTietDatHang ChiTietDatHang { set; get; }
        [ForeignKey("IdSanPham")]
        public virtual SanPham SanPham { set; get; }

    }
}
