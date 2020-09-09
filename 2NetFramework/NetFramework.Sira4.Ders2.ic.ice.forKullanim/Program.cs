using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira4.Ders2.ic.ice.forKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            //ic ice for dongusu kullanimi

            /*burada ic ice for dongusu calistigi surece i degeri her seferinde 1 artarak 
             * j degerinin kosulunu saglayacak ve j degeri de her seferinde kendini yenileyerek
             * donguyu saglayacak*/

            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            Console.Clear();

            //ic ice for dongusu odev
            /*
             * 1*1 = 1
             * 1*2 = 2
             * 
             * 
             * 10*1 = 10
             * 10*2 = 20
             */
            //bunu ekrana yaz

            for (int i = 1; i <= 9; i++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    int carpimSonuc = i * y;
                    Console.Write("{0}*{1}={2} \t", i, y, carpimSonuc);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
