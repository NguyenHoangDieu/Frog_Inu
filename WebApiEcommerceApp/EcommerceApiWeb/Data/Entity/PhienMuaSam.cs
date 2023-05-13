using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiEcommerceApp.Model.Abstract;

namespace WebApiEcommerceApp.Data
{
    [Table("PhienMuaSam")]
    public class PhienMuaSam : Auditable
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public double Total { get; set; }
        public bool TrangThai { get; set; }
    }
}
