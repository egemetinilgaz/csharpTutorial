using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira14.Ders1.AbstractNedir
{
    public class musteri : temelSinif
    {
        public int musteriID { get; set; }

        public musteri()
        {
            musteriID = 1;
        }

        //implement edilen kisim
        public override void testAbstract() //dikkat et override etti
        {
            // throw new NotImplementedException();
            //kendi body'sini yazmak zorunda
            Console.WriteLine("musteri sinifinin testAbstract'i");
        }
    }
}
