using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira12.Ders1.KalitimNedir
{
    class Program
    {
        static void Main(string[] args)
        {

            temelTip T1 = new temelTip();
            T1.TemelTipMetot1(); //burada direkt metoda erisiyor
            
            egitmen E1 = new egitmen();
            
            Console.WriteLine("egitmen nesnesi orneklendi");
            E1.TemelTipMetot1(); //burada ben temeltip icindeki metodum diyor ve yine erisiyor
                                 //tek fark tooltip icerisinde nereden geldigini bize soyluyor

            /*
             * burada ilk once egitmen nesnesine gider
             * daha sonra orada bir kalitim gorur, yani temelTip'den kalitildigini gorur
             * ve ilk once temelTip icindeki yapici metot calisir
             * daha sonra tekrar egitmen icine gelir ve buradaki yapici metot'da calisir
             */

            personel P2 = new personel();
            P2.TemelTipMetot1();

            ogrenci O2 = new ogrenci();
            O2.TemelTipMetot1();


            //ozel tiplerde boxing - unboxing
            //bizim object nesnemiz nedir? temelTip
            temelTip T2;
            //hangi nesnelerde temelTip object gorevi gorur?
            //cevap: personel, egitmen, ogrenci
            //cevab sebebi: temelTip  nesnesinden turedikleri icin, temel tip nesnesi,bu nesnelerde
            //object gibi davranir
            T2 = E1; //egitmen nesnesini, temelTip nesnesine atadik, yani boxing yaptik
            E1 = (egitmen)T2; //unboxing yaptik

            personel P1 = new personel();
            T2 = P1; //personel nesnesini, temelTip nesnesine atadik, yani boxing yaptik
            P1 = (personel)T2; //unboxing yaptik

            ogrenci O1 = new ogrenci();
            T2 = O1; //ogrenci nesnesini, temelTip nesnesine atadik, yani boxing yaptik
            O1 = (ogrenci)T2; //unboxing yaptik

            //sealed ile nesnemizi muhurleriz ve kalitilmasini engelleriz
            //kullanim sekli: public sealed class egitmen : temelTip
            //kalitilmaz olan nesne, baska bir nesne icinde innertype olarak kullanilabilir

            egitmen E2 = new egitmen();
            /*
             * egitmen orneklenirken personeli gordu
             * personel temel tipi gordu
             * temel tip objeyi gordu (buradaki objeyi biz goremiyoruz ama her sey ondan turuyor)
             */
            //sonra da yukaridaki asamalarin tam tersi oldu ve 
            //egitmen orneklendi - egitmen E2 = new egitmen();

            //kalitim konusunun kendine has erisim belirleyicisi vardir, bu da protected
            /*
             * normal kullanimda private gibi davranir yani o sinifin disinda kullanilamaz
             * kalitim yolu ile baska bir class icerisinde public olarak kullanilir
             */

            temelTip T3 = new temelTip();

        }
    }
}
