
namespace is_takibi
{
    partial class Takip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Takip));
            this.dataGridViewTakip = new System.Windows.Forms.DataGridView();
            this.t_barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_ist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_calisan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notYeri = new System.Windows.Forms.TextBox();
            this.bitti = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTakip)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTakip
            // 
            this.dataGridViewTakip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTakip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t_barkod,
            this.t_tarih,
            this.t_ist,
            this.t_calisan});
            this.dataGridViewTakip.Location = new System.Drawing.Point(67, 68);
            this.dataGridViewTakip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTakip.Name = "dataGridViewTakip";
            this.dataGridViewTakip.RowHeadersWidth = 49;
            this.dataGridViewTakip.Size = new System.Drawing.Size(736, 415);
            this.dataGridViewTakip.TabIndex = 0;
            this.dataGridViewTakip.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewTakip_DataBindingComplete);
            // 
            // t_barkod
            // 
            this.t_barkod.DataPropertyName = "t_barkod";
            this.t_barkod.HeaderText = "Barkod No";
            this.t_barkod.MinimumWidth = 6;
            this.t_barkod.Name = "t_barkod";
            this.t_barkod.Width = 120;
            // 
            // t_tarih
            // 
            this.t_tarih.DataPropertyName = "t_tarih";
            this.t_tarih.HeaderText = "İşe Başlama Tarihi";
            this.t_tarih.MinimumWidth = 6;
            this.t_tarih.Name = "t_tarih";
            this.t_tarih.Width = 120;
            // 
            // t_ist
            // 
            this.t_ist.DataPropertyName = "t_ist";
            this.t_ist.HeaderText = "İstasyon";
            this.t_ist.MinimumWidth = 6;
            this.t_ist.Name = "t_ist";
            this.t_ist.Width = 120;
            // 
            // t_calisan
            // 
            this.t_calisan.DataPropertyName = "t_calisan";
            this.t_calisan.HeaderText = "Çalışan Adı";
            this.t_calisan.MinimumWidth = 6;
            this.t_calisan.Name = "t_calisan";
            this.t_calisan.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.notYeri);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(867, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(427, 415);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İş Hakkındaki Notlar";
            // 
            // notYeri
            // 
            this.notYeri.Location = new System.Drawing.Point(8, 21);
            this.notYeri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.notYeri.Multiline = true;
            this.notYeri.Name = "notYeri";
            this.notYeri.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notYeri.Size = new System.Drawing.Size(409, 383);
            this.notYeri.TabIndex = 0;
            // 
            // bitti
            // 
            this.bitti.BackColor = System.Drawing.Color.MintCream;
            this.bitti.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitti.ForeColor = System.Drawing.Color.Black;
            this.bitti.Location = new System.Drawing.Point(500, 490);
            this.bitti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bitti.Name = "bitti";
            this.bitti.Size = new System.Drawing.Size(303, 49);
            this.bitti.TabIndex = 2;
            this.bitti.Text = "Bu İşi Bitti Olarak Kaydet !";
            this.bitti.UseVisualStyleBackColor = false;
            this.bitti.Click += new System.EventHandler(this.bitti_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FloralWhite;
            this.label9.Location = new System.Drawing.Point(63, 562);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 30);
            this.label9.TabIndex = 33;
            this.label9.Text = "FolBar  © 2023. Tüm Hakları saklıdır.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Takip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1373, 603);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bitti);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewTakip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Takip";
            this.Text = "İş Takip Paneli";
            this.Load += new System.EventHandler(this.Takip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTakip)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTakip;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_ist;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_calisan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bitti;
        private System.Windows.Forms.TextBox notYeri;
        private System.Windows.Forms.Label label9;
    }
}