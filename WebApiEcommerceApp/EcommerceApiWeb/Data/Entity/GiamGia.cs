using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiEcommerceApp.Model.Abstract;

namespace WebApiEcommerceApp.Data
{
    [Table("GiamGia")]
    public class GiamGia : Auditable
    {
        [Key]
        public int Id { get; set; }
        public string TenMaGiamGia { get; set; }
        public string MoTa { get; set; }
        public double PhanTramGiamGia { get;set; }
        public bool isActive { get; set; }

    }
}
