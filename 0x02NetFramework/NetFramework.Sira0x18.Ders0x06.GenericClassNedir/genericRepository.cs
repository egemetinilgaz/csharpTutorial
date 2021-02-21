using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira18.Ders6.GenericClassNedir
{
    public class genericRepository<T> //, ile ayirdiktan sonra birden fazla generic tipi yazabiliriz
                                      //gercek haytta en fazla 2 kullanim vardir
                                      //public class genericRepository<T> where T:class dersen
                                      //genericRepository<musteri> burasi class olmak zorunda
                                      //genericRepository<int> olmaz mesela

    {
        public genericRepository()
        {
            //context:EF DBFirst
        }

        public virtual List<T> getir()
        {
            //Gelen T tipini database uzerinden sorgulamak ve elde etmis oldugum
            //kayitlari generic koleksiyon olarak bir ust katmana donmek
            return null;
        }

        public virtual void yeniKayitEkle(T data)
        {
            //bize gelen T tipi icerisindeki bilgiyi, T tipinin isaret etmis oldugu tabloya ekliyoruz
        }
    }
}
