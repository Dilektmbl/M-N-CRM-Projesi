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
    public partial class CagriMerkeziForm : Form
    {
        TalepService talepService = new TalepService();
        public CagriMerkeziForm()
        {
            InitializeComponent();
        }

        private void CagriMerkeziForm_Load(object sender, EventArgs e)
        {

          
            List<Musteri> musteriler = MusteriService.MusteriListele();

            cmbMusteri.DataSource = musteriler;
            cmbMusteri.DisplayMember = "AdSoyad";
            cmbMusteri.ValueMember = "MusteriId";

            // 🔹 Hizmet
            cmbHizmet.DataSource = HizmetService.HizmetListele();
            cmbHizmet.DisplayMember = "HizmetAdi";
            cmbHizmet.ValueMember = "HizmetId";

            // Personel
            cmbPersonel.DataSource = PersonelService.PersonelListele();
            cmbPersonel.DisplayMember = "AdSoyad";
            cmbPersonel.ValueMember = "PersonelId";

            // Durum
            cmbDurum.Items.Add("Yeni");
            cmbDurum.Items.Add("İşlemde");
            cmbDurum.Items.Add("Tamamlandı");
            cmbDurum.SelectedIndex = 0;
        }

        private void btnTalepOlustur_Click(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedValue == null || cmbHizmet.SelectedValue == null)
            {
                MessageBox.Show("Müşteri ve Hizmet seçilmelidir");
                return;
            }

            Talep yeniTalep = new Talep
            {
                MusteriId = (int)cmbMusteri.SelectedValue,
                HizmetId = (int)cmbHizmet.SelectedValue,
                PersonelId = cmbPersonel.SelectedValue != null
                                ? (int?)cmbPersonel.SelectedValue
                                : null,
                Durum = cmbDurum.SelectedItem.ToString(),
                Aciklama = txtAciklama.Text,
                TalepTarihi = DateTime.Now
            };

            TalepService.TalepEkle(yeniTalep);



            MessageBox.Show("Talep başarıyla kaydedildi");

            this.Close();
        }
    }
}
