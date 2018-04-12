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
    public partial class YoneticiGenelPenceresi : Form
    {
        public YoneticiGenelPenceresi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SatisLogPaneli.Visible = false;
            Urun_ListelePaneli.Visible = false;
            UrunEklePaneli.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SatisLogPaneli.Visible = true;
            Urun_ListelePaneli.Visible = false;
            UrunEklePaneli.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SatisLogPaneli.Visible = false;
            Urun_ListelePaneli.Visible = true;
            UrunEklePaneli.Visible = false;
        }
    }
}
