﻿
namespace is_takibi
{
    partial class MusteriSifre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriSifre));
            this.degistir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.yeni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eski = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // degistir
            // 
            this.degistir.Location = new System.Drawing.Point(283, 265);
            this.degistir.Name = "degistir";
            this.degistir.Size = new System.Drawing.Size(127, 27);
            this.degistir.TabIndex = 4;
            this.degistir.Text = "Değiştir";
            this.degistir.UseVisualStyleBackColor = true;
            this.degistir.Click += new System.EventHandler(this.degistir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(75, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yeni Şifre :";
            // 
            // yeni
            // 
            this.yeni.Location = new System.Drawing.Point(76, 236);
            this.yeni.Name = "yeni";
            this.yeni.Size = new System.Drawing.Size(334, 20);
            this.yeni.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(75, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eski Şifre :";
            // 
            // eski
            // 
            this.eski.Location = new System.Drawing.Point(76, 182);
            this.eski.Name = "eski";
            this.eski.Size = new System.Drawing.Size(334, 20);
            this.eski.TabIndex = 0;
            // 
            // MusteriSifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 292);
            this.Controls.Add(this.degistir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yeni);
            this.Controls.Add(this.eski);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusteriSifre";
            this.Text = "Şifre Değiştirme Paneli";
            this.Load += new System.EventHandler(this.MusteriSifre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button degistir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yeni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eski;
    }
}