using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira4.Ders4.WhileKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            /*while (true)
            {
            
            }
                /* while (true) //sartimiz true oldugu surece dongu calismasina dvam eder
            
                /*
                 * 1- while (false) olana kadar devam eder
                 * 2- dongu icerisinde bir yerde break kullanirsan donguden cikmis oluruz
                 */

            //ornek kullanim 1: 1-10 arasi sayilari yaz

            //for ile yazdigim

            /*for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.Read();
            Console.Clear();*/

            //while ile yazdigim

            int sayac = 1;

            while (sayac <= 10)
            {
                Console.WriteLine(sayac);
                sayac++;
            }
            Console.ReadLine();

            //aslinda while dongusu bu islem icin kullanilmaz ama burada mantigi anlamak icin
            //for dongusu kullanip bunu daha sonra while ile yaptim

            //while dongusunun asil amaci bir silemin sonucu true olana kadar kullanmaktir
        }
    }
}

