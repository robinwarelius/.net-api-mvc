using System.ComponentModel.DataAnnotations;

namespace API.Models.Entities
{
    public class ShowcaseEntity
    {
        [Key]
        public Guid? ShowcaseId { get; set; }   
        public string? Title { get; set; }
        public string? Ingress { get; set; }
        public string? DeliveryText { get; set; }
        public string? ButtonText { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime? Date { get; set; }
    }
}
