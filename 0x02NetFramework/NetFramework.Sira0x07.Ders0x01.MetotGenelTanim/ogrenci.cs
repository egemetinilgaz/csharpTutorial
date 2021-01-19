using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira7.Ders1.MetotGenelTanim
{
    public class ogrenci
    {
        public void sayHelloStudent()
        {
            Console.WriteLine("say hello student :)");
            Console.ReadLine();

        }

        /* metot olusturmak icin  gerekli seyler
             * [erisim belirleyicisi] <geri donus degeri> metotadi (parametreler)
             * {
             *    //metodun  calismasi icin gereken kodlarr
             * }
             * 
             * erisim belirleyicisi
             * 
             * public //genelolan, herkesin erisebildigi
             * private //ozel olan, herkesin erisemedigi
             * protected //birbirinden nesne kalitirsa ulasirsin
             * internal //ilgili kutuphane  icinde ulasirsin
             * internal protected //ilgili kutuphaneden veya bir yerden kalitildiysa ulasirsin 
             *
             */

        private void ogrenciMetot1(string ogrendiAdi, string ogrenciSoyadi)
        {
            Console.WriteLine("ogrenci bilgileri:{0} {1}", ogrendiAdi, ogrenciSoyadi);
            Console.ReadLine();
        }

        public void ogrenciMetot2()
        {
            ogrenciMetot1("Ege Metin", "ILGAZ");
            Console.ReadLine();
        }
    }
}
