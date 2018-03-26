using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Market_Otomasyonu
{
    public partial class MarketLogin : Form
    {
       
        public MarketLogin()
        {
            InitializeComponent();
        }

        private void MarketLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             string connetionString = null;
            SqlConnection cnn ;
            connetionString = "Data Source=BAYRAMGELDI-PC\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=market-otomasyonu";
            cnn = new SqlConnection(connetionString);
            string query = "Select * from marketsahibi Where tcno = '" + tckimlikno.Text.Trim() + "' and telno = '" + telno.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                marketpaneli mrkpaneli = new marketpaneli();
                this.Hide();
                mrkpaneli.Show();


               

            }
            else
            {
                MessageBox.Show("Check your username and password");



            }


        }
    }
}
