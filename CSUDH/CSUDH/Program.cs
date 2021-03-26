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

            var elso = domains.First();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i+1}.szint:{elso.GetDomain(i+1)}");
            }

            string htmlFajl = "<HTML>\n";
            htmlFajl += "<HEAD>\n";
            htmlFajl += "<TITLE>Domain nevek</TITLE>\n";
            htmlFajl += "</HEAD>\n";
            htmlFajl += "<BODY>\n";
            htmlFajl += "<TABLE>\n";
            htmlFajl += "<TR>\n";
            htmlFajl += "<TH style='text-align:left'>Ssz</TH>\n";
            htmlFajl += "<TH style='text-align:left'>Host domain neve</TH>\n";
            htmlFajl += "<TH style='text-align:left'>Host IP címe</TH>\n";
            
            for (int i = 0; i < 5; i++)
            {
                htmlFajl += $"<TH style='text-align:left'>{i+1}.szint</TH>\n";
            }
            htmlFajl += "</TR>\n";

            //innentől jönnek az adatok
            int sorszam = 1;
            foreach (var j in domains)
            {
                htmlFajl += "<TR>\n";
                htmlFajl += $"<TD style='text-align:left'>{sorszam}</TD>\n";
                htmlFajl += $"<TD style='text-align:left'>{j.DomainName}</TD>\n";
                htmlFajl += $"<TD style='text-align:left'>{j.IpAddress}</TD>\n";
                for (int i = 0; i < 5; i++)
                {
                    htmlFajl += $"<TD style='text-align:left'>{j.GetDomain(i+1)}</TD>\n";
                }

                htmlFajl += "</TR>\n";
                sorszam++;
            }
            htmlFajl += "</TABLE>\n";

            htmlFajl += "</BODY>\n";
            htmlFajl += "</HTML>\n";

            try
            {
                File.WriteAllText("table.html",htmlFajl);
                Console.WriteLine("Kiírás kész!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }


            Console.ReadKey();
        }
    }
}
