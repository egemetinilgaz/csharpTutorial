using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira9.Ders3.Encapsulation3
{
    internal class email
    {
        public string isim;

        private string _soyisim;

        public string SoyIsim
        {
            get
            {
                return this._soyisim;
            }
            set
            {
                this._soyisim = value;
                this.emailAdres = string.Format("{0} {1}@gmail.com", isim, _soyisim);
            }
        }

        private string emailAdres;

        public string EMailAdres
        {
            get
            {
                return this.emailAdres;
            }
            private set
            {
                this.emailAdres = value;
            }
        }


    }
}
