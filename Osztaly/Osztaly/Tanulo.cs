﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly
{
    public class Tanulo
    {
      

        public string Nev { get; set; }
        public int Magassag { get; set; }
        public int Suly { get; set; }
        public int Szulev { get; set; }

        public Tanulo(string nev, int magassag, int suly, int szulev)
        {
            Nev = nev;
            Magassag = magassag;
            Suly = suly;
            Szulev = szulev;
        }


    }
}
