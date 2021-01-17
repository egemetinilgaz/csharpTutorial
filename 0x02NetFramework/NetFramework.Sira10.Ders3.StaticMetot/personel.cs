using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira10.Ders3.StaticMetot
{
    internal class personel
    {
        public static string domainAdres = "firmam.com";

        public string isim { get; set; }
        public string soyisim { get; set; }



        private string _emailadres;
        public string EMailAdres
        {
            get
            {
                return this._emailadres;
            }
            set
            {
                this._emailadres = value.ToLower() + "@" + personel.domainAdres;
                //bu deger atama islemi program cs tarafinda da yapilirdi
                //ancak burada yapmak daha mantikli
                //cunku diger turlu bir degisiklik oldugunda
                //program cs tarafinda butun verilerde gecen kismi tek tek degistirmen gerekecek
            }
        }

        public int cinsiyet { get; set; }
    }
}
