using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudokuCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Feladvany> feladvanyok = new List<Feladvany>();

            try
            {
                var sorok = File.ReadAllLines("feladvanyok.txt",Encoding.Default);

                for (int i = 0; i < sorok.Length; i++)
                {
                    feladvanyok.Add(new Feladvany(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);               
            }

            Console.WriteLine($"3.feladat: Beolvasva {feladvanyok.Count} feladvány");

            Console.ReadKey();
        }
    }
}
