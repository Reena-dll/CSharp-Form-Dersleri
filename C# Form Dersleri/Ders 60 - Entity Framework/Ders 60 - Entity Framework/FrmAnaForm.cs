using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_60___Entity_Framework
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUrun fr = new FrmUrun();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmİstatistik fr = new Frmİstatistik();
            fr.Show();
            this.Hide();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
