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
    public partial class frmFatura : Form
    {
        public frmFatura()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ME3MUPN;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmFatura_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from fatura", baglanti);
            adtr.Fill(daset, "fatura");
            dataGridView1.DataSource = daset.Tables["fatura"];

            baglanti.Close();
        }
    }
}
