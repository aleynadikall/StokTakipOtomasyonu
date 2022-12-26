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
    public partial class frmSatisListele : Form
    {
        public frmSatisListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ME3MUPN;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void SatisListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];
            baglanti.Close();
        }

        private void frmSatisListele_Load(object sender, EventArgs e)
        {
            SatisListele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into fatura(faturano, ad, soyad, urunadi, adet, toplam) values(@faturano, @ad, @soyad, @urunadi, @adet, @toplam)", baglanti);
            komut.Parameters.AddWithValue("@faturano", textBox1.Text);
            komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@urunadi", textBox4.Text);
            komut.Parameters.AddWithValue("@adet", int.Parse(textBox5.Text));
            komut.Parameters.AddWithValue("@toplam", double.Parse(textBox6.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();

            frmFatura gecis = new frmFatura();
            gecis.ShowDialog();

           
        }
    }
}
