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
    public partial class SifrePaneli : Form
    {
        public SifrePaneli()
        {
            InitializeComponent();
        }

        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");


        public int oturum_id2 { get; set; }


        public int isimVer { get; set; }



        private void SifrePaneli_Load(object sender, EventArgs e)
        {
            baglan.Open();

            string oturumCek = "SELECT*FROM Admin WHERE id=@id2";


            MySqlCommand komutlar = new MySqlCommand(oturumCek, baglan);

            komutlar.Parameters.AddWithValue("@id2", oturum_id2);

            MySqlDataReader dr = komutlar.ExecuteReader();

            if (dr.Read())
            {
                string isimK = dr["isim"].ToString();

                label7.Text = isimK;

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


                string oturumCek2 = "SELECT * FROM Admin WHERE id=@id AND sifre=@sifre";
                MySqlCommand komut = new MySqlCommand(oturumCek2, baglan);

                komut.Parameters.AddWithValue("@id", oturum_id2);
                komut.Parameters.AddWithValue("@sifre", eski.Text);
               

                // NOT NOT NOT ÖNEMLİ ÖNEMLİ ÖNEMLİ : 2 TANE DATAREADER HATA VERDİĞİ İÇİN 
                //komut'u OBJECT'E AKTARIP VAR MI YOK MU SORGULADIK!

                object emre = komut.ExecuteScalar();
                 
                if (emre==null)
                { // burada kaldın
                    MessageBox.Show("Eski Şifre Hatalı!\n\nŞifre Değişmedi!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    string guncelle2 = "UPDATE Admin SET sifre=@sifre WHERE id=@id";
                    MySqlCommand emoli = new MySqlCommand(guncelle2, baglan);

                    emoli.Parameters.AddWithValue("@sifre", yeni.Text);
                    emoli.Parameters.AddWithValue("@id", oturum_id2);


                    emoli.ExecuteNonQuery();

                    MessageBox.Show("Şifre başarıyla güncellendi!\n\nYeni Şifre: "+yeni.Text, "Bilgilendirme :", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    eski.Text = "";
                    yeni.Text = "";
                }
                 
                
            }

            baglan.Close();
           
        }

 

        


         
   
        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

  
    }
}
