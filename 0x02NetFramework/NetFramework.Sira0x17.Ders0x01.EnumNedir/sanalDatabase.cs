using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira17.Ders1.EnumNedir
{
    public class sanalDatabase
    {
        ArrayList sanalDB = new ArrayList();

        public musteriReturnValue musteriYeniKayit(musteri M) //buradaki int ifadesini enum yapiyoruz
                                                              //yani musteriReturnValue
        {
            sanalDB.Add(M);
            return musteriReturnValue.kayitBasarili; //burada enum'i kullandik
        }
    }
}
