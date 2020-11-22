using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira8.Ders2.Siniflarda.Metot
{
    internal class musteri
    {
        internal musteri() //bu bir yapici metot constructor
        {

        }

        internal musteri(string _tckimlikno) //bu bir yapici metot constructor
        {
            TCKimlikNo = _tckimlikno;
        }

        internal musteri(string _tckimlikno, string _isim) //bu bir yapici metot constructor
        {
            TCKimlikNo = _tckimlikno;
            isim = _isim;
        }

        internal musteri(string _tckimlikno, string _isim, string _soyisim) //bu bir yapici metot constructor
        {
            TCKimlikNo = _tckimlikno;
            isim = _isim;
            soyisim = _soyisim;
        }

        internal string TCKimlikNo;
        internal string isim;
        internal string soyisim;
        internal int cinsiyet; //ornek 717770001: erkek, 717770002: kadin

        internal bool musteriKontrol()
        {
            bool kontrol = musteriKontrolDatabase(TCKimlikNo);
            return kontrol;
        }

        private bool musteriKontrolDatabase(string _tckimlikno)
        {
            //database e gidilip, musterinin kimlik numarasina gore daha once
            //kayit edilip edilmedigine bakilir ve biz buna simdilik true diyoruz
            return true;
        }
    }
}
