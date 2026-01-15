using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MiniCRM.Domain;

namespace MiniCRM.DAO
{
    public class PersonelDao
    {
        public static List<Personel> PersonelListele()
        {
            List<Personel> liste = new List<Personel>();
            MySqlConnection conn = DbBaglanti.GetConnection();

            MySqlCommand cmd = new MySqlCommand(
                "SELECT PersonelId, AdSoyad, Uzmanlik, Email FROM Personel",
                conn
            );

            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                liste.Add(new Personel
                {
                    PersonelId = Convert.ToInt32(dr["PersonelId"]),
                    AdSoyad = dr["AdSoyad"].ToString(),
                    Uzmanlik = dr["Uzmanlik"].ToString(),
                    Email = dr["Email"].ToString()
                });
            }

            conn.Close();
            return liste;
        }

        public static void PersonelEkle(Personel p)
        {
            MySqlConnection conn = DbBaglanti.GetConnection();

            MySqlCommand cmd = new MySqlCommand(@"
                INSERT INTO Personel (AdSoyad, Uzmanlik, Email)
                VALUES (@ad, @uz, @mail)", conn);

            cmd.Parameters.AddWithValue("@ad", p.AdSoyad);
            cmd.Parameters.AddWithValue("@uz", p.Uzmanlik);
            cmd.Parameters.AddWithValue("@mail", p.Email);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void PersonelGuncelle(Personel p)
        {
            MySqlConnection conn = DbBaglanti.GetConnection();
            MySqlCommand cmd = new MySqlCommand(@"
        UPDATE Personel 
        SET AdSoyad=@ad, Uzmanlik=@uz, Email=@mail
        WHERE PersonelId=@id
    ", conn);

            cmd.Parameters.AddWithValue("@ad", p.AdSoyad);
            cmd.Parameters.AddWithValue("@uz", p.Uzmanlik);
            cmd.Parameters.AddWithValue("@mail", p.Email);
            cmd.Parameters.AddWithValue("@id", p.PersonelId);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void PersonelSil(int id)
        {
            MySqlConnection conn = DbBaglanti.GetConnection();
            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM Personel WHERE PersonelId=@id", conn);

            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
