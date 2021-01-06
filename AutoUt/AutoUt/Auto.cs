using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUt
{
    public class Auto
    {
        public string Tipus { get; set; }
        public int SebessegKmh { get; set; }

        public double EnnyitHalad()
        {
            return SebessegKmh / 3.6;
        }
    }
}
