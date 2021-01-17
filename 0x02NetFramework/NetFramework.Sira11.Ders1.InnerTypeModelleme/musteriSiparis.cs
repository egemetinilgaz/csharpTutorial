using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira11.Ders1.InnerTypeModelleme
{
    public class musteriSiparis
    {
        public string musteriSiparisNumarasi { get; set; }

        //burada inner type icinde inner type olusturduk
        public musteriUrun[] musteriUrunler;

        public musteriSiparis() //yapici metot olusturduk
        {
            musteriUrunler = new musteriUrun[2];
        }

        //bu metodu program cs'de cagirma seklini ogreniyorum
        public void musteriSiparisTestMetot()
        {
            Console.WriteLine("musteriSiparisTestMetot");
        }

    }
}
