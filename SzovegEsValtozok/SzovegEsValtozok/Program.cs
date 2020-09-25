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
            string szoveg = "Valami,bármi,akármi";
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



            Console.ReadKey();
        }
    }
}
