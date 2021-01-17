using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira2.Ders3.MantiksalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*mantiksal operatorler
             * && : ve operatoru
             * || : veya operatoru
             */

            //&& operatoru

            int sayi1 = 10;
            int sayi2 = 5;
            int sayi3 = 20;

            bool veOperatorSonuc = sayi1 > sayi2 && sayi1 < sayi2; //hepsinin true olmasi gerekir
            /*
             * true - true = true
             * true - false = false
             * false - true = false
             */

            //|| veya operatoru

            bool veyaOperatorSonuc = sayi1 < sayi2 || sayi1 < sayi3; //sartlardan birinin dogru olmasi yeterli
            /*
             * true - false = true
             * false - true = true
             * false - false = false
             */


        }
    }
}
