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

        }


        public void Koszon(string koszones)
        {
            Console.WriteLine($"{koszones},{nev} vagyok ");
        }

    }
}
