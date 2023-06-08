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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public int guncelle_id { get; set; }

        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        MySqlDataAdapter mda;

        private void Form5_Load(object sender, EventArgs e)
        {

            baglan.Open();

            string cek = "SELECT*FROM musteri WHERE m_id=@m_id";

            MySqlCommand komut = new MySqlCommand(cek, baglan);

            komut.Parameters.AddWithValue("@m_id", guncelle_id);

            mda = new MySqlDataAdapter(komut);

            MySqlDataReader dr = komut.ExecuteReader();


            if (dr.Read()) //Datareader ile okunan verileri form kontrollerine aktardık.
            {
                isim.Text = dr["m_isim"].ToString();
                tel.Text = dr["m_tel"].ToString();
                adres.Text = dr["m_adres"].ToString();
                mail.Text = dr["m_mail"].ToString();
                not.Text= dr["m_tarih"].ToString();
                label7.Text = dr["m_sifre"].ToString();

            }

            baglan.Close();

        }

        private void guncelle_Click(object sender, EventArgs e)
        {

            if (isim.Text.Length == 0 || tel.Text.Length == 0 || adres.Text.Length == 0 )
            {
                MessageBox.Show("Boş Alan Bırakmayınız!\n\n Güncelleme Başarısız!", "Bilglendirme :",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else
            {

                baglan.Open();

                MySqlCommand guncelleww = new MySqlCommand("UPDATE musteri SET m_isim=@m_isim, m_tel=@m_tel, m_adres=@m_adres, m_mail=@m_mail WHERE m_id=@m_id", baglan);


                guncelleww.Parameters.AddWithValue("@m_isim", isim.Text);
                guncelleww.Parameters.AddWithValue("@m_tel", tel.Text);
                guncelleww.Parameters.AddWithValue("@m_adres", adres.Text);
                guncelleww.Parameters.AddWithValue("@m_mail", mail.Text);
                guncelleww.Parameters.AddWithValue("@m_id", guncelle_id);


                guncelleww.ExecuteNonQuery();

                MessageBox.Show("Müşteri başarıyla güncellendi!", "Bilgilendirme :", MessageBoxButtons.OK, MessageBoxIcon.Information);

                baglan.Close();


                Form4 f4 = (Form4)Application.OpenForms["Form4"]; // diğer formun (Form4'ün) otomatik güncellenmesi için ;)
                f4.mus_dok();

            }
        }
    }
}
