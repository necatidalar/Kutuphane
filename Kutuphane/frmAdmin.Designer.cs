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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            grpPersonel = new GroupBox();
            btnPersonelRolKaydet = new Button();
            dgvPersonel = new DataGridView();
            personelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cinsiyetIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cinsiyetAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifMiDataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            personelBilgileriDtoBindingSource = new BindingSource(components);
            txtPersonelAra = new TextBox();
            labelPersonelAra = new Label();
            grpPersonelRolleri = new GroupBox();
            btnRolKaldir = new Button();
            dgvPersonelRolleri = new DataGridView();
            personelRolIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personelIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            rolIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            personelAdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personelSoyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rolAdiDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            personelRolDtoBindingSource = new BindingSource(components);
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            grpRoller.SuspendLayout();
            panelRolIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoller).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rolBindingSource).BeginInit();
            grpYetki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvYetki).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yetkiBindingSource).BeginInit();
            grpPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personelBilgileriDtoBindingSource).BeginInit();
            grpPersonelRolleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonelRolleri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personelRolDtoBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // grpRoller
            // 
            grpRoller.Controls.Add(panelRolIslemleri);
            grpRoller.Controls.Add(dgvRoller);
            grpRoller.Controls.Add(txtRolAra);
            grpRoller.Controls.Add(label1);
            grpRoller.Dock = DockStyle.Fill;
            grpRoller.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpRoller.ForeColor = Color.FromArgb(64, 64, 64);
            grpRoller.Location = new Point(4, 3);
            grpRoller.Margin = new Padding(4, 3, 4, 3);
            grpRoller.MinimumSize = new Size(419, 744);
            grpRoller.Name = "grpRoller";
            grpRoller.Padding = new Padding(12);
            grpRoller.Size = new Size(419, 744);
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
            panelRolIslemleri.Location = new Point(12, 496);
            panelRolIslemleri.Margin = new Padding(4, 3, 4, 3);
            panelRolIslemleri.Name = "panelRolIslemleri";
            panelRolIslemleri.Size = new Size(395, 236);
            panelRolIslemleri.TabIndex = 3;
            // 
            // btnRolSil
            // 
            btnRolSil.Anchor = AnchorStyles.Top;
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
            btnRolGuncelle.Anchor = AnchorStyles.Top;
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
            btnRolEkle.Anchor = AnchorStyles.Top;
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
            txtRolKodu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            txtRolId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            txtRolAdi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            dgvRoller.Size = new Size(389, 481);
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
            txtRolAra.Size = new Size(350, 23);
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
            grpYetki.Location = new Point(431, 3);
            grpYetki.Margin = new Padding(4, 3, 4, 3);
            grpYetki.Name = "grpYetki";
            grpYetki.Padding = new Padding(12);
            grpYetki.Size = new Size(419, 744);
            grpYetki.TabIndex = 2;
            grpYetki.TabStop = false;
            grpYetki.Text = "2. Yetki Seçimi";
            // 
            // btnYetkiKaydet
            // 
            btnYetkiKaydet.Anchor = AnchorStyles.Bottom;
            btnYetkiKaydet.BackColor = Color.FromArgb(46, 204, 113);
            btnYetkiKaydet.FlatAppearance.BorderSize = 0;
            btnYetkiKaydet.FlatStyle = FlatStyle.Flat;
            btnYetkiKaydet.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnYetkiKaydet.ForeColor = Color.White;
            btnYetkiKaydet.Location = new Point(8, 681);
            btnYetkiKaydet.Margin = new Padding(4, 3, 4, 3);
            btnYetkiKaydet.Name = "btnYetkiKaydet";
            btnYetkiKaydet.Size = new Size(404, 48);
            btnYetkiKaydet.TabIndex = 2;
            btnYetkiKaydet.Text = "YETKİLERİ KAYDET";
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 190, 195);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvYetki.DefaultCellStyle = dataGridViewCellStyle3;
            dgvYetki.Location = new Point(8, 73);
            dgvYetki.Margin = new Padding(4, 3, 4, 3);
            dgvYetki.MultiSelect = false;
            dgvYetki.Name = "dgvYetki";
            dgvYetki.ReadOnly = true;
            dgvYetki.RowHeadersVisible = false;
            dgvYetki.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYetki.Size = new Size(404, 590);
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.NullValue = false;
            Secim.DefaultCellStyle = dataGridViewCellStyle2;
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
            txtYetkiAra.PlaceholderText = "İşlem adı ara...";
            txtYetkiAra.Size = new Size(349, 23);
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
            // grpPersonel
            // 
            grpPersonel.Controls.Add(btnPersonelRolKaydet);
            grpPersonel.Controls.Add(dgvPersonel);
            grpPersonel.Controls.Add(txtPersonelAra);
            grpPersonel.Controls.Add(labelPersonelAra);
            grpPersonel.Dock = DockStyle.Fill;
            grpPersonel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpPersonel.ForeColor = Color.FromArgb(64, 64, 64);
            grpPersonel.Location = new Point(3, 3);
            grpPersonel.Name = "grpPersonel";
            grpPersonel.Padding = new Padding(12);
            grpPersonel.Size = new Size(417, 472);
            grpPersonel.TabIndex = 3;
            grpPersonel.TabStop = false;
            grpPersonel.Text = "3. Personel Seçimi";
            // 
            // btnPersonelRolKaydet
            // 
            btnPersonelRolKaydet.Anchor = AnchorStyles.Bottom;
            btnPersonelRolKaydet.BackColor = Color.FromArgb(255, 159, 67);
            btnPersonelRolKaydet.FlatAppearance.BorderSize = 0;
            btnPersonelRolKaydet.FlatStyle = FlatStyle.Flat;
            btnPersonelRolKaydet.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPersonelRolKaydet.ForeColor = Color.White;
            btnPersonelRolKaydet.Location = new Point(10, 409);
            btnPersonelRolKaydet.Name = "btnPersonelRolKaydet";
            btnPersonelRolKaydet.Size = new Size(396, 48);
            btnPersonelRolKaydet.TabIndex = 2;
            btnPersonelRolKaydet.Text = "SEÇİLİ PERSONELE ROL ATA";
            btnPersonelRolKaydet.UseVisualStyleBackColor = false;
            btnPersonelRolKaydet.Click += btnPersonelRolKaydet_Click;
            // 
            // dgvPersonel
            // 
            dgvPersonel.AllowUserToAddRows = false;
            dgvPersonel.AllowUserToDeleteRows = false;
            dgvPersonel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPersonel.AutoGenerateColumns = false;
            dgvPersonel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonel.BackgroundColor = Color.White;
            dgvPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonel.Columns.AddRange(new DataGridViewColumn[] { personelIdDataGridViewTextBoxColumn, adDataGridViewTextBoxColumn, soyadDataGridViewTextBoxColumn, cinsiyetIdDataGridViewTextBoxColumn, cinsiyetAdiDataGridViewTextBoxColumn, aktifMiDataGridViewCheckBoxColumn1 });
            dgvPersonel.DataSource = personelBilgileriDtoBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(178, 190, 195);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPersonel.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPersonel.Location = new Point(12, 64);
            dgvPersonel.MultiSelect = false;
            dgvPersonel.Name = "dgvPersonel";
            dgvPersonel.ReadOnly = true;
            dgvPersonel.RowHeadersVisible = false;
            dgvPersonel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonel.Size = new Size(393, 339);
            dgvPersonel.TabIndex = 2;
            dgvPersonel.ColumnHeaderMouseClick += dgvPersonel_ColumnHeaderMouseClick;
            dgvPersonel.SelectionChanged += dgvPersonel_SelectionChanged;
            // 
            // personelIdDataGridViewTextBoxColumn
            // 
            personelIdDataGridViewTextBoxColumn.DataPropertyName = "PersonelId";
            personelIdDataGridViewTextBoxColumn.HeaderText = "PersonelId";
            personelIdDataGridViewTextBoxColumn.Name = "personelIdDataGridViewTextBoxColumn";
            personelIdDataGridViewTextBoxColumn.ReadOnly = true;
            personelIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // adDataGridViewTextBoxColumn
            // 
            adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            adDataGridViewTextBoxColumn.HeaderText = "Ad";
            adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            soyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cinsiyetIdDataGridViewTextBoxColumn
            // 
            cinsiyetIdDataGridViewTextBoxColumn.DataPropertyName = "CinsiyetId";
            cinsiyetIdDataGridViewTextBoxColumn.HeaderText = "CinsiyetId";
            cinsiyetIdDataGridViewTextBoxColumn.Name = "cinsiyetIdDataGridViewTextBoxColumn";
            cinsiyetIdDataGridViewTextBoxColumn.ReadOnly = true;
            cinsiyetIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // cinsiyetAdiDataGridViewTextBoxColumn
            // 
            cinsiyetAdiDataGridViewTextBoxColumn.DataPropertyName = "CinsiyetAdi";
            cinsiyetAdiDataGridViewTextBoxColumn.HeaderText = "CinsiyetAdi";
            cinsiyetAdiDataGridViewTextBoxColumn.Name = "cinsiyetAdiDataGridViewTextBoxColumn";
            cinsiyetAdiDataGridViewTextBoxColumn.ReadOnly = true;
            cinsiyetAdiDataGridViewTextBoxColumn.Visible = false;
            // 
            // aktifMiDataGridViewCheckBoxColumn1
            // 
            aktifMiDataGridViewCheckBoxColumn1.DataPropertyName = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn1.HeaderText = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn1.Name = "aktifMiDataGridViewCheckBoxColumn1";
            aktifMiDataGridViewCheckBoxColumn1.ReadOnly = true;
            aktifMiDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // personelBilgileriDtoBindingSource
            // 
            personelBilgileriDtoBindingSource.DataSource = typeof(Model.DTO.PersonelBilgileriDto);
            // 
            // txtPersonelAra
            // 
            txtPersonelAra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPersonelAra.Font = new Font("Segoe UI", 9F);
            txtPersonelAra.Location = new Point(46, 35);
            txtPersonelAra.Name = "txtPersonelAra";
            txtPersonelAra.PlaceholderText = "Personel ara...";
            txtPersonelAra.Size = new Size(359, 23);
            txtPersonelAra.TabIndex = 1;
            txtPersonelAra.TextChanged += txtPersonelAra_TextChanged;
            // 
            // labelPersonelAra
            // 
            labelPersonelAra.AutoSize = true;
            labelPersonelAra.Font = new Font("Segoe UI", 9F);
            labelPersonelAra.Location = new Point(12, 38);
            labelPersonelAra.Name = "labelPersonelAra";
            labelPersonelAra.Size = new Size(28, 15);
            labelPersonelAra.TabIndex = 0;
            labelPersonelAra.Text = "Ara:";
            // 
            // grpPersonelRolleri
            // 
            grpPersonelRolleri.Controls.Add(btnRolKaldir);
            grpPersonelRolleri.Controls.Add(dgvPersonelRolleri);
            grpPersonelRolleri.Controls.Add(button1);
            grpPersonelRolleri.Dock = DockStyle.Fill;
            grpPersonelRolleri.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpPersonelRolleri.ForeColor = Color.FromArgb(64, 64, 64);
            grpPersonelRolleri.Location = new Point(3, 481);
            grpPersonelRolleri.Name = "grpPersonelRolleri";
            grpPersonelRolleri.Padding = new Padding(12);
            grpPersonelRolleri.Size = new Size(417, 260);
            grpPersonelRolleri.TabIndex = 4;
            grpPersonelRolleri.TabStop = false;
            grpPersonelRolleri.Text = "4. Personel Rolleri";
            // 
            // btnRolKaldir
            // 
            btnRolKaldir.Anchor = AnchorStyles.Bottom;
            btnRolKaldir.BackColor = Color.FromArgb(214, 48, 49);
            btnRolKaldir.FlatAppearance.BorderSize = 0;
            btnRolKaldir.FlatStyle = FlatStyle.Flat;
            btnRolKaldir.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRolKaldir.ForeColor = Color.White;
            btnRolKaldir.Location = new Point(12, 203);
            btnRolKaldir.Margin = new Padding(4, 3, 4, 3);
            btnRolKaldir.Name = "btnRolKaldir";
            btnRolKaldir.Size = new Size(393, 48);
            btnRolKaldir.TabIndex = 4;
            btnRolKaldir.Text = "ROL KALDIR";
            btnRolKaldir.UseVisualStyleBackColor = false;
            btnRolKaldir.Click += btnRolKaldir_Click;
            // 
            // dgvPersonelRolleri
            // 
            dgvPersonelRolleri.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPersonelRolleri.AutoGenerateColumns = false;
            dgvPersonelRolleri.BackgroundColor = Color.White;
            dgvPersonelRolleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonelRolleri.Columns.AddRange(new DataGridViewColumn[] { personelRolIdDataGridViewTextBoxColumn, personelIdDataGridViewTextBoxColumn1, rolIdDataGridViewTextBoxColumn1, personelAdDataGridViewTextBoxColumn, personelSoyadDataGridViewTextBoxColumn, rolAdiDataGridViewTextBoxColumn1 });
            dgvPersonelRolleri.DataSource = personelRolDtoBindingSource;
            dgvPersonelRolleri.Location = new Point(12, 33);
            dgvPersonelRolleri.Name = "dgvPersonelRolleri";
            dgvPersonelRolleri.Size = new Size(393, 160);
            dgvPersonelRolleri.TabIndex = 3;
            dgvPersonelRolleri.ColumnHeaderMouseClick += dgvPersonelRolleri_ColumnHeaderMouseClick;
            // 
            // personelRolIdDataGridViewTextBoxColumn
            // 
            personelRolIdDataGridViewTextBoxColumn.DataPropertyName = "PersonelRolId";
            personelRolIdDataGridViewTextBoxColumn.HeaderText = "PersonelRolId";
            personelRolIdDataGridViewTextBoxColumn.Name = "personelRolIdDataGridViewTextBoxColumn";
            personelRolIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // personelIdDataGridViewTextBoxColumn1
            // 
            personelIdDataGridViewTextBoxColumn1.DataPropertyName = "PersonelId";
            personelIdDataGridViewTextBoxColumn1.HeaderText = "PersonelId";
            personelIdDataGridViewTextBoxColumn1.Name = "personelIdDataGridViewTextBoxColumn1";
            personelIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // rolIdDataGridViewTextBoxColumn1
            // 
            rolIdDataGridViewTextBoxColumn1.DataPropertyName = "RolId";
            rolIdDataGridViewTextBoxColumn1.HeaderText = "RolId";
            rolIdDataGridViewTextBoxColumn1.Name = "rolIdDataGridViewTextBoxColumn1";
            rolIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // personelAdDataGridViewTextBoxColumn
            // 
            personelAdDataGridViewTextBoxColumn.DataPropertyName = "PersonelAd";
            personelAdDataGridViewTextBoxColumn.HeaderText = "Personel Adı";
            personelAdDataGridViewTextBoxColumn.Name = "personelAdDataGridViewTextBoxColumn";
            // 
            // personelSoyadDataGridViewTextBoxColumn
            // 
            personelSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelSoyad";
            personelSoyadDataGridViewTextBoxColumn.HeaderText = "Personel Soyadı";
            personelSoyadDataGridViewTextBoxColumn.Name = "personelSoyadDataGridViewTextBoxColumn";
            // 
            // rolAdiDataGridViewTextBoxColumn1
            // 
            rolAdiDataGridViewTextBoxColumn1.DataPropertyName = "RolAdi";
            rolAdiDataGridViewTextBoxColumn1.HeaderText = "Rol Adı";
            rolAdiDataGridViewTextBoxColumn1.Name = "rolAdiDataGridViewTextBoxColumn1";
            // 
            // personelRolDtoBindingSource
            // 
            personelRolDtoBindingSource.DataSource = typeof(Model.DTO.PersonelRolDto);
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.FromArgb(255, 159, 67);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(120, 542);
            button1.Name = "button1";
            button1.Size = new Size(396, 48);
            button1.TabIndex = 2;
            button1.Text = "SEÇİLİ PERSONELE ROL ATA";
            button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(grpRoller, 0, 0);
            tableLayoutPanel1.Controls.Add(grpYetki, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1283, 750);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(grpPersonel, 0, 0);
            tableLayoutPanel2.Controls.Add(grpPersonelRolleri, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(857, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 64.3026F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35.6974F));
            tableLayoutPanel2.Size = new Size(423, 744);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1283, 750);
            Controls.Add(tableLayoutPanel1);
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
            grpPersonel.ResumeLayout(false);
            grpPersonel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).EndInit();
            ((System.ComponentModel.ISupportInitialize)personelBilgileriDtoBindingSource).EndInit();
            grpPersonelRolleri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonelRolleri).EndInit();
            ((System.ComponentModel.ISupportInitialize)personelRolDtoBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnYetkiKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelRolleriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolYetkileriDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private System.Windows.Forms.TextBox txtRolId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource yetkiBindingSource;

        private System.Windows.Forms.GroupBox grpPersonel;
        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.Button btnPersonelRolKaydet;
        private System.Windows.Forms.TextBox txtPersonelAra;
        private System.Windows.Forms.Label labelPersonelAra;
        private DataGridViewTextBoxColumn personelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinsiyetIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinsiyetAdiDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn1;
        private BindingSource personelBilgileriDtoBindingSource;
        private GroupBox grpPersonelRolleri;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvPersonelRolleri;
        private DataGridViewTextBoxColumn yetkiIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yetkiAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yetkiKoduDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn Secim;
        private DataGridViewTextBoxColumn rolYetkileriDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn personelAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personelSoyadiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personelRolIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personelIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn rolIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn personelAdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personelSoyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rolAdiDataGridViewTextBoxColumn1;
        private BindingSource personelRolDtoBindingSource;
        private Button btnRolKaldir;
    }
}