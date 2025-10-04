using System.ComponentModel.DataAnnotations;

namespace LibraryPortalBlazorWebAssemblyApp.Models;

public class Author
{
    public int author_id { get; set; }

    [Required(ErrorMessage = "Author name is required.")]
    [StringLength(100, ErrorMessage = "Author name cannot exceed 100 characters.")]
    public string author_name { get; set; }

    [Required(ErrorMessage = "Country is required.")]
    [StringLength(2, ErrorMessage = "Country cannot exceed 2 characters.")]
    public string? country { get; set; }

    [Required(ErrorMessage = "Address is required.")]
    [StringLength(250, ErrorMessage = "Address cannot exceed 250 characters.")]
    public string? address { get; set; }

    [Required(ErrorMessage = "Phone number is required.")]
    [StringLength(100, ErrorMessage = "Phone number cannot exceed 100 characters.")]
    [Phone(ErrorMessage = "Invalid phone number format.")]
    public string? phone { get; set; }

    [EmailAddress(ErrorMessage = "Invalid email address format.")]
    [StringLength(200, ErrorMessage = "Email cannot exceed 200 characters.")]
    public string? email { get; set; }

    public DateTime? create_date { get; set; }

    public bool active { get; set; }
}