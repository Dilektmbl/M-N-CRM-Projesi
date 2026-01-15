using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MiniCRM.DAO
{
    public class GeriBildirimDao
    {
        public static bool TalepIcinVarMi(int talepId)
        {
            using (MySqlConnection conn = DbBaglanti.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM GeriBildirim WHERE TalepId=@talepId", conn))
                {
                    cmd.Parameters.AddWithValue("@talepId", talepId);

                    conn.Open();
                    int adet = Convert.ToInt32(cmd.ExecuteScalar());
                    return adet > 0;
                }
            }
        }

        public static int GeriBildirimEkle(int talepId, int puan, string yorum)
        {
            using (MySqlConnection conn = DbBaglanti.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(@"
                    INSERT INTO GeriBildirim (TalepId, Puan, Yorum)
                    VALUES (@talepId, @puan, @yorum);", conn))
                {
                    cmd.Parameters.AddWithValue("@talepId", talepId);
                    cmd.Parameters.AddWithValue("@puan", puan);
                    cmd.Parameters.AddWithValue("@yorum",
                        string.IsNullOrWhiteSpace(yorum) ? (object)DBNull.Value : yorum);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
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
                    return (sonuc == null || sonuc == DBNull.Value) ? 0 : Convert.ToDouble(sonuc);
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

                    using (MySql.Data.MySqlClient.MySqlDataAdapter da = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        public static DataTable PersonelBazliMemnuniyet(DateTime? bas, DateTime? bit)
        {
            using (MySqlConnection conn = DbBaglanti.GetConnection())
            {
                string sql = @"
                    SELECT 
                        p.AdSoyad AS Personel,
                        AVG(gb.Puan) AS OrtalamaPuan,
                        COUNT(*) AS Adet
                    FROM GeriBildirim gb
                    INNER JOIN Talep t ON t.TalepId = gb.TalepId
                    INNER JOIN Personel p ON p.PersonelId = t.PersonelId
                    WHERE 1=1";

                if (bas != null) sql += " AND gb.Tarih >= @bas";
                if (bit != null) sql += " AND gb.Tarih <= @bit";

                sql += @"
                    GROUP BY p.AdSoyad
                    ORDER BY OrtalamaPuan DESC;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    if (bas != null) cmd.Parameters.AddWithValue("@bas", bas.Value);
                    if (bit != null) cmd.Parameters.AddWithValue("@bit", bit.Value);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
