
namespace is_takibi
{
    partial class CKguncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CKguncelle));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.is_not = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.i_urun = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.TextBox();
            this.guncelle = new System.Windows.Forms.Button();
            this.i_adet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.i_adet);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.is_not);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.i_urun);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tutar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.isim);
            this.groupBox3.Controls.Add(this.guncelle);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(55, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 431);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Güncelleme Paneli";
            // 
            // is_not
            // 
            this.is_not.AutoSize = true;
            this.is_not.Location = new System.Drawing.Point(21, 278);
            this.is_not.Name = "is_not";
            this.is_not.Size = new System.Drawing.Size(30, 13);
            this.is_not.TabIndex = 18;
            this.is_not.Text = "Not :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 298);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 70);
            this.textBox1.TabIndex = 17;
            // 
            // i_urun
            // 
            this.i_urun.Location = new System.Drawing.Point(21, 109);
            this.i_urun.Name = "i_urun";
            this.i_urun.Size = new System.Drawing.Size(257, 20);
            this.i_urun.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "İşin Tutarı (TL olarak) :  ";
            // 
            // tutar
            // 
            this.tutar.Location = new System.Drawing.Point(21, 204);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(259, 20);
            this.tutar.TabIndex = 14;
            this.tutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tutar_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ürün Adı :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Müşteri Adı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "İşin Adı : ";
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(21, 62);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(259, 20);
            this.isim.TabIndex = 2;
            this.isim.TextChanged += new System.EventHandler(this.isim_TextChanged);
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.SystemColors.ControlText;
            this.guncelle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle.ForeColor = System.Drawing.Color.Snow;
            this.guncelle.Location = new System.Drawing.Point(163, 382);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(115, 34);
            this.guncelle.TabIndex = 1;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // i_adet
            // 
            this.i_adet.Location = new System.Drawing.Point(21, 251);
            this.i_adet.Name = "i_adet";
            this.i_adet.Size = new System.Drawing.Size(257, 20);
            this.i_adet.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Adet :";
            // 
            // CKguncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(418, 499);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CKguncelle";
            this.Text = "İş Güncelleme Paneli";
            this.Load += new System.EventHandler(this.CKguncelle_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.TextBox i_urun;
        private System.Windows.Forms.Label is_not;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox i_adet;
        private System.Windows.Forms.Label label2;
    }
}