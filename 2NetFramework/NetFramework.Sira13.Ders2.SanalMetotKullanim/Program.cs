using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira13.Ders2.SanalMetotKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            televizyon T1 = new televizyon();
            T1.ekranaYaz("urunden kalitildigi icin, urun nesnesi altindaki metodu yazar");

            urun U1 = new urun();
            //burada urun class'inda override oldugu icin kendi icindeki hali ile calisiyor
            U1.ekranaYaz("bu metot urun nesnesi icerisinden cagirildi");

            baseClass B1 = new baseClass();
            B1.ekranaYaz("bu metot baseClass nesnesi icerisinden cagirildi");



            Console.ReadLine();

        }
    }
}
