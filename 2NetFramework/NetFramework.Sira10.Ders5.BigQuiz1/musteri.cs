using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira10.Ders5.BigQuiz1
{
    internal class musteri
    {
        #region SANAL DATABASE
        static ArrayList musteriDatabese;
        #endregion

        #region STATIC YAPICI METOT

        static musteri() //static yapici metot
        {
            musteriDatabese = new ArrayList();
        }

        #endregion

        #region FIELD

        public int MusteriID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string eMailAdres { get; set; }
        public string sifre { get; set; }



        private string _kullaniciAdi;

        #endregion

        #region ENCAPSULATION

        public string kullaniciAdi
        {
            get
            {
                return this._kullaniciAdi;
            }
            set
            {
                bool kullaniciAdiKontrol = musteriKullaniciAdiKontol(value);
                if (kullaniciAdiKontrol)
                {
                    Console.WriteLine("bu kullanici adi sistemde kayitli");
                    this._kullaniciAdi = string.Empty;
                }
                else
                {
                    this._kullaniciAdi = value;
                }
            }
        }

        #endregion

        #region STATIC METHODS

        static bool musteriKullaniciAdiKontol(string kuladi)
        {
            bool kontrol = false;

            for (int i = 0; i < musteriDatabese.Count; i++)
            {
                musteri temp = (musteri)musteriDatabese[i];
                // soyle de yazilir ama daha karisik
                //if(((musteri)musteriDatabese[i]).kullaniciAdi == _kullaniciadi)

                //arraylist obje sakladigi icin zorunlu tip donusumu yapiyoruz
                //obje olarak gelen degeri, cevirip temp uzerine aliyoruz
                //gecici olarak, yine musteri class'inin ismi ile sadece kontrol amacli actigimiz
                //musteri temp = (musteri) uzerine atiyoruz
                if (temp.kullaniciAdi == kuladi)
                {
                    kontrol = true;
                    break;
                }
            }

            return kontrol;
        }
        static bool musteriEmailAdresKontrol(string kulemailadres)
        {
            bool kontrol = false;
            for (int i = 0; i < musteriDatabese.Count; i++)
            {
                musteri temp = (musteri)musteriDatabese[i];
                //arraylist obje sakladigi icin zorunlu tip donusumu yapiyoruz
                //obje olarak gelen degeri, cevirip temp uzerine aliyoruz
                //gecici olarak, yine musteri class'inin ismi ile sadece kontrol amacli actigimiz
                //musteri temp = (musteri) uzerine atiyoruz
                if (temp.eMailAdres == kulemailadres)
                {
                    kontrol = true;
                    break;
                }
            }
            return kontrol;
        }
        #endregion



        #region MUSTERI EKLE METOT
        public static void MusteriEkle(musteri musterigirisi)
        {
            #region PARAMETERS CONTROLS
            if (musterigirisi != null && !string.IsNullOrEmpty(musterigirisi.kullaniciAdi) && !string.IsNullOrEmpty(musterigirisi.eMailAdres))
            //m.kullaniciAdi null ya da bos degilse
            {
                bool emailAdresKontrol = musteriEmailAdresKontrol(musterigirisi.eMailAdres);
                if (emailAdresKontrol)
                {
                    Console.WriteLine("eklemek istediginiz kullanici sistemde kayitli");
                }
                else
                {
                    musteriDatabese.Add(musterigirisi);
                    Console.WriteLine("yeni kayit islemi basarili");
                }
            }
            else
            {

            }
            #endregion
        }
        #endregion
    }
}
