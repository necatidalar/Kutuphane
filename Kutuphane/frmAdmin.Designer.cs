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
            components = new System.ComponentModel.Container();
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
            txtRolId = new TextBox();
            label5 = new Label();
            txtRolAdi = new TextBox();
            label2 = new Label();
            dgvRoller = new DataGridView();
            rolIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rolAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rolKoduDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifMiDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            personelRolleriDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rolYetkileriDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rolBindingSource = new BindingSource(components);
            txtRolAra = new TextBox();
            label1 = new Label();
            grpYetki = new GroupBox();
            btnYetkiKaydet = new Button();
            dgvYetki = new DataGridView();
            yetkiIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yetkiAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yetkiKoduDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Secim = new DataGridViewCheckBoxColumn();
            rolYetkileriDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            yetkiBindingSource = new BindingSource(components);
            txtYetkiAra = new TextBox();
            label4 = new Label();
            grpRoller.SuspendLayout();
            panelRolIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoller).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rolBindingSource).BeginInit();
            grpYetki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvYetki).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yetkiBindingSource).BeginInit();
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
            panelRolIslemleri.Controls.Add(txtRolId);
            panelRolIslemleri.Controls.Add(label5);
            panelRolIslemleri.Controls.Add(txtRolAdi);
            panelRolIslemleri.Controls.Add(label2);
            panelRolIslemleri.Dock = DockStyle.Bottom;
            panelRolIslemleri.Location = new Point(12, 502);
            panelRolIslemleri.Margin = new Padding(4, 3, 4, 3);
            panelRolIslemleri.Name = "panelRolIslemleri";
            panelRolIslemleri.Size = new Size(405, 236);
            panelRolIslemleri.TabIndex = 3;
            // 
            // btnRolSil
            // 
            btnRolSil.BackColor = Color.FromArgb(214, 48, 49);
            btnRolSil.FlatStyle = FlatStyle.Flat;
            btnRolSil.ForeColor = Color.White;
            btnRolSil.Location = new Point(264, 187);
            btnRolSil.Margin = new Padding(4, 3, 4, 3);
            btnRolSil.Name = "btnRolSil";
            btnRolSil.Size = new Size(104, 40);
            btnRolSil.TabIndex = 6;
            btnRolSil.Text = "Sil";
            btnRolSil.UseVisualStyleBackColor = false;
            btnRolSil.Click += btnRolSil_Click;
            // 
            // btnRolGuncelle
            // 
            btnRolGuncelle.BackColor = Color.FromArgb(9, 132, 227);
            btnRolGuncelle.FlatStyle = FlatStyle.Flat;
            btnRolGuncelle.ForeColor = Color.White;
            btnRolGuncelle.Location = new Point(144, 187);
            btnRolGuncelle.Margin = new Padding(4, 3, 4, 3);
            btnRolGuncelle.Name = "btnRolGuncelle";
            btnRolGuncelle.Size = new Size(113, 40);
            btnRolGuncelle.TabIndex = 5;
            btnRolGuncelle.Text = "Güncelle";
            btnRolGuncelle.UseVisualStyleBackColor = false;
            btnRolGuncelle.Click += btnRolGuncelle_Click;
            // 
            // btnRolEkle
            // 
            btnRolEkle.BackColor = Color.FromArgb(0, 184, 148);
            btnRolEkle.FlatStyle = FlatStyle.Flat;
            btnRolEkle.ForeColor = Color.White;
            btnRolEkle.Location = new Point(23, 187);
            btnRolEkle.Margin = new Padding(4, 3, 4, 3);
            btnRolEkle.Name = "btnRolEkle";
            btnRolEkle.Size = new Size(114, 40);
            btnRolEkle.TabIndex = 4;
            btnRolEkle.Text = "Ekle";
            btnRolEkle.UseVisualStyleBackColor = false;
            btnRolEkle.Click += btnRolEkle_Click;
            // 
            // txtRolKodu
            // 
            txtRolKodu.Location = new Point(23, 141);
            txtRolKodu.Margin = new Padding(4, 3, 4, 3);
            txtRolKodu.Name = "txtRolKodu";
            txtRolKodu.Size = new Size(345, 25);
            txtRolKodu.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(23, 123);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Rol Kodu:";
            // 
            // txtRolId
            // 
            txtRolId.Enabled = false;
            txtRolId.Location = new Point(23, 33);
            txtRolId.Margin = new Padding(4, 3, 4, 3);
            txtRolId.Name = "txtRolId";
            txtRolId.Size = new Size(345, 25);
            txtRolId.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(23, 15);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 0;
            label5.Text = "Rol Id:";
            // 
            // txtRolAdi
            // 
            txtRolAdi.Location = new Point(23, 87);
            txtRolAdi.Margin = new Padding(4, 3, 4, 3);
            txtRolAdi.Name = "txtRolAdi";
            txtRolAdi.Size = new Size(345, 25);
            txtRolAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(23, 69);
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
            dgvRoller.AllowUserToResizeRows = false;
            dgvRoller.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRoller.AutoGenerateColumns = false;
            dgvRoller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoller.BackgroundColor = Color.White;
            dgvRoller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoller.Columns.AddRange(new DataGridViewColumn[] { rolIdDataGridViewTextBoxColumn, rolAdiDataGridViewTextBoxColumn, rolKoduDataGridViewTextBoxColumn, aktifMiDataGridViewCheckBoxColumn, personelRolleriDataGridViewTextBoxColumn, rolYetkileriDataGridViewTextBoxColumn });
            dgvRoller.DataSource = rolBindingSource;
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
            dgvRoller.Size = new Size(399, 423);
            dgvRoller.TabIndex = 2;
            dgvRoller.ColumnHeaderMouseClick += dgvRoller_ColumnHeaderMouseClick;
            dgvRoller.SelectionChanged += dgvRoller_SelectionChanged;
            // 
            // rolIdDataGridViewTextBoxColumn
            // 
            rolIdDataGridViewTextBoxColumn.DataPropertyName = "RolId";
            rolIdDataGridViewTextBoxColumn.HeaderText = "RolId";
            rolIdDataGridViewTextBoxColumn.Name = "rolIdDataGridViewTextBoxColumn";
            rolIdDataGridViewTextBoxColumn.ReadOnly = true;
            rolIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // rolAdiDataGridViewTextBoxColumn
            // 
            rolAdiDataGridViewTextBoxColumn.DataPropertyName = "RolAdi";
            rolAdiDataGridViewTextBoxColumn.HeaderText = "Rol Adı";
            rolAdiDataGridViewTextBoxColumn.Name = "rolAdiDataGridViewTextBoxColumn";
            rolAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rolKoduDataGridViewTextBoxColumn
            // 
            rolKoduDataGridViewTextBoxColumn.DataPropertyName = "RolKodu";
            rolKoduDataGridViewTextBoxColumn.HeaderText = "Rol Kodu";
            rolKoduDataGridViewTextBoxColumn.Name = "rolKoduDataGridViewTextBoxColumn";
            rolKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aktifMiDataGridViewCheckBoxColumn
            // 
            aktifMiDataGridViewCheckBoxColumn.DataPropertyName = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.HeaderText = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.Name = "aktifMiDataGridViewCheckBoxColumn";
            aktifMiDataGridViewCheckBoxColumn.ReadOnly = true;
            aktifMiDataGridViewCheckBoxColumn.Visible = false;
            // 
            // personelRolleriDataGridViewTextBoxColumn
            // 
            personelRolleriDataGridViewTextBoxColumn.DataPropertyName = "PersonelRolleri";
            personelRolleriDataGridViewTextBoxColumn.HeaderText = "PersonelRolleri";
            personelRolleriDataGridViewTextBoxColumn.Name = "personelRolleriDataGridViewTextBoxColumn";
            personelRolleriDataGridViewTextBoxColumn.ReadOnly = true;
            personelRolleriDataGridViewTextBoxColumn.Visible = false;
            // 
            // rolYetkileriDataGridViewTextBoxColumn
            // 
            rolYetkileriDataGridViewTextBoxColumn.DataPropertyName = "RolYetkileri";
            rolYetkileriDataGridViewTextBoxColumn.HeaderText = "RolYetkileri";
            rolYetkileriDataGridViewTextBoxColumn.Name = "rolYetkileriDataGridViewTextBoxColumn";
            rolYetkileriDataGridViewTextBoxColumn.ReadOnly = true;
            rolYetkileriDataGridViewTextBoxColumn.Visible = false;
            // 
            // rolBindingSource
            // 
            rolBindingSource.DataSource = typeof(Model.Entity.Rol);
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
            txtRolAra.TextChanged += txtRolAra_TextChanged;
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
            // grpYetki
            // 
            grpYetki.Controls.Add(btnYetkiKaydet);
            grpYetki.Controls.Add(dgvYetki);
            grpYetki.Controls.Add(txtYetkiAra);
            grpYetki.Controls.Add(label4);
            grpYetki.Dock = DockStyle.Fill;
            grpYetki.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpYetki.ForeColor = Color.FromArgb(64, 64, 64);
            grpYetki.Location = new Point(429, 0);
            grpYetki.Margin = new Padding(4, 3, 4, 3);
            grpYetki.Name = "grpYetki";
            grpYetki.Padding = new Padding(12);
            grpYetki.Size = new Size(854, 750);
            grpYetki.TabIndex = 2;
            grpYetki.TabStop = false;
            grpYetki.Text = "2. İşlem Seçimi";
            // 
            // btnYetkiKaydet
            // 
            btnYetkiKaydet.Anchor = AnchorStyles.Bottom;
            btnYetkiKaydet.BackColor = Color.FromArgb(46, 204, 113);
            btnYetkiKaydet.FlatAppearance.BorderSize = 0;
            btnYetkiKaydet.FlatStyle = FlatStyle.Flat;
            btnYetkiKaydet.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnYetkiKaydet.ForeColor = Color.White;
            btnYetkiKaydet.Location = new Point(211, 687);
            btnYetkiKaydet.Margin = new Padding(4, 3, 4, 3);
            btnYetkiKaydet.MaximumSize = new Size(419, 48);
            btnYetkiKaydet.Name = "btnYetkiKaydet";
            btnYetkiKaydet.Size = new Size(419, 48);
            btnYetkiKaydet.TabIndex = 2;
            btnYetkiKaydet.Text = "DEĞİŞİKLİKLERİ KAYDET";
            btnYetkiKaydet.UseVisualStyleBackColor = false;
            btnYetkiKaydet.Click += btnYetkiKaydet_Click;
            // 
            // dgvYetki
            // 
            dgvYetki.AllowUserToAddRows = false;
            dgvYetki.AllowUserToDeleteRows = false;
            dgvYetki.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvYetki.AutoGenerateColumns = false;
            dgvYetki.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvYetki.BackgroundColor = Color.White;
            dgvYetki.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYetki.Columns.AddRange(new DataGridViewColumn[] { yetkiIdDataGridViewTextBoxColumn, yetkiAdiDataGridViewTextBoxColumn, yetkiKoduDataGridViewTextBoxColumn, Secim, rolYetkileriDataGridViewTextBoxColumn1 });
            dgvYetki.DataSource = yetkiBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(178, 190, 195);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvYetki.DefaultCellStyle = dataGridViewCellStyle2;
            dgvYetki.Location = new Point(8, 73);
            dgvYetki.Margin = new Padding(4, 3, 4, 3);
            dgvYetki.MultiSelect = false;
            dgvYetki.Name = "dgvYetki";
            dgvYetki.ReadOnly = true;
            dgvYetki.RowHeadersVisible = false;
            dgvYetki.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYetki.Size = new Size(824, 596);
            dgvYetki.TabIndex = 2;
            dgvYetki.ColumnHeaderMouseClick += dgvYetki_ColumnHeaderMouseClick;
            // 
            // yetkiIdDataGridViewTextBoxColumn
            // 
            yetkiIdDataGridViewTextBoxColumn.DataPropertyName = "YetkiId";
            yetkiIdDataGridViewTextBoxColumn.HeaderText = "YetkiId";
            yetkiIdDataGridViewTextBoxColumn.Name = "yetkiIdDataGridViewTextBoxColumn";
            yetkiIdDataGridViewTextBoxColumn.ReadOnly = true;
            yetkiIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // yetkiAdiDataGridViewTextBoxColumn
            // 
            yetkiAdiDataGridViewTextBoxColumn.DataPropertyName = "YetkiAdi";
            yetkiAdiDataGridViewTextBoxColumn.HeaderText = "Yetki Adı";
            yetkiAdiDataGridViewTextBoxColumn.Name = "yetkiAdiDataGridViewTextBoxColumn";
            yetkiAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yetkiKoduDataGridViewTextBoxColumn
            // 
            yetkiKoduDataGridViewTextBoxColumn.DataPropertyName = "YetkiKodu";
            yetkiKoduDataGridViewTextBoxColumn.HeaderText = "Yetki Kodu";
            yetkiKoduDataGridViewTextBoxColumn.Name = "yetkiKoduDataGridViewTextBoxColumn";
            yetkiKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Secim
            // 
            Secim.HeaderText = "✔";
            Secim.Name = "Secim";
            Secim.ReadOnly = true;
            // 
            // rolYetkileriDataGridViewTextBoxColumn1
            // 
            rolYetkileriDataGridViewTextBoxColumn1.DataPropertyName = "RolYetkileri";
            rolYetkileriDataGridViewTextBoxColumn1.HeaderText = "RolYetkileri";
            rolYetkileriDataGridViewTextBoxColumn1.Name = "rolYetkileriDataGridViewTextBoxColumn1";
            rolYetkileriDataGridViewTextBoxColumn1.ReadOnly = true;
            rolYetkileriDataGridViewTextBoxColumn1.Visible = false;
            // 
            // yetkiBindingSource
            // 
            yetkiBindingSource.DataSource = typeof(Model.Entity.Yetki);
            // 
            // txtYetkiAra
            // 
            txtYetkiAra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtYetkiAra.Font = new Font("Segoe UI", 9F);
            txtYetkiAra.Location = new Point(55, 35);
            txtYetkiAra.Margin = new Padding(4, 3, 4, 3);
            txtYetkiAra.Name = "txtYetkiAra";
            txtYetkiAra.PlaceholderText = "İşlem adı veya işlem kodu ara...";
            txtYetkiAra.Size = new Size(784, 23);
            txtYetkiAra.TabIndex = 1;
            txtYetkiAra.TextChanged += txtYetkiAra_TextChanged;
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
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1283, 750);
            Controls.Add(grpYetki);
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
            ((System.ComponentModel.ISupportInitialize)rolBindingSource).EndInit();
            grpYetki.ResumeLayout(false);
            grpYetki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvYetki).EndInit();
            ((System.ComponentModel.ISupportInitialize)yetkiBindingSource).EndInit();
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
        private System.Windows.Forms.GroupBox grpYetki;
        private System.Windows.Forms.TextBox txtYetkiAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvYetki;
        private Button btnYetkiKaydet;
        private DataGridViewTextBoxColumn rolIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rolAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rolKoduDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn personelRolleriDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rolYetkileriDataGridViewTextBoxColumn;
        private BindingSource rolBindingSource;
        private TextBox txtRolId;
        private Label label5;
        private BindingSource yetkiBindingSource;
        private DataGridViewTextBoxColumn yetkiIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yetkiKoduDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yetkiAdiDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn Secim;
        private DataGridViewTextBoxColumn rolYetkileriDataGridViewTextBoxColumn1;
    }
}