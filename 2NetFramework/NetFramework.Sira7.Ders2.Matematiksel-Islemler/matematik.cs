using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira7.Ders2.Matematiksel_Islemler
{
    public class matematik
    {
        //topla metodu yaz
        public decimal toplamaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 + sayi2;
            return sonuc;
        }

        //cikar metodu yaz
        public decimal cikartmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }

        //carp metodu yaz
        public decimal carpmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;
        }

        //bolme metodu yaz
        public decimal bolmeIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }

        //menu metodu yap

        public void menuHazirla()
        {
            Console.Clear();
            Console.WriteLine("***menu***");
            Console.WriteLine("1- toplama");
            Console.WriteLine("2- cikartma");
            Console.WriteLine("3- carpma");
            Console.WriteLine("4- bolme");
            Console.Write("islem icin bir deger secin: ");
        }

        //sonucu ekrana yazma metodu

        public void sonucEkranaYaz(decimal kullaniciSayi1, string operators,
            decimal kullaniciSayi2, decimal sonuc)
        {
            Console.WriteLine("{0} {1} {2} = {3}", kullaniciSayi1, operators, kullaniciSayi2, sonuc);
        }
    }
}
