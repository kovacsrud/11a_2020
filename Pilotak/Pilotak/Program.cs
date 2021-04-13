using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilotak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pilota> pilotak = new List<Pilota>();
            try
            {
                var sorok = File.ReadAllLines("pilotak.csv",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    pilotak.Add(new Pilota(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"3.feladat:{pilotak.Count}");

            Console.ReadKey();
        }
    }
}
