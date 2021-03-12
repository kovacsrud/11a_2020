using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultrabalaton
{
    public class Versenyzo
    {
        public string VersenyzoNev { get; set; }
        public int RajtSzam { get; set; }
        public string Kategoria { get; set; }

        public string VersenyIdo { get; set; }

        public int Tavszazalek { get; set; }

        public Versenyzo(string sor)
        {
            var e = sor.Split(';');
            VersenyzoNev = e[0];
            RajtSzam = Convert.ToInt32(e[1]);
            Kategoria = e[2];
            VersenyIdo = e[3];
            Tavszazalek = Convert.ToInt32(e[4]);
        }

        public double IdoOraban()
        {
            var e = VersenyIdo.Split(':');
            double ora = Convert.ToDouble(e[0]);
            double perc = Convert.ToDouble(e[1]);
            double masodperc = Convert.ToDouble(e[2]);

            return (ora * 3600) + (perc * 60) + masodperc; 

        }

    }
}
