using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreMVCOefeningenreeks3.Models;

namespace DotNetCoreMVCOefeningenreeks3.Controllers
{
    public class BandLidController : Controller
    {
        private List<Band> bands;
  
        public BandLidController()
        {
            bands = BandInitializer.StartUp();
        }

        [Route("[controller]/[action]")]
        public IActionResult Lijst()
        {
            return View(bands);
        }

        [Route("[action]/[controller]/{bandlidnaam}/{bandlidjaar:int}/{geslacht:GeslachtKeuze}/{bandnaam}")]
        [Route("[action][controller]/Naam/{bandlidnaam}/Jaar/{bandlidjaar:int}/Geslacht/{geslacht:GeslachtKeuze}/Band/{bandnaam}")]
        [HttpGet("[controller]/[action]")]
        public IActionResult Maak(string bandlidnaam, int bandlidjaar, Geslacht geslacht, string bandnaam)
        {
            ViewBag.bandnaam = bandnaam;
            return View(new BandLid()
                    { Naam=bandlidnaam, Leeftijd=bandlidjaar, Geslacht=geslacht}
                );
        }

        [ValidateAntiForgeryToken]
        [HttpPost()]
        [Route("[controller]/[action]")]
        public IActionResult VoegToe(BandLid bandLid, string band)
        {
            if (ModelState.IsValid)
            {
                bands.Add(
                     new Band()
                     {
                         Naam = band,
                         Leden = new List<BandLid>()
                            { new BandLid()
                                { Naam = bandLid.Naam, Geslacht = bandLid.Geslacht, Leeftijd= bandLid.Leeftijd, Levend = true }
                            }
                     });
                return View("Lijst", bands);
            }
            return View("Maak",bandLid);
        }
    }
}
