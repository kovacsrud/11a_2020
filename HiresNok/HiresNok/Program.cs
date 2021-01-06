using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiresNok
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HiresNo> hiresnok = new List<HiresNo>();

            Console.WriteLine("Akar felvinni adatot?(i/n)");
            var felvitel = Console.ReadLine();

            while (felvitel=="i")
            {
                Console.WriteLine("Név:");
                var nev = Console.ReadLine();
                Console.WriteLine("Foglalkozás:");
                var foglalkozas = Console.ReadLine();
                Console.WriteLine("Nemzetiség(a/n):");
                var nemzetiseg = Console.ReadLine();

                hiresnok.Add(
                    new HiresNo
                    {
                        Nev=nev,
                        Foglalkozas=foglalkozas,
                        Nemzetiseg=nemzetiseg
                    }
                    );
                
                Console.WriteLine("Akar felvinni adatot?(i/n)");
                felvitel = Console.ReadLine();

            }

            for (int i = 0; i < hiresnok.Count; i++)
            {
                Console.WriteLine($"{hiresnok[i].Elotag()} {hiresnok[i].Nev}," +
                    $"{hiresnok[i].Foglalkozas}," +
                    $"{hiresnok[i].Nemzetiseg}");
            }

            foreach (var i in hiresnok)
            {
                Console.WriteLine($"{i.Elotag()} {i.Nev},{i.Foglalkozas}");
            }

            Console.ReadKey();
        }
    }
}
