using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homerseklet
{
    class Program
    {
        static double Celsius2Fahrenheit(double celsius)
        {
            var fahrenheit = (celsius * 1.8) + 32;
            return fahrenheit;
        }

        static void Main(string[] args)
        {
            Console.Write("Adj meg egy hőmérsékletet celsiusban:");
            var celsius = Convert.ToDouble(Console.ReadLine());

            while (celsius!=-111)
            {
                //Függvény hívása
                Console.WriteLine($"{celsius} az {Celsius2Fahrenheit(celsius)} fahrenheit");
                Console.Write("Adj meg egy hőmérsékletet celsiusban:");
                celsius = Convert.ToDouble(Console.ReadLine());
            }


            Console.ReadKey();
        }

    }
}
