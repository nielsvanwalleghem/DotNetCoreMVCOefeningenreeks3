using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreMVCOefeningenreeks3.Models
{
    public enum Geslacht
    {
        Man,
        Vrouw,
    }

    public class BandLid
    {
        [Display(Name = "Naam bandlid")]
        [Required(ErrorMessage = "Geef een naam op voor het bandlid")]
        public string Naam { get; set; }

        [Display(Name = "Leeftijd")]
        [Required(ErrorMessage = "Geef de leeftijd op")]
        [Range(minimum: 18, maximum: 90, ErrorMessage = "De leeftijd moet tussen {1} en {2} jaar liggen")]
        public int Leeftijd { get; set; }

        [Display(Name = "Geslacht")]
        public Geslacht Geslacht { get; set; }

        [Display(Name = "Nog in leven?")]
        public bool Levend { get; set; }
    }
}
