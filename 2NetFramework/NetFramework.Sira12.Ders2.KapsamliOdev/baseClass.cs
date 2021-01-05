using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira12.Ders2.KapsamliOdev
{
    public class baseClass
    {
        //sadece bir kere calisacak static bir sayac yaziyorum
        public static int sayac = 1; //ilk olustugu zaman 1 degerini otomatik alacak

        public baseClass()
        {
            _id = sayac = 1;
            sayac = sayac + 1;
        }


        private int _id;
        public int id //kontrol olacak
        {
            get
            {
                return _id;
            }
            private set
            {
                //bir sayac icerisindeki degerde faydalanmak istiyorum
                // _id = sayac;
                // sayac = sayac + 1;
                //buradaki degerlerin programcs'de gozukmeme sebebi
                //set alaninin private olarak isaretlenmensi
                //bu yuzden, bu islemi yukarida yapici metot ile yapiyorum
            }
        } 


        private string _barkod;
        public string barkod //girdigim deger sanal database'de varsa hata versin, yoksa eklesin
        {
            get
            {
                return _barkod;
            }
            set
            {
                //bunu bir metot ile yapacagim, bu metodum da sanaldatabase icerisinde olacak
                bool kontrolIslemi1 = sanalDatabase.dbBarkodKontrol(value);
                {
                    if (!kontrolIslemi1) //degeri sanal database icerisinde bulamadim
                    {
                        _barkod = value;
                    }
                    else
                    {
                        Console.WriteLine("bu barkod degeri sanal database icerisinde vardir");
                    }
                }
            }
        } 
        public DateTime olusturmaTarihi { get; set; }
        public int olusturanKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncelleyenKullanici { get; set; }
        public bool silindi { get; set; }
    }
}
