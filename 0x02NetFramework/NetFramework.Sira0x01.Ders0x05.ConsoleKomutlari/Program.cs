using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira1.Ders5.ConsoleKomutlari
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullanicidanDeger = string.Empty;

            //bir uygulamanin en temel amaci kullaniciya mesaj gostermektir

            Console.Write("mesaj 1"); //metni ekrana yazar, satir atlamaz imlec oldugu yerde kalir
            Console.WriteLine("mesaj 2"); //metni ekrana yazar, imlec bir alt satira gecer

            //ekranda bulunan tum datayi silmek icin "console.clear();" metodunu kullan

            Console.Clear();

            //temel bir ihtiyac olan kullanicidan deger alma

            Console.Write("lutfen adinizi giriniz: ");
            kullanicidanDeger = Console.ReadLine();

            /*elimizde olan degisken veya degiskenleri kullanarak, kullaniciya bir mesaj gostermenin
             *birden fazla yontemi vardir*/

            //1. yontem

            string mesaj = "girmis oldugunuz isim: " + kullanicidanDeger;
            Console.WriteLine(mesaj);

            Console.Clear();

            //2. yontem

            mesaj = string.Format("girmis oldugunuz isim {0}", kullanicidanDeger);

            //buradaki {0} virgulden sonra gelen ilk degisken sira numarasidir
            //virgulden sonra baska bir deger olsaydi {1} {2} diye dvam edecekti
            //saymaya 0 dan baslar

            Console.Clear();
            
            //3.yontem

            Console.WriteLine("girmis oldugunuz isim {0}", kullanicidanDeger);
                        
            Console.ReadLine();
        }
    }
}
