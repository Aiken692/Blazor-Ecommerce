namespace BlazorEcommerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Category> Categories { get; set; } = new List<Category>();

        public async Task GetCategories()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");

            if (result != null && result.Data != null)
            {
                Categories = result.Data;
            }
        }

        public async Task<ServiceResponse<Category>> GetCategory(Guid categoryId)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Category>>($"api/category/{categoryId}");

            return result;
        }
    }
}
