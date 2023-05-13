using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiEcommerceApp.Model.Abstract;

namespace WebApiEcommerceApp.Data
{
    [Table("GioHang")]
    public class GioHang : Auditable
    {
        [Key]
        public int Id { get; set; }
        public int IdPhienMuaSam { get; set; }
        public int IdSanPham { get; set; }
        public int SoLuong { get; set; }
        public bool TrangThai { get; set; }
        [ForeignKey("IdPhienMuaSam")]
        public virtual PhienMuaSam PhienMuaSam { set; get; }
        [ForeignKey("IdSanPham")]
        public virtual SanPham SanPham { set; get; }

    }
}
