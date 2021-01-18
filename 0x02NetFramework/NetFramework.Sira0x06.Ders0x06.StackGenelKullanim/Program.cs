using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira6.Ders7.StackGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            //genel kullanim

            Stack S1 = new Stack();

            //icerisine aldigi datalari komut kullanarak sirali sekilde kendi listesinden cikarir

            //davranis sekli soyle; last in, first out(lifo), son giren once cikar
            //yani en son gelen data, ilk isleme giren data oluyor

            S1.Push("bir");
            S1.Push("iki");
            S1.Push("uc");
            S1.Push("dort");
            //bir datayi obje biciminde koleksiyonumuza ekler

            //object olarak iceride tuttuklari degerleri donerler
            object o1 = S1.Pop(); //dataya onizleme yapar, bir sonraki islenecek data budur diyor
            //daha sonra kendisinden remove eder
            object o2 = S1.Peek(); //pop ile ayni islemi yapar ama remove etmez
        }
    }
}
