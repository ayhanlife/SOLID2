namespace SOLID2.Core.DTOs
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }


        public int CategoryId { get; set; }
    }
}
