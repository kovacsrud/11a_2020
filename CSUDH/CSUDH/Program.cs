using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSUDH
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Domain> domains = new List<Domain>();

            try
            {
                var sorok = File.ReadAllLines("csudh.txt", Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    domains.Add(new Domain(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"3.feladat: Domainek száma:{domains.Count}");

            Console.ReadKey();
        }
    }
}
