using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiEcommerceApp.Model.Abstract;

namespace EcommerceApiWeb.Data.Entity
{
    [Table("DonHang")]
    public class DonHang : Auditable
    {
        [Key]
        public int Id { get; set; }
        public long IdUser { get; set; }
        public DateTime? NgayMua { get; set; }
        public string TypeNhanHang { get; set; }
        public string TypeThanhToan { get; set; }
        public string TrangThai { get; set; }
        public string DiaDiemNhanHang { get; set; }
        public decimal GiaTamTinh { get; set; }
        public decimal GiaDonHang { get; set; }
        public long? IdKhoHang { get; set; }
    }
}
