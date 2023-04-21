
using API.Models.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Entities
{
    public class ProductEntity
    {
        [Key]
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

        [ForeignKey(nameof(CategoryId))]
        public Guid? CategoryId { get; set; }
        public CategoryEntity? Category { get; set; }


      
        
    }
}
