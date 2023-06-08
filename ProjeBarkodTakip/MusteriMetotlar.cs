 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace is_takibi
{
    class MusteriMetotlar : Interface1
    {
        public string adSoyad { get ; set ; }

        public static int oturumId { get; set; }

        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=wwwajan_barkod;Uid=root;Pwd=;Charset=utf8");

        MySqlDataAdapter mda;

        


        public void bilgi()
        {
            MessageBox.Show("İşlem Başarıyla yapıldı!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void uyari()
        {
            MessageBox.Show("İşlem Başarısız!\n\nTekrar Deneyin", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public string isimCek()
        {
           baglan.Open();

            string cek = "SELECT*FROM musteri WHERE m_id=@m_id";

            MySqlCommand komut = new MySqlCommand(cek,baglan);

            komut.Parameters.AddWithValue("@m_id",oturumId);

            MySqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
 
                 adSoyad= dr["m_isim"].ToString();
 
            }

            baglan.Close();

            return adSoyad;
        }




    }
}
