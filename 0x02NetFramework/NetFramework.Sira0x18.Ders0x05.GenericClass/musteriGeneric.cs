using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira18.Ders5.GenericClass
{
    public class musteriGeneric<T> //<T> ile generic yapiyorum
    {
        public T id { get; set; }
        public T musteriNumara { get; set; }
        public string TCKimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime dogumTarihi { get; set; }

        public T musteriNumarasiAl()
        {
            return musteriNumara;
        }
    }
}
