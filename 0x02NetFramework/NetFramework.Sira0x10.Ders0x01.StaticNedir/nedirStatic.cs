using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira10.Ders1.StaticNedir
{
    internal class nedirStatic
    {
        public string isim { get; set; } //bu sekilde ayni anda hem property hem de field oldu
        //hizli kullanimi prop tab tab
        public string soyIsim { get; set; }
        public string eMailAdres { get; set; }

        public void test1()
        {
            Console.WriteLine("nesne ornegi ALINDIKTAN SONRA calisacak olan metot");
            test2();
            // * static olmayan metot, static olan metodu cagirabilir
        }

        public static void test2() //static
        {
            Console.WriteLine("nesne ornegi ALINMADAN kullanilabilir");
            //test1
            // *static olan metot, static olmayan bir metot vb. cagiramaz
            // *yalnizca static olanlari cagirabilir
        }
    }
}
