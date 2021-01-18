using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira6.Ders3.ArrayListOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * kullanici karsisina bir menu gelecek
             * 
             * console.writeline("menu");
             * console.writeline("1- deger ekle");
             * console.writeline("2- deger listele");
             * console.writeline("3- deger ara");
             * console.writeline("4- deger guncelle/duzenle");
             * console.writeline("5- deger sil");
             * console.writeline("6- uygulama cikis");
             * 
             * console.write("ssciniz");
             * 
             * kullaniciyi dinle
             * arraylist tanimla, degerlistesi adinda
             * switch yapisi icinde deger listesi olacak
             * yukaridaki listeyi switch yapisina uyarla
             * kullanici 6 yi secene kadar ekrani temizleyip islem yapsin
             * kutuphaneye collections eklemeyi unutma, array kullanmak icin
             */

            string kullaniciSecim = string.Empty;
            ArrayList degerListesi = new ArrayList();

            do
            {

                Console.Clear();
                Console.WriteLine("*menu*");
                Console.WriteLine("1- deger ekle");
                Console.WriteLine("2- deger listele");
                Console.WriteLine("3- deger ara");
                Console.WriteLine("4- deger guncelle/duzenle");
                Console.WriteLine("5- deger sil");
                Console.WriteLine("6- cikis");

                kullaniciSecim = Console.ReadLine();

                switch (kullaniciSecim)
                {
                    case "1":
                        Console.Write("eklemek istediginiz degeri girin:");
                        string kullaniciDeger = Console.ReadLine();
                        degerListesi.Add(kullaniciDeger);
                        Console.WriteLine("deger eklendi");
                        System.Threading.Thread.Sleep(2000);
                        //bu komut ile 2000 ms yani 2 sn bekler ve devam eder program
                        break;

                    case "2":
                        for (int i = 0; i < degerListesi.Count; i++)
                        {
                            /*burada degerlistesi[i] dememin sebebi
                            * deger listesinin i. degerini al diyoruz
                            * yani o da ++ komutu ile sirayla birer birer artiyor
                            * ve ekrana yaziliyor
                            */
                            Console.WriteLine("{0}. deger = {1}", i, degerListesi[i]);
                        }
                        Console.WriteLine("devam etmek icin bir tusa basin");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine("aramak istediginiz degeri girin: ");
                        string kullaniciAramaDeger = Console.ReadLine();
                        bool kontrol = degerListesi.Contains(kullaniciAramaDeger);
                        if (kontrol)
                        {
                            //alt satiri acikla burada
                            int bulunanIndex = degerListesi.IndexOf(kullaniciAramaDeger);
                            string bulunanDeger = degerListesi[bulunanIndex].ToString();
                            Console.WriteLine("deger bulundu, index sirasi: {0}, deger: {1}",
                                bulunanIndex, bulunanDeger);
                        }
                        else
                        {
                            Console.WriteLine("aradiginiz kriterlerde deger bulunamadi");

                            //deger bulunamazsa kullaniciya bu degeri listeye ekleyelim mi diye sor
                            //yes derse listeye ekle

                            Console.WriteLine("bulunamayan degeri listeye eklemek ister misiniz (Y/N)");
                            string kullaniciEkleCevap = Console.ReadLine();
                            if (kullaniciEkleCevap.ToUpper() == "Y")
                            {
                                Console.WriteLine("eklemek istediginiz yeni degeri girin:");
                                string kullaniciEkleDeger = Console.ReadLine();
                                degerListesi.Add(kullaniciEkleDeger);
                                Console.WriteLine("yeni girmis oldugunuz deger eklendi");
                            }
                            else
                            {
                                Console.WriteLine("islem secmeye devam edebilir ya da cikis yapmak icin 6 ya basabilirsiniz");
                            }

                        }
                        Console.WriteLine("devam etmek icin bir tusa basin");
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine("guncellemek istediginiz degeri girin:");
                        string kullaniciDuzenlenecekDeger = Console.ReadLine();

                        Console.WriteLine("{0} degerini hangi deger ile guncellemek istiyorsunuz",
                            kullaniciDuzenlenecekDeger);
                        string kullaniciYeniDeger = Console.ReadLine();

                        if (degerListesi.Contains(kullaniciDuzenlenecekDeger))
                        {
                            int kullaniciHedefIndex = degerListesi.IndexOf(kullaniciDuzenlenecekDeger);
                            degerListesi[kullaniciHedefIndex] = kullaniciYeniDeger;
                            Console.WriteLine("degeriniz guncellendi");
                        }
                        else
                        {
                            Console.WriteLine("aradiginiz deger listede bulunamadi");
                        }
                        System.Threading.Thread.Sleep(2000);
                        break;

                    case "5":
                        Console.WriteLine("tum degerleri mi silmek istersiniz (Y/N)");
                        string kullaniciSilCevap = Console.ReadLine();

                        if (kullaniciSilCevap.ToUpper() == "Y")
                        {
                            degerListesi.Clear();
                            Console.WriteLine("tum degerler silindi");
                        }
                        else
                        {
                            Console.WriteLine("listede silmek istediginiz degeri girin:");
                            string kullaniciSilDeger = Console.ReadLine();
                            if (degerListesi.Contains(kullaniciSilDeger))
                            {
                                degerListesi.Remove(kullaniciSilDeger);
                                Console.WriteLine("sectiginiz deger silindi");
                            }
                            else
                            {
                                Console.WriteLine("silmek istediginiz deger listede degil");
                            }
                            Console.WriteLine("devam etmek icin bir tusa basin");
                            Console.ReadLine();
                        }
                        break;
                }
            } while (kullaniciSecim != "6");
        }
    }
}
