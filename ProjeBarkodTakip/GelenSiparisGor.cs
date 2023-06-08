 
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
    public partial class GelenSiparisGor : Form
    {
        public GelenSiparisGor()
        {
            InitializeComponent();
        }


        // MySql veritabanına balğantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        MySqlDataAdapter mda;

        DataSet ds;
 
  
        public void mus_dok()
        {

            baglan.Open();

            string cek = "SELECT*FROM siparis,musteri WHERE siparis.si_firma=musteri.m_id ORDER BY si_id DESC ";

            MySqlDataAdapter mdam = new MySqlDataAdapter(cek, baglan);
 
 
            DataSet dsm = new DataSet();

            mdam.Fill(dsm, "siparis,musteri");

            dataGridView2.DataSource = dsm.Tables[0];

            // satırların renk ayarı

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++) 
             {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                 
                if (Convert.ToInt32(dataGridView2.Rows[i].Cells["si_okundu"].Value) == 0)
                {

                    renk.BackColor = Color.LightPink;
                    renk.ForeColor = Color.Black;
                }
                else
                {

                    renk.BackColor = Color.GreenYellow;
                    renk.ForeColor = Color.Black;

                }

                dataGridView2.Rows[i].DefaultCellStyle = renk;

            }

            // renk bitti



            baglan.Close();


        }

      

        private void GelenSiparisGor_Load(object sender, EventArgs e)
        {
             
            mus_dok();
             
        }


        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //datagrid özellikleri

            dataGridView2.Columns["si_okundu"].Visible = false; // datagrid de is_id kolonunu göstermiyoruz ;)
            dataGridView2.Columns["si_ekleyen"].Visible = false; // datagrid de is_id kolonunu göstermiyoruz ;)
            dataGridView2.Columns["si_firma"].Visible = false; // datagrid de is_id kolonunu göstermiyoruz ;)
            dataGridView2.Columns["m_id"].Visible = false; // datagrid de is_id kolonunu göstermiyoruz ;)
            dataGridView2.Columns["m_adres"].Visible = false; // datagrid de is_id kolonunu göstermiyoruz ;)
            dataGridView2.Columns["m_sifre"].Visible = false; // datagrid de is_id kolonunu göstermiyoruz ;)
            dataGridView2.Columns["m_tarih"].Visible = false; // datagrid de is_id kolonunu göstermiyoruz ;)
            dataGridView2.Columns["m_tel"].Visible = false; // datagrid de is_id kolonunu göstermiyoruz ;)
            dataGridView2.Columns["m_mail"].Visible = false; // datagrid de is_id kolonunu göstermiyoruz ;)

            dataGridView2.Columns[0].Width = 60; // sütun genişliği ayarlama
                                                 // dataGridView2.Columns[1].Width = 60;
                                                 // dataGridView2.Columns[2].Width = 60;
                                                 // dataGridView2.Columns[3].Width = 300;
                                                 //dataGridView2.Columns[4].Width = 60;

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // otomatik kaplama
        }

        private void kayitTamam_Click(object sender, EventArgs e)
        {
            int g_id = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells["si_id"].Value);

            baglan.Open();

            MySqlCommand guncellewwa = new MySqlCommand("UPDATE siparis SET  si_okundu=1 WHERE si_id=@m_id", baglan);

            guncellewwa.Parameters.AddWithValue("@m_id", g_id);

            guncellewwa.ExecuteNonQuery();

            MessageBox.Show("Sipariş başarıyla KAYIT YAPILDI olarak güncellendi!", "Bilgilendirme :", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CalisanKayit ck_b = (CalisanKayit)Application.OpenForms["CalisanKayit"]; // diğer formda güncelleme yapmak için...
            ck_b.gelen_siparis_gor();
            

            baglan.Close();

            mus_dok();



        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int okunduMu = Convert.ToInt32(dataGridView2.CurrentRow.Cells[6].Value.ToString()); // id çekme kodu ;)

            if (okunduMu == 0)
            {
                //string isbasla = dataGridView2.CurrentRow.Cells[2].Value.ToString(); 
                string isbitis = dataGridView2.CurrentRow.Cells[3].Value.ToString(); // Mysqldeki siparis tablosundan 4. sütun -> si_bitis
                string isfirma = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                string isbilgi = dataGridView2.CurrentRow.Cells[5].Value.ToString();

                CalisanKayit ck_a = new CalisanKayit();
                ck_a = (CalisanKayit)Application.OpenForms["CalisanKayit"];

                ck_a.is_not.Text = "İş teslimi : " + isbitis + " - Bilgiler :"  + isbilgi;
                ck_a.urun.Text= dataGridView2.CurrentRow.Cells[8].Value.ToString();
                ck_a.i_adet.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
                ck_a.tutar.Text = dataGridView2.CurrentRow.Cells[9].Value.ToString();


                baglan.Open();

                string cekkka = "SELECT * FROM musteri WHERE m_id=@m_id ";


                MySqlCommand komutlar = new MySqlCommand(cekkka, baglan);

                komutlar.Parameters.AddWithValue("@m_id", isfirma);

                MySqlDataReader drww = komutlar.ExecuteReader();

                if (drww.Read())
                {
                    ck_a.comboBox1.SelectedValue = drww["m_id"].ToString();

                    ck_a.comboBox1.SelectedItem = drww["m_isim"].ToString();

                    ck_a.isim.Text= drww["m_isim"].ToString() + " - " + dataGridView2.CurrentRow.Cells[8].Value.ToString() + " - " + dataGridView2.CurrentRow.Cells[7].Value.ToString();

                }

                baglan.Close();
 

                //Not: Bu componentleri (i_adet.Text vb) CalisanKayit.Designer.cs 'de public yapman lazım...

            }
            else { }
        }
    }
}
