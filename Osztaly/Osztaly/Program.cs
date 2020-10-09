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
            Ember e1 = new Ember("Egon",178,68,1999);
            Console.WriteLine(e1.GetMagassag());
            e1.SetMagassag(182);
            Console.WriteLine(e1.GetMagassag());

            e1.Koszon("Szia");


            Ember e2 = new Ember("Zénó",196,79,2003);
            Console.WriteLine(e2.GetMagassag());
            e2.SetMagassag(190);
            Console.WriteLine(e2.GetMagassag());

            e2.Koszon("Csá csumi");




            Console.ReadKey();
        }
    }
}
