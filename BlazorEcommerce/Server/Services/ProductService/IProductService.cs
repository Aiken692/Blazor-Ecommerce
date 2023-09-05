﻿namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductListAsync();
        Task<ServiceResponse<Product>> GetProductAsync(Guid productId);

        Task<ServiceResponse<List<Product>>> GetProductsByCategoryUrlAsync(string categoryUrl);
    }
}
