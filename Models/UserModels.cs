using System.ComponentModel.DataAnnotations;

namespace JWT_API.Models
{
    public class UserModels
    {
        [Required]

        public string UserName { get; set; }

        [Required]

        public string Password { get; set; }

        [Required]

        public string Email { get; set; }

        [Required]

        public string Rol { get; set; }

        [Required]

        public string FirstName { get; set; }

        [Required]

        public string LastName { get; set; }

    }
}
