using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira10.Ders1.StaticNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            //static; nesne ornegi alinmadan ulastigimiz field, metot, class....

            //stack bolge icerisinde pointer'imiz olustu
            nedirStatic S1;
            //stack bolgede pointer olustugu zaman static olan bir yapici metot calisti ve
            //yine class icerisinde tanimli olan static field-metot, static bolgede olustu
            nedirStatic.test2();
            //static bolgeye ulasmak icin nesne adi (S1) degil
            //class adi nedirStatic. yapman gerekiyor





            //nesne ornegi alindiktan sonra;
            S1 = new nedirStatic();
            //stack bolgede pointer => kendisini heap bolgede tanimladi, static olmayan tanimlari tamamladi
            S1.test1();//nesne ornegi alindiktan  sonra test1 metoduna ulastim

            //static neden ve nerelerde kullanilir
            /*
             * 1- helper.cs => kontroller
             * 2- olusturdugumuz nesnemizin => bagimliligi farkli class'lara oldugu icin
             * (proje icerisinde ozel oldugu icin) nesne icerisinde static metot tanimi yapilir
             * 3- class icerisinde bir field (static) tanimi yapar, ilgili field icerisine deger
             * atamasi yapariz, daha sonra uygulama icerisinde N(birdenfazla farkli yer) 
             * farkli yerde olusturdugumuz static field'a ulasir, degerleri okuruz
             * 4- [uygulama] => [ozelHelper] => [DLL]
             * BURALARI SU AN TAM ANLAYAMIYORSUN AMA ILERLEMEYE DEVAM ET, ANLAYACAKSIN.
             */

        }
    }
}
