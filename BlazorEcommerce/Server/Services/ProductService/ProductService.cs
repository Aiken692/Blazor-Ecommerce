namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _dbContext;

        public ProductService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ServiceResponse<List<Product>>> GetProductListAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _dbContext.Products.ToListAsync() 
            };

            return response;
        }
    }
}
