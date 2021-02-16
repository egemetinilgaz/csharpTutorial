using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira18.Ders4.DictionarySortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic olmayan koleksiyon davranisi
            Hashtable HTList = new Hashtable();
            HTList.Add(1, "bir");
            HTList.Add(2, "iki");
            HTList.Add(3, 3);
            HTList.Add(4, true);
            // HTList.Add(1, "test"); //burada hata verecek
            //cunku key degerleri unique'dirr, yani bir tane olabilir

            //dictionary koleksiyonu => / TKey / TValue


            //buradaki amac hashtable'dan farkli olarak, girilecek key ve value degerlerinin
            //onceden belirlenmesidir, tip guvenlidir yani
            Dictionary<int, string> dictionaryList1 = new Dictionary<int, string>();
            dictionaryList1.Add(1, "bir");
            dictionaryList1.Add(2, "iki");
            dictionaryList1.Add(3, "uc");
            // dictionaryList1.Add(1, "test"); //burada da hata verir
            //cunku key degerleri unique'dir, yani bir tane olabilir

            //deger uzerinde yapilabilecek islemler

            //deger degistirme

            string gelenDeger1 = dictionaryList1[1];
            gelenDeger1 = "yenilenen deger";
            dictionaryList1[1] = gelenDeger1;

            //deger silme
            bool silmeSonuc = dictionaryList1.Remove(2);
            if (silmeSonuc)
            {
                Console.WriteLine("silindi");
            }
            else
            {
                Console.WriteLine("silinemedi");
            }

            //containskey: bizim vermis oldugumuz parametrenin, koleksiyon (key) icinde 
            //olup olmadigina bakar
            //true ya da false doner
            bool arananKeyDeger = dictionaryList1.ContainsKey(1);
            if (arananKeyDeger)
            {
                string gelenDeger = dictionaryList1[1];
                gelenDeger = "yenilenen deger";
                dictionaryList1[1] = gelenDeger;
            }
            else
            {
                Console.WriteLine("aranan deger bulunamadi");
            }

            //containsvalue: bizim vermis oldugumuz parametrenin, koleksiyon (value) icinde 
            //olup olmadigina bakar
            //true ya da false doner
            bool arananValueDeger = dictionaryList1.ContainsValue("uc");
            if (arananKeyDeger)
            {
                Console.WriteLine("aranan deger bulundu");
            }
            else
            {
                Console.WriteLine("aranan deger bulunamadi");
            }

            //dictionarylist1 icindeki degerlerde donme
            //KeyValuePair<int, string> burada sana int ve string gelecek, bunlarin icinde don diyoruz
            foreach (KeyValuePair<int, string> item in dictionaryList1)
            {
                Console.WriteLine("anahtar: {0} || deger: {1}", item.Key, item.Value);
            }

            dictionaryList1.Clear(); //her seyi siler

            //sortedlist dictionary koleksiyonunun ayni islemini yapar
            //cok kucuk bir fark var
            SortedList<int, string> sortedListKoleksiyon1 = new SortedList<int, string>();
            //kucukten buyuge dogru siralayarak yapar
            sortedListKoleksiyon1.Add(100, "yuz");
            sortedListKoleksiyon1.Add(50, "elli");
            sortedListKoleksiyon1.Add(1, "bir");
            sortedListKoleksiyon1.Add(1000, "bin");
        }
    }
}
