using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira7.Ders3.Metot.Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * kullanicidan ogrenci adi, soyadi ve 3 tane ders notu al
             * ogrenci sinifi icinde ogrencipuanhesapla adinda bir metoda parametre olarak ver
             * ekrana yaz
             * ortalama>=45 gecer, ortalama<45 kalir
             */

            string ogrenciAd = string.Empty;
            string ogrenciSoyad = string.Empty;
            decimal not1 = 0;
            decimal not2 = 0;
            decimal not3 = 0;
            //decimal ortalama = 0;

            Console.WriteLine("ortalmasini hesaplamak  istediginiz ogrenci bilgilerini yazin");

            Console.Write("ad: ");
            ogrenciAd = Console.ReadLine();

            Console.Write("soyad:");
            ogrenciSoyad = Console.ReadLine();

            Console.Write("not1: ");
            not1 = decimal.Parse(Console.ReadLine());

            Console.Write("not2: ");
            not2 = decimal.Parse(Console.ReadLine());

            Console.Write("not3: ");
            not3 = decimal.Parse(Console.ReadLine());

            ogrenci O = new ogrenci();
            //not3 degeri ogrenci cs kisminda default olarak 45 ayarlandigi icin burada
            //not3 kismi diger not1 ve not2 parametrelerinden farkli gorunecek
            //burada soyle oluyor, eger not3 e bir not girerse ogrenci onu aliyor
            //not3 e not girilmezse default degeri olan 45 i aliyor
            O.ogrenciNotHesapla(ogrenciAd, ogrenciSoyad, not1, not2, not3);
            Console.ReadLine();
        }
    }
}
