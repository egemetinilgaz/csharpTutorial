using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira7.Ders6.MetotAsiriYuklenme
{
    class Program
    {
        static void Main(string[] args)
        {
            //metot asiri yuklenme

            Console.WriteLine("hello world");
            //burada Console.WriteLine() yaptigin an solda 19 tane secenek ciktigini goreceksin
            //iste bu metotlara asiri yuklenmedir
            Console.WriteLine(true); //bu da console sinifinin writeline metodunun bir parcasi

            topla(12, 10); //burada da topla dedigim an 3 tane secenek geliyor
            //bu secenekler int, decimal ve string islemler icin, iste bu asiri yuklenme
        }

        //simdi de ben bir metot olusturup, ayni metot adiyla birden fazla parca olusturup
        //metoda asiri yuklenme yapacagim
        //toplam 3 tane yapacagim

        static void topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("toplam: {0}", toplam);
        }

        static void topla(decimal sayi1, decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            Console.WriteLine("toplam: {0}", toplam);
        }

        static void topla(string metin1, string metin2)
        {
            Console.WriteLine(metin1 + " " + metin2);
        }
    }
}
