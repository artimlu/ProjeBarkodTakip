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
    public partial class muhGuncelle : Form
    {
        public muhGuncelle()
        {
            InitializeComponent();
        }

        public int guncelle_id { get; set; }

        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        MySqlDataAdapter mda;


        private void muhGuncelle_Load(object sender, EventArgs e)
        {
            baglan.Open();

            string cek = "SELECT*FROM muhasebe WHERE muh_id=@kelime";

            MySqlCommand komut = new MySqlCommand(cek, baglan);

            komut.Parameters.AddWithValue("@kelime", guncelle_id);

            mda = new MySqlDataAdapter(komut);

            MySqlDataReader dr = komut.ExecuteReader();


            if (dr.Read()) //Datareader ile okunan verileri form kontrollerine aktardık.
            {
                notM.Text = dr["muh_not"].ToString();
              
            }

            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (notM.Text.Length == 0)
            {
                MessageBox.Show("Boş Bırakmayınız!");
            }

            else
            {

                baglan.Open();

                MySqlCommand guncelleww = new MySqlCommand("UPDATE muhasebe SET muh_not=@muh_not WHERE muh_id=@muh_id ", baglan);


                guncelleww.Parameters.AddWithValue("@muh_not", notM.Text);
                guncelleww.Parameters.AddWithValue("@muh_id", guncelle_id);
                 
 
                guncelleww.ExecuteNonQuery();

                MessageBox.Show("Not başarıyla güncellendi!", "Bilgilendirme :", MessageBoxButtons.OK, MessageBoxIcon.Information);

                baglan.Close();


                Form11 f11 = (Form11)Application.OpenForms["Form11"]; // diğer formun (Form2'nin) otomatik güncellenmesi için ;)
                f11.muhasebe_dok();

            }
        }
    }
}
