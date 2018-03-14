using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreMVCOefeningenreeks3.Models;

namespace DotNetCoreMVCOefeningenreeks3.Controllers
{
    [Route("")]
    public class BandController : Controller
    {
        private List<Band> bands;
        public BandController()
        {
            bands = BandInitializer.StartUp();
        }

        [Route("")]
        [Route("[controller]/[action]")]
        public IActionResult Lijst()
        {
            return View(bands);
        }

        [Route("[controller]/[action]")]
        public IActionResult LijstMetLeden()
        {
            return View(bands);
        }

        [Route("[action]/[controller]/{bandnaam}/{bandjaar:int}")]
        [Route("[action][controller]/Naam/{bandnaam}/Jaar/{bandjaar:int}")]
        [HttpGet("[controller]/[action]")]
        public IActionResult Maak(string bandnaam, int bandjaar)
        {
            return View(new Band() { Naam=bandnaam, Jaar=bandjaar });
        }

        [ValidateAntiForgeryToken]
        [Route("[controller]/[action]")]
        [HttpPost()]
        public IActionResult VoegToe(Band band)
        {
            if (ModelState.IsValid) {
                bands.Add(new Band() { Naam=band.Naam, Jaar=band.Jaar });
                return View("Lijst", bands);
            }
            return View("Maak",band);
        }

        [Route("[controller]/[action]")]
        [Route("MaakLijst/JS")]
        public IActionResult JSLijst()
        {
            return Json(bands);
        }
    }
}
