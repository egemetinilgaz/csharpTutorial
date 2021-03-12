namespace NetFramework.Sira19.Ders4.MessageBoxUygulama
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.txtTelefonNumara = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txteMailAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstMusteriler = new System.Windows.Forms.ListBox();
            this.bildirimEkrani = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYeniKayit);
            this.groupBox1.Controls.Add(this.txtTelefonNumara);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txteMailAdres);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoyisim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIsim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Musteri Ekleme Formu";
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(102, 136);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(111, 23);
            this.btnYeniKayit.TabIndex = 4;
            this.btnYeniKayit.Text = "Yeni Musteri Ekle";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // txtTelefonNumara
            // 
            this.txtTelefonNumara.Location = new System.Drawing.Point(102, 109);
            this.txtTelefonNumara.Name = "txtTelefonNumara";
            this.txtTelefonNumara.Size = new System.Drawing.Size(112, 20);
            this.txtTelefonNumara.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon Numarasi";
            // 
            // txteMailAdres
            // 
            this.txteMailAdres.Location = new System.Drawing.Point(102, 83);
            this.txteMailAdres.Name = "txteMailAdres";
            this.txteMailAdres.Size = new System.Drawing.Size(112, 20);
            this.txteMailAdres.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "eMailAdresi";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(102, 57);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(112, 20);
            this.txtSoyisim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(102, 31);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(112, 20);
            this.txtIsim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Isim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstMusteriler);
            this.groupBox2.Location = new System.Drawing.Point(238, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Musteri Kayit Listesi";
            // 
            // lstMusteriler
            // 
            this.lstMusteriler.FormattingEnabled = true;
            this.lstMusteriler.Location = new System.Drawing.Point(6, 19);
            this.lstMusteriler.Name = "lstMusteriler";
            this.lstMusteriler.Size = new System.Drawing.Size(261, 147);
            this.lstMusteriler.TabIndex = 0;
            // 
            // bildirimEkrani
            // 
            this.bildirimEkrani.Text = "notifyIcon1";
            this.bildirimEkrani.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 200);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Message Box Uygulama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.TextBox txtTelefonNumara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txteMailAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMusteriler;
        private System.Windows.Forms.NotifyIcon bildirimEkrani;
    }
}

