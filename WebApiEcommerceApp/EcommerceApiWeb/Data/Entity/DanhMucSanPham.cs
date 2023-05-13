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
        public string TenDanhMuc { get; set; }
        public string MoTa { get; set; }
        public bool TrangThai { get; set; }

    }
}
