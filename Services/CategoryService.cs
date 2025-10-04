using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryPortalBlazorServerApp.Components.Models;
using Microsoft.Extensions.Options;

namespace LibraryPortalBlazorServerApp.Components.Services
{
    public class CategoryService
    {
        private readonly HttpClient _http;
        private readonly string _baseUrl;

        public CategoryService(HttpClient http, IConfiguration config)
        {
            _http = http;
            _baseUrl = config["ApiSettings:BaseUrl"] + "/categories";
        }

        public async Task<List<Category>> GetCategoriesAsync()
            => await _http.GetFromJsonAsync<List<Category>>(_baseUrl) ?? new List<Category>();

        public async Task<Category?> GetCategoryAsync(int id)
            => await _http.GetFromJsonAsync<Category>($"{_baseUrl}/{id}");

        public async Task<Category?> AddCategoryAsync(Category category)
        {
            var response = await _http.PostAsJsonAsync(_baseUrl, category);
            return await response.Content.ReadFromJsonAsync<Category>();
        }

        public async Task<Category?> UpdateCategoryAsync(Category category)
        {
            var response = await _http.PutAsJsonAsync($"{_baseUrl}/{category.category_id}", category);
            return await response.Content.ReadFromJsonAsync<Category>();
        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            var response = await _http.DeleteAsync($"{_baseUrl}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}