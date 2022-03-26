using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_51___Dinamik_Araçlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();

            Point btnkonum = new Point(20,10);

            btn.Location = btnkonum;
            btn.Name = "Button2";
            btn.Text = "Tıkla";
            btn.BackColor = Color.Green;
            this.Controls.Add(btn);
            btn.Width = 75;
            btn.Height = 100;

            Label lbl = new Label();
            Point lblkonum = new Point(250, 25);
            lbl.Location = lblkonum;
            lbl.Name = "Label2";
            lbl.Text = "Merhaba";
            lbl.BackColor = Color.Yellow;
            lbl.AutoSize = true;
            this.Controls.Add(lbl);


           


            for (int i = 1; i < 10; i++)
            {
                TextBox txt = new TextBox();
                Point txtkonum = new Point(350, i * 32);
                txt.Location = txtkonum;
                txt.Name = "Text" + i;
                txt.Text = i.ToString();
                this.Controls.Add(txt);
            }

        }
    }
}
