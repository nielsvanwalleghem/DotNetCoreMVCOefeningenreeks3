using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHowest;

namespace DotNetCoreMVCOefeningenreeks3.Controllers
{
    [Route("")]
    [Route("[controller]")]
    public class BerekenController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return Content("Route zonder resultaat");
        }

        [Route("[action]/{value?}")]
        public IActionResult Faculteit(int? value)
        {
            return Content($"Faculteit van {value ?? 0} is {MyHowest.Faculteit.Bereken(value ?? 0)}", contentType: "text/html; charset=utf-8");
        }

        [Route("[action]/{convertTo:regex(inFahrenheit|inKelvin)}/{fromTemp:int}")]
        public IActionResult Temperatuur(string convertTo, int fromTemp)
        {
            Temperatuur temperatuur = new Temperatuur(fromTemp);
            string eenheid;
            double tempResultaat;

            switch (convertTo)
            {
                case "inFahrenheit":
                    eenheid = "Fahrenheit";
                    tempResultaat = temperatuur.Fahrenheit;
                    break;
                case "inKelvin":
                    eenheid = "Kelvin";
                    tempResultaat = temperatuur.Kelvin;
                    break;
                default:
                    eenheid = "Celsius";
                    tempResultaat = fromTemp;
                    break;
            }
            return Content($"Temperatuur in {eenheid} is {tempResultaat}");
        }
    }
}