using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniCRM.DAO;
using MiniCRM.Domain;

namespace MiniCRM.Service
{
    public class AuthService
    {
        private readonly KullaniciDao _dao = new KullaniciDao();

        public Kullanici Login(string kullaniciAdi, string sifre)
        {
            if (string.IsNullOrWhiteSpace(kullaniciAdi)) return null;
            if (string.IsNullOrWhiteSpace(sifre)) return null;

            return _dao.GirisYap(kullaniciAdi, sifre);
        }
        public bool Register(string kullaniciAdi, string sifre, string rol)
        {
            if (string.IsNullOrWhiteSpace(kullaniciAdi)) return false;
            if (string.IsNullOrWhiteSpace(sifre)) return false;
            if (string.IsNullOrWhiteSpace(rol)) return false;

            return _dao.KayitOl(kullaniciAdi, sifre, rol);
        }

    }
}
