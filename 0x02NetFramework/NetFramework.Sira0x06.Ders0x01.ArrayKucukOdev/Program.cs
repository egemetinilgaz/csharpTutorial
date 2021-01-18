using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.Sira6.Ders2.ArrayKucukOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 elemanli (string) arraylist icindeki degerleri Z-A olacak sekilde sirala

            ArrayList A1 = new ArrayList();

            A1.Add("Metin");
            A1.Add("Hatice");
            A1.Add("Fatma");
            A1.Add("Eda");
            A1.Add("Rahmi");
            A1.Add("Omer");
            A1.Add("Zeynep");
            A1.Add("Yagmur");
            A1.Add("Yalcin");
            A1.Add("Mehmet");

            A1.Sort();
            A1.Reverse();
        }
    }
}
