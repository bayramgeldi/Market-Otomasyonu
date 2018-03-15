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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "admin"; string password = "admin";
            
            Form2 adminpanel = new Form2();


            if (username == textBox1.Text && password == textBox2.Text)
            {
                adminpanel.ShowDialog();
            }
            else
                MessageBox.Show("Şifre veya Kullanıcı adı hatalı");
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
