using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadionFeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Stadion> stadionok = new List<Stadion>();
            try
            {
                var sorok = File.ReadAllLines("vb2018.txt",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    stadionok.Add(
                        new Stadion
                        {
                            Varos = e[0],
                            Nev1 = e[1],
                            Nev2 = e[2],
                            Ferohely = Convert.ToInt32(e[3])
                        }
                        );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                 
            }

            Console.WriteLine($"Feladat 3. Stadionok száma:{stadionok.Count}");

            var legkisebb = stadionok.FindAll(x=>x.Ferohely==stadionok.Min(y=>y.Ferohely));

            foreach (var i in legkisebb)
            {
                Console.WriteLine($"Feladat 4. {i.Varos},{i.Nev1},{i.Nev2},{i.Ferohely}");
            }

            var atlag = stadionok.Average(x => x.Ferohely);

            Console.WriteLine($"Feladat 5. Átlagos férőhelyszám:{atlag:0.0}");

            var altnev = stadionok.FindAll(x=>x.Nev2!="n.a.").Count;

            Console.WriteLine($"Feladat 6. Két néven is ismert stadionok száma:{altnev}");

            Console.ReadKey();
        }
    }
}
