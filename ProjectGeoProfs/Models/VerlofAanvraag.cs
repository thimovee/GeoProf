using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProjectGeoProfs.Models
{
    public class VerlofAanvraag
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Vul je volledige naam in.")]
        [Display(Name = "Volledige Naam")]
        public string? VolledigeNaam { get; set; }
        [Required(ErrorMessage = "Vul de sector in waar je werkt.")]
        public string? Sector { get; set; }
        [Required(ErrorMessage = "Vul de startdatum van je verlof in")]
        [Display(Name = "Startdatum Verlof")]
        [DataType(DataType.Date)]
        public DateTime VerlofBeginDatum { get; set; }
        [Required(ErrorMessage = "Vul de startdatum van je verlof in")]
        [Display(Name = "Einddatum Verlof")]
        [DataType(DataType.Date)]
        public DateTime VerlofEindDatum { get; set; }
        [Display(Name = "Verlof Reden")]
        [Required(ErrorMessage = "Vul je Verlof reden in.")]
        public string? VerlofReden { get; set; }
        public bool Geaccepteerd { get; set; }
    }
}
