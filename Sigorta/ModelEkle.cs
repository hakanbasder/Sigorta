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
    public partial class ModelEkle : Form
    {
        public ModelEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ISMAILPC;Initial Catalog=sigorta;Integrated Security=True");

        private void ModelEkle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sigortaDataSet6.Markalar' table. You can move, or remove it, as needed.
            this.markalarTableAdapter1.Fill(this.sigortaDataSet6.Markalar);
            // TODO: This line of code loads data into the 'sigortaDataSet5.Markalar' table. You can move, or remove it, as needed.
            this.markalarTableAdapter.Fill(this.sigortaDataSet5.Markalar);

        }

        private void MdlEkle_Button_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kayitekle = new SqlCommand("insert into MODELLER (ModelAdi, MarkaID) values( @ModelAdi, @MarkaID)", baglanti);
            kayitekle.Parameters.AddWithValue("@ModelAdi", MdlEkle_txtBox.Text);
            kayitekle.Parameters.AddWithValue("@MarkaID", comboBox1.SelectedValue);
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
