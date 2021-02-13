using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira18.Ders2.ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //arraylist'in generic versiyonu
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("bir");

            //<T> : T tipi demek .net framework icerisinde olan veya bizim olusturdugumuz
            //herhangi bir tip demek
            //arraylist'de oldugu gibi boxing-unboxing islemlerine gerek olmuyor

            List<int> listeGeneric = new List<int>();
            listeGeneric.Add(1);
            listeGeneric.Add(2);
            // listeGeneric.Add("metin"); hata verir cunku string girdim

            //olusturdugumuz liste icinde donuyoruz
            for (int i = 0; i < listeGeneric.Count; i++)
            {
                Console.WriteLine(listeGeneric[i]);
            }

            List<string> isimler = new List<string>();
            isimler.Add("Ege Metin");
            isimler.Add("Hatice");
            // isimler.Add(123); hata verir cunku int girdim
            //yukaridaki koleksiyonlar tip guvenli oluyor

            //burada da liste icindeki elemanlari sayiyoruz
            for (int i = 0; i < isimler.Count; i++)
            {
                Console.WriteLine(isimler[i]);
            }



            //simdi de kendi olusturdugumuz musteri nesnesinin list'ini alacagiz

            List<musteri> musteriListe = new List<musteri>();
            //hizli nesne tanimlama yaptim
            musteriListe.Add(new musteri()
            {
                id = 1,
                isim = "Ege Metin",
                soyisim = "ILGAZ"
            });


            //olusturdugumuz liste icinde donuyoruz
            foreach (musteri item in musteriListe)
            {
                Console.WriteLine(item.isim);
            }

            Console.ReadLine();
        }
    }
}
