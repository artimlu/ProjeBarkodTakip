
namespace is_takibi
{
    partial class SatinAlma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatinAlma));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yenile = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.s_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_ac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.TextBox();
            this.is_ekle = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DepoGit = new System.Windows.Forms.Button();
            this.satinAl = new System.Windows.Forms.Button();
            this.muhasebe = new System.Windows.Forms.Button();
            this.kullanici = new System.Windows.Forms.Button();
            this.istasyon = new System.Windows.Forms.Button();
            this.musteriler = new System.Windows.Forms.Button();
            this.isler = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.yenile);
            this.groupBox1.Controls.Add(this.ara);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.guncelle);
            this.groupBox1.Controls.Add(this.sil);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(16, 134);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1124, 665);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Düzenleme Paneli";
            // 
            // yenile
            // 
            this.yenile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.yenile.ForeColor = System.Drawing.Color.Crimson;
            this.yenile.Location = new System.Drawing.Point(949, 30);
            this.yenile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(161, 27);
            this.yenile.TabIndex = 10;
            this.yenile.Text = "LİSTEYİ YENİLE";
            this.yenile.UseVisualStyleBackColor = false;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(317, 27);
            this.ara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(92, 27);
            this.ara.TabIndex = 8;
            this.ara.Text = "ARA";
            this.ara.UseVisualStyleBackColor = true;
            this.ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Ürün Adını yazınız...";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.SystemColors.ControlText;
            this.guncelle.ForeColor = System.Drawing.Color.Aquamarine;
            this.guncelle.Location = new System.Drawing.Point(860, 608);
            this.guncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(251, 41);
            this.guncelle.TabIndex = 6;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.SystemColors.ControlText;
            this.sil.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.sil.Location = new System.Drawing.Point(23, 608);
            this.sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(251, 41);
            this.sil.TabIndex = 5;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.s_id,
            this.s_urun,
            this.s_firma,
            this.s_fiyat,
            this.s_ac,
            this.s_tarih});
            this.dataGridView2.Location = new System.Drawing.Point(23, 64);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 49;
            this.dataGridView2.Size = new System.Drawing.Size(1088, 521);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView2_DataBindingComplete);
            // 
            // s_id
            // 
            this.s_id.DataPropertyName = "s_id";
            this.s_id.HeaderText = "Ürün No";
            this.s_id.MinimumWidth = 6;
            this.s_id.Name = "s_id";
            this.s_id.Width = 120;
            // 
            // s_urun
            // 
            this.s_urun.DataPropertyName = "s_urun";
            this.s_urun.HeaderText = "Ürün Adı";
            this.s_urun.MinimumWidth = 6;
            this.s_urun.Name = "s_urun";
            this.s_urun.Width = 120;
            // 
            // s_firma
            // 
            this.s_firma.DataPropertyName = "s_firma";
            this.s_firma.HeaderText = "Firma Adı";
            this.s_firma.MinimumWidth = 6;
            this.s_firma.Name = "s_firma";
            this.s_firma.Width = 120;
            // 
            // s_fiyat
            // 
            this.s_fiyat.DataPropertyName = "s_fiyat";
            this.s_fiyat.HeaderText = "Fiyat";
            this.s_fiyat.MinimumWidth = 6;
            this.s_fiyat.Name = "s_fiyat";
            this.s_fiyat.Width = 120;
            // 
            // s_ac
            // 
            this.s_ac.DataPropertyName = "s_ac";
            this.s_ac.HeaderText = "Açıklama";
            this.s_ac.MinimumWidth = 6;
            this.s_ac.Name = "s_ac";
            this.s_ac.Width = 120;
            // 
            // s_tarih
            // 
            this.s_tarih.DataPropertyName = "s_tarih";
            this.s_tarih.HeaderText = "Tarih";
            this.s_tarih.MinimumWidth = 6;
            this.s_tarih.Name = "s_tarih";
            this.s_tarih.Width = 120;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.mail);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.adres);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tel);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.isim);
            this.groupBox3.Controls.Add(this.is_ekle);
            this.groupBox3.Location = new System.Drawing.Point(1187, 134);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(385, 591);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni Ürün Ekleme Paneli";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(35, 217);
            this.mail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(317, 22);
            this.mail.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Satın Alındığı Fiyat :";
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(33, 283);
            this.adres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(313, 222);
            this.adres.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tam Açıklama :";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(35, 150);
            this.tel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(317, 22);
            this.tel.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Satın Alındığı Firma Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Satın Alınan Ürün Adı : ";
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(35, 81);
            this.isim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(317, 22);
            this.isim.TabIndex = 2;
            // 
            // is_ekle
            // 
            this.is_ekle.BackColor = System.Drawing.SystemColors.ControlText;
            this.is_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.is_ekle.ForeColor = System.Drawing.Color.Coral;
            this.is_ekle.Location = new System.Drawing.Point(35, 530);
            this.is_ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.is_ekle.Name = "is_ekle";
            this.is_ekle.Size = new System.Drawing.Size(316, 41);
            this.is_ekle.TabIndex = 1;
            this.is_ekle.Text = "SATIN ALMA EKLE";
            this.is_ekle.UseVisualStyleBackColor = false;
            this.is_ekle.Click += new System.EventHandler(this.is_ekle_Click);
            // 
            // sifre
            // 
            this.sifre.BackColor = System.Drawing.Color.Crimson;
            this.sifre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sifre.Location = new System.Drawing.Point(1195, 74);
            this.sifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(108, 31);
            this.sifre.TabIndex = 27;
            this.sifre.Text = "Şifre Değiştir";
            this.sifre.UseVisualStyleBackColor = false;
            this.sifre.Click += new System.EventHandler(this.sifre_Click_1);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Crimson;
            this.cikis.ForeColor = System.Drawing.Color.Cornsilk;
            this.cikis.Location = new System.Drawing.Point(1320, 74);
            this.cikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(129, 31);
            this.cikis.TabIndex = 30;
            this.cikis.Text = "Güvenli Çıkış";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(1313, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "isim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1189, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Hoşgeldiniz Sayın ";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(1197, 766);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(365, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "FolBar  © 2023. Tüm Hakları saklıdır.";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.DepoGit);
            this.groupBox5.Controls.Add(this.satinAl);
            this.groupBox5.Controls.Add(this.muhasebe);
            this.groupBox5.Controls.Add(this.kullanici);
            this.groupBox5.Controls.Add(this.istasyon);
            this.groupBox5.Controls.Add(this.musteriler);
            this.groupBox5.Controls.Add(this.isler);
            this.groupBox5.Location = new System.Drawing.Point(16, 17);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(1124, 87);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Menü";
            // 
            // DepoGit
            // 
            this.DepoGit.BackColor = System.Drawing.Color.Black;
            this.DepoGit.ForeColor = System.Drawing.Color.White;
            this.DepoGit.Location = new System.Drawing.Point(968, 26);
            this.DepoGit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DepoGit.Name = "DepoGit";
            this.DepoGit.Size = new System.Drawing.Size(143, 38);
            this.DepoGit.TabIndex = 6;
            this.DepoGit.Text = "Depo Paneli";
            this.DepoGit.UseVisualStyleBackColor = false;
            this.DepoGit.Click += new System.EventHandler(this.DepoGit_Click);
            // 
            // satinAl
            // 
            this.satinAl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.satinAl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.satinAl.Location = new System.Drawing.Point(811, 26);
            this.satinAl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.satinAl.Name = "satinAl";
            this.satinAl.Size = new System.Drawing.Size(143, 38);
            this.satinAl.TabIndex = 7;
            this.satinAl.Text = "Satın Alma Paneli";
            this.satinAl.UseVisualStyleBackColor = false;
            this.satinAl.Click += new System.EventHandler(this.satinAl_Click);
            // 
            // muhasebe
            // 
            this.muhasebe.BackColor = System.Drawing.Color.Black;
            this.muhasebe.ForeColor = System.Drawing.Color.White;
            this.muhasebe.Location = new System.Drawing.Point(653, 26);
            this.muhasebe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.muhasebe.Name = "muhasebe";
            this.muhasebe.Size = new System.Drawing.Size(143, 38);
            this.muhasebe.TabIndex = 4;
            this.muhasebe.Text = "Muhasebe Paneli";
            this.muhasebe.UseVisualStyleBackColor = false;
            this.muhasebe.Click += new System.EventHandler(this.muhasebe_Click);
            // 
            // kullanici
            // 
            this.kullanici.BackColor = System.Drawing.SystemColors.ControlText;
            this.kullanici.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kullanici.Location = new System.Drawing.Point(493, 26);
            this.kullanici.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullanici.Name = "kullanici";
            this.kullanici.Size = new System.Drawing.Size(143, 38);
            this.kullanici.TabIndex = 3;
            this.kullanici.Text = "Çalışan Paneli";
            this.kullanici.UseVisualStyleBackColor = false;
            this.kullanici.Click += new System.EventHandler(this.kullanici_Click);
            // 
            // istasyon
            // 
            this.istasyon.BackColor = System.Drawing.SystemColors.ControlText;
            this.istasyon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.istasyon.Location = new System.Drawing.Point(332, 26);
            this.istasyon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.istasyon.Name = "istasyon";
            this.istasyon.Size = new System.Drawing.Size(143, 38);
            this.istasyon.TabIndex = 2;
            this.istasyon.Text = "İstasyon Paneli";
            this.istasyon.UseVisualStyleBackColor = false;
            this.istasyon.Click += new System.EventHandler(this.istasyon_Click);
            // 
            // musteriler
            // 
            this.musteriler.BackColor = System.Drawing.SystemColors.ControlText;
            this.musteriler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.musteriler.Location = new System.Drawing.Point(172, 26);
            this.musteriler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musteriler.Name = "musteriler";
            this.musteriler.Size = new System.Drawing.Size(143, 38);
            this.musteriler.TabIndex = 1;
            this.musteriler.Text = "Müşteri Paneli";
            this.musteriler.UseVisualStyleBackColor = false;
            this.musteriler.Click += new System.EventHandler(this.musteriler_Click);
            // 
            // isler
            // 
            this.isler.BackColor = System.Drawing.Color.Black;
            this.isler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.isler.Location = new System.Drawing.Point(15, 26);
            this.isler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isler.Name = "isler";
            this.isler.Size = new System.Drawing.Size(143, 38);
            this.isler.TabIndex = 0;
            this.isler.Text = "İş Paneli";
            this.isler.UseVisualStyleBackColor = false;
            this.isler.Click += new System.EventHandler(this.isler_Click_1);
            // 
            // SatinAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SatinAlma";
            this.Text = "Satın Alma Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SatinAlma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.Button is_ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sifre;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_ac;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_tarih;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button DepoGit;
        private System.Windows.Forms.Button satinAl;
        private System.Windows.Forms.Button muhasebe;
        private System.Windows.Forms.Button kullanici;
        private System.Windows.Forms.Button istasyon;
        private System.Windows.Forms.Button musteriler;
        private System.Windows.Forms.Button isler;
    }
}