using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira3.Ders5.@if.elseif.Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanicidan gelen degerlere 4 islem yaptırma (secim yaparak)

            string kullanicidanGelenDeger1 = string.Empty;
            string kullanicidanGelenDeger2 = string.Empty;
            string kullaniciGelenSecim = string.Empty;

            int sayi1 = 0;
            int sayi2 = 0;

            int sonuc = 0;

            Console.Write("ilk sayiyi girin: ");
            kullanicidanGelenDeger1 = Console.ReadLine();

            Console.Write("ikinci sayiyi girin: ");
            kullanicidanGelenDeger2 = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("isleminizi secin: ");
            Console.WriteLine("1 - toplama");
            Console.WriteLine("2 - cikartma");
            Console.WriteLine("3 - carpma");
            Console.WriteLine("4 - bolme");
            Console.Write("seciminiz: ");
            kullaniciGelenSecim = Console.ReadLine();

            sayi1 = int.Parse(kullanicidanGelenDeger1);
            sayi2 = int.Parse(kullanicidanGelenDeger2);

            if (kullaniciGelenSecim == "1")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (kullaniciGelenSecim == "2")
            {
                sonuc = sayi1 - sayi2;
            }
            else if (kullaniciGelenSecim == "3")
            {
                sonuc = sayi1 * sayi2;
            }
            else if (kullaniciGelenSecim == "4")
            {
                sonuc = sayi1 / sayi2;
            }
            else
            {
                Console.WriteLine("aralik disinda deger girisi");
            }

            //yukarida her islemin altina tek tek yazmak yerine (Console.WriteLine) bunu yaptik            
            if (sonuc != 0)
                Console.WriteLine("islemin sonucu {0}", sonuc);

            Console.ReadLine();

            //boyle de yazilabilir

            int sayi3, sayi4;
            string secim;
            
            Console.WriteLine("ilk sayiyi girin: ");
            sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayiyi girin: ");
            sayi4 = Convert.ToInt32(Console.ReadLine());

            int toplamSonuc = sayi3 + sayi4;
            int farkSonuc = sayi3 - sayi4;
            int carpimSonuc = sayi3 * sayi4;
            int bolumSonuc = sayi3 / sayi4;            

            Console.WriteLine("isleminizi secin: ");
            Console.WriteLine("1- toplama");
            Console.WriteLine("2- cikartma");
            Console.WriteLine("3- carpma");
            Console.WriteLine("4- bolme");

            secim = Console.ReadLine(); //buna dikkat et, kullandigin degiskeni mutlaka oku

            if (secim == "1")
            {
                Console.WriteLine("toplam {0}", toplamSonuc);
            }
            else if (secim == "2")
            {
                Console.WriteLine("fark {0}", farkSonuc);
            }
            else if (secim == "3")
            {
                Console.WriteLine("carpim {0}", carpimSonuc);
            }
            else if (secim == "4")
            {
                Console.WriteLine("bolum {0}", bolumSonuc);
            }
            else
            {
                Console.WriteLine("aralik disinda deger girisi");
            }
            Console.ReadLine();

        }
    }
}
