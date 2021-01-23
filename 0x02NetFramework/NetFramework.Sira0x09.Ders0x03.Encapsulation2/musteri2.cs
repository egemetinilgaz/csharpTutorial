using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira9.Ders2.Encapsulation2
{
    internal class musteri2
    {
        //burasi class'in field'i yani alani
        
        internal string isim;
        internal string soyisim;
        //emailAdres asagida private
        //id asagida private

        //yapici metot olusturuyoruz
        //nesnem orneklendiginde, yapici metodum calisacak
        //yapici metodum iceride private olan IDUret metodundan random bir deger alacak
        //aldigi bu random degeri, yine iceride private olan id uzerine atacak
        //daha sonra da get ve set ile, private id uzerinden islem yapacagim
        public musteri2()
        {
            this.id = IDUret();
        }





        //get ve set metotlari public'tir bunu unutma
        //field icerisine deger atanamasin ama deger okunsun
        private int id;
        public int ID
        {
            get
            {
                return this.id;
            }
            private set //burada ID'ye mudahale edilmesin istiyorsan, ID'yi private yapacaksin
            {
                this.id = value;
            }
        }

        private int IDUret()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 90000);
        }





        private string emailAdres; //burasi private field dis dunya goremez
        public string EMailAdress
        {
            //get; //database veya farkli veri kaynagindan data cektigimizde, 
            //class cagiran programciya datayi gosterdigimiz kisim
            //set; //dis dunyadan cektigim datayi, private olarak sakladigim field icerisine deger
            //atandigim kisim (private string emailAdres;) bu kisim

            set
            {
                this.emailAdres = value;
                
            }

            get
            {
                return this.emailAdres;
            }
        }
    }
}
