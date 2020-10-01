using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira4.Ders8.Do.While.Quiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*kullanici 1 ile x arasinda bir sayi girsin
             * daha sonra sistem kullanicinin girmis oldugu 1-x arasinda bir sayi tahmin etsin
             * daha sonra kullanici sistemin tahmin etmis oldugu sayiyi bulsun
             * bulamazsa yeniden sorsun
             * kullanici ne zaman bulursa y kadar denediniz ve sonuca ulastiniz desin.
             */

            int odevTahmin = 0;
            int odevUretilenSayi = 0;
            int sayac = 0;

            Console.WriteLine("tahmin icin bir sayi girin: ");
            int odevKullaniciMaxValue = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            odevUretilenSayi = rnd.Next(1, odevKullaniciMaxValue);

            do
            {
                sayac++;
                Console.WriteLine("{0}. deneme, uretilen sayiyi tahmin et", sayac);
                odevTahmin = int.Parse(Console.ReadLine());

            } while (odevTahmin != odevUretilenSayi);

            Console.WriteLine("{0}. defa denediniz, sayiyi tahmin ettiniz, dogru sayi {1}", sayac, odevUretilenSayi);
            Console.ReadLine();

        }
    }
}
