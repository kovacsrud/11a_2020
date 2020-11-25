using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hianyzas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hianyzas> hianyzasok = new List<Hianyzas>();
            try
            {
                var sorok = File.ReadAllLines("szeptember.csv", Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    hianyzasok.Add(
                        new Hianyzas {
                            Nev=e[0],
                            Osztaly=e[1],
                            Elsonap=Convert.ToInt32(e[2]),
                            Utolsonap=Convert.ToInt32(e[3]),
                            Mulasztottorak=Convert.ToInt32(e[4])
                        }
                        );
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(hianyzasok.Count);

            var osszhianyzas = hianyzasok.Sum(x=>x.Mulasztottorak);
            Console.WriteLine($"Az összes mulasztott órák száma:{osszhianyzas}");

            var benap = Convert.ToInt32(Console.ReadLine());
            var benev = Console.ReadLine();

            var hianyzotte = hianyzasok.Find(x=>x.Nev==benev);

            if (hianyzotte!=null)
            {
                Console.WriteLine($"{benev} hiányzott szeptemberben");
            } else
            {
                Console.WriteLine($"{benev} nem hiányzott szeptemberben");
            }

            if (hianyzasok.Any(x=>x.Nev==benev))
            {
                Console.WriteLine($"{benev} hiányzott szeptemberben");
            } else
            {
                Console.WriteLine($"{benev} nem hiányzott szeptemberben");
            }

            var hianyoztakaznap = hianyzasok.FindAll(x=>x.Elsonap>=benap && x.Utolsonap<=benap);

            if (hianyoztakaznap.Count==0)
            {
                Console.WriteLine("Ezen a napon senki sem hiányzott!");
            } else
            {
                foreach (var i in hianyoztakaznap)
                {
                    Console.WriteLine($"{i.Nev},{i.Osztaly}");
                }
            }


            Console.ReadKey();
        }
    }
}
