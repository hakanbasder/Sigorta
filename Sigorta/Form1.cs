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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ISMAILPC;Initial Catalog=sigorta;Integrated Security=True");
       
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * From Kullanici_Giris where KullaniciAdi='"+ textBox1.Text +"' and Sifre='"+textBox2.Text +"'",baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                GirisSyafasi grs  = new GirisSyafasi();
                grs.Show();
                this.Hide();
              
            }

            else
            {
                MessageBox.Show("Kullancı Adı Veya Şifreniz Hatalıdır");
                textBox1.Clear();
                textBox2.Clear();
               
            }
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kayit_Ol kytol = new Kayit_Ol();
            kytol.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sd = new SqlDataAdapter("delete from Kullanici_Giris where KullaniciAdi='" + textBox3.Text + "'", baglanti);
            DataSet ds = new DataSet();
            sd.Fill(ds);
            textBox3.Clear();

            if (textBox3.Text=="")
            {
                MessageBox.Show("Kaydınız Silindi");
            }

            else
            {
                MessageBox.Show("Kayıt Bulunamadı");
            }


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button1.PerformClick();

            }
        }
    }
}
