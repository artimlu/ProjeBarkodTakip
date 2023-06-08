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
    public partial class CMguncelle : Form
    {
        public CMguncelle()
        {
            InitializeComponent();
        }

        public int guncelle_id { get; set; }

        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        MySqlDataAdapter mda;

        private void CMguncelle_Load(object sender, EventArgs e)
        {

            baglan.Open();

            string cek = "SELECT*FROM siparis WHERE si_id=@m_id";

            MySqlCommand komut = new MySqlCommand(cek, baglan);

            komut.Parameters.AddWithValue("@m_id", guncelle_id);

            mda = new MySqlDataAdapter(komut);

            MySqlDataReader dr = komut.ExecuteReader();


            if (dr.Read()) //Datareader ile okunan verileri form kontrollerine aktardık.
            {
              
                bilgi.Text = dr["si_bilgi"].ToString();
                sUrun.Text = dr["si_urun"].ToString();
                sFiyat.Text = dr["si_fiyat"].ToString();
                sAdet.Text = dr["si_adet"].ToString();
            }

            baglan.Close();

        }

        private void guncelle_Click(object sender, EventArgs e)
        {

            if ( bilgi.Text.Length == 0 || sebep.Text.Length==0 || sFiyat.Text.Length == 0 || sUrun.Text.Length == 0 || sAdet.Text.Length ==0)
            {
                MessageBox.Show("Boş Alan Bırakmayınız!\n\n Güncelleme Başarısız!", "Bilglendirme :",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else
            {

                String yeniBilgi = bilgi.Text + " --- Güncelleme Sebebi: " + sebep.Text+ " - Güncelleme Tarihi: "+ DateTime.Now + " ---" ;

                baglan.Open();

                MySqlCommand guncelleww = new MySqlCommand("UPDATE siparis SET  si_bilgi=@ybilgi, si_urun=@urun , si_fiyat=@fiyat , si_adet=@adet WHERE si_id=@m_id", baglan);
 
                guncelleww.Parameters.AddWithValue("@ybilgi", yeniBilgi);
                
                guncelleww.Parameters.AddWithValue("@m_id", guncelle_id);

                guncelleww.Parameters.AddWithValue("@urun", sUrun.Text);

                guncelleww.Parameters.AddWithValue("@fiyat", sFiyat.Text);

                guncelleww.Parameters.AddWithValue("@adet", sAdet.Text);


                guncelleww.ExecuteNonQuery();

                MessageBox.Show("Sipariş başarıyla güncellendi!", "Bilgilendirme :", MessageBoxButtons.OK, MessageBoxIcon.Information);

                baglan.Close();


                CalisanMusteri cmus = (CalisanMusteri)Application.OpenForms["CalisanMusteri"]; // diğer formun (Form4'ün) otomatik güncellenmesi için ;)
                cmus.mus_dok();

            }
        }
    }
}
