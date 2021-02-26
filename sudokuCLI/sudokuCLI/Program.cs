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
            Random rand = new Random();

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

            Console.Write("Kérem a feladvány méretét [4..9]:");
            var meret = Convert.ToInt32(Console.ReadLine());
            while (meret<4 || meret>9)
            {
                Console.Write("Rossz! Kérem a feladvány méretét [4..9]:");
                meret = Convert.ToInt32(Console.ReadLine());
            }

            var adottmeret = feladvanyok.FindAll(x=>x.Meret==meret);

            Console.WriteLine($"{meret}x{meret} méretű feladványból {adottmeret.Count} van tárolva.");

            
            var kivalaszott = adottmeret.ElementAt(rand.Next(0,adottmeret.Count));

            Console.WriteLine($@"5.feladat:A kiválasztott feladvány:
            {kivalaszott.Kezdo}");

            int kitoltottdb = 0;

            for (int i = 0; i < kivalaszott.Kezdo.Length; i++)
            {
                if (kivalaszott.Kezdo[i]!='0')
                {
                    kitoltottdb++;
                }
            }

            double szazalekos = (double)kitoltottdb / kivalaszott.Kezdo.Length;

            Console.WriteLine($"6.feladat: A feladvány kitöltöttsége:{szazalekos*100} %");

            Console.WriteLine($"7.feladat: A feladat kirajzolva:");
            kivalaszott.Kirajzol();

            string fajlnev = $"sudoku{meret}.txt";

            try
            {
                FileStream fajl = new FileStream(fajlnev, FileMode.Create);
                StreamWriter writer = new StreamWriter(fajl, Encoding.Default);

                foreach (var i in adottmeret)
                {
                    writer.WriteLine(i.Kezdo);
                }
                writer.Close();
                Console.WriteLine("A fájlba írás kész!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }


            Console.ReadKey();
        }
    }
}
