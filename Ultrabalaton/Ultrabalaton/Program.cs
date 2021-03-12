﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultrabalaton
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();

            try
            {
                var sorok = File.ReadAllLines("ub2017egyeni.txt",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    versenyzok.Add(new Versenyzo(sorok[i]));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"3.feladat Egyéni indulók:{versenyzok.Count} fő");

            var nok100 = versenyzok.FindAll(x=>x.Kategoria=="Noi" && x.Tavszazalek==100).Count;

            Console.WriteLine($"4.feladat Célba érkező női sportolók:{nok100} fő");

            Console.Write("Adja meg egy sportoló nevét:");
            var sportoloNev = Console.ReadLine();





            Console.ReadKey();
        }
    }
}
