
namespace is_takibi
{
    partial class CalisanMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanMusteri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yenile = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.si_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.si_baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.si_bitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.si_bilgi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.si_urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.si_adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.si_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.siFiyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.siUrun = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.siAdet = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bitis = new System.Windows.Forms.DateTimePicker();
            this.baslangic = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.is_ekle = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(21, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1228, 782);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş Paneli";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // yenile
            // 
            this.yenile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.yenile.ForeColor = System.Drawing.Color.Crimson;
            this.yenile.Location = new System.Drawing.Point(1043, 27);
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
            this.textBox1.Text = "Arama...";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.SystemColors.ControlText;
            this.guncelle.ForeColor = System.Drawing.Color.Aquamarine;
            this.guncelle.Location = new System.Drawing.Point(953, 727);
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
            this.sil.Location = new System.Drawing.Point(23, 727);
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
            this.si_id,
            this.si_baslangic,
            this.si_bitis,
            this.si_bilgi,
            this.si_urun,
            this.si_adet,
            this.si_fiyat,
            this.m_isim,
            this.m_tel});
            this.dataGridView2.Location = new System.Drawing.Point(23, 64);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 49;
            this.dataGridView2.Size = new System.Drawing.Size(1181, 634);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView2_DataBindingComplete);
            // 
            // si_id
            // 
            this.si_id.DataPropertyName = "si_id";
            this.si_id.FillWeight = 50F;
            this.si_id.HeaderText = "Sipariş No";
            this.si_id.MinimumWidth = 6;
            this.si_id.Name = "si_id";
            this.si_id.Width = 50;
            // 
            // si_baslangic
            // 
            this.si_baslangic.DataPropertyName = "si_baslangic";
            this.si_baslangic.HeaderText = "Başlangıç Tarihi";
            this.si_baslangic.MinimumWidth = 6;
            this.si_baslangic.Name = "si_baslangic";
            this.si_baslangic.Width = 120;
            // 
            // si_bitis
            // 
            this.si_bitis.DataPropertyName = "si_bitis";
            this.si_bitis.HeaderText = "Teslim Tarihi";
            this.si_bitis.MinimumWidth = 6;
            this.si_bitis.Name = "si_bitis";
            this.si_bitis.Width = 120;
            // 
            // si_bilgi
            // 
            this.si_bilgi.DataPropertyName = "si_bilgi";
            this.si_bilgi.FillWeight = 300F;
            this.si_bilgi.HeaderText = "Bilgiler";
            this.si_bilgi.MinimumWidth = 6;
            this.si_bilgi.Name = "si_bilgi";
            this.si_bilgi.Width = 300;
            // 
            // si_urun
            // 
            this.si_urun.DataPropertyName = "si_urun";
            this.si_urun.HeaderText = "Ürün";
            this.si_urun.MinimumWidth = 6;
            this.si_urun.Name = "si_urun";
            this.si_urun.Width = 120;
            // 
            // si_adet
            // 
            this.si_adet.DataPropertyName = "si_adet";
            this.si_adet.HeaderText = "Adet";
            this.si_adet.MinimumWidth = 6;
            this.si_adet.Name = "si_adet";
            this.si_adet.Width = 120;
            // 
            // si_fiyat
            // 
            this.si_fiyat.DataPropertyName = "si_fiyat";
            this.si_fiyat.HeaderText = "Fiyat";
            this.si_fiyat.MinimumWidth = 6;
            this.si_fiyat.Name = "si_fiyat";
            this.si_fiyat.Width = 120;
            // 
            // m_isim
            // 
            this.m_isim.DataPropertyName = "m_isim";
            this.m_isim.HeaderText = "Firma Adı";
            this.m_isim.MinimumWidth = 6;
            this.m_isim.Name = "m_isim";
            this.m_isim.Width = 120;
            // 
            // m_tel
            // 
            this.m_tel.DataPropertyName = "m_tel";
            this.m_tel.HeaderText = "Firma Tel";
            this.m_tel.MinimumWidth = 6;
            this.m_tel.Name = "m_tel";
            this.m_tel.Width = 120;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.siFiyat);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.siUrun);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.siAdet);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.bitis);
            this.groupBox3.Controls.Add(this.baslangic);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.adres);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.is_ekle);
            this.groupBox3.Location = new System.Drawing.Point(1288, 119);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(385, 623);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni Sipariş Ekleme Paneli";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 155);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "Fiyat (TL):";
            // 
            // siFiyat
            // 
            this.siFiyat.Location = new System.Drawing.Point(35, 177);
            this.siFiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siFiyat.Name = "siFiyat";
            this.siFiyat.Size = new System.Drawing.Size(323, 22);
            this.siFiyat.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Ürün Adı : ";
            // 
            // siUrun
            // 
            this.siUrun.Location = new System.Drawing.Point(35, 71);
            this.siUrun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siUrun.Name = "siUrun";
            this.siUrun.Size = new System.Drawing.Size(323, 22);
            this.siUrun.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Adet: ";
            // 
            // siAdet
            // 
            this.siAdet.Location = new System.Drawing.Point(35, 124);
            this.siAdet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siAdet.Name = "siAdet";
            this.siAdet.Size = new System.Drawing.Size(323, 22);
            this.siAdet.TabIndex = 36;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 230);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(323, 24);
            this.comboBox1.TabIndex = 35;
            // 
            // bitis
            // 
            this.bitis.Location = new System.Drawing.Point(35, 337);
            this.bitis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bitis.Name = "bitis";
            this.bitis.Size = new System.Drawing.Size(323, 22);
            this.bitis.TabIndex = 20;
            // 
            // baslangic
            // 
            this.baslangic.Location = new System.Drawing.Point(35, 284);
            this.baslangic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baslangic.Name = "baslangic";
            this.baslangic.Size = new System.Drawing.Size(323, 22);
            this.baslangic.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Teslim Tarihi :";
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(35, 390);
            this.adres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(323, 174);
            this.adres.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 368);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Not:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "İş Başlangıcı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Firma Adı : ";
            // 
            // is_ekle
            // 
            this.is_ekle.BackColor = System.Drawing.SystemColors.ControlText;
            this.is_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.is_ekle.ForeColor = System.Drawing.Color.Coral;
            this.is_ekle.Location = new System.Drawing.Point(35, 572);
            this.is_ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.is_ekle.Name = "is_ekle";
            this.is_ekle.Size = new System.Drawing.Size(324, 41);
            this.is_ekle.TabIndex = 1;
            this.is_ekle.Text = "SİPARİŞ  EKLE";
            this.is_ekle.UseVisualStyleBackColor = false;
            this.is_ekle.Click += new System.EventHandler(this.is_ekle_Click);
            // 
            // sifre
            // 
            this.sifre.BackColor = System.Drawing.Color.Crimson;
            this.sifre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sifre.Location = new System.Drawing.Point(1329, 66);
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
            this.cikis.Location = new System.Drawing.Point(1455, 66);
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
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(1445, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "isim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(1324, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Hoşgeldiniz Sayın ";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(1284, 774);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(395, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "FolBar  © 2023. Tüm Hakları saklıdır.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalisanMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1712, 814);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CalisanMusteri";
            this.Text = "Satış ve Pazarlama Departmanı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CalisanMusteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button is_ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sifre;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker baslangic;
        private System.Windows.Forms.DateTimePicker bitis;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox siFiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox siUrun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox siAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_bitis;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_bilgi;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_tel;
    }
}