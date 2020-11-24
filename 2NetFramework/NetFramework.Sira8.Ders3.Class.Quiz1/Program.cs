using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira8.Ders3.Class.Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            arac arac1 = new arac("BMW", "520D", 2020, 1664);
            arac1.alisFiyat = 300000;
            arac1.satisFiyat = 350000; //tahmini fiyat, net satis fiyati degil
            arac1.maxIndirimTutar = 7000;
            //arac1.fiyat = burada fiyati goruntuluyor olmam gerekiyor ancak
            //mudahale edemiyor olmam gerekecek, bu bir sonraki kapsulleme konusunda incelenecek

            arac1.fiyatAta(330000);
            arac1.bilgileriGoruntule();
        }
    }
}
