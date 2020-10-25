using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira6.Ders8.QueueGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            //genel kullanim

            //davranis sekli soyle; first in, first out(fifo), ilk giren ilk cikar
            //yani ilk gelen data, ilk isleme giren data oluyor

            Queue Q1 = new Queue();

            //ekleme metodu farkli, enqueue ile ekliyorum
            Q1.Enqueue("bir");
            Q1.Enqueue("iki");
            Q1.Enqueue("uc");
            Q1.Enqueue("dort");

            object O1 = Q1.Peek(); //silinmeden on izleme verir
            object O2 = Q1.Dequeue(); //degeri gonderdikten sonra, siler
                
        }
    }
}
