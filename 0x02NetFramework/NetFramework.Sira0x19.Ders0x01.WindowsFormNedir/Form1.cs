using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.Sira19.Ders1.WindowsFormNedir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //eger bir windows form elemanina dokunmak istersek
            //buradan ya da daha asagidan bu islemleri yapmaliyiz
            txtMesaj.Text = "metin girin";
            //form1.cs'nin icinde "bir metin girin" yazdiktan sonra
            //burada da txtMesaj.Text = "metin girin"; bu kod ile
            //bunu yazdiginda en son yaptigin guncel kalir
            //yani ekrana metni girin yazar
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butonac_Click(object sender, EventArgs e)
        //(object sender, EventArgs e) sender bize nereden geldigini gosterir
        //yani butonac'dan geliyorum diyor
        //EventArgs e ise bize olaylari gosterir
        {
            //simdi form1 uzerinden, merhabaform'a ulasacagiz
            //aslinda burada class orneklemeye benzer bir sey yapacagiz
            //class => musteri M1 = new musteri();

            string txtMesajDegeri = txtMesaj.Text;

            merhabaForm mrbForm = new merhabaForm(txtMesajDegeri);
            //merhabaform'un yapici metodunda ki parametreyi
            //burada kullandik
            mrbForm.Show(); //ornekledigimiz class'i gostermeye yarar
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMesaj_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMesaj_Enter(object sender, EventArgs e)
        {
            //kullanici tikladiginda text'i temizlemek icin
            //bu seviyede uc bir ornek ama gorelim
            TextBox T1 = (TextBox)sender;
            //T1 demek: formun uzeindeki textbox programsal olarak elimde demek
            //burada sender'dan obje olarak gelen bir textbox var
            //bunu textbox'a ceviriyorum
            T1.Text = string.Empty;
        }

        //acilan formlarin tam oradan acilmasini istiyorsan
        //form ozellilerinden, startposition secenegini
        //centerscreen yapmalisin

        //form'un boyutlarinin kullanici tarafindan degistirilmesini
        //istemezsek yine formun ayarlarindan formborderstyle
        //seceneginden fixedtoolwindow'u secmelisin
    }
}
