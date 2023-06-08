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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Access veritabanına balantı yapılıyor!
        // OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=VeriTabani.accdb");

        // MySql veritabanına balantı yapılıyor!
        MySqlConnection baglan = new MySqlConnection("Server=localhost;Port=3306;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        //mysql uzak veritabanı kullanıcı erişimi izin kodu-> GRANT ALL ON wwwajan_barkod.* TO 'wwwajan_barkod'@'%' IDENTIFIED BY 'barkod1234';

        private void giris_Click(object sender, EventArgs e)
        {

            
             
            if(isim.Text.Length== 0 || sifre.Text.Length == 0)
            {
                MessageBox.Show("Alanları Boş Bırakmayınız!\n\nGiriş YAPILAMADI!", "Bilgilendirme : "
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {


                if (yonetici.Checked == true)
                {

                    baglan.Open();

                    string sorgu = "SELECT * FROM Admin WHERE tc_no=@tcc AND sifre=@sifre";
 
                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);

                    cmd.Parameters.AddWithValue("@tcc", isim.Text);
                    cmd.Parameters.AddWithValue("@sifre", sifre.Text);

                    MySqlDataReader dr = cmd.ExecuteReader();

 

                    if (dr.Read())
                    {
                        int oturum = (int)dr["id"];
                        Form2 form2 = new Form2();
                        Form2.oturum_id = oturum;


                        form2.Show();  // form2 göster diyoruz
                        this.Hide();   // bunu yani form1'i gizle diyoruz
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı ya da şifre yanlış!\n\nGiriş YAPILAMADI!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    baglan.Close();


                }


                else
                {
                    baglan.Open();

                    string sorguc = "SELECT * FROM calisan WHERE c_tc=@isim AND c_sifre=@sifre";

                    MySqlCommand cmdc = new MySqlCommand(sorguc, baglan);

                    cmdc.Parameters.AddWithValue("@isim", isim.Text);
                    cmdc.Parameters.AddWithValue("@sifre", sifre.Text);

                    MySqlDataReader drc = cmdc.ExecuteReader();
                    if (drc.Read())
                    {
                        int oturum = (int)drc["c_id"];
                        int ista = (int)drc["c_ist_id"];
                        string oturumAd = drc["c_isim"].ToString();
                        int bolum = (int)drc["c_ist_id"];
                        


                        if (bolum == 3)
                        {
                            CalisanMuhasebe cm = new CalisanMuhasebe();
                            CalisanMuhasebe.oturum_id2 = oturum;
                            cm.Show(); 
                            this.Hide();  
                        }
                        else if (bolum == 7)
                        {
                            CalisanIK c_ik=new CalisanIK();
                            CalisanIK.oturum_id2 = oturum;
                            c_ik.Show();
                            this.Hide();

                        }
                        else if (bolum == 6)
                        {
                            CalisanMusteri cmus = new CalisanMusteri();
                            CalisanMusteri.oturum_id2 = oturum;
                            cmus.Show();
                            this.Hide();

                        }

                        else if (bolum == 4)
                        {
                            CalisanSatinAlma csm = new CalisanSatinAlma();
                            CalisanSatinAlma.oturum_id2 = oturum;
                            csm.Show();
                            this.Hide();

                        }

                        else if (bolum == 5)
                        {  
                            CalisanDepo cdepo = new CalisanDepo();
                            CalisanDepo.oturum_id2 = oturum;
                            cdepo.Show();
                            this.Hide();

                        }
                        else if (bolum == 8)
                        {
                           CalisanKayit c_k = new CalisanKayit();
                           CalisanKayit.oturum_id = oturum;
                           c_k.Show();
                           this.Hide();

                        }
                        else if (bolum == 5)
                        {
                            CalisanDepo cdepo = new CalisanDepo();
                            CalisanDepo.oturum_id2 = oturum;
                            cdepo.Show();
                            this.Hide();

                        }
                        else
                        {
                            Calisan calisan = new Calisan();
                            calisan.oturum_id = oturum;
                            calisan.isimCek = oturumAd;
                            calisan.istId = ista;
                            calisan.Show();  // calisan göster diyoruz
                            this.Hide();   // bunu yani form1'i gizle diyoruz
                        }


                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı ya da şifre yanlış!\n\nGiriş YAPILAMADI!",
                            "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    baglan.Close();

                }


            }
           


           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             sifre.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriPaneli mus = new MusteriPaneli();
 
            mus.Show();  // form2 göster diyoruz
            this.Hide();   // bunu yani form
        }

 


        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TuretilmisSinif1 turet = new TuretilmisSinif1();

            turet.Isim = "Dila-Hüseyin";
            turet.Mail = "gazi@gazi.edu.tr";
            turet.Tel = "05308748080";


            turet.Yazdir();

             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
