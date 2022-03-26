namespace Ders_54___Hastene_Yönetim_ve_Randevu_Sistemi
{
    partial class FrmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDuzenle));
            this.BtnBilgiGuncelle = new System.Windows.Forms.Button();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBilgiGuncelle
            // 
            this.BtnBilgiGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnBilgiGuncelle.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBilgiGuncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnBilgiGuncelle.Location = new System.Drawing.Point(196, 346);
            this.BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            this.BtnBilgiGuncelle.Size = new System.Drawing.Size(146, 45);
            this.BtnBilgiGuncelle.TabIndex = 32;
            this.BtnBilgiGuncelle.Text = "Güncelle";
            this.BtnBilgiGuncelle.UseVisualStyleBackColor = false;
            this.BtnBilgiGuncelle.Click += new System.EventHandler(this.BtnBilgiGuncelle_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(196, 291);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(146, 30);
            this.cmbCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cinsiyet:";
            // 
            // textSifre
            // 
            this.textSifre.Location = new System.Drawing.Point(196, 244);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(146, 29);
            this.textSifre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Şifre:";
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(196, 196);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(146, 29);
            this.mskTel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Telefon Numarası:";
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(196, 106);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(146, 29);
            this.textSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Soyad:";
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(196, 62);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(146, 29);
            this.textAd.TabIndex = 1;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(196, 151);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(146, 29);
            this.mskTc.TabIndex = 3;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "TC Kimlik NO:";
            // 
            // FrmBilgiDuzenle
            // 
            this.AcceptButton = this.BtnBilgiGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(412, 429);
            this.Controls.Add(this.BtnBilgiGuncelle);
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
            this.Name = "FrmBilgiDuzenle";
            this.Text = "Sea Green Hospital";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBilgiGuncelle;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}