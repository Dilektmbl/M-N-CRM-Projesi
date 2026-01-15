using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCRM.Domain
{
    public class TalepListeDto
    {
        public int TalepId { get; set; }
        public string MusteriAdi { get; set; }
        public string HizmetAdi { get; set; }
        public string PersonelAdi { get; set; }
        public string Durum { get; set; }
        public string Aciklama { get; set; }
        public DateTime TalepTarihi { get; set; }
    }

}
