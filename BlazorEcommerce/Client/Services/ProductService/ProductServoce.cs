﻿namespace BlazorEcommerce.Client.Services.ProductService
{
    public class ProductServoce : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductServoce(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<Product> Products { get; set; } = new List<Product>();
        public string Message { get; set; }

        public event Action ProductsChanged;

       

        public async Task<ServiceResponse<Product>?> GetProduct(int productId)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"api/products/{productId}");

            return result;
        }

        public async Task GetProducts(string? categoryUrl)
        {
            var result = categoryUrl == null ? await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/products/featured") : await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/products/category/{categoryUrl}");

            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }

            ProductsChanged.Invoke();
        }

        public async Task<List<string>> GetProductSearchSuggestions(string searchText)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<string>>>($"api/products/searchsuggestions/{searchText}");

            return result.Data;
        }

        public async Task SearchProducts(string searchText)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/products/search/{searchText}");

            if(result != null && result.Data != null)
            {
                Products = result.Data;
            }

            if (Products.Count == 0) Message = "No products found";

            ProductsChanged?.Invoke();
        }
    }
}
