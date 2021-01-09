using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira13.Ders2.SanalMetotKullanim
{
    public class urun : baseClass
    {
        public urun()
        {
            Console.WriteLine("urun sinifinin yapici metodu");
        }
        
        public override void ekranaYaz(string data) //buraya baseClass'in imzasi aynen gelir
        {
            // base.ekranaYaz(data); //burasi degistirilebilir kisim
            Console.WriteLine("urun => " + data);
        }
    }
}
