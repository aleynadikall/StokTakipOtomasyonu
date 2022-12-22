
namespace StokTakipOtomasyonu
{
    partial class frmUrunListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.satisFiyatiTxt = new System.Windows.Forms.TextBox();
            this.alisFiyatiTxt = new System.Windows.Forms.TextBox();
            this.miktariTxt = new System.Windows.Forms.TextBox();
            this.urunAdiTxt = new System.Windows.Forms.TextBox();
            this.markaTxt = new System.Windows.Forms.TextBox();
            this.kategoriTxt = new System.Windows.Forms.TextBox();
            this.barkodNoTxt = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtBarkodAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMarkaGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(245, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(479, 321);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(130, 362);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 34);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Satış Fiyatı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Alış Fiyatı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Miktarı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Ürün Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Marka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Kategori";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Barkod No";
            // 
            // satisFiyatiTxt
            // 
            this.satisFiyatiTxt.Location = new System.Drawing.Point(113, 312);
            this.satisFiyatiTxt.Name = "satisFiyatiTxt";
            this.satisFiyatiTxt.Size = new System.Drawing.Size(100, 22);
            this.satisFiyatiTxt.TabIndex = 22;
            // 
            // alisFiyatiTxt
            // 
            this.alisFiyatiTxt.Location = new System.Drawing.Point(113, 271);
            this.alisFiyatiTxt.Name = "alisFiyatiTxt";
            this.alisFiyatiTxt.Size = new System.Drawing.Size(100, 22);
            this.alisFiyatiTxt.TabIndex = 21;
            // 
            // miktariTxt
            // 
            this.miktariTxt.Location = new System.Drawing.Point(113, 230);
            this.miktariTxt.Name = "miktariTxt";
            this.miktariTxt.Size = new System.Drawing.Size(100, 22);
            this.miktariTxt.TabIndex = 20;
            // 
            // urunAdiTxt
            // 
            this.urunAdiTxt.Location = new System.Drawing.Point(113, 189);
            this.urunAdiTxt.Name = "urunAdiTxt";
            this.urunAdiTxt.Size = new System.Drawing.Size(100, 22);
            this.urunAdiTxt.TabIndex = 19;
            // 
            // markaTxt
            // 
            this.markaTxt.Location = new System.Drawing.Point(113, 148);
            this.markaTxt.Name = "markaTxt";
            this.markaTxt.ReadOnly = true;
            this.markaTxt.Size = new System.Drawing.Size(100, 22);
            this.markaTxt.TabIndex = 17;
            // 
            // kategoriTxt
            // 
            this.kategoriTxt.Location = new System.Drawing.Point(113, 107);
            this.kategoriTxt.Name = "kategoriTxt";
            this.kategoriTxt.ReadOnly = true;
            this.kategoriTxt.Size = new System.Drawing.Size(100, 22);
            this.kategoriTxt.TabIndex = 16;
            // 
            // barkodNoTxt
            // 
            this.barkodNoTxt.Location = new System.Drawing.Point(113, 66);
            this.barkodNoTxt.Name = "barkodNoTxt";
            this.barkodNoTxt.Size = new System.Drawing.Size(100, 22);
            this.barkodNoTxt.TabIndex = 15;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(752, 95);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 34);
            this.btnSil.TabIndex = 31;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtBarkodAra
            // 
            this.txtBarkodAra.Location = new System.Drawing.Point(500, 52);
            this.txtBarkodAra.Name = "txtBarkodAra";
            this.txtBarkodAra.Size = new System.Drawing.Size(224, 22);
            this.txtBarkodAra.TabIndex = 32;
            this.txtBarkodAra.TextChanged += new System.EventHandler(this.txtBarkodAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Barkod Numarasına Göre Ara";
            // 
            // comboKategori
            // 
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(334, 448);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(146, 24);
            this.comboKategori.TabIndex = 34;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboKategori_SelectedIndexChanged);
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(334, 488);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(146, 24);
            this.comboMarka.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Kategori";
            // 
            // btnMarkaGuncelle
            // 
            this.btnMarkaGuncelle.Location = new System.Drawing.Point(512, 451);
            this.btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            this.btnMarkaGuncelle.Size = new System.Drawing.Size(179, 56);
            this.btnMarkaGuncelle.TabIndex = 38;
            this.btnMarkaGuncelle.Text = "Marka/Kategori Güncelle";
            this.btnMarkaGuncelle.UseVisualStyleBackColor = true;
            this.btnMarkaGuncelle.Click += new System.EventHandler(this.btnMarkaGuncelle_Click);
            // 
            // frmUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(862, 602);
            this.Controls.Add(this.btnMarkaGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboMarka);
            this.Controls.Add(this.comboKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkodAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.satisFiyatiTxt);
            this.Controls.Add(this.alisFiyatiTxt);
            this.Controls.Add(this.miktariTxt);
            this.Controls.Add(this.urunAdiTxt);
            this.Controls.Add(this.markaTxt);
            this.Controls.Add(this.kategoriTxt);
            this.Controls.Add(this.barkodNoTxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUrunListele";
            this.Text = "Ürün Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmUrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox satisFiyatiTxt;
        private System.Windows.Forms.TextBox alisFiyatiTxt;
        private System.Windows.Forms.TextBox miktariTxt;
        private System.Windows.Forms.TextBox urunAdiTxt;
        private System.Windows.Forms.TextBox markaTxt;
        private System.Windows.Forms.TextBox kategoriTxt;
        private System.Windows.Forms.TextBox barkodNoTxt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtBarkodAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMarkaGuncelle;
    }
}