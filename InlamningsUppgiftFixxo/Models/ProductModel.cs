

using API.Models.Entities;

namespace InlamningsUppgiftFixxo.Models
{
    public class ProductModel
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
        public CategoryModel? Category { get; set; }

    }
}
