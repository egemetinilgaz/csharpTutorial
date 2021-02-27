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
    public partial class merhabaForm : Form
    {
        public merhabaForm(string metin) //bu yapici metoda parametre girdik
        {
            InitializeComponent();
            //eger bir windows form elemanina dokunmak istersek
            //buradan ya da daha asagidan bu islemleri yapmaliyiz
            label1.Text = metin;
            //burada da label1.Text'in uzerine gelen metin degerini verdik
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void merhabaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
