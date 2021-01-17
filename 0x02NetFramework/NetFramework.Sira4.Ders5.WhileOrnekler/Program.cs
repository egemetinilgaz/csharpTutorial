using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira4.Ders5.WhileOrnekler
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanicidan bir sayi al ve bu sayi 0 a esit olana kadar ekrana yaz
            //while ile yap

            Console.WriteLine("bir sayi girin: ");
            string kullanicidanGelenDeger = Console.ReadLine();
            Console.WriteLine("girmis oldugunuz sayi yukarida");
            int sayac = int.Parse(kullanicidanGelenDeger);

            while (sayac != -1)
            {
                Console.WriteLine(sayac);
                sayac = sayac - 1;
                //ya da sayac--; de denilebilirdi
            }
            Console.ReadLine();
            Console.Clear();

            //kullanicidan gelen degerlerin toplamini ekrana yaz, 0 dan kucuk bir deger girilirse
            //toplama islemi dursun ve ekrana toplam sonucu yazalım

            Console.WriteLine("toplamak istediginiz rakamlari girin: ");
            Console.WriteLine("-1 ve daha kucuk bir deger islemi durdurur.");

            int toplamDeger = 0;

            while (true)
            {
                string kullaniciGelenDeger = Console.ReadLine();
                int kullaniciGelenDegerInt = int.Parse(kullaniciGelenDeger);
                if (kullaniciGelenDegerInt < 0)
                    break;
                else toplamDeger = toplamDeger + kullaniciGelenDegerInt;
            }
            Console.WriteLine("toplam deger: {0}", toplamDeger);
            Console.ReadLine();

        }
    }
}
