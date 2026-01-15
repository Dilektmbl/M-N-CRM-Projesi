namespace MiniCRM.UI
{
    partial class TalepYonetimForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvTalepler = new System.Windows.Forms.DataGridView();
            this.colTalepId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMusteriId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHizmetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTalepTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTalepId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.grpGeriBildirim = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPuan = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYorum = new System.Windows.Forms.TextBox();
            this.btnGeriBildirimKaydet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTalepler)).BeginInit();
            this.grpGeriBildirim.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(953, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "TALEP GÜNCELLEME ALANI ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvTalepler);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 454);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 288);
            this.panel3.TabIndex = 3;
            // 
            // dgvTalepler
            // 
            this.dgvTalepler.AllowUserToAddRows = false;
            this.dgvTalepler.AllowUserToDeleteRows = false;
            this.dgvTalepler.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvTalepler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTalepler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTalepler.BackgroundColor = System.Drawing.Color.White;
            this.dgvTalepler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTalepler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTalepler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTalepler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTalepler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTalepler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTalepId,
            this.colMusteriId,
            this.colHizmetId,
            this.colPersonelId,
            this.colDurum,
            this.colAciklama,
            this.colTalepTarihi});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTalepler.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvTalepler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTalepler.EnableHeadersVisualStyles = false;
            this.dgvTalepler.GridColor = System.Drawing.Color.LightGray;
            this.dgvTalepler.Location = new System.Drawing.Point(0, 0);
            this.dgvTalepler.MultiSelect = false;
            this.dgvTalepler.Name = "dgvTalepler";
            this.dgvTalepler.ReadOnly = true;
            this.dgvTalepler.RowHeadersVisible = false;
            this.dgvTalepler.RowHeadersWidth = 51;
            this.dgvTalepler.RowTemplate.Height = 24;
            this.dgvTalepler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTalepler.Size = new System.Drawing.Size(953, 288);
            this.dgvTalepler.TabIndex = 6;
            this.dgvTalepler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTalepler_CellContentClick);
            // 
            // colTalepId
            // 
            this.colTalepId.DataPropertyName = "TalepId";
            this.colTalepId.HeaderText = "Talep ID";
            this.colTalepId.MinimumWidth = 6;
            this.colTalepId.Name = "colTalepId";
            this.colTalepId.ReadOnly = true;
            this.colTalepId.Visible = false;
            // 
            // colMusteriId
            // 
            this.colMusteriId.DataPropertyName = "MusteriId";
            this.colMusteriId.HeaderText = "Müşteri ID";
            this.colMusteriId.MinimumWidth = 6;
            this.colMusteriId.Name = "colMusteriId";
            this.colMusteriId.ReadOnly = true;
            // 
            // colHizmetId
            // 
            this.colHizmetId.DataPropertyName = "HizmetId";
            this.colHizmetId.HeaderText = "Hizmet ID";
            this.colHizmetId.MinimumWidth = 6;
            this.colHizmetId.Name = "colHizmetId";
            this.colHizmetId.ReadOnly = true;
            // 
            // colPersonelId
            // 
            this.colPersonelId.DataPropertyName = "PersonelId";
            this.colPersonelId.HeaderText = "Personel ";
            this.colPersonelId.MinimumWidth = 6;
            this.colPersonelId.Name = "colPersonelId";
            this.colPersonelId.ReadOnly = true;
            // 
            // colDurum
            // 
            this.colDurum.DataPropertyName = "Durum";
            this.colDurum.HeaderText = "Durum";
            this.colDurum.MinimumWidth = 6;
            this.colDurum.Name = "colDurum";
            this.colDurum.ReadOnly = true;
            // 
            // colAciklama
            // 
            this.colAciklama.DataPropertyName = "Aciklama";
            this.colAciklama.HeaderText = "Açıklama";
            this.colAciklama.MinimumWidth = 6;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.ReadOnly = true;
            // 
            // colTalepTarihi
            // 
            this.colTalepTarihi.DataPropertyName = "TalepTarihi";
            this.colTalepTarihi.HeaderText = "Tarih";
            this.colTalepTarihi.MinimumWidth = 6;
            this.colTalepTarihi.Name = "colTalepTarihi";
            this.colTalepTarihi.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Talep ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Durum :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Personel :";
            // 
            // txtTalepId
            // 
            this.txtTalepId.Location = new System.Drawing.Point(189, 30);
            this.txtTalepId.Multiline = true;
            this.txtTalepId.Name = "txtTalepId";
            this.txtTalepId.ReadOnly = true;
            this.txtTalepId.Size = new System.Drawing.Size(200, 28);
            this.txtTalepId.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Açıklama :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(189, 187);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 28);
            this.txtAciklama.TabIndex = 21;
            // 
            // cmbDurum
            // 
            this.cmbDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(189, 77);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(200, 30);
            this.cmbDurum.TabIndex = 22;
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(189, 135);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(200, 30);
            this.cmbPersonel.TabIndex = 23;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(275, 329);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(185, 33);
            this.btnSil.TabIndex = 24;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.btnYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(31, 329);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(185, 33);
            this.btnYenile.TabIndex = 25;
            this.btnYenile.Text = "YENİLE";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click_1);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(174, 265);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(185, 48);
            this.btnGuncelle.TabIndex = 26;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // grpGeriBildirim
            // 
            this.grpGeriBildirim.Controls.Add(this.btnGeriBildirimKaydet);
            this.grpGeriBildirim.Controls.Add(this.txtYorum);
            this.grpGeriBildirim.Controls.Add(this.label7);
            this.grpGeriBildirim.Controls.Add(this.cmbPuan);
            this.grpGeriBildirim.Controls.Add(this.label6);
            this.grpGeriBildirim.Enabled = false;
            this.grpGeriBildirim.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpGeriBildirim.Location = new System.Drawing.Point(624, 6);
            this.grpGeriBildirim.Name = "grpGeriBildirim";
            this.grpGeriBildirim.Size = new System.Drawing.Size(326, 388);
            this.grpGeriBildirim.TabIndex = 27;
            this.grpGeriBildirim.TabStop = false;
            this.grpGeriBildirim.Text = "MÜŞTERİ MEMNUNİYETİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = " Puan (1-5) :";
            // 
            // cmbPuan
            // 
            this.cmbPuan.BackColor = System.Drawing.SystemColors.Control;
            this.cmbPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPuan.FormattingEnabled = true;
            this.cmbPuan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbPuan.Location = new System.Drawing.Point(6, 75);
            this.cmbPuan.Name = "cmbPuan";
            this.cmbPuan.Size = new System.Drawing.Size(200, 30);
            this.cmbPuan.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grpGeriBildirim);
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Controls.Add(this.btnYenile);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.cmbPersonel);
            this.panel2.Controls.Add(this.cmbDurum);
            this.panel2.Controls.Add(this.txtAciklama);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTalepId);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 394);
            this.panel2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Yorum :";
            // 
            // txtYorum
            // 
            this.txtYorum.BackColor = System.Drawing.SystemColors.Control;
            this.txtYorum.Location = new System.Drawing.Point(10, 172);
            this.txtYorum.Multiline = true;
            this.txtYorum.Name = "txtYorum";
            this.txtYorum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtYorum.Size = new System.Drawing.Size(193, 74);
            this.txtYorum.TabIndex = 25;
            // 
            // btnGeriBildirimKaydet
            // 
            this.btnGeriBildirimKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.btnGeriBildirimKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeriBildirimKaydet.FlatAppearance.BorderSize = 0;
            this.btnGeriBildirimKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriBildirimKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriBildirimKaydet.ForeColor = System.Drawing.Color.White;
            this.btnGeriBildirimKaydet.Location = new System.Drawing.Point(56, 293);
            this.btnGeriBildirimKaydet.Name = "btnGeriBildirimKaydet";
            this.btnGeriBildirimKaydet.Size = new System.Drawing.Size(185, 33);
            this.btnGeriBildirimKaydet.TabIndex = 26;
            this.btnGeriBildirimKaydet.Text = "MEMNUNİYETİ KAYDET";
            this.btnGeriBildirimKaydet.UseVisualStyleBackColor = false;
            this.btnGeriBildirimKaydet.Click += new System.EventHandler(this.btnGeriBildirimKaydet_Click);
            // 
            // TalepYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 742);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TalepYonetimForm";
            this.Text = "TalepYonetimForm";
            this.Load += new System.EventHandler(this.TalepYonetimForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTalepler)).EndInit();
            this.grpGeriBildirim.ResumeLayout(false);
            this.grpGeriBildirim.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvTalepler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTalepId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMusteriId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHizmetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTalepTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTalepId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox grpGeriBildirim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGeriBildirimKaydet;
        private System.Windows.Forms.TextBox txtYorum;
    }
}