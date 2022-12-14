using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProjectGeoProfs.Models
{
    public class VerlofAanvraag
    {
        public int Id { get; set; }
        [Display(Name = "Volledige Naam")]
        public string? VolledigeNaam { get; set; }
        public string? Sector { get; set; }
        [Display(Name = "Startdatum Verlof")]
        [DataType(DataType.Date)]
        public DateTime VerlofBeginDatum { get; set; }
        [Display(Name = "Einddatum Verlof")]
        [DataType(DataType.Date)]
        public DateTime VerlofEindDatum { get; set; }
        [Display(Name = "Verlof Reden")]
        public string? VerlofReden { get; set; }
    }
}
