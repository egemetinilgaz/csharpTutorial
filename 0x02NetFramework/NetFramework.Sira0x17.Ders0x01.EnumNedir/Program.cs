using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira17.Ders1.EnumNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            //enum nedir
            musteri M1 = new musteri();
            M1.id = 1;
            M1.musteriNumara = "MSN0001";
            M1.isim = "Ege Metin";
            M1.soyisim = "ILGAZ";
            M1.emailAdres = "ilgazzegemetin@gmail.com";

            sanalDatabase SB = new sanalDatabase();

            /*int musteriKayitSonuc = SB.musteriYeniKayit(M1);

            if (musteriKayitSonuc == 71777001)
            {

            }*/
            //bunun ve asagidaki kodun okunakligina bakacagiz


            musteriReturnValue musteriKayitSonuc = SB.musteriYeniKayit(M1);

            if (musteriKayitSonuc == musteriReturnValue.kayitBasarili)
            {

            }

            int enumInt = (int)musteriReturnValue.kayitBasarisiz;
            //burada kayit basarisiz siradaki int degerini alacak
            Console.WriteLine(enumInt);
        }
    }
}
