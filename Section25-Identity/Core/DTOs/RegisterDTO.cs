
using Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Core.DTOs
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "{0} can't be empty")]
        [EmailAddress(ErrorMessage = "{0} is not in the correct format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} can't be empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} can't be empty")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "{0} should contain only numbers")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "{0} can't be empty")]
        public string Password { get; set; }

        [Required(ErrorMessage = "{0} can't be empty")]
        public string ConfirmPassword { get; set; }

        public UserTypeOptions UserType { get; set; } = UserTypeOptions.User;
    }
}
