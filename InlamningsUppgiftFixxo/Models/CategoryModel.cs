using System.ComponentModel.DataAnnotations;

namespace API.Models.Entities
{
    public class CategoryModel
    {



        [Key]
        public Guid? CategoryId { get; set; }
        public string? CategoryName { get; set; }
    }
}
