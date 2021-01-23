using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira12.Ders2.KapsamliOdev
{
    public class urun : baseClass //burada ana proplari baseclass'dan aldik, buraya ozelleri sonra yazdik
    {
        public string marka { get; set; } //sadece sectigimiz markalar satilabilir
        public string model { get; set; }


        private decimal _alisFiyat;
        public decimal alisFiyat //0 dan kucuk olamaz
        {
            get
            {
                return alisFiyat;
            }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("alis fiyati 0 veya 0'dan kucuk olamaz");
                }
                else
                {
                    _alisFiyat = value;
                }
            }
        }


        private decimal _satisFiyat;
        public decimal satisFiyat //alisfiyatindan kucuk olamaz
        {
            get
            {
                return _satisFiyat;
            }
            set
            {
                if (value<_alisFiyat)
                {
                    Console.WriteLine("satis fiyati, alis fiyatindan kucuk olamaz");
                }
                else
                {
                    _satisFiyat = value;
                }
            }
        }


        private decimal _kampanyaFiyat;
        public decimal kampanyaFiyat //0 dan kucuk olamaz
        {
            get
            {
                return _kampanyaFiyat;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("kampanya fiyati 0'dan kucuk olamaz");
                }
                else
                {
                    _kampanyaFiyat = value;
                }
            }
        }
    }
}
