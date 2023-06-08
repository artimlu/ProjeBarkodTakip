 
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
    public partial class CalisanDepoGoster: Form
    {
        public CalisanDepoGoster()
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

       

        private void CalisanDepoGoster_Load(object sender, EventArgs e)
        {
            mus_dok();
             
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

       
    }
}
