using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira7.Ders8.MetotLocalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //metot local function
            localFunctionKullanimi(11, 22);
            Console.ReadLine();
        }

        static void localFunctionKullanimi(int sayi1, int sayi2)
        {
            // int toplam = sayi1 + sayi2; normalde boyle yazardik

            //buraya ozel bir metot tasarlayacagim ve toplama islemini burada yapacagim
            //metot icerisindeki islemler sadece o metotda kullanilirsa localfunction yaparsin

            int topla(int gelenSayi1, int gelenSayi2)
            {
                return gelenSayi1 + gelenSayi2;
            }

            int toplamDeger = topla(sayi1, sayi2);

            Console.WriteLine(toplamDeger);
        }
    }
}
