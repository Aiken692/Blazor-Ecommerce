﻿namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        string Message { get; set; }

        List<Product> Products { get; set; }

        Task GetProducts(string? categoryUrl);

        Task<ServiceResponse<Product>> GetProduct(int productId);

        Task SearchProducts(string searchText);
        Task<List<string>> GetProductSearchSuggestions(string searchText);
    }
}
