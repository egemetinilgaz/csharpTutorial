using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira16.Ders1.ParticalClassNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri M1 = new musteri();
            M1.id = 1;
            M1.isim = "Ege Metin";
            M1.soyisim = "ILGAZ";
            M1.emailAdres = "ilgazzegemetin@gmail.com";

            int sonuc = M1.yeniKayit(M1);
            if (sonuc > 0)
            {
                Console.WriteLine("database yeni kayit eklendi");
            }

            ogrenci O1 = new ogrenci();
            O1.id = 1;
            O1.yeniKayit(O1);
        }
    }
}
