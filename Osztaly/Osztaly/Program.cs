using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember e1 = new Ember();
            e1.nev = "Zénó";
            e1.magassag = 176;
            e1.suly = 79;
            e1.szulev = 1998;

            e1.Koszon();

            Ember e2 = new Ember();
            e2.nev = "Gerzson";
            e2.magassag = 196;
            e2.suly = 69;
            e2.szulev = 2001;
            e2.Koszon();




            Console.ReadKey();
        }
    }
}
