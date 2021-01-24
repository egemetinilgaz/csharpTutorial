using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira17.Ders1.EnumNedir
{
    public enum musteriReturnValue //class ifadesini enum olarak degistiriyorum
                                   //burada .net bunun artik bir tanim blogu oldugunu biliyor
                                   //enumlar kendi icinde int deger alirlar, vermezsek 0'dan baslar ve enum kadar devam ederler
                                   //ama sen bunlara asagidaki gibi degerler de verebilirsin
    {
        kayitBasarili = 71777001,
        kayitBasarisiz,
        varolanMusteri,
        parametreHatasi,
        calismaZamaniHatasi
    }
}
