using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira9.Ders2.Encapsulation.Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir onceki encapsulation dersinde yaptigimiz
            //get edilmesin ama set edilsin orneginin tam tersini
            //farkli icerikli bir ornek ile sen yap

            aile benimAilem = new aile();

            Console.WriteLine("aile kisi sayisi:" + benimAilem.ToString());
            Console.ReadLine();
        }
    }
}
