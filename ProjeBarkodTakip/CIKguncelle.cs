using System.Data.OleDb;
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
    public partial class CIKguncelle : Form
    {
        public CIKguncelle()
        {
            InitializeComponent();
        }

        public int guncelle_id { get; set; }

        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        MySqlDataAdapter mda;
 
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CIKguncelle_Load(object sender, EventArgs e)
        {
            baglan.Open();
            // combobox için istasyon bilgileri

            string cek3 = "SELECT * FROM istasyon ";

            MySqlDataAdapter mda3 = new MySqlDataAdapter(cek3, baglan);

            DataSet ds3 = new DataSet();

            mda3.Fill(ds3, "istasyon");

            comboBox1.ValueMember = "ist_id";

            comboBox1.DisplayMember = "ist_isim";

            comboBox1.DataSource = ds3.Tables[0];

            //buraya kadar




            string cek = "SELECT*FROM calisan WHERE c_id=@cid";

            MySqlCommand komut = new MySqlCommand(cek, baglan);
          
            komut.Parameters.AddWithValue("@cid", guncelle_id);
            

            mda = new MySqlDataAdapter(komut);

            MySqlDataReader dr = komut.ExecuteReader();


            if (dr.Read()) //Datareader ile okunan verileri form kontrollerine aktardık.
            {
                isim.Text = dr["c_isim"].ToString();
                bilgi.Text = dr["c_bilgi"].ToString();
                tarih.Text = dr["c_yil"].ToString();
                tc_no.Text = dr["c_tc"].ToString();

                label6.Text = dr["c_sifre"].ToString();

                //combobox daki seçili olan veriyi selectvalue ile veriyoruz...
                int c_ist_id = (int)dr["c_ist_id"];

                comboBox1.SelectedValue = c_ist_id;

            }

            baglan.Close();

        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (isim.Text.Length == 0 || tc_no.Text.Length == 0)
            {
                MessageBox.Show("Boş Alan Bırakmayınız!");
            }

            else
            {

                string id_s = comboBox1.SelectedValue.ToString();

                int id_m_al = Int32.Parse(id_s);

                baglan.Open();

                MySqlCommand guncelleww = new MySqlCommand("UPDATE calisan SET c_isim=@isim, c_bilgi=@bilgi, c_ist_id=@cistId, c_tc=@tcc WHERE c_id=@cId", baglan);


                guncelleww.Parameters.AddWithValue("@isim", isim.Text);
                guncelleww.Parameters.AddWithValue("@bilgi", bilgi.Text);
                guncelleww.Parameters.AddWithValue("@cistId", id_m_al);
                guncelleww.Parameters.AddWithValue("@cId", guncelle_id);
                guncelleww.Parameters.AddWithValue("@tcc", tc_no.Text);


                guncelleww.ExecuteNonQuery();

                MessageBox.Show("Çalışan başarıyla güncellendi!", "Bilgilendirme :", MessageBoxButtons.OK, MessageBoxIcon.Information);

                baglan.Close();


                CalisanIK cikk = (CalisanIK)Application.OpenForms["CalisanIK"]; // diğer formun (Form2'nin) otomatik güncellenmesi için ;)
                cikk.cal_dok();

            }
        }

        private void tarih_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
