using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hegyek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hegycsucs> hegycsucsok = new List<Hegycsucs>();
            try
            {
                var sorok = File.ReadAllLines("hegyekMo.txt",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    hegycsucsok.Add(
                        new Hegycsucs
                        {
                            HegycsucsNeve=e[0],
                            Hegyseg=e[1],
                            Magassag=Convert.ToInt32(e[2])
                        }
                        );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);               
            }

            Console.WriteLine($"3.feladat: Hegycsúcsok száma:{hegycsucsok.Count} db");

            var atlagmagassag = hegycsucsok.Average(x=>x.Magassag);

            Console.WriteLine($"4.feladat:Hegycsúcsok átlagos magassága:{atlagmagassag:0.00} m");

            var legmagasabb = hegycsucsok.Find(x => x.Magassag ==hegycsucsok.Max(y=>y.Magassag));

            Console.WriteLine($@"5.feladat:
              A legmagasabb hegycsúcs:{legmagasabb.HegycsucsNeve} 
              Hegység neve:{legmagasabb.Hegyseg} 
              Magasság:{legmagasabb.Magassag}"
            );

            Console.Write("Adjon meg egy magasságot:");
            var bemagassag = Convert.ToInt32(Console.ReadLine());

            var magasabbe = hegycsucsok.Find(x=>x.Hegyseg=="Börzsöny" && x.Magassag>bemagassag);

            if (magasabbe==null)
            {
                Console.WriteLine($"Nincs {bemagassag}-nál magasabb csúcs.");
            } else
            {
                Console.WriteLine($"Van {bemagassag}-nál magasabb csúcs.");
            }

            var magasabbef = hegycsucsok.FindAll(x=>x.Hegyseg=="Börzsöny" && x.Magassag>bemagassag);
            if (magasabbef.Count>0)
            {
                Console.WriteLine($"Van {bemagassag}-nál magasabb csúcs.");
            } else
            {
                Console.WriteLine($"Nincs {bemagassag}-nál magasabb csúcs.");
            }

            var magasabb3000 = hegycsucsok.Count(x=>x.Magassag*3.28>3000);
            Console.WriteLine($"7.feladat: 3000 lábnál magasabb hegycsúcsok száma:{magasabb3000}");

            var stat = hegycsucsok.ToLookup(x=>x.Hegyseg);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key} - {i.Count()} db");
            }




            Console.ReadKey();
        }
    }
}
