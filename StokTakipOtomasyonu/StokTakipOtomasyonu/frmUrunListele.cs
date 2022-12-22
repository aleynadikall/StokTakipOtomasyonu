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
    public partial class frmUrunListele : Form
    {
        public frmUrunListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ME3MUPN;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void KategoriGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoriBilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }

            baglanti.Close();
        }

        private void frmUrunListele_Load(object sender, EventArgs e)
        {
            UrunListele();
            KategoriGetir();
        }

        private void UrunListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urun", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            barkodNoTxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            kategoriTxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            markaTxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            urunAdiTxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            miktariTxt.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            alisFiyatiTxt.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            satisFiyatiTxt.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set urunadi = @urunadi, miktari = @miktari, alisfiyati = @alisfiyati, satisfiyati = @satisfiyati where barkodno = @barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", barkodNoTxt.Text);
            komut.Parameters.AddWithValue("@urunadi", urunAdiTxt.Text);
            komut.Parameters.AddWithValue("@miktari", int.Parse(miktariTxt.Text));
            komut.Parameters.AddWithValue("@alisfiyati", double.Parse(alisFiyatiTxt.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(satisFiyatiTxt.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            UrunListele();
            MessageBox.Show("Güncelleme Yapıldı.");

            foreach(Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            if(barkodNoTxt.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update urun set kategori = @kategori, marka = @marka where barkodno = @barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", barkodNoTxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme Yapıldı.");
                daset.Tables["urun"].Clear();
                UrunListele();
            }
            else
            {
                MessageBox.Show("BarkodNo seçili değil.");
            }
           

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Alttaki işlemler yapılırken comboboxımızın içerisi temizlensin diyoruz.
            comboMarka.Items.Clear();
            comboMarka.Text = "";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from markaBilgileri where kategori = '" + comboKategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where barkodno = '" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            UrunListele();
            MessageBox.Show("Kayıt Silindi.");
        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            //geçici bir tablo tanımlıyoruz.
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urun where barkodno like '%" + txtBarkodAra.Text + "%'", baglanti);
            //tabloyu adtr ye atıyoruz.
            adtr.Fill(tablo);
            //dataGridViewda tabloyu göstermek için aşitleme yapıyoruz..
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
