using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira12.Ders1.KalitimNedir
{
    public class personel : temelTip
    {
        public DateTime isBaslangicTarihi { get; set; }
        public DateTime isCikisTarihi { get; set; }
        public int izinGunSayisi { get; set; }

        public personel() //yapici metot
        {
            Console.WriteLine("personel listesi yapici metodu calisti");
        }
    }
}
