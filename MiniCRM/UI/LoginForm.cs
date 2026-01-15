using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniCRM.Service;
using MiniCRM.Domain;

namespace MiniCRM.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void girişBtn_Click(object sender, EventArgs e)
        {
            AuthService authService = new AuthService();

            Kullanici kullanici = authService.Login(
                txtKullaniciAdi.Text.Trim(),
               sifreTxt.Text.Trim()
            );

            if (kullanici == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı",
                                "Giriş Hatası",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Giriş başarılı
            AdminForm adminForm = new AdminForm(kullanici);
            adminForm.Show();
            this.Hide();
        }

        private void yeniKayıtBtn_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.Show();
            this.Hide();
        }
    }
}
