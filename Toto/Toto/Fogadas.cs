using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    public class Fogadas
    {
        public int Ev { get; set; }
        public int Het { get; set; }
        public int Fordulo { get; set; }
        public int T13p1 { get; set; }
        public int Ny13p1 { get; set; }
        public string Eredmenyek { get; set; }

        public Fogadas(string sor)
        {
            var e = sor.Split(';');
            Ev = Convert.ToInt32(e[0]);
            Het = Convert.ToInt32(e[1]);
            Fordulo = Convert.ToInt32(e[2]);
            T13p1 = Convert.ToInt32(e[3]);
            Ny13p1 = Convert.ToInt32(e[4]);
            Eredmenyek = e[5];
        }


    }
}
