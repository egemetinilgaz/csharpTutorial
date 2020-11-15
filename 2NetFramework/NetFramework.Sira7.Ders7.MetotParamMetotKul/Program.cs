using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira7.Ders7.MetotParamMetotKul
{
    class Program
    {
        //metot parametrelerinde metot kullanimi (ic ice metot kullanimi)

        static void Main(string[] args)
        {
            //bu kod blogunda aslinda decimal toplam degiskeni bellekte fazladan yer kapliyor
            decimal toplam = topla(12M, 45M);
            ekrandaGoster(toplam);

            ekrandaGoster(topla(11M, 44M)); //yukaridakinin ic ice yazimi
            //burada sunu yapiyoruz
            /*
             * ekrandaGoster bana object bir deger ver ben de bunu ekrana yazayim diyor
             * biz bu object degeri (object her seyi kapsar unutma) topla metodundan int olarak veriyoruz
             * yani ekrandaGoster(topla bu sekilde oluyor
             * topla metodunun islem yapmasi icin de 2 tane int turunden degere ihtiyaci var
             * (topla(11M, 44M) onuda boyle yaziyoruz
             * daha sonra hepsini birlestirip ekrandaGoster(topla(11M, 44M)); yaziyoruz
             */

            Console.ReadLine();
        }

        static void ekrandaGoster(object o)
        {
            Console.WriteLine(o.ToString());
        }
        static int topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        static decimal topla(decimal sayi1, decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            return toplam;
        }

        static string topla(string metin1, string metin2)
        {
            return (metin1 + " " + metin2);
        }
    }
}
