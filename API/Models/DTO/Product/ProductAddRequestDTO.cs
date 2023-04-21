using API.Models.Entities;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.DTO.Product
{
    public class ProductAddRequestDTO
    {
        [Required]
        public string? Title { get; set; }

        [Required]
        public double? Price { get; set; }

        [Required]
        public int? Rating { get; set; }

        [Required]
        public string? ImageUrl { get; set; }

        [Required]
        public string? Details { get; set; }

        [Required]
        public int? SKU { get; set; }

        [Required]
        public string? Brand { get; set; }

        [Required]
        public DateTime? Date { get; set; }

        [Required]
        public string? Color { get; set; }

        [Required]
        public Guid? CategoryId { get; set; }



        public ProductEntity ToProduct()
        {
            return new ProductEntity()
            {
                Title = this.Title,
                Price = this.Price,
                Rating = this.Rating,
                ImageUrl = this.ImageUrl,
                Details = this.Details,
                SKU = this.SKU,
                Brand = this.Brand,
                Date = this.Date,
                Color = this.Color,
                CategoryId = this.CategoryId,
            };
        }

    }
}
