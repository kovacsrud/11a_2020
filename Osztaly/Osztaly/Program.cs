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

            Tanulo t1 = new Tanulo("Ubul", 182, 78, 2001);
            t1.Suly = 74;

            Tanulo t2 = new Tanulo("Elek", 95, 58, 2002);

            Console.WriteLine(t2.Magassag);


            Console.ReadKey();
        }
    }
}
