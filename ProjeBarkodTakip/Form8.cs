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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        public int guncelle_id { get; set; }

        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        MySqlDataAdapter mda;

        private void Form8_Load(object sender, EventArgs e)
        {
            baglan.Open();

            string cek = "SELECT*FROM istasyon WHERE ist_id=@ist_id";

            MySqlCommand komut = new MySqlCommand(cek, baglan);

            komut.Parameters.AddWithValue("@ist_id", guncelle_id);

            mda = new MySqlDataAdapter(komut);

            MySqlDataReader dr = komut.ExecuteReader();


            if (dr.Read()) //Datareader ile okunan verileri form kontrollerine aktardık.
            {
                isim.Text = dr["ist_isim"].ToString();
                
                adres.Text = dr["ist_ac"].ToString();
                

            }

            baglan.Close();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (isim.Text.Length == 0)
            {
                MessageBox.Show("İstasyon Adını Doldurunuz!\n\nGüncelleme Yapılamadı!", "Bilglendirme :",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else
            { 
                  baglan.Open();

                  string sorgucu = "UPDATE istasyon SET ist_isim='" + isim.Text + "', ist_ac= '" + adres.Text + "' WHERE ist_id= " + guncelle_id ;

                  MySqlCommand guncelle22 = new MySqlCommand(sorgucu, baglan);

                /*  guncelle22.Parameters.AddWithValue("@ist_isim", isim.Text);
                  guncelle22.Parameters.AddWithValue("@ist_id", guncelle_id);
                  guncelle22.Parameters.AddWithValue("@ist_ac", adres.Text);*/

                guncelle22.ExecuteNonQuery();

                  MessageBox.Show("İstasyon başarıyla güncellendi!", "Bilgilendirme :", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  baglan.Close();

                  Form7 f7 = (Form7)Application.OpenForms["Form7"]; // diğer formun (Form7'nin) otomatik güncellenmesi için ;)
                  f7.ist_dok();
                
            }
        }
    }
}
