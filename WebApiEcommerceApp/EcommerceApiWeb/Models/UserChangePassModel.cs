using System.ComponentModel.DataAnnotations;

namespace EcommerceApiWeb.Models
{
    public class UserChangePassModel
    {
        [Required]
        public string OldPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
        [Required]
        public string ConfirmPassword { get; set;}
    }
}
