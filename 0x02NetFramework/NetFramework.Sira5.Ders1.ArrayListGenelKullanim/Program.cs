using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.Sira5.Ders1.ArrayListGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            int Capacity = 0;
            int Count = 0;

            ArrayList A1 = new ArrayList();

            //tek deger ekleme

            A1.Add("Ege Metin ILGAZ");
            Capacity = A1.Capacity;
            Count = A1.Count;
            A1.Add(100);

            //birden fazla deger ekleme

            ArrayList A2 = new ArrayList();
            A2.Add("Hatice");
            A2.Add("ILGAZ");
            A2.Add("Eda");

            //burada A2 arraylist in icindeki degerleri A1 arraylist e aktardik
            //su an A1 in icinde Ege Metin ILGAZ, 100, Hatice, ILGAZ, Eda var
            A1.AddRange(A2);

            //capacity & count inceleme

            Capacity = A1.Capacity;
            Count = A1.Count;

            //koleksiyon icideki degere ulasma

            object O1 = A1[3];
            string S1 = A1[3].ToString(); //ToString ile string e cevirdik
            int I1 = (int)A1[1];

            //koleksiyon icindeki degeri degistirme

            A1[3] = "Metin ILGAZ"; //A1 in icinde bulunan 3. index degerini degisstirdik

            //dizilerde siralama

            //dizinin mevcut elemanlarini ters olarak siralama

            A1.Reverse(); //mecvut index te en alttaki degeri en uste alir ve terse cevirir

            //A-Z siralama

            A1.Remove(100);
            A1.Sort(); //icerideki elemanlari a dan z ye siralar
                       //ancak bizim dizilerin icinde bir int deger de oldugu icin burada hata alacagiz
                       //o yuzden 100 degerini yukarida 100 degerini sildim

            //koleksiyon yardimci komutlar/metotlarr

            //indexof metodu

            if (A1.Contains("Hatice"))
            {
                int indexDeger = A1.IndexOf("Hatice");
                A1.RemoveAt(indexDeger);
            }
            //burada indexof komutu ile a1 in icinde bulunan hatice nin kacinci index te olduguna bakiyor
            //buldugumuz degeri de silebiliriz kolay bir sekilde

            //contains metodu

            bool Kontrol1 = A1.Contains("Hatice"); //true, hatice A1 in icinde
            bool Kontrol2 = A1.Contains(900); //false 900 A1 in icinde degil
            //Contains komutu A1 in icinde bu deger var mi ona bakar
            //varsa true yoksa false doner

            //toarray metodu

            object[] D1 = A1.ToArray(); //array listin icinde bulunan datalari dizi olarak verir

            //clear metodu

            A1.Clear(); //A1 in icinde ne varsa siler, hic deger kalmaz
            //clear ile temizlediginde count 0 olur ama capacity ayni kalir
            //capacity yi tekrar boyutlandirma asagidaki sekilde olur
            A1.TrimToSize(); //koleksiyon size ini yeniden boyutlandir

            //koleksiyon icindeki degeri silme

            A1.Remove("Metin ILGAZ"); //ilgili index tamamen kalkar, alttaki deger bir uste gelir

            A1.RemoveRange(2, 2); //A1 in 2.index inden baslar ve basladigi index le beraber 2 tane index siler

            A1.RemoveAt(3); //ilgili index (3) tamamen kalkar, alttaki deger bir uste gelir

        }
    }
}
