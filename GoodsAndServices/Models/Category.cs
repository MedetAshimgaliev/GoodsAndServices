using GoodsAndServices.Models.InputModels;

namespace GoodsAndServices.Models
{
    public class Category
    {
        public Category()
        {

        }

        public Category(CategoryInputDTO entity)
        {
            Name = entity.Name;
            Size = entity.Size;
            Weight = entity.Weight;
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Size { get; set; }
        public long? Weight { get; set; }
        public List<Product>? Products { get; set; }
    }
}
