using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiEcommerceApp.Data
{
    [Table("DiaChiUser")]
    public class DiaChiUser
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string DiaChi { get; set; }
        public string ThanhPho { get;set; }
        public string DienThoai { get; set; }
        public string GhiChu { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { set; get; }

    }
}
