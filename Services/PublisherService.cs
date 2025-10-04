using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryPortalBlazorServerApp.Components.Models;
using Microsoft.Extensions.Options;

namespace LibraryPortalBlazorWebAssemblyApp.Services;

public class PublisherService
{
  private readonly HttpClient _http;
        private readonly string _baseUrl;

        public PublisherService(HttpClient http, IConfiguration config)
        {
            _http = http;
            _baseUrl = config["ApiSettings:BaseUrl"] + "/publishers";
        }

        public async Task<List<Publisher>> GetPublishersAsync()
            => await _http.GetFromJsonAsync<List<Publisher>>(_baseUrl) ?? new List<Publisher>();

        public async Task<Publisher?> GetPublisherAsync(int id)
            => await _http.GetFromJsonAsync<Publisher>($"{_baseUrl}/{id}");

        public async Task<Publisher?> AddPublisherAsync(Publisher publisher)
        {
            var response = await _http.PostAsJsonAsync(_baseUrl, publisher);
            return await response.Content.ReadFromJsonAsync<Publisher>();
        }

        public async Task<Publisher?> UpdatePublisherAsync(Publisher publisher)
        {
            var response = await _http.PutAsJsonAsync($"{_baseUrl}/{publisher.publisher_id}", publisher);
            return await response.Content.ReadFromJsonAsync<Publisher>();
        }

        public async Task<bool> DeletePublisherAsync(int id)
        {
            var response = await _http.DeleteAsync($"{_baseUrl}/{id}");
            return response.IsSuccessStatusCode;
        }
    
}