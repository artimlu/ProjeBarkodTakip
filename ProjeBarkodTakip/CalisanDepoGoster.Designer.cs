
namespace is_takibi
{
    partial class CalisanDepoGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanDepoGoster));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yenile = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.d_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.yenile);
            this.groupBox1.Controls.Add(this.ara);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(21, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1045, 732);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depo Paneli";
            // 
            // yenile
            // 
            this.yenile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.yenile.ForeColor = System.Drawing.Color.Crimson;
            this.yenile.Location = new System.Drawing.Point(859, 36);
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
            this.ara.Location = new System.Drawing.Point(317, 34);
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
            this.textBox1.Location = new System.Drawing.Point(23, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Ürün Adını yazınız...";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.d_id,
            this.d_urun,
            this.d_adet,
            this.d_tarih,
            this.d_aciklama});
            this.dataGridView2.Location = new System.Drawing.Point(23, 73);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 49;
            this.dataGridView2.Size = new System.Drawing.Size(997, 631);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView2_DataBindingComplete);
            // 
            // d_id
            // 
            this.d_id.DataPropertyName = "d_id";
            this.d_id.HeaderText = "Ürün No";
            this.d_id.MinimumWidth = 6;
            this.d_id.Name = "d_id";
            this.d_id.Width = 120;
            // 
            // d_urun
            // 
            this.d_urun.DataPropertyName = "d_urun";
            this.d_urun.HeaderText = "Ürün Adı";
            this.d_urun.MinimumWidth = 6;
            this.d_urun.Name = "d_urun";
            this.d_urun.Width = 120;
            // 
            // d_adet
            // 
            this.d_adet.DataPropertyName = "d_adet";
            this.d_adet.HeaderText = "Adet";
            this.d_adet.MinimumWidth = 6;
            this.d_adet.Name = "d_adet";
            this.d_adet.Width = 120;
            // 
            // d_tarih
            // 
            this.d_tarih.DataPropertyName = "d_tarih";
            this.d_tarih.HeaderText = "Güncelleme Tarihi";
            this.d_tarih.MinimumWidth = 6;
            this.d_tarih.Name = "d_tarih";
            this.d_tarih.Width = 120;
            // 
            // d_aciklama
            // 
            this.d_aciklama.DataPropertyName = "d_aciklama";
            this.d_aciklama.HeaderText = "Açıklama";
            this.d_aciklama.MinimumWidth = 6;
            this.d_aciklama.Name = "d_aciklama";
            this.d_aciklama.Width = 120;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(684, 798);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(383, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "FolBar  © 2023. Tüm Hakları saklıdır.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "** 5 Adet ve Daha Az Kalan Ürünler Kırmızıyla Gösterilir!";
            // 
            // CalisanDepoGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1107, 827);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CalisanDepoGoster";
            this.Text = "Depo Sayımı";
            this.Load += new System.EventHandler(this.CalisanDepoGoster_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_aciklama;
        private System.Windows.Forms.Label label1;
    }
}