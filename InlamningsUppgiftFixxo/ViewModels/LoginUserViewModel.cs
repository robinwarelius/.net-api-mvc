using System.ComponentModel.DataAnnotations;

namespace InlamningsUppgiftFixxo.ViewModels
{
    public class LoginUserViewModel
    {
        [Required(ErrorMessage = "Email field can't be blank")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Password field can't be blank")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
