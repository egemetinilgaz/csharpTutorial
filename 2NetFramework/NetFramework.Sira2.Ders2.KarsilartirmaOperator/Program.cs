using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira2.Ders2.KarsilartirmaOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*karsilastirma operatorleri
             * < : kucuktur
             * > : buyuktur
             * <= : kucuk esittir
             * >= : buyuk esittir
             * == : esit esittir
             * != : esit degildir //unlem olumsuzluk getirir
             * is : tur donusumlerinde kullandigimiz operator
             * as : tur donusumlerinde kullandigimiz operator
             */            

            int Sayi1 = 10;
            int Sayi2 = 15;

            //kucuktur operatoru

            bool kucukOperatorSonuc = Sayi1 < Sayi2;
            Console.WriteLine(kucukOperatorSonuc);

            //buyuktur operatoru

            bool buyukOperatorSonuc = Sayi1 > Sayi2;
            Console.WriteLine(buyukOperatorSonuc);

            //kucuk esittir operatoru

            bool kucukEsittirSonuc = Sayi1 <= Sayi2; //kucuk veya esit olmasina bakar
            Console.WriteLine(kucukEsittirSonuc);

            //buyuk esittir operatoru

            bool buyukEsittirSonuc = Sayi1 >= Sayi2;
            Console.WriteLine(buyukEsittirSonuc);

            //esittir / esit degildir

            bool esittirOperatorSonuc = Sayi1 == Sayi2;
            bool esitDegildirOperatorSonuc = Sayi1 != Sayi2;
            Console.WriteLine(esittirOperatorSonuc);
            Console.WriteLine(esitDegildirOperatorSonuc);

            //is - as operatorleri



        }
    }
}
