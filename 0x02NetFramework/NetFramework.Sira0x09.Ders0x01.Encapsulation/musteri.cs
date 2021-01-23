using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira9.Ders1.Encapsulation
{
    internal class musteri
    {
        // internal; NetFramework.Sira9.Ders1.Encapsulation icinde erisilebilen demektir

        //burasi class'in field'i yani alani
        internal int id;
        internal string isim;
        internal string soyisim;

        private string emailAdres; //burasi private dis dunya goremez, burasi private field

        //dis dunyaya public olacak, aldigi degeri ic dunyayaki emailadres'e gonderecek
        //class icindeki ozellikler yani property

        //buradaki email yukaridakinden farkli, karistirma
        public string EMailAdress
        {
            //get; //database veya farkli veri kaynagindan data cektigimizde, 
            //class cagiran programciya datayi gosterdigimiz kisim
            //set; //dis dunyadan cektigim datayi, private olarak sakladigim field icerisine deger
            //atandigim kisim (private string emailAdres;) bu kisim

            get
            {
                return this.emailAdres; //burada da onu cagiran kisiye gonderiyoruz
            }

            set
            {
                this.emailAdres = value;
                //gelen degeri(ilgazzegemetin@gmail.com) value anahtar kelimesi ile yakalariz 
                //ve emailAdres e atariz
                //buradaki value uzerinde istedigimiz islemi yapariz
                //metotda gonderirirm
                //dogrulugunu kontrol ederim 
                //if else bloguna sokarim
                //vs
            }
        }
    }
}
