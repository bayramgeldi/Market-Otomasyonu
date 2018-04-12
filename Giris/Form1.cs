using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giris
{
    public partial class Form1 : Form
    {
        mSahibiGenelPencere Sahibi = new mSahibiGenelPencere();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SifreGirinisFormu Sahibi = new SifreGirinisFormu();
            this.Hide();
            Sahibi.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SifreGirinisFormu Sahibi = new SifreGirinisFormu();
            this.Hide();
            Sahibi.ShowDialog();
        }
    }
}
