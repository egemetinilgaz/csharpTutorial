namespace NetFramework.Sira19.Ders1.WindowsFormNedir
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
            this.butonac = new System.Windows.Forms.Button();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butonac
            // 
            this.butonac.Location = new System.Drawing.Point(63, 74);
            this.butonac.Name = "butonac";
            this.butonac.Size = new System.Drawing.Size(164, 68);
            this.butonac.TabIndex = 0;
            this.butonac.Text = "ikinci formu ac";
            this.butonac.UseVisualStyleBackColor = true;
            this.butonac.Click += new System.EventHandler(this.butonac_Click);
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(63, 48);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(164, 20);
            this.txtMesaj.TabIndex = 1;
            this.txtMesaj.Text = "bir metin girin";
            this.txtMesaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMesaj.TextChanged += new System.EventHandler(this.txtMesaj_TextChanged);
            this.txtMesaj.Enter += new System.EventHandler(this.txtMesaj_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "ikinci form uzerinde yazmasini \r\nistediginiz metni girin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 170);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.butonac);
            this.Name = "Form1";
            this.Text = "Hello Windows Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butonac;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Label label1;
    }
}

