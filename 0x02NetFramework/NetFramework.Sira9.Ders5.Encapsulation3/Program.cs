using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira9.Ders3.Encapsulation3
{
    class Program
    {
        static void Main(string[] args)
        {
            email eMail1 = new email();

            eMail1.isim = "egemetin";
            eMail1.SoyIsim = "ilgaz";
            Console.WriteLine(eMail1.EMailAdres);
            Console.ReadLine();
        }
    }
}
