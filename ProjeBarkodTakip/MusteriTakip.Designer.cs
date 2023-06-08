
namespace is_takibi
{
    partial class MusteriTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriTakip));
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewTakipM = new System.Windows.Forms.DataGridView();
            this.t_barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_ist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_calisan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTakipM)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FloralWhite;
            this.label9.Location = new System.Drawing.Point(739, 534);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 30);
            this.label9.TabIndex = 36;
            this.label9.Text = "FolBar  © 2023. Tüm Hakları saklıdır.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dataGridViewTakipM
            // 
            this.dataGridViewTakipM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTakipM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t_barkod,
            this.t_tarih,
            this.t_ist,
            this.t_calisan});
            this.dataGridViewTakipM.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTakipM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTakipM.Name = "dataGridViewTakipM";
            this.dataGridViewTakipM.RowHeadersWidth = 49;
            this.dataGridViewTakipM.Size = new System.Drawing.Size(1068, 514);
            this.dataGridViewTakipM.TabIndex = 35;
            this.dataGridViewTakipM.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewTakipM_DataBindingComplete);
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
            // MusteriTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1067, 575);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewTakipM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MusteriTakip";
            this.Text = "İş Takip Paneli";
            this.Load += new System.EventHandler(this.MusteriTakip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTakipM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewTakipM;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_ist;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_calisan;
    }
}