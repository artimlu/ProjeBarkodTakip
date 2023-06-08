 
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
    public partial class CalisanDepo: Form
    {
        public CalisanDepo()
        {
            InitializeComponent();
        }


        // MySql veritabanına balğantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");


        public static  int oturum_id2 { get; set; }


        public void mus_dok()
        {

            baglan.Open();

            string cek = "SELECT*FROM depo ORDER BY d_id DESC ";

            MySqlDataAdapter mdam = new MySqlDataAdapter(cek, baglan);

            DataSet dsm = new DataSet();

            mdam.Fill(dsm, "depo");

            dataGridView2.DataSource = dsm.Tables[0];

            // datagrid satır renkllendirme

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                Application.DoEvents();
                // Math.DivRem(i, 2, out sayi);
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToInt32(dataGridView2.Rows[i].Cells["d_adet"].Value) <= 5)
                {
                    renk.BackColor = Color.Red;
                }
                else  
                {
                    renk.BackColor = Color.YellowGreen;
                }

                dataGridView2.Rows[i].DefaultCellStyle = renk;
            }
            // renklendirme son



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

        private void CalisanDepo_Load(object sender, EventArgs e)
        {
            mus_dok();
            kullanici_belirle();
        }


        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //datagrid özellikleri

            dataGridView2.Columns[0].Width = 50; // sütun genişliği ayarlama
            dataGridView2.Columns[1].Width = 150;
            dataGridView2.Columns[2].Width = 150;
            dataGridView2.Columns[3].Width = 150;
             

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

            string cek = "SELECT*FROM depo WHERE d_urun LIKE @kelime ";
 
            MySqlCommand mykomi = new MySqlCommand(cek, baglan);

            mykomi.Parameters.AddWithValue("@kelime", "%"+textBox1.Text+"%");

            MySqlDataAdapter mda = new MySqlDataAdapter(mykomi);

            DataSet ds = new DataSet();

            mda.Fill(ds, "depo");

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
            DialogResult secenek = MessageBox.Show("Bu Ürünü Depodan Silmek istiyor musunuz?", "Depo Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dataGridView2.SelectedRows)  //Seçili Satırları Silme
                {
                    int numara = Convert.ToInt32(drow.Cells[0].Value);

                    baglan.Open();


                    MySqlCommand silelim = new MySqlCommand("DELETE FROM depo WHERE d_id=@numm", baglan);
                    
                    silelim.Parameters.AddWithValue("@numm", numara);
                    

                    silelim.ExecuteNonQuery();

                    MessageBox.Show("Depodaki ürün başarıyla silindi!", "Bilgilendirme :");

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
            int g_id = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells["d_id"].Value);

            CDguncelle cdgg = new CDguncelle();

            cdgg.guncelle_id = g_id; // ÖNEMli: guncelle_id'yi Form5 te oluştur ve burada seçili olan id'yi ona ata ;) sonra form5 te çağır...

            cdgg.Show();  // form5 göster diyoruz
        }

        private void is_ekle_Click(object sender, EventArgs e)
        {
            if (isim.Text.Length == 0 ||  mail.Text.Length == 0 || d_aciklamaT.Text.Length == 0)
            {
                MessageBox.Show("Boş Alan Bırakmayınız!","Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                baglan.Open();
 
                string yil = DateTime.Now.ToShortDateString(); // gün.ay.yil olarak verir
         
                MySqlCommand ekle = new MySqlCommand("INSERT INTO depo (d_urun,d_adet,d_tarih,d_aciklama) VALUES (@m_isim,@m_mail,@m_tarih,@d_aciklama)", baglan);

                ekle.Parameters.AddWithValue("@m_isim", isim.Text);
                
                 
                ekle.Parameters.AddWithValue("@m_tarih", yil);
                ekle.Parameters.AddWithValue("@m_mail", mail.Text);
                ekle.Parameters.AddWithValue("@d_aciklama", d_aciklamaT.Text);

                ekle.ExecuteNonQuery();

                MessageBox.Show("Yeni Ürünü Depoya Başarıyla Eklendiniz!","Bilgilendirme : ",MessageBoxButtons.OK,MessageBoxIcon.Information);

                isim.Text = "";
               
                mail.Text = "";

                d_aciklamaT.Text = "";

                baglan.Close();

                mus_dok();
            }
        }

 

 
  

        private void cikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
           // Application.Exit();
        }

        private void sifre_Click_1(object sender, EventArgs e)
        {
            SifrePaneliCalisan sifrePan = new SifrePaneliCalisan();

            sifrePan.oturum_id2 = oturum_id2;


            sifrePan.Show();
        }
    }
}
