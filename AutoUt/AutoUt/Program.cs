using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUt
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto { Tipus="Opel", SebessegKmh=90};

            Console.WriteLine(auto.EnnyitHalad());

            

            Console.ReadKey();
        }
    }
}
