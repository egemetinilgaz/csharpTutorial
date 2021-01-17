using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira7.Ders2.Matematiksel_Islemler
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanicidan 2 deger alip 4 islem yaptir,  metot ile yap

            matematik M = new matematik();
        yenidenIslemYap: //burasi bir lable
        yenidenSecim: //kullanici hatali deger girerse buraya donecek

            M.menuHazirla();
            int kullaniciSecim = int.Parse(Console.ReadLine());

            if (kullaniciSecim > 4 || kullaniciSecim < 1)
            {
                Console.WriteLine("hatali deger girisi yaptiniz");
                Console.WriteLine("1-4 araliginda yeniden secim yapin ");
                System.Threading.Thread.Sleep(3000);
                goto yenidenSecim;
            }

            Console.WriteLine("birinci sayiyi girin: ");
            decimal kullaniciSayi1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("ikinci sayiyi girin: ");
            decimal kullaniciSayi2 = decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;

            switch (kullaniciSecim)
            {
                case 1: //toplama islemi
                    sonuc = M.toplamaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, "+", kullaniciSayi2, sonuc);
                    break;
                case 2: //cikartma islemi
                    sonuc = M.cikartmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, "-", kullaniciSayi2, sonuc);
                    break;
                case 3: //carpma islemi
                    sonuc = M.carpmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, "*", kullaniciSayi2, sonuc);
                    break;
                case 4: //bolme islemi
                    sonuc = M.bolmeIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, "/", kullaniciSayi2, sonuc);
                    break;
                //hocanin vermis oldugu ve cevapladigi bu odevde
                //program yukaridaki if dongusu olmadan default alanina girmiyor
                //nedenini anlamadim ve yukariya kendim if blogu koydum
                default:
                    Console.WriteLine("girmis oldugunuz deger, liste icinde bulunamadi");
                    Console.WriteLine("yeniden bir deger girin");
                    System.Threading.Thread.Sleep(2000);
                    goto yenidenIslemYap; //burada kullanici farkli bir 
                    //deger girerse basa donmesini sagliyoruz
            }
            //burasi do while ile de yapilablirdi
            Console.WriteLine("yeni bir islemyapmak ister misiniz ? (Y/N) ");
            string YN = Console.ReadLine();
            if (YN.ToUpper() == "Y")
            {
                goto yenidenIslemYap; //tepedeki lable a gider
            }
        }
    }
}
