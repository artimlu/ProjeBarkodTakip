
namespace is_takibi
{
    partial class CMguncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMguncelle));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sebep = new System.Windows.Forms.TextBox();
            this.bilgi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guncelle = new System.Windows.Forms.Button();
            this.sUrun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sAdet = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.sAdet);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.sFiyat);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.sUrun);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.sebep);
            this.groupBox3.Controls.Add(this.bilgi);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.guncelle);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(59, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 413);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sipariş Güncelleme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Güncelleme Sebebi :";
            // 
            // sebep
            // 
            this.sebep.Location = new System.Drawing.Point(28, 275);
            this.sebep.Multiline = true;
            this.sebep.Name = "sebep";
            this.sebep.Size = new System.Drawing.Size(236, 70);
            this.sebep.TabIndex = 17;
            // 
            // bilgi
            // 
            this.bilgi.Location = new System.Drawing.Point(28, 184);
            this.bilgi.Multiline = true;
            this.bilgi.Name = "bilgi";
            this.bilgi.Size = new System.Drawing.Size(236, 66);
            this.bilgi.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Notlar:";
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.SystemColors.ControlText;
            this.guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelle.ForeColor = System.Drawing.Color.Coral;
            this.guncelle.Location = new System.Drawing.Point(28, 363);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(236, 33);
            this.guncelle.TabIndex = 1;
            this.guncelle.Text = "SİPARİŞİ GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sUrun
            // 
            this.sUrun.Location = new System.Drawing.Point(28, 47);
            this.sUrun.Name = "sUrun";
            this.sUrun.Size = new System.Drawing.Size(236, 20);
            this.sUrun.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ürün Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fiyat (TL):";
            // 
            // sFiyat
            // 
            this.sFiyat.Location = new System.Drawing.Point(28, 95);
            this.sFiyat.Name = "sFiyat";
            this.sFiyat.Size = new System.Drawing.Size(236, 20);
            this.sFiyat.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Adet:";
            // 
            // sAdet
            // 
            this.sAdet.Location = new System.Drawing.Point(28, 140);
            this.sAdet.Name = "sAdet";
            this.sAdet.Size = new System.Drawing.Size(236, 20);
            this.sAdet.TabIndex = 23;
            // 
            // CMguncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(431, 479);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CMguncelle";
            this.Text = "Sipariş Güncelleme Paneli";
            this.Load += new System.EventHandler(this.CMguncelle_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox bilgi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sebep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sUrun;
    }
}