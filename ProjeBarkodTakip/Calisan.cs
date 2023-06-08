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
using Microsoft.VisualBasic;

namespace is_takibi
{
    public partial class Calisan : Form
    {
        public Calisan()
        {
            InitializeComponent();
        }
        // MySql veritabanına balantı yapılıyor!
        MySqlConnection baglan = new MySqlConnection("Server=89.163.242.122;Port=3306;Database=wwwajan_barkod;Uid=wwwajan_barkod;Pwd='barkod1234';Charset=utf8");

        string istasyon_isim;

        int barkod_varmi = 0;
        int takipte_bu_calisan_varmi = 0;
       
        public int oturum_id { get; set; }

        public int istId { get; set; }

        public string isimCek { get; set; }

 


        private void Ist_Adi_Getir()
        {
            baglan.Open();

            string oturumCek23 = "SELECT ist_isim FROM istasyon WHERE ist_id=@istt";
            MySqlCommand komutlar23 = new MySqlCommand(oturumCek23, baglan);
            komutlar23.Parameters.AddWithValue("@istt", istId);
            MySqlDataReader dree = komutlar23.ExecuteReader();


            if (dree.Read())
            {
                istasyon_isim = dree["ist_isim"].ToString();
            }


            baglan.Close();
        }

        
        private void Calisan_Load(object sender, EventArgs e)
        {
            Ist_Adi_Getir();

            label7.Text = isimCek + " ("+ istasyon_isim +")";

            this.ActiveControl = isim;

           
  
        }

        

        private void sifre_Click(object sender, EventArgs e)
        {
            SifrePaneliCalisan sifrePan = new SifrePaneliCalisan();

            sifrePan.oturum_id2 = oturum_id;
            
            sifrePan.Show();

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Close();
            //Application.Exit();
        }



        private void getir_Click_1(object sender, EventArgs e)
        {

            baglan.Open();

            string oturumCek2 = "SELECT COUNT(*) FROM isler WHERE is_barkod=@barkod";
            MySqlCommand komutlar2 = new MySqlCommand(oturumCek2, baglan);
            komutlar2.Parameters.AddWithValue("@barkod", isim.Text);
            barkod_varmi = Convert.ToInt32(komutlar2.ExecuteScalar()); // girilen barkod no, veritabanında var mı yok mu? integer değer ata

            // çok çok önemli: burada datareader olmadan veri alabildik -> komutlar2.ExecuteScalar()

            string oturumCek22 = "SELECT COUNT(*) FROM takip WHERE t_barkod=@barkod2 AND t_calisan=@isim ";
            MySqlCommand komutlar221 = new MySqlCommand(oturumCek22, baglan);
            komutlar221.Parameters.AddWithValue("@barkod2", isim.Text);
            komutlar221.Parameters.AddWithValue("@isim", isimCek);
            takipte_bu_calisan_varmi = Convert.ToInt32(komutlar221.ExecuteScalar()); // girilen barkod no'yu daha önce bu çalışan girdi mi? integer değer ata



            if (barkod_varmi > 0 && takipte_bu_calisan_varmi == 0 ) // db'de barkod no'su varsa ve çalışan daha önce giriş yapMAdıysa bunu yap...
            {

                 DialogResult secenek = MessageBox.Show("Bu işe Başlamak istiyor musunuz?", "İşe Başlama Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                   if (secenek == DialogResult.Yes)
                   {
                                    string yil = DateTime.Now.ToShortDateString(); // gün.ay.yil olarak verir

                                    DateTime dtAl = DateTime.Now;
                                    string saatAl = dtAl.ToString("HH:mm:ss");

                                    string tarih = yil + " " + saatAl;

                                    string ekleme = "INSERT INTO takip (t_tarih,t_barkod,t_ist,t_calisan) VALUES (@t_tarih,@t_barkod,@t_ist,@t_calisan)";

                                         MySqlCommand basla = new MySqlCommand(ekleme, baglan);
                                            basla.CommandTimeout = 200; // exeption'dan kaçınmak için lazım...
                                    

                                        basla.Parameters.AddWithValue("@t_tarih", tarih);
                                        basla.Parameters.AddWithValue("@t_barkod", isim.Text);
                                        basla.Parameters.AddWithValue("@t_ist", istasyon_isim);
                                        basla.Parameters.AddWithValue("@t_calisan", isimCek);

                                         basla.ExecuteNonQuery();

                                        MessageBox.Show("işe başlandı!", "Bilgilendirme :");

                                        isim.Text = "";
                                
                   }
                   
                    else if (secenek == DialogResult.No)
                    {
                        //Hayırsa bişey yapma...
                    }
              
            }

            else if (barkod_varmi > 0 && takipte_bu_calisan_varmi > 0) // db'de barkod no'su varsa ve çalışan daha önce giriş yaptıysa bunu yap...
            {

                DateTime bugun = DateTime.Now;
                string notGirisi = Interaction.InputBox("Bu Barkod ile daha önceden işe başlama yaptınız.\nBu işe Not eklemek istiyorsanız, aşağıdaki kutucuğu doldurunuz...", "Uyarı Penceresi", isimCek + ": ", 150, 150);
                //1 - Interaction.InputBox kullanabilmek için önce Referanslardan (başvurulardan) Windows.VisualBasic projeye eklenmeli
                //2- üste using Microsoft.VisualBasic; çağırılmalı

                if (notGirisi != "") 
                {

                    string yeniYazi = Environment.NewLine + Environment.NewLine + notGirisi + " ( " + bugun + " ) ";
                    string notDuz = "UPDATE isler SET is_not=concat(is_not,@yazi) WHERE is_barkod=@barkod"; // concat -> update işleminde içeriği silmeden ekleme yapar...
                    MySqlCommand mycom = new MySqlCommand(notDuz, baglan);
                    mycom.CommandTimeout = 200;  // exeption'dan kaçınmak için lazım...
                    mycom.Parameters.AddWithValue("@yazi", yeniYazi);
                    mycom.Parameters.AddWithValue("@barkod", isim.Text);
                    mycom.ExecuteNonQuery();
                    MessageBox.Show("Not başarıyla girildi!", "Bilgilendirme :", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else // Interaction.InputBox 'da iptal tuşuna basılırsa...
                {

                }

            }

            else // barkod no yoksa 
            {

                MessageBox.Show("Barkod Numarası Yanlış!\n\nYeniden Deneyin!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

                baglan.Close();

            

        }

        private void isim_TextChanged_1(object sender, EventArgs e)
        {
           // string txt = this.isim.Text;
           // this.isim.Text = string.Empty;
        }

        
    }
}
