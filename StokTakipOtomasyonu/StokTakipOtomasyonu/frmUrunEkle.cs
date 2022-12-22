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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ME3MUPN;Initial Catalog=StokTakip;Integrated Security=True");

        //Aynı kaydın engellenmesi için tanımlanan değişken ve method.
        bool durum;

        private void barkodKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            // Kayıtlar okunduğu sürece:
            while (read.Read())
            {
                if (textBarkodNo.Text == read["barkodNo"].ToString() || textBarkodNo.Text == "" || textBarkodNo.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktari = miktari + '"+int.Parse(miktariTxt.Text)+"' where barkodno = '"+barkodNoTxt.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            lblMiktari.Text = "";

            MessageBox.Show("Var Olan Ürüne Ekleme Yapıldı.");
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }

        private void KategoriGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoriBilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxKategori.Items.Add(read["kategori"].ToString());
            }

            baglanti.Close();
        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Alttaki işlemler yapılırken comboboxımızın içerisi temizlensin diyoruz.
            comboBoxMarka.Items.Clear();
            comboBoxMarka.Text = "";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from markaBilgileri where kategori = '"+comboBoxKategori.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
               comboBoxMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            barkodKontrol();
            if(durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into urun(barkodno, kategori, marka, urunadi, miktari, alisfiyati, satisfiyati, tarih) values(@barkodno, @kategori, @marka, @urunadi, @miktari, @alisfiyati, @satisfiyati, @tarih) ", baglanti);
                komut.Parameters.AddWithValue("@barkodno", textBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", comboBoxKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboBoxMarka.Text);
                komut.Parameters.AddWithValue("@urunadi", textUrunAdi.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(textMiktari.Text));
                komut.Parameters.AddWithValue("@alisfiyati", double.Parse(textAlisFiyati.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(textSatisFiyati.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Eklendi.");
            }
            else
            {
                MessageBox.Show("Böyle bir barkod numarası var.");
            }
            
            comboBoxMarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
                if(item is ComboBox)
                {
                    item.Text = "";
                }
            }


        }

        private void barkodNoTxt_TextChanged(object sender, EventArgs e)
        {
            if(barkodNoTxt.Text == "")
            {
                foreach(Control item in groupBox2.Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }


            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun where barkodno like '" + barkodNoTxt.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                kategoriTxt.Text = read["kategori"].ToString();
                markaTxt.Text = read["marka"].ToString();
                urunAdiTxt.Text = read["urunadi"].ToString();
                lblMiktari.Text = read["miktari"].ToString();
                alisFiyatiTxt.Text = read["alisfiyati"].ToString();
                satisFiyatiTxt.Text = read["satisfiyati"].ToString();
            

            }
            baglanti.Close();
        }
    }
}
