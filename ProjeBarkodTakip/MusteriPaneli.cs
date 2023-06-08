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

namespace is_takibi
{
    public partial class MusteriPaneli : Form
    {
        public MusteriPaneli()
        {
            InitializeComponent();
        }

        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        MySqlDataAdapter mda;

        private void MusteriPaneli_Load(object sender, EventArgs e)
        {

        }

        private void giris_Click(object sender, EventArgs e)
        {
            baglan.Open();

            if (isim.Text.Length == 0 || sifre.Text.Length == 0)
            {
                MessageBox.Show("Alanları Boş Bırakmayınız!\n\nGiriş YAPILAMADI!", "UYARI! : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
 
                    string sorgu = "SELECT * FROM musteri WHERE m_isim=@isim AND m_sifre=@sifre";

                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);

                    cmd.Parameters.AddWithValue("@isim", isim.Text);
                    cmd.Parameters.AddWithValue("@sifre", sifre.Text);

                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        int oturum = (int)dr["m_id"];
                        Musteri musteri = new Musteri();
                        Musteri.oturumId = oturum;

                         MusteriMetotlar musteriMet = new MusteriMetotlar();
                         MusteriMetotlar.oturumId = oturum;

                        musteri.Show();  // form2 göster diyoruz
                        this.Hide();   // bunu yani form1'i gizle diyoruz
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı ya da şifre yanlış!\n\nGiriş YAPILAMADI!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
 

            }



            baglan.Close();
        }

        private void uyelik_Click(object sender, EventArgs e)
        {
            Uyelik uyelik = new Uyelik();

            uyelik.Show();

            this.Close();
        }

        private void sifreBildir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şifre Hatırlatma işlemi için, \n\nhuseyintaskiran@gazi.edu.tr\n\n maili ile irtibata geçiniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
