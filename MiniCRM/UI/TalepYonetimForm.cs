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
using MiniCRM.DAO;


namespace MiniCRM.UI
{
    public partial class TalepYonetimForm : Form
    {
        int seciliTalepId = 0;  
        public TalepYonetimForm()
        {
            InitializeComponent();
        }
        TalepDao talepDao = new TalepDao();
        private void TalepYonetimForm_Load(object sender, EventArgs e)
        {
            dgvTalepler.DataSource = TalepService.TalepListeleDT();

            // DURUM COMBOBOX
            cmbDurum.Items.Clear();
            cmbDurum.Items.Add("Yeni");
            cmbDurum.Items.Add("İşlemde");
            cmbDurum.Items.Add("Tamamlandı");
            cmbDurum.SelectedIndex = 0;

            // PERSONEL COMBOBOX
            cmbPersonel.DataSource = PersonelService.PersonelListele();
            cmbPersonel.DisplayMember = "AdSoyad";
            cmbPersonel.ValueMember = "PersonelId";
            cmbPersonel.SelectedIndex = -1;
            //
            cmbPuan.Items.Clear();
            cmbPuan.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
            cmbPuan.SelectedIndex = 4;

            grpGeriBildirim.Enabled = false;
        }

        private void dgvTalepler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvTalepler.Rows[e.RowIndex];

            seciliTalepId = Convert.ToInt32(row.Cells["colTalepId"].Value);

            txtTalepId.Text = seciliTalepId.ToString();
            cmbDurum.Text = row.Cells["colDurum"].Value.ToString();
            cmbPersonel.SelectedValue = row.Cells["colPersonelId"].Value;
            txtAciklama.Text = row.Cells["colAciklama"].Value.ToString();
            //
            //
            //
            string durum = row.Cells["colDurum"].Value?.ToString();
            grpGeriBildirim.Enabled = (durum == "Tamamlandı");

            if (!grpGeriBildirim.Enabled)
            {
                cmbPuan.SelectedIndex = 4;  
                txtYorum.Clear();
            }

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliTalepId == 0)
            {
                MessageBox.Show("Lütfen bir talep seçin.");
                return;
            }

            if (MessageBox.Show("Talep silinsin mi?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                TalepService.TalepSil(seciliTalepId);
                dgvTalepler.DataSource = TalepService.TalepListeleDT();
                seciliTalepId = 0;
                txtTalepId.Clear();
                txtAciklama.Clear();
            }
        }

        private void btnYenile_Click_1(object sender, EventArgs e)
        {
            dgvTalepler.DataSource = TalepService.TalepListeleDT();

            txtTalepId.Clear();
            txtAciklama.Clear();
            cmbDurum.SelectedIndex = 0;
            cmbPersonel.SelectedIndex = -1;
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (seciliTalepId == 0)
            {
                MessageBox.Show("Lütfen bir talep seçin.");
                return;
            }

            int? personelId = cmbPersonel.SelectedValue == null
                ? (int?)null
                : Convert.ToInt32(cmbPersonel.SelectedValue);

            TalepService.TalepGuncelle(
                seciliTalepId,
                cmbDurum.Text,
                personelId,
                txtAciklama.Text
            );

            dgvTalepler.DataSource = TalepService.TalepListeleDT();
        }

        private void btnGeriBildirimKaydet_Click(object sender, EventArgs e)
        {

            if (seciliTalepId == 0)
            {
                MessageBox.Show("Önce bir talep seçiniz.");
                return;
            }

            if (!grpGeriBildirim.Enabled)
            {
                MessageBox.Show("Sadece 'Tamamlandı' taleplere memnuniyet girilebilir.");
                return;
            }

            int puan = Convert.ToInt32(cmbPuan.SelectedItem);
            string yorum = txtYorum.Text.Trim();

            try
            {
                GeriBildirimService.MemnuniyetKaydet(seciliTalepId, puan, yorum);
                MessageBox.Show("Memnuniyet kaydedildi.");
                grpGeriBildirim.Enabled = false; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
