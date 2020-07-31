using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira1.Ders4.TurDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sayi1 = byte.MaxValue;
            sayi1 = byte.MinValue;

            //bilincli tur donusumu / explicit cost
            /*deger/degisken farkli bir bir degiskene donusecegi zaman 
             * hangi deger tipine donusecegini belirtmis oldugumuz islemdir
             * bunu kullanirken ozel kod gerekir, yuksek kapasiteli degisken
             * dusuk kapasiteli degiskene donusturulur*/              

            int sayi2 = 125;

            sayi1 = (byte)sayi2; //donusen sayi2, kucuk degere donusuyor

            Console.Write("sayi1: ");
            Console.WriteLine(sayi1);          

            //bilincsiz tur donusumu / implicit cost
            /*dusuk kapasiteli degiskenin, yuksek kapasiteli degiskene donusmesine denir.
             * ozek kod gerekmez*/

            //byte < int < double

            double sayi3 = 10;

            sayi3 = sayi2; //donusen sayi2, buyuk degere donusuyor

            Console.Write("sayi3: ");
            Console.WriteLine(sayi3);

            //checked - unchecked

            unchecked
            {
                sayi2 = 512;
                sayi1 = (byte)sayi2; //burada derleyici beni uyarmiyor, deger kaybi olmasina ragmen
            }

            checked
            {
                sayi2 = 512;
                sayi1 = (byte)sayi2; //burada derleyici beni uyariyor, deger kaybi oldu diye
            }               
            
            Console.Write("sayi1: ");
            Console.WriteLine(sayi1);

            //object nedir

            /*bir veri tipidir
             * .net dunyasindaki her veri tipini tanir, her veri tipi de onu tanir
             * icerisinde matematiksel islemler yapilmaz, ana tipine donusturmek gerekir
             */

            object temelTip = sayi2; //int deger atadik
            temelTip = sayi3; //double deger atadik
            temelTip = new //isimsiz bir class olusturduk
            {
                marka = "KTM",
                model = "DUKE 200",
            };

            temelTip = sayi2; //boxing islemi
            sayi2 = (int)temelTip; //unboxing oldu
            
            Console.Write("");   
            Console.ReadLine();

        }
    }
}
