using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryPortalBlazorWebAssemblyApp.Models;

public class Publisher
{
	public int publisher_id { get; set; }


	[Required(ErrorMessage = "Publisher name is required.")]
	[StringLength(100, ErrorMessage = "Publisher name cannot exceed 100 characters.")]
	public string? publisher_name { get; set; }

	[Required(ErrorMessage = "Address is required.")]
	[StringLength(250, ErrorMessage = "Address cannot exceed 250 characters.")]
	public string? address { get; set; }

	[Required(ErrorMessage = "Phone number is required.")]
	[Phone(ErrorMessage = "Invalid phone number format.")]
	[StringLength(20, ErrorMessage = "Phone number cannot exceed 20 characters.")]
	public string? phone { get; set; }

	[EmailAddress(ErrorMessage = "Invalid email address format.")]
	[StringLength(200, ErrorMessage = "Email cannot exceed 200 characters.")]
	public string? email { get; set; }

	public DateTime? create_date { get; set; }

	public bool active { get; set; }
}