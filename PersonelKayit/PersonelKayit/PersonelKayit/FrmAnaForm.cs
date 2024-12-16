using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonelKayit
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        void temizle()
        {
            Txtid.Text = "";
            Txtad.Text = "";
            Txtsoyad.Text = "";
            Cmbsehir.Text = "";
            Mtxtmaas.Text = "";
            radioButton3.Checked = false;
            radioButton2.Checked = false;
            Txtmeslek.Text = "";
            Txtid.Focus();
        }

        private void Btnlistele_Click(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.DefaultConnection;
            SqlConnection baglanti = new SqlConnection(connectionString);
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabanıDataSet.Tbl_Personel);
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.DefaultConnection;
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (Perid,PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",baglanti);
            komut.Parameters.AddWithValue("@p1", Txtid.Text);
            komut.Parameters.AddWithValue("@p2", Txtad.Text);
            komut.Parameters.AddWithValue("@p3", Txtsoyad.Text);
            komut.Parameters.AddWithValue("@p4", Cmbsehir.Text);
            komut.Parameters.AddWithValue("@p5", Mtxtmaas.Text);
            komut.Parameters.AddWithValue("@p6", Txtmeslek.Text);
            komut.Parameters.AddWithValue("@p7", labeldurum.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) 
            {
                labeldurum.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                labeldurum.Text = "False";
            }
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = Properties.Settings.Default.DefaultConnection;
            SqlConnection baglanti = new SqlConnection(connectionString);

            int secilen= dataGridView1.SelectedCells[0].RowIndex;

            Txtid.Text=dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Txtad.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Txtsoyad.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Cmbsehir.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Mtxtmaas.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            labeldurum.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            Txtmeslek.Text= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void labeldurum_TextChanged(object sender, EventArgs e)
        {
            if(labeldurum.Text == "True")
            {
                radioButton3.Checked = true;
            }
            if(labeldurum.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.DefaultConnection;
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel where Perid=@k1",baglanti);
            komutsil.Parameters.AddWithValue("@k1",Txtid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void Btngüncelle_Click(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.DefaultConnection;
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 where Perid=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", Txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", Txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", Cmbsehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", Mtxtmaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", labeldurum.Text);
            komutguncelle.Parameters.AddWithValue("@a6", Txtmeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", Txtid.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi");
        }

        private void Btnistatistik_Click(object sender, EventArgs e)
        {
            Formistatistik fr = new Formistatistik();
            fr.Show();
        }

        private void Btngrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frg = new FrmGrafikler();
            frg.Show();
        }
    }
}
