using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzovegEsValtozok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Szöveges változókkal végzett fontosabb műveletek
            string szoveg = "valami,bármi,akármi";
            string szoveg2 = "valami,BÁRMI,Akármi";

            //Kis- vagy nagybetűs megjelenítés
            Console.WriteLine(szoveg.ToLower());
            Console.WriteLine(szoveg.ToUpper());

            if (szoveg.ToUpper()==szoveg2.ToUpper())
            {
                Console.WriteLine("Megegyeznek!");
            }else
            {
                Console.WriteLine("Nem egyeznek meg!");
                
            }

            //Vizsgálatok
            Console.WriteLine(szoveg.StartsWith("Val"));
            Console.WriteLine(szoveg.ToUpper().StartsWith("Val".ToUpper()));

            //Benne van?
            Console.WriteLine(szoveg.Contains("bár"));

            Console.WriteLine(szoveg.Replace(',',';'));

            string datum = "2019.03.19";

            string ev = datum.Substring(0, 4);
            Console.WriteLine(ev);

            string honap = datum.Substring(5,2);
            Console.WriteLine(honap);

            //Feldarabolás, Split
            var elemek = datum.Split('.');

            for (int i = 0; i < elemek.Length; i++)
            {
                Console.WriteLine(elemek[i]);
            }



            Console.ReadKey();
        }
    }
}
