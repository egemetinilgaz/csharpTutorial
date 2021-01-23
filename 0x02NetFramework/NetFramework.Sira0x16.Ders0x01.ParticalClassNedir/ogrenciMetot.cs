using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira16.Ders1.ParticalClassNedir
{
    public partial class ogrenci //buradan metodu sildik, sadece ogrenci kaldi
        //burada ide hata verir zaten ogrenci nesnesi var diye, simdi bunu bir parca haline getirecegim
        //partial anahtar kelimesi ile bunlarin birer parca oldugunu soyluyoruz
    {
        public int yeniKayit(ogrenci o)
        {
            Console.WriteLine("yenikayit islemi basarili");
            return 1;
        }

        public int kayitGuncelle(ogrenci o)
        {
            Console.WriteLine("ogrenci kayit guncelleme basarili");
            return 1;
        }

        public int kayitSil(ogrenci o)
        {
            Console.WriteLine("ogrenci kaydi silindi");
            return 1;
        }
    }
}
