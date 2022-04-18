using GoodsAndServices.Models.InputModels;

namespace GoodsAndServices.Models
{
    public class Product
    {
        public Product()
        {

        }

        public Product(ProductInputDTO entity)
        {
            Name = entity.Name;
            Description = entity.Description;
            ImageLink = entity.ImageLink;
            Price = entity.Price;
            CategoryId = entity.CategoryId;
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }   
        public string? ImageLink { get; set; }   
        public long? Price { get; set; }
        public long CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
