using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira18.Ders5.GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic class nedir

            //burasi generic olmayan bir class
            musteri M1 = new musteri();
            M1.id = 1;
            M1.TCKimlikNumarasi = "123456789101";
            M1.musteriNumara = "12345";
            M1.isim = "Ege Metin";
            M1.soyisim = "ILGAZ";
            M1.dogumTarihi = DateTime.Parse("26.09.1991");

            //generic class bu degildir, bu yanlis kullanim UNUTMA
            //bir sonraki derste asil kullanima bakacagim(sira18.ders6)
            //bunu yapma diye, bu dersi not aldim
            musteriGeneric<int> musteriGeneric1 = new musteriGeneric<int>();
            musteriGeneric1.id = 1;
            musteriGeneric1.musteriNumarasiAl();

            musteriGeneric<Guid> musteriGeneric2 = new musteriGeneric<Guid>();
            musteriGeneric2.musteriNumarasiAl();

        }
    }
}
