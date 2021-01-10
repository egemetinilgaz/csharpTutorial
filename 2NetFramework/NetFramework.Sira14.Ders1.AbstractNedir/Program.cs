using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira14.Ders1.AbstractNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            // temelSinif T1 = new temelSinif(); burasi hata verir
            //kalitan nesne, kalitilan nesne bir abstract olsa bile constructor'ini (ctor) calistirir
            //icerisinde bulunan field'lar da, temelSinifin yapici metodundaki degerleri alir
            //yani nesne ornegi alinamaz ama kalitilabilir
            //abstract  direkt turetilmez, direkt ulasip kullanilamaz
            //static metotlar ozet olarak bildirilmez
            //virtual anahtar sozcugu kullanilmaz
            
            superMusteri SP1 = new superMusteri();
            SP1.testAbstract();
            
            
            musteri M1 = new musteri();
            M1.test(); //temelSinif icindeki metodu da kullanabiliriz
            M1.testAbstract();


            Console.ReadLine();
        }
    }
}
