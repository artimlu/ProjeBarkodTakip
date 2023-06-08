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
    public partial class MusteriTakip : Form
    {
        public MusteriTakip()
        {
            InitializeComponent();
        }

        public int oturumTakip { get; set; }
        public string barkodNo { get; set; }
 
       

        private void MusteriTakip_Load(object sender, EventArgs e)
        {

            // MySql veritabanına balantı yapılıyor!

            MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

            baglan.Open();

            string sorgu = "SELECT* FROM takip WHERE t_barkod=@kelime ORDER BY t_id ASC";

            MySqlCommand mykomi = new MySqlCommand(sorgu, baglan);

            mykomi.Parameters.AddWithValue("@kelime", barkodNo);

            MySqlDataAdapter mda = new MySqlDataAdapter(mykomi);

            DataSet ds = new DataSet();

            mda.Fill(ds, "takip");

            dataGridViewTakipM.DataSource = ds.Tables[0];

            baglan.Close();

        }

        private void dataGridViewTakipM_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewTakipM.Columns["t_id"].Visible = false; // datagrid de is_id kolonunu göstermiyoruz ;)


            dataGridViewTakipM.Columns[0].Width = 60; // sütun genişliği ayarlama


            dataGridViewTakipM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // otomatik kaplama
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
