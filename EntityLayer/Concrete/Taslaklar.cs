using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Taslaklar
    {
        [Key]
        public int TaslakID { get; set; }

        [StringLength(50)]
        public string Kime { get; set; }

        [StringLength(100)]
        public string Konu { get; set; }

        [StringLength(1000)]
        public string Icerik { get; set; }
    }
}
