using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira18.Ders6.GenericClassNedir
{
    public class musteri
    {
        public int id { get; set; }
        public Guid musteriNumara { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime dogumTarihi { get; set; }
    }
}
