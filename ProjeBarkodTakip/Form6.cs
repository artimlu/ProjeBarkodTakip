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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public int guncelle_id { get; set; }

        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        MySqlDataAdapter mda;

        int kayitSayisi = -1;
        int akayitSayisi = -1;
        int bkayitSayisi = -1;

        public void mus_dok2()
        {

            baglan.Open();

            string cek = "SELECT*FROM isler WHERE is_mus=@is_mus ORDER BY is_id DESC ";

            MySqlCommand komut = new MySqlCommand(cek, baglan);

            komut.Parameters.AddWithValue("@is_mus", guncelle_id);

            mda = new MySqlDataAdapter(komut);

            DataSet dsm = new DataSet();

            mda.Fill(dsm, "musteri");

            dataGridView3.DataSource = dsm.Tables[0];



            // satırların renk ayarı
            for (int j = 0; j < dataGridView3.Rows.Count - 1; j++)
            {
                Application.DoEvents();

                int sayiHesap = j % 2;

                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if (sayiHesap != 0)
                {
                    renk.BackColor = Color.DarkBlue;
                }
                else if (sayiHesap == 0)
                {
                    renk.BackColor = Color.DarkSlateGray;
                }

                dataGridView3.Rows[j].DefaultCellStyle = renk;
            }

            // renk bitti


            // bu da toplam sayısı bulma kodu

            MySqlCommand mycmd = new MySqlCommand("select count(*) from isler WHERE is_mus=" + guncelle_id, baglan);

             kayitSayisi= Convert.ToInt32(mycmd.ExecuteScalar());

            label10.Text =kayitSayisi.ToString();

            // bu da toplam aktif iş sayısı bulma kodu

            MySqlCommand mycmd2 = new MySqlCommand("select count(*) from isler WHERE is_durum='a' AND is_mus=" + guncelle_id, baglan);



            akayitSayisi = Convert.ToInt32(mycmd2.ExecuteScalar());

            label18.Text = akayitSayisi.ToString();


            // bu da toplam bitmiş iş sayısı bulma kodu

            MySqlCommand mycmd3 = new MySqlCommand("select count(*) from isler WHERE is_durum='b' AND is_mus=" + guncelle_id, baglan);

            bkayitSayisi = Convert.ToInt32(mycmd3.ExecuteScalar());

            label19.Text = bkayitSayisi.ToString();

            // bu kadar



            baglan.Close();


        }

        void dok_isim()
        {
            baglan.Open();

            string cek3 = "SELECT*FROM musteri WHERE m_id=@m_id" ;

            MySqlCommand komut = new MySqlCommand(cek3,baglan);

            komut.Parameters.AddWithValue("@m_id", guncelle_id);

            MySqlDataReader dr = komut.ExecuteReader();


            if (dr.Read()) //Datareader ile okunan verileri form kontrollerine aktardık.
            {
                label11.Text = dr["m_isim"].ToString();
                label15.Text = dr["m_tel"].ToString();
                
                label16.Text = dr["m_mail"].ToString();
                label17.Text = dr["m_tarih"].ToString();

            }

            baglan.Close();

        }
  
        public void toplam_is_dok() // datagrid deki verileri toplayan fonksiyon ve // access tablodaki sütunu toplayana program
        {
            //datagrid deki tabloyu toplama

            label23.Text = "Ödeme YOK!";
            int Topla = 0;
            for (int i = 0; i < dataGridView3.Rows.Count; ++i)
            {
                Topla += Convert.ToInt32(dataGridView3.Rows[i].Cells[5].Value); 
                // Not: cells'in 5 olması veritabanındaki 6. sütün olması. Yani burada ayarladığın sıra değil!
            }
            label23.Text = Convert.ToString(Topla);//çalıştır

            int sayi2 = Convert.ToInt32(label23.Text);


            //access  tablodaki sütunu toplama

            baglan.Open();

            string result = "SELECT SUM(gelen) FROM muhasebe WHERE gelen_kim=" + guncelle_id;
            MySqlCommand showresult = new MySqlCommand(result, baglan);

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
 
       

        public  void dok_muhasebe_doktor()
        {
            baglan.Open();

            string cek4 = "SELECT*FROM muhasebe WHERE gelen_kim=@gelen_kim ORDER BY muh_id DESC";

            MySqlCommand komut2 = new MySqlCommand(cek4, baglan);
 
            komut2.Parameters.AddWithValue("@gelen_kim", guncelle_id);
 
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

 

 
        private void Form6_Load(object sender, EventArgs e)
        {
            mus_dok2();

            dok_isim();

            dok_muhasebe_doktor();

            toplam_is_dok();
             
            

           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView3_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //datagrid özellikleri

            dataGridView3.Columns["is_id"].Visible = false; // datagrid de is_id kolonunu göstermiyoruz ;)
            dataGridView3.Columns["is_barkod"].Visible = false;
            dataGridView3.Columns["is_not"].Visible = false;

            dataGridView3.Columns["is_mus"].Visible = false;

            dataGridView3.Columns[0].Width = 60; // sütun genişliği ayarlama
            dataGridView3.Columns[1].Width = 200;
            dataGridView3.Columns[2].Width = 100;
            dataGridView3.Columns[3].Width = 50;


            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // otomatik kaplama
        }

        private void ara_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string kelime = textBox1.Text;

            string cek = "SELECT*FROM isler WHERE is_mus=@is_mus AND is_adi LIKE  @kelime ";

            MySqlCommand mykomi = new MySqlCommand(cek, baglan);

            mykomi.Parameters.AddWithValue("@is_mus", guncelle_id);

            mykomi.Parameters.AddWithValue("@kelime", "%"+textBox1.Text+"%");

            MySqlDataAdapter mda = new MySqlDataAdapter(mykomi);

            DataSet ds = new DataSet();

            mda.Fill(ds, "isler");

            dataGridView3.DataSource = ds.Tables[0];


            // satırların renk ayarı
            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {
                Application.DoEvents();

                int sayiHesap = i % 2;

                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if (sayiHesap != 0)
                {
                    renk.BackColor = Color.DarkBlue;
                }
                else if (sayiHesap == 0)
                {
                    renk.BackColor = Color.DarkSlateGray;
                }

                dataGridView3.Rows[i].DefaultCellStyle = renk;
            }

            // renk bitti

            baglan.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            mus_dok2();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
