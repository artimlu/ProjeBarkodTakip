
namespace is_takibi
{
    partial class Calisan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calisan));
            this.sifre = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.getir = new System.Windows.Forms.Button();
            this.isim = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sifre
            // 
            this.sifre.BackColor = System.Drawing.Color.Crimson;
            this.sifre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sifre.Location = new System.Drawing.Point(741, 49);
            this.sifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(111, 28);
            this.sifre.TabIndex = 27;
            this.sifre.Text = "Şifre Değiştir";
            this.sifre.UseVisualStyleBackColor = false;
            this.sifre.Click += new System.EventHandler(this.sifre_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Salmon;
            this.cikis.Location = new System.Drawing.Point(623, 49);
            this.cikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(111, 28);
            this.cikis.TabIndex = 30;
            this.cikis.Text = "Güvenli Çıkış";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(184, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "isim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(35, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Hoşgeldiniz Sayın  ";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FloralWhite;
            this.label9.Location = new System.Drawing.Point(553, 309);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 30);
            this.label9.TabIndex = 37;
            this.label9.Text = "FolBar  © 2023. Tüm Hakları saklıdır.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.getir);
            this.groupBox2.Controls.Add(this.isim);
            this.groupBox2.Location = new System.Drawing.Point(39, 153);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(481, 186);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İş Girişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Barkod No :";
            // 
            // getir
            // 
            this.getir.Location = new System.Drawing.Point(33, 117);
            this.getir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getir.Name = "getir";
            this.getir.Size = new System.Drawing.Size(399, 28);
            this.getir.TabIndex = 1;
            this.getir.Text = "İşi Getir";
            this.getir.UseVisualStyleBackColor = true;
            this.getir.Click += new System.EventHandler(this.getir_Click_1);
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(33, 69);
            this.isim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(397, 22);
            this.isim.TabIndex = 0;
            this.isim.TextChanged += new System.EventHandler(this.isim_TextChanged_1);
            // 
            // Calisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 430);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Calisan";
            this.Text = "Çalışan Paneli";
            this.Activated += new System.EventHandler(this.isim_TextChanged_1);
            this.Load += new System.EventHandler(this.Calisan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sifre;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button getir;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.Label label2;
    }
}