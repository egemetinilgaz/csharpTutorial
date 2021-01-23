using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira11.Ders1.InnerTypeModelleme
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri M1 = new musteri();
            M1.musteriID = 1;
            M1.TCKimlikNo = "11111111111";
            M1.isim = "Ege Metin";
            M1.soyisim = "ILGAZ";
            M1.OlusturmaTarih = DateTime.Now;

            // M1.musteriAdresBilgileri = new musteriAdres[5];
            //bunu ustteki gibi yapma, kod tekrari olur ve guncellemek cok zor olur
            //nesne yonelimli programlamada bunun yeri burasi degil

            M1.musteriAdresBilgileri[0] = new musteriAdres()
            {
                il = "istanbul",
                ilce = "uskudar",
                adres = "........",
                adresTip = "ev adresi"
            };

            M1.musteriIletisimBilgileri[0] = new musteriIetisim()
            {
                aktifPasif = true,
                alanKodu = "216",
                iletisimTip = 71777001,
                numara="0555555555"
            };

            M1.musteriUrunBilgileri[0] = new musteriUrun()
            {
                urunID = 123,
                tanim = "macbook pro 2020",
                fiyat = 11299
            };

            M1.musteriUrunBilgileri[1] = new musteriUrun()
            {
                urunID = 122,
                tanim = "macbook air 2020",
                fiyat = 10299
            };

            
            
            //burada inner type icinde inner type olusturduk
            M1.musteriSiparisBilgileri[0] = new musteriSiparis()
            {
                musteriSiparisNumarasi = "siparis00002"
            };

            M1.musteriSiparisBilgileri[0].musteriUrunler[0] = new musteriUrun()
            {
                urunID = 121,
                tanim = "telefon",
                fiyat = 5999
            };



            M1.musteriAdresBilgileri[0].musteriAdresTestMetot();
            M1.musteriIletisimBilgileri[0].musteriIetisimTestMetot();
            M1.musteriUrunBilgileri[0].musteriUrunTestMetot();
            M1.musteriUrunBilgileri[1].musteriUrunTestMetot2();
            Console.ReadLine();
        }
    }
}
