using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idojaras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IdojarasAdat> idojarasadatok = new List<IdojarasAdat>();

            try
            {
                var sorok = File.ReadAllLines("idojaras.csv",Encoding.Default);

                for (int i = 1; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    IdojarasAdat adat = new IdojarasAdat {
                        Ev = Convert.ToInt32(e[0]),
                        Honap = Convert.ToInt32(e[1]),
                        Nap = Convert.ToInt32(e[2]),
                        Ora = Convert.ToInt32(e[3]),
                        Homerseklet = Convert.ToDouble(e[4]),
                        Szelsebesseg=Convert.ToDouble(e[5]),
                        Paratartalom=Convert.ToDouble(e[6])
                    };
                    idojarasadatok.Add(adat);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Sorok száma:{idojarasadatok.Count}");

            var ev2016 = idojarasadatok.FindAll(x => x.Ev == 2016 && x.Honap==11);

            foreach (var i in ev2016)
            {
                Console.WriteLine($"{i.Ev}.{i.Honap}.{i.Nap} {i.Ora}");
            }


            Console.ReadKey();
        }
    }
}
