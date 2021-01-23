using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira12.Ders2.KapsamliOdev
{
    public static class sanalDatabase
    {
        private static ArrayList db = new ArrayList(); //db adinda bir arraylist olusturdum
        //ve nesneyi orrneklemeyi unutma
        //ben buraya mudahele edilsin istemiyorum
        //o yuzden iceride static bir metot olusturup bu islemi cozecegim

        public static void yeniUrunEkle(baseClass data)
        {
            /*
             * eger database icinde benim eklemek istedigim data varsa arraylist'e eklemeyecegim
             */
            if (data != null && !string.IsNullOrEmpty(data.barkod))
            {
                db.Add(data);
            }
        }

        public static bool dbBarkodKontrol(string barkod1)
        {
            bool kontrolIslemi = false;
            if (db != null && db.Count > 0)
            {
                for (int i = 0; i < db.Count; i++)
                {
                    baseClass objeCevir = (baseClass)db[i]; //bu  kismi iyi incele ve birine anlatacak kadar anla
                    if (objeCevir.barkod == barkod1)
                    {
                        kontrolIslemi = true;
                    }
                }
            }
            return kontrolIslemi;
        }
    }
}
