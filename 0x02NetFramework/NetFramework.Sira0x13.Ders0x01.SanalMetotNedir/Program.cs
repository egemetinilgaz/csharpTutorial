using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira13.Ders1.SanalMetotNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            //butun nesneler object'den gelir

            //tostring metodu cagirildiginda, 
            //cagrilan class'in, namespace'ini ve class'in adini bize doner
            //bu .net'in standart davranisi

            musteri M1 = new musteri();
            M1.isim = "Ege Metin";
            M1.soyisim = "ILGAZ";
            string toStringMesaj = M1.ToString();
            Console.WriteLine(toStringMesaj);
            Console.ReadLine();

            //ekran  ciktisi: NetFramework.Sira13.Ders1.SanalMetotNedir.musteri
        }
    }
}
