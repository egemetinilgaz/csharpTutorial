using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira15.Ders1.InterfaceNedir
{
    public class musteri : Imusteri //implement interface dediginde hata vermeyecek (sari ampule tikla)
    {
        /*
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string isim { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string soyisim { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int kayitDuzenle(int id, string isim, string soyisim)
        {
            throw new NotImplementedException();
        }

        public int kayitSil(int id)
        {
            throw new NotImplementedException();
        }

        public int yeniKayit(string isim, string soyisim)
        {
            throw new NotImplementedException();
        }*/
        //yukaridaki kisim hazir gelir, bunu sen dolduraaksin

        int _id;
        string _isim;
        string _soyisim;
        //asagidaki prop'lar degiskenlere ihtiyac duyduklari icin bu degiskenleri once yaziyoruz

        public int ID { get { return -ID; } set { _id = value; } }
        public string isim { get { return _isim; } set { _isim = value; } }
        public string soyisim { get { return _soyisim; } set { _soyisim = value; } }

        public int kayitDuzenle(int id, string isim, string soyisim)
        {
            Console.WriteLine("kayit duzenlendi");
            return 1;
        }

        public int kayitSil(int id)
        {
            Console.WriteLine("kayit silindi");
            return 1;
        }

        public int yeniKayit(string isim, string soyisim)
        {
            Console.WriteLine("yeni kayit eklendi");
            return 2;
        }
    }
}
