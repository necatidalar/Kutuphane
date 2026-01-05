namespace Kutuphane.UI
{
    partial class frmPersonelIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelIslemleri));
            groupBox1 = new GroupBox();
            comboBox_Cinsiyet = new ComboBox();
            btnTemizle = new Button();
            btnSil = new Button();
            btnDuzenle = new Button();
            btnKaydet = new Button();
            textBox_Sifre = new TextBox();
            label4 = new Label();
            textBox_KullaniciAdi = new TextBox();
            label6 = new Label();
            label3 = new Label();
            textBox_Soyad = new TextBox();
            label7 = new Label();
            textBox_Ad = new TextBox();
            label2 = new Label();
            textBox_PersonelId = new TextBox();
            label1 = new Label();
            personelBilgileriDtoBindingSource = new BindingSource(components);
            textBox_Ara = new TextBox();
            label_txtAra = new Label();
            dataGrid_Personel = new DataGridView();
            personelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cinsiyetIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cinsiyetAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifMiDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSilinenleriGoster = new Button();
            btnGeriYukle = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)personelBilgileriDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Personel).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(41, 128, 185);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.MinimumSize = new Size(343, 682);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(343, 682);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "👨‍💻 Personel Kayıt İşlemleri";
            // 
            // comboBox_Cinsiyet
            // 
            comboBox_Cinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Cinsiyet.Font = new Font("Segoe UI", 10F);
            comboBox_Cinsiyet.FormattingEnabled = true;
            comboBox_Cinsiyet.Location = new Point(120, 138);
            comboBox_Cinsiyet.Margin = new Padding(3, 4, 3, 4);
            comboBox_Cinsiyet.Name = "comboBox_Cinsiyet";
            comboBox_Cinsiyet.Size = new Size(209, 31);
            comboBox_Cinsiyet.TabIndex = 4;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(149, 165, 166);
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(14, 194);
            btnTemizle.Margin = new Padding(3, 4, 3, 4);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(303, 51);
            btnTemizle.TabIndex = 10;
            btnTemizle.Text = "\U0001f9f9 Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 57, 43);
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(14, 135);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(303, 51);
            btnSil.TabIndex = 9;
            btnSil.Text = "❌ Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.FromArgb(41, 128, 185);
            btnDuzenle.FlatAppearance.BorderSize = 0;
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDuzenle.ForeColor = Color.White;
            btnDuzenle.Location = new Point(14, 76);
            btnDuzenle.Margin = new Padding(3, 4, 3, 4);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(303, 51);
            btnDuzenle.TabIndex = 8;
            btnDuzenle.Text = "✏️ Düzenle";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(39, 174, 96);
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(14, 17);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(303, 51);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "💾 KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // textBox_Sifre
            // 
            textBox_Sifre.Font = new Font("Segoe UI", 10F);
            textBox_Sifre.Location = new Point(120, 221);
            textBox_Sifre.Margin = new Padding(3, 4, 3, 4);
            textBox_Sifre.Name = "textBox_Sifre";
            textBox_Sifre.Size = new Size(209, 30);
            textBox_Sifre.TabIndex = 6;
            textBox_Sifre.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(69, 225);
            label4.Name = "label4";
            label4.Size = new Size(48, 23);
            label4.TabIndex = 0;
            label4.Text = "Şifre:";
            // 
            // textBox_KullaniciAdi
            // 
            textBox_KullaniciAdi.Font = new Font("Segoe UI", 10F);
            textBox_KullaniciAdi.Location = new Point(120, 180);
            textBox_KullaniciAdi.Margin = new Padding(3, 4, 3, 4);
            textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            textBox_KullaniciAdi.Size = new Size(209, 30);
            textBox_KullaniciAdi.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(40, 142);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 0;
            label6.Text = "Cinsiyet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(10, 184);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 0;
            label3.Text = "Kullanıcı Adı:";
            // 
            // textBox_Soyad
            // 
            textBox_Soyad.Font = new Font("Segoe UI", 10F);
            textBox_Soyad.Location = new Point(120, 97);
            textBox_Soyad.Margin = new Padding(3, 4, 3, 4);
            textBox_Soyad.Name = "textBox_Soyad";
            textBox_Soyad.Size = new Size(209, 30);
            textBox_Soyad.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(55, 101);
            label7.Name = "label7";
            label7.Size = new Size(61, 23);
            label7.TabIndex = 0;
            label7.Text = "Soyad:";
            // 
            // textBox_Ad
            // 
            textBox_Ad.Font = new Font("Segoe UI", 10F);
            textBox_Ad.Location = new Point(120, 56);
            textBox_Ad.Margin = new Padding(3, 4, 3, 4);
            textBox_Ad.Name = "textBox_Ad";
            textBox_Ad.Size = new Size(209, 30);
            textBox_Ad.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(79, 60);
            label2.Name = "label2";
            label2.Size = new Size(35, 23);
            label2.TabIndex = 0;
            label2.Text = "Ad:";
            // 
            // textBox_PersonelId
            // 
            textBox_PersonelId.Enabled = false;
            textBox_PersonelId.Font = new Font("Segoe UI", 10F);
            textBox_PersonelId.Location = new Point(120, 14);
            textBox_PersonelId.Margin = new Padding(3, 4, 3, 4);
            textBox_PersonelId.Name = "textBox_PersonelId";
            textBox_PersonelId.Size = new Size(209, 30);
            textBox_PersonelId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(15, 18);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 0;
            label1.Text = "Personel Id:";
            // 
            // personelBilgileriDtoBindingSource
            // 
            personelBilgileriDtoBindingSource.DataSource = typeof(Model.DTO.PersonelBilgileriDto);
            // 
            // textBox_Ara
            // 
            textBox_Ara.Font = new Font("Segoe UI", 10F);
            textBox_Ara.Location = new Point(430, 18);
            textBox_Ara.Margin = new Padding(3, 4, 3, 4);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Ad veya Soyad ile arayın";
            textBox_Ara.Size = new Size(315, 30);
            textBox_Ara.TabIndex = 13;
            textBox_Ara.TextChanged += textBox_Ara_TextChanged;
            // 
            // label_txtAra
            // 
            label_txtAra.AutoSize = true;
            label_txtAra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label_txtAra.ForeColor = Color.FromArgb(64, 64, 64);
            label_txtAra.Location = new Point(364, 22);
            label_txtAra.Name = "label_txtAra";
            label_txtAra.Size = new Size(64, 23);
            label_txtAra.TabIndex = 21;
            label_txtAra.Text = "Arama:";
            // 
            // dataGrid_Personel
            // 
            dataGrid_Personel.AutoGenerateColumns = false;
            dataGrid_Personel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Personel.Columns.AddRange(new DataGridViewColumn[] { personelIdDataGridViewTextBoxColumn, adDataGridViewTextBoxColumn, soyadDataGridViewTextBoxColumn, cinsiyetIdDataGridViewTextBoxColumn, cinsiyetAdiDataGridViewTextBoxColumn, aktifMiDataGridViewCheckBoxColumn });
            dataGrid_Personel.DataSource = personelBilgileriDtoBindingSource;
            dataGrid_Personel.Location = new Point(363, 56);
            dataGrid_Personel.Margin = new Padding(3, 4, 3, 4);
            dataGrid_Personel.Name = "dataGrid_Personel";
            dataGrid_Personel.RowHeadersWidth = 51;
            dataGrid_Personel.Size = new Size(845, 744);
            dataGrid_Personel.TabIndex = 22;
            dataGrid_Personel.CellFormatting += dataGrid_Personel_CellFormatting;
            dataGrid_Personel.ColumnHeaderMouseClick += dataGrid_Personel_ColumnHeaderMouseClick;
            dataGrid_Personel.SelectionChanged += dataGrid_Personel_SelectionChanged;
            // 
            // personelIdDataGridViewTextBoxColumn
            // 
            personelIdDataGridViewTextBoxColumn.DataPropertyName = "PersonelId";
            personelIdDataGridViewTextBoxColumn.HeaderText = "PersonelId";
            personelIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            personelIdDataGridViewTextBoxColumn.Name = "personelIdDataGridViewTextBoxColumn";
            personelIdDataGridViewTextBoxColumn.Visible = false;
            personelIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            adDataGridViewTextBoxColumn.HeaderText = "Adı";
            adDataGridViewTextBoxColumn.MinimumWidth = 6;
            adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            soyadDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // cinsiyetIdDataGridViewTextBoxColumn
            // 
            cinsiyetIdDataGridViewTextBoxColumn.DataPropertyName = "CinsiyetId";
            cinsiyetIdDataGridViewTextBoxColumn.HeaderText = "CinsiyetId";
            cinsiyetIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            cinsiyetIdDataGridViewTextBoxColumn.Name = "cinsiyetIdDataGridViewTextBoxColumn";
            cinsiyetIdDataGridViewTextBoxColumn.Visible = false;
            cinsiyetIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // cinsiyetAdiDataGridViewTextBoxColumn
            // 
            cinsiyetAdiDataGridViewTextBoxColumn.DataPropertyName = "CinsiyetAdi";
            cinsiyetAdiDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            cinsiyetAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            cinsiyetAdiDataGridViewTextBoxColumn.Name = "cinsiyetAdiDataGridViewTextBoxColumn";
            cinsiyetAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // aktifMiDataGridViewCheckBoxColumn
            // 
            aktifMiDataGridViewCheckBoxColumn.DataPropertyName = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.HeaderText = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.MinimumWidth = 6;
            aktifMiDataGridViewCheckBoxColumn.Name = "aktifMiDataGridViewCheckBoxColumn";
            aktifMiDataGridViewCheckBoxColumn.Visible = false;
            aktifMiDataGridViewCheckBoxColumn.Width = 125;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox_PersonelId);
            panel1.Controls.Add(comboBox_Cinsiyet);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_Ad);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox_Soyad);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox_Sifre);
            panel1.Controls.Add(textBox_KullaniciAdi);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 268);
            panel1.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnKaydet);
            flowLayoutPanel1.Controls.Add(btnDuzenle);
            flowLayoutPanel1.Controls.Add(btnSil);
            flowLayoutPanel1.Controls.Add(btnTemizle);
            flowLayoutPanel1.Controls.Add(btnSilinenleriGoster);
            flowLayoutPanel1.Controls.Add(btnGeriYukle);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 297);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(11, 13, 11, 13);
            flowLayoutPanel1.Size = new Size(337, 381);
            flowLayoutPanel1.TabIndex = 14;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.BackColor = Color.FromArgb(236, 240, 241);
            btnSilinenleriGoster.Cursor = Cursors.Hand;
            btnSilinenleriGoster.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnSilinenleriGoster.FlatStyle = FlatStyle.Flat;
            btnSilinenleriGoster.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSilinenleriGoster.ForeColor = Color.FromArgb(41, 128, 185);
            btnSilinenleriGoster.Location = new Point(14, 253);
            btnSilinenleriGoster.Margin = new Padding(3, 4, 3, 4);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(303, 51);
            btnSilinenleriGoster.TabIndex = 23;
            btnSilinenleriGoster.Text = "🗑️ Silinen Personelli Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.BackColor = Color.FromArgb(52, 73, 94);
            btnGeriYukle.Cursor = Cursors.Hand;
            btnGeriYukle.FlatAppearance.BorderSize = 0;
            btnGeriYukle.FlatStyle = FlatStyle.Flat;
            btnGeriYukle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGeriYukle.ForeColor = Color.White;
            btnGeriYukle.Location = new Point(14, 312);
            btnGeriYukle.Margin = new Padding(3, 4, 3, 4);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(303, 51);
            btnGeriYukle.TabIndex = 24;
            btnGeriYukle.Text = "↩️ Seçili Personeli Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = false;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // frmPersonelIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1222, 816);
            Controls.Add(dataGrid_Personel);
            Controls.Add(label_txtAra);
            Controls.Add(textBox_Ara);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(883, 651);
            Name = "frmPersonelIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Personel İşlemleri";
            Load += frmPersonelIslemleri_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)personelBilgileriDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Personel).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox_PersonelId;
        private Label label1;
        private TextBox textBox_Sifre;
        private Label label4;
        private TextBox textBox_KullaniciAdi;
        private Label label3;
        private TextBox textBox_Ad;
        private Label label2;
        private Button btnTemizle;
        private Button btnSil;
        private Button btnDuzenle;
        private Button btnKaydet;
        private TextBox textBox_Ara;
        private DataGridViewTextBoxColumn teslimEdilenlerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn terslimAlinanlarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private TextBox textBox_Soyad;
        private Label label7;
        private ComboBox comboBox_Cinsiyet;
        private Label label6;
        private DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private BindingSource personelBilgileriDtoBindingSource;
        private Label label_txtAra;
        private DataGridView dataGrid_Personel;
        private DataGridViewTextBoxColumn personelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinsiyetIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinsiyetAdiDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSilinenleriGoster;
        private Button btnGeriYukle;
    }
}