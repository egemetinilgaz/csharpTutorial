using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira1.Ders6.ParseConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            //parse&convert

            //kullanicidan gelen deger ya da degerleri cevirmek icin kullanilir
            
            //kullanicidan deger aldik
            Console.Write("lutfen 1-10 arasinda bir deger girin: ");
            string gelenDeger = Console.ReadLine(); //aldigimiz deger string
            Console.WriteLine("ilk deger: " + gelenDeger);
            Console.Write("lutfen 1-10 arasinda bir deger girin: ");
            string gelenDeger2 = Console.ReadLine(); //aldigimiz deger string
            Console.WriteLine("ikinci deger: " + gelenDeger2);

            int sayi1 = int.Parse(gelenDeger); //parse yontemi ile int'e cevirdim
            int sayi2 = Convert.ToInt32(gelenDeger2); //convert yontemi ile int'e cevirdim
            int toplam = sayi1 + sayi2 + 15;
            Console.WriteLine("toplam deger: {0}", toplam);

            Console.Clear();

            //parse&convert aralarindaki fark

            string text1 = "250";
            string text2 = null;

            int sayi3 = -1;
            int sayi4 = -1;

            //convert kullanimi

            sayi3 = Convert.ToInt32(text1); //burada cevirir hata vermez, 250 olur
            sayi4 = Convert.ToInt32(text2); //burada da hata vermez ama convert metodu null yerine
            //degiskenin default degerini atar, burada int default degeri 0

            //parse kullanimi

            sayi3 = int.Parse(text1); //burada cevirir hata vermez, 250 olur
            sayi4 = int.Parse(text2); //burada hata verir, parse metodunda default degeri atamaz

            Console.ReadLine();
        }
    }
}
