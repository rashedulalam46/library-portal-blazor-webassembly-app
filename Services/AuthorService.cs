using System.Net.Http.Json;
using LibraryPortalBlazorServerApp.Components.Models;
using Microsoft.Extensions.Options;

namespace LibraryPortalBlazorWebAssemblyApp.Services;

public class AuthorService
{
    private readonly HttpClient _http;
    private readonly string _baseUrl;

    public AuthorService(HttpClient http, IConfiguration config)
    {
        _http = http;
        _baseUrl = config["ApiSettings:BaseUrl"] + "/authors";
    }

    public async Task<List<Author>> GetAuthorsAsync()
        => await _http.GetFromJsonAsync<List<Author>>(_baseUrl) ?? new List<Author>();

    public async Task<Author?> GetAuthorAsync(int id)
        => await _http.GetFromJsonAsync<Author>($"{_baseUrl}/{id}");

    public async Task<Author?> AddAuthorAsync(Author author)
    {
        var response = await _http.PostAsJsonAsync(_baseUrl, author);
        return await response.Content.ReadFromJsonAsync<Author>();
    }

    public async Task<Author?> UpdateAuthorAsync(Author author)
    {
        var response = await _http.PutAsJsonAsync($"{_baseUrl}/{author.author_id}", author);
        return await response.Content.ReadFromJsonAsync<Author>();
    }

    public async Task<bool> DeleteAuthorAsync(int id)
    {
        var response = await _http.DeleteAsync($"{_baseUrl}/{id}");
        return response.IsSuccessStatusCode;
    }
}