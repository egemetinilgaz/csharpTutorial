using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira13.Ders2.SanalMetotKullanim
{
    public class baseClass
    {
        public baseClass()
        {
            Console.WriteLine("base class yapici metodu");
        }
        
        //virtual sanal metot olusturur
        public virtual void ekranaYaz(string data) // baseClass'in imzasi
        {
            Console.WriteLine(data);
        }
    }
}
