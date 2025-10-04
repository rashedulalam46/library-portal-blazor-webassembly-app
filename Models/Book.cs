using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryPortalBlazorWebAssemblyApp.Models;

public class Book
{

    public int book_id { get; set; }

    [Required(ErrorMessage = "Title is required.")]
    [StringLength(100, ErrorMessage = "Title cannot exceed 200 characters.")]
    public string? title { get; set; }

    [StringLength(250, ErrorMessage = "Description cannot exceed 1000 characters.")]
    public string? description { get; set; }

    [Required(ErrorMessage = "Author is required.")]
    public int? author_id { get; set; }

    [Required(ErrorMessage = "Category is required.")]
    public int? category_id { get; set; }

    [Required(ErrorMessage = "Publisher is required.")]
    public int? publisher_id { get; set; }

    [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
    public DateTime? publish_date { get; set; }


    [StringLength(20, ErrorMessage = "ISBN cannot exceed 20 characters.")]
    public string? isbn { get; set; }

    [Range(0, 10000, ErrorMessage = "Price must be between 0 and 10,000.")]
    public decimal? price { get; set; }

    [DefaultValue(true)]
    public bool active { get; set; }
}

// DTO for reading/fetching book data
public class BookRead
{
    public int book_id { get; set; }

    public string? title { get; set; }

    public string? description { get; set; }

    public int? author_id { get; set; }

    public int? category_id { get; set; }

    public int? publisher_id { get; set; }


    public DateTime? publish_date { get; set; }

    public string? isbn { get; set; }

    public decimal? price { get; set; }

    public bool active { get; set; }

    public DateTime? create_date { get; set; }

    // Optional related names
    public string? author_name { get; set; }

    public string? category_name { get; set; }

    public string? publisher_name { get; set; }
}
