using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira9.Ders2.Encapsulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri2 Musteri1 = new musteri2();

            
            Musteri1.EMailAdress = "ilgazzegemetin@gmail.com";
            Console.WriteLine(Musteri1.EMailAdress);




            //musteri2 class'indaki public int ID'yi cagirdik
            //get ile istedigimiz degeri aldik
            //set'i de private yaptik, ve mudahale edilemez hale getirdik
            //field icerisine deger atanamasin ama deger okunsun
            Console.WriteLine("musteri id numarasi: " + Musteri1.ID.ToString());
            
            // Musteri1.ID = 10; //burada hata verecek, cunku set blogu private

            Console.ReadLine();
        }
    }
}
