

using System.ComponentModel.DataAnnotations;

namespace Core.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "{0} can't be empty")]
        [EmailAddress(ErrorMessage = "Incorrect {0} format")]
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} can't be empty")]
        public string Password { get; set; }
    }
}
