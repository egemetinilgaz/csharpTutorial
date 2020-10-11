using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira6.Ders3.HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();
            //hashtable i sozluk gibi dusun

            //deger ekleme

            H1.Add("car", "araba");
            H1.Add("house", "ev");
            //burada car ve house key, araba ve ev value degerlerdir
            //key degerler sozluk icinde yalnizca 1 kere kullanilir, tekrar edemez
            //value degerler ise tekrar edebilir

            H1.Add("cars", "araba");
            //H1.Add("cars", "arabalar"); bu hatali kullanim cunku cars keyi 1 defa kullanilir

            //yardimci metotlar

            //contains
            bool kontrol1 = H1.Contains("house"); //true
            bool kontrol2 = H1.Contains("door"); //false
            //burada contains metodu ilgili  degerlerin h1 icinde olup olmadigina bakar
            //true veya false doner

            //containskey
            bool kontrol3 = H1.ContainsKey("house"); //contains ile ayni isi yapar, keylerde arar

            //containsvalue
            bool kontrol4 = H1.ContainsValue("araba"); //burada value uzerinden deger aramasi yapariz

            //copyto
            //farkli bir hashtable verip su indexden basla, suraya kadar kopyala diyoruz

            //data duzenleme

            H1["house"] = "villa"; //ilgili key  degerini vererek, value degerini duzenler

            //remove
            H1.Remove("cars"); //key ile arama yapip value ile beraber tamamen siler
            
            //count
            int toplamDeger = H1.Count;
            //koleksiyon icindeki toplam degerlere bakar

            //clear
            H1.Clear(); //koleysiyon icindeki tum datayi temizler
        }
    }
}
