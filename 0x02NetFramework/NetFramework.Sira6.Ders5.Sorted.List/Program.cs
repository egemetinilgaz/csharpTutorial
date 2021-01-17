using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira6.Ders6.Sorted.List
{
    class Program
    {
        static void Main(string[] args)
        {
            //genel kullanim

            //icerisine key ve value degerleri alan bir koleksiyodur
            //hashtable dan farki her bir degerin, key degerine  gore kendi siralar (A-Z)
            //key degerlerinin ayni turden olmasi gerekir (string ve int olmaz mesela) 
            //siralama isleminin olmasi icin
            //icerisinde dongu kullanilabilir

            SortedList SortedL = new SortedList();

            SortedL.Add(100, "yuz");
            SortedL.Add(90, "doksan");
            SortedL.Add(1, "bir");
            SortedL.Add(9000, "dokuzbin");

            // SortedL.Add("A", "B"); burada hata verir, cunku iceride int olan listeye
            //string deger atadik
            //string baslarsan string devam et, int baslarsan int devam et

            //hashtable ile ayni yardimci metotlari kullanirsin
        }
    }
}
