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
    public partial class GirisSyafasi : Form
    {
        public GirisSyafasi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ISMAILPC;Initial Catalog=sigorta;Integrated Security=True");

        private void GirisSyafasi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sigortaDataSet8.bilgilerr' table. You can move, or remove it, as needed.
            this.bilgilerrTableAdapter.Fill(this.sigortaDataSet8.bilgilerr);
            this.markalarTableAdapter2.Fill(this.dtSigorta.Markalar);
            this.markalarTableAdapter2.Fill(this.dtSigorta.Markalar);
            this.mODELLERTableAdapter1.Fill(this.dtSigorta.MODELLER);

            MarkaCombo_SelectedIndexChanged(null, null);

            toolTip1.SetToolTip(kimlik_txtBox, "11 Karakterli Girin");
            
        }

        private void Kaydet_Button_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kayitekle=new SqlCommand("insert into Bilgilerr(Ad,Soyad,TelefonNumarasi,TC_Kimlik,Plaka,Sase_No,Baslangic,Bitis_Tarihi,ModelID) values (@ad, @soyad, @telefon, @kimlik,@plaka, @sase, @baslagic, @bitis,@ModelID)",baglanti);
            kayitekle.Parameters.AddWithValue("@ad", ad_txtBox.Text);
            kayitekle.Parameters.AddWithValue("@soyad", soyad_txtBox.Text);
            kayitekle.Parameters.AddWithValue("@telefon", telefon_txtBox.Text);
            kayitekle.Parameters.AddWithValue("@kimlik", kimlik_txtBox.Text);
            kayitekle.Parameters.AddWithValue("@plaka", plaka_txtBox.Text);
            kayitekle.Parameters.AddWithValue("@sase", sase_txtBox.Text);
            kayitekle.Parameters.AddWithValue("@baslagic", baslangicTarih.Value.ToShortDateString());
            kayitekle.Parameters.AddWithValue("@bitis", BitisTarihi.Value.ToShortDateString());
            kayitekle.Parameters.AddWithValue("@ModelID",modelComboBox.SelectedValue);

            kayitekle.ExecuteNonQuery();

            MessageBox.Show("Kayıt Başarılı Kaydedilmiştir..");
            baglanti.Close();

        }

        private void Sil_Button_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("Delete From Bilgilerr where ID='" +dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'",baglanti);
            //where Ad=@ad", baglanti);
            sil.Parameters.AddWithValue("@ad", ad_txtBox.Text);
            sil.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi :( " );
             baglanti.Close();

        }

        private void Goster_Button_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select* From Bilgilerr", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            SqlCommand komut = new SqlCommand("Select b.*, MDL.ModelAdi, M.MarkaAdi from bilgilerr as b left outer join Modeller as mdl ON mdl.ModelID = b.ModelID left outer join Markalar as m ON m.MarkaID = mdl.MarkaID", baglanti);
            SqlDataAdapter daa = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            daa.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Guncelle_Button_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update bilgilerr set Ad=@ad,Soyad=@soyad,TelefonNumarasi=@telno,TC_Kimlik=@tc,Plaka=@plaka,Sase_No=@sase,Baslagic=@baslangic,Bitis_Tarihi=@bitis where ID=@id", baglanti);
            guncelle.Parameters.AddWithValue("@ad", ad_txtBox.Text);
            guncelle.Parameters.AddWithValue("@soyad", soyad_txtBox.Text);
            guncelle.Parameters.AddWithValue("@telno", telefon_txtBox.Text);
            guncelle.Parameters.AddWithValue("@tc", kimlik_txtBox.Text);
            guncelle.Parameters.AddWithValue("@baslangic", baslangicTarih.Value.ToShortDateString());
            guncelle.Parameters.AddWithValue("@plaka", plaka_txtBox.Text);
            guncelle.Parameters.AddWithValue("@sase", sase_txtBox.Text);
            guncelle.Parameters.AddWithValue("@bitis", BitisTarihi.Value.ToShortDateString());

            guncelle.ExecuteNonQuery();
            baglanti.Close();

        }

        private void Temizle_Button_Click(object sender, EventArgs e)
        {
            ad_txtBox.Clear();
            soyad_txtBox.Clear();
            telefon_txtBox.Clear();
            kimlik_txtBox.Clear();
            plaka_txtBox.Clear();
            sase_txtBox.Clear();
        }

        private void Ara_Button_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Bilgilerr  where Ad='" + ara_txtBox.Text + "'", baglanti);
            DataSet ds=new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            SqlDataAdapter da1 = new SqlDataAdapter("select * from Bilgilerr  where Soyad='" + ara_txtBox.Text + "'", baglanti);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];

            SqlDataAdapter da2 = new SqlDataAdapter("select * from Bilgilerr  where TelefonNumarasi='" + ara_txtBox.Text + "'", baglanti);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            dataGridView1.DataSource = ds2.Tables[0];

            SqlDataAdapter da3 = new SqlDataAdapter("select * from Bilgilerr  where TC_Kimlik='" + ara_txtBox.Text + "'", baglanti);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            dataGridView1.DataSource = ds3.Tables[0];

            SqlDataAdapter da4 = new SqlDataAdapter("select * from Bilgilerr  where Plaka='" + ara_txtBox.Text + "'", baglanti);
            DataSet ds4 = new DataSet();
            da4.Fill(ds4);
            dataGridView1.DataSource = ds4.Tables[0];










             //where Ad= '" + ara_txtBox.Text + "'" arama kodu 
            //select * from Bilgilerr where Ad='"+ ara_txtBox.Text + "'"
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Formlar arası geçiş //

            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            string Ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string Soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            string  TelefonNumarasi= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            string  TC_Kimlik= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            string  Plaka= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            string  Sase_No= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            string  Baslagic= dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            string  Bitis_Tarihi= dataGridView1.Rows[secilen].Cells[8].Value.ToString();


           ad_txtBox.Text=Ad;
           soyad_txtBox.Text=Soyad;
           telefon_txtBox.Text=TelefonNumarasi;
           kimlik_txtBox.Text=TC_Kimlik;
           //baslangic_txtBox.Text=Baslagic;
           plaka_txtBox.Text=Plaka;
           sase_txtBox.Text=Sase_No;
           //bitis_txtBox.Text = Bitis_Tarihi;


        }


        private void ad_txtBox_TextChanged(object sender, EventArgs e)
        {
            if (ad_txtBox.Text == "")
            {
                errorProvider1.SetError(ad_txtBox, "Bu alan boş geçilemez");
            }  
        }


        private void kimlik_txtBox_TextChanged(object sender, EventArgs e)
        {
            if (kimlik_txtBox.Text == "")
            {
                errorProvider1.SetError(kimlik_txtBox, "Bu alan boş geçilemez");
            } 
        }

        private void MarkaEkleBtn_Click(object sender, EventArgs e)
        {
            MarkaEkle mrkekle = new MarkaEkle();
            mrkekle.Show();
            this.Hide();
        }

        private void ModelEkleBtn_Click(object sender, EventArgs e)
        {
            ModelEkle mdlekle = new ModelEkle();
            mdlekle.Show();
            this.Hide();
        }

        private void tsModellerToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mODELLERTableAdapter1.tsModeller(this.dtSigorta.MODELLER, new System.Nullable<int>(((int)(System.Convert.ChangeType(markaIDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void modellerToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mODELLERTableAdapter1.Modeller(this.dtSigorta.MODELLER, new System.Nullable<int>(((int)(System.Convert.ChangeType(markaIDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void modeller1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mODELLERTableAdapter1.Modeller1(this.dtSigorta.MODELLER, new System.Nullable<int>(((int)(System.Convert.ChangeType(markaIDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void MarkaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                this.mODELLERTableAdapter1.Modeller1(this.dtSigorta.MODELLER, new System.Nullable<int>(Convert.ToInt32(MarkaCombo.SelectedValue)));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ara_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Ara_Button.PerformClick();
            }
        }






        //private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.mODELLERTableAdapter.FillBy2(this.sigortaDataSet3.MODELLER);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        //private void fillByToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.mODELLERTableAdapter1.FillBy(this.sigortaDataSet7.MODELLER, new System.Nullable<int>(((int)(System.Convert.ChangeType(markaIDToolStripTextBox.Text, typeof(int))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        //private void fillByToolStripButton1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.markalarTableAdapter.FillBy(this.sigortaDataSet1.Markalar, ((int)(System.Convert.ChangeType(markaIDToolStripTextBox1.Text, typeof(int)))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        //private void fillBy2ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{

        //}

        //private void fillByToolStripButton1_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.mODELLERTableAdapter.FillBy(this.sigortaDataSet3.MODELLER);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}





    }
}
