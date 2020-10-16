using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira6.Ders5.Hash.Table.Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * hashtable icine eng-tr olarak data ekle
             * kullanici her data eklendiginde soru sorsun, yeni eklemek ister misin diye
             * y/n seklinde sor, y derse eklemeye devam et
             * n ye basarsa tum listeyi yazir
             * var olan bir key eklerse, zaten bu deger var de
             */

            Hashtable sozlukVeriTabani = new Hashtable();

            do
            {
                Console.Clear();
                Console.WriteLine("eklemek istediginiz sozluk degerini girin:");
                Console.Write("ENG: ");
                string eng = Console.ReadLine();

                //burada kullanicinin ekledigi kelime veri tabaninda var mi kontrol ediyorum
                bool kontrol = sozlukVeriTabani.ContainsKey(eng);
                if (kontrol)
                {
                    Console.WriteLine("eklemek istediginiz {0} kelimesi " +
                        "sozluk icerisinde bulunmaktadir. {0} kelimesinin  " +
                        "turkce karsiligi {1}", eng, sozlukVeriTabani[eng].ToString());
                    //sozlukVeriTabani[eng] burada sozlukVeriTabani'nin eng index ini yaziyor
                    //yani car araba dersen, arabayi yaziyor(car key, araba value)
                }
                else
                {
                    //kullanicinin ekledigi eng kelime veri tabaninda yoksa buradan devam eder
                    Console.WriteLine("{0} ingilizce kelimesinin turkce karsiligini yazin", eng);
                    string tr = Console.ReadLine();
                    sozlukVeriTabani.Add(eng, tr);
                    Console.WriteLine("deger ekleme basarili");
                }

                Console.WriteLine("yeni deger eklemek ister misiniz (Y/N)");

            } while (Console.ReadLine().ToUpper() != "N");

            //1.yontem
            foreach (var item in sozlukVeriTabani.Keys)
            {
                Console.WriteLine("eng: {0}  tr: {1}", item, sozlukVeriTabani[item]);
                //sozlukVeriTabani[item] burada sozlukVeriTabani'nin item index ini yaziyor
                //yani car araba dersen, arabayi yaziyor(car key, araba value)
            }

            //2. yontem
            //DictionaryEntry yerinde var yaziyordu
            foreach (DictionaryEntry item in sozlukVeriTabani)
            {
                //burada sozluk  veri tabanindakiher bir item'in ne oldugunu ogrenmem gerekiyor
                //tip donusumune girmem gerekiyor
                // Console.WriteLine(item.GetType().Name); bu komut ile gercek tipe ulastim
                //var yerine yazilacak gercek tipin DictionaryEntry oldugunu gorduk ve degistirdim
                Console.WriteLine("eng: {0}  tr: {1}", item.Key, item.Value);
            }
            Console.ReadLine();
        }
    }
}
