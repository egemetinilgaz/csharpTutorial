using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira9.Ders3.Encapsulation.Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * insan sinifi icinde _tckimliknumarasi adinda private field yapalim
             * set: girilen deger 11 haneli olmali
             * set: girilen degerler sayisal olmasi diyecek
             * 
             * get: deger okunmaz sekilde davransin
             * get: ilk 3 hanesini gosterelim
             */

            insan insan1 = new insan();

            insan1.TCKimlikNumarasi = "14464890466";
            Console.WriteLine(insan1.TCKimlikNumarasi.ToString());
            Console.ReadLine();
        }
    }
}
