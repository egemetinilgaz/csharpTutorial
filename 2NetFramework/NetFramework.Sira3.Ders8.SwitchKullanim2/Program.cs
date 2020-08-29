using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira3.Ders8.SwitchKullanim2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciGelenDeger = string.Empty;

        //goto kullanimi icin bir etiket tanimlama

        YenidenSecim:

            Console.WriteLine("bir deger girin ve faz ogrenin: ");
            kullaniciGelenDeger = Console.ReadLine();

            //switch case 2 farkli kullanim

            //bir projenin bolumlendirilmesi

            switch (kullaniciGelenDeger)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                    Console.WriteLine("1. Faz");
                    break;

                case "5":
                case "6":
                case "7":
                case "8":
                    Console.WriteLine("2. Faz");
                    break;

                case "9":
                case "10":
                case "11":
                case "12":
                    Console.WriteLine("3. Faz");
                    break;


                default:
                    Console.WriteLine("aralik disi deger girisi yaptiniz");
                    goto YenidenSecim; //goto yazdigin zaman break'e gerek yok, kullanilmaz
            }
        }
    }
}
