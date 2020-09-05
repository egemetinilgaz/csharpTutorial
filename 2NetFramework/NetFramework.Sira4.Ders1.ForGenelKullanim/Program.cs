using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira4.Ders1.ForGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            //for dongusu genel kullanim

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("bir for dongusu ornegi");
            }

            Console.Clear();

            for (int j = 0; j <= 20; j += 2)
            {
                Console.WriteLine("ikise artarak giden dongu ornegi");
            }

            Console.Clear();

            //ekran uzerinde 1-10 arasi degerleri yazdir

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + ". tekrar");
            }


            //1-100 arasindaki cift sayilari yazdir

            for (int sayac = 2; sayac <= 100; sayac += 2)
            {
                Console.WriteLine(sayac);
            }

            //boyle de yazilir

            Console.Clear();

            for (int sayac2 = 1; sayac2 <= 100; sayac2++)
            {
                if (sayac2 % 2 == 0) //sayac2 nin 2 ye bolumunden kalan 0 sa cift sayi olur
                {
                    Console.WriteLine(sayac2 + " - cift sayidir");
                }
            }

            Console.Clear();

            //1-100 arasindaki cift sayilarin toplamini yaz (odev)

            int toplam = 0;

            for (int sayac = 1; sayac <= 100; sayac++)
            {
                if (sayac % 2 == 0)
                {
                    //toplam = toplam + sayac; boyle de yazilir
                    toplam += sayac;
                }
            }
            Console.WriteLine("1-100 arasi cift sayilarin toplami: {0}", toplam);

            Console.Clear();

            //kullanici bir sayi girecek ve bu sayinin faktoriyelini alacaksin ve ekrana yaz

            string kullaniciGelenDeger = string.Empty;
            int kullaniciGelenDegerInt = 0;
            int faktoriyelHesapla = 1;

            Console.WriteLine("faktoriyelini almak istedigin sayiyi gir: ");
            kullaniciGelenDeger = Console.ReadLine();
            kullaniciGelenDegerInt = int.Parse(kullaniciGelenDeger);

            for (int i = kullaniciGelenDegerInt; i >= 1; i--)
            {
                //faktoriyelHesapla = faktoriyelHesapla * i; uzun yol
                faktoriyelHesapla *= i;
            }
            Console.WriteLine("{0} degerinin faktoriyel sonucu: {1}", kullaniciGelenDeger, faktoriyelHesapla);

            Console.ReadLine();

            Console.Clear();

            //sonsuz dongu olusturma

            int sayac1 = 0;
            for (; ; ) //sonsuz dongu standart kalibi
            {
                sayac1++;
                //sonsuz dongude bir sure sonra ram siser ve makina hdd yi ram olarak kullanir
                //bu da islemcinin cok isinmasina neden olur ve makina kendini kapatir

                //break anahtar kelimesi;
                if (sayac1 == 2)
                    break;
                //break komutu ile sart saglansa bile sayac 2 ye esit oldugunda durur

                Console.WriteLine(sayac1);

                Console.Clear();

                //continue anahtar kelimesi;

                int sayac2 = 0;
                for (; ; )
                {
                    sayac2++;
                    if (sayac2 == 2)
                        continue;
                    //continue ifadesi ile sayac 2 oldugunda bir sefere mahsus asagidaki sayac
                    //bloguna gecmeden tekrar donguye girecek ve bu 2 yi atlayarak tekrar
                    //saymaya devam edeceginden sonsuz donguye girecek

                    Console.WriteLine(sayac2);
                }

                Console.WriteLine("bu bir sonsuz dongu ve devamli olarak yazilir");
                Console.ReadLine();

                Console.Clear();
            }

        }
    }
}
