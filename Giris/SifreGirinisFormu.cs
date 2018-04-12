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
    public partial class SifreGirinisFormu : Form
    {
        public SifreGirinisFormu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "admin", password = "admin";
            string Market_kullanici = "sahibi",sifre = "sahibi";

            if (username == textBox1.Text && password == textBox2.Text)
            {
                YoneticiGenelPenceresi adminpaneli = new YoneticiGenelPenceresi();
                this.Hide();
                adminpaneli.ShowDialog();
            }
            else if(Market_kullanici == textBox1.Text && sifre == textBox2.Text)
            {
                mSahibiGenelPencere Sahibi = new mSahibiGenelPencere();
                this.Hide();
                Sahibi.ShowDialog();
            }
            else
                MessageBox.Show("Şifre veya Kullanıcı adı hatalı");
        }
    }
}
