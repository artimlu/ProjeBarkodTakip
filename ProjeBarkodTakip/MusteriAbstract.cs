using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_takibi
{
    public abstract class MusteriAbstract
    {
        public int oturumTakip { get; set; }
        public string barkodNo { get; set; }
        public abstract void uyari();
      
       
        
    }
}
