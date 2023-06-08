using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace is_takibi
{
    public partial class CSAguncelle : Form
    {
        public CSAguncelle()
        {
            InitializeComponent();
        }

        public int guncelle_id { get; set; }

        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        MySqlDataAdapter mda;

        private void CSAguncelle_Load(object sender, EventArgs e)
        {

            baglan.Open();

            string cek = "SELECT*FROM satinalma WHERE s_id=@m_id";

            MySqlCommand komut = new MySqlCommand(cek, baglan);

            komut.Parameters.AddWithValue("@m_id", guncelle_id);

            mda = new MySqlDataAdapter(komut);

            MySqlDataReader dr = komut.ExecuteReader();


            if (dr.Read()) //Datareader ile okunan verileri form kontrollerine aktardık.
            {
                isim.Text = dr["s_urun"].ToString();
                tel.Text = dr["s_firma"].ToString();
                adres.Text = dr["s_ac"].ToString();
                mail.Text = dr["s_fiyat"].ToString();
                not.Text= dr["s_tarih"].ToString();
               

            }

            baglan.Close();

        }

        private void guncelle_Click(object sender, EventArgs e)
        {

            if (isim.Text.Length == 0 || tel.Text.Length == 0 || adres.Text.Length == 0 || mail.Text.Length == 0)
            {
                MessageBox.Show("Boş Alan Bırakmayınız!\n\n Güncelleme Başarısız!", "Bilglendirme :",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else
            {

                baglan.Open();

                MySqlCommand guncelleww = new MySqlCommand("UPDATE satinalma SET s_urun=@m_isim, s_firma=@m_tel, s_ac=@m_adres, s_fiyat=@m_mail WHERE s_id=@m_id", baglan);


                guncelleww.Parameters.AddWithValue("@m_isim", isim.Text);
                guncelleww.Parameters.AddWithValue("@m_tel", tel.Text);
                guncelleww.Parameters.AddWithValue("@m_adres", adres.Text);
                guncelleww.Parameters.AddWithValue("@m_mail", mail.Text);
                guncelleww.Parameters.AddWithValue("@m_id", guncelle_id);


                guncelleww.ExecuteNonQuery();

                MessageBox.Show("Satın Alma başarıyla güncellendi!", "Bilgilendirme :", MessageBoxButtons.OK, MessageBoxIcon.Information);

                baglan.Close();


                CalisanSatinAlma ccc = (CalisanSatinAlma)Application.OpenForms["CalisanSatinAlma"]; // diğer formun (Form4'ün) otomatik güncellenmesi için ;)
                ccc.mus_dok();

            }
        }
    }
}
