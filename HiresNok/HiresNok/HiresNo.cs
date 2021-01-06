using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiresNok
{
    public class HiresNo
    {
        public string Nev { get; set; }
        public string Foglalkozas { get; set; }
        public string Nemzetiseg { get; set; }

        public string Elotag()
        {
            if (Nemzetiseg=="a")
            {
                return "Ms.";
            } else
            {
                return "Frau";
            }
        }
    }
}
