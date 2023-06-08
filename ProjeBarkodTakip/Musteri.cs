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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }

        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        MySqlDataAdapter mda;

        public string adSoyad { get; set; }
        public static int oturumId { get; set; }
        int kayitSayisi = -1;
        int akayitSayisi = -1;
        int bkayitSayisi = -1;

        public void mus_dok2()
        {

            baglan.Open();

            string cek = "SELECT*FROM isler WHERE is_mus=@is_mus ORDER BY is_id DESC ";

            MySqlCommand komkom = new MySqlCommand(cek,baglan);
 
            komkom.Parameters.AddWithValue("@is_mus", oturumId);

            MySqlDataAdapter mdam = new MySqlDataAdapter(komkom);

            DataSet dsm = new DataSet();

            mdam.Fill(dsm, "musteri");

            dataGridViewMusteri.DataSource = dsm.Tables[0];



            // satırların renk ayarı
            for (int j = 0; j < dataGridViewMusteri.Rows.Count - 1; j++)
            {
                Application.DoEvents();

                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                string is_durum = Convert.ToString(dataGridViewMusteri.Rows[j].Cells["is_durum"].Value);

                if (is_durum == "a")
                {
                    renk.BackColor = Color.YellowGreen;
                }
                else if (is_durum == "b")
                {
                    renk.BackColor = Color.Pink;
                }

                dataGridViewMusteri.Rows[j].DefaultCellStyle = renk;
            }

            // renk bitti


            // bu da toplam sayısı bulma kodu

            MySqlCommand mycmd = new MySqlCommand("select count(*) from isler WHERE is_mus=@is_mus", baglan);

            mycmd.Parameters.AddWithValue("@is_mus", oturumId);

            kayitSayisi = Convert.ToInt32(mycmd.ExecuteScalar());

            label10.Text = kayitSayisi.ToString();

            // bu da toplam aktif iş sayısı bulma kodu

            MySqlCommand mycmd2 = new MySqlCommand("select count(*) from isler WHERE is_durum='a' AND is_mus=@is_mus", baglan);

            mycmd2.Parameters.AddWithValue("@is_mus", oturumId);

            akayitSayisi = Convert.ToInt32(mycmd2.ExecuteScalar());

            label18.Text = akayitSayisi.ToString();


            // bu da toplam bitmiş iş sayısı bulma kodu

            MySqlCommand mycmd3 = new MySqlCommand("select count(*) from isler WHERE is_durum='b' AND is_mus=@is_mus", baglan);

            mycmd3.Parameters.AddWithValue("@is_mus", oturumId);

            bkayitSayisi = Convert.ToInt32(mycmd3.ExecuteScalar());

            label19.Text = bkayitSayisi.ToString();

            // bu kadar



            baglan.Close();


        }

        void dok_isim()
        {
            baglan.Open();

            string cek3 = "SELECT*FROM musteri WHERE m_id=@m_id";

            MySqlCommand komutaaa = new MySqlCommand(cek3, baglan);

            komutaaa.Parameters.AddWithValue("@m_id", oturumId);


            MySqlDataReader dr = komutaaa.ExecuteReader();


            if (dr.Read()) //Datareader ile okunan verileri form kontrollerine aktardık.
            {
                
                label15.Text = dr["m_tel"].ToString();

                label16.Text = dr["m_mail"].ToString();
                label17.Text = dr["m_tarih"].ToString();

            }

            baglan.Close();

        }


        public void toplam_is_dok() // datagrid deki verileri toplayan fonksiyon ve // MySql tablodaki sütunu toplayana program
        {
            //datagrid deki tabloyu toplama

            label23.Text = "Ödeme YOK!";
            int Topla = 0;
            for (int i = 0; i < dataGridViewMusteri.Rows.Count; ++i)
            {
                Topla += Convert.ToInt32(dataGridViewMusteri.Rows[i].Cells[5].Value);
                // Not: cells'in 5 olması veritabanındaki 6. sütün olması. Yani burada ayarladığın sıra değil!
            }
            label23.Text = Convert.ToString(Topla);//çalıştır

            int sayi2 = Convert.ToInt32(label23.Text);


            //MySql  tablodaki sütunu toplama

            baglan.Open();

            string result = "SELECT SUM(gelen) FROM muhasebe WHERE gelen_kim=@gelen_kim";
            MySqlCommand showresult = new MySqlCommand(result, baglan);
            showresult.Parameters.AddWithValue("@gelen_kim", oturumId);

            object emrebaba = showresult.ExecuteScalar(); // objectsiz çalışmıyor! string falan yapma...
            label22.Text = Convert.ToString(emrebaba);

            // ikisinin farkı da lazım bize bu programda;)

            if (label22.Text == "")// label22 boş olursa sııntı çıkıyor!
            {
                label22.Text = Convert.ToString(0);

            }

            int sayi1 = Convert.ToInt32(label22.Text);

            int sayi3 = sayi2 - sayi1;

            label24.Text = Convert.ToString(sayi3);

            baglan.Close();

        }

        public void dok_muhasebe_doktor()
        {
            baglan.Open();

            string cek4 = "SELECT*FROM muhasebe WHERE gelen_kim=@gelen_kim ORDER BY muh_id DESC";

            MySqlCommand komut2 = new MySqlCommand(cek4, baglan);

            komut2.Parameters.AddWithValue("@gelen_kim", oturumId);

            MySqlDataReader dr2 = komut2.ExecuteReader();

            label20.Text = "Ödeme YOK!";
            label21.Text = "Ödeme YOK!";

            if (dr2.Read())
            {

                label20.Text = dr2["gelen"].ToString();
                label21.Text = dr2["tarih"].ToString();
            }

            baglan.Close();

        }


        private void Musteri_Load(object sender, EventArgs e)
        {
            MusteriMetotlar muss = new MusteriMetotlar();

            isimYeri.Text=muss.isimCek();

            mus_dok2();

            dok_isim();

            dok_muhasebe_doktor();

            toplam_is_dok();

        }

        private void sifre_Click(object sender, EventArgs e)
        {
            MusteriSifre mussif = new MusteriSifre();

            MusteriSifre.oturum_id = oturumId; // Musterisifre.cs içindeki oturum_id'ye, oturumId değerini atadık...
 
            mussif.Show();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Close();
            //Application.Exit();
        }

        private void dataGridViewMusteri_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewMusteri.Columns["is_id"].Visible = false; // datagrid de is_id kolonunu göstermiyoruz ;)
            dataGridViewMusteri.Columns["is_barkod"].Visible = false;
            dataGridViewMusteri.Columns["is_durum"].Visible = false;
            dataGridViewMusteri.Columns["is_not"].Visible = false;
            dataGridViewMusteri.Columns["is_mus"].Visible = false;


            dataGridViewMusteri.Columns[0].Width = 60; // sütun genişliği ayarlama
            dataGridViewMusteri.Columns[1].Width = 350;
            dataGridViewMusteri.Columns[2].Width = 150;

            dataGridViewMusteri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // otomatik kaplama
        }

        private void ara_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string kelime = textBox1.Text;

            string cek = "SELECT*FROM isler WHERE  ( is_adi LIKE '%'  + @kelime + '%' ) AND is_mus=@is_mus ";

            MySqlCommand mykomi = new MySqlCommand(cek, baglan);

            mykomi.Parameters.AddWithValue("@kelime", textBox1.Text);
            mykomi.Parameters.AddWithValue("@is_mus", oturumId);

            MySqlDataAdapter mda = new MySqlDataAdapter(mykomi);

            DataSet ds = new DataSet();

             mda.Fill(ds, "isler");

            dataGridViewMusteri.DataSource = ds.Tables[0];


            // satırların renk ayarı
            for (int i = 0; i < dataGridViewMusteri.Rows.Count - 1; i++)
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

                dataGridViewMusteri.Rows[i].DefaultCellStyle = renk;
            }

            // renk bitti

            baglan.Close();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            mus_dok2();
        }

        private void takip_Click(object sender, EventArgs e)
        {
            MusteriTakip tkp = new MusteriTakip();

            tkp.oturumTakip = oturumId;

            string barkodNo = Convert.ToString(dataGridViewMusteri.Rows[dataGridViewMusteri.CurrentRow.Index].Cells["is_barkod"].Value);

            tkp.barkodNo = barkodNo;


            tkp.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
