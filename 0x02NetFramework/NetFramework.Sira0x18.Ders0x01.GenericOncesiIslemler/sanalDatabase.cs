using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira18.Ders1.GenericOncesiIslemler
{
    public class sanalDatabase
    {
        private ArrayList listem;
        public sanalDatabase()
        {
            listem = new ArrayList();
        }

        public void yeniKayit(int data)
        {
            listem.Add(data);
        }

        //ben burada private olarak sakladigim arraylist'ime, istemis oldugum, zorunlu kostugum
        //veri tipini aldim. yani sadece int alabilir.
    }
}
