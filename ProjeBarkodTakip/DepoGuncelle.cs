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
    public partial class DepoGuncelle : Form
    {
        public DepoGuncelle ()
        {
            InitializeComponent();
        }

        public int guncelle_id { get; set; }

        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        MySqlDataAdapter mda;

        private void DepoGuncelle_Load(object sender, EventArgs e)
        {

            baglan.Open();

            string cek = "SELECT*FROM depo WHERE d_id=@d_id";

            MySqlCommand komut = new MySqlCommand(cek, baglan);

            komut.Parameters.AddWithValue("@d_id", guncelle_id);

            mda = new MySqlDataAdapter(komut);

            MySqlDataReader dr = komut.ExecuteReader();


            if (dr.Read()) //Datareader ile okunan verileri form kontrollerine aktardık.
            {
                isim.Text = dr["d_urun"].ToString();
                
                mail.Text = dr["d_adet"].ToString();
                not.Text= dr["d_tarih"].ToString();

                d_aciklamaD.Text = dr["d_aciklama"].ToString();


            }

            baglan.Close();

        }

        private void guncelle_Click(object sender, EventArgs e)
        {

            if (isim.Text.Length == 0 ||   mail.Text.Length == 0 || d_aciklamaD.Text.Length == 0)
            {
                MessageBox.Show("Boş Alan Bırakmayınız!\n\n Güncelleme Başarısız!", "Bilglendirme :",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else
            {

                baglan.Open();

                MySqlCommand guncelleww = new MySqlCommand("UPDATE depo SET d_urun=@m_isim, d_adet=@m_mail, d_tarih=@d_tarihh, d_aciklama=@aciklama WHERE d_id=@m_id", baglan);

                guncelleww.Parameters.AddWithValue("@m_isim", isim.Text);
                 
                guncelleww.Parameters.AddWithValue("@m_mail", mail.Text);

                guncelleww.Parameters.AddWithValue("@m_id", guncelle_id);

                guncelleww.Parameters.AddWithValue("@aciklama", d_aciklamaD.Text);

                string yil = DateTime.Now.ToShortDateString(); // gün.ay.yil olarak verir

                guncelleww.Parameters.AddWithValue("@d_tarihh", yil);

                guncelleww.ExecuteNonQuery();

                MessageBox.Show("Depo başarıyla güncellendi!", "Bilgilendirme :", MessageBoxButtons.OK, MessageBoxIcon.Information);

                baglan.Close();

                Depo cccc = (Depo)Application.OpenForms["Depo"]; // diğer formun (Depo'nun) otomatik güncellenmesi için ;)
                
                cccc.mus_dok();

            }
        }
    }
}
