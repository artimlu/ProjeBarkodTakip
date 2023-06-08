using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using MySql.Data.MySqlClient;
//using System.Diagnostics;

namespace is_takibi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");


        MySqlDataAdapter mda;

        DataSet ds;

        public static int oturum_id { get; set; }
        
        public  void kullanici_belirle()
        {
            
            baglan.Open();

            string oturumCek = "SELECT*FROM Admin WHERE id=" + oturum_id;
            MySqlCommand komutlar = new MySqlCommand(oturumCek,baglan);

            MySqlDataReader dr = komutlar.ExecuteReader();

            if (dr.Read())
            {
                string isimK = dr["isim"].ToString();

             
                string sifreK = dr["sifre"].ToString();

                label7.Text = isimK;

 
            }

            
            baglan.Close();


        }



        public void is_dok()
        {
 
            baglan.Open();

            string cek = "SELECT*FROM isler,musteri WHERE is_durum='a' AND isler.is_mus=musteri.m_id ORDER BY is_id DESC ";
            // 2 tabloyu birbirne bağladık

            mda = new MySqlDataAdapter(cek, baglan);

           

            ds = new DataSet();

            mda.Fill(ds,"isler,musteri"); // 2 tabloyu da yazmak zorundasın

            dataGridView1.DataSource = ds.Tables[0];

            // satırların renk ayarı
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Application.DoEvents();

                int sayiHesap = i % 2;

                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                // Not: eğer veritabında sorgu ile boyayacaksan;
                //Convert.ToInt32(dataGridView1.Rows[i].Cells["gelen"].Value) == 0 gibi kullanmalısın
                //Form11.cs de var örneği

                if (sayiHesap != 0)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                else if (sayiHesap == 0)
                {
                    renk.BackColor = Color.Pink;
                }

                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }

            // renk bitti

            baglan.Close();


        }

         public void musteri_dok()
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

        private void Form2_Load(object sender, EventArgs e)
        {

            is_dok();

            musteri_dok();

            kullanici_belirle();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns["is_id"].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id_s = comboBox1.SelectedValue.ToString();

            int id_m_al = Int32.Parse(id_s);
        }

        private void is_ekle_Click(object sender, EventArgs e)
        {

            if (isim.Text.Length == 0 || tutar.Text.Length==0 || urunn.Text.Length == 0 || adett.Text.Length == 0)
            {
                MessageBox.Show("Boş Alanları Doldurunuz!\nİş Ekleme Yapılamadı!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else { 
            baglan.Open();

                barkod_picture.Image = null;

                string yil = DateTime.Now.ToShortDateString(); // gün.ay.yil olarak verir

                DateTime dtAl = DateTime.Now;
                string tarihall = dtAl.ToString("ddMMyyHHmmss"); //gün+ay+yil+saat+dakika+saniye

                // string  saniye = DateTime.Now.Second.ToString(); // sadece saniye
                // string dakika = DateTime.Now.Minute.ToString(); // sadece dakika
                // string saat = DateTime.Now.Hour.ToString(); // sadece saat

                // combobox id değerini atama, alttaki notu oku
                string id_s = comboBox1.SelectedValue.ToString();

                int id_m_al = Int32.Parse(id_s);

                // aslında, Form9 da olduğu gibi sadece comboBox1.SelectedValue ile değer atayabilirdik ;)
                //bunu da bilmek de fayda var

                string barkod = oturum_id +  tarihall ; //barkod No: Kullanici id'si ve tarih
                // Bu da barkod oluşturma kodları
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                barkod_picture.Image = barcode.Draw(barkod, 50);

                MySqlCommand ekle = new MySqlCommand("INSERT INTO isler (is_adi,is_barkod,is_durum,is_giris,is_tutar,is_mus,is_not,is_urun,is_adet) VALUES (@is_adi,@is_barkod,@is_durum,@is_giris,@is_tutar,@is_mus,@is_not,@urun,@adet)", baglan);

                ekle.Parameters.AddWithValue("@is_adi", isim.Text);
                ekle.Parameters.AddWithValue("@is_barkod", barkod);
                ekle.Parameters.AddWithValue("@is_durum", "a");
                ekle.Parameters.AddWithValue("@is_giris", yil);
                ekle.Parameters.AddWithValue("@is_tutar", tutar.Text);
                ekle.Parameters.AddWithValue("@is_mus", id_m_al);
                ekle.Parameters.AddWithValue("@is_not", is_not.Text);
                
                ekle.Parameters.AddWithValue("@urun", urunn.Text);
                ekle.Parameters.AddWithValue("@adet", adett.Text);

                ekle.ExecuteNonQuery();

                MySqlCommand ekle22 = new MySqlCommand("INSERT INTO takip (t_barkod,t_tarih,t_ist,t_calisan) VALUES (@t_barkod,@t_tarih,@t_ist,@t_calisan)", baglan);

                ekle22.Parameters.AddWithValue("@t_barkod", barkod);
                ekle22.Parameters.AddWithValue("@t_tarih", DateTime.Now.ToString());
                ekle22.Parameters.AddWithValue("@t_ist", "Kayıt");
                ekle22.Parameters.AddWithValue("@t_calisan", "Yönetici");
               

                ekle22.ExecuteNonQuery();

                MessageBox.Show("Yeni iş başarıyla eklendi!","Bilgilendirme : ",MessageBoxButtons.OK,MessageBoxIcon.Information);

            isim.Text = "";
            tutar.Text = "";
            is_not.Text = "";
            urunn.Text="";
            adett.Text = "";

                baglan.Close();

            is_dok();


                // hIZ ÖLÇÜMÜ
/*
                Stopwatch sw = new Stopwatch();

                sw.Start();

                // ...

                sw.Stop();

                MessageBox.Show("İş Ekleme Panelinde Kodların Çalışma Süresi(ms) :"+ sw.Elapsed, "SİSTEM TESTİ : ", MessageBoxButtons.OK, MessageBoxIcon.Information);
*/



                 
            }

        }

        private void isim_TextChanged(object sender, EventArgs e)
        {

        }

        private void sil_Click(object sender, EventArgs e)
        {
 
DialogResult secenek = MessageBox.Show("Bu işi silmek istiyor musunuz?", "İş Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
                {
                    int numara = Convert.ToInt32(drow.Cells[0].Value);

                    baglan.Open();


                    MySqlCommand silelim = new MySqlCommand("DELETE FROM isler WHERE is_id=@numm", baglan);

                    silelim.Parameters.AddWithValue("@numm", numara);
                     

                    silelim.ExecuteNonQuery();

                    MessageBox.Show("iş başarıyla silindi!", "Bilgilendirme :",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    baglan.Close();

                }

                is_dok();
            }
            else if (secenek == DialogResult.No)
            {
                
            }
 
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            int g_id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["is_id"].Value);

            Form3 form3 = new Form3();

            form3.guncelle_id = g_id; // ÖNEMli: guncelle_id'yi Form3 te oluştur ve burada seçili olan id'yi ona ata ;) sonra form3 te çağır...
           
            form3.Show();  // form3 göster diyoruz

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void ara_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string kelime= textBox1.Text;

            string cek = "SELECT*FROM isler,musteri WHERE isler.is_mus=musteri.m_id AND  is_adi LIKE  @kelime ";

            MySqlCommand mykomi = new MySqlCommand(cek,baglan);
            mykomi.Parameters.AddWithValue("@kelime", "%"+textBox1.Text+"%");
            

            mda = new MySqlDataAdapter(mykomi);

            ds = new DataSet();

            mda.Fill(ds, "isler,musteri");

            dataGridView1.DataSource = ds.Tables[0];

            // satırların renk ayarı
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
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

                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }

            // renk bitti

            baglan.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            //datagrid özellikleri

            dataGridView1.Columns["is_id"].Visible = false; // datagrid de is_id kolonunu göstermiyoruz ;)
            dataGridView1.Columns["is_barkod"].Visible = false;
            dataGridView1.Columns["is_durum"].Visible = false;
            dataGridView1.Columns["is_not"].Visible = false;
            dataGridView1.Columns["is_mus"].Visible = false;

            dataGridView1.Columns["m_id"].Visible = false;
            dataGridView1.Columns["m_adres"].Visible = false;
            dataGridView1.Columns["m_tarih"].Visible = false;
            dataGridView1.Columns["m_mail"].Visible = false;
            dataGridView1.Columns["m_sifre"].Visible = false;
            dataGridView1.Columns["m_tel"].Visible = false;


            dataGridView1.Columns[0].Width = 60; // sütun genişliği ayarlama
            dataGridView1.Columns[1].Width = 350;
            dataGridView1.Columns[2].Width = 150;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // otomatik kaplama
        }

        private void doktorlar_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            form4.Show();

            this.Close();

        }

        // yazdırma komutları
        private void yazdir_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_printpage;
            pd.Document = doc;
            doc.Print();
        }

        private void Doc_printpage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(barkod_picture.Width, barkod_picture.Height);
            barkod_picture.DrawToBitmap(bm, new Rectangle(0, 0, barkod_picture.Width, barkod_picture.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void yenile_Click(object sender, EventArgs e)
        {
            is_dok();
        }

        private void barkod_picture_Click(object sender, EventArgs e)
        {
            string deger= dataGridView1.CurrentRow.Cells[2].Value.ToString(); //Mysql veritabanındaki , isler tablosunun 3. elemanı (barkod_no) (0'dan başlıyor) 

            MessageBox.Show(deger);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // satıra bir kere tıkladığında yapılan event 
        {
            string secili_barkod = dataGridView1.CurrentRow.Cells[2].Value.ToString(); // Mysql de deneme db'deki isler tablosundan 3. sütunu yani barkodu aldık.
            // neden "isler" tablosu? Çünkü is_dok() fonksiyonunda datasetin içine "isler" tablosunu ekledik!

            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            barkod_picture.Image = barcode.Draw(secili_barkod, 200);
        }
        // buraya kadar
      

       
        private void isler_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Close();
        }

        private void sifre_Click(object sender, EventArgs e)
        {
            SifrePaneli sifrePan = new SifrePaneli();

            sifrePan.oturum_id2 = oturum_id;

             

            sifrePan.Show();
 
             
        }
 

        private void istasyon_Click_1(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();

            Form7.oturum_id2 = oturum_id;

            form7.Show();

            this.Close();
        }

        private void musteriler_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
 
            Form4.oturum_id2 = oturum_id;

            form4.Show();

            this.Close();
        }

        private void kullanici_Click_1(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();

            Form9.oturum_id2 = oturum_id;

            form9.Show();

            this.Close();
        }

        private void muhasebe_Click_1(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();

            Form11.oturum_id2 = oturum_id;

            form11.Show();

            this.Close();
        }

        private void cikis_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();

            this.Close();
            //Application.Exit();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void takip_Click(object sender, EventArgs e)
        {
            Takip tkp = new Takip();

            tkp.oturumTakip = oturum_id;

            string barkodNo = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["is_barkod"].Value);

            tkp.barkodNo = barkodNo; 


            tkp.Show();

           
             

        }

        private void tutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void satinAl_Click(object sender, EventArgs e)
        {

            SatinAlma satinAlma = new SatinAlma();

            SatinAlma.oturum_id2 = oturum_id;

            satinAlma.Show();

            this.Close();

        }

        private void DepoGit_Click(object sender, EventArgs e)
        {
            Depo depoo = new Depo();

            Depo.oturum_id2 = oturum_id;

            depoo.Show();

            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglan.Open();

            string cek = "SELECT*FROM isler,musteri WHERE is_durum='b' AND isler.is_mus=musteri.m_id ORDER BY is_id DESC ";
            // 2 tabloyu birbirne bağladık

            mda = new MySqlDataAdapter(cek, baglan);



            ds = new DataSet();

            mda.Fill(ds, "isler,musteri"); // 2 tabloyu da yazmak zorundasın

            dataGridView1.DataSource = ds.Tables[0];

            // satırların renk ayarı
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Application.DoEvents();

                int sayiHesap = i % 2;

                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                // Not: eğer veritabında sorgu ile boyayacaksan;
                //Convert.ToInt32(dataGridView1.Rows[i].Cells["gelen"].Value) == 0 gibi kullanmalısın
                //Form11.cs de var örneği

                if (sayiHesap != 0)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                else if (sayiHesap == 0)
                {
                    renk.BackColor = Color.Pink;
                }

                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }

            // renk bitti

            baglan.Close();


        }
    }
}
