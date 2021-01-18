using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira4.Ders7.Do.While.Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * kullaniciyi do while icerisine al ve kullanici adi sifre sor
             * kullanici adi : Demo
             * sifre : Demo
             * dogru girerse donguden cik ve giris basarili yaz
             * yanlis girerse kullanici adi ve sifre sormaya devam et
             */

            string kullaniciAdi = string.Empty;
            string KullaniciSifre = string.Empty;
            int sayac = 0;

            do
            {
                /*
                 * sayac ile kontrol onemli
                 * do while icerisinde herhangi bir if kontrolu yapmadık
                 * while (sart) blogu icinde kontrol yaptik
                 * bu yuzden degerin yanlis veya dogru oldugunu sayac degiskeni ile kontrol ettik
                 */

                if (sayac > 0)
                    Console.WriteLine("kullanici adi veya sifre hatali");
                Console.WriteLine();

                Console.WriteLine("kullanici adini girin: ");
                kullaniciAdi = Console.ReadLine();

                Console.WriteLine("sifre giriniz: ");
                KullaniciSifre = Console.ReadLine();

                sayac++;
                //degerleri bir alt satirda kontrol ediyoruz
            } while (kullaniciAdi.ToLower() != "demo" || KullaniciSifre.ToLower() != "demo");

            //To.Lower: string e atanan tüm karakterleri kucuk harf yapar
            //kullanici Demo - demo - DeMo yazsa da olacak

            Console.WriteLine("basarili kullanici girisi");

            Console.ReadLine();
        }
    }
}
