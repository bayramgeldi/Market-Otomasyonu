using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Otomasyonu
{
    public partial class Bakkalite : Form
    {
        public Bakkalite()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin admin = new AdminLogin();
            admin.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarketLogin market = new MarketLogin();
            this.Hide();
            market.ShowDialog();
        }

        private void aboutbtn_click(object sender, EventArgs e)
        {
            hakkinda about = new hakkinda();
            this.Hide();
            about.ShowDialog();
        }
    }
}
