using MiniCRM.DAO;
using MiniCRM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MiniCRM.Service
{
    public class HizmetService
    {
        public static List<Hizmet> HizmetListele()
        {
            return HizmetDao.HizmetListele();
        }

    }
}
