using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Sistemi
{
    
   public class Teshis
   {
   public string TeshisAdi { get; set; }

   public Teshis(string teshisAdi)
   {
    TeshisAdi = teshisAdi;
   }

        public override string ToString()
        {
            return $"Teşhis: {TeshisAdi}";
        }
    }
   
   
   

   
}
