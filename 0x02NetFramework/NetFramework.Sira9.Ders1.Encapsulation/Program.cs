using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira9.Ders1.Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri Musteri1 = new musteri();
            Musteri1.id = 442;
            Musteri1.isim = "Ege Metin";
            Musteri1.soyisim = "ILGAZ";

            //encapsulation: class inicindeki field'a giden datanin, gitme ve 
            //o dataya ulasma bolumlerini detaylandirma kismina denir
            
            /*
             * kapsulleme (encapsulation)
             * field icerisine deger atanamasin ama deger okunsun
             * field icerisine deger atamasi yapilsin ama okunamasin
             * field icerisine deger atansin ama degerinilk4 hanesi okunsun
             * 1-field icerisine deger atama ve okuma yapilsin ama belirlenen bir surectengecsin
             * 1-ve veri sonra gosterilsin
             */

            //class icinde bir alanin deger alma ve  deger okuma kisimlarina encapsulation denir

            //property, get, set

            // Musteri1.emailAdres = "ilgazzegemetin@gmail.com"; (private field oldugu icin hata verir)

            //burasi property, field degil
            //genel olarak encapsulation konusuna giris yaptik
            Musteri1.EMailAdress = "ilgazzegemetin@gmail.com";
            Console.Write(Musteri1.EMailAdress);
            Console.ReadLine();
        }
    }
}
