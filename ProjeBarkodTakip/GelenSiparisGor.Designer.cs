
namespace is_takibi
{
    partial class GelenSiparisGor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GelenSiparisGor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.kayitTamam = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.si_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.si_baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.si_bitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.si_bilgi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.si_urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.si_adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.si_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.kayitTamam);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(20, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1228, 774);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş Paneli";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(19, 724);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "FolBar  © 2023. Tüm Hakları saklıdır.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kayitTamam
            // 
            this.kayitTamam.BackColor = System.Drawing.SystemColors.ControlText;
            this.kayitTamam.ForeColor = System.Drawing.Color.Aquamarine;
            this.kayitTamam.Location = new System.Drawing.Point(655, 715);
            this.kayitTamam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kayitTamam.Name = "kayitTamam";
            this.kayitTamam.Size = new System.Drawing.Size(549, 41);
            this.kayitTamam.TabIndex = 6;
            this.kayitTamam.Text = "BU SİPARİŞİN KAYDINI YAPILDI OLARAK İŞARETLE";
            this.kayitTamam.UseVisualStyleBackColor = false;
            this.kayitTamam.Click += new System.EventHandler(this.kayitTamam_Click);
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
            this.m_isim,
            this.si_urun,
            this.si_adet,
            this.si_fiyat});
            this.dataGridView2.Location = new System.Drawing.Point(19, 30);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 49;
            this.dataGridView2.Size = new System.Drawing.Size(1181, 674);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            this.si_bilgi.FillWeight = 150F;
            this.si_bilgi.HeaderText = "Bilgiler";
            this.si_bilgi.MinimumWidth = 6;
            this.si_bilgi.Name = "si_bilgi";
            this.si_bilgi.Width = 150;
            // 
            // m_isim
            // 
            this.m_isim.DataPropertyName = "m_isim";
            this.m_isim.HeaderText = "Firma Adı";
            this.m_isim.MinimumWidth = 6;
            this.m_isim.Name = "m_isim";
            this.m_isim.Width = 120;
            // 
            // si_urun
            // 
            this.si_urun.DataPropertyName = "si_urun";
            this.si_urun.HeaderText = "Ürün Adı";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Yeşil: Kaydı Yapılanlar  |   Kırmızı: Kaydı Henüz Yapılmayanlar";
            // 
            // GelenSiparisGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 860);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GelenSiparisGor";
            this.Text = "Gelen Siparişler";
            this.Load += new System.EventHandler(this.GelenSiparisGor_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button kayitTamam;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_bitis;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_bilgi;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_fiyat;
    }
}