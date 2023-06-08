using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace is_takibi
{
    public partial class SifreGoster : Form
    {
        public SifreGoster()
        {
            InitializeComponent();
        }
        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");
        private void gonder_Click(object sender, EventArgs e)
        {
            baglan.Open();

            if (mail.Text.Length == 0 )
            {
                MessageBox.Show("Boş Bırakmayınız!", "UYARI! : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string sorgu = "SELECT * FROM musteri WHERE m_mail=@m_mail ";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);

                cmd.Parameters.AddWithValue("@m_mail", mail.Text);
                

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    /*
                     * string sifreAl = dr["m_sifre"].ToString();
   
                    MailMessage ePosta = new MailMessage();
                    ePosta.From = new MailAddress("tasarim.emre.ciftci@gmail.com");
                    ePosta.To.Add(mail.Text);

                    ePosta.Subject = "Sifre Hatirlatma";
                    ePosta.Body = "Sifreniz : " + sifreAl + "\n\nMutlu gunler dileriz :)";
                    SmtpClient smtp = new SmtpClient();
                    smtp.Credentials = new System.Net.NetworkCredential("tasarim.emre.ciftci@gmail.com", "hamzagulten123");
                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = false;
                    smtp.Send(ePosta);

                    */

                    MessageBox.Show("Mail başarıyla gönderilmiştir.!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    mail.Text = "";
                
                }
                else
                {
                    MessageBox.Show("Böyle bir Mail Sistemde Yok!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }



            baglan.Close();
        }

        private void SifreGoster_Load(object sender, EventArgs e)
        {

        }
    }
}
