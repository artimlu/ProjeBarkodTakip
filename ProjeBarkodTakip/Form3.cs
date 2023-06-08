 
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public int guncelle_id { get; set; }

        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        MySqlDataAdapter mda;

        


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void isim_TextChanged(object sender, EventArgs e)
        {
             


        }

     
        private void Form3_Load(object sender, EventArgs e)
        {
            baglan.Open();
            // combobox için

            string cek3 = "SELECT * FROM musteri ";

            MySqlDataAdapter mda3 = new MySqlDataAdapter(cek3, baglan);

            DataSet ds3 = new DataSet();

            mda3.Fill(ds3, "musteri"); // deneme isimli database deki musteri isimli tablo

            comboBox1.ValueMember = "m_id";

            comboBox1.DisplayMember = "m_isim"; // musteri ismindeki tablodaki, m_isim isimli sütun (isimleri çekiyoruz)

            comboBox1.DataSource = ds3.Tables[0];

            //buraya kadar


           

            string cek="SELECT*FROM isler WHERE is_id=@g_idd";

            MySqlCommand komut = new MySqlCommand(cek, baglan);

            komut.Parameters.AddWithValue("@g_idd", guncelle_id);
            

            mda = new MySqlDataAdapter(komut);

            MySqlDataReader dr = komut.ExecuteReader();

         
            if (dr.Read()) //Datareader ile okunan verileri form kontrollerine aktardık.
            {
                isim.Text = dr["is_adi"].ToString();
                tutar.Text = dr["is_tutar"].ToString();
                i_urunn.Text = dr["is_urun"].ToString();
                textBox1.Text = dr["is_not"].ToString();
                i_adett.Text = dr["is_adet"].ToString();

                //combobox daki seçili olan veriyi selectvalue ile veriyoruz...
                int mus_id = (int)dr["is_mus"];

                comboBox1.SelectedValue = mus_id;

            }

            baglan.Close();

        }

        private void tarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            //combpobox da seçili değerin id'sini almak için gerekli kod. string-> int     ;)
            string id_s = comboBox1.SelectedValue.ToString();

            int id_m_al = Int32.Parse(id_s);
            // bu kod bu kadar 


            if (isim.Text.Length == 0 || tutar.Text.Length == 0 || i_urunn.Text.Length == 0 || i_adett.Text.Length == 0)
            {
                MessageBox.Show("Boş alan bırakmayınız!\n\n Güncelleme Yapılmadı", "Uyarı Penceresi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else
            {

                baglan.Open();

                MySqlCommand guncelleww = new MySqlCommand("UPDATE isler SET is_adi=@is_adi, is_urun=@is_urun, is_tutar=@is_tutar, is_mus=@is_mus, is_not=@is_not, is_adet=@is_adet WHERE is_id=@is_id", baglan);

                guncelleww.Parameters.AddWithValue("@is_adi", isim.Text);
                guncelleww.Parameters.AddWithValue("@is_tutar", tutar.Text);
                guncelleww.Parameters.AddWithValue("@is_urun",i_urunn.Text);
                guncelleww.Parameters.AddWithValue("@is_mus", id_m_al);
                guncelleww.Parameters.AddWithValue("@is_not", textBox1.Text);
                guncelleww.Parameters.AddWithValue("@is_id", guncelle_id);
                guncelleww.Parameters.AddWithValue("@is_adet", i_adett.Text);


                guncelleww.ExecuteNonQuery();

                MessageBox.Show("İş başarıyla güncellendi!", "Bilgilendirme :", MessageBoxButtons.OK, MessageBoxIcon.Information);

                baglan.Close();


                Form2 f2 = (Form2)Application.OpenForms["Form2"]; // diğer formun (Form2'nin) otomatik güncellenmesi için ;)
                f2.is_dok();

            }
        }

        private void tutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
