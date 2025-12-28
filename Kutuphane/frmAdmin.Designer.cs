namespace Kutuphane.UI
{
    partial class frmAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            grpRoller = new GroupBox();
            panelRolIslemleri = new Panel();
            btnRolSil = new Button();
            btnRolGuncelle = new Button();
            btnRolEkle = new Button();
            txtRolKodu = new TextBox();
            label3 = new Label();
            txtRolAdi = new TextBox();
            label2 = new Label();
            dgvRoller = new DataGridView();
            txtRolAra = new TextBox();
            label1 = new Label();
            grpMenuler = new GroupBox();
            dgvMenuler = new DataGridView();
            txtMenuAra = new TextBox();
            label4 = new Label();
            grpYetkiler = new GroupBox();
            btnYetkiKaydet = new Button();
            panelYetkiKutulari = new Panel();
            chkOdunc = new CheckBox();
            chkIade = new CheckBox();
            chkSil = new CheckBox();
            chkGuncelle = new CheckBox();
            chkEkle = new CheckBox();
            chkListele = new CheckBox();
            lblSeciliBilgi = new Label();
            grpRoller.SuspendLayout();
            panelRolIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoller).BeginInit();
            grpMenuler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenuler).BeginInit();
            grpYetkiler.SuspendLayout();
            panelYetkiKutulari.SuspendLayout();
            SuspendLayout();
            // 
            // grpRoller
            // 
            grpRoller.Controls.Add(panelRolIslemleri);
            grpRoller.Controls.Add(dgvRoller);
            grpRoller.Controls.Add(txtRolAra);
            grpRoller.Controls.Add(label1);
            grpRoller.Dock = DockStyle.Left;
            grpRoller.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpRoller.ForeColor = Color.FromArgb(64, 64, 64);
            grpRoller.Location = new Point(0, 0);
            grpRoller.Margin = new Padding(4, 3, 4, 3);
            grpRoller.Name = "grpRoller";
            grpRoller.Padding = new Padding(12);
            grpRoller.Size = new Size(429, 750);
            grpRoller.TabIndex = 1;
            grpRoller.TabStop = false;
            grpRoller.Text = "1. Rol Yönetimi";
            // 
            // panelRolIslemleri
            // 
            panelRolIslemleri.BackColor = Color.WhiteSmoke;
            panelRolIslemleri.BorderStyle = BorderStyle.FixedSingle;
            panelRolIslemleri.Controls.Add(btnRolSil);
            panelRolIslemleri.Controls.Add(btnRolGuncelle);
            panelRolIslemleri.Controls.Add(btnRolEkle);
            panelRolIslemleri.Controls.Add(txtRolKodu);
            panelRolIslemleri.Controls.Add(label3);
            panelRolIslemleri.Controls.Add(txtRolAdi);
            panelRolIslemleri.Controls.Add(label2);
            panelRolIslemleri.Dock = DockStyle.Bottom;
            panelRolIslemleri.Location = new Point(12, 526);
            panelRolIslemleri.Margin = new Padding(4, 3, 4, 3);
            panelRolIslemleri.Name = "panelRolIslemleri";
            panelRolIslemleri.Size = new Size(405, 212);
            panelRolIslemleri.TabIndex = 3;
            // 
            // btnRolSil
            // 
            btnRolSil.BackColor = Color.FromArgb(214, 48, 49);
            btnRolSil.FlatStyle = FlatStyle.Flat;
            btnRolSil.ForeColor = Color.White;
            btnRolSil.Location = new Point(260, 145);
            btnRolSil.Margin = new Padding(4, 3, 4, 3);
            btnRolSil.Name = "btnRolSil";
            btnRolSil.Size = new Size(104, 40);
            btnRolSil.TabIndex = 6;
            btnRolSil.Text = "Sil";
            btnRolSil.UseVisualStyleBackColor = false;
            // 
            // btnRolGuncelle
            // 
            btnRolGuncelle.BackColor = Color.FromArgb(9, 132, 227);
            btnRolGuncelle.FlatStyle = FlatStyle.Flat;
            btnRolGuncelle.ForeColor = Color.White;
            btnRolGuncelle.Location = new Point(140, 145);
            btnRolGuncelle.Margin = new Padding(4, 3, 4, 3);
            btnRolGuncelle.Name = "btnRolGuncelle";
            btnRolGuncelle.Size = new Size(113, 40);
            btnRolGuncelle.TabIndex = 5;
            btnRolGuncelle.Text = "Güncelle";
            btnRolGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnRolEkle
            // 
            btnRolEkle.BackColor = Color.FromArgb(0, 184, 148);
            btnRolEkle.FlatStyle = FlatStyle.Flat;
            btnRolEkle.ForeColor = Color.White;
            btnRolEkle.Location = new Point(19, 145);
            btnRolEkle.Margin = new Padding(4, 3, 4, 3);
            btnRolEkle.Name = "btnRolEkle";
            btnRolEkle.Size = new Size(114, 40);
            btnRolEkle.TabIndex = 4;
            btnRolEkle.Text = "Ekle";
            btnRolEkle.UseVisualStyleBackColor = false;
            // 
            // txtRolKodu
            // 
            txtRolKodu.Location = new Point(19, 102);
            txtRolKodu.Margin = new Padding(4, 3, 4, 3);
            txtRolKodu.Name = "txtRolKodu";
            txtRolKodu.Size = new Size(345, 25);
            txtRolKodu.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(15, 81);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Rol Kodu:";
            // 
            // txtRolAdi
            // 
            txtRolAdi.Location = new Point(19, 40);
            txtRolAdi.Margin = new Padding(4, 3, 4, 3);
            txtRolAdi.Name = "txtRolAdi";
            txtRolAdi.Size = new Size(345, 25);
            txtRolAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(15, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "Rol Adı:";
            // 
            // dgvRoller
            // 
            dgvRoller.AllowUserToAddRows = false;
            dgvRoller.AllowUserToDeleteRows = false;
            dgvRoller.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRoller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoller.BackgroundColor = Color.White;
            dgvRoller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(178, 190, 195);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvRoller.DefaultCellStyle = dataGridViewCellStyle1;
            dgvRoller.Location = new Point(15, 73);
            dgvRoller.Margin = new Padding(4, 3, 4, 3);
            dgvRoller.MultiSelect = false;
            dgvRoller.Name = "dgvRoller";
            dgvRoller.ReadOnly = true;
            dgvRoller.RowHeadersVisible = false;
            dgvRoller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoller.Size = new Size(399, 446);
            dgvRoller.TabIndex = 2;
            // 
            // txtRolAra
            // 
            txtRolAra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRolAra.Font = new Font("Segoe UI", 9F);
            txtRolAra.Location = new Point(54, 35);
            txtRolAra.Margin = new Padding(4, 3, 4, 3);
            txtRolAra.Name = "txtRolAra";
            txtRolAra.PlaceholderText = "Rol adı ara...";
            txtRolAra.Size = new Size(360, 23);
            txtRolAra.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(15, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Ara:";
            // 
            // grpMenuler
            // 
            grpMenuler.Controls.Add(dgvMenuler);
            grpMenuler.Controls.Add(txtMenuAra);
            grpMenuler.Controls.Add(label4);
            grpMenuler.Dock = DockStyle.Fill;
            grpMenuler.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpMenuler.ForeColor = Color.FromArgb(64, 64, 64);
            grpMenuler.Location = new Point(429, 0);
            grpMenuler.Margin = new Padding(4, 3, 4, 3);
            grpMenuler.Name = "grpMenuler";
            grpMenuler.Padding = new Padding(12);
            grpMenuler.Size = new Size(373, 750);
            grpMenuler.TabIndex = 2;
            grpMenuler.TabStop = false;
            grpMenuler.Text = "2. Menü / Ekran Seçimi";
            // 
            // dgvMenuler
            // 
            dgvMenuler.AllowUserToAddRows = false;
            dgvMenuler.AllowUserToDeleteRows = false;
            dgvMenuler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMenuler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenuler.BackgroundColor = Color.White;
            dgvMenuler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(178, 190, 195);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMenuler.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMenuler.Location = new Point(15, 73);
            dgvMenuler.Margin = new Padding(4, 3, 4, 3);
            dgvMenuler.MultiSelect = false;
            dgvMenuler.Name = "dgvMenuler";
            dgvMenuler.ReadOnly = true;
            dgvMenuler.RowHeadersVisible = false;
            dgvMenuler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenuler.Size = new Size(343, 662);
            dgvMenuler.TabIndex = 2;
            // 
            // txtMenuAra
            // 
            txtMenuAra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMenuAra.Font = new Font("Segoe UI", 9F);
            txtMenuAra.Location = new Point(55, 35);
            txtMenuAra.Margin = new Padding(4, 3, 4, 3);
            txtMenuAra.Name = "txtMenuAra";
            txtMenuAra.PlaceholderText = "Ekran veya menü adı ara...";
            txtMenuAra.Size = new Size(303, 23);
            txtMenuAra.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(15, 38);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 0;
            label4.Text = "Ara:";
            // 
            // grpYetkiler
            // 
            grpYetkiler.Controls.Add(btnYetkiKaydet);
            grpYetkiler.Controls.Add(panelYetkiKutulari);
            grpYetkiler.Controls.Add(lblSeciliBilgi);
            grpYetkiler.Dock = DockStyle.Right;
            grpYetkiler.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpYetkiler.ForeColor = Color.FromArgb(64, 64, 64);
            grpYetkiler.Location = new Point(802, 0);
            grpYetkiler.Margin = new Padding(4, 3, 4, 3);
            grpYetkiler.Name = "grpYetkiler";
            grpYetkiler.Padding = new Padding(12);
            grpYetkiler.Size = new Size(481, 750);
            grpYetkiler.TabIndex = 3;
            grpYetkiler.TabStop = false;
            grpYetkiler.Text = "3. Yetki Tanımlama";
            // 
            // btnYetkiKaydet
            // 
            btnYetkiKaydet.BackColor = Color.FromArgb(46, 204, 113);
            btnYetkiKaydet.Dock = DockStyle.Bottom;
            btnYetkiKaydet.FlatAppearance.BorderSize = 0;
            btnYetkiKaydet.FlatStyle = FlatStyle.Flat;
            btnYetkiKaydet.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnYetkiKaydet.ForeColor = Color.White;
            btnYetkiKaydet.Location = new Point(12, 680);
            btnYetkiKaydet.Margin = new Padding(4, 3, 4, 3);
            btnYetkiKaydet.Name = "btnYetkiKaydet";
            btnYetkiKaydet.Size = new Size(457, 58);
            btnYetkiKaydet.TabIndex = 2;
            btnYetkiKaydet.Text = "DEĞİŞİKLİKLERİ KAYDET";
            btnYetkiKaydet.UseVisualStyleBackColor = false;
            // 
            // panelYetkiKutulari
            // 
            panelYetkiKutulari.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelYetkiKutulari.BorderStyle = BorderStyle.FixedSingle;
            panelYetkiKutulari.Controls.Add(chkOdunc);
            panelYetkiKutulari.Controls.Add(chkIade);
            panelYetkiKutulari.Controls.Add(chkSil);
            panelYetkiKutulari.Controls.Add(chkGuncelle);
            panelYetkiKutulari.Controls.Add(chkEkle);
            panelYetkiKutulari.Controls.Add(chkListele);
            panelYetkiKutulari.Location = new Point(15, 103);
            panelYetkiKutulari.Margin = new Padding(4, 3, 4, 3);
            panelYetkiKutulari.Name = "panelYetkiKutulari";
            panelYetkiKutulari.Size = new Size(450, 560);
            panelYetkiKutulari.TabIndex = 1;
            // 
            // chkOdunc
            // 
            chkOdunc.AutoSize = true;
            chkOdunc.Font = new Font("Segoe UI", 10F);
            chkOdunc.Location = new Point(27, 256);
            chkOdunc.Margin = new Padding(4, 3, 4, 3);
            chkOdunc.Name = "chkOdunc";
            chkOdunc.Size = new Size(154, 23);
            chkOdunc.TabIndex = 5;
            chkOdunc.Text = "Ödünç Verme Yetkisi";
            chkOdunc.UseVisualStyleBackColor = true;
            // 
            // chkIade
            // 
            chkIade.AutoSize = true;
            chkIade.Font = new Font("Segoe UI", 10F);
            chkIade.Location = new Point(27, 212);
            chkIade.Margin = new Padding(4, 3, 4, 3);
            chkIade.Name = "chkIade";
            chkIade.Size = new Size(131, 23);
            chkIade.TabIndex = 4;
            chkIade.Text = "İade Alma Yetkisi";
            chkIade.UseVisualStyleBackColor = true;
            // 
            // chkSil
            // 
            chkSil.AutoSize = true;
            chkSil.Font = new Font("Segoe UI", 10F);
            chkSil.ForeColor = Color.FromArgb(192, 57, 43);
            chkSil.Location = new Point(27, 168);
            chkSil.Margin = new Padding(4, 3, 4, 3);
            chkSil.Name = "chkSil";
            chkSil.Size = new Size(129, 23);
            chkSil.TabIndex = 3;
            chkSil.Text = "Veri Silme Yetkisi";
            chkSil.UseVisualStyleBackColor = true;
            // 
            // chkGuncelle
            // 
            chkGuncelle.AutoSize = true;
            chkGuncelle.Font = new Font("Segoe UI", 10F);
            chkGuncelle.ForeColor = Color.FromArgb(41, 128, 185);
            chkGuncelle.Location = new Point(27, 125);
            chkGuncelle.Margin = new Padding(4, 3, 4, 3);
            chkGuncelle.Name = "chkGuncelle";
            chkGuncelle.Size = new Size(165, 23);
            chkGuncelle.TabIndex = 2;
            chkGuncelle.Text = "Veri Düzenleme Yetkisi";
            chkGuncelle.UseVisualStyleBackColor = true;
            // 
            // chkEkle
            // 
            chkEkle.AutoSize = true;
            chkEkle.Font = new Font("Segoe UI", 10F);
            chkEkle.ForeColor = Color.FromArgb(39, 174, 96);
            chkEkle.Location = new Point(27, 81);
            chkEkle.Margin = new Padding(4, 3, 4, 3);
            chkEkle.Name = "chkEkle";
            chkEkle.Size = new Size(140, 23);
            chkEkle.TabIndex = 1;
            chkEkle.Text = "Veri Ekleme Yetkisi";
            chkEkle.UseVisualStyleBackColor = true;
            // 
            // chkListele
            // 
            chkListele.AutoSize = true;
            chkListele.Checked = true;
            chkListele.CheckState = CheckState.Checked;
            chkListele.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkListele.Location = new Point(27, 37);
            chkListele.Margin = new Padding(4, 3, 4, 3);
            chkListele.Name = "chkListele";
            chkListele.Size = new Size(171, 23);
            chkListele.TabIndex = 0;
            chkListele.Text = "Görüntüleme (Listele)";
            chkListele.UseVisualStyleBackColor = true;
            // 
            // lblSeciliBilgi
            // 
            lblSeciliBilgi.BackColor = Color.FromArgb(255, 248, 225);
            lblSeciliBilgi.BorderStyle = BorderStyle.FixedSingle;
            lblSeciliBilgi.Dock = DockStyle.Top;
            lblSeciliBilgi.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblSeciliBilgi.ForeColor = Color.FromArgb(64, 64, 64);
            lblSeciliBilgi.Location = new Point(12, 30);
            lblSeciliBilgi.Margin = new Padding(4, 0, 4, 0);
            lblSeciliBilgi.Name = "lblSeciliBilgi";
            lblSeciliBilgi.Size = new Size(457, 55);
            lblSeciliBilgi.TabIndex = 0;
            lblSeciliBilgi.Text = "Lütfen soldan bir rol, ortadan bir menü seçiniz.";
            lblSeciliBilgi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1283, 750);
            Controls.Add(grpMenuler);
            Controls.Add(grpYetkiler);
            Controls.Add(grpRoller);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yönetim Paneli";
            Load += frmAdmin_Load;
            grpRoller.ResumeLayout(false);
            grpRoller.PerformLayout();
            panelRolIslemleri.ResumeLayout(false);
            panelRolIslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoller).EndInit();
            grpMenuler.ResumeLayout(false);
            grpMenuler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenuler).EndInit();
            grpYetkiler.ResumeLayout(false);
            panelYetkiKutulari.ResumeLayout(false);
            panelYetkiKutulari.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRoller;
        private System.Windows.Forms.TextBox txtRolAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRoller;
        private System.Windows.Forms.Panel panelRolIslemleri;
        private System.Windows.Forms.TextBox txtRolAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRolKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRolSil;
        private System.Windows.Forms.Button btnRolGuncelle;
        private System.Windows.Forms.Button btnRolEkle;
        private System.Windows.Forms.GroupBox grpMenuler;
        private System.Windows.Forms.TextBox txtMenuAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMenuler;
        private System.Windows.Forms.GroupBox grpYetkiler;
        private System.Windows.Forms.Label lblSeciliBilgi;
        private System.Windows.Forms.Panel panelYetkiKutulari;
        private System.Windows.Forms.CheckBox chkOdunc;
        private System.Windows.Forms.CheckBox chkIade;
        private System.Windows.Forms.CheckBox chkSil;
        private System.Windows.Forms.CheckBox chkGuncelle;
        private System.Windows.Forms.CheckBox chkEkle;
        private System.Windows.Forms.CheckBox chkListele;
        private System.Windows.Forms.Button btnYetkiKaydet;
    }
}