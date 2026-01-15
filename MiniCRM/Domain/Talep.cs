using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCRM.Domain
{
    public class Talep
    {
        public int TalepId { get; set; }
        public int MusteriId { get; set; }
        public int HizmetId { get; set; }
        public int? PersonelId { get; set; }   
        public string Durum { get; set; }
        public string Aciklama { get; set; }
        public DateTime TalepTarihi { get; set; }
    }
}
