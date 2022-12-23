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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ME3MUPN;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void SepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepettt", baglanti);
            adtr.Fill(daset, "sepettt");
            dataGridView1.DataSource = daset.Tables["sepettt"];

            //ilk üç satırı gözlemlemek için
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmUrunListele listele = new frmUrunListele();
            listele.ShowDialog();
        }

        private void btnSatisLis_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunEk_Click(object sender, EventArgs e)
        {
            frmUrunEkle ekle = new frmUrunEkle();
            ekle.ShowDialog();
        }

        private void btnMusEkle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.Show();
        }

        private void btnMusLis_Click(object sender, EventArgs e)
        {
            frmMusteriListeleme listele = new frmMusteriListeleme();
            listele.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            SepetListele();
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if(txtTC.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from musteri where tc like '"+txtTC.Text+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();

            }
            baglanti.Close();
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
           
            Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun where barkodno like '" + txtBarkod.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtUrunAdi.Text = read["urunadi"].ToString();
                txtSatisFiyati.Text = read["satisfiyati"].ToString();

            }
            baglanti.Close();
        }

        private void Temizle()
        {
            if (txtBarkod.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMiktar)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }

        //aynı numaralı barkod ürün varsa 
        bool durum;
        private void BarkodKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from sepettt", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                if (txtBarkod.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            BarkodKontrol();
            if(durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepettt(tc, adsoyad, telefon, barkodno, urunadi, miktari, satisfiyati, toplamfiyati, tarih) values(@tc, @adsoyad, @telefon,@barkodno, @urunadi, @miktari, @satisfiyati, @toplamfiyati, @tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", txtBarkod.Text);
                komut.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktar.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatisFiyati.Text));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(txtToplamFiyat.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update sepettt set miktari = miktari + '"+int.Parse(txtMiktar.Text)+"' where barkodno = '" + txtBarkod.Text + "'", baglanti);
                komut2.ExecuteNonQuery();

                SqlCommand komut3 = new SqlCommand("update sepettt set toplamfiyati = miktari * satisfiyati where barkodno = '"+txtBarkod.Text+"'", baglanti);
                komut3.ExecuteNonQuery();

                baglanti.Close();
            }
            txtMiktar.Text = "1";
            daset.Tables["sepettt"].Clear();
            SepetListele();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtMiktar)
                    {
                        item.Text = "";
                    }
                    else
                    {
                        txtMiktar.Text = "1";
                    }
                }
            }
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatisFiyati.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void txtSatisFiyati_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatisFiyati.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepettt where barkodno = '" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün sepetten çıkarılmıştır.");
            daset.Tables["sepettt"].Clear();
            SepetListele();
        }

        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepettt", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satış İşlemi iptal edildi.");
            daset.Tables["sepettt"].Clear();
            SepetListele();
        }
    }
}
