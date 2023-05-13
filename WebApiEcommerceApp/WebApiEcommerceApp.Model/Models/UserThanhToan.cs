using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiEcommerceApp.Data
{
    [Table("UserThanhToan")]
    public class UserThanhToan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string PhuongThucThanhToan { get; set; }
        public DateTime HetHan { get; set; }

    }
}
