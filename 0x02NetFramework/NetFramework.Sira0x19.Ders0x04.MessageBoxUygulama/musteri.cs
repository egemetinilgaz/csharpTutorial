using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira19.Ders4.MessageBoxUygulama
{
    public class musteri
    {
        public Guid id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string eMailAdres { get; set; }
        public string telefonNumarasi { get; set; }

        public override string ToString() //override islemini burada yaptim
        {
            return isim + " " + soyisim;
        }
    }
}
