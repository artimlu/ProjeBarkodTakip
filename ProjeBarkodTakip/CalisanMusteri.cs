 
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
    public partial class CalisanMusteri : Form
    {
        public CalisanMusteri()
        {
            InitializeComponent();
        }


        // MySql veritabanına balğantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        MySqlDataAdapter mda;

        DataSet ds;

        public static  int oturum_id2 { get; set; }


        public void mus_dok()
        {

            baglan.Open();

            string cek = "SELECT*FROM siparis,musteri WHERE siparis.si_firma=musteri.m_id AND si_ekleyen=@si_ekleyen ORDER BY si_id DESC ";

            MySqlDataAdapter mdam = new MySqlDataAdapter(cek, baglan);

            mdam.SelectCommand.Parameters.AddWithValue("@si_ekleyen", oturum_id2);
 
            DataSet dsm = new DataSet();

            mdam.Fill(dsm, "siparis,musteri");

            dataGridView2.DataSource = dsm.Tables[0];

            // satırların renk ayarı
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                Application.DoEvents();

                int sayiHesap = i % 2;

                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if (sayiHesap != 0)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                else if (sayiHesap == 0)
                {
                    renk.BackColor = Color.Pink;
                }

                dataGridView2.Rows[i].DefaultCellStyle = renk;
            }

            // renk bitti



            baglan.Close();


        }

        public void kullanici_belirle()
        {

            baglan.Open();

            string oturumCek = "SELECT*FROM calisan WHERE c_id=" + oturum_id2;
            MySqlCommand komutlar = new MySqlCommand(oturumCek, baglan);

            MySqlDataReader dr = komutlar.ExecuteReader();

            if (dr.Read())
            {
                label7.Text = dr["c_isim"].ToString();
 
            }


            baglan.Close();


        }

        private void CalisanMusteri_Load(object sender, EventArgs e)
        {
            musteri_dok();
            mus_dok();
            kullanici_belirle();
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
            dataGridView2.Columns["m_mail"].Visible = false; // datagrid de is_id kolonunu göstermiyoruz ;)




            dataGridView2.Columns[0].Width = 60; // sütun genişliği ayarlama
                                                 // dataGridView2.Columns[1].Width = 60;
                                                 // dataGridView2.Columns[2].Width = 60;
                                                 // dataGridView2.Columns[3].Width = 300;
                                                 //dataGridView2.Columns[4].Width = 60;

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // otomatik kaplama
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void ara_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string kelime = textBox1.Text;

            string cek = "SELECT*FROM siparis,musteri WHERE siparis.si_firma=musteri.m_id AND si_ekleyen=@si_ekleyen  AND si_bilgi LIKE @kelime ";
 

            MySqlCommand mykomi = new MySqlCommand(cek, baglan);
            mykomi.Parameters.AddWithValue("@kelime", "%"+textBox1.Text+"%");
            mykomi.Parameters.AddWithValue("@si_ekleyen", oturum_id2);
             
            MySqlDataAdapter mda = new MySqlDataAdapter(mykomi);

            DataSet ds = new DataSet();

            mda.Fill(ds, "siparis,musteri");

            dataGridView2.DataSource = ds.Tables[0];

            // satırların renk ayarı
            for (int j = 0; j < dataGridView2.Rows.Count - 1; j++)
            {
                Application.DoEvents();

                int sayiHesapj = j % 2;

                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if (sayiHesapj != 0)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                else if (sayiHesapj == 0)
                {
                    renk.BackColor = Color.Pink;
                }

                dataGridView2.Rows[j].DefaultCellStyle = renk;
            }

            // renk bitti

            baglan.Close();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            mus_dok();
        }

        private void isler_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Close();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Bu siparişi silmek istiyor musunuz?", "Müşteri Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dataGridView2.SelectedRows)  //Seçili Satırları Silme
                {
                    int numara = Convert.ToInt32(drow.Cells[0].Value);

                    baglan.Open();


                    MySqlCommand silelim = new MySqlCommand("DELETE FROM siparis WHERE si_id=@numm", baglan);
                    
                    silelim.Parameters.AddWithValue("@numm", numara);
                    

                    silelim.ExecuteNonQuery();

                    MessageBox.Show("Sipariş başarıyla silindi!", "Bilgilendirme :");

                    baglan.Close();

                }

                mus_dok();
            }
            else if (secenek == DialogResult.No)
            {

            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            int g_id = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells["si_id"].Value);

            CMguncelle cmggg = new CMguncelle();

            cmggg.guncelle_id = g_id; // ÖNEMli: guncelle_id'yi Form5 te oluştur ve burada seçili olan id'yi ona ata ;) sonra form5 te çağır...

            cmggg.Show();  // form5 göster diyoruz
        }

        private void is_ekle_Click(object sender, EventArgs e)
        {
            if (adres.Text.Length == 0 || siAdet.Text.Length==0 || siFiyat.Text.Length == 0 || siUrun.Text.Length == 0  )
            {
                MessageBox.Show("Boş Alan Bırakmayınız!","Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                baglan.Open();


             

                MySqlCommand ekle = new MySqlCommand("INSERT INTO siparis (si_ekleyen,si_baslangic,si_bitis,si_firma,si_bilgi,si_fiyat,si_urun,si_adet) VALUES (@si_ekleyen,@si_baslangic,@si_bitis,@si_firma,@m_adres,@fiyat,@urun,@adet)", baglan);

 
                
                ekle.Parameters.AddWithValue("@m_adres", adres.Text);
                ekle.Parameters.AddWithValue("@si_baslangic", baslangic.Text);
                ekle.Parameters.AddWithValue("@si_bitis", bitis.Text); 
                ekle.Parameters.AddWithValue("@si_ekleyen", oturum_id2);
                ekle.Parameters.AddWithValue("@si_firma", comboBox1.SelectedValue);
                ekle.Parameters.AddWithValue("@fiyat", siFiyat.Text);
                ekle.Parameters.AddWithValue("@urun", siUrun.Text);
                ekle.Parameters.AddWithValue("@adet", siAdet.Text);


                ekle.ExecuteNonQuery();

                MessageBox.Show("Yeni Sipariş başarıyla eklendi!","Bilgilendirme : ",MessageBoxButtons.OK,MessageBoxIcon.Information);


                adres.Text = "";
                siAdet.Text = "";
                siFiyat.Text = "";
                siUrun.Text = "";

                baglan.Close();

                mus_dok();
            }
        }

        

       
        private void cikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            //Application.Exit();
        }

        private void sifre_Click_1(object sender, EventArgs e)
        {
            SifrePaneliCalisan sifrePan = new SifrePaneliCalisan();

            sifrePan.oturum_id2 = oturum_id2;



            sifrePan.Show();
        }


        private void musteri_dok()
        {

            baglan.Open();

            string cek = "SELECT * FROM musteri ";

            mda = new MySqlDataAdapter(cek, baglan);

            ds = new DataSet();

            mda.Fill(ds, "musteri"); // deneme isimli database deki musteri isimli tablo

            comboBox1.ValueMember = "m_id";

            comboBox1.DisplayMember = "m_isim"; // musteri ismindeki tablodaki, m_isim isimli sütun (isimleri çekiyoruz)

            comboBox1.DataSource = ds.Tables[0];

            baglan.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
