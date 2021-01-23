using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira10.Ders4.StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            personel P1 = new personel();
            P1.isim = "Ege Metin";
            P1.soyisim = "ILGAZ";
            P1.EMailAdres = "egemetinilgaz";
            P1.cinsiyet = 71777001; //71777002 kadin icin

            helper.emailGoner("iem@firmam.com", "yeni personel girisi", P1.isim + P1.soyisim);
            //yukarida ilk cagirdiginda ekran ciktisi asagidaki gibidir
            // helper => static class => static CTOR
            // mail gonderme islemi basarili
            // yani static yapici metot calisti ve isi bitti

            helper.emailGoner("iem@firmam.com", "yeni personel girisi", P1.isim + P1.soyisim);
            //burada ise tekrar cagirilmasina ragmen calismaz ve cikti asagidaki gibi olur
            // mail gonderme islemi basarili
        }
    }
}
