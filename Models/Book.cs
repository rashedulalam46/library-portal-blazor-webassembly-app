using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryPortalBlazorServerApp.Components.Models;

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
    public string? ISBN { get; set; }

    [Range(0, 10000, ErrorMessage = "Price must be between 0 and 10,000.")]
    public decimal price { get; set; }

    public bool active { get; set; }
}

// DTO for reading/fetching book data
public class BookRead
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int? AuthorId { get; set; }
    public int? CategoryId { get; set; }
    public int? PublisherId { get; set; }
    public DateTime? PublishDate { get; set; }
    public string ISBN { get; set; }
    public decimal Price { get; set; }
    public bool Active { get; set; }
    public DateTime? CreateDate { get; set; }

    // Optionally: if you want to return related names
    public string AuthorName { get; set; }
    public string CategoryName { get; set; }
    public string PublisherName { get; set; }
}
