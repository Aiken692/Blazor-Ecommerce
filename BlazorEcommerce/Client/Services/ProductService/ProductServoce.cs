

namespace BlazorEcommerce.Client.Services.ProductService
{
    public class ProductServoce : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductServoce(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public async Task GetProducts()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/products");

            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }
        }

    }
}
