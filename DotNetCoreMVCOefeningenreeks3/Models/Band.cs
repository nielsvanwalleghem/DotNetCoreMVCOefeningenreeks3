using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreMVCOefeningenreeks3.Models
{
    public class Band
    {
        [Display(Name ="Naam van de band")]
        [Required(ErrorMessage ="Geef een naam op voor de band")]
        [MinLength(3, ErrorMessage = "De naam moet minstens {1} tekens langs zijn"), MaxLength(25)]
        public string Naam { get; set; }

        [Display(Name = "Jaar van oprichting")]
        [Required(ErrorMessage ="Voorzie het jaar van oprichten")]
        [Range(minimum: 1920, maximum: 2017, ErrorMessage ="Het jaar van oprichten moet tussen {1} en {2} liggen")]
        public int Jaar { get; set; }
        public List<BandLid> Leden { get; set; }
    }
}
