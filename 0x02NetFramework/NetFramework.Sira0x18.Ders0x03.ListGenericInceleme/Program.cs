using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira18.Ders3.ListGenericInceleme
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilarim = new List<int>();

            sayilarim.Add(1);

            int[] eklenecekData1 = new int[4]; //int dizi olusturduk
            eklenecekData1[0] = 2;
            eklenecekData1[1] = 3;
            eklenecekData1[2] = 4;
            eklenecekData1[3] = 5;

            //simdi bu datalari sayilarim'a ekleyecegiz

            //1. uzun yol
            for (int i = 0; i < eklenecekData1.Length; i++)
            {
                sayilarim.Add(eklenecekData1[i]);
            }

            //2. yol
            sayilarim.AddRange(eklenecekData1);

            //------------------------------------------------------------

            int capacity = sayilarim.Capacity; //yine 4'er 4'er genisler
            int count = sayilarim.Count;

            //count ve capacity degerlerini esitleme
            sayilarim.TrimExcess();

            capacity = sayilarim.Capacity;
            count = sayilarim.Count;

            //sayilarim koleksiyonu icindeki datayi ekrana yazmak istiyorum
            //for veya foreach ile yapablirim
            //daha kisa bir yol var
            sayilarim.ForEach(i => Console.WriteLine(i));
            //buradaki i degeri, benim verdigim bir deger, baska isim de verebilirdim
            //lambda => ilgili koleksiyon icinde arama yap demek

            //belli bir index'e denk gelen degeri yazdirma
            int bulunanDeger = sayilarim[3];
            Console.WriteLine("List<T> koleksiyonu icerisindeki 3. index'de bulunan deger: {0}", bulunanDeger);

            //simdi eklemek istedigimiz sayiyi araya alip, ondan sonraki index
            //sirasinin hepsini bir asagi kaydiralim
            sayilarim.Insert(1, 7);

            //icerideki degerlerin var olup olmadigini kontrol etme
            //true ya da false doner
            bool kontrol1 = sayilarim.Any(); //burada iceriye tamamen bakar, bir deger varsa bile true
            bool kontrol2 = sayilarim.Any(i => i > 5);
            //yukarida da, i degerini ben verdim baska bir sey de yazabilirdim, ama genel kullanim
            //sen iceride don, 5'den buyuk bir deger varsa bana true dersin, yoksa false diyorum

            //koleksiyon icindeki elemanlari, buyukten kucuge, ya da kucukten buyuge siralama
            sayilarim.Sort(); //A'dan Z'ye dogru siralar, 1'den N'e kadar siralar
            sayilarim.Reverse(); //Z'den A'ya dogru siralar, N'den 1'e kadar siralar

            //koleksiyon icindeki en yuksek degeri bulur
            int enYuksekDeger = sayilarim.Max();
            //koleksiyon icindeki en dusuk degeri bulur
            int enDusukDeger = sayilarim.Min();
            //koleksiyon icindeki degerleri toplar
            int toplamDeger = sayilarim.Sum();

            //dizi icerisinden eleman silme
            //bool deger doner
            bool silmeIslemiSonuc = sayilarim.Remove(100); //degeri listeden cikarir

            //belirtmis oldugumuz degerlere karsilik gelen degerleri siler
            int silinenAdet = sayilarim.RemoveAll(i => i > 3); //burada 3'den buyuk degerleri siler

            //belirttigimiz endex'e gore sileriz
            sayilarim.RemoveAt(2); //2 index'inde bulunan degeri siler, index sirasi kayar

            //komple silme
            sayilarim.Clear();
        }
    }
}
