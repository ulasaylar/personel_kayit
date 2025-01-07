using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelKayit
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.DefaultConnection;
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici where Kullaniciadi=@p1 and Sifre=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1", Txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("@p2", Txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Ya Da Şifre");
            }
            baglanti.Close();
        }
    }
}
