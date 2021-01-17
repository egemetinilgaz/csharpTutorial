using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira3.Ders4.else_if.Kullanim
{
    class Program
    {
        static void Main(string[] args)
        {
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

            if (ortalama > 0 && ortalama < 45) Console.WriteLine("Zayif");
            else if (ortalama >= 45 && ortalama < 60) Console.WriteLine("Orta");
            else if (ortalama >= 60 && ortalama < 80) Console.WriteLine("İyi");
            else if (ortalama >= 80 && ortalama <= 100) Console.WriteLine("Pekiyi");
            else Console.WriteLine("Hatali Ortalama, notlarinizi kontrol edin.");

            Console.ReadLine();
        }
    }
}
