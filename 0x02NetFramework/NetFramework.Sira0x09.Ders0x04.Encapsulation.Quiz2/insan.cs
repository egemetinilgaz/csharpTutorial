using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira9.Ders3.Encapsulation.Quiz
{
    internal class insan
    {
        /*
             * insan sinifi icinde _tckimliknumarasi adinda private field yapalim
             * set: girilen deger 11 haneli olmali
             * set: girilen degerler sayisal olmasi diyecek
             * 
             * get: deger okunmaz sekilde davransin
             * get: ilk 3 hanesini gosterelim
             */

        private string _tckimliknumarasi;

        public string TCKimlikNumarasi
        {
            get
            {
                return _tckimliknumarasi.Substring(0, 3);
                //Substring(0, 3) metodu ile ilk 3 haneyi gosteriyoruz
                //0. index'ten 3 hane goster demek
            }
            set
            {
                if (value.Length == 11)
                {
                    bool hataYakala = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        //char.IsNumber ile girilen degerin sayi olup olmadigina bakiyoruz
                        if (karakterKontrol)
                        {

                        }
                        else
                        {
                            hataYakala = true;
                            break;
                        }
                    }
                    if (hataYakala)
                    {
                        Console.WriteLine("degerler sayisal olmalidir");
                    }
                    else
                    {
                        this._tckimliknumarasi = value;
                    }
                }
                else
                {
                    Console.WriteLine("11 haneli bir deger girmelisiniz");
                }
            }
        }

    }
}
