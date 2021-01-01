using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira10.Ders5.BigQuiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * musteri adinda bir class olustur
             * bu nesnenin icine static olarak bir arraylist olustur
             * musteri sinifinin icerisine;
             * int: id
             * string: isim, soyisim, emailadres, kullaniciadi, sifre field'lari olustur
             * olusturdugumuz bu field listesinden bazilarinin encapsulation filtreleri;
             * kullanici adi degeri sanal olarak olusturdugumuz database icerisinde aransin
             * eger bu deger database icinde adi degeri varsa, 
             * field icerisine eklenmek istenen deger eklenmesin(encapsulation)
             * musteri ekle adinda bir static metot olusturalim
             * parametre olarak musteri tipi alsin
             * musteri nesnesinin null olup olmadigini
             * musteri nesnesi icerisindeki kullanici adinin dolu olmasi sartina baksin
             * yukarida kriterlerden gecerse sanal olarak olusturdugumuz database'imize eklenmeden once
             * email adresinden br kontrol saglansin
             * eger sistemde ayni email adresi ile bir musteri degeri varsa eklenmesin
             * yoksa sanal database icerisine ilgili nesneyi ekleyelim
             */

            musteri M1 = new musteri();
            M1.MusteriID = 1;
            M1.isim = "Ege Metin";
            M1.soyisim = "ILGAZ";
            M1.eMailAdres = "ilgazzegemetin@gmail.com";
            M1.kullaniciAdi = "EgeMetinILGAZ";
            M1.sifre = "12345";

            musteri.MusteriEkle(M1);



            //boyle bir yazim sekli de var
            musteri M2 = new musteri()
            {
                MusteriID = 2,
                isim = "Hatice",
                soyisim = "ILGAZ",
                eMailAdres = "ilgazhatice@gmail.com",
                kullaniciAdi = "haticeilgaz",
                sifre = "54321"
            };

            musteri.MusteriEkle(M2);



            //buradaki amac bilerek ayni girmek ve sistemin hata vermesini saglamak
            musteri M3 = new musteri();
            M3.MusteriID = 1;
            M3.isim = "Ege Metin";
            M3.soyisim = "ILGAZ";
            M3.eMailAdres = "ilgazzegemetin@gmail.com";
            M3.kullaniciAdi = "EgeMetinILGAZ";
            M3.sifre = "12345";

            musteri.MusteriEkle(M3);

            Console.ReadLine();
        }
    }
}
