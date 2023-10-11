namespace BlazorEcommerce.Shared
{
    public class ProductVariant
    {
        public int ProductTypeId { get; set; }
        public ProductType? ProductType { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public double OriginalPrice { get; set; }
        public double Price { get; set; }
    }
}
