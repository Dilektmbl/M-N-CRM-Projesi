namespace MiniCRM.UI
{
    partial class CagriMerkeziForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.btnTalepOlustur = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHizmet = new System.Windows.Forms.ComboBox();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(928, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "📞 ÇAĞRI MERKEZİ – TALEP OLUŞTURMA ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.label5);
            this.PanelTop.Controls.Add(this.label6);
            this.PanelTop.Controls.Add(this.cmbDurum);
            this.PanelTop.Controls.Add(this.cmbPersonel);
            this.PanelTop.Controls.Add(this.btnTalepOlustur);
            this.PanelTop.Controls.Add(this.txtAciklama);
            this.PanelTop.Controls.Add(this.label4);
            this.PanelTop.Controls.Add(this.label3);
            this.PanelTop.Controls.Add(this.label2);
            this.PanelTop.Controls.Add(this.cmbHizmet);
            this.PanelTop.Controls.Add(this.cmbMusteri);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTop.Location = new System.Drawing.Point(0, 61);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(928, 583);
            this.PanelTop.TabIndex = 1;
            // 
            // btnTalepOlustur
            // 
            this.btnTalepOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.btnTalepOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTalepOlustur.FlatAppearance.BorderSize = 0;
            this.btnTalepOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTalepOlustur.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTalepOlustur.ForeColor = System.Drawing.Color.White;
            this.btnTalepOlustur.Location = new System.Drawing.Point(365, 378);
            this.btnTalepOlustur.Name = "btnTalepOlustur";
            this.btnTalepOlustur.Size = new System.Drawing.Size(223, 42);
            this.btnTalepOlustur.TabIndex = 11;
            this.btnTalepOlustur.Text = "   [ 🟦 TALEP OLUŞTUR ] ";
            this.btnTalepOlustur.UseVisualStyleBackColor = false;
            this.btnTalepOlustur.Click += new System.EventHandler(this.btnTalepOlustur_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.SystemColors.Control;
            this.txtAciklama.Location = new System.Drawing.Point(43, 378);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Size = new System.Drawing.Size(193, 74);
            this.txtAciklama.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "  📝 Açıklama: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "  🛠 Hizmet: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = " 👤 Müşteri:";
            // 
            // cmbHizmet
            // 
            this.cmbHizmet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbHizmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHizmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHizmet.FormattingEnabled = true;
            this.cmbHizmet.IntegralHeight = false;
            this.cmbHizmet.Location = new System.Drawing.Point(186, 100);
            this.cmbHizmet.MaxDropDownItems = 10;
            this.cmbHizmet.Name = "cmbHizmet";
            this.cmbHizmet.Size = new System.Drawing.Size(224, 30);
            this.cmbHizmet.TabIndex = 6;
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.IntegralHeight = false;
            this.cmbMusteri.Location = new System.Drawing.Point(186, 31);
            this.cmbMusteri.MaxDropDownItems = 10;
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(224, 30);
            this.cmbMusteri.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(52, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Durum :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(52, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Personel :";
            // 
            // cmbDurum
            // 
            this.cmbDurum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.IntegralHeight = false;
            this.cmbDurum.Location = new System.Drawing.Point(186, 241);
            this.cmbDurum.MaxDropDownItems = 10;
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(228, 30);
            this.cmbDurum.TabIndex = 16;
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.IntegralHeight = false;
            this.cmbPersonel.Location = new System.Drawing.Point(186, 163);
            this.cmbPersonel.MaxDropDownItems = 10;
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(226, 30);
            this.cmbPersonel.TabIndex = 15;
            // 
            // CagriMerkeziForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 644);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.panel1);
            this.Name = "CagriMerkeziForm";
            this.Text = "CagriMerkeziForm";
            this.Load += new System.EventHandler(this.CagriMerkeziForm_Load);
            this.panel1.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.ComboBox cmbHizmet;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Button btnTalepOlustur;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.ComboBox cmbPersonel;
    }
}