using DAO;
using MiniCRM.DAO;
using MiniCRM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCRM.Service
{

    public class MusteriService
    {
        public static List<Musteri> MusteriListele()
        {
            return MusteriDao.MusteriListele();
        }
    }
}
