
namespace is_takibi
{
    partial class SifrePaneliCalisan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifrePaneliCalisan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.degistir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.yeni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eski = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.degistir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.yeni);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.eski);
            this.groupBox1.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox1.Location = new System.Drawing.Point(33, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 223);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre Değiştirme Paneli";
            // 
            // degistir
            // 
            this.degistir.ForeColor = System.Drawing.Color.Black;
            this.degistir.Location = new System.Drawing.Point(168, 158);
            this.degistir.Name = "degistir";
            this.degistir.Size = new System.Drawing.Size(72, 23);
            this.degistir.TabIndex = 4;
            this.degistir.Text = "Değiştir";
            this.degistir.UseVisualStyleBackColor = true;
            this.degistir.Click += new System.EventHandler(this.degistir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yeni Şifre :";
            // 
            // yeni
            // 
            this.yeni.Location = new System.Drawing.Point(18, 116);
            this.yeni.Name = "yeni";
            this.yeni.Size = new System.Drawing.Size(222, 20);
            this.yeni.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eski Şifre :";
            // 
            // eski
            // 
            this.eski.Location = new System.Drawing.Point(18, 59);
            this.eski.Name = "eski";
            this.eski.Size = new System.Drawing.Size(222, 20);
            this.eski.TabIndex = 0;
            // 
            // SifrePaneliCalisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(346, 295);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SifrePaneliCalisan";
            this.Text = "Şifre Paneli Çalisan";
            this.Load += new System.EventHandler(this.SifrePaneliCalisan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button degistir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yeni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eski;
    }
}