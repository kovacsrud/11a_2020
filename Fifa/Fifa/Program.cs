using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Csapat> csapatok = new List<Csapat>();
            try
            {
                var sorok = File.ReadAllLines("fifa.txt", Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    csapatok.Add(new Csapat(sorok[i]));
                }
            }
            catch (Exception ex)
            {
              Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"3.feladat: A világranglistán {csapatok.Count} csapat szerepel.");

            var atlagpont = csapatok.Average(x=>x.Pontszam);
            Console.WriteLine($"4.feladat: A csapatok átlagos pontszáma: {atlagpont:0.00} pont.");

            var maxjavito = csapatok.Find(x=>x.Valtozas==csapatok.Max(y=>y.Valtozas));

            if (maxjavito!=null)
            {
                Console.WriteLine($@"5.feladat: A legtöbbet javító csapat
                    Helyezes:{maxjavito.Helyezes}
                    Csapat:{maxjavito.Csapatnev}
                    Pontszám:{maxjavito.Pontszam}");
            } else
            {
                Console.WriteLine("Nincs ilyen!");
            }

            if (csapatok.Any(x=>x.Csapatnev=="Magyarország"))
            {
                Console.WriteLine("6.feladat: A csapatok között ott van Magyarország.");
            } else
            {
                Console.WriteLine("6.feladat: A csapatok között nincs Magyarország.");
            }

            var statisztika = csapatok.ToLookup(x=>x.Valtozas);

            Console.WriteLine("7.feladat: Statisztika");

            foreach (var i in statisztika)
            {
                if (i.Count()>1)
                {
                    Console.WriteLine($"{i.Key} helyet változott {i.Count()} csapat");
                }
                
            }

            var stat = csapatok.GroupBy(x => x.Valtozas);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key},{i.Count()},{i.Average(x=>x.Pontszam)}");
            }


            Console.ReadKey();
        }
    }
}
