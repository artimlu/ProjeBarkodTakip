
namespace is_takibi
{
    partial class SifreGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreGoster));
            this.mail = new System.Windows.Forms.TextBox();
            this.gonder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(60, 241);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(341, 20);
            this.mail.TabIndex = 15;
            // 
            // gonder
            // 
            this.gonder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gonder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gonder.Location = new System.Drawing.Point(248, 272);
            this.gonder.Name = "gonder";
            this.gonder.Size = new System.Drawing.Size(153, 24);
            this.gonder.TabIndex = 14;
            this.gonder.Text = "Gönder";
            this.gonder.UseVisualStyleBackColor = false;
            this.gonder.Click += new System.EventHandler(this.gonder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(63, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "E-Postanızı Yazınız :";
            // 
            // SifreGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(471, 320);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.gonder);
            this.Controls.Add(this.label2);
            this.Name = "SifreGoster";
            this.Text = "Şifre Hatırlatma Paneli";
            this.Load += new System.EventHandler(this.SifreGoster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Button gonder;
        private System.Windows.Forms.Label label2;
    }
}