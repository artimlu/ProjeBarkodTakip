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
    public partial class MusteriSifre : Form
    {
        public MusteriSifre()
        {
            InitializeComponent();
        }
        public static int oturum_id { get; set; }


        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");


        public class SifreDuzenle : MusteriAbstract
        {
            public override void uyari()
            {

                MessageBox.Show("Gerekli Alanları Boş Bırakmayınız!\n\nŞifre Değişmedi!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }


        private void MusteriSifre_Load(object sender, EventArgs e)
        {

        }

        private void degistir_Click(object sender, EventArgs e)
        {
            baglan.Open();

            if (eski.Text.Length == 0 || yeni.Text.Length == 0)
            {
                SifreDuzenle sifDuz = new SifreDuzenle();

                sifDuz.uyari();
            }
            else if (yeni.Text.Length < 4)
            {

                MessageBox.Show("Yeni Şifre En Az 4 Haneli Olmalı!\n\nŞifre Değişmedi!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                string oturumCek2 = "SELECT * FROM musteri WHERE m_id=@id AND m_sifre=@sifre";
                MySqlCommand komut = new MySqlCommand(oturumCek2, baglan);

                komut.Parameters.AddWithValue("@id", oturum_id);
                komut.Parameters.AddWithValue("@sifre", eski.Text);


                // NOT NOT NOT ÖNEMLİ ÖNEMLİ ÖNEMLİ : 2 TANE DATAREADER HATA VERDİĞİ İÇİN 
                //komut'u OBJECT'E AKTARIP VAR MI YOK MU SORGULADIK!

                object emre = komut.ExecuteScalar();

                if (emre == null)
                { // burada kaldın
                    MessageBox.Show("Eski Şifre Hatalı!\n\nŞifre Değişmedi!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    string guncelle2 = "UPDATE musteri SET m_sifre=@sifre WHERE m_id=@id";
                    MySqlCommand emoli = new MySqlCommand(guncelle2, baglan);

                    emoli.Parameters.AddWithValue("@sifre", yeni.Text);
                    emoli.Parameters.AddWithValue("@id", oturum_id);


                    emoli.ExecuteNonQuery();

                    MessageBox.Show("Şifre başarıyla güncellendi!\n\nYeni Şifre: " + yeni.Text, "Bilgilendirme :", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   

                    eski.Text = "";
                    yeni.Text = "";
                }


            }

            baglan.Close();
        }
    }
}
