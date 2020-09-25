using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggvenyek
{
    class Program
    {
        //Függvény deklarációk
        static void Kiir()
        {
            Console.WriteLine("Kukásautó");
        }

        static void Kiir(string szoveg)
        {
            Console.WriteLine(szoveg);
        }

        static void Kiir(string sz1,string sz2)
        {
            Console.WriteLine($"{sz1}-->{sz2}");
        }

        //visszatérési értékkel rendelkező függvények
        static int Osszead(int a,int b)
        {
            return a + b;
        }

        static double Osszead(double a,double b)
        {
            return a + b;
        }

        static void Tombl(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i]+" ");
            }
        }


        static void Main(string[] args)
        {
            Kiir();
            Kiir();
            Kiir("Portaszolgálat");
            Kiir("Izé", "bigyó");
            var a = Osszead(120, 210);
            Console.WriteLine(a);

            Console.WriteLine(Osszead(233, 111));
            Console.WriteLine(Osszead(22.54566, 34.556));

            int[] szamok = { 10, 26, 56, 77, 986, 2334, 677, 8767 };

            //írjon függvényt, amely kilistázza egy tömb elemeit

            Tomblista(szamok);

            Tombl(szamok);

            Console.ReadKey();
        }

        private static void Tomblista(int[] szamok)
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + " ");
            }
        }
    }
}
