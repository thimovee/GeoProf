using System.ComponentModel.DataAnnotations;
namespace ProjectGeoProfs.Models
{
    public class Gebruiker
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string? VoorNaam { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string? Achternaam { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? Email { get; set; }
    }
}
