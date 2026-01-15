using MiniCRM.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MiniCRM.UI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Add("Admin");
            cmbRol.Items.Add("Destek");
            cmbRol.Items.Add("CagriMerkezi");
            cmbRol.SelectedIndex = 0;
        }

        private void KayıtButton_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kullaniciTxt.Text.Trim();
            string sifre = sifreTXT.Text.Trim();
            string rol = cmbRol.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz");
                return;
            }

            AuthService authService = new AuthService();
            bool sonuc = authService.Register(kullaniciAdi, sifre, rol);

            if (sonuc)
            {
                MessageBox.Show("Kayıt başarılı");
                this.Close(); // Login ekranına döner
            }
            else
            {
                MessageBox.Show("Kayıt başarısız");
            }
        }
    }
}
