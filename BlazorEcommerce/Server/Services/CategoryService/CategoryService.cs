using BlazorEcommerce.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Category>> GetCategoryAsync(Guid categoryId)
        {
            var response = new ServiceResponse<Category>();
            var category = await _context.Categories.FindAsync(categoryId);

            if (category == null)
            {
                response.Success = false;
                response.Message = "Sorry, but this category does not exist";
            }
            else
            {
                response.Data = category;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategoryListAsync()
        {
            var categories = await _context.Categories.ToListAsync();

            return new ServiceResponse<List<Category>>
            {
                Data = categories
            };
        }
    }
}
