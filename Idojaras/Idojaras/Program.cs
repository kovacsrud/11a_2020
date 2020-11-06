using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idojaras
{
    class Program
    {
        static void Main(string[] args)
        {
            IdojarasAdat adat = new IdojarasAdat(2020, 12, 12, 22, 12.6, 13.66, 0.9);
            IdojarasAdat adat2 = new IdojarasAdat {
                Ev=2020,
                Honap=11,
                Nap=10,
                Ora=6,
                Homerseklet=11.4,
                Szelsebesseg=6.2,
                Paratartalom=0.8
            };

            Console.ReadKey();
        }
    }
}
