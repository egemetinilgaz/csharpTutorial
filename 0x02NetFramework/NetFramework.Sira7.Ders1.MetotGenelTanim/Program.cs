using System; //bir kutuphane dosyasini uygulama icirisine ekler
using System.Collections.Generic; //kutuphane
using System.Linq; //kutuphane
using System.Text; //kutuphane
using System.Threading.Tasks; //kutuphane

namespace NetFramework.Sira7.Ders1.MetotGenelTanim
{
    class Program
    {
        static void Main(string[] args) //burasi metot, main metodu
        {
            //yukaridaki using.system kutuphanesini kullanmadan uzun yazalim
            System.Console.Write("1hello");
            //kutuphaneyi kullandigimizda da boyle olur
            Console.Write("2hello");
            Console.WriteLine("");

            //yukaridaki 5 kutuphanenin ozellikle neden eklenmis oldugunu ogrenelim
            /*
             * gelen kutuphanaler .net framework versiyonlari ile degisir
             * yenilendikce guncellenir, kolaylik saglar
             */

            //namespace kismi kutuphane adini icerir, isim uzayidir
            //baska br uygulamada kutuphane olarak kullanabilirim
            //namespace icerisinde class tanimlari bulunur

            //class .net icerisinde olusturdugumuz, icerisinde metotlari ve 
            //bir cok ozellikleri barindiran kucuk paketlerdir

            //bir classin icinde birden fazla  metot olur
            //bu metotlarlar cagirildikca is yapar

            //main metodu uygulamanin ilk baslayacagi kisimdir
            //ilk scope araligidir, su an bunlari yazdigim aralik

            //void, metot calisacak ama geriye parametre(deger) donmeyecek demek

            //SayHello();

            ogrenci O1 = new ogrenci(); //ogreci sinifindaki metoda ulasmak icin yazdik
            //O1.sayHelloStudent();
            O1.ogrenciMetot2();
        }

        static void SayHello() //parantez bos oldugu icin deger almaz
        {
            Console.WriteLine("3hello");
            Console.ReadLine();
        }
    }
}
