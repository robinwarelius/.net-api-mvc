using API.Models.Identity;
using System.ComponentModel.DataAnnotations;

namespace API.Models.DTO.Account
{
    public class RegisterUserRequestDTO
    {
        [Required]
        [MinLength(2, ErrorMessage = "Firstname must contain more than 2 characters")]
        public string FirstName { get; set; } = null!;


        [Required]
        [MinLength(2, ErrorMessage = "Lastname must contain more than 2 characters")]
        public string LastName { get; set; } = null!;


        [Required]
        [DataType(DataType.EmailAddress)]       
        public string Email { get; set; } = null!;


        [Required]
        [DataType(DataType.Password)]        
        public string Password { get; set; } = null!;


        [Required]
        [DataType(DataType.Password)]      
        [Compare(nameof(Password), ErrorMessage = $"{nameof(Password)} and {nameof(ConfirmPassword)} do not match")]
        public string ConfirmPassword { get; set; } = null!;


        public static implicit operator ApplicationUser (RegisterUserRequestDTO registerDTO)
        {
            return new ApplicationUser()
            {
                FirstName = registerDTO.FirstName,
                LastName = registerDTO.LastName,
                Email = registerDTO.Email,
                UserName = registerDTO.Email
            };
        }
    }
}
