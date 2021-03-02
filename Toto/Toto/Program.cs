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

            Console.ReadKey();
        }
    }
}
