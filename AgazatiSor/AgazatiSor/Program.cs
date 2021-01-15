using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgazatiSor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy számot:");
            var szam = Convert.ToInt32(Console.ReadLine());

            if (szam>0)
            {
                Console.WriteLine("Ez a szám pozitív!");
            }
            else if (szam<0)
            {
                Console.WriteLine("Ez a szám negatív!");
            } else
            {
                Console.WriteLine("A szám nulla!");
            }

            Console.ReadKey();
        }
    }
}
