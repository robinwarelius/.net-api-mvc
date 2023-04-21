using API.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.DTO.Product
{
    public class ProductResponseDTO
    {
        public Guid? ProductId { get; set; }
        public string? Title { get; set; }
        public double? Price { get; set; }
        public int? Rating { get; set; }
        public string? ImageUrl { get; set; }
        public string? Details { get; set; }
        public int? SKU { get; set; }
        public string? Brand { get; set; }
        public DateTime? Date { get; set; }
        public string? Color { get; set; }
        public Guid? CategoryId { get; set; }
        public CategoryEntity? Category { get; set; }

    }

    public static class ProductEntityExtension
    {
        public static ProductResponseDTO ToProductResponse(this ProductEntity product)
        {
            return new ProductResponseDTO()
            {
                ProductId = product.ProductId,
                Title = product.Title,
                Price = product.Price,
                Rating = product.Rating,
                ImageUrl = product.ImageUrl,
                Details = product.Details,
                SKU = product.SKU,
                Brand = product.Brand,
                Date = product.Date,
                Color = product.Color,
                CategoryId = product.CategoryId,
                Category = product.Category
            };
        }


    }
}
