namespace Ders_54___Hastene_Yönetim_ve_Randevu_Sistemi
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.textAd = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.BtnKayitYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(213, 26);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(146, 29);
            this.textAd.TabIndex = 1;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(213, 115);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(146, 29);
            this.mskTc.TabIndex = 3;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "TC Kimlik NO:";
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(213, 70);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(146, 29);
            this.textSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefon Numarası:";
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(213, 160);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(146, 29);
            this.mskTel.TabIndex = 4;
            // 
            // textSifre
            // 
            this.textSifre.Location = new System.Drawing.Point(213, 208);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(146, 29);
            this.textSifre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cinsiyet:";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(213, 255);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(146, 30);
            this.cmbCinsiyet.TabIndex = 6;
            // 
            // BtnKayitYap
            // 
            this.BtnKayitYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnKayitYap.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnKayitYap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnKayitYap.Location = new System.Drawing.Point(213, 310);
            this.BtnKayitYap.Name = "BtnKayitYap";
            this.BtnKayitYap.Size = new System.Drawing.Size(146, 45);
            this.BtnKayitYap.TabIndex = 19;
            this.BtnKayitYap.Text = "Kayıt Yap";
            this.BtnKayitYap.UseVisualStyleBackColor = false;
            this.BtnKayitYap.Click += new System.EventHandler(this.BtnKayitYap_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.BtnKayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(430, 383);
            this.Controls.Add(this.BtnKayitYap);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Sea Green Hospital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Button BtnKayitYap;
    }
}