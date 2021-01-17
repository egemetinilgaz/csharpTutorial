using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira10.Ders4.StaticClass
{
    public static class helper //artik static class haline geldi
                               //artik static helper'in program cs tarafinda nesnesi alinamaz
                               //kendi icinde ise sadece static field ve static metot barindirir
                               //asagida static olmayan bir sey kullanamazsin
    {
        /*public helper()
        {
           //her nesne ornegi alindiginda, uygulama standart yapici metodu calistirir
        }*/



        //burasi static yapici metot
        static helper() //burada static olarak, yapici bir metot olusturduk, bunlar private olurlar
        {
            //static yapici metotlar, uygulama boyunca bir defa calisir(ilk cagirilma)
            //tekrar cagirdiginda calismazlar
            Console.WriteLine("helper => static class => static CTOR");
        }


        //burasi normal static metot
        public static void emailGoner(string aliciEmailAdres, string konu, string icerik)
        {
            //email gonderme islemi devam edecek.(burada bir simulasyon yaptim)
            Console.WriteLine("mail gonderme islemi basarili");
        }

        /* 
         * static olmayan bir class icinde
         * 1 static ctor
         * 1 normal ctor oldugunda
         * yine ne kadar orneklenirse orneklensin
         * static ctor yalnizca 1 kere calisir
         * 
         */


    }
}
