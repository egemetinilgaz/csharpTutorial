﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira19.Ders4.MessageBoxUygulama
{
    public static class sanalDatabase
    {
        public static List<musteri> musteriler { get; set; }

        static sanalDatabase()
        {
            musteriler = new List<musteri>();
        }
    }
}
