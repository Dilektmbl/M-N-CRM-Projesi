using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniCRM.Domain;

namespace MiniCRM.UI
{
    using Domain;

    public partial class AdminForm : Form
    {
        private Kullanici _aktifKullanici;

        public AdminForm(Kullanici kullanici)
        {
            InitializeComponent();
            _aktifKullanici = kullanici;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            YetkilendirmeUygula();
            MenuClickleriBagla();
        }

          private bool YetkiVarMi(string ekranKodu)
          {  
            string rol = _aktifKullanici.Rol;

            if (rol == "Admin")
                return true;

            if (rol == "Destek")
                return ekranKodu == "TALEP";

            if (rol == "CagriMerkezi")
                return ekranKodu == "CAGRI";

            return false;
          }

      
        private void YetkilendirmeUygula()
        {

            btnMusteri.Enabled = YetkiVarMi("MUSTERI");
            btnPersonel.Enabled = YetkiVarMi("PERSONEL");
            btnHizmet.Enabled = YetkiVarMi("HIZMET");
            btnTalep.Enabled = YetkiVarMi("TALEP");
            btnCagrı.Enabled = YetkiVarMi("CAGRI");
            btnRapor.Enabled = YetkiVarMi("RAPOR");
        }

        
        private void MenuClickleriBagla()
        {
            
            btnMusteri.Tag = "MUSTERI";
            btnPersonel.Tag = "PERSONEL";
            btnHizmet.Tag = "HIZMET";
            btnTalep.Tag = "TALEP";
            btnCagrı.Tag = "CAGRI";
            btnRapor.Tag = "RAPOR";

           
            btnMusteri.Click += MenuItem_Click;
            btnPersonel.Click += MenuItem_Click;
            btnHizmet.Click += MenuItem_Click;
            btnTalep.Click += MenuItem_Click;
            btnCagrı.Click += MenuItem_Click;
            btnRapor.Click += MenuItem_Click;
        }
            private void MenuItem_Click(object sender, EventArgs e)
        {
            Control item = sender as Control;
            if (item == null) return;

            string ekranKodu = item.Tag?.ToString() ?? "";

            if (!YetkiVarMi(ekranKodu))
            {
                MessageBox.Show("Bu alana yetkiniz yok");
                return;
            }

            switch (ekranKodu)
            {
                case "MUSTERI":
                    FormAc(new CustomerForm());
                    break;

                case "PERSONEL":
                    FormAc(new PersonelYonetimForm());
                    break;

                case "HIZMET":
                    FormAc(new ServiceForm());
                    break;

                case "TALEP":
                    FormAc(new TalepYonetimForm());
                    break;

                case "CAGRI":
                    if (_aktifKullanici.Rol == "CagriMerkezi")
                    {
                        FormAc(new CagriMerkeziForm());
                    }
                    break;

                case "RAPOR":
                    FormAc(new ReportForm());
                    break;
            }
        }

        private void FormAc(Form frm)
        {
            panelIcerik.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelIcerik.Controls.Add(frm);
            frm.Show();
        }


        private void btnMusteri_Click(object sender, EventArgs e)
        {
            if (!YetkiVarMi("MUSTERI"))
            {
                MessageBox.Show("Bu alana yetkiniz yok");
                return;
            }

            FormAc(new CustomerForm());
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            if (!YetkiVarMi("PERSONEL"))
            {
                MessageBox.Show("Bu alana yetkiniz yok");
                return;
            }

            FormAc(new PersonelYonetimForm());
        }

        private void btnHizmet_Click(object sender, EventArgs e)
        {
            if (!YetkiVarMi("HIZMET"))
            {
                MessageBox.Show("Bu alana yetkiniz yok");
                return;
            }

            FormAc(new ServiceForm());
        }

        private void btnTalep_Click(object sender, EventArgs e)
        {
            if (!YetkiVarMi("TALEP"))
            {
                MessageBox.Show("Bu alana yetkiniz yok");
                return;
            }

            FormAc(new TalepYonetimForm());
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            FormAc(new ReportForm());
        }

        private void btnCagrı_Click(object sender, EventArgs e)
        {


            if (_aktifKullanici.Rol != "CagriMerkezi")
            {
                MessageBox.Show("Bu alana sadece çağrı merkezi erişebilir");
                return;
            }

            FormAc(new CagriMerkeziForm());
        }

        private void btnMusteri_Click_1(object sender, EventArgs e)
        {
            CustomerForm frm = new CustomerForm();
            frm.TopLevel = false;

            panelIcerik.Controls.Clear();
            panelIcerik.Controls.Add(frm);

            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnPersonel_Click_1(object sender, EventArgs e)
        {
            PersonelYonetimForm frm = new PersonelYonetimForm();
            frm.TopLevel = false;

            panelIcerik.Controls.Clear();
            panelIcerik.Controls.Add(frm);

            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(
          "Çıkış yapmak istiyor musunuz?",
          "Çıkış",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }

        private void btnRapor_Click_1(object sender, EventArgs e)
        {
            if (_aktifKullanici.Rol != "Admin")
            {
                MessageBox.Show("Bu alana yetkiniz yok");
                return;
            }
            ReportForm frm = new ReportForm();
            frm.TopLevel = false;

            panelIcerik.Controls.Clear();
            panelIcerik.Controls.Add(frm);

            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnHizmet_Click_1(object sender, EventArgs e)
        {
            ServiceForm frm = new ServiceForm();
            frm.TopLevel = false;

            panelIcerik.Controls.Clear();
            panelIcerik.Controls.Add(frm);

            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnTalep_Click_1(object sender, EventArgs e)
        {
            TalepYonetimForm frm = new TalepYonetimForm();
            frm.TopLevel = false;

            panelIcerik.Controls.Clear();
            panelIcerik.Controls.Add(frm);

            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
