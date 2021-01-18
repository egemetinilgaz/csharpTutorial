using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira4.Ders6.While.Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            //sistemin calisma zamaninda urettigi 1-10 arasindaki bir degeri
            //kullanicinin tahmin etmesini iste, kac kez denedigini de bul ve ekrana yaz

            //rnd = random

            int sistemUretSayi = 0;
            int tahminAdet = 1;
            Random rnd = new Random();
            sistemUretSayi = rnd.Next(1, 10); //next komutu uretmis oldugum sayiyi, degiskenime atamama yariyor

            while (true)
            {
                Console.Write("{0}. deneme - sistemin uretmis oldugu sayiyi tahmin edin:", tahminAdet);
                string rndKullaniciGelen = Console.ReadLine();
                int rndKullaniciGelenInt = int.Parse(rndKullaniciGelen);

                //if (int.Parse(rndKullaniciGelen) == sistemUretSayi) boyle kisa da yazilir

                if (rndKullaniciGelenInt == sistemUretSayi)
                {
                    Console.WriteLine("{0}. denemede buldunuz, dogru sayi", tahminAdet);
                    break;
                }
                else
                {
                    Console.WriteLine("{0}. deneme, yanlis sayi, yeniden deneyin", tahminAdet);
                    tahminAdet++;
                }
            }
            Console.ReadLine();
        }
    }
}
