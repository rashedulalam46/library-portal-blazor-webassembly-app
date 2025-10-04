using LibraryPortalBlazorServerApp.Components.Models;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;

namespace LibraryPortalBlazorWebAssemblyApp.Services;

public class BookService
{
    private readonly HttpClient _http;
    private readonly string _baseUrl;

    public BookService(HttpClient http, IOptions<ApiSettings> options)
    {
        _http = http;
        _baseUrl = $"{options.Value.BaseUrl}/books";
    }

    public async Task<List<BookRead>> GetBooksAsync()
        => await _http.GetFromJsonAsync<List<BookRead>>(_baseUrl) ?? new List<BookRead>();

    public async Task<Book?> GetBookAsync(int id)
        => await _http.GetFromJsonAsync<Book>($"{_baseUrl}/{id}");

    public async Task<Book?> AddBookAsync(Book book)
    {
        var response = await _http.PostAsJsonAsync(_baseUrl, book);
        return await response.Content.ReadFromJsonAsync<Book>();
    }

    public async Task<Book?> UpdateBookAsync(Book book)
    {
        var response = await _http.PutAsJsonAsync($"{_baseUrl}/{book.book_id}", book);
        return await response.Content.ReadFromJsonAsync<Book>();
    }

    public async Task<bool> DeleteBookAsync(int id)
    {
        var response = await _http.DeleteAsync($"{_baseUrl}/{id}");
        return response.IsSuccessStatusCode;
    }
}