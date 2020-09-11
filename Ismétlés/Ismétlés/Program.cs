using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ismétlés
{
    class Program
    {
        static void Main(string[] args)
        {
            //Változók
            //Egész szám típusok

            //előjeles típusok
            int a = 123;
            a = -123;

            Console.WriteLine($"{Int32.MinValue},{Int32.MaxValue}");

            Console.WriteLine($"{UInt32.MinValue},{UInt32.MaxValue}");

            short aa = 125;

            long aaa = 1234556;

            // előjel nélküi típusok
            uint b = 345;

            //lebegőpontos
            float l = 12.012345678901234567890123456789f;

            double ll= 12.012345678901234567890123456789;

            decimal lll= 12.012345678901234567890123456789m;

            
            Console.WriteLine($"{l},{ll},{lll}");

            //szöveg

            string szoveg = "Valami Szöveg";

            Console.WriteLine(szoveg.ToLower());
            Console.WriteLine(szoveg.ToUpper());

            szoveg = "Valami Más Szöveg";

            Console.WriteLine(szoveg.Substring(7,3));
            Console.WriteLine(szoveg.Contains("Más"));

            if ("Más".ToLower()=="más".ToLower()) 
            {
                Console.WriteLine("Ugyanaz a két szöveg!");

            } else
            {
                Console.WriteLine("Nem ugyanaz a két szöveg!");
            }

            //karakter típus
            //szám, betű, írásjel, vezérlő karakter

            char k = 'l';

            //Logikai típus
            bool logic = true;

            //összetett típusok
            //tömb -> több azonos típusú változó együtt

            //létrehozás az elemek megadásával
            //index           0, 1,  2,  3,  4   
            int[] szamok = { 11, 23, 67, 89, 34 };

            //létrehozás az elemszám megadásával
            int[] szamok2 = new int[50];

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }

            Random rand = new Random();

            for (int i = 0; i < szamok2.Length; i++)
            {
                szamok2[i] = rand.Next(-50, 50 + 1);
            }

            for (int i = 0; i < szamok2.Length; i++)
            {
                Console.WriteLine(szamok2[i]);
            }

            Console.ReadKey();
        }
    }
}
