using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.Sira19.Ders4.MessageBoxUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            //asagida int deger dondurdugum icin
            //buraya int degisken atadik ve onun uzerine aldik
            int islemSonuc = yeniMusteriEkle(new musteri()
            {
                id = Guid.NewGuid(),
                isim = txtIsim.Text,
                soyisim = txtSoyisim.Text,
                eMailAdres = txteMailAdres.Text,
                telefonNumarasi = txtTelefonNumara.Text
            });

            if (islemSonuc > 0)
            {
                DialogResult res = MessageBox.Show("musteri ekleme basarili, " +
                    "yeni musteri eklemek ister misiniz",
                    "bilgilendirme", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                //kullanici yeni musteri eklemek istiyorsam
                //formun icerisindeki textbox'i silmem gerekiyor
                if (res == DialogResult.Yes)
                {
                    //bildirim balonunu doldururken dikkat et
                    //eksik doldurursan surekli hata alirsin
                    bildirimEkrani = new NotifyIcon();
                    bildirimEkrani.BalloonTipText = "toplam musteri sayisi:"
                        + sanalDatabase.musteriler.Count.ToString();
                    bildirimEkrani.BalloonTipTitle = "musteri adet bilgisi";
                    bildirimEkrani.Visible = true; //bunu yapmazsan goremezsin
                    bildirimEkrani.Icon = SystemIcons.Information;
                    bildirimEkrani.ShowBalloonTip(1500);

                }
                else if (res == DialogResult.No)
                {

                }
                ekranTemizle(); //yukaridaki 2 sart icin de calisacagi icin
                //buraya yani ortak alana aldim
                ekranListele(); //burada da ekran listele metodumu cagirdim
            }
            else
            {
                MessageBox.Show("hata: kayit ekleme islemi yapilmadi");
            }

        }

        private void ekranListele()
        {
            lstMusteriler.DataSource = sanalDatabase.musteriler;
            //tostring'i override etmedigim icin
            //namespace ve class ismi gorunecek
            //bunu musteri class'inda hallediyorum
            //class'in standart calismasina mudahale ediyoruz aslinda
        }
        
        private void ekranTemizle()
        {
            txtIsim.Text = string.Empty;
            txtSoyisim.Text = string.Empty;
            txteMailAdres.Text = string.Empty;
            txtTelefonNumara.Text = string.Empty;
        }

        private int yeniMusteriEkle(musteri data)
        //burada geriye int deger donduruyoruz
        {
            sanalDatabase.musteriler.Add(data);
            return 1;
        }
    }
}
