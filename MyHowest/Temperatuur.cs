using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHowest
{
    public class Temperatuur
    {
        public Temperatuur(int tempInCelsius)
        {
            Celsius= tempInCelsius;
        }

        public double Fahrenheit
        {
            get
            {
                return Celsius * 1.8 + 32;
            }
        }
        public double Kelvin
        {
            get
            {
                return Celsius + 273.15;
            }
        }

        public int Celsius { get; set; }

    }
}