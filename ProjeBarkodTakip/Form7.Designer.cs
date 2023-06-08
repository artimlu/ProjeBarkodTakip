
namespace is_takibi
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.TextBox();
            this.is_ekle = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DepoGit = new System.Windows.Forms.Button();
            this.muhasebe = new System.Windows.Forms.Button();
            this.satinAl = new System.Windows.Forms.Button();
            this.kullanici = new System.Windows.Forms.Button();
            this.istasyon = new System.Windows.Forms.Button();
            this.musteriler = new System.Windows.Forms.Button();
            this.isler = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yenile = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.ist_isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ist_ac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.ac);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.isim);
            this.groupBox3.Controls.Add(this.is_ekle);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(1203, 134);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(323, 593);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni İstasyon Ekleme Paneli";
            // 
            // ac
            // 
            this.ac.Location = new System.Drawing.Point(35, 177);
            this.ac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ac.Multiline = true;
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(263, 296);
            this.ac.TabIndex = 16;
            this.ac.TextChanged += new System.EventHandler(this.adres_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "İstasyon Açıklama : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "İstasyon Adı : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(35, 92);
            this.isim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(257, 22);
            this.isim.TabIndex = 2;
            // 
            // is_ekle
            // 
            this.is_ekle.BackColor = System.Drawing.SystemColors.ControlText;
            this.is_ekle.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.is_ekle.ForeColor = System.Drawing.Color.Coral;
            this.is_ekle.Location = new System.Drawing.Point(35, 516);
            this.is_ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.is_ekle.Name = "is_ekle";
            this.is_ekle.Size = new System.Drawing.Size(264, 42);
            this.is_ekle.TabIndex = 1;
            this.is_ekle.Text = "İSTASYON EKLE";
            this.is_ekle.UseVisualStyleBackColor = false;
            this.is_ekle.Click += new System.EventHandler(this.is_ekle_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.DepoGit);
            this.groupBox5.Controls.Add(this.muhasebe);
            this.groupBox5.Controls.Add(this.satinAl);
            this.groupBox5.Controls.Add(this.kullanici);
            this.groupBox5.Controls.Add(this.istasyon);
            this.groupBox5.Controls.Add(this.musteriler);
            this.groupBox5.Controls.Add(this.isler);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(21, 12);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(1131, 87);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Menü";
            // 
            // DepoGit
            // 
            this.DepoGit.BackColor = System.Drawing.Color.Black;
            this.DepoGit.ForeColor = System.Drawing.Color.White;
            this.DepoGit.Location = new System.Drawing.Point(965, 27);
            this.DepoGit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DepoGit.Name = "DepoGit";
            this.DepoGit.Size = new System.Drawing.Size(143, 38);
            this.DepoGit.TabIndex = 43;
            this.DepoGit.Text = "Depo Paneli";
            this.DepoGit.UseVisualStyleBackColor = false;
            this.DepoGit.Click += new System.EventHandler(this.DepoGit_Click);
            // 
            // muhasebe
            // 
            this.muhasebe.BackColor = System.Drawing.SystemColors.ControlText;
            this.muhasebe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.muhasebe.Location = new System.Drawing.Point(651, 27);
            this.muhasebe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.muhasebe.Name = "muhasebe";
            this.muhasebe.Size = new System.Drawing.Size(140, 38);
            this.muhasebe.TabIndex = 4;
            this.muhasebe.Text = "Muhasebe Paneli";
            this.muhasebe.UseVisualStyleBackColor = false;
            this.muhasebe.Click += new System.EventHandler(this.muhasebe_Click);
            // 
            // satinAl
            // 
            this.satinAl.BackColor = System.Drawing.Color.Black;
            this.satinAl.ForeColor = System.Drawing.Color.White;
            this.satinAl.Location = new System.Drawing.Point(804, 27);
            this.satinAl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.satinAl.Name = "satinAl";
            this.satinAl.Size = new System.Drawing.Size(143, 38);
            this.satinAl.TabIndex = 42;
            this.satinAl.Text = "Satın Alma Paneli";
            this.satinAl.UseVisualStyleBackColor = false;
            this.satinAl.Click += new System.EventHandler(this.satinAl_Click);
            // 
            // kullanici
            // 
            this.kullanici.BackColor = System.Drawing.SystemColors.ControlText;
            this.kullanici.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kullanici.Location = new System.Drawing.Point(493, 27);
            this.kullanici.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullanici.Name = "kullanici";
            this.kullanici.Size = new System.Drawing.Size(140, 38);
            this.kullanici.TabIndex = 3;
            this.kullanici.Text = "Çalışan Paneli";
            this.kullanici.UseVisualStyleBackColor = false;
            this.kullanici.Click += new System.EventHandler(this.kullanici_Click);
            // 
            // istasyon
            // 
            this.istasyon.BackColor = System.Drawing.Color.CornflowerBlue;
            this.istasyon.ForeColor = System.Drawing.Color.Black;
            this.istasyon.Location = new System.Drawing.Point(335, 27);
            this.istasyon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.istasyon.Name = "istasyon";
            this.istasyon.Size = new System.Drawing.Size(140, 38);
            this.istasyon.TabIndex = 2;
            this.istasyon.Text = "İstasyon Paneli";
            this.istasyon.UseVisualStyleBackColor = false;
            this.istasyon.Click += new System.EventHandler(this.istasyon_Click);
            // 
            // musteriler
            // 
            this.musteriler.BackColor = System.Drawing.SystemColors.ControlText;
            this.musteriler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.musteriler.Location = new System.Drawing.Point(175, 27);
            this.musteriler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musteriler.Name = "musteriler";
            this.musteriler.Size = new System.Drawing.Size(140, 38);
            this.musteriler.TabIndex = 1;
            this.musteriler.Text = "Müşteri Paneli";
            this.musteriler.UseVisualStyleBackColor = false;
            this.musteriler.Click += new System.EventHandler(this.musteriler_Click);
            // 
            // isler
            // 
            this.isler.BackColor = System.Drawing.SystemColors.ControlText;
            this.isler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.isler.Location = new System.Drawing.Point(16, 27);
            this.isler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isler.Name = "isler";
            this.isler.Size = new System.Drawing.Size(140, 38);
            this.isler.TabIndex = 0;
            this.isler.Text = "İş Paneli";
            this.isler.UseVisualStyleBackColor = false;
            this.isler.Click += new System.EventHandler(this.isler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yenile);
            this.groupBox1.Controls.Add(this.ara);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.guncelle);
            this.groupBox1.Controls.Add(this.sil);
            this.groupBox1.Controls.Add(this.dataGridView4);
            this.groupBox1.Location = new System.Drawing.Point(21, 134);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1131, 665);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İstasyon Düzenleme Paneli";
            // 
            // yenile
            // 
            this.yenile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.yenile.ForeColor = System.Drawing.Color.Crimson;
            this.yenile.Location = new System.Drawing.Point(968, 28);
            this.yenile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(133, 27);
            this.yenile.TabIndex = 10;
            this.yenile.Text = "LİSTEYİ YENİLE";
            this.yenile.UseVisualStyleBackColor = false;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(344, 26);
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
            this.textBox1.Size = new System.Drawing.Size(312, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "İstasyon Adını yazınız...";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.SystemColors.ControlText;
            this.guncelle.ForeColor = System.Drawing.Color.Aquamarine;
            this.guncelle.Location = new System.Drawing.Point(921, 601);
            this.guncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(180, 41);
            this.guncelle.TabIndex = 6;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.SystemColors.ControlText;
            this.sil.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.sil.Location = new System.Drawing.Point(23, 601);
            this.sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(156, 41);
            this.sil.TabIndex = 5;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToOrderColumns = true;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ist_isim,
            this.ist_ac});
            this.dataGridView4.Location = new System.Drawing.Point(23, 64);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 49;
            this.dataGridView4.Size = new System.Drawing.Size(1079, 529);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView4_DataBindingComplete);
            // 
            // ist_isim
            // 
            this.ist_isim.DataPropertyName = "ist_isim";
            this.ist_isim.FillWeight = 200F;
            this.ist_isim.HeaderText = "İstasyon İsim";
            this.ist_isim.MinimumWidth = 6;
            this.ist_isim.Name = "ist_isim";
            this.ist_isim.Width = 200;
            // 
            // ist_ac
            // 
            this.ist_ac.DataPropertyName = "ist_ac";
            this.ist_ac.FillWeight = 300F;
            this.ist_ac.HeaderText = "İstasyon Açıklama";
            this.ist_ac.MinimumWidth = 6;
            this.ist_ac.Name = "ist_ac";
            this.ist_ac.Width = 300;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1212, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 31);
            this.button1.TabIndex = 31;
            this.button1.Text = "Şifre Değiştir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Crimson;
            this.cikis.ForeColor = System.Drawing.Color.Cornsilk;
            this.cikis.Location = new System.Drawing.Point(1336, 69);
            this.cikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(129, 31);
            this.cikis.TabIndex = 34;
            this.cikis.Text = "Güvenli Çıkış";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(1325, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "isim";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1207, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Hoşgeldiniz Sayın ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(1213, 774);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 25);
            this.label9.TabIndex = 36;
            this.label9.Text = "FolBar  © 2023. Tüm Hakları saklıdır.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1552, 814);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form7";
            this.Text = "İstasyon Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form7_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.Button is_ekle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button muhasebe;
        private System.Windows.Forms.Button kullanici;
        private System.Windows.Forms.Button istasyon;
        private System.Windows.Forms.Button musteriler;
        private System.Windows.Forms.Button isler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DepoGit;
        private System.Windows.Forms.Button satinAl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ist_isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ist_ac;
    }
}