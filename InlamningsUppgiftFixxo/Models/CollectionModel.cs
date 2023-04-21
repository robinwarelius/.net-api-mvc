

using API.Models.Entities;

namespace InlamningsUppgiftFixxo.Models
{
    public class CollectionModel
    {
        public string? Title { get; set; }
        public CategoryModel? Category { get; set; }
        public List <ProductModel>? CollectionItemModel { get; set; }
    }
}
