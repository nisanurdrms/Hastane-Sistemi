using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Sistemi
{
    public class Tedavi
    {
        public string Ilac { get; set; }
        public string TedaviDetayi { get; set; }

        public Tedavi(string ilac, string tedaviDetayi)
        {
            Ilac = ilac;
            TedaviDetayi = tedaviDetayi;
        }

        public override string ToString()
        {
            return $"İlaç: {Ilac}, Tedavi: {TedaviDetayi}";
        }
        
    }

}
