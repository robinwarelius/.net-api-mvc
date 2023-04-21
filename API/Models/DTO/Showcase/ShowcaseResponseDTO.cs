using API.Models.Entities;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace API.Models.DTO.Showcase
{
    public class ShowcaseResponseDTO
    {
        public string? Title { get; set; }
        public string? Ingress { get; set; }
        public string? DeliveryText { get; set; }
        public string? ButtonText { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime? Date { get; set; }
    }

    public static class ShowcaseEntityExtension 
    {
        public static ShowcaseResponseDTO ToShowcase(this ShowcaseEntity showcase)
        {
            return new ShowcaseResponseDTO()
            {
                Title = showcase.Title,
                Ingress = showcase.Ingress,
                DeliveryText = showcase.DeliveryText,
                ButtonText = showcase.ButtonText,
                ImageUrl = showcase.ImageUrl,
                Date = showcase.Date
            };
        }

    }
}
