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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelIslemleri));
            groupBox1 = new GroupBox();
            comboBox_Cinsiyet = new ComboBox();
            btnGeriYukle = new Button();
            btnSilinenleriGoster = new Button();
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
            dataGrid_Personel = new DataGridView();
            personelBilgileriDtoBindingSource = new BindingSource(components);
            btnAra = new Button();
            label5 = new Label();
            textBox_Ara = new TextBox();
            personelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cinsiyetIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cinsiyetAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifMiDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Personel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personelBilgileriDtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox_Cinsiyet);
            groupBox1.Controls.Add(btnGeriYukle);
            groupBox1.Controls.Add(btnSilinenleriGoster);
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnDuzenle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(textBox_Sifre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox_KullaniciAdi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox_Soyad);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox_Ad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_PersonelId);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 588);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "👨‍💻 Personel Kayıt ve Güncelleme";
            // 
            // comboBox_Cinsiyet
            // 
            comboBox_Cinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Cinsiyet.Font = new Font("Segoe UI", 10F);
            comboBox_Cinsiyet.FormattingEnabled = true;
            comboBox_Cinsiyet.Location = new Point(119, 124);
            comboBox_Cinsiyet.Name = "comboBox_Cinsiyet";
            comboBox_Cinsiyet.Size = new Size(183, 25);
            comboBox_Cinsiyet.TabIndex = 4;
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.BackColor = Color.FromArgb(39, 174, 96);
            btnGeriYukle.FlatAppearance.BorderSize = 0;
            btnGeriYukle.FlatStyle = FlatStyle.Flat;
            btnGeriYukle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGeriYukle.ForeColor = Color.White;
            btnGeriYukle.Location = new Point(133, 425);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(154, 35);
            btnGeriYukle.TabIndex = 12;
            btnGeriYukle.Text = "♻️ Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = false;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.BackColor = Color.FromArgb(52, 73, 94);
            btnSilinenleriGoster.FlatAppearance.BorderSize = 0;
            btnSilinenleriGoster.FlatStyle = FlatStyle.Flat;
            btnSilinenleriGoster.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSilinenleriGoster.ForeColor = Color.White;
            btnSilinenleriGoster.Location = new Point(133, 384);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(154, 35);
            btnSilinenleriGoster.TabIndex = 11;
            btnSilinenleriGoster.Text = "🗑️ Silinenleri Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(149, 165, 166);
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(133, 343);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(154, 35);
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
            btnSil.Location = new Point(133, 302);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(154, 35);
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
            btnDuzenle.Location = new Point(133, 261);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(154, 35);
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
            btnKaydet.Location = new Point(133, 220);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(154, 35);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "➕ Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // textBox_Sifre
            // 
            textBox_Sifre.Font = new Font("Segoe UI", 10F);
            textBox_Sifre.Location = new Point(119, 186);
            textBox_Sifre.Name = "textBox_Sifre";
            textBox_Sifre.Size = new Size(183, 25);
            textBox_Sifre.TabIndex = 6;
            textBox_Sifre.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(74, 189);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 0;
            label4.Text = "Şifre:";
            // 
            // textBox_KullaniciAdi
            // 
            textBox_KullaniciAdi.Font = new Font("Segoe UI", 10F);
            textBox_KullaniciAdi.Location = new Point(119, 155);
            textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            textBox_KullaniciAdi.Size = new Size(183, 25);
            textBox_KullaniciAdi.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(49, 127);
            label6.Name = "label6";
            label6.Size = new Size(62, 19);
            label6.TabIndex = 0;
            label6.Text = "Cinsiyet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(23, 158);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 0;
            label3.Text = "Kullanıcı Adı:";
            // 
            // textBox_Soyad
            // 
            textBox_Soyad.Font = new Font("Segoe UI", 10F);
            textBox_Soyad.Location = new Point(119, 93);
            textBox_Soyad.Name = "textBox_Soyad";
            textBox_Soyad.Size = new Size(183, 25);
            textBox_Soyad.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(62, 96);
            label7.Name = "label7";
            label7.Size = new Size(50, 19);
            label7.TabIndex = 0;
            label7.Text = "Soyad:";
            // 
            // textBox_Ad
            // 
            textBox_Ad.Font = new Font("Segoe UI", 10F);
            textBox_Ad.Location = new Point(119, 62);
            textBox_Ad.Name = "textBox_Ad";
            textBox_Ad.Size = new Size(183, 25);
            textBox_Ad.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(83, 65);
            label2.Name = "label2";
            label2.Size = new Size(29, 19);
            label2.TabIndex = 0;
            label2.Text = "Ad:";
            // 
            // textBox_PersonelId
            // 
            textBox_PersonelId.Enabled = false;
            textBox_PersonelId.Font = new Font("Segoe UI", 10F);
            textBox_PersonelId.Location = new Point(119, 31);
            textBox_PersonelId.Name = "textBox_PersonelId";
            textBox_PersonelId.Size = new Size(183, 25);
            textBox_PersonelId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(27, 34);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 0;
            label1.Text = "Personel Id:";
            // 
            // dataGrid_Personel
            // 
            dataGrid_Personel.AllowUserToDeleteRows = false;
            dataGrid_Personel.AllowUserToOrderColumns = true;
            dataGrid_Personel.AllowUserToResizeRows = false;
            dataGrid_Personel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGrid_Personel.AutoGenerateColumns = false;
            dataGrid_Personel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Personel.BackgroundColor = Color.White;
            dataGrid_Personel.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid_Personel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Personel.ColumnHeadersHeight = 30;
            dataGrid_Personel.Columns.AddRange(new DataGridViewColumn[] { personelIdDataGridViewTextBoxColumn, adDataGridViewTextBoxColumn, soyadDataGridViewTextBoxColumn, cinsiyetIdDataGridViewTextBoxColumn, cinsiyetAdiDataGridViewTextBoxColumn, aktifMiDataGridViewCheckBoxColumn });
            dataGrid_Personel.DataSource = personelBilgileriDtoBindingSource;
            dataGrid_Personel.EnableHeadersVisualStyles = false;
            dataGrid_Personel.GridColor = Color.LightGray;
            dataGrid_Personel.Location = new Point(346, 42);
            dataGrid_Personel.MultiSelect = false;
            dataGrid_Personel.Name = "dataGrid_Personel";
            dataGrid_Personel.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(170, 204, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGrid_Personel.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGrid_Personel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Personel.Size = new Size(711, 558);
            dataGrid_Personel.TabIndex = 1;
            dataGrid_Personel.CellFormatting += dataGrid_Personel_CellFormatting;
            dataGrid_Personel.SelectionChanged += dataGrid_Personel_SelectionChanged;
            // 
            // personelBilgileriDtoBindingSource
            // 
            personelBilgileriDtoBindingSource.DataSource = typeof(Model.DTO.PersonelBilgileriDto);
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.FromArgb(41, 128, 185);
            btnAra.FlatAppearance.BorderSize = 0;
            btnAra.FlatStyle = FlatStyle.Flat;
            btnAra.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAra.ForeColor = Color.White;
            btnAra.Location = new Point(982, 11);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 25);
            btnAra.TabIndex = 14;
            btnAra.Text = "🔍 ARA";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(661, 15);
            label5.Name = "label5";
            label5.Size = new Size(33, 19);
            label5.TabIndex = 0;
            label5.Text = "Ara:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Font = new Font("Segoe UI", 10F);
            textBox_Ara.Location = new Point(700, 12);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Ad, Soyad veya Kullanıcı Adı ile arayın";
            textBox_Ara.Size = new Size(276, 25);
            textBox_Ara.TabIndex = 13;
            // 
            // personelIdDataGridViewTextBoxColumn
            // 
            personelIdDataGridViewTextBoxColumn.DataPropertyName = "PersonelId";
            personelIdDataGridViewTextBoxColumn.HeaderText = "PersonelId";
            personelIdDataGridViewTextBoxColumn.Name = "personelIdDataGridViewTextBoxColumn";
            personelIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // adDataGridViewTextBoxColumn
            // 
            adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            adDataGridViewTextBoxColumn.HeaderText = "Adı";
            adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            soyadDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // cinsiyetIdDataGridViewTextBoxColumn
            // 
            cinsiyetIdDataGridViewTextBoxColumn.DataPropertyName = "CinsiyetId";
            cinsiyetIdDataGridViewTextBoxColumn.HeaderText = "CinsiyetId";
            cinsiyetIdDataGridViewTextBoxColumn.Name = "cinsiyetIdDataGridViewTextBoxColumn";
            cinsiyetIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // cinsiyetAdiDataGridViewTextBoxColumn
            // 
            cinsiyetAdiDataGridViewTextBoxColumn.DataPropertyName = "CinsiyetAdi";
            cinsiyetAdiDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            cinsiyetAdiDataGridViewTextBoxColumn.Name = "cinsiyetAdiDataGridViewTextBoxColumn";
            // 
            // aktifMiDataGridViewCheckBoxColumn
            // 
            aktifMiDataGridViewCheckBoxColumn.DataPropertyName = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.HeaderText = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.Name = "aktifMiDataGridViewCheckBoxColumn";
            aktifMiDataGridViewCheckBoxColumn.Visible = false;
            // 
            // frmPersonelIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1069, 612);
            Controls.Add(btnAra);
            Controls.Add(label5);
            Controls.Add(textBox_Ara);
            Controls.Add(dataGrid_Personel);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(775, 500);
            Name = "frmPersonelIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Personel İşlemleri";
            Load += frmPersonelIslemleri_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Personel).EndInit();
            ((System.ComponentModel.ISupportInitialize)personelBilgileriDtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox_PersonelId;
        private Label label1;
        private DataGridView dataGrid_Personel;
        private TextBox textBox_Sifre;
        private Label label4;
        private TextBox textBox_KullaniciAdi;
        private Label label3;
        private TextBox textBox_Ad;
        private Label label2;
        private Button btnGeriYukle;
        private Button btnSilinenleriGoster;
        private Button btnTemizle;
        private Button btnSil;
        private Button btnDuzenle;
        private Button btnKaydet;
        private Button btnAra;
        private Label label5;
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
        private DataGridViewTextBoxColumn personelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinsiyetIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinsiyetAdiDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
    }
}