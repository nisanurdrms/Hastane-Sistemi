using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Sistemi
{

    public class HastaKayit
    {
        public Hasta HastaBilgi { get; set; }
        public Teshis TeshisBilgi { get; set; }
        public Tedavi TedaviBilgi { get; set; }

        public HastaKayit(Hasta hasta, Teshis teshis, Tedavi tedavi = null)
        {
            HastaBilgi = hasta;
            TeshisBilgi = teshis;
            TedaviBilgi = tedavi;
        }


        public string HastaBilgisi()
        {
            return HastaBilgi.ToString();
        }

        public string TeshisBilgisi()
        {
            return TeshisBilgi.ToString();
        }

        public string TedaviBilgisi()
        {
            return TedaviBilgi != null ? TedaviBilgi.ToString() : string.Empty;
        }



    }

}
