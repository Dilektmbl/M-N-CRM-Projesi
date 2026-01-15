using MiniCRM.DAO;
using MiniCRM.Domain;
using MiniCRM.Service;
using MySql.Data.MySqlClient;
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
    public partial class PersonelYonetimForm : Form
    {
        public PersonelYonetimForm()
        {
            InitializeComponent();
        }

        private void PersonelYonetimForm_Load(object sender, EventArgs e)
        {
            dgvPersoneller.DataSource = PersonelService.PersonelListele();
        }
        int seciliPersonelId = 0;
   
        private void dgvPersoneller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvPersoneller.CurrentRow == null) return;

            seciliPersonelId = Convert.ToInt32(
                dgvPersoneller.CurrentRow.Cells["colPersonelId"].Value
            );

            txtAdSoyad.Text = dgvPersoneller.CurrentRow.Cells["colAdSoyad"].Value?.ToString();
            txtEmail.Text = dgvPersoneller.CurrentRow.Cells["colEmail"].Value?.ToString();
            txtUzmanlik.Text = dgvPersoneller.CurrentRow.Cells["colUzmanlik"].Value?.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Basit zorunlu alan kontrolü
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtUzmanlik.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
                return;
            }

            Personel p = new Personel
            {
                AdSoyad = txtAdSoyad.Text,
                Uzmanlik = txtUzmanlik.Text,
                Email = txtEmail.Text
            };

            PersonelService.PersonelEkle(p);

            MessageBox.Show("Personel başarıyla eklendi");

            // tabloyu yenile
            dgvPersoneller.DataSource = PersonelService.PersonelListele();

            // alanları temizle
            seciliPersonelId = 0;
            txtAdSoyad.Clear();
            txtUzmanlik.Clear();
            txtEmail.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (seciliPersonelId == 0)
            {
                MessageBox.Show("Lütfen bir personel seçin.");
                return;
            }

            Personel p = new Personel
            {
                PersonelId = seciliPersonelId,
                AdSoyad = txtAdSoyad.Text,
                Email = txtEmail.Text,
                Uzmanlik = txtUzmanlik.Text
            };

            PersonelDao.PersonelGuncelle(p);
            dgvPersoneller.DataSource = PersonelDao.PersonelListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (seciliPersonelId == 0)
            {
                MessageBox.Show("Lütfen bir personel seçin.");
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Seçili personeli silmek istiyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr == DialogResult.Yes)
            {
                PersonelDao.PersonelSil(seciliPersonelId);
                dgvPersoneller.DataSource = PersonelDao.PersonelListele();

                seciliPersonelId = 0;
                txtAdSoyad.Clear();
                txtEmail.Clear();
                txtUzmanlik.Clear();
            }
        }
        
    }
}
