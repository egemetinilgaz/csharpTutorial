using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira3.Ders3.if_else.Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            //uc farkli not degerine gore ortalama bulan ve kaldiniz gectiniz yazan bir uygulama yaz

            string isimSoyisim = string.Empty;
            string kullanicidanGelen1 = string.Empty;
            string kullanicidanGelen2 = string.Empty;
            string kullanicidanGelen3 = string.Empty;

            int not1, not2, not3 = 0;

            double ortalama = 0;

            Console.WriteLine("isim soyisim girin: ");

            Console.Write("isim soyisim: ");
            isimSoyisim = Console.ReadLine();

            Console.WriteLine("birinci notu girin: ");
            kullanicidanGelen1 = Console.ReadLine();

            Console.WriteLine("ikinci notu girin: ");
            kullanicidanGelen2 = Console.ReadLine();

            Console.WriteLine("ucuncu notu girin: ");
            kullanicidanGelen3 = Console.ReadLine();

            not1 = int.Parse(kullanicidanGelen1);
            not2 = int.Parse(kullanicidanGelen2);
            not3 = int.Parse(kullanicidanGelen3);

            ortalama = (not1 + not2 + not3) / 3;

            if (ortalama >= 45)
            {
                Console.WriteLine("Merhaba {0}", isimSoyisim);
                Console.WriteLine("ortalama {0} ile gectiniz", ortalama);
            }
            else
            {
                Console.WriteLine("ortalama {0} ile kaldiniz", ortalama);
            }

            Console.ReadLine();

            //boyle de yazilabilir

            int not4, not5, not6, ortalama2; //yukarida not1,not2,not3 kullandigim icin boyle yaptim
            string adSoyad;

            Console.WriteLine("isim soyisim girin: ");
            Console.Write("isim soyisim: ");
            adSoyad = Console.ReadLine();

            Console.WriteLine("birinci notu girin: ");
            not4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci notu girin: ");
            not5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ucuncu notu girin: ");
            not6 = Convert.ToInt32(Console.ReadLine());

            ortalama2 = (not4 + not5 + not6) / 3;

            if (ortalama >= 45)
            {
                Console.WriteLine("Merhaba {0}", adSoyad);
                Console.WriteLine("ortalama {0} ile gectiniz ", ortalama2);
            }
            else
            {
                Console.WriteLine("ortalama {0} ile kaldiniz ", ortalama2);
            }

            Console.ReadLine();
        }
    }
}
