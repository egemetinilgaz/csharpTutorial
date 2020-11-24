using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira8.Ders3.Class.Quiz1
{
    public class arac
    {
        public string marka;
        public string model;
        public int modelYili;
        public decimal km;
        public int yakitTuru;
        public int vitesTipi;
        public decimal alisFiyat;
        public decimal satisFiyat;
        public decimal maxIndirimTutar;
        public decimal fiyat;

        public arac()
        {

        }

        public arac(string _marka, string _model)
        {
            marka = _marka;
            model = _model;
        }

        public arac(string _marka, string _model, int _modelYili)
        {
            marka = _marka;
            model = _model;
            modelYili = _modelYili;
        }

        public arac(string _marka, string _model, int _modelYili, decimal _km)
        {
            marka = _marka;
            model = _model;
            modelYili = _modelYili;
            this.km = _km; //buradaki this.km, yani bu class'in field i olan km demek
            //parametre olan _km degil
        }

        public void bilgileriGoruntule()
        {
            Console.WriteLine("Marka: {1}, model: {2}, model yili: {3}, km: {4}, yakit turu: {5}" +
                "vites tipi: {6}, alis fiyati: {7}, satis fiyati: {8}, max indirim tutar: {9}" +
                "fiyat: {10}", marka, model, modelYili, km, yakitTuru, vitesTipi, alisFiyat, satisFiyat,
                maxIndirimTutar, fiyat);
        }
        public void fiyatAta(decimal _fiyat)
        {
            decimal fiyatHesap = satisFiyat - maxIndirimTutar;
            if(_fiyat<fiyatHesap)
            {
                Console.WriteLine("gecersiz fiyat girisi");
            }
            else
            {
                this.fiyat = _fiyat;
                Console.WriteLine("fiyat guncellendi");
            }
        }
    }
}
