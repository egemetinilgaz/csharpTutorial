using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira16.Ders1.ParticalClassNedir
{
    public partial class ogrenci //burada field'i sildik sadece ogrenci kaldi
        //burada ide hata verir zaten ogrenci nesnesi var diye, simdi bunu bir parca haline getirecegim
        //partial anahtar kelimesi ile bunlarin birer parca oldugunu soyluyoruz
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string ogrenciNumara { get; set; }
    }
}
