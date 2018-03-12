using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHowest
{
    public static class Faculteit
    {
        static Faculteit()
        {
        }

        public static int Bereken(int waarde)
        {
            return FacCount(waarde);
        }

        private static int FacCount(int v)
        {
            if (v > 0)
            {
                return v * FacCount(v - 1);  
            } else
            {
                return 1;
            }
        }
    }
}