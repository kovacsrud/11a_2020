using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadionFeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Stadion> stadionok = new List<Stadion>();
            try
            {
                var sorok = File.ReadAllLines("vb2018.txt",Encoding.Default);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                 
            }

            Console.ReadKey();
        }
    }
}
