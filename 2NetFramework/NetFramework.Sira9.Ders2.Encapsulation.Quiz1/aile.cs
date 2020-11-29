using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sira9.Ders2.Encapsulation.Quiz1
{
    internal class aile
    {
        //bir onceki encapsulation dersinde yaptigimiz
        //get edilmesin ama set edilsin orneginin tam tersini
        //farkli icerikli bir ornek ile sen yap

        public aile()
        {
            this.sayi = aileKacKisi();
        }



        private int sayi;

        public int aileBirey
        {
            private get
            {
                return this.aileBirey;
            }
            set
            {
                this.aileBirey = value;
            }
        }



        private int aileKacKisi()
        {
            int aileSayi = 5;
            return aileSayi;
        }
    }
}
