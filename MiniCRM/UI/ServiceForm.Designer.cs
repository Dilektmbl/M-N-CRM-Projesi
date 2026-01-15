namespace MiniCRM.UI
{
    partial class ServiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnHizmetEkle = new System.Windows.Forms.Button();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtHizmetAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvHizmetler = new System.Windows.Forms.DataGridView();
            this.colHizmetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHizmetAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUcret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHizmetler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
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
            this.label1.Size = new System.Drawing.Size(800, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "HİZMET TANIMLARI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnsil);
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Controls.Add(this.btnHizmetEkle);
            this.panel2.Controls.Add(this.txtUcret);
            this.panel2.Controls.Add(this.txtAciklama);
            this.panel2.Controls.Add(this.txtHizmetAdi);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 319);
            this.panel2.TabIndex = 1;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.FlatAppearance.BorderSize = 0;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(323, 269);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(173, 33);
            this.btnsil.TabIndex = 17;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(80, 269);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(173, 33);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnHizmetEkle
            // 
            this.btnHizmetEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.btnHizmetEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHizmetEkle.FlatAppearance.BorderSize = 0;
            this.btnHizmetEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHizmetEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHizmetEkle.ForeColor = System.Drawing.Color.White;
            this.btnHizmetEkle.Location = new System.Drawing.Point(201, 201);
            this.btnHizmetEkle.Name = "btnHizmetEkle";
            this.btnHizmetEkle.Size = new System.Drawing.Size(200, 39);
            this.btnHizmetEkle.TabIndex = 15;
            this.btnHizmetEkle.Text = "HİZMET EKLE";
            this.btnHizmetEkle.UseVisualStyleBackColor = false;
            this.btnHizmetEkle.Click += new System.EventHandler(this.btnHizmetEkle_Click);
            // 
            // txtUcret
            // 
            this.txtUcret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUcret.Location = new System.Drawing.Point(201, 139);
            this.txtUcret.Multiline = true;
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(200, 30);
            this.txtUcret.TabIndex = 14;
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(201, 86);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 30);
            this.txtAciklama.TabIndex = 13;
            // 
            // txtHizmetAdi
            // 
            this.txtHizmetAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtHizmetAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHizmetAdi.Location = new System.Drawing.Point(201, 36);
            this.txtHizmetAdi.Multiline = true;
            this.txtHizmetAdi.Name = "txtHizmetAdi";
            this.txtHizmetAdi.Size = new System.Drawing.Size(200, 30);
            this.txtHizmetAdi.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ücret :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Açıklama :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hizmet Adı :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvHizmetler);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 373);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 250);
            this.panel3.TabIndex = 2;
            // 
            // dgvHizmetler
            // 
            this.dgvHizmetler.AllowUserToAddRows = false;
            this.dgvHizmetler.AllowUserToDeleteRows = false;
            this.dgvHizmetler.AllowUserToResizeRows = false;
            this.dgvHizmetler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHizmetler.BackgroundColor = System.Drawing.Color.White;
            this.dgvHizmetler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHizmetler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHizmetler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHizmetler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHizmetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHizmetler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHizmetId,
            this.colHizmetAdi,
            this.colAciklama,
            this.colUcret});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHizmetler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHizmetler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHizmetler.EnableHeadersVisualStyles = false;
            this.dgvHizmetler.GridColor = System.Drawing.Color.LightGray;
            this.dgvHizmetler.Location = new System.Drawing.Point(0, 0);
            this.dgvHizmetler.MultiSelect = false;
            this.dgvHizmetler.Name = "dgvHizmetler";
            this.dgvHizmetler.ReadOnly = true;
            this.dgvHizmetler.RowHeadersVisible = false;
            this.dgvHizmetler.RowHeadersWidth = 51;
            this.dgvHizmetler.RowTemplate.Height = 24;
            this.dgvHizmetler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHizmetler.Size = new System.Drawing.Size(800, 250);
            this.dgvHizmetler.TabIndex = 6;
            this.dgvHizmetler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHizmetler_CellContentClick);
            // 
            // colHizmetId
            // 
            this.colHizmetId.DataPropertyName = "HizmetId";
            this.colHizmetId.HeaderText = "ID";
            this.colHizmetId.MinimumWidth = 6;
            this.colHizmetId.Name = "colHizmetId";
            this.colHizmetId.ReadOnly = true;
            this.colHizmetId.Visible = false;
            // 
            // colHizmetAdi
            // 
            this.colHizmetAdi.DataPropertyName = "HizmetAdi";
            this.colHizmetAdi.HeaderText = "Hizmet Adı";
            this.colHizmetAdi.MinimumWidth = 6;
            this.colHizmetAdi.Name = "colHizmetAdi";
            this.colHizmetAdi.ReadOnly = true;
            // 
            // colAciklama
            // 
            this.colAciklama.DataPropertyName = "Aciklama";
            this.colAciklama.HeaderText = "Açıklama";
            this.colAciklama.MinimumWidth = 6;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.ReadOnly = true;
            // 
            // colUcret
            // 
            this.colUcret.DataPropertyName = " Ucret";
            this.colUcret.HeaderText = "Ücret (₺)";
            this.colUcret.MinimumWidth = 6;
            this.colUcret.Name = "colUcret";
            this.colUcret.ReadOnly = true;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ServiceForm";
            this.Text = "ServiceForm";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHizmetler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnHizmetEkle;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtHizmetAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvHizmetler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHizmetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHizmetAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUcret;
    }
}