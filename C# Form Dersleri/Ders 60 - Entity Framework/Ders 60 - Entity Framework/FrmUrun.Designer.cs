namespace Ders_60___Entity_Framework
{
    partial class FrmUrun
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStokSayı = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(134, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(176, 29);
            this.txtId.TabIndex = 1;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(134, 58);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(176, 29);
            this.txtUrunAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(134, 110);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(176, 29);
            this.txtMarka.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marka:";
            // 
            // txtStokSayı
            // 
            this.txtStokSayı.Location = new System.Drawing.Point(134, 160);
            this.txtStokSayı.Name = "txtStokSayı";
            this.txtStokSayı.Size = new System.Drawing.Size(176, 29);
            this.txtStokSayı.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stok Sayısı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fiyat:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(134, 217);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(176, 29);
            this.txtFiyat.TabIndex = 9;
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(134, 269);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(176, 29);
            this.txtDurum.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Durum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kategori:";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(425, 50);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(109, 45);
            this.btnListele.TabIndex = 14;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(425, 107);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 45);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(425, 159);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(109, 45);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(425, 210);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(109, 45);
            this.BtnGuncelle.TabIndex = 17;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(425, 261);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(109, 45);
            this.BtnTemizle.TabIndex = 18;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 399);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(629, 150);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 316);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 30);
            this.comboBox1.TabIndex = 20;
            // 
            // FrmUrun
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(656, 596);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStokSayı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUrun";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStokSayı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}