using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly
{
    public class Ember
    {
        private string nev;
        private int magassag;
        private int suly;
        private int szulev;

        //Konstruktor, a példányosításkor automatikusan
        //lefut
        public Ember(string benev,int bemagassag,int besuly,int beszulev)
        {
            nev = benev;
            magassag = bemagassag;
            suly = besuly;
            szulev = beszulev;
        }


        public void Koszon(string koszones)
        {
            Console.WriteLine($"{koszones},{nev} vagyok ");
        }

        public int GetMagassag()
        {
            return magassag;
        }

    }
}
