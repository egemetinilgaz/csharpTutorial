using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira3.Ders2.if_else.Ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanici adi ve sifre isteyen uygulama yap

            #region kullanici adi ve sifre isteme ornek
            string kullaniciAdi = "";
            string kullaniciSifre = "";

            Console.Write("kullanici adini girin: ");
            kullaniciAdi = Console.ReadLine();

            Console.WriteLine("kullanici sifre girin: ");
            kullaniciSifre = Console.ReadLine();

            if (kullaniciAdi == "Demo" && kullaniciSifre == "1234")
            {
                Console.WriteLine("basarili giris");
            }
            else
            {
                Console.WriteLine("hatali giris");
            }
            #endregion            

            Console.ReadLine();
        }
    }
}
