using MySql.Data.MySqlClient;
using System;
 
using System.Data;
using System.Drawing;
 
using System.Windows.Forms;

namespace is_takibi
{
    public partial class CalisanIK: Form
    {
        public CalisanIK()
        {
            InitializeComponent();
        }

        // MySql veritabanına balantı yapılıyor!

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        MySqlDataAdapter mda;

        DataSet ds;

        public static int oturum_id2 { get; set; }


        public void cal_dok()
        {

            baglan.Open();

            string cek = "SELECT*FROM calisan,istasyon WHERE c_ist_id=ist_id  ORDER BY c_isim ASC ";

            mda = new MySqlDataAdapter(cek, baglan);

            ds = new DataSet();

            mda.Fill(ds, "calisan,istasyon");

            dataGridView5.DataSource = ds.Tables[0];

            // satırların renk ayarı
            for (int j = 0; j < dataGridView5.Rows.Count - 1; j++)
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

                dataGridView5.Rows[j].DefaultCellStyle = renk;
            }

            // renk bitti


            baglan.Close();


        }

        public void ist_dok()
        {

            baglan.Open();

            string cek = "SELECT * FROM istasyon ";

            mda = new MySqlDataAdapter(cek, baglan);

            ds = new DataSet();

            mda.Fill(ds, "istasyon"); // deneme isimli database deki musteri isimli tablo

            comboBox1.ValueMember = "ist_id";

            comboBox1.DisplayMember = "ist_isim"; // istasyon ismindeki tablodaki, ist_isim isimli sütun (isimleri çekiyoruz)

            comboBox1.DataSource = ds.Tables[0];

            baglan.Close();
        }

        public void kullanici_belirle()
        {

            baglan.Open();

            string oturumCek = "SELECT*FROM calisan WHERE c_id=@c_id";
            MySqlCommand komutlar = new MySqlCommand(oturumCek, baglan);

            komutlar.Parameters.AddWithValue("@c_id", oturum_id2);

            MySqlDataReader dr = komutlar.ExecuteReader();

            if (dr.Read())
            {
                label7.Text = dr["c_isim"].ToString();
            }


            baglan.Close();


        }

 

        private void CalisanIK_Load(object sender, EventArgs e)
        {

            cal_dok();
            ist_dok();
            kullanici_belirle();

        }

        private void is_ekle_Click(object sender, EventArgs e)
        {
            if (isim.Text.Length == 0 || c_sifre.Text.Length == 0)
            {
                MessageBox.Show("Çalışan Adı ve Şifre Boş Bırakılamaz!\n\nEkleme Yapılamadı!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                baglan.Open();

                // burda kaldın...

                string yil = DateTime.Now.ToShortDateString(); // gün.ay.yil olarak verir


                MySqlCommand ekle = new MySqlCommand("INSERT INTO calisan (c_isim,c_ist_id,c_bilgi,c_yil,c_sifre,c_tc) VALUES (@c_isim,@c_ist_id,@c_bilgi,@c_yil,@c_sifre,@c_tc)", baglan);

                ekle.Parameters.AddWithValue("@c_isim", isim.Text);
                ekle.Parameters.AddWithValue("@c_ist_id", comboBox1.SelectedValue);
                ekle.Parameters.AddWithValue("@c_bilgi", ac.Text);
                ekle.Parameters.AddWithValue("@c_yil", yil);
                ekle.Parameters.AddWithValue("@c_sifre", c_sifre.Text);
                ekle.Parameters.AddWithValue("@c_tc", tc_no.Text);

                ekle.ExecuteNonQuery();

                MessageBox.Show("Yeni Çalışan başarıyla eklendi!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isim.Text = "";
                ac.Text = "";
                c_sifre.Text = "";
                tc_no.Text = "";


                baglan.Close();

                cal_dok();
            }
        }




        private void dataGridView5_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //datagrid özellikleri
            //dataGridView5_DataBindingComplete CalisanIK.Designer'a atanmaz ise manuel atama yapmak lazım.
            //Copy / paste - >dataGridView5'e
            //this.dataGridView5.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView5_DataBindingComplete);
            dataGridView5.Columns["c_id"].Visible = false;
             
            dataGridView5.Columns["c_yil"].Visible = false;
            dataGridView5.Columns["c_sifre"].Visible = false;
            dataGridView5.Columns["c_ist_id"].Visible = false;
            dataGridView5.Columns["ist_id"].Visible = false;
            dataGridView5.Columns["ist_ac"].Visible = false;

            dataGridView5.Columns[0].Width = 50; // sütun genişliği ayarlama
            dataGridView5.Columns[1].Width = 200;
            dataGridView5.Columns[2].Width = 250;
            dataGridView5.Columns[3].Width = 250;


            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // otomatik kaplama
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            cal_dok();
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

            string cek2 = "SELECT*FROM calisan,istasyon WHERE  c_isim LIKE  @kelime  AND c_ist_id=ist_id";
 
            MySqlCommand mykomi = new MySqlCommand(cek2, baglan);
            mykomi.Parameters.AddWithValue("@kelime", "%"+textBox1.Text+"%");

            MySqlDataAdapter mda2 = new MySqlDataAdapter(mykomi);

            DataSet ds2 = new DataSet();

            mda2.Fill(ds2, "calisan,istasyon");

            dataGridView5.DataSource = ds2.Tables[0];

            // satırların renk ayarı
            for (int i = 0; i < dataGridView5.Rows.Count - 1; i++)
            {
                Application.DoEvents();

                int sayiHesapj = i % 2;

                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if (sayiHesapj != 0)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                else if (sayiHesapj == 0)
                {
                    renk.BackColor = Color.Pink;
                }

                dataGridView5.Rows[i].DefaultCellStyle = renk;
            }

            // renk bitti


            baglan.Close();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Bu çalışanı silerseniz, bu çalışanın yaptığı işlerde ismi gözükmeyecektir!\n\nBu çalışanı yine de silmek istiyor musunuz?", "Çalışan Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dataGridView5.SelectedRows)  //Seçili Satırları Silme
                {
                    int numara = Convert.ToInt32(drow.Cells[0].Value);

                    baglan.Open();


                    MySqlCommand silelim = new MySqlCommand("DELETE FROM calisan WHERE c_id=" + numara, baglan);

                    silelim.ExecuteNonQuery();

                    MessageBox.Show("Çalışan başarıyla silindi!", "Bilgilendirme :");

                    baglan.Close();

                }

                cal_dok();
            }
            else if (secenek == DialogResult.No)
            {

            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            int g_id = Convert.ToInt32(dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells["c_id"].Value); // id çekme kodu ;)

            CIKguncelle cikg = new CIKguncelle();

            cikg.guncelle_id = g_id; // ÖNEMli: guncelle_id'yi Form5 te oluştur ve burada seçili olan id'yi ona ata ;) sonra form5 te çağır...

            cikg.Show();  // form5 göster diyoruz
        }
 

   

        private void button1_Click(object sender, EventArgs e)
        {
            SifrePaneliCalisan sifrePan = new SifrePaneliCalisan();

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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void c_sifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
