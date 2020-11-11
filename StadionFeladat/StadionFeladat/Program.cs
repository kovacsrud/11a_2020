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

            Console.ReadKey();
        }
    }
}
