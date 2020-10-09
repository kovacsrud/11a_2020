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




            Console.ReadKey();
        }
    }
}
