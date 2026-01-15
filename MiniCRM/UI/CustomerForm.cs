using DAO;
using MiniCRM.Domain;
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
    public partial class CustomerForm : Form
    {
        int seciliMusteriId = 0;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = MusteriDao.MusteriListele();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri
            {
                AdSoyad = txtAdSoyad.Text,
                Email = txtEmail.Text,
                Telefon = txtTelefon.Text
            };

            MusteriDao.MusteriEkle(m);

            // Grid yenilensin
            dgvMusteriler.DataSource = MusteriDao.MusteriListele();

            // TextBox'ları temizle
            txtAdSoyad.Clear();
            txtEmail.Clear();
            txtTelefon.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliMusteriId == 0)
            {
                MessageBox.Show("Lütfen bir müşteri seçin.");
                return;
            }

            Musteri m = new Musteri
            {
                MusteriId = seciliMusteriId,
                AdSoyad = txtAdSoyad.Text,
                Email = txtEmail.Text,
                Telefon = txtTelefon.Text
            };

            MusteriDao.MusteriGuncelle(m);
            dgvMusteriler.DataSource = MusteriDao.MusteriListele();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (seciliMusteriId == 0)
            {
                MessageBox.Show("Lütfen bir müşteri seçin.");
                return;
            }

            if (MessageBox.Show(
                "Seçili müşteriyi silmek istiyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MusteriDao.MusteriSil(seciliMusteriId);
                dgvMusteriler.DataSource = MusteriDao.MusteriListele();

                seciliMusteriId = 0;
                txtAdSoyad.Clear();
                txtEmail.Clear();
                txtTelefon.Clear();
            }
        }

        private void dgvMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvMusteriler.Rows[e.RowIndex];

            seciliMusteriId = Convert.ToInt32(row.Cells[0].Value);
            txtAdSoyad.Text = row.Cells[1].Value.ToString();
            txtEmail.Text = row.Cells[2].Value.ToString();
            txtTelefon.Text = row.Cells[3].Value.ToString();
        }
       
    }
}
