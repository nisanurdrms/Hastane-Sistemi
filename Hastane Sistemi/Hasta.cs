using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Sistemi
{
    public class Hasta
    {
        
            public string Ad { get; set; }
            public string Soyad { get; set; }

            public Hasta(string ad, string soyad)
            {
                Ad = ad;
                Soyad = soyad;
            }

         
            public override string ToString()
            {
                return $"Hasta: {Ad} {Soyad}";
            }
        

    }
}
