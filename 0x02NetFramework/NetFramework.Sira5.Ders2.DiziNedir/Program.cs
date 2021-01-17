using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira5.Ders1.DiziNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciIsimListesi = new string[5];

            //nasil deger eklenir
            //uygulama saymaya 0 dan baslar
            //0 1 2 3 4 5 6 7 8 9 10
            /*
             * 5 elemanli bir dizi olusturdugum zaman
             * [0] 1. eleman
             * [1] 2. eleman
             * [2] 3. eleman
             * [3] 4. eleman
             * [4] 5. eleman
             */

            ogrenciIsimListesi[0] = "Ege Metin ILGAZ";
            ogrenciIsimListesi[1] = "Hatice ILGAZ";
            ogrenciIsimListesi[2] = "Eda ILGAZ";
            ogrenciIsimListesi[3] = "Fatma ILGAZ";
            ogrenciIsimListesi[4] = "Rahmi ILGAZ";

            //dizi icinden 3. elemani ekrana yazalim

            Console.Write(ogrenciIsimListesi[2]);
            Console.ReadLine();

            //listedeki tum isimleri bir dongu yardimi ile ekrana yazalim
            //foreach ornegi ile yapacagiz

            foreach (string item in ogrenciIsimListesi)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.Clear();

            //item dizi icerisindeki elemanlari ifade eder, ornegin "Ege Metin ILGAZ"
            //in ile dizi icerisindeki degerler bitene kadar donecektir, dizi icerisinde
            //donecek deger kalmadiginda donguden cikacak

            //simdi de ayni islemi for dongusu ile yapalim

            for (int i = 0; i < ogrenciIsimListesi.Length; i++)
            {
                string gelenIsim = ogrenciIsimListesi[i];
                Console.WriteLine(gelenIsim);
            }
            Console.ReadLine();

            //ogrenciIsimListesi.Length demek ogrenciIsimListesi'nin degeri kadar uzunluk demek
            //bunun yerine 5 yazarsak hata alirdik cunku [5] yok, [0]-[4] araligi var
            //Length : uzunluk demektir
        }
    }
}
