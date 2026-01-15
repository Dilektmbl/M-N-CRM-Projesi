using MiniCRM.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCRM.DAO
{
    public class HizmetDao
    {
        public static List<Hizmet> HizmetListele()
        {
            List<Hizmet> liste = new List<Hizmet>();
            MySqlConnection conn = DbBaglanti.GetConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Hizmet", conn);

            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                liste.Add(new Hizmet
                {
                    HizmetId = dr.GetInt32("HizmetId"),
                    HizmetAdi = dr.GetString("HizmetAdi"),
                    Aciklama = dr.GetString("Aciklama"),
                    Ucret = dr.GetDecimal("Ucret")
                });
            }

            conn.Close();
            return liste;
        }

        public static void HizmetGuncelle(Hizmet h)
        {
            MySqlConnection conn = DbBaglanti.GetConnection();

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE Hizmet SET HizmetAdi=@adi, Aciklama=@aciklama, Ucret=@ucret WHERE HizmetId=@id",
                conn);

            cmd.Parameters.AddWithValue("@adi", h.HizmetAdi);
            cmd.Parameters.AddWithValue("@aciklama", h.Aciklama);
            cmd.Parameters.AddWithValue("@ucret", h.Ucret);
            cmd.Parameters.AddWithValue("@id", h.HizmetId);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void HizmetSil(int id)
        {
            MySqlConnection conn = DbBaglanti.GetConnection();

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM Hizmet WHERE HizmetId=@id",
                conn);

            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void HizmetEkle(Hizmet h)
        {

            MySqlConnection conn = DbBaglanti.GetConnection();

            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO Hizmet (HizmetAdi, Aciklama, Ucret) VALUES (@adi, @aciklama, @ucret)",
                conn);

            cmd.Parameters.AddWithValue("@adi", h.HizmetAdi);
            cmd.Parameters.AddWithValue("@aciklama", h.Aciklama);
            cmd.Parameters.AddWithValue("@ucret", h.Ucret);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }   
}

