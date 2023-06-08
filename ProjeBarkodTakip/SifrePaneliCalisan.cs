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
    public partial class SifrePaneliCalisan : Form
    {
        public SifrePaneliCalisan()
        {
            InitializeComponent();
        }
        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        public int oturum_id2 { get; set; }

        String sifreEski;
        private void SifrePaneliCalisan_Load(object sender, EventArgs e)
        {
            baglan.Open();
            string oturumCek2 = "SELECT * FROM calisan WHERE c_id=@id22 ";
            MySqlCommand komut = new MySqlCommand(oturumCek2, baglan);

            komut.Parameters.AddWithValue("@id22", oturum_id2);

            MySqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {

                sifreEski = dr["c_sifre"].ToString();


            }

            dr.Close();
            baglan.Close();

        }

        private void degistir_Click(object sender, EventArgs e)
        {
            baglan.Open();

            if (eski.Text.Length == 0 || yeni.Text.Length == 0)
            {
                MessageBox.Show("Gerekli Alanları Boş Bırakmayınız!\n\nŞifre Değişmedi!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (yeni.Text.Length < 4)
            {

                MessageBox.Show("Yeni Şifre En Az 4 Haneli Olmalı!\n\nŞifre Değişmedi!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                

                if (sifreEski == eski.Text)
                {
                    string guncelle2 = "UPDATE calisan SET c_sifre=@sifre WHERE c_id=@id";
                    MySqlCommand emoli = new MySqlCommand(guncelle2, baglan);

                    emoli.Parameters.AddWithValue("@sifre", yeni.Text);
                    emoli.Parameters.AddWithValue("@id", oturum_id2);


                    emoli.ExecuteNonQuery();

                    MessageBox.Show("Şifre başarıyla güncellendi!\n\nYeni Şifre: " + yeni.Text, "Bilgilendirme :", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    eski.Text = "";
                    yeni.Text = "";
                }
                else
                {
                    MessageBox.Show("Eski Şifre Hatalı!\n\nŞifre Değişmedi!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            baglan.Close();

        }
    }
}
