using MiniCRM.DAO;
using MiniCRM.Domain;
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
using System.Globalization;

namespace MiniCRM.UI
{
    public partial class ServiceForm : Form
    {
        int seciliHizmetId = 0;
        public ServiceForm()
        {
            InitializeComponent();
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            dgvHizmetler.DataSource = HizmetDao.HizmetListele();
        }

        private void btnHizmetEkle_Click(object sender, EventArgs e)
        {
            decimal ucret;

            if (!decimal.TryParse(txtUcret.Text,
                NumberStyles.Any,
                CultureInfo.CurrentCulture,
                out ucret))
            {
                MessageBox.Show("Ücret geçerli bir sayı değil. Örnek: 7000,00");
                return;
            }

            Hizmet h = new Hizmet
            {
                HizmetAdi = txtHizmetAdi.Text,
                Aciklama = txtAciklama.Text,
                Ucret = ucret
            };

            HizmetDao.HizmetEkle(h);

            dgvHizmetler.DataSource = HizmetDao.HizmetListele();

            txtHizmetAdi.Clear();
            txtAciklama.Clear();
            txtUcret.Clear();

        }

        private void dgvHizmetler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvHizmetler.CurrentRow == null) return;

            seciliHizmetId = Convert.ToInt32(
                dgvHizmetler.CurrentRow.Cells["colHizmetId"].Value
            );

            txtHizmetAdi.Text =
                dgvHizmetler.CurrentRow.Cells["colHizmetAdi"].Value?.ToString();

            txtAciklama.Text =
                dgvHizmetler.CurrentRow.Cells["colAciklama"].Value?.ToString();

            txtUcret.Text = dgvHizmetler.CurrentRow.Cells["colUcret"].Value?.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliHizmetId == 0)
            {
                MessageBox.Show("Lütfen bir hizmet seçin.");
                return;
            }

            decimal ucret;
            if (!decimal.TryParse(txtUcret.Text,
                NumberStyles.Any,
                CultureInfo.CurrentCulture,
                out ucret))
            {
                MessageBox.Show("Ücret geçerli bir sayı değil. Örnek: 7000,00");
                return;
            }

            Hizmet h = new Hizmet
            {
                HizmetId = seciliHizmetId,
                HizmetAdi = txtHizmetAdi.Text,
                Aciklama = txtAciklama.Text,
                Ucret = ucret
            };

            HizmetDao.HizmetGuncelle(h);
            dgvHizmetler.DataSource = HizmetDao.HizmetListele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (seciliHizmetId == 0)
            {
                MessageBox.Show("Lütfen bir hizmet seçin.");
                return;
            }

            if (MessageBox.Show(
                "Seçili hizmet silinsin mi?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                HizmetDao.HizmetSil(seciliHizmetId);
                dgvHizmetler.DataSource = HizmetDao.HizmetListele();

                seciliHizmetId = 0;
                txtHizmetAdi.Clear();
                txtAciklama.Clear();
                txtUcret.Clear();
            }
        }
    }
}
