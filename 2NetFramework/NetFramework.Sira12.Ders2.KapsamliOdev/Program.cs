using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira12.Ders2.KapsamliOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            bilgisayar B1 = new bilgisayar();
            // B1.id = 1; //buraya deger girilmeyecek, ama uygulama set edilir sekilde de birakmayacak
            B1.marka = "Apple";
            B1.model = "MacBook Pro 2020";
            B1.islemci = "8. nesil Intel Core i5 işlemci";
            B1.alisFiyat = 9000M;
            B1.satisFiyat = 14000M;
            B1.kampanyaFiyat = 9000M;
            B1.barkod = "123456"; //barkod icin sanal bir database yapacagim

            sanalDatabase.yeniUrunEkle(B1);

        }
    }
}
