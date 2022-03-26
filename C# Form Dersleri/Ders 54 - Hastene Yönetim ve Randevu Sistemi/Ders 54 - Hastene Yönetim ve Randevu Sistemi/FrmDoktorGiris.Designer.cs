namespace Ders_54___Hastene_Yönetim_ve_Randevu_Sistemi
{
    partial class FrmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiris));
            this.textSifre = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.btnGirisyap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textSifre
            // 
            this.textSifre.Location = new System.Drawing.Point(245, 167);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(128, 29);
            this.textSifre.TabIndex = 12;
            this.textSifre.Text = "3333";
            this.textSifre.UseSystemPasswordChar = true;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(245, 122);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(128, 29);
            this.mskTc.TabIndex = 11;
            this.mskTc.Text = "33333333333";
            this.mskTc.ValidatingType = typeof(int);
            // 
            // btnGirisyap
            // 
            this.btnGirisyap.Location = new System.Drawing.Point(262, 215);
            this.btnGirisyap.Name = "btnGirisyap";
            this.btnGirisyap.Size = new System.Drawing.Size(111, 34);
            this.btnGirisyap.TabIndex = 10;
            this.btnGirisyap.Text = "Giriş Yap";
            this.btnGirisyap.UseVisualStyleBackColor = true;
            this.btnGirisyap.Click += new System.EventHandler(this.btnGirisyap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "TC Kimlik NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 53);
            this.label1.TabIndex = 13;
            this.label1.Text = "Doktor Giriş Paneli";
            // 
            // FrmDoktorGiris
            // 
            this.AcceptButton = this.btnGirisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(562, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.btnGirisyap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorGiris";
            this.Text = "Sea Green Hospital";
            this.Load += new System.EventHandler(this.FrmDoktorGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Button btnGirisyap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}