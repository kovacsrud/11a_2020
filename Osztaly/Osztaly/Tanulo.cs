using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly
{
    public class Tanulo
    {
      

        public string Nev { get; set; }
        private int magassag;
        public int Magassag {
            get { return magassag; }
            set
            {
                if (value>=100 && value<=240)
                {
                    magassag = value;
                }else
                {
                    magassag = 165;
                }
            }
        }
        public int Suly { get; set; }
        public int Szulev { get; set; }

        public Tanulo(string nev, int magassag, int suly, int szulev)
        {
            Nev = nev;
            Magassag = magassag;
            Suly = suly;
            Szulev = szulev;
        }


    }
}
