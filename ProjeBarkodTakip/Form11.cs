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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }


        // MySql veritabanına bağlantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        MySqlDataAdapter mda;

        DataSet ds;

        public static int oturum_id2 { get; set; }

        public void muhasebe_dok()
        {


            baglan.Open();

            //son Bir hafta için gerekli sürler belirleniyor
            DateTime bitir = DateTime.Today;
            DateTime basla = bitir.AddDays(-7);
  
            // son bir hafta için deki tüm kayıtları çeken kod

            string cek = "SELECT * FROM muhasebe WHERE tarih BETWEEN @basla AND @bitir ";

            MySqlCommand komutsql = new MySqlCommand(cek, baglan);

            komutsql.Parameters.AddWithValue("@basla", basla);
            komutsql.Parameters.AddWithValue("@bitir", bitir);

            mda = new MySqlDataAdapter(komutsql);

            ds = new DataSet();

            mda.Fill(ds, "musteri");

            dataGridView6.DataSource = ds.Tables[0];


            // datagrid satır renkllendirme

            for (int i = 0; i < dataGridView6.Rows.Count - 1; i++)
            {
                Application.DoEvents();
                // Math.DivRem(i, 2, out sayi);
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToInt32(dataGridView6.Rows[i].Cells["gelen"].Value) != 0)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                else if (Convert.ToInt32(dataGridView6.Rows[i].Cells["gelen"].Value) == 0)
                {
                    renk.BackColor = Color.Pink;
                }

                dataGridView6.Rows[i].DefaultCellStyle = renk;
            }
            // renklendirme son

            baglan.Close();

        }



        /* bu kısım yeni sütun ekleme bölümü, gelen_kim ve giden_kim in isimlerini yazdırıyor ama aramada hata veriyor;)
 
// sütun ekleme başarılı çalıştı ancak, arama kısmıyla bir türlü entegre çalışmadı! BEnde veritabanına id yerine direkt isim yazdırdım. Muhasebedeki Gelen_kim ve giden_kim'e

        // BU ÇOK ÇOK ÇOK ÖNEMLİ ;) 2 FARKLI OleDb TABLOSUNDAN VERİ ÇEKİP TEK DATAGRID DE GÖSTERMEYİ ÇÖZDÜK SONUNDA :)

        // seçili sütun içindeki ID değerini, diğer OleDb tablodaki ID ile karşılaştırıp isim yazdırma metodu
        private void YeniSutunEkleme() //  dataGridView6 ya yeni sütun ekliyıruz. Muhasebe tablosunda olmayıp da giderler tablosundaki veriyi ekliyoruz...
        {

            baglan.Open();

            //SütunU oluşturuyoruz.
            DataGridViewTextBoxColumn gidenKim = new DataGridViewTextBoxColumn();
            

            //Datagride alanINı ekliyoruz.
            dataGridView6.Columns.Add(gidenKim);


            //Sütun başlıĞINIı ayarlıyoruz.
            gidenKim.HeaderText = "GİDEN KİM";


            //Sütun genişliĞİNi ayarlıyoruz.
            gidenKim.Width = 120;



            for (int aa = 0; aa < dataGridView6.Rows.Count - 1; aa++)
            {

                if (Convert.ToInt32(dataGridView6.Rows[aa].Cells["gelen_kim"].Value) == 0) // gelen_kim muhasebe tablosunun sutunu, gelen_kim=0 ise giden_kim doludur;)
                { // rows satırlar, cells sutunlar

                    string cekGider = "SELECT gid_isim FROM giderler WHERE  gid_id=" + dataGridView6.Rows[aa].Cells["giden_kim"].Value; // giden_kim muhasebe tablosunun sutunu 
                                                                                                                                        //gidem_kim ile gid_id eşit mi diye kontrol ettirdik
                      // not: yukarıda dataset'e muhasebeyi direkt attığımız için bütün sütunları ototmatik tanıdı.
                     // Yani Cells["giden_kim"] deki giden_kim otomatik tanıyor ;)

                    OleDbCommand giderKomut = new OleDbCommand(cekGider, baglan);

                    object gidenYaz = giderKomut.ExecuteScalar();

                    if (gidenYaz == null)
                    {
                        gidenYaz = "Silinmiş";
                    }

   
                    //Kayıt girişini gerçekleştiriyoruz.

                     dataGridView6.Rows[aa].Cells[7].Value = gidenYaz;

                    // not buradaki 7'nin nedeni, muhasebe tablosunu 7 tane sütunu olması
                    // 0'dan başlarsak 6 ya kadar sütün sayısı olur
                    // bu da 7. oluyor
                    //yeni yapacağımız "Kimden geldi" datagrid sütunuda 8 olacak ;) 26.02.2021
                }
  
            }

            baglan.Close();
           
           
        }

     

        private void YeniSutunEkleme2() //  dataGridView6 ya yeni sütun ekliyıruz. Muhasebe tablosunda olmayıp da giderler tablosundaki veriyi ekliyoruz...
        {

            baglan.Open();

            //SütunU oluşturuyoruz.
            DataGridViewTextBoxColumn gelenKim = new DataGridViewTextBoxColumn();


            //Datagride alanINı ekliyoruz.
            dataGridView6.Columns.Add(gelenKim);


            //Sütun başlıĞINIı ayarlıyoruz.
            gelenKim.HeaderText = "GELEN KİM";


            //Sütun genişliĞİNi ayarlıyoruz.
            gelenKim.Width = 120;



            for (int aaa = 0; aaa < dataGridView6.Rows.Count - 1; aaa++)
            {

                if (Convert.ToInt32(dataGridView6.Rows[aaa].Cells["giden_kim"].Value) == 0) // giden_kim muhasebe tablosunun sutunu, giden_kim=0 ise gelen_kim doludur;)
                { // rows satırlar, cells sutunlar

                    string cekGelen = "SELECT m_isim FROM musteri WHERE  m_id=" + dataGridView6.Rows[aaa].Cells["gelen_kim"].Value;  
                                         // musteri tablosundaki id ile, muhasebe tablosundaki gelen_kim ayni numaralar (id'ler)
                                         //onları eşitledik

                    OleDbCommand gelenKomut = new OleDbCommand(cekGelen, baglan);

                    object gelenYaz = gelenKomut.ExecuteScalar();

                    if (gelenYaz == null)
                    {
                        gelenYaz = "Silinmiş";
                    }

                    //Kayıt girişini gerçekleştiriyoruz.

                    dataGridView6.Rows[aaa].Cells[8].Value = gelenYaz;

                    // not buradaki 8'nin nedenini, bi üstteki YeniSutunEkleme fonksiyonundan oku ;) 26.02.2021
                }

            }

            baglan.Close();

        }



      
*/




        private void yenile_Click(object sender, EventArgs e)
        {

            muhasebe_dok();


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


            //



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
                label15.Text = dr["isim"].ToString();

            }


            baglan.Close();


        }
        public void gider_dok()
        {

            baglan.Open();

            string cek = "SELECT * FROM giderler ";

            mda = new MySqlDataAdapter(cek, baglan);

            ds = new DataSet();

            mda.Fill(ds, "giderler"); // deneme isimli database deki musteri isimli tablo

            giderler.ValueMember = "gid_id";

            giderler.DisplayMember = "gid_isim"; // musteri ismindeki tablodaki, m_isim isimli sütun (isimleri çekiyoruz)

            giderler.DataSource = ds.Tables[0];




            mda.Fill(ds, "giderler2");  

            giderler2.ValueMember = "gid_id";

            giderler2.DisplayMember = "gid_isim";  

            giderler2.DataSource = ds.Tables[0];



            baglan.Close();
        }
 
        private void Form11_Load(object sender, EventArgs e)
        {

            musteri_dok();

            gider_dok();

            muhasebe_dok();

            kullanici_belirle();





        }

        private void giris_ekle_Click(object sender, EventArgs e)
        {
            if (tutar.Text.Length == 0)
            {
                MessageBox.Show("Tutar Bölümünü Doldurunuz!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                baglan.Open();
 


                MySqlCommand ekle = new MySqlCommand("INSERT INTO muhasebe (gelen,gelen_kim,tarih,muh_not,giden,giden_kim) VALUES (@tutar,@combo,@tarih,@mnot,'0','0')", baglan);

                ekle.Parameters.AddWithValue("@tutar", tutar.Text);
                ekle.Parameters.AddWithValue("@combo", comboBox1.SelectedValue);
                ekle.Parameters.AddWithValue("@tarih", tarih.Value.ToString("yyyy-MM-dd"));
                ekle.Parameters.AddWithValue("@mnot", muh_not.Text);


                ekle.ExecuteNonQuery();

                MessageBox.Show("Yeni PARA Girişi başarıyla eklendi!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tutar.Text = "";
                muh_not.Text = "";
               

                baglan.Close();

                muhasebe_dok();
               
            }
        }

        private void gider_ekle_Click(object sender, EventArgs e)
        {

            if (gider_isim.Text.Length == 0)
            {
                MessageBox.Show("Boş Bırakılmaz! EKLENEMEDİ !", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                baglan.Open();


                MySqlCommand ekle22 = new MySqlCommand("INSERT INTO giderler (gid_isim) VALUES (@gIsım)", baglan);


                ekle22.Parameters.AddWithValue("@gIsım", gider_isim.Text);
               


                ekle22.ExecuteNonQuery();

                MessageBox.Show("Yeni Gider Kalemi başarıyla eklendi!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gider_isim.Text = "";
      
                baglan.Close();

                gider_dok();



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Bu Gider Kalemini silmek istiyor musunuz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
 
                    baglan.Open();
 
                    MySqlCommand silelim = new MySqlCommand("DELETE FROM giderler WHERE gid_id=@gsec", baglan);

                silelim.Parameters.AddWithValue("@gsec", giderler2.SelectedValue);
                 

                silelim.ExecuteNonQuery();

                    MessageBox.Show("Gider Kalemi başarıyla silindi!", "Bilgilendirme :");

                    baglan.Close();

                gider_dok();

            }
            else if (secenek == DialogResult.No)
            {

            }
        }

        private void cikis_ekle_Click(object sender, EventArgs e)
        {
            if (tutar2.Text.Length == 0)
            {
                MessageBox.Show("Tutar Bölümünü Doldurunuz!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                baglan.Open();

                 

                MySqlCommand ekle = new MySqlCommand("INSERT INTO muhasebe (giden,giden_kim,tarih,muh_not,gelen,gelen_kim) VALUES (@tutar,@combo,@tarih,@mnot,'0','0')", baglan);
                ekle.Parameters.AddWithValue("@tutar", tutar2.Text);
                ekle.Parameters.AddWithValue("@combo", giderler.SelectedValue);
                ekle.Parameters.AddWithValue("@tarih", tarih2.Value.ToString("yyyy-MM-dd"));
                ekle.Parameters.AddWithValue("@mnot", muh_not2.Text);

                ekle.ExecuteNonQuery();

                MessageBox.Show("Yeni PARA Çıkışı başarıyla eklendi!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tutar2.Text = "";
                muh_not2.Text = "";

                baglan.Close();

                muhasebe_dok();
            }
        }


 
        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView6_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //datagrid özellikleri

            dataGridView6.Columns["muh_id"].Visible = false; // datagrid de is_id kolonunu göstermiyoruz ;)

            dataGridView6.Columns["giden_kim"].Visible = false;

            dataGridView6.Columns["gelen_kim"].Visible = false;


            dataGridView6.Columns[0].Width = 60; // sütun genişliği ayarlama
            dataGridView6.Columns[1].Width = 150; // sütun genişliği ayarlama


            dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // otomatik kaplama
        }

        private void sil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Bu Veriyi silmek istiyor musunuz?", "Muhasebe Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dataGridView6.SelectedRows)  //Seçili Satırları Silme
                {
                    int numara = Convert.ToInt32(drow.Cells[0].Value);

                    baglan.Open();


                    MySqlCommand silelim = new MySqlCommand("DELETE FROM muhasebe WHERE muh_id=@num", baglan);

                    silelim.Parameters.AddWithValue("@num", numara);
                    silelim.ExecuteNonQuery();

                    MessageBox.Show("Seçili Veri Başarıyla Silindi!", "Bilgilendirme :");

                    baglan.Close();

                }

                muhasebe_dok();
            }
            else if (secenek == DialogResult.No)
            {

            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            int g_id = Convert.ToInt32(dataGridView6.Rows[dataGridView6.CurrentRow.Index].Cells["muh_id"].Value);

            muhGuncelle form12 = new muhGuncelle();

            form12.guncelle_id = g_id; // ÖNEMli: guncelle_id'yi Form3 te oluştur ve burada seçili olan id'yi ona ata ;) sonra form3 te çağır...

            form12.Show();  // form3 göster diyoruz

        }

       

        private void secim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

         
         

        private void ara_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string secimBox = secim.Text;

           
            if(secimBox== "Sadece Gelir")
            {

                string cekAra = "SELECT*FROM muhasebe WHERE giden=0 AND tarih BETWEEN  @basla AND @bitir ";

                MySqlCommand komutsql2 = new MySqlCommand(cekAra, baglan);

                komutsql2.Parameters.AddWithValue("@basla", g_tarih.Value.ToString("yyyy-MM-dd"));
                komutsql2.Parameters.AddWithValue("@bitir", c_tarih.Value.ToString("yyyy-MM-dd"));
                

                mda = new MySqlDataAdapter(komutsql2);
            }

            else if (secimBox == "Sadece Gider")
            {
                string cekAra = "SELECT*FROM muhasebe WHERE gelen=0 AND tarih BETWEEN  @basla AND @bitir ";

                MySqlCommand komutsql2 = new MySqlCommand(cekAra, baglan);

                komutsql2.Parameters.AddWithValue("@basla", g_tarih.Value.ToString("yyyy-MM-dd"));
                komutsql2.Parameters.AddWithValue("@bitir", c_tarih.Value.ToString("yyyy-MM-dd"));


                mda = new MySqlDataAdapter(komutsql2);

            }

            else
            {

                string cekAra = "SELECT*FROM muhasebe WHERE tarih BETWEEN  @basla AND @bitir ";

                MySqlCommand komutsql2 = new MySqlCommand(cekAra, baglan);

                komutsql2.Parameters.AddWithValue("@basla", g_tarih.Value.ToString("yyyy-MM-dd"));
                komutsql2.Parameters.AddWithValue("@bitir", c_tarih.Value.ToString("yyyy-MM-dd"));


                mda = new MySqlDataAdapter(komutsql2);

            }

 

          

            ds = new DataSet();

            mda.Fill(ds, "muhasebe");

            dataGridView6.DataSource = ds.Tables[0];

            for (int i = 0; i < dataGridView6.Rows.Count - 1; i++)
            {
                Application.DoEvents();
                // Math.DivRem(i, 2, out sayi);
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToInt32(dataGridView6.Rows[i].Cells["gelen"].Value) != 0)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                else if (Convert.ToInt32(dataGridView6.Rows[i].Cells["gelen"].Value) == 0)
                {
                    renk.BackColor = Color.Pink;
                }

                dataGridView6.Rows[i].DefaultCellStyle = renk;
            }


            baglan.Close();
 
        }
 
     
     
 

        private void muhasebe_Click(object sender, EventArgs e)
        {

            Form11 form11 = new Form11();
            Form11.oturum_id2 = oturum_id2;

            form11.Show();

            this.Close();

        }

        private void isler_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Close();
        }

        private void musteriler_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            Form4.oturum_id2 = oturum_id2;
            form4.Show();

            this.Close();
        }

        private void istasyon_Click_1(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            Form7.oturum_id2 = oturum_id2;

            form7.Show();

            this.Close();
        }

        private void kullanici_Click_1(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            Form9.oturum_id2 = oturum_id2;
            form9.Show();

            this.Close();
        }

        private void sifre_Click_1(object sender, EventArgs e)
        {
            SifrePaneli sifrePan = new SifrePaneli();

            sifrePan.Show();

            this.Close();
        }

        private void topla_Click(object sender, EventArgs e)
        {
            baglan.Open();

            //datagrid deki tabloyu toplama

            // gelen parayı toplama
            int Topla = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; ++i)
            {
                Topla += Convert.ToInt32(dataGridView6.Rows[i].Cells[2].Value);
                // Not: cells'in 2 olması veritabanındaki 3. sütün (yani gelen para sütunu)olması. Yani burada ayarladığın sıra değil!
                // 0'dan başlıyor saymaya
            }
            //sayiGelen.Text = Convert.ToString(Topla);
            //int toplaGelen = Convert.ToInt32(sayiGelen.Text); 
            //sayiyi texboxa aktarma istersek bu kodlar kullanılacaktı
             

            //giden parayı toplama
 
            int Topla2 = 0;
            for (int j = 0; j < dataGridView6.Rows.Count; ++j)
            {
                Topla2 += Convert.ToInt32(dataGridView6.Rows[j].Cells[3].Value);
                // Not: cells'in 3 olması veritabanındaki 4. sütün (yani giden para sütunu)olması. Yani burada ayarladığın sıra değil!
                // 0'dan başlıyor saymaya
            }
            //sayiGiden.Text = Convert.ToString(Topla2); 
            // int toplaGiden = Convert.ToInt32(sayiGiden.Text);
            //sayiyi texboxa aktarma istersek bu kodlar kullanılacaktı

            int toplamKar = Topla - Topla2;


            MessageBox.Show("Toplam Gelir ="+ Topla + "\nToplam Gider ="+ Topla2 + "\nToplam Kar ="+ toplamKar, "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            baglan.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            SifrePaneli sifrePan = new SifrePaneli();

            sifrePan.oturum_id2 = oturum_id2;



            sifrePan.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            //Application.Exit();
        }

        private void tutar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tutar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
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

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
