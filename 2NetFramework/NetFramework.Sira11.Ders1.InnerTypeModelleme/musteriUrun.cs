using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira11.Ders1.InnerTypeModelleme
{
    public class musteriUrun
    {
        public int urunID { get; set; }
        public string tanim { get; set; }
        public decimal fiyat { get; set; }

        public musteriUrun()
        {
            Console.WriteLine("musteri urun yapici metodu calisti");
        }

        public void musteriUrunTestMetot()
        {
            Console.WriteLine("musteriUrunTestMetot");
        }

        public void musteriUrunTestMetot2()
        {
            Console.WriteLine("musteriUrunTestMetot2");
        }
    }
}
