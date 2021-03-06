using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira19.Ders2.KullaniciGirisUyg
{
    public class sanalDatabase
    {
        public static List<kullanici> kullaniciTablo = new List<kullanici>();

        static sanalDatabase()
        {
            kullaniciTablo.Add(new kullanici()
            {
                id = 1,
                isim = "Ege Metin",
                soyisim = "ILGAZ",
                kullaniciAdi = "ilgazEM",
                sifre = "1",
                aciklama = "Ege Metin ILGAZ Pofil"
            });

            kullaniciTablo.Add(new kullanici()
            {
                id = 2,
                isim = "Hatice",
                soyisim = "ILGAZ",
                kullaniciAdi = "ilgazHTC",
                sifre = "2",
                aciklama = "Hatice ILGAZ Pofil"
            });

            kullaniciTablo.Add(new kullanici()
            {
                id = 3,
                isim = "Eda",
                soyisim = "ILGAZ",
                kullaniciAdi = "ilgazEDA",
                sifre = "3",
                aciklama = "Eda ILGAZ Pofil"
            });
        }
    }
}
