using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Munkavallalo
{
    public class Dolgozo
    {
        public string Nev { get; set; }
        public string Munkakor { get; set; }
        public int Szuletesiev { get; set; }

        public int Eletkor()
        {
            var datum = DateTime.Now;
            return datum.Year - Szuletesiev;
        }

    }
}
