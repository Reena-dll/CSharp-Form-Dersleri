namespace Ders_19___Bilgi_Yarışması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.butonA = new System.Windows.Forms.Button();
            this.butonB = new System.Windows.Forms.Button();
            this.butonC = new System.Windows.Forms.Button();
            this.butonD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDogru = new System.Windows.Forms.Label();
            this.labelYanlis = new System.Windows.Forms.Label();
            this.labelSoruNo = new System.Windows.Forms.Label();
            this.butonSonraki = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 13);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(447, 187);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // butonA
            // 
            this.butonA.Location = new System.Drawing.Point(23, 225);
            this.butonA.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.butonA.Name = "butonA";
            this.butonA.Size = new System.Drawing.Size(152, 44);
            this.butonA.TabIndex = 1;
            this.butonA.Text = "A";
            this.butonA.UseVisualStyleBackColor = true;
            this.butonA.Click += new System.EventHandler(this.butonA_Click);
            // 
            // butonB
            // 
            this.butonB.Location = new System.Drawing.Point(215, 225);
            this.butonB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.butonB.Name = "butonB";
            this.butonB.Size = new System.Drawing.Size(152, 44);
            this.butonB.TabIndex = 2;
            this.butonB.Text = "B";
            this.butonB.UseVisualStyleBackColor = true;
            this.butonB.Click += new System.EventHandler(this.butonB_Click);
            // 
            // butonC
            // 
            this.butonC.Location = new System.Drawing.Point(23, 294);
            this.butonC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.butonC.Name = "butonC";
            this.butonC.Size = new System.Drawing.Size(152, 44);
            this.butonC.TabIndex = 3;
            this.butonC.Text = "C";
            this.butonC.UseVisualStyleBackColor = true;
            this.butonC.Click += new System.EventHandler(this.butonC_Click);
            // 
            // butonD
            // 
            this.butonD.Location = new System.Drawing.Point(215, 294);
            this.butonD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.butonD.Name = "butonD";
            this.butonD.Size = new System.Drawing.Size(152, 44);
            this.butonD.TabIndex = 4;
            this.butonD.Text = "D";
            this.butonD.UseVisualStyleBackColor = true;
            this.butonD.Click += new System.EventHandler(this.butonD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doğru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yanlış:";
            // 
            // labelDogru
            // 
            this.labelDogru.AutoSize = true;
            this.labelDogru.Location = new System.Drawing.Point(590, 61);
            this.labelDogru.Name = "labelDogru";
            this.labelDogru.Size = new System.Drawing.Size(18, 19);
            this.labelDogru.TabIndex = 8;
            this.labelDogru.Text = "0";
            // 
            // labelYanlis
            // 
            this.labelYanlis.AutoSize = true;
            this.labelYanlis.Location = new System.Drawing.Point(590, 109);
            this.labelYanlis.Name = "labelYanlis";
            this.labelYanlis.Size = new System.Drawing.Size(18, 19);
            this.labelYanlis.TabIndex = 9;
            this.labelYanlis.Text = "0";
            // 
            // labelSoruNo
            // 
            this.labelSoruNo.AutoSize = true;
            this.labelSoruNo.Location = new System.Drawing.Point(590, 16);
            this.labelSoruNo.Name = "labelSoruNo";
            this.labelSoruNo.Size = new System.Drawing.Size(18, 19);
            this.labelSoruNo.TabIndex = 10;
            this.labelSoruNo.Text = "0";
            // 
            // butonSonraki
            // 
            this.butonSonraki.Location = new System.Drawing.Point(498, 156);
            this.butonSonraki.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.butonSonraki.Name = "butonSonraki";
            this.butonSonraki.Size = new System.Drawing.Size(152, 44);
            this.butonSonraki.TabIndex = 11;
            this.butonSonraki.Text = "Sonraki";
            this.butonSonraki.UseVisualStyleBackColor = true;
            this.butonSonraki.Click += new System.EventHandler(this.butonSonraki_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(431, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(551, 259);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(687, 417);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butonSonraki);
            this.Controls.Add(this.labelSoruNo);
            this.Controls.Add(this.labelYanlis);
            this.Controls.Add(this.labelDogru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butonD);
            this.Controls.Add(this.butonC);
            this.Controls.Add(this.butonB);
            this.Controls.Add(this.butonA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button butonA;
        private System.Windows.Forms.Button butonB;
        private System.Windows.Forms.Button butonC;
        private System.Windows.Forms.Button butonD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDogru;
        private System.Windows.Forms.Label labelYanlis;
        private System.Windows.Forms.Label labelSoruNo;
        private System.Windows.Forms.Button butonSonraki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

