using System.ComponentModel.DataAnnotations;

namespace API.Models.DTO.Contact
{
    public class ContactAddRequestDTO
    {
        [Required]
        public string Name { get; set; } = null!;

        [EmailAddress]
        public string Email { get; set; } = null!;
        public string? Comment { get; set; }
    }
}
