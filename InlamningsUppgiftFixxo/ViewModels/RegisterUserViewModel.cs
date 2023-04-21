using System.ComponentModel.DataAnnotations;

namespace InlamningsUppgiftFixxo.ViewModels
{
    public class RegisterUserViewModel
    {

        [Required(ErrorMessage = "Firstname field can't be empty ")]
        [MinLength(2, ErrorMessage = "Firstname must contain more than 2 characters")]
        public string FirstName { get; set; } = null!;


        [Required(ErrorMessage = "Lastname field can't be empty ")]
        [MinLength(2, ErrorMessage = "Firstname must contain more than 2 characters")]
        public string LastName { get; set; } = null!;


        [Required]
        [DataType(DataType.EmailAddress)]      
        public string Email { get; set; } = null!;


        [Required]
        [DataType(DataType.Password)]      
        public string Password { get; set; } = null!;


        [Required]
        [DataType(DataType.Password)]      
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = null!;

    }
}
