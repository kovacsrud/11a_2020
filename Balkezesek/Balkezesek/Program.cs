﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dobo> dobok = new List<Dobo>();

            try
            {
                var sorok = File.ReadAllLines("balkezesek.csv",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    dobok.Add(new Dobo(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Adatok száma:{dobok.Count}");

            var okt99 = dobok.FindAll(x=>x.Utolso.Year==1999 && x.Utolso.Month==10);

            foreach (var i in okt99)
            {
                Console.WriteLine($"{i.Nev}-{i.Magassag*2.54:0.0}");
            }

            Console.Write("Adjon meg egy évszámot:");
            var evszam = Convert.ToInt32(Console.ReadLine());

            while (evszam<1990 || evszam>1999)
            {
                Console.Write("Hibás érték, újra:");
                evszam = Convert.ToInt32(Console.ReadLine());
            }

            var atlagsuly = dobok.FindAll(x=>x.Elso.Year>=evszam && x.Utolso.Year<=evszam).Average(x=>x.Suly);

            Console.WriteLine($"Átlagsúly:{atlagsuly:0.00}, kg-ban {atlagsuly/2:0.00}");

            //A fenti példa alapján határozza meg az átlagmagasságot is

            var atlagmagassag = dobok.FindAll(x => x.Elso.Year >= evszam && x.Utolso.Year <= evszam).Average(x=>x.Magassag);

            Console.WriteLine($"Átlagmagasság:{atlagmagassag:0.00}, cm-ben {atlagmagassag*2.54:0.00}");

            Console.ReadKey();
        }
    }
}
