using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilotak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pilota> pilotak = new List<Pilota>();
            try
            {
                var sorok = File.ReadAllLines("pilotak.csv",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    pilotak.Add(new Pilota(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"3.feladat:{pilotak.Count}");

            Console.WriteLine($"4.feladat:{pilotak.Last().Nev}");
            //Alternatív megoldás az utolsó elem kiválasztására
            Console.WriteLine($"4.feladat:{pilotak[pilotak.Count-1].Nev}");

            var regiPilotak = pilotak.FindAll(x=>x.SzuletesiEv<1901);

            Console.WriteLine("5.feladat");
            foreach (var i in regiPilotak)
            {
                Console.WriteLine($"{i.Nev} ({i.SzuletesiEv}.{i.SzuletesiHo}.{i.SzuletesiNap}.)");
            }

            var rajtszamosPilotak = pilotak.FindAll(x=>x.Rajtszam!=-11);

            var legkisebbRajtszam = rajtszamosPilotak.Find(x=>x.Rajtszam==rajtszamosPilotak.Min(y=>y.Rajtszam));
            
            Console.WriteLine($"6.feladat:{legkisebbRajtszam.Nemzetiseg}");
            

            Console.ReadKey();
        }
    }
}
