using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{

    class Program
    {
        class EredmenyElemzo
        {
            private string Eredmenyek;

            private int DontetlenekSzama
            {
                get
                {
                    return Megszamol('X');
                }
            }

            private int Megszamol(char kimenet)
            {
                int darab = 0;
                foreach (var i in Eredmenyek)
                {
                    if (i == kimenet) darab++;
                }
                return darab;
            }

            public bool NemvoltDontetlenMerkozes
            {
                get
                {
                    return DontetlenekSzama == 0;
                }
            }

            public EredmenyElemzo(string eredmenyek) // konstruktor
            {
                Eredmenyek = eredmenyek;
            }
        }
        static void Main(string[] args)
        {
            List<Fogadas> fogadasok = new List<Fogadas>();

            try
            {
                var sorok = File.ReadAllLines("toto.txt",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    fogadasok.Add(new Fogadas(sorok[i]));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);               
            }

            Console.WriteLine($"3.feladat: Fordulók száma:{fogadasok.Count}");

            //var telitalalatDb = fogadasok.FindAll(x=>x.T13p1>0).Sum(x=>x.T13p1);
            var telitalalatDb = fogadasok.Sum(x => x.T13p1);

            Console.WriteLine($"4.feladat: Telitalálatos szelvények száma:{telitalalatDb} db");

            var atlagNyeremeny = fogadasok.FindAll(x=>x.T13p1>0).Average(x=>(x.T13p1*x.Ny13p1));

            Console.WriteLine($"5.feladat: Átlag:{atlagNyeremeny:0} Ft");

            var minNyeremeny = fogadasok.FindAll(x => x.T13p1 > 0).Min(x => x.Ny13p1);

            var minFordulo = fogadasok.Find(x=>x.Ny13p1==minNyeremeny);

            var maxNyeremeny = fogadasok.FindAll(x=>x.T13p1>0).Max(x=>x.Ny13p1);

            var maxFordulo = fogadasok.Find(x=>x.Ny13p1==maxNyeremeny);

            Console.WriteLine($@"6.feladat:
            Legnagyobb:
            Év:{maxFordulo.Ev}
            Hét:{maxFordulo.Het}
            Forduló:{maxFordulo.Fordulo}
            Telitalálat:{maxFordulo.T13p1}
            Nyeremény:{maxFordulo.Ny13p1} Ft
            Eredmények:{maxFordulo.Eredmenyek}
            Legkisebb:
            Év:{minFordulo.Ev}
            Hét:{minFordulo.Het}
            Forduló:{minFordulo.Fordulo}
            Telitalálat:{minFordulo.T13p1}
            Nyeremény:{minFordulo.Ny13p1} Ft
            Eredmények:{minFordulo.Eredmenyek}");

            var nincsdontetlen = fogadasok.FindAll(x=>!x.Eredmenyek.Contains("x"));

            if (nincsdontetlen.Count>0)
            {
                Console.WriteLine("Van olyan forduló, ahol nem volt döntetlen!");
            } else
            {
                Console.WriteLine("Nincs olyan forduló, ahol nem volt döntetlen!");
            }

            //Eredmenyelemzo osztály használata
            List<EredmenyElemzo> eredmenyelemek = new List<EredmenyElemzo>();

            foreach (var i in fogadasok)
            {
                eredmenyelemek.Add(new EredmenyElemzo(i.Eredmenyek));
            }


            var elemzes = eredmenyelemek.Find(x=>x.NemvoltDontetlenMerkozes==true);

            if (elemzes!=null)
            {
                Console.WriteLine("Van olyan forduló, ahol nem volt döntetlen!");
            } else
            {
                Console.WriteLine("Nincs olyan forduló, ahol nem volt döntetlen!");
            }


            //foreach (var i in eredmenyelemek)
            //{
            //    Console.WriteLine($"{i.NemvoltDontetlenMerkozes}");
            //}

            Console.ReadKey();
        }
    }
}
