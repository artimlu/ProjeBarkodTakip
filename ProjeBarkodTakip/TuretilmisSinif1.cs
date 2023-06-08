using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takibi
{
    class TuretilmisSinif1 : AnaSinif
    {

        private int istId;

        private string tel, adres, mail;

        public int IstId { get => istId; set => istId = value; }

        public string Tel { get => tel; set => tel = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Mail { get => mail; set => mail = value; }       

        public void Yazdir()
        {

            MessageBox.Show("HAKKIMIZDA\nBu yazılım aşağıda bilgileri verilen firma tarafından yapılmış olup, Hiçbir suretle izinsiz kopyalanamaz, silinemez ve çoğaltılamaz. Şikayet ve Önerileriniz için gerekli bilgiler aşağıdadır...\n\nYazılımcı: " + Isim + "\nE-Posta : " + mail + "\nTelefon : " + tel,"YARDIM", MessageBoxButtons.OK, MessageBoxIcon.Question);
             
        }
    }
}
