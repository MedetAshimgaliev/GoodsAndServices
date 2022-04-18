namespace GoodsAndServices.Models.InputModels
{
    public class ProductInputDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageLink { get; set; }
        public long? Price { get; set; }
        public long CategoryId { get; set; }
    }
}
