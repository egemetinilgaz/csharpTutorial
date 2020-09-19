using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira4.Ders3.ForeachGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            //genel kullanim

            /*foreach (var item in collection)
            {

            }*/

            /*iterassyon= tekerrur, tekrarlama, yineleme anlamina gelir
             * foreach dizi (array) ve koleksiyon (collection) tabanli nesnelerin
             * elemanlari uzerinden ilerleyen, iterasyon gerceklestirerek bu elemanlara
             * is katmanimizi olusturacagimiz bir dongudur*/

            //eleman sayisinin bilinmedigi durumlarda cok kullanislidir

            string[] Isimler = new[] { "Ege Metin ILGAZ", "Rahmi ILGAZ", "Fatma ILGAZ" };

            foreach (string item in Isimler)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.Clear();

            //ornek uygulama //diziler konusunda buraya donecegim ve ornekler yapacagim

            /*
             * int veri tipinde bir dizi olustur
             * kullanicimiz dizinin kac elemanli olacagi bilgisini bize versin
             * dizi icindeki alanlara deger atamasi yapsin
             * dizi icindeki elemanlarin toplamlarini ve ortalamasini ekrana yaz
             */

            Console.WriteLine("olusturmak istediginiz veri kumesinin uzunlugunu gir: ");
            string uygulama1diziUzunluk = Console.ReadLine();
            int uygulamaDiziUzunlukInt = int.Parse(uygulama1diziUzunluk);

            int[] uygulama1Dizi = new int[uygulamaDiziUzunlukInt];

            for (int uygulamaSayac = 0; uygulamaSayac < uygulama1Dizi.Length; uygulamaSayac++)
            {
                Console.WriteLine("{0}. index e denk gelen degeri girin: ", uygulamaSayac);

                uygulama1Dizi[uygulamaSayac] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("dizinin icindeki tum alanlari doldurdunuz.");

            int uygulama1Toplam = 0, uygulama1Ortalama = 0;
            foreach (int item in uygulama1Dizi)
            {
                Console.WriteLine(item);
                uygulama1Toplam = uygulama1Toplam + item;
            }
            Console.WriteLine("toplama islemi sonucu: {0}", uygulama1Toplam);

            Console.WriteLine("dizi icerisindeki eleman sayisi {0}", uygulama1Dizi.Length);
            uygulama1Ortalama = uygulama1Toplam / uygulama1Dizi.Length;
            Console.WriteLine("ortalama islemi sonucu: {0}", uygulama1Ortalama);
            Console.ReadLine();
            Console.Clear();

            /*
             * 20 elemanli bir int dizi olustur
             * degerleri random sinifinin next fonksiyonu ile 1-10 arasinda doldur
             * sonra dizi icindeki elemanlari ekrana yaz
             * ilgili dizi icerisinde kac tane 4 degeri oldugunu bul
             */

            Random Rnd = new Random();

            int[] uygulama2Dizi = new int[20];
            for (int uygulama2Sayac = 0; uygulama2Sayac < uygulama2Dizi.Length; uygulama2Sayac++)
            {
                uygulama2Dizi[uygulama2Sayac] = Rnd.Next(1, 10);
            }

            int uygulama2Bul = 0;

            foreach (int item in uygulama2Dizi)
            {
                Console.WriteLine(item);
                if (item == 4)
                    uygulama2Bul++;
            }

            Console.WriteLine("dizi icindeki 4 degeri {0} adettir", uygulama2Bul);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
