using System.ComponentModel.DataAnnotations;

namespace LibraryPortalBlazorServerApp.Components.Models;

public class Category
{
    public int category_id { get; set; }

    [Required(ErrorMessage = "Category name is required.")]
    [StringLength(100, ErrorMessage = "Category name cannot exceed 100 characters.")]
    public string? category_name { get; set; }

    [Required(ErrorMessage = "Description is required.")]
    [StringLength(250, ErrorMessage = "Description cannot exceed 250 characters.")]
    public string? description { get; set; }
    public DateTime? create_date { get; set; }
    public bool active { get; set; }
}