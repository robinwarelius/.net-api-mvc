using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace API.Models.Entities
{
    public class ContactEntity
    {
        [Key]
        public Guid? ContactId { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Comment { get; set; }
    }
}
