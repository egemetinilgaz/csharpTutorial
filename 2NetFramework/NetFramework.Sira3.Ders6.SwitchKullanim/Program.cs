using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira3.Ders6.SwitchKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            //if - else if ile yaptigimiz uygulamayi switch ile yapiyoruz

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

            switch (kullaniciGelenSecim)
            {
                case "1": //case leri if gibi dusun
                    sonuc = sayi1 + sayi2;
                    break;
                case "2":
                    sonuc = sayi1 - sayi2;
                    break;
                case "3":
                    sonuc = sayi1 * sayi2;
                    break;
                case "4":
                    sonuc = sayi1 / sayi2;
                    break;
                default: // default u da else gibi dusun
                    Console.WriteLine("1-4 arasinda bir deger secin");
                    break;
            }
        }
    }
}
