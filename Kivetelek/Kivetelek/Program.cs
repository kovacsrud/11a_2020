using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                try
                {
                    throw new ArgumentOutOfRangeException();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Beágyazott try-catch");
                    Console.WriteLine(ex.Message);
                }

                

                Console.Write("Adj meg egy számot:");
                var szam = Convert.ToInt32(Console.ReadLine());

               

            }
            catch(FormatException ex)
            {
                Console.WriteLine("Számot kell megadni!");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Túl nagy a szám értéke!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine("A try-catch után folytatódik a program");
            Console.ReadKey();
        }
    }
}
