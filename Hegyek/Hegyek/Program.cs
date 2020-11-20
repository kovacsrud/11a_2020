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

            Console.WriteLine($"4.feladat:Hegycsúcsok átlagos magassága:{atlagmagassag} m");

            Console.ReadKey();
        }
    }
}
