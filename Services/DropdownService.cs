using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryPortalBlazorServerApp.Models;

namespace LibraryPortalBlazorServerApp.Services;

public class DropdownService
{
    private readonly HttpClient _http;
    private readonly string _baseUrl;

    public DropdownService(HttpClient http, IConfiguration config)
    {
        _http = http;
        _baseUrl = config["ApiSettings:BaseUrl"] + "/dropdown";
    }

    public async Task<List<DropdownItem>> GetCategoriesAsync()
        => await _http.GetFromJsonAsync<List<DropdownItem>>($"{_baseUrl}/categories") ?? new List<DropdownItem>();      

    public async Task<List<DropdownItem>> GetAuthorsAsync()
        => await _http.GetFromJsonAsync<List<DropdownItem>>($"{_baseUrl}/authors") ?? new List<DropdownItem>();

    public async Task<List<DropdownItem>> GetPublishersAsync()
        => await _http.GetFromJsonAsync<List<DropdownItem>>($"{_baseUrl}/publishers") ?? new List<DropdownItem>();

    public async Task<List<DropdownItem>> GetCountriesAsync()
        => await _http.GetFromJsonAsync<List<DropdownItem>>($"{_baseUrl}/countries") ?? new List<DropdownItem>();

}