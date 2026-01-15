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
using System.Windows.Forms.DataVisualization.Charting;

namespace MiniCRM.UI
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnRaporGetir_Click(object sender, EventArgs e)
        {
            DateTime baslangic = dtpBaslangic.Value.Date;
            DateTime bitis = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);

            DataTable dt = null;

            switch (cmbRaporTuru.SelectedIndex)
            {
                case 0: // Tüm Talepler
                    chartRapor.Visible = false;
                    dt = TalepService.TumTalepler(baslangic, bitis);
                    dgvRapor.DataSource = dt;
                    break;

                case 1: // Personel Bazlı
                    dt = TalepService.PersonelBazliTalepSayisi(baslangic, bitis);
                    GrafikDoldur(dt, "PersonelAdi", "TalepSayisi", "Personel Bazlı Talep Sayısı");
                    break;

                case 2: // Hizmet Bazlı
                    dt = TalepService.HizmetBazliTalepSayisi(baslangic, bitis);
                    GrafikDoldur(dt, "HizmetAdi", "TalepSayisi", "Hizmet Bazlı Talep Sayısı");
                    break;

                case 3: // Müşteri Bazlı
                    dt = TalepService.MusteriBazliTalepSayisi(baslangic, bitis);
                    GrafikDoldur(dt, "MusteriAdi", "TalepSayisi", "Müşteri Bazlı Talep Sayısı");
                    break;
                case 4: //  Memnuniyet (Puan Dağılımı)
                    dt = TalepService.PuanDagilimiGetir(baslangic, bitis); // (Puan, Adet)
                    GrafikDoldur(dt, "Puan", "Adet", "Memnuniyet - Puan Dağılımı");
                    dgvRapor.DataSource = dt;
                    break;

                case 5: // Personel Bazlı Memnuniyet
                    dt = TalepService.PersonelBazliMemnuniyetGetir(baslangic, bitis); // (Personel, OrtalamaPuan, Adet)
                    GrafikDoldur(dt, "Personel", "OrtalamaPuan", "Personel Bazlı Memnuniyet (Ortalama)");
                    dgvRapor.DataSource = dt;
                    break;

            }
        }


        private void ReportForm_Load(object sender, EventArgs e)
        {

            cmbRaporTuru.Items.Clear();
            cmbRaporTuru.Items.Add("Tüm Talepler");
            cmbRaporTuru.Items.Add("Personel Bazlı");
            cmbRaporTuru.Items.Add("Hizmet Bazlı");
            cmbRaporTuru.Items.Add("Müşteri Bazlı");
            cmbRaporTuru.Items.Add("Memnuniyet (Puan Dağılımı)");
            cmbRaporTuru.Items.Add("Personel Bazlı Memnuniyet");


            cmbRaporTuru.SelectedIndex = 0;

            chartRapor.Visible = false;

            DgvStilAyarla();
        }
        private void TumTaleplerGetir(DateTime baslangic, DateTime bitis)
        {
            chartRapor.Visible = false;

            var liste = TalepService.TumTalepler(baslangic, bitis);
            dgvRapor.DataSource = liste;
        }
        private void PersonelBazliRapor(DateTime baslangic, DateTime bitis)
        {
            chartRapor.Visible = true;

            DataTable dt = TalepService.PersonelBazliTalepSayisi(baslangic, bitis);
            dgvRapor.DataSource = dt;

            ChartHazirla("Personel Bazlı Talep Sayısı");

            foreach (DataRow row in dt.Rows)
            {
                chartRapor.Series[0].Points.AddXY(
                    row["Personel"].ToString(),
                    Convert.ToInt32(row["TalepSayisi"])
                );
            }
        }

        private void HizmetBazliRapor(DateTime baslangic, DateTime bitis)
        {
            chartRapor.Visible = true;

            DataTable dt = TalepService.HizmetBazliTalepSayisi(baslangic, bitis);
            dgvRapor.DataSource = dt;

            ChartHazirla("Hizmet Bazlı Talep Sayısı");

            foreach (DataRow row in dt.Rows)
            {
                chartRapor.Series[0].Points.AddXY(
                    row["HizmetAdi"].ToString(),
                    Convert.ToInt32(row["TalepSayisi"])
                );
            }
        }
        private void MusteriBazliRapor(DateTime baslangic, DateTime bitis)
        {
            chartRapor.Visible = true;

            DataTable dt = TalepService.MusteriBazliTalepSayisi(baslangic, bitis);
            dgvRapor.DataSource = dt;

            ChartHazirla("Müşteri Bazlı Talep Sayısı");

            foreach (DataRow row in dt.Rows)
            {
                chartRapor.Series[0].Points.AddXY(
                    row["MusteriAdi"].ToString(),
                    Convert.ToInt32(row["TalepSayisi"])
                );
            }
        }
        private void ChartHazirla(string baslik)
        {
            chartRapor.Series.Clear();
            chartRapor.ChartAreas.Clear();
            chartRapor.Titles.Clear();

            ChartArea area = new ChartArea();

            area.BackColor = Color.White;

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.Gainsboro;

            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);

            area.AxisX.LabelStyle.Angle = -20;
            area.AxisX.Interval = 1;
            area.AxisY.Interval = 1;

            chartRapor.ChartAreas.Add(area);

            Series seri = new Series("Rapor")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Color = Color.FromArgb(52, 152, 219)
            };

            chartRapor.Series.Add(seri);

            chartRapor.Titles.Add(new Title
            {
                Text = baslik,
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 60, 90)
            });
        }
        private void DgvStilAyarla()
        {
            dgvRapor.EnableHeadersVisualStyles = false;

            dgvRapor.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(30, 60, 90);

            dgvRapor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRapor.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvRapor.DefaultCellStyle.Font =
                new Font("Segoe UI", 9);

            dgvRapor.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(52, 152, 219);

            dgvRapor.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvRapor.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 248, 251);

            dgvRapor.RowTemplate.Height = 32;
        }
        void GrafikDoldur(DataTable dt, string xKolon, string yKolon)
        {
            dgvRapor.DataSource = dt;
            chartRapor.Visible = true;

            chartRapor.Series.Clear();

            var s = chartRapor.Series.Add("Rapor");
            s.ChartType = SeriesChartType.Column;

            foreach (DataRow row in dt.Rows)
            {
                s.Points.AddXY(
                    row[xKolon].ToString(),
                    Convert.ToInt32(row[yKolon])
                );
            }
        }
        private void GrafikDoldur(
           DataTable dt,
            string xKolon,
            string yKolon,
            string baslik)
        {
            dgvRapor.DataSource = dt;

            chartRapor.Visible = true;
            ChartHazirla(baslik);

            foreach (DataRow row in dt.Rows)
            {
                chartRapor.Series["Rapor"]
                    .Points
                    .AddXY(
                        row[xKolon].ToString(),
                        Convert.ToInt32(row[yKolon])
                    );
            }
        }

    }
}

