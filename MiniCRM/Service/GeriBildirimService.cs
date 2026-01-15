using MiniCRM.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCRM.Service
{
    public static class GeriBildirimService
    {
        public static void MemnuniyetKaydet(int talepId, int puan, string yorum)
        {
            if (talepId <= 0) throw new Exception("Talep seçiniz.");
            if (puan < 1 || puan > 5) throw new Exception("Puan 1 ile 5 arasında olmalıdır.");

            if (GeriBildirimDao.TalepIcinVarMi(talepId))
                throw new Exception("Bu talep için zaten memnuniyet girilmiş.");

            GeriBildirimDao.GeriBildirimEkle(talepId, puan, yorum);
        }

        public static double OrtalamaMemnuniyetGetir(DateTime? bas, DateTime? bit)
            => GeriBildirimDao.OrtalamaMemnuniyet(bas, bit);

        public static DataTable PuanDagilimiGetir(DateTime? bas, DateTime? bit)
            => GeriBildirimDao.PuanDagilimi(bas, bit);
    }
}
