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

namespace StokTakipOtomasyonu
{
    public partial class frmMusteriListeleme : Form
    {
        public frmMusteriListeleme()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ME3MUPN;Initial Catalog=StokTakip;Integrated Security=True");
        
        //Kayıtları geçici olarak tutmak için bir dataset oluştruduk.
        DataSet dataset = new DataSet();

        private void frmMusteriListeleme_Load(object sender, EventArgs e)
        {
            Kayıt();
        }

        private void Kayıt()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from musteri", baglanti);
            adtr.Fill(dataset, "musteri");
            dataGridView1.DataSource = dataset.Tables["musteri"];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTC.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update musteri set adsoyad = @adsoyad, telefon = @telefon, adres = @adres, email = @email where tc = @tc", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTC.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataset.Tables["musteri"].Clear();
            Kayıt();
            MessageBox.Show("Müşteri Kaydı Güncellendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }


        }

        private void btnSilme_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from musteri where tc = '"+dataGridView1.CurrentRow.Cells["tc"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataset.Tables["musteri"].Clear();
            Kayıt();
            MessageBox.Show("Kayıt Silindi.");
        }

        private void txtTCAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from musteri where tc like '%"+ txtTCAra.Text+"%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
