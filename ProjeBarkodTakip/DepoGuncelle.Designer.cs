
namespace is_takibi
{
    partial class DepoGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepoGuncelle));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.not = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.TextBox();
            this.guncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.d_aciklamaD = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.d_aciklamaD);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.not);
            this.groupBox3.Controls.Add(this.mail);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.isim);
            this.groupBox3.Controls.Add(this.guncelle);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(29, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 446);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Güncelleme Paneli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Depo Güncelleme Tarihi :";
            // 
            // not
            // 
            this.not.AutoSize = true;
            this.not.Location = new System.Drawing.Point(159, 420);
            this.not.Name = "not";
            this.not.Size = new System.Drawing.Size(88, 13);
            this.not.TabIndex = 19;
            this.not.Text = "degerdegerdeger";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(25, 163);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(236, 20);
            this.mail.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Adet :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ürün Adı : ";
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(25, 81);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(239, 20);
            this.isim.TabIndex = 2;
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.SystemColors.ControlText;
            this.guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelle.ForeColor = System.Drawing.Color.Coral;
            this.guncelle.Location = new System.Drawing.Point(25, 373);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(236, 33);
            this.guncelle.TabIndex = 1;
            this.guncelle.Text = "DEPO\'YU GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Açıklama :";
            // 
            // d_aciklamaD
            // 
            this.d_aciklamaD.Location = new System.Drawing.Point(25, 236);
            this.d_aciklamaD.Multiline = true;
            this.d_aciklamaD.Name = "d_aciklamaD";
            this.d_aciklamaD.Size = new System.Drawing.Size(236, 120);
            this.d_aciklamaD.TabIndex = 22;
            // 
            // DepoGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(363, 510);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepoGuncelle";
            this.Text = "Depo Güncelleme Paneli";
            this.Load += new System.EventHandler(this.DepoGuncelle_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Label not;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox d_aciklamaD;
    }
}