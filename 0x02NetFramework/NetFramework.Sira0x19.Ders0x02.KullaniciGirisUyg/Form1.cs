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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string _kullaniciAdi = txtKullaniciAdi.Text;
            string _sifre = txtKullaniciSifre.Text;

            //burada _kullaniciAdi ile gelen parametreyi, kullaniciTablo'da
            //ariyoruz ve orada olup olmadigina bakiyoruz
            kullanici bulunanKullanici = sanalDatabase.kullaniciTablo.Find
                (i => i.kullaniciAdi == _kullaniciAdi && i.sifre == _sifre);

            // _kullaniciAdi == "admin" && _sifre == "123"
            if (bulunanKullanici != null)
            {
                anaForm _anaForm = new anaForm(bulunanKullanici);
                _anaForm.Show();
            }
            else
            {
                /*
                 * windows form icinde kullaniciya popup gostermeyi
                 * ufak bir sekilde inceleyecegiz
                 * daha sonra ayrica islenecek
                 */
                MessageBox.Show("Hatali Giris", "HATA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.Gray;
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }

        private void txtKullaniciSifre_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.Gray;
        }

        private void txtKullaniciSifre_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
