using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira13.Ders1.SanalMetotNedir
{
    public class musteri // :object => framework standart olarak tum nesneleri object'den turetir
    {
        public int musteriID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }

        public override string ToString()
        {
            // return base.ToString(); - standart kullanim
            return isim + " " + soyisim;
            //bunu yaptigimiz zaman object nesnesi icindeki ToString() metodu calismayacak
            //benim musteri nesnesi icindeki ToString() metodum calisacak
            //sanalmetot oldugu icin mudahale ettigimiz metot calisir
        }
    }
}
