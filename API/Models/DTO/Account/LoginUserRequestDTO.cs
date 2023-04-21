using API.Models.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace API.Models.DTO.Account
{
    public class LoginUserRequestDTO
    {
        
        [EmailAddress]
        public string Email { get; set; } = null!;

        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        public static implicit operator ApplicationUser (LoginUserRequestDTO dto)
        {
            return new ApplicationUser()
            {
                Email = dto.Email,
                UserName = dto.Email
            };
        }
    }
}
