using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira8.Ders1.OOPNedir
{
    public class musteri
    {
        /*
         * turkiye cumhuriyeti kimlik numarasi
         * isim
         * soyisim
         * cinsiyet
         */

        //yapici metot (ctor)

        public musteri() //bu bir yapici metot
        {

        }

        public musteri(string _tckimlikno) //bu bir yapici metot
        {
            TCKimlikNo = _tckimlikno;
        }

        public musteri(string _tckimlikno, string _isim) //bu bir yapici metot
        {
            TCKimlikNo = _tckimlikno;
            isim = _isim;
        }

        public musteri(string _tckimlikno, string _isim, string _soyisim) //bu bir yapici metot
        {
            TCKimlikNo = _tckimlikno;
            isim = _isim;
            soyisim = _soyisim;
        }

        public string TCKimlikNo;
        public string isim;
        public string soyisim;
        public int cinsiyet; //ornek 717770001: erkek, 717770002: kadin
    }
}
