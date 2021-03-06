using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.Sira19.Ders2.KullaniciGirisUyg
{
    public partial class anaForm : Form
    {
        public anaForm(kullanici bulunanKullanici_)
        {
            InitializeComponent();
            txtIsim.Text = bulunanKullanici_.isim;
            txtSoyisim.Text = bulunanKullanici_.soyisim;
            txtKullaniciAdi.Text = bulunanKullanici_.kullaniciAdi;
            txtKullaniciAdi.Enabled = false; //girilemez olacak
            txtSifre.Text = bulunanKullanici_.sifre;
            txtAciklama.Text = bulunanKullanici_.aciklama;
            btnGuncelle.Tag = bulunanKullanici_.id; //tag icerisinde object tutar
        }

        private void anaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Button btnYakalaGuncelle = (Button)sender; 
            //sender ornegi, altta da ayni islem yapilacak
            int _id = (int)btnGuncelle.Tag;
            //burada id degerini yakaliyoruz islem yapmak icin
            int index = sanalDatabase.kullaniciTablo.FindIndex
                (i => i.id == _id);
            //soldaki id, benim kullanici sinifindaki id degerim
            //sagdaki ise burada olusturdugum degisken
            sanalDatabase.kullaniciTablo[index].isim = txtIsim.Text;
            sanalDatabase.kullaniciTablo[index].soyisim = txtSoyisim.Text;
            sanalDatabase.kullaniciTablo[index].sifre = txtSifre.Text;
            sanalDatabase.kullaniciTablo[index].kullaniciAdi = txtKullaniciAdi.Text;
        }
    }
}
