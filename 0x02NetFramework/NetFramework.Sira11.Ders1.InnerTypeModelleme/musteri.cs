using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira11.Ders1.InnerTypeModelleme
{
    public class musteri
    {
        #region TEKIL FIELD
        public int musteriID { get; set; }
        public string TCKimlikNo { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime OlusturmaTarih { get; set; }
        public int kullaniciID { get; set; }
        #endregion



        #region INNER TYPE

        //inner type ogrendik
        public musteriAdres[] musteriAdresBilgileri;
        public musteriIetisim[] musteriIletisimBilgileri;
        public musteriSiparis[] musteriSiparisBilgileri;
        public musteriUrun[] musteriUrunBilgileri;
        

        #endregion

        public musteri() //ctor yani yapici metot olusturarak ve inner type'i burada cagirdik
            //burada referans olusturmak onemli bunu unutma, program cs'de degil
        {
            musteriAdresBilgileri = new musteriAdres[5];
            musteriIletisimBilgileri = new musteriIetisim[4];
            musteriSiparisBilgileri = new musteriSiparis[10];
            musteriUrunBilgileri = new musteriUrun[7];
            
        }
    }
}
