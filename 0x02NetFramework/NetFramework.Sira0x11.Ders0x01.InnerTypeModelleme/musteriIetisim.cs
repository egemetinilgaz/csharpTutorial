using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira11.Ders1.InnerTypeModelleme
{
    public class musteriIetisim
    {
        public int iletisimTip { get; set; } //71777001 mobil, 71777002 sabit
        public string alanKodu { get; set; }
        public string numara { get; set; }
        public bool aktifPasif { get; set; }

        public musteriIetisim()
        {
            Console.WriteLine("musteri iletisim yapici metodu calsiti");
        }
        
        //bu metodu program cs'de cagirma seklini ogreniyorum
        public void musteriIetisimTestMetot()
        {
            Console.WriteLine("musteriIetisimTestMetot");
        }
    }
}
