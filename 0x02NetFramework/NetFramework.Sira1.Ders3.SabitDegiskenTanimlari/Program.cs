using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira1.Ders3.SabitDegiskenTanimlari
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;

            sayi1 = 111;

            const int ortakBolumDeger = 2; //const anahtar kelimesi ile sabit deger atadik
            
            int sonuc = sayi1 / ortakBolumDeger;

            ortakBolumDeger = 3; //burada alinan hata ortakbolum bir sabittir ve sen buna deger atamasi yapamazsin

           

        }
    }
}
