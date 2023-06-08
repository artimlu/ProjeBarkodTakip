
namespace is_takibi
{
    partial class CalisanKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanKayit));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.is_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_giris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_ekle = new System.Windows.Forms.Button();
            this.isim = new System.Windows.Forms.TextBox();
            this.sil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tutar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.yenile = new System.Windows.Forms.Button();
            this.takip = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.urun = new System.Windows.Forms.TextBox();
            this.i_adet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.is_not = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.barkod_picture = new System.Windows.Forms.PictureBox();
            this.yazdir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Button();
            this.gelenSiparisler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barkod_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.is_adi,
            this.is_urun,
            this.is_adet,
            this.is_tutar,
            this.is_giris,
            this.m_isim,
            this.m_tel});
            this.dataGridView1.Location = new System.Drawing.Point(23, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 692);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // is_adi
            // 
            this.is_adi.DataPropertyName = "is_adi";
            this.is_adi.HeaderText = "İşin Adı";
            this.is_adi.MinimumWidth = 6;
            this.is_adi.Name = "is_adi";
            this.is_adi.Width = 120;
            // 
            // is_urun
            // 
            this.is_urun.DataPropertyName = "is_urun";
            this.is_urun.HeaderText = "Ürün";
            this.is_urun.MinimumWidth = 6;
            this.is_urun.Name = "is_urun";
            this.is_urun.Width = 120;
            // 
            // is_adet
            // 
            this.is_adet.DataPropertyName = "is_adet";
            this.is_adet.HeaderText = "Adet";
            this.is_adet.MinimumWidth = 6;
            this.is_adet.Name = "is_adet";
            this.is_adet.Width = 120;
            // 
            // is_tutar
            // 
            this.is_tutar.DataPropertyName = "is_tutar";
            this.is_tutar.HeaderText = "İşin Tutarı";
            this.is_tutar.MinimumWidth = 6;
            this.is_tutar.Name = "is_tutar";
            this.is_tutar.Width = 120;
            // 
            // is_giris
            // 
            this.is_giris.DataPropertyName = "is_giris";
            this.is_giris.HeaderText = "İş Giriş Tarihi";
            this.is_giris.MinimumWidth = 6;
            this.is_giris.Name = "is_giris";
            this.is_giris.Width = 120;
            // 
            // m_isim
            // 
            this.m_isim.DataPropertyName = "m_isim";
            this.m_isim.HeaderText = "Müşteri Adı";
            this.m_isim.MinimumWidth = 6;
            this.m_isim.Name = "m_isim";
            this.m_isim.Width = 120;
            // 
            // m_tel
            // 
            this.m_tel.DataPropertyName = "m_tel";
            this.m_tel.HeaderText = "Müşteri Telefon";
            this.m_tel.MinimumWidth = 6;
            this.m_tel.Name = "m_tel";
            this.m_tel.Width = 120;
            // 
            // is_ekle
            // 
            this.is_ekle.BackColor = System.Drawing.SystemColors.ControlText;
            this.is_ekle.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.is_ekle.ForeColor = System.Drawing.Color.Coral;
            this.is_ekle.Location = new System.Drawing.Point(17, 393);
            this.is_ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.is_ekle.Name = "is_ekle";
            this.is_ekle.Size = new System.Drawing.Size(324, 42);
            this.is_ekle.TabIndex = 1;
            this.is_ekle.Text = "İŞ EKLE";
            this.is_ekle.UseVisualStyleBackColor = false;
            this.is_ekle.Click += new System.EventHandler(this.is_ekle_Click);
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(17, 55);
            this.isim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(323, 22);
            this.isim.TabIndex = 2;
            this.isim.TextChanged += new System.EventHandler(this.isim_TextChanged);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.SystemColors.ControlText;
            this.sil.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.sil.Location = new System.Drawing.Point(23, 768);
            this.sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(251, 41);
            this.sil.TabIndex = 5;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.SystemColors.ControlText;
            this.guncelle.ForeColor = System.Drawing.Color.Aquamarine;
            this.guncelle.Location = new System.Drawing.Point(435, 768);
            this.guncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(251, 41);
            this.guncelle.TabIndex = 6;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Arama Yapılacak İş Adını yazınız...";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "İşin Adı : (Firma - Ürün - Adet)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Müşteri Adı : ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 156);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(323, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Adet : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "İşin Tutarı (TL olarak) :  ";
            // 
            // tutar
            // 
            this.tutar.Location = new System.Drawing.Point(17, 208);
            this.tutar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(323, 22);
            this.tutar.TabIndex = 14;
            this.tutar.TextChanged += new System.EventHandler(this.tutar_TextChanged);
            this.tutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tutar_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.yenile);
            this.groupBox1.Controls.Add(this.takip);
            this.groupBox1.Controls.Add(this.ara);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.guncelle);
            this.groupBox1.Controls.Add(this.sil);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(29, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1105, 816);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İş Düzenleme Paneli";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button1.Location = new System.Drawing.Point(771, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "BİTMİŞ İŞLER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(326, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "(Ara Butonu Aktif ve Tamamlanmış Tüm İşleri Gösterir)";
            // 
            // yenile
            // 
            this.yenile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.yenile.ForeColor = System.Drawing.Color.Crimson;
            this.yenile.Location = new System.Drawing.Point(940, 28);
            this.yenile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(125, 27);
            this.yenile.TabIndex = 10;
            this.yenile.Text = "YENİLE";
            this.yenile.UseVisualStyleBackColor = false;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // takip
            // 
            this.takip.BackColor = System.Drawing.SystemColors.ControlText;
            this.takip.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.takip.Location = new System.Drawing.Point(815, 768);
            this.takip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.takip.Name = "takip";
            this.takip.Size = new System.Drawing.Size(251, 41);
            this.takip.TabIndex = 9;
            this.takip.Text = "İŞ TAKİBİ";
            this.takip.UseVisualStyleBackColor = false;
            this.takip.Click += new System.EventHandler(this.takip_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.urun);
            this.groupBox3.Controls.Add(this.i_adet);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.is_not);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tutar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.isim);
            this.groupBox3.Controls.Add(this.is_ekle);
            this.groupBox3.Location = new System.Drawing.Point(1227, 363);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(357, 443);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni İş Ekleme Paneli";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 85);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ürün Adı :";
            // 
            // urun
            // 
            this.urun.Location = new System.Drawing.Point(17, 106);
            this.urun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.urun.Name = "urun";
            this.urun.Size = new System.Drawing.Size(323, 22);
            this.urun.TabIndex = 19;
            // 
            // i_adet
            // 
            this.i_adet.Location = new System.Drawing.Point(17, 258);
            this.i_adet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.i_adet.Name = "i_adet";
            this.i_adet.Size = new System.Drawing.Size(323, 22);
            this.i_adet.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Not :";
            // 
            // is_not
            // 
            this.is_not.Location = new System.Drawing.Point(17, 309);
            this.is_not.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.is_not.Multiline = true;
            this.is_not.Name = "is_not";
            this.is_not.Size = new System.Drawing.Size(323, 70);
            this.is_not.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.barkod_picture);
            this.groupBox2.Controls.Add(this.yazdir);
            this.groupBox2.Location = new System.Drawing.Point(1227, 138);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(357, 212);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barkod Alanı";
            // 
            // barkod_picture
            // 
            this.barkod_picture.Location = new System.Drawing.Point(23, 26);
            this.barkod_picture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barkod_picture.Name = "barkod_picture";
            this.barkod_picture.Size = new System.Drawing.Size(315, 124);
            this.barkod_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.barkod_picture.TabIndex = 18;
            this.barkod_picture.TabStop = false;
            this.barkod_picture.Click += new System.EventHandler(this.barkod_picture_Click);
            // 
            // yazdir
            // 
            this.yazdir.BackColor = System.Drawing.SystemColors.ControlText;
            this.yazdir.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazdir.ForeColor = System.Drawing.Color.Coral;
            this.yazdir.Location = new System.Drawing.Point(19, 160);
            this.yazdir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yazdir.Name = "yazdir";
            this.yazdir.Size = new System.Drawing.Size(319, 42);
            this.yazdir.TabIndex = 17;
            this.yazdir.Text = "YAZDIR";
            this.yazdir.UseVisualStyleBackColor = false;
            this.yazdir.Click += new System.EventHandler(this.yazdir_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(1223, 815);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(359, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "FolBar  © 2023. Tüm Hakları saklıdır.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sifre
            // 
            this.sifre.BackColor = System.Drawing.Color.Crimson;
            this.sifre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sifre.Location = new System.Drawing.Point(1227, 62);
            this.sifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(160, 31);
            this.sifre.TabIndex = 7;
            this.sifre.Text = "Şifre Değiştir";
            this.sifre.UseVisualStyleBackColor = false;
            this.sifre.Click += new System.EventHandler(this.sifre_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1223, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Hoşgeldiniz Sayın ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(1343, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "isim";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Crimson;
            this.cikis.ForeColor = System.Drawing.Color.Cornsilk;
            this.cikis.Location = new System.Drawing.Point(1400, 62);
            this.cikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(181, 31);
            this.cikis.TabIndex = 26;
            this.cikis.Text = "Güvenli Çıkış";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // gelenSiparisler
            // 
            this.gelenSiparisler.BackColor = System.Drawing.Color.DarkRed;
            this.gelenSiparisler.ForeColor = System.Drawing.Color.Cornsilk;
            this.gelenSiparisler.Location = new System.Drawing.Point(1227, 100);
            this.gelenSiparisler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gelenSiparisler.Name = "gelenSiparisler";
            this.gelenSiparisler.Size = new System.Drawing.Size(355, 31);
            this.gelenSiparisler.TabIndex = 27;
            this.gelenSiparisler.Text = "Gelen Siparişleri Gör";
            this.gelenSiparisler.UseVisualStyleBackColor = false;
            this.gelenSiparisler.Click += new System.EventHandler(this.gelenSiparisler_Click);
            // 
            // CalisanKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1627, 850);
            this.Controls.Add(this.gelenSiparisler);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CalisanKayit";
            this.Text = "İş Kayıt Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CalisanKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barkod_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button is_ekle;
        public System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox barkod_picture;
        private System.Windows.Forms.Button yazdir;
        private System.Windows.Forms.Button takip;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Button sifre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox is_not;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button gelenSiparisler;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox i_adet;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_giris;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_tel;
    }
}