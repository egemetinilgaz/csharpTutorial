using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira18.Ders6.GenericClassNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Database | Uygulama
             * MSSQL    | C#
             * 
             * 
             * tabloMusteri
             * id int
             * musteriNumara uniqueidentitfy (guid)
             * isim nvarchar(50) string
             * soyisim nvarchar(50) string
             * dogumTarih datetime datetime
             * 
             * UnitOfWorks => Generic Class | Generic Interface
             * 
             * 
             */

            genericRepository<musteri> repositoryMusteri = new genericRepository<musteri>();
            List<musteri> musterilerim = repositoryMusteri.getir();
            repositoryMusteri.yeniKayitEkle(null);

            genericRepository<urun> repositoryUrun = new genericRepository<urun>();
            List<urun> urunlerim = repositoryUrun.getir();
            repositoryUrun.yeniKayitEkle(null);

            //biz burada bir genericRepository class'i ile birden fazla is yapabiliyoruz

        }
    }
}
