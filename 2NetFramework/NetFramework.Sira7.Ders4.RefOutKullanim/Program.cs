using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira7.Ders4.RefOutKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref ve out anahtar sozcuklerinde eski .net versiyonlarinda bir fark vardi
            //mevcut framework versiyonlarinda bu fark ortadan kalkti

            //deger tipli davranistan referans tipli davranisa gecmemize olanak saglar

            //esskiden aralarindaki fark suydu
            //ref kullanirken main kismindaki sayi1 in deger almasi zorunluydu
            //out kullanirken de yine bir deger almasi gerekiyordu ama bu deger
            //main kisminda olmayan metotda da verilebiliyordu

            int sayi1 = 0; //ref kullanirken burada deger vermek zorundaydik ama bu eksidendi
            degerAta(ref sayi1);
        }

        static void degerAta(ref int gelenDeger)
        {
            //sayi1 = 0; //out kullanirken burada yapiyorduk ama bu eskidendi
            gelenDeger = 10;
        }

        //simdi yeni .net surumleride deger vermeden islemlerimize devame edebiliyoruz 
    }
}
