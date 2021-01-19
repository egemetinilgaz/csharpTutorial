using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira8.Ders1.OOPNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            //oop nedir = class tanimlama ve inceleme

            //oop yi somut bir ornek olan cikolata kalibi ve cikolatalar uzerinden asagida anlat
            /*
             * 
             * 
             * 
             * 
             */

            //bir namespace altinda birden fazla class tanimlanabilir

            musteri M1 = new musteri();
            //burada = new musteri yapip parantez actigimiz an
            //ayni metotlardaki gibi asiri yuklenme(overload) gibi secenekler cikacak
            //burada da 4 adet secenek cikacak, cunku ben musteri.cs icinde 4 adet yapici metot tanimladim
            
            // 1. bos default degeri al dedim

            /*public musteri() //bu bir yapici metot
            {
                //burasi bos, defult deger gelir
            }*/

            // 2. tc yi ben vereecegim, digerlerini sen default doldur dedim

            /*public musteri(string _tckimlikno) //bu bir yapici metot
            {
                TCKimlikNo = _tckimlikno;
            }*/

            // 3. tc ve ismi ben verecegim, digerlerini sen default doldur dedim

            /*public musteri(string _tckimlikno, string _isim) //bu bir yapici metot
            {
                TCKimlikNo = _tckimlikno;
                isim = _isim;
            }*/

            // 4. tc, isim ve soyismi ben verecegim, digerlerini sen default doldur dedim

            /*public musteri(string _tckimlikno, string _isim, string _soyisim) //bu bir yapici metot
            {
                TCKimlikNo = _tckimlikno;
                isim = _isim;
                soyisim = _soyisim;
            }*/

            M1.TCKimlikNo = "12345678912";
            M1.isim = "Ege Metin";
            M1.soyisim = "ILGAZ";
            M1.cinsiyet = 71777001;

            musteri M2 = M1; //burada bir referans verdim, M1 nereyi gosteriyorsa sen de oraya bak dedim

            M2.isim = "Hatice"; //M1'de de deger degisir
            M1.TCKimlikNo = "98765432198"; //M2'de de deger degisir

            M2 = null;
            M1 = null;
            //burada bellekteki heap bolgeden degerleri dusurduk
        }
    }
}
