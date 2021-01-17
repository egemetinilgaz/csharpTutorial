using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira1.Ders2.ReferansTipDavranis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*referans tipli davranislar kopyalanarak cogalmaz, merkezi olarak degeri isaret eder.
             * ve bir noktada degistiginde onu isaret eden her noktada degismesi saglanir.
             * onu isaret eden kimse kalmazsa bellekten duser.*/

            /*mantik su: 2 kisi uzakta bir nesneyi gosteriyor, o nesne degistiginde 2 kisinin
             * gosterdigi yer/nesne de degisir. bu referans tipli davranistir.*/
            
            Motosiklet motosikletTanimi1 = new Motosiklet();
            motosikletTanimi1.marka = "KTM";
            motosikletTanimi1.model = "DUKE 200";
            motosikletTanimi1.renk = "Turuncu";

            Motosiklet motosikletTanimi2 = motosikletTanimi1;

            motosikletTanimi2.renk = "Siyah";

            motosikletTanimi1.model = "1290 Super Duke";

            motosikletTanimi1 = null; //bellekten dusurduk
            motosikletTanimi2 = null; //bellekten dusurduk
        }
    }

    class Motosiklet
    {
        public string marka;
        public string model;
        public string renk;
    }
}
