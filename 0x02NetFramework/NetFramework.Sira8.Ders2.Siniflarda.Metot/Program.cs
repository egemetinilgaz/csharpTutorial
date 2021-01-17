using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira8.Ders2.Siniflarda.Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri M1 = new musteri();

            M1.TCKimlikNo = "12345678912";
            M1.isim = "Ege Metin";
            M1.soyisim = "ILGAZ";
            M1.cinsiyet = 71777001;

            musteri M2 = M1; //burada bir referans verdim, M1 nereyi gosteriyorsa sen de oraya bak dedim

            M2.isim = "Hatice"; //M1'de de deger degisir
            M1.TCKimlikNo = "98765432198"; //M2'de de deger degisir

            bool musteriKontrolEt = M1.musteriKontrol();
        }
    }
}
