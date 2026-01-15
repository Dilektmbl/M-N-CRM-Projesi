using MiniCRM.Domain;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using MiniCRM.DAO;

namespace DAO
{
    public class MusteriDao
    {
        public static List<Musteri> MusteriListele()
        {
            List<Musteri> liste = new List<Musteri>();
            MySqlConnection conn = DbBaglanti.GetConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Musteri", conn);

            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                liste.Add(new Musteri
                {
                    MusteriId = dr.GetInt32("MusteriId"),
                    AdSoyad = dr["AdSoyad"].ToString(),
                    Email = dr["Email"].ToString(),
                    Telefon = dr["Telefon"].ToString()
                });
            }

            conn.Close();
            return liste;
        }
        public static void MusteriEkle(Musteri m)
        {
            MySqlConnection conn = DbBaglanti.GetConnection();

            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO Musteri (AdSoyad, Email, Telefon) VALUES (@ad, @mail, @tel)", conn);

            cmd.Parameters.AddWithValue("@ad", m.AdSoyad);
            cmd.Parameters.AddWithValue("@mail", m.Email);
            cmd.Parameters.AddWithValue("@tel", m.Telefon);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void MusteriGuncelle(Musteri m)
        {
            MySqlConnection conn = DbBaglanti.GetConnection();
            MySqlCommand cmd = new MySqlCommand(
                "UPDATE Musteri SET AdSoyad=@ad, Email=@mail, Telefon=@tel WHERE MusteriId=@id", conn);

            cmd.Parameters.AddWithValue("@ad", m.AdSoyad);
            cmd.Parameters.AddWithValue("@mail", m.Email);
            cmd.Parameters.AddWithValue("@tel", m.Telefon);
            cmd.Parameters.AddWithValue("@id", m.MusteriId);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void MusteriSil(int musteriId)
        {
            MySqlConnection conn = DbBaglanti.GetConnection();
            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM Musteri WHERE MusteriId=@id", conn);

            cmd.Parameters.AddWithValue("@id", musteriId);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
