using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kektura
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TuraSzakasz> teljestura = new List<TuraSzakasz>();
            var kezdomagassag = 0;
            try
            {
                var sorok = File.ReadAllLines("kektura.csv", Encoding.Default);
                var aktualismagassag = Convert.ToInt32(sorok[0]);
                kezdomagassag = aktualismagassag;

                for (int i = 1; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    aktualismagassag += Convert.ToInt32(e[3]) - Convert.ToInt32(e[4]);
                    teljestura.Add(
                        new TuraSzakasz
                        {
                           
                            Kiindulopont = e[0],
                            Vegpont = e[1],
                            SzakaszHossz = Convert.ToDouble(e[2]),
                            EmelkedesOsszeg = Convert.ToInt32(e[3]),
                            LejtesOsszeg = Convert.ToInt32(e[4]),
                            Pecsetelohely = e[5],
                            TengerszintFelettiMagassag = aktualismagassag
                        }
                        );  
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);               
            }

            Console.WriteLine($"Feladat 3: Szakaszok száma:{teljestura.Count} db");

            var teljeshossz = teljestura.Sum(x => x.SzakaszHossz);

            Console.WriteLine($"Feladat 4:A túra teljes hossza:{teljeshossz} km.");

            var legrovidebb = teljestura.Min(x => x.SzakaszHossz);

            var legr_adatai = teljestura.Find(x=>x.SzakaszHossz==legrovidebb);

            Console.WriteLine($@"Feladat 5: A legrövidebb szakasz adatai:
            Kezdete:{legr_adatai.Kiindulopont}
            Vége:{legr_adatai.Vegpont}
            Távolság:{legr_adatai.SzakaszHossz} km
            ");

            Console.WriteLine($"Feladat 7: Hiányos állomásnevek");

            foreach (var i in teljestura)
            {
                if (i.HianyosNev())
                {
                    Console.WriteLine($"{i.Vegpont}");
                }
            }

            var maxmagassag = teljestura.Max(x=>x.TengerszintFelettiMagassag);
            var legmagasabb = teljestura.Find(x=>x.TengerszintFelettiMagassag==maxmagassag);
            Console.WriteLine($@"8 feladat: A túra legmagasabban fekvő végpontja:
             A végpont neve:{legmagasabb.Vegpont}               
             Magassága:{legmagasabb.TengerszintFelettiMagassag}");


            try
            {
                FileStream fajl = new FileStream("kektura2.csv",FileMode.Create);
                StreamWriter writer = new StreamWriter(fajl,Encoding.Default);
                writer.WriteLine(kezdomagassag);

                foreach (var i in teljestura)
                {
                    if (i.HianyosNev())
                    {
                        writer.WriteLine($"{i.Kiindulopont};{i.Vegpont} pecsetelohely;{i.EmelkedesOsszeg};{i.LejtesOsszeg};{i.Pecsetelohely}");
                    }else
                    {
                        writer.WriteLine($"{i.Kiindulopont};{i.Vegpont};{i.EmelkedesOsszeg};{i.LejtesOsszeg};{i.Pecsetelohely}");
                    }
                }


                writer.Close();
                Console.WriteLine("Kiírás kész");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }



            Console.ReadKey();
        }
    }
}
