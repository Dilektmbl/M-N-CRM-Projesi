using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniCRM.DAO;
using MiniCRM.Domain;

namespace MiniCRM.Service
{
    public class TalepService
    {
        public static void TalepEkle(Talep t)
        {
            if (t.MusteriId <= 0 || t.HizmetId <= 0)
                throw new Exception("Müşteri ve Hizmet seçilmelidir.");

            TalepDao.TalepEkle(t);
        }

        public static List<Talep> TalepListele()
        {
            return TalepDao.TalepListele();
        }
        public static DataTable TalepListeleDT()
        {
            return TalepDao.TalepListeleDT();
        }
        public static void TalepSil(int talepId)
        {
            TalepDao.TalepSil(talepId);
        }
        public static void TalepGuncelle(int talepId, string durum, int? personelId, string aciklama)
        {
            TalepDao.TalepGuncelle(talepId, durum, personelId, aciklama);
        }

        public static DataTable HizmetBazliTalepSayisi(DateTime baslangic, DateTime bitis)
        {
            return TalepDao.HizmetBazliTalepSayisi(baslangic, bitis);
        }
        public static DataTable PersonelBazliTalepSayisi(DateTime baslangic, DateTime bitis)
        {
            return TalepDao.PersonelBazliTalepSayisi(baslangic, bitis);

        }
        public static DataTable TumTalepler(DateTime baslangic, DateTime bitis)
        {
            return TalepDao.TumTalepler(baslangic, bitis);
        }
        public static DataTable MusteriBazliTalepSayisi(DateTime baslangic, DateTime bitis)
        {
            return TalepDao.MusteriBazliTalepSayisi(baslangic, bitis);
        }
        public static double OrtalamaMemnuniyetGetir(DateTime? bas, DateTime? bit)
        {
            return GeriBildirimDao.OrtalamaMemnuniyet(bas, bit);
        }

        public static DataTable PuanDagilimiGetir(DateTime? bas, DateTime? bit)
        {
            return GeriBildirimDao.PuanDagilimi(bas, bit);
        }
        public static DataTable PersonelBazliMemnuniyetGetir(DateTime? bas, DateTime? bit)
        {
            return GeriBildirimDao.PersonelBazliMemnuniyet(bas, bit);
        }
    }
}
