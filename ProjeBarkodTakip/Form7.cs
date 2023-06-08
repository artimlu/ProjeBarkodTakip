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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        public static int oturum_id2 { get; set; }
        public void ist_dok()
        {

            baglan.Open();

            string cek = "SELECT*FROM istasyon WHERE ist_id NOT IN (3,4,5,6,7,8)  ORDER BY ist_isim ASC ";

            MySqlDataAdapter mdam = new MySqlDataAdapter(cek, baglan);

            DataSet dsm = new DataSet();

            mdam.Fill(dsm, "istasyon");

            dataGridView4.DataSource = dsm.Tables[0];

            // satırların renk ayarı
            for (int i = 0; i < dataGridView4.Rows.Count - 1; i++)
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

                dataGridView4.Rows[i].DefaultCellStyle = renk;
            }

            // renk bitti


            baglan.Close();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adres_TextChanged(object sender, EventArgs e)
        {

        }

        private void is_ekle_Click(object sender, EventArgs e)
        {
            if (isim.Text.Length == 0)
            {
                MessageBox.Show("İstasyon Adını Doldurunuz!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                baglan.Open();
 
                MySqlCommand ekle = new MySqlCommand("INSERT INTO istasyon (ist_isim,ist_ac) VALUES (@isim,@tel)", baglan);

                ekle.Parameters.AddWithValue("@isim", isim.Text);
                ekle.Parameters.AddWithValue("@tel", ac.Text);
                

                ekle.ExecuteNonQuery();

                MessageBox.Show("Yeni istasyon başarıyla eklendi!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isim.Text = "";
               
                ac.Text = "";
                 

                baglan.Close();

                ist_dok();
            }
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            ist_dok();
        }

        private void ara_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string kelime = textBox1.Text;

            string cek2 = "SELECT*FROM istasyon WHERE ist_id NOT IN (3,4,5,6,7,8) AND ist_isim LIKE  @kelime ";


            MySqlCommand mykomi = new MySqlCommand(cek2, baglan);
            mykomi.Parameters.AddWithValue("@kelime", "%"+textBox1.Text+"%");

            MySqlDataAdapter mda2 = new MySqlDataAdapter(mykomi);

            DataSet ds2 = new DataSet();

            mda2.Fill(ds2, "istasyon");

            dataGridView4.DataSource = ds2.Tables[0];

            // satırların renk ayarı
            for (int j = 0; j < dataGridView4.Rows.Count - 1; j++)
            {
                Application.DoEvents();

                int sayiHesap = j % 2;

                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if (sayiHesap != 0)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                else if (sayiHesap == 0)
                {
                    renk.BackColor = Color.Pink;
                }

                dataGridView4.Rows[j].DefaultCellStyle = renk;
            }

            // renk bitti

            baglan.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }


        private void dataGridView4_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //datagrid özellikleri

            dataGridView4.Columns["ist_id"].Visible = false; // datagrid de is_id kolonunu göstermiyoruz ;)
            


            dataGridView4.Columns[0].Width = 60; // sütun genişliği ayarlama
           
            

            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // otomatik kaplama
        }

        private void sil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Bu istasyonu silerseniz, daha önce yapılan işlerde bu istasyon gözükmeyecektir!\n\nBu istasyonu yine de silmek istiyor musunuz?", "İstasyon Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dataGridView4.SelectedRows)  //Seçili Satırları Silme
                {
                    int numara = Convert.ToInt32(drow.Cells[0].Value);

                    baglan.Open();


                    MySqlCommand silelim = new MySqlCommand("DELETE FROM istasyon WHERE ist_id=" + numara, baglan);

                    silelim.ExecuteNonQuery();

                    MessageBox.Show("İstasyon başarıyla silindi!", "Bilgilendirme :");

                    baglan.Close();

                }

                ist_dok();
            }
            else if (secenek == DialogResult.No)
            {

            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            int g_id = Convert.ToInt32(dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells["ist_id"].Value);

            Form8 form8 = new Form8();

            form8.guncelle_id = g_id; // ÖNEMli: guncelle_id'yi Form5 te oluştur ve burada seçili olan id'yi ona ata ;) sonra form5 te çağır...

            form8.Show();  // form5 göster diyoruz
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

        private void Form7_Load(object sender, EventArgs e)
        {
            ist_dok();
            kullanici_belirle();
        }

        private void kullanici_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();

            Form9.oturum_id2 = oturum_id2;

            form9.Show();

            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void isler_Click(object sender, EventArgs e)
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

        private void istasyon_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            Form7.oturum_id2 = oturum_id2;

            form7.Show();

            this.Close();
        }

        private void muhasebe_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();

            Form11.oturum_id2 = oturum_id2;

            form11.Show();

            this.Close();
        }
 
 
        private void sifre_Click(object sender, EventArgs e)
        {
            SifrePaneli sifrePan = new SifrePaneli();

            sifrePan.Show();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SifrePaneli sifrePan = new SifrePaneli();

            sifrePan.oturum_id2 = oturum_id2;



            sifrePan.Show();
        }

        private void cikis_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();

            this.Close();
            //Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void satinAl_Click(object sender, EventArgs e)
        {

            SatinAlma satinAlma = new SatinAlma();

            SatinAlma.oturum_id2 = oturum_id2;

            satinAlma.Show();

            this.Close();

        }

        private void DepoGit_Click(object sender, EventArgs e)
        {
            Depo depoo = new Depo();

            Depo.oturum_id2 = oturum_id2;

            depoo.Show();

            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
