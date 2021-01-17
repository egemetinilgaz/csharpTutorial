using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira2.Ders1.AritmatikOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*aritmatiksel operatorler
             * + toplama
             * - cikartma
             * / bolme
             * * carpma
             * % mod alma
             * -- cikartma isleminde kullanacagimiz bir operator
             * ++ toplama isleminde kullanacagimiz bir operator
             * 
             */


            //bu sekilde de yazilabilir
            
            int sayi1, sayi2, toplam;

            Console.WriteLine("birinci sayiyi girin: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayiyi girin: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;

            Console.WriteLine("Toplam: {0}", toplam);

            Console.ReadLine();        
            
            
            //toplama operatoru

            int toplamOperatoruSayi1 = 10;
            int toplamOperatoruSayi2 = 15;
            int toplamOperatoruToplam = toplamOperatoruSayi1 + toplamOperatoruSayi2;
            Console.WriteLine("Toplam: " + toplamOperatoruToplam);

            #region toplama odev
            //odev: ekran uzerinden girilen 2 sayiyi toplayan uygulama yaz
            /*algoritmasini kurarsan; kullanicidan gelen iki tane degere ihtiyacin var
             * bu degerleri int e cevirmen gerekiyor ve toplama islemi yapman gerekiyor*/

            string kullanicidanGelenDeger1 = string.Empty;
            string kullanicidanGelenDeger2 = string.Empty;

            int odevSayi1 = 0;
            int odevSayi2 = 0;

            int odevToplam = 0;

            Console.WriteLine("toplam icin ilk sayiyi girin: ");
            kullanicidanGelenDeger1 = Console.ReadLine();

            Console.WriteLine("toplam icin ikinci sayiyi girin: ");
            kullanicidanGelenDeger2 = Console.ReadLine();

            odevSayi1 = int.Parse(kullanicidanGelenDeger1);
            odevSayi2 = int.Parse(kullanicidanGelenDeger2);

            odevToplam = odevSayi1 + odevSayi2;
            Console.WriteLine("toplam deger: " + odevToplam);

            Console.ReadLine();
            #endregion

            //cikartma operatoru

            int cikartOperatoruSayi1 = 30;
            int cikartOperatoruSayi2 = 10;
            int cikartOperatoruFark = cikartOperatoruSayi1 - cikartOperatoruSayi2;
            Console.WriteLine("Fark: {0}", cikartOperatoruFark);

            #region cikartma odev
            //odev: ekran uzerinden girilen 2 sayinin farkini alan uygulama yaz
            /*algoritmasini kurarsan; kullanicidan gelen iki tane degere ihtiyacin var
             * bu degerleri int e cevirmen gerekiyor ve farkini alan islemi yapman gerekiyor*/

            string kullanicidanGelenDeger3 = string.Empty;
            string kullanicidanGelenDeger4 = string.Empty;

            int odevSayi3 = 0;
            int odevSayi4 = 0;

            int odevFark = 0;

            Console.WriteLine("fark icin ilk sayiyi girin: ");
            kullanicidanGelenDeger3 = Console.ReadLine();

            Console.WriteLine("fark icin ikinci sayiyi girin: ");
            kullanicidanGelenDeger4 = Console.ReadLine();

            odevSayi3 = int.Parse(kullanicidanGelenDeger3);
            odevSayi4 = int.Parse(kullanicidanGelenDeger4);

            odevFark = odevSayi3 - odevSayi4;

            Console.WriteLine("iki sayinin farki: {0}", odevFark);
            Console.ReadLine();
            #endregion

            //bolme operatoru

            int bolmeOperatoruSayi1 = 30;
            int bolmeOperatoruSayi2 = 2;
            int bolmeOperatoruSonuc = bolmeOperatoruSayi1 / bolmeOperatoruSayi2;
            Console.WriteLine("Bolum: {0}", bolmeOperatoruSonuc);

            #region bolme odev
            //odev: ekran uzerinden girilen 2 sayinin bolumunu alan uygulama yaz
            /*algoritmasini kurarsan; kullanicidan gelen iki tane degere ihtiyacin var
             * bu degerleri int e cevirmen gerekiyor ve bolumunu alan islemi yapman gerekiyor*/

            string kullanicidanGelenDeger5 = string.Empty;
            string kullanicidanGelenDeger6 = string.Empty;

            int odevSayi5 = 0;
            int odevSayi6 = 0;

            int odevBolum = 0;

            Console.WriteLine("bolum icin ilk sayiyi girin: ");
            kullanicidanGelenDeger5 = Console.ReadLine();

            Console.WriteLine("bolum icin ikinci sayiyi girin: ");
            kullanicidanGelenDeger6 = Console.ReadLine();

            odevSayi5 = int.Parse(kullanicidanGelenDeger5);
            odevSayi6 = int.Parse(kullanicidanGelenDeger6);

            odevBolum = odevSayi5 / odevSayi6;

            Console.WriteLine("bolum: {0}", odevBolum);
            Console.ReadLine();
            #endregion

            //carpma operaatoru

            int carpmaOperatoruSayi1 = 10;
            int carpmaOperatoruSayi2 = 2;
            int carpmaOperatoruSonuc = carpmaOperatoruSayi1 * carpmaOperatoruSayi2;
            Console.WriteLine("Carpim: {0}", carpmaOperatoruSonuc);

            #region carpma odev
            //odev: ekran uzerinden girilen 2 sayinin carpimini alan uygulama yaz
            /*algoritmasini kurarsan; kullanicidan gelen iki tane degere ihtiyacin var
             * bu degerleri int e cevirmen gerekiyor ve carpimini alan islemi yapman gerekiyor*/

            string kullanicidanGelenDeger7 = string.Empty;
            string kullanicidanGelenDeger8 = string.Empty;

            int odevSayi7 = 0;
            int odevSayi8 = 0;

            int carpim = 0;

            Console.WriteLine("carpim icin ilk sayiyi girin: ");
            kullanicidanGelenDeger7 = Console.ReadLine();

            Console.WriteLine("carpim icin ikinci sayiyi girin: ");
            kullanicidanGelenDeger8 = Console.ReadLine();

            odevSayi7 = int.Parse(kullanicidanGelenDeger7);
            odevSayi8 = int.Parse(kullanicidanGelenDeger8);

            carpim = odevSayi7 * odevSayi8;

            Console.WriteLine("Carpim: " + carpim);
            Console.ReadLine();
            #endregion

            //mod alma

            int modOperatoruSayi1 = 10;
            int modOperatoruSayi2 = 3;
            int modOperatoruSonuc = modOperatoruSayi1 % modOperatoruSayi2;
            Console.WriteLine("Mod: " + modOperatoruSonuc);

            #region mod alma odev
            //odev: ekran uzerinden girilen 2 sayinin modunu alan uygulama yaz
            /*algoritmasini kurarsan; kullanicidan gelen iki tane degere ihtiyacin var
             * bu degerleri int e cevirmen gerekiyor ve modunu alan islemi yapman gerekiyor*/

            string kullanicidanGelenDeger9 = string.Empty;
            string kullanicidanGelenDeger10 = string.Empty;

            int odevSayi9 = 0;
            int odevSayi10 = 0;

            int mod = 0;

            Console.WriteLine("mod almak icin ilk sayiyi girin: ");
            kullanicidanGelenDeger9 = Console.ReadLine();

            Console.WriteLine("mod almak icin ikinci sayiyi girin: ");
            kullanicidanGelenDeger10 = Console.ReadLine();

            odevSayi9 = int.Parse(kullanicidanGelenDeger9);
            odevSayi10 = int.Parse(kullanicidanGelenDeger10);

            mod = odevSayi9 % odevSayi10;

            Console.WriteLine("alinan mod: {0}", mod);
            Console.ReadLine();
            #endregion

            //-- ve ++ operatorleri

            int aritmatikselsayi = 40;

            aritmatikselsayi++; //aritmatikselSayi = aritmatikselSayi + 1; //bir arttir demek
            aritmatikselsayi--; //aritmatikselSayi = aritmatikselSayi - 1; //bir azalt demek
            aritmatikselsayi += 5;
            Console.WriteLine(aritmatikselsayi);
            Console.ReadLine();
        }
    }
}
