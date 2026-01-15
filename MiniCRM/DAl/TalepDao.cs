using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MiniCRM.Domain;
using System.Data;

namespace MiniCRM.DAO
{
    public class TalepDao
    {
        public static void TalepEkle(Talep t)
        {
            MySqlConnection conn = DbBaglanti.GetConnection();
            MySqlCommand cmd = new MySqlCommand(@"
        INSERT INTO Talep
        (MusteriId, HizmetId, PersonelId, Durum, Aciklama, TalepTarihi)
        VALUES
        (@musteri, @hizmet, @personel, @durum, @aciklama, @tarih)", conn);

            cmd.Parameters.AddWithValue("@musteri", t.MusteriId);
            cmd.Parameters.AddWithValue("@hizmet", t.HizmetId);
            cmd.Parameters.AddWithValue("@personel", t.PersonelId);
            cmd.Parameters.AddWithValue("@durum", t.Durum);
            cmd.Parameters.AddWithValue("@aciklama", t.Aciklama);
            cmd.Parameters.AddWithValue("@tarih", t.TalepTarihi);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static List<Talep> TalepListele()
        {
            List<Talep> liste = new List<Talep>();
            MySqlConnection conn = DbBaglanti.GetConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Talep", conn);

            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int? personelId = null;

                if (!dr.IsDBNull(dr.GetOrdinal("PersonelId")))
                {
                    personelId = dr.GetInt32("PersonelId");
                }

                liste.Add(new Talep
                {
                    TalepId = dr.GetInt32("TalepId"),
                    MusteriId = dr.GetInt32("MusteriId"),
                    HizmetId = dr.GetInt32("HizmetId"),
                    PersonelId = personelId,
                    TalepTarihi = dr.GetDateTime("TalepTarihi"),
                    Aciklama = dr.GetString("Aciklama"),
                    Durum = dr.GetString("Durum")
                });
            }

            conn.Close();
            return liste;
        }
        public static DataTable TalepListeleDT()
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = DbBaglanti.GetConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Talep ORDER BY TalepTarihi DESC", conn);

            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();

            return dt;
        }
        public static void TalepSil(int talepId)
        {
            MySqlConnection conn = DbBaglanti.GetConnection();
            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM Talep WHERE TalepId = @id", conn);

            cmd.Parameters.AddWithValue("@id", talepId);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void TalepGuncelle(int talepId, string durum, int? personelId, string aciklama)
        {
            using (MySqlConnection conn = DbBaglanti.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(@"
            UPDATE Talep
            SET Durum = @durum,
                PersonelId = @personelId,
                Aciklama = @aciklama
            WHERE TalepId = @talepId", conn);

                cmd.Parameters.AddWithValue("@durum", durum);
                cmd.Parameters.AddWithValue("@personelId",
                    personelId.HasValue ? (object)personelId.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@aciklama", aciklama);
                cmd.Parameters.AddWithValue("@talepId", talepId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public static DataTable HizmetBazliTalepSayisi(DateTime baslangic, DateTime bitis)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = DbBaglanti.GetConnection())
            {
                string sql = @"
        SELECT 
            h.HizmetAdi,
            COUNT(t.TalepId) AS TalepSayisi
        FROM Talep t
        INNER JOIN Hizmet h ON h.HizmetId = t.HizmetId
        WHERE t.TalepTarihi BETWEEN @baslangic AND @bitis
        GROUP BY h.HizmetAdi";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@baslangic", baslangic);
                    cmd.Parameters.AddWithValue("@bitis", bitis);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }
        public static DataTable PersonelBazliTalepSayisi(DateTime baslangic, DateTime bitis)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = DbBaglanti.GetConnection())
            {
                string sql = @"
                SELECT
                    p.AdSoyad AS PersonelAdi,
                    COUNT(t.TalepId) AS TalepSayisi
                FROM Talep t
                INNER JOIN Personel p ON p.PersonelId = t.PersonelId
                WHERE t.TalepTarihi BETWEEN @baslangic AND @bitis
                GROUP BY p.AdSoyad;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@baslangic", baslangic);
                    cmd.Parameters.AddWithValue("@bitis", bitis);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public static DataTable MusteriBazliTalepSayisi(DateTime baslangic, DateTime bitis)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = DbBaglanti.GetConnection())
            {
                string sql = @"
        SELECT
            m.AdSoyad AS MusteriAdi,
            COUNT(t.TalepId) AS TalepSayisi
        FROM Talep t
        INNER JOIN Musteri m ON m.MusteriId = t.MusteriId
        WHERE t.TalepTarihi BETWEEN @baslangic AND @bitis
        GROUP BY m.AdSoyad;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@baslangic", baslangic);
                    cmd.Parameters.AddWithValue("@bitis", bitis);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }


        public static DataTable TumTalepler(DateTime baslangic, DateTime bitis)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = DbBaglanti.GetConnection())
            {
                string sql = @"
        SELECT 
            t.TalepId,
            m.AdSoyad AS Musteri,
            h.HizmetAdi,
            p.AdSoyad AS Personel,
            t.Durum,
            t.Aciklama,
            t.TalepTarihi
        FROM Talep t
        INNER JOIN Musteri m ON m.MusteriId = t.MusteriId
        INNER JOIN Hizmet h ON h.HizmetId = t.HizmetId
        LEFT JOIN Personel p ON p.PersonelId = t.PersonelId
        WHERE t.TalepTarihi BETWEEN @baslangic AND @bitis
        ORDER BY t.TalepTarihi DESC";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@baslangic", baslangic);
                    cmd.Parameters.AddWithValue("@bitis", bitis);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }
        public static double OrtalamaMemnuniyet(DateTime? bas, DateTime? bit)
        {
            using (MySqlConnection conn = DbBaglanti.GetConnection())
            {
                string sql = "SELECT AVG(Puan) FROM GeriBildirim WHERE 1=1";

                if (bas != null) sql += " AND Tarih >= @bas";
                if (bit != null) sql += " AND Tarih <= @bit";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    if (bas != null) cmd.Parameters.AddWithValue("@bas", bas.Value);
                    if (bit != null) cmd.Parameters.AddWithValue("@bit", bit.Value);

                    conn.Open();
                    object sonuc = cmd.ExecuteScalar();
                    return (sonuc == DBNull.Value || sonuc == null) ? 0 : Convert.ToDouble(sonuc);
                }
            }
        }
        public static System.Data.DataTable PuanDagilimi(DateTime? bas, DateTime? bit)
        {
            using (MySqlConnection conn = DbBaglanti.GetConnection())
            {
                string sql = @"
            SELECT Puan, COUNT(*) AS Adet
            FROM GeriBildirim
            WHERE 1=1";

                if (bas != null) sql += " AND Tarih >= @bas";
                if (bit != null) sql += " AND Tarih <= @bit";

                sql += " GROUP BY Puan ORDER BY Puan";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    if (bas != null) cmd.Parameters.AddWithValue("@bas", bas.Value);
                    if (bit != null) cmd.Parameters.AddWithValue("@bit", bit.Value);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        public static System.Data.DataTable PersonelBazliMemnuniyet(DateTime? bas, DateTime? bit)
        {
            using (MySqlConnection conn = DbBaglanti.GetConnection())
            {
                string sql = @"
            SELECT p.AdSoyad AS Personel, AVG(gb.Puan) AS OrtalamaPuan, COUNT(*) AS Adet
            FROM GeriBildirim gb
            INNER JOIN Talep t ON t.TalepId = gb.TalepId
            INNER JOIN Personel p ON p.PersonelId = t.PersonelId
            WHERE 1=1";

                if (bas != null) sql += " AND gb.Tarih >= @bas";
                if (bit != null) sql += " AND gb.Tarih <= @bit";

                sql += " GROUP BY p.AdSoyad ORDER BY OrtalamaPuan DESC";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    if (bas != null) cmd.Parameters.AddWithValue("@bas", bas.Value);
                    if (bit != null) cmd.Parameters.AddWithValue("@bit", bit.Value);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }



    }
}

