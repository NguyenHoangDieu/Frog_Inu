using System.ComponentModel.DataAnnotations;

namespace EcommerceApiWeb.Models
{
    public class UserModel
    {
        public int? Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string UserMessage { get; set; }
        public string AccessToken { get; set; }

    }
}
