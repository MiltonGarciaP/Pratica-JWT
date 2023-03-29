using System.ComponentModel.DataAnnotations;

namespace JWT_API.Models
{
    public class LoginUser
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
