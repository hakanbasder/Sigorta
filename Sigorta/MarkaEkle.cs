using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sigorta
{
    public partial class MarkaEkle : Form
    {
        public MarkaEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ISMAILPC;Initial Catalog=sigorta;Integrated Security=True");
       
        private void MarkaEkle_Load(object sender, EventArgs e)
        {

        }

        private void kydtButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kayitekle = new SqlCommand("insert into Markalar(MarkaAdi) values( @MarkaAdi)", baglanti);
            kayitekle.Parameters.AddWithValue("@MarkaAdi", mrkaekle_txtBox.Text);

            kayitekle.ExecuteNonQuery();

            MessageBox.Show("Kayıt Başarılı Kaydedilmiştir..");

            GirisSyafasi grs = new GirisSyafasi();
            grs.Show();
            this.Hide();

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GirisSyafasi grs = new GirisSyafasi();
            grs.Show();
            this.Hide();
        }
    }
}
