using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _dbContext;

        public ProductService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ServiceResponse<List<Product>>> GetFeaturedProducts()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _dbContext.Products.Where(p => p.Featured == true).Include(v => v.Variants).ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();

            var product = await _dbContext.Products
                .Include(v => v.Variants)
                .ThenInclude(t => t.ProductType)
                .FirstOrDefaultAsync(p => p.Id == productId);

            if (product == null)
            {
                response.Success = false;
                response.Message = "Sorry, but this product does not exist";
            }
            else
            {
                response.Data = product;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductListAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _dbContext.Products
                .Include(v => v.Variants)
                .ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategoryUrlAsync(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _dbContext.Products
                .Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                .Include(v => v.Variants)
                .ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText)
        {
            var products = await FindProductsBySearchText(searchText);

            List<string> results = new List<string>();

            foreach (var product in products)
            {
                if(product.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(product.Title);
                }

                if(product.Description != null)
                {
                    var punctuation = product.Description.Where(char.IsPunctuation)
                        .Distinct().ToArray();

                    var words = product.Description.Split().Select(s => s.Trim(punctuation));

                    foreach (var word in words)
                    {
                        if (word.Contains(searchText, StringComparison.OrdinalIgnoreCase) && !results.Contains(word))
                        {
                            results.Add(word);
                        }
                    }
                }
            }

            return new ServiceResponse<List<string>> { Data = results };
        }

        public async Task<ServiceResponse<ProductSearchResult>> SearchProducts(string searchText, int page)
        {
            var pageResults = 2f;
            var pageCount = Math.Ceiling((await FindProductsBySearchText(searchText)).Count / pageResults);
            var products = await _dbContext.Products
                            .Where(p => p.Title.ToLower().Contains(searchText.ToLower())
                            ||
                            p.Description.ToLower().Contains(searchText.ToLower()))
                            .Include(v => v.Variants)
                            .Skip((page - 1) * (int)pageResults)
                            .Take((int)pageResults)
                            .ToListAsync();

            var response = new ServiceResponse<ProductSearchResult>
            {
                Data = new ProductSearchResult
                {
                    Products = products,
                    CurrentPage = page,
                    Pages = (int)pageCount
                }
            };

            return response;
        }

        private async Task<List<Product>> FindProductsBySearchText(string searchText)
        {
            return await _dbContext.Products
                            .Where(p => p.Title.ToLower().Contains(searchText.ToLower())
                            ||
                            p.Description.ToLower().Contains(searchText.ToLower()))
                            .Include(v => v.Variants)
                            .ToListAsync();
        }
    }
}
