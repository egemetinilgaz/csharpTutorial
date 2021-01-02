using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira11.Ders1.InnerTypeModelleme
{
    public class musteriAdres
    {
        //inner type icin listem
        public string adresTip { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public String adres { get; set; }

        public musteriAdres() //yapici metot
        {
            Console.WriteLine("musteri adres yapici metodu calisti");
        }

        //bu metodu program cs'de cagirma seklini ogreniyorum
        public void musteriAdresTestMetot()
        {
            Console.WriteLine("musteriAdresTestMetot");
        }
    }
}
