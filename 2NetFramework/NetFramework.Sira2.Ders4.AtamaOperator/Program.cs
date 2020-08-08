using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira2.Ders4.AtamaOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * = esittir operatoru, degeri gostermis oldugumuz degiskene atar
             * += //sayi1 = sayi1 + 2;
             * -= //sayi1 = sayi1 - 2;
             * /= //sayi1 = sayi1 / 2;
             * *= //sayi1 = sayi1 / 2;
             */

            //esittir operatoru

            int sayi1 = 10;

            // += operatoru

            sayi1 += 2; //sayi1 = sayi1 + 2;
            Console.WriteLine(sayi1);

            // -= operatoru

            sayi1 -= 2; //sayi1 = sayi1 - 2;
            Console.WriteLine(sayi1);

            // *= operatoru

            sayi1 *= 2; //sayi1 = sayi1 * 2;
            Console.WriteLine(sayi1);

            // /= operatoru

            sayi1 /= 2; //sayi1 = sayi1 / 2;
            Console.WriteLine(sayi1);

            //ozel amacli operatorler

            /*farkli bircok konuda karsimiza cikacak
             * ? karar yapilari bolumde incelenecek
             * () tur donusumu islemlerinde boxing - unboxing
             * [] dizi islemlerinde incelenecek
             * new class yapilarinda incelenecek
             */

            //region kullanimi

        }
    }
}
