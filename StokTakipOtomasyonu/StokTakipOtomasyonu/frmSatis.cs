using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyonu
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
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

        }

        private void btnSatisLis_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunEk_Click(object sender, EventArgs e)
        {

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
    }
}
