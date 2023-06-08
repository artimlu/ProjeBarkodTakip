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

namespace is_takibi
{
    public partial class Uyelik : Form
    {
        public Uyelik()
        {
            InitializeComponent();
        }
        // MySql veritabanına bağlantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        private void Uyelik_Load(object sender, EventArgs e)
        {

        }

        public static bool Email_Format_Kontrol(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void is_ekle_Click(object sender, EventArgs e)
        {
            if (isim.Text.Length == 0 || tel.Text.Length == 0 || mail.Text.Length == 0 || sifre.Text.Length == 0)
            {
                MessageBox.Show("Boş Alan Bırakmayınız!\n\nTekrar Deneyiniz...", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (sifre.Text.Length < 4)
            {
                MessageBox.Show("Şifre en az 4 haneli olmalı!\n\nTekrar Deneyiniz...", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (Email_Format_Kontrol(mail.Text) == false)
            {

                MessageBox.Show("Geçersiz E-Posta Adresi!\n\nTekrar Deneyiniz...", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglan.Open();



                string yil = DateTime.Now.ToShortDateString(); // gün.ay.yil olarak verir


                MySqlCommand ekle = new MySqlCommand("INSERT INTO musteri (m_isim,m_tel,m_adres,m_tarih,m_mail,m_sifre) VALUES (@m_isim,@m_tel,@m_adres,@m_tarih,@m_mail,@m_sifre)", baglan);

                ekle.Parameters.AddWithValue("@m_isim", isim.Text);
                ekle.Parameters.AddWithValue("@m_tel", tel.Text);
                ekle.Parameters.AddWithValue("@m_adres", adres.Text);
                ekle.Parameters.AddWithValue("@m_tarih", yil);
                ekle.Parameters.AddWithValue("@m_mail", mail.Text);
                ekle.Parameters.AddWithValue("@m_sifre", sifre.Text);

                ekle.ExecuteNonQuery();

                MessageBox.Show("Başarıyla Kayıt Oldunuz.", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isim.Text = "";
                tel.Text = "";
                adres.Text = "";
                mail.Text = "";
                sifre.Text = "";

                baglan.Close();

                MusteriPaneli mp = new MusteriPaneli();

                mp.Show();

                this.Close();

              

            }
        }

    }
}
