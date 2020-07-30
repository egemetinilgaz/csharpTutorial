using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira1.Ders1.DegiskenNedir
{
    class Program
    {
        static void Main(string[] args)
        {  //ust islem blok

            //degisken tanimi: veritipi degiskenisim
            string isim; //string metinsel veri tipidir, " " icinde yazilir
            isim = "Metin";
            //= atama operatorudur

            Console.Write("Kullanici Adi: ");
            Console.WriteLine(isim);

            //ekran ciktisi
            //Kullanici Adi: Metin

            int i = 4;
            int y = i;

            Console.Write("i nin degeri: ");
            Console.WriteLine(i);
            Console.Write("y nin degeri: ");
            Console.WriteLine(y);

            y = 10;

            /*burada i nin degeri 4 olarak kalirken, y nin degeri 
             * 10 olarak degisecek, cunku stack bolgede tanimlamis oldugumuz
             * degiskenler kopyalanarak cogalir, temel veri tipleri stack
             * bolgesinde saklanir ve bu degiskenler
             * kendi uzerindeki degeri bilir*/
            
            Console.Write("i nin degeri: ");
            Console.WriteLine(i);
            Console.Write("y nin degeri: ");
            Console.WriteLine(y);

            int sayi1 = 0;

            sayi1 = int.MinValue;
            Console.WriteLine("en dusuk deger: ");
            Console.WriteLine(sayi1);

            sayi1 = int.MaxValue;
            Console.WriteLine("en yuksek deger: ");
            Console.WriteLine(sayi1);

            //bolum sonunda odev gelecek
            double sayi2 = double.MinValue;

            //alt islem blok
            {
                //burasi alt islem blok

                int toplam = 30;
                Console.WriteLine(toplam);
                toplam = 40;

                sayi2 = 100; //ust islem blogunda tanimlandigi icin bunu burada kullanabiliriz
            }

            Console.WriteLine(sayi2);

            //kendi icinde tanimlanan, kullanilan her sey faaliyet alani bittiginde kaybolur
            //ancak faaliyet alani ustunde tanimladigimiz her seye ulasir, deger atar, silersin
            //alt islem blogundan ciktiginda ust islem blogunda yaptigimiz islem kaybolmaz, calismaya devam eder

            Console.ReadLine();
            /*bu komut ekranin hemen kapanmamasini saglar
             * gercek amaci bu degil ama onu da daha sonra ogrenecegiz*/
        }
    }
}
