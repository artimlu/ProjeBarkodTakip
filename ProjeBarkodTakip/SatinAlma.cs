 
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
    public partial class SatinAlma : Form
    {
        public SatinAlma()
        {
            InitializeComponent();
        }


        // MySql veritabanına balğantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");


        public static  int oturum_id2 { get; set; }


        public void mus_dok_satin_alma()
        {

            baglan.Open();

            string cek = "SELECT*FROM satinalma ORDER BY s_id DESC ";

            MySqlDataAdapter mdam = new MySqlDataAdapter(cek, baglan);

            DataSet dsm = new DataSet();

            mdam.Fill(dsm, "satinalma");

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

            string oturumCek = "SELECT*FROM Admin WHERE id=" + oturum_id2;
            MySqlCommand komutlar = new MySqlCommand(oturumCek, baglan);

            MySqlDataReader dr = komutlar.ExecuteReader();

            if (dr.Read())
            {
                label7.Text = dr["isim"].ToString();
 
            }

            baglan.Close();

        }

        private void SatinAlma_Load(object sender, EventArgs e)
        {
            mus_dok_satin_alma();
            kullanici_belirle();
        }


        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //datagrid özellikleri

            dataGridView2.Columns[0].Width = 50; // sütun genişliği ayarlama
            dataGridView2.Columns[1].Width = 150;
            dataGridView2.Columns[2].Width = 150;
            dataGridView2.Columns[3].Width = 150;
            dataGridView2.Columns[4].Width = 150;

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

            string cek = "SELECT*FROM satinalma WHERE s_urun LIKE @kelime ";
 
            MySqlCommand mykomi = new MySqlCommand(cek, baglan);

            mykomi.Parameters.AddWithValue("@kelime", "%"+textBox1.Text+"%");

            MySqlDataAdapter mda = new MySqlDataAdapter(mykomi);

            DataSet ds = new DataSet();

            mda.Fill(ds, "satinalma");

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
            mus_dok_satin_alma();
        }

        private void isler_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Close();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Bu Satın Almayı Silmek istiyor musunuz?", "Satın Alma Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dataGridView2.SelectedRows)  //Seçili Satırları Silme
                {
                    int numara = Convert.ToInt32(drow.Cells[0].Value);

                    baglan.Open();


                    MySqlCommand silelim = new MySqlCommand("DELETE FROM satinalma WHERE s_id=@numm", baglan);
                    
                    silelim.Parameters.AddWithValue("@numm", numara);
                    

                    silelim.ExecuteNonQuery();

                    MessageBox.Show("Ürün  başarıyla silindi!", "Bilgilendirme :");

                    baglan.Close();

                }

                mus_dok_satin_alma();
            }
            else if (secenek == DialogResult.No)
            {

            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            int g_id = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells["s_id"].Value);

            SatinAlmaguncelle csa = new SatinAlmaguncelle();

            csa.guncelle_id = g_id; // ÖNEMli: guncelle_id'yi Form5 te oluştur ve burada seçili olan id'yi ona ata ;) sonra form5 te çağır...

            csa.Show();  // form5 göster diyoruz
        }

        private void is_ekle_Click(object sender, EventArgs e)
        {
            if (isim.Text.Length == 0 || tel.Text.Length == 0 || mail.Text.Length == 0 || adres.Text.Length == 0  )
            {
                MessageBox.Show("Boş Alan Bırakmayınız!","Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                baglan.Open();
 
                string yil = DateTime.Now.ToShortDateString(); // gün.ay.yil olarak verir
         
                MySqlCommand ekle = new MySqlCommand("INSERT INTO satinalma (s_urun,s_firma,s_ac,s_tarih,s_fiyat) VALUES (@m_isim,@m_tel,@m_adres,@m_tarih,@m_mail)", baglan);

                ekle.Parameters.AddWithValue("@m_isim", isim.Text);
                ekle.Parameters.AddWithValue("@m_tel", tel.Text);
                ekle.Parameters.AddWithValue("@m_adres", adres.Text);
                ekle.Parameters.AddWithValue("@m_tarih", yil);
                ekle.Parameters.AddWithValue("@m_mail", mail.Text);
                  
                ekle.ExecuteNonQuery();

                MessageBox.Show("Yeni Satın Alma başarıyla eklendi!","Bilgilendirme : ",MessageBoxButtons.OK,MessageBoxIcon.Information);

                isim.Text = "";
                tel.Text = "";
                adres.Text = "";
                mail.Text = "";

                baglan.Close();

                mus_dok_satin_alma();
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
            SifrePaneli sifrePan = new SifrePaneli();

            sifrePan.oturum_id2 = oturum_id2;

            sifrePan.Show();
        }


        private void istasyon_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();

            Form7.oturum_id2 = oturum_id2;

            form7.Show();

            this.Close();
        }
        private void isler_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Close();
        }

        private void musteriler_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            Form4.oturum_id2 = oturum_id2;

            form4.Show();

            this.Close();
        }

        private void kullanici_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();

            Form9.oturum_id2 = oturum_id2;

            form9.Show();

            this.Close();
        }

        private void muhasebe_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();

            Form11.oturum_id2 = oturum_id2;

            form11.Show();

            this.Close();
        }

     
        private void DepoGit_Click(object sender, EventArgs e)
        {
            Depo depoo = new Depo();

            Depo.oturum_id2 = oturum_id2;

            depoo.Show();

            this.Close();

        }

        private void satinAl_Click(object sender, EventArgs e)
        {

            SatinAlma satinAlma = new SatinAlma();

            SatinAlma.oturum_id2 = oturum_id2;

            satinAlma.Show();

            this.Close();

        }
    }
}
