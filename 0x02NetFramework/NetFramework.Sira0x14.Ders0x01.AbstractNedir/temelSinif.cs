using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira14.Ders1.AbstractNedir
{
    public abstract class temelSinif //burada sealed kullanamazsin
                                     //yani hem abstract, hem de sealed olamaz
                                     //cunku abstract bir sablondu ve kalitilmasi gerekiyor
    {
        public DateTime kayitTarihi { get; set; }
        public DateTime guncellemeTarih { get; set; }

        public temelSinif()
        {
            kayitTarihi = DateTime.Now;
            guncellemeTarih = DateTime.Now;
        }

        public void test()
        {
            Console.WriteLine("temelSinif icindeki test metodu");
        }

        /* public abstract void testAbstract()
        {
            // abstract metotlarin metot body'si olmaz
            // nesne ornegi alinamayan, bizim hazirlamis oldugumuz metotlari ya da field'lari
            // kullanima zorunlu  hale getiriyoruz
        }*/

        public abstract void testAbstract(); //sadece metot imzasi kismi yazilir ve birakilir
        //bu metodu musteri class'inda kullanmak zorundasin, mantik bu, yani implement edeceksin
        //implement etmek: class'in icerisindeki o metot imzasini kullanmak demek
    }
}
