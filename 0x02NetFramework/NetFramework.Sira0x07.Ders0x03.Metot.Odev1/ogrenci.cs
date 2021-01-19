using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira7.Ders3.Metot.Odev1
{
    public class ogrenci
    {
        //parametreler 2 ye ayrilir opsiyonel (dolmasi zorunlu olmayan)
        //opsiyonel olmayan(dolmasi zorunlu olan)
        public void ogrenciNotHesapla(string ogrenciAdi, string OgrenciSoyadi, decimal ogNot1,
            decimal ogNot2, decimal ogNot3 = 45) //opsiyonel parametreler en sonda yazilmalidir
            //aralara yazildiginda program hata verir, ya da opsiyonel kullandigin parametreden sonra
            //bir parametre yazarsan =0 diyebilirsin
        //yukarida ogrencinin ogNot3 un girisi zorunlu ama biz bunu opsiyonlu bir hale getiriyoruz
        //bu sekilde deger girilmedigi zaman da default degeri 45 olacak sekilde calisacak
        //bu sekilde yapilir "decimal ogNot3 = 45"
        {
            Console.WriteLine("ogrenci bilgileri");
            Console.WriteLine("ad soyad: {0} {1}", ogrenciAdi, OgrenciSoyadi);
            //burada ortalamayi asagidaki private metodu cagirar aldim
            decimal ortalama = ortalamaHesapla(ogNot1, ogNot2, ogNot3);
            //bu kisim benden ogrenciOrtalama adinda bir parametre istemiyor
            //sadece decimal bir veri tipi olan parametre istiyor
            ortalamaNotDegerlendir(ortalama);

            //yukaridaki kisimda yine ortalama alindiktan sonra bir islem yapilmadigi icin
            //kisa yazim sekli
            // ortalamaNotDegerlendir(ortalamaHesapla(ogNot1, ogNot2, ogNot3));
            //yukaridaki gibi ic ice olan metotlarda once ic kisim calisir
        }
        void ortalamaNotDegerlendir(decimal ogreniOrtalama)
        {
            if (ogreniOrtalama < 45)
            {
                Console.WriteLine("ortalama: {0} ile kaldiniz", ogreniOrtalama);
            }
            else
            {
                Console.WriteLine("ortalama {0} ile gectiniz", ogreniOrtalama);
            }
        }
        //parametre degerlerinin isimleri ayni olmak zorunda degil
        //ortalamaHesapla da ogrencinot1 kullanirken, ogrenciNotHesapla da ogNot1 kullandim
        private decimal ortalamaHesapla(decimal ogrencinot1, decimal ogrencinot2, decimal ogrencinot3)
        {
            decimal ortalama1 = (ogrencinot1 + ogrencinot2 + ogrencinot3) / 3;
            return ortalama1;

            //yukarida ortalama alindiktan sonra baska bir islem yapilmadigi icin
            //decimal ortalama1 diye br degisken tanimlayip hafizada tutmaya gerek yok
            //bunu asagidaki gibi kisa bir sekilde de yazabiliriz
            // return (ogrencinot1 + ogrencinot2 + ogrencinot3) / 3;
        }
    }
}
