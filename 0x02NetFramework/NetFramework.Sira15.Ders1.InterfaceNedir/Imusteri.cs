using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira15.Ders1.InterfaceNedir
{
    public interface Imusteri
    {
        /*public Imusteri()
        {

        }*/
        //interface icerisinde yapici metot kullanilmaz

        /*
         * interface icerisinde neler olur
         * field
         * metot
         * delegate (henuz gormedi bunu, ileride gorecegiz)
         * .
         * .
         */

        //field

        int ID { get; set; }
        string isim { get; set; }
        string soyisim { get; set; }

        //metot

        int yeniKayit(string isim, string soyisim);
        int kayitDuzenle(int id, string isim, string soyisim);
        int kayitSil(int id);
    }
}
