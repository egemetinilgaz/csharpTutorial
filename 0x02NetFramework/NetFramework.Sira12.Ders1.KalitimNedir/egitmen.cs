using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira12.Ders1.KalitimNedir
{
    public class egitmen : personel
    {
        public string brans { get; set; }
        public int bransSeviye { get; set; }


        public egitmen() //yapici metot
        {
            Console.WriteLine("egitmen nesnesinin yapici metodu calsiti");
        }

        // idAtamaIslemi(); bunu burada cagiramazsin,cunku bu  temelTip class'i icerisinde private
        //bunu cagirmanin yolu var, daha sonraki derslerde islenecek
    }
}
