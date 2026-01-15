using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MiniCRM.Domain;

namespace MiniCRM.DAO
{
    public class KullaniciDao
    {
        public Kullanici GirisYap(string kadi, string sifre)
        {
            using (var conn = DbBaglanti.GetConnection())
            {
                string sql = "SELECT * FROM Kullanici WHERE KullaniciAdi=@k AND Sifre=@s";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@k", kadi);
                cmd.Parameters.AddWithValue("@s", sifre);

                conn.Open();
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return new Kullanici
                    {
                        KullaniciId = dr.GetInt32("KullaniciId"),
                        KullaniciAdi = dr.GetString("KullaniciAdi"),
                        Rol = dr.GetString("Rol")
                    };
                }
            }
            return null;
        }
        public bool KayitOl(string kullaniciAdi, string sifre, string rol)
        {
            using (var conn = DbBaglanti.GetConnection())
            {
                string sql = @"INSERT INTO Kullanici (KullaniciAdi, Sifre, Rol)
                       VALUES (@adi, @sifre, @rol)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@adi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.Parameters.AddWithValue("@rol", rol);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }

}

