using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreMVCOefeningenreeks3.Models;
using Microsoft.AspNetCore.Http;

namespace DotNetCoreMVCOefeningenreeks3.Models
{
    public static class BandInitializer
    {
        static BandInitializer()
        {
 
        }

        public static  List<Band> StartUp() {
            return new List<Band>() {
                new Band() { Naam="The Beatles", Jaar=1960,
                    Leden = new List<BandLid>()
                        {
                            new BandLid() { Naam="George", Geslacht=Geslacht.Man, Leeftijd=55, Levend=false },
                            new BandLid() { Naam="Ringo", Geslacht=Geslacht.Man, Leeftijd=64, Levend=true },
                            new BandLid() { Naam="Paul", Geslacht=Geslacht.Man, Leeftijd=76, Levend=true },
                            new BandLid() { Naam="John", Geslacht=Geslacht.Man, Leeftijd=35, Levend=false }
                        }
                },
                new Band() { Naam="Nicole & Hugo", Jaar=1302,
                    Leden = new List<BandLid>()
                        {
                            new BandLid() { Naam="Nicole", Geslacht=Geslacht.Vrouw, Leeftijd=75, Levend=true },
                            new BandLid() { Naam="Hugo", Geslacht=Geslacht.Man, Leeftijd=73, Levend=true },
                        }
                }
            };

        }
    }
}
