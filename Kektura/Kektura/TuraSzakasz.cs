using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kektura
{
    public class TuraSzakasz
    {
        public string Kiindulopont { get; set; }
        public string Vegpont { get; set; }
        public double SzakaszHossz { get; set; }
        public int EmelkedesOsszeg { get; set; }
        public int LejtesOsszeg { get; set; }
        public string Pecsetelohely { get; set; }

        public bool HianyosNev()
        {
            if (Pecsetelohely=="i" && !Vegpont.Contains("pecsetelohely"))
            {
                return true;
            } else
            {
                return false;
            }
        }

    }
}
