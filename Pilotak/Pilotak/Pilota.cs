using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilotak
{
    public class Pilota
    {
        public string Nev { get; set; }
        public int SzuletesiEv { get; set; }
        public int SzuletesiHo { get; set; }
        public int SzuletesiNap { get; set; }

        public string Nemzetiseg { get; set; }
        public int Rajtszam { get; set; }

        public Pilota(string sor)
        {
            var e = sor.Split(';');
            Nev = e[0];
            var szuladat = e[1].Split('.');
            SzuletesiEv = Convert.ToInt32(szuladat[0]);
            SzuletesiHo= Convert.ToInt32(szuladat[1]);
            SzuletesiNap= Convert.ToInt32(szuladat[2]);
            Nemzetiseg = e[2];

            if (e[3]=="")
            {
                Rajtszam = -11;
            } else
            {
                Rajtszam = Convert.ToInt32(e[3]);
            }

        }
    }
}
