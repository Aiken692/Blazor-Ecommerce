namespace BlazorEcommerce.Shared
{
    public class CartProductResponse
    {
        public int ProductId { get; set; }
        public string? Titile { get; set; }
        public int ProductTypeId { get; set; }
        public string? ProductType { get; set; }
        public string? ImageUrl { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
