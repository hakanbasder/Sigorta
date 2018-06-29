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
    public partial class Kayit_Ol : Form
    {
        public Kayit_Ol()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ISMAILPC;Initial Catalog=sigorta;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kayitekle = new SqlCommand("insert into Kullanici_Giris(KullaniciAdi,Sifre) values (@k1,@s1)", baglanti);
            kayitekle.Parameters.AddWithValue("@k1", textBox2.Text);
            kayitekle.Parameters.AddWithValue("@s1", textBox1.Text);

            kayitekle.ExecuteNonQuery();
            baglanti.Close();

            textBox1.Clear();
            textBox2.Clear();

            MessageBox.Show("Kayıt Başarılı");

            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();

        }
    }
}
