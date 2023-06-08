using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takibi
{
    class AnaSinif // Admin için gerekli, DB'de admin tablosu
    {
        private int id;

        private string isim, sifre;

        public string Isim { get => isim; set => isim = value; }
         
        public string Sifre
        {
            get { return sifre; }
            set
            {
                if (sifre.Length < 4)
                { MessageBox.Show("Şifre 4 Haneden küçük olamaz!", "Bilgilendirme : ", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                 
            }
        }
        public int Id { get => id; set => id = value; }

       

    }
}
