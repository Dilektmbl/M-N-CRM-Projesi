using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MiniCRM.DAO;
using MiniCRM.Domain;
using MySql.Data.MySqlClient;


namespace MiniCRM.Service
{
    public class PersonelService
    {
        public static List<Personel> PersonelListele()
        {
            return PersonelDao.PersonelListele();
        }

        public static void PersonelEkle(Personel p)
        {
            PersonelDao.PersonelEkle(p);
        }

        public static void PersonelGuncelle(Personel p)
        {
            PersonelDao.PersonelGuncelle(p);
        }

        public static void PersonelSil(int id)
        {
            PersonelDao.PersonelSil(id);
        }

    }
}

