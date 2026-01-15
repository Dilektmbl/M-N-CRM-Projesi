using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCRM.Domain
{
    public class GeriBildirim
    {
        public int GeriBildirimId { get; set; }
        public int TalepId { get; set; }
        public int Puan { get; set; }           
        public string Yorum { get; set; }       
        public DateTime Tarih { get; set; }    
    }
}
