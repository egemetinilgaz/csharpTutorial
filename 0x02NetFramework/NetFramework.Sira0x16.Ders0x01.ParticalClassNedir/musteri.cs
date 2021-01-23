using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira16.Ders1.ParticalClassNedir
{
    public class musteri
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }

        public int yeniKayit(musteri m)
        {
            Console.WriteLine("database kayit islemi tamamlandi");
            return 1;
        }

        public int kayitGuncelle(musteri m)
        {
            Console.WriteLine("musteri kaydi guncellendi");
            return 1;
        }

        public int kayitSil(int id)
        {
            Console.WriteLine("musteri kaydi silindi");
            return 1;
        }
    }
}
