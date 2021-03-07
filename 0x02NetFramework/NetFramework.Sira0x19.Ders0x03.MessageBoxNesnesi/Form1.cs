using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.Sira19.Ders3.MessageBoxNesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMesajGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kullaniciya gostermek istedigimiz bilgi", "baslik bilgisi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSoruSor_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("yeniden denemek ister misin?",
                 "soru", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(res == DialogResult.Yes)
            {

            }
            else if (res == DialogResult.No)
            {

            }
            else if(res == DialogResult.Cancel)
            {

            }
        }
    }
}
