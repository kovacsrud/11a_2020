using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    public class Dobo
    {
        public string Nev { get; set; }
        public DateTime Elso { get; set; }
        public DateTime Utolso { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }

        public Dobo(string sor)
        {
            var e = sor.Split(';');
            Nev = e[0];
            Elso = DateTime.Parse(e[1]);
            Utolso = DateTime.Parse(e[2]);
            Suly = Convert.ToInt32(e[3]);
            Magassag = Convert.ToInt32(e[4]);
        }
    }
}
