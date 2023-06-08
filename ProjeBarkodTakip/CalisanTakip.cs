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
    public partial class CalisanTakip : Form
    {
        public CalisanTakip()
        {
            InitializeComponent();
        }
        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        public int oturumTakip { get; set; }

        public string barkodNo { get; set; }


        private void CalisanTakip_Load(object sender, EventArgs e)
        {

            baglan.Open();

            string sorgu = "SELECT* FROM takip WHERE t_barkod='"+ barkodNo + "'";
 
            MySqlDataAdapter mda = new MySqlDataAdapter(sorgu, baglan);

            DataSet ds = new DataSet();

            mda.Fill(ds, "takip");

            dataGridViewCalisanTakip.DataSource = ds.Tables[0];
  
            baglan.Close();

            // notları gösterme
            baglan.Open();

            string sorgu2 = "SELECT* FROM isler WHERE is_barkod='" + barkodNo + "'";

            MySqlCommand komut = new MySqlCommand(sorgu2, baglan);

            MySqlDataReader dr = komut.ExecuteReader();


            if (dr.Read()) //Datareader ile okunan verileri form kontrollerine aktardık.
            {
                notYeri.Text = dr["is_not"].ToString();
                
            }

            baglan.Close(); 
            

        }
 

        private void dataGridViewCalisanTakip_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //datagrid özellikleri

            dataGridViewCalisanTakip.Columns["t_id"].Visible = false; // datagrid de is_id kolonunu göstermiyoruz ;)


            dataGridViewCalisanTakip.Columns[0].Width = 60; // sütun genişliği ayarlama


            dataGridViewCalisanTakip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // otomatik kaplama
        }

        private void bitti_Click(object sender, EventArgs e)
        {

            DialogResult secenek = MessageBox.Show("Bu işi BİTTİ olarak ayarlamak istiyor musunuz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {

                baglan.Open();

                string bittiYap = "UPDATE isler SET is_durum='b' WHERE is_barkod=@barkod";

                MySqlCommand mycom = new MySqlCommand(bittiYap, baglan);

                mycom.Parameters.AddWithValue("@barkod", barkodNo);

                mycom.ExecuteNonQuery();

                MessageBox.Show("iş başarıyla Bitti olarak ayarlandı!", "Bilgilendirme :", MessageBoxButtons.OK, MessageBoxIcon.Information);

                baglan.Close();

                CalisanKayit f23 = (CalisanKayit)Application.OpenForms["CalisanKayit"]; // diğer formun (Form2'nin) otomatik güncellenmesi için ;)
                f23.is_dok();
            }
            else { }
        }
    }
}
