using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira12.Ders1.KalitimNedir
{
    public class ogrenci:temelTip
    {
        public string bolum { get; set; }
        public string ogrenciSeviye { get; set; }

        public ogrenci()
        {
            Console.WriteLine("ogrenci listesi yapici metot calisti");
            temelTipMetot2(); //ogrenci, temeltip'den kalitim yolu ile olustugu icin, 
            //temelTipMetot2(); metodunu burada da cagirabilirim.

            //peki programcs'de ogrenci nesnesini olusturdugumuzda,
            //olusturdugumuz ogrenci nesnesinden temelTipMetot2(); da ulasabilir miyiz?
            //HAYIR
        }
    }
}
