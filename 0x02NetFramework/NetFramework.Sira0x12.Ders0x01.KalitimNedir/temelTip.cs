using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira12.Ders1.KalitimNedir
{
    public class temelTip
    {
        public int ID { get; set; }
        public string refefansKod { get; set; }
        public string TCkimlikNo { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int cinsiyet { get; set; }
        public DateTime kayitTarihi { get; set; }
        public int kayitKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncellemeKullanici { get; set; }
        public bool silindi { get; set; }

        public temelTip() //yapici metot
        {
            Console.WriteLine("temel tip nesnesinin yapici metodu calisti");
            idAtamaIslemi(); // asagidaki metodu burada cagirdim
            //unutma cagirilmamis metot, yazilmamis metot'dur
        }

        private void idAtamaIslemi()
        {
            Random randomsayi = new Random();
            this.ID = randomsayi.Next(1000, 9000);
        }

        public void TemelTipMetot1()
        {
            Console.WriteLine("temeltip icerisinde metot 1");
            temelTipMetot2(); //protected metoda burada ulasirsin cunku private gibi davranir
        }

        protected void temelTipMetot2()
        {
            Console.WriteLine("protected metot");
            //bunu burada ya da bundan turetilen siniflarda cagirabilirsin
            //bakiniz yukarida cagirdik
            //ve yine ogrenci class'i icinde de cagirdik
        }
    }
}
