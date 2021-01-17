using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira3.Ders1.if_else.Kullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            //if-else genel kullanim
            
            if (true)
            {
                //dogru ise bu islemleri yap
            }
            else
            {
                //dogru degilse bu islemleri yap
            }

            //if - else baslangic

            int sayi1 = 10;
            int sayi2 = 15;

            bool sonuc = sayi1 < sayi2;
            if (sonuc)
            {
                Console.WriteLine("sayi1 - sayi2 degerinden kucuktur.");
            }
            else
            {
                Console.WriteLine("sayi1 - sayi2 degerinden buyuktur.");
            }

            //yukaridaki kodu daha kisa yazmanin yolu

            if (sayi1 < sayi2)
            {
                Console.WriteLine("sayi1 - sayi2 degerinden kucuktur.");
            }
            else
            {
                Console.WriteLine("sayi1 - sayi2 degerinden buyuktur.");
            }

            //yukaridaki kodu daha kisa yazmanin yolu

            if (sayi1 < sayi2) Console.WriteLine("sayi1 - sayi2 degerinden kucuktur.");
            else Console.WriteLine("sayi1 - sayi2 degerinden buyuktur.");

            //yukarida yazilan kodda if-else blogu tek bir islem/komut yapiyorsa
            //suslu paranteze gerek yok.

            Console.ReadLine();
    
        }
    }
}
