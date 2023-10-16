namespace BlazorEcommerce.Shared
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public Order? Order { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType? ProductType { get; set; }
        public double Quantity { get; set; }
        public double TotalPrice  { get; set; }
    }
}
