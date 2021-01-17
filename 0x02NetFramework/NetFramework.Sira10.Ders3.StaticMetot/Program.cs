using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira10.Ders3.StaticMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            personel P1 = new personel();
            P1.isim = "Ege Metin";
            P1.soyisim = "ILGAZ";
            P1.EMailAdres = "egemetinilgaz";
            P1.cinsiyet = 71777001; //71777002 kadin icin

            helper.emailGoner("iem@firmam.com", "yeni personel girisi", P1.isim + P1.soyisim + P1.cinsiyet);
        }
    }
}
