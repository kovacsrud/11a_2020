using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa
{
    public class Csapat
    {
        public string Csapatnev { get; set; }
        public int Helyezes { get; set; }
        public int Valtozas { get; set; }
        public int Pontszam { get; set; }

        public Csapat(string sor)
        {
            var e = sor.Split(';');
            Csapatnev = e[0];
            Helyezes = Convert.ToInt32(e[1]);
            Valtozas = Convert.ToInt32(e[2]);
            Pontszam = Convert.ToInt32(e[3]);
        }
    }
}
