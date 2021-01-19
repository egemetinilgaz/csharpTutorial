using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira7.Ders5.ParamsKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanimi yapmadan parametre ekler gibi istedigimiz kadar ekleriz
            //params ifadesi bizim belirtmis oldugumuz veri titpindeki degerleri
            //iceride dizi haline getirir
            //
            topla(5, 9, 20, 45, 22, 12, 11, 56);//burada dizi tanimi yapmiyoruz
            //belirtmis oldugumuz veri tipinden sirali data ister, yani int[] turunden
        }
        //params ifadesinden sonra string fade alamazsin
        //params ifadesi, parametrelerin son parametresi olmalidir
        // static void topla(string metin1, params int[] sayilar)
        static void topla(params int[] sayilar)//burada yukarida verilen degerler oto dizi olur
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
                //toplam = toplam + sayilar[i]; boyle de yazilirdi
            }
            Console.WriteLine("toplam: {0}", toplam);
            Console.ReadLine();
        }
    }
}
