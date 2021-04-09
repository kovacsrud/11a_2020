using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KivetelGyak
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            var b = 0;
            var c = 0;
            try
            {
                Console.Write("A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine($"C:{c}");
                throw new SajatHiba("Saját hiba!");

            }
            catch (SajatHiba ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Számot kell megadni a bekérésnél!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Nullával nem lehet osztani!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("A finally ág kódja mindig lefut");
                a = 0;
                b = 0;
                c = 0;
            }

            Console.WriteLine($"A:{a},B:{b},C:{c}");

            Console.ReadKey();
        }
    }
}
