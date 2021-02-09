using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira18.Ders1.GenericOncesiIslemler
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic oncesi islemler boyle yapiliyordu

            //hatirlatma arraylist obje turunden saklar

            /*
             * ArrayList liste = new ArrayList();
             * liste.Add()
             * 
             */

            sanalDatabase sDatabase = new sanalDatabase();
            {
                sDatabase.yeniKayit(1); //burada sadece int girebiirsin
            }

            /*
             * yukaridaki amacimiz sanalDatabase class'i icerisinde private bir metot
             * olusturup, bu metot icerisinden istedigimiz veri tipinde bir veri tipi
             * kullanilmasini zorunlu kilmak
             */
        }
    }
}
