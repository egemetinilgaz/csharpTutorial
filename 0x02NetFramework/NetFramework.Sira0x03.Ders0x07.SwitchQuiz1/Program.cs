using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira3.Ders7.Switch.Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullaniciya kacinci ayda oldugunu soracagiz
            //kullanici sayisal bir deger girecek ve biz denk gelen ayi bildirecegiz

            string kullaniciGelenDeger = string.Empty;

            //goto kullanimi icin bir etiket tanimlama

            YenidenSecim:
                       
            Console.WriteLine("bulundugunuz ay'in sayisal degerini girin: ");
            kullaniciGelenDeger = Console.ReadLine();
           
            switch (kullaniciGelenDeger)
            {
                case "1":
                    Console.WriteLine("Ocak");
                    break;
                case "2":
                    Console.WriteLine("Subat");
                    break;
                case "3":
                    Console.WriteLine("Mart");
                    break;
                case "4":
                    Console.WriteLine("Nisan");
                    break;
                case "5":
                    Console.WriteLine("Mayis");
                    break;
                case "6":
                    Console.WriteLine("Haziran");
                    break;
                case "7":
                    Console.WriteLine("Temmuz");
                    break;
                case "8":
                    Console.WriteLine("Ağustos");
                    break;
                case "9":
                    Console.WriteLine("Eylul");
                    break;
                case "10":
                    Console.WriteLine("Ekim");
                    break;
                case "11":
                    Console.WriteLine("Kasim");
                    break;
                case "12":
                    Console.WriteLine("Aralik");
                    break;
                default:
                    Console.WriteLine("aralik disi deger girisi yaptiniz");
                    goto YenidenSecim; //goto yazdigin zaman break'e gerek yok, kullanilmaz                    
            }

        }
    }
}
