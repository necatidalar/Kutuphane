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
            personelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cinsiyetIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kullaniciAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sifreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            teslimEdilenlerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            terslimAlinanlarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cinsiyetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personelBindingSource = new BindingSource(components);
            btnAra = new Button();
            label5 = new Label();
            textBox_Ara = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Personel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personelBindingSource).BeginInit();
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 485);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // comboBox_Cinsiyet
            // 
            comboBox_Cinsiyet.FormattingEnabled = true;
            comboBox_Cinsiyet.Location = new Point(99, 135);
            comboBox_Cinsiyet.Name = "comboBox_Cinsiyet";
            comboBox_Cinsiyet.Size = new Size(198, 23);
            comboBox_Cinsiyet.TabIndex = 19;
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.Location = new Point(121, 399);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(154, 25);
            btnGeriYukle.TabIndex = 18;
            btnGeriYukle.Text = "Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = true;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.Location = new Point(121, 368);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(154, 25);
            btnSilinenleriGoster.TabIndex = 17;
            btnSilinenleriGoster.Text = "Silinen Personelleri Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = true;
            btnSilinenleriGoster.Visible = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(121, 337);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(154, 25);
            btnTemizle.TabIndex = 15;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(121, 306);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(154, 25);
            btnSil.TabIndex = 16;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(121, 275);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(154, 25);
            btnDuzenle.TabIndex = 14;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(121, 244);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(154, 25);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // textBox_Sifre
            // 
            textBox_Sifre.Location = new Point(99, 193);
            textBox_Sifre.Name = "textBox_Sifre";
            textBox_Sifre.Size = new Size(198, 23);
            textBox_Sifre.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 196);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 0;
            label4.Text = "Şifre:";
            // 
            // textBox_KullaniciAdi
            // 
            textBox_KullaniciAdi.Location = new Point(99, 164);
            textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            textBox_KullaniciAdi.Size = new Size(198, 23);
            textBox_KullaniciAdi.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 138);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 0;
            label6.Text = "Cinsiyet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 167);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 0;
            label3.Text = "Kullanıcı Adı:";
            // 
            // textBox_Soyad
            // 
            textBox_Soyad.Location = new Point(99, 106);
            textBox_Soyad.Name = "textBox_Soyad";
            textBox_Soyad.Size = new Size(198, 23);
            textBox_Soyad.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 109);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 0;
            label7.Text = "Soyad:";
            // 
            // textBox_Ad
            // 
            textBox_Ad.Location = new Point(99, 77);
            textBox_Ad.Name = "textBox_Ad";
            textBox_Ad.Size = new Size(198, 23);
            textBox_Ad.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 80);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 0;
            label2.Text = "Ad:";
            // 
            // textBox_PersonelId
            // 
            textBox_PersonelId.Location = new Point(99, 48);
            textBox_PersonelId.Name = "textBox_PersonelId";
            textBox_PersonelId.Size = new Size(198, 23);
            textBox_PersonelId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 51);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Personel Id:";
            // 
            // dataGrid_Personel
            // 
            dataGrid_Personel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Personel.AutoGenerateColumns = false;
            dataGrid_Personel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Personel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Personel.Columns.AddRange(new DataGridViewColumn[] { personelIdDataGridViewTextBoxColumn, adDataGridViewTextBoxColumn, soyadDataGridViewTextBoxColumn, cinsiyetIdDataGridViewTextBoxColumn, kullaniciAdiDataGridViewTextBoxColumn, sifreDataGridViewTextBoxColumn, teslimEdilenlerDataGridViewTextBoxColumn, terslimAlinanlarDataGridViewTextBoxColumn, cinsiyetDataGridViewTextBoxColumn });
            dataGrid_Personel.DataSource = personelBindingSource;
            dataGrid_Personel.Location = new Point(346, 42);
            dataGrid_Personel.Name = "dataGrid_Personel";
            dataGrid_Personel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Personel.Size = new Size(711, 558);
            dataGrid_Personel.TabIndex = 1;
            dataGrid_Personel.SelectionChanged += dataGrid_Personel_SelectionChanged;
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
            adDataGridViewTextBoxColumn.HeaderText = "Ad";
            adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // cinsiyetIdDataGridViewTextBoxColumn
            // 
            cinsiyetIdDataGridViewTextBoxColumn.DataPropertyName = "CinsiyetId";
            cinsiyetIdDataGridViewTextBoxColumn.HeaderText = "CinsiyetId";
            cinsiyetIdDataGridViewTextBoxColumn.Name = "cinsiyetIdDataGridViewTextBoxColumn";
            cinsiyetIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAdi";
            kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "KullaniciAdi";
            kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            // 
            // teslimEdilenlerDataGridViewTextBoxColumn
            // 
            teslimEdilenlerDataGridViewTextBoxColumn.DataPropertyName = "TeslimEdilenler";
            teslimEdilenlerDataGridViewTextBoxColumn.HeaderText = "TeslimEdilenler";
            teslimEdilenlerDataGridViewTextBoxColumn.Name = "teslimEdilenlerDataGridViewTextBoxColumn";
            teslimEdilenlerDataGridViewTextBoxColumn.Visible = false;
            // 
            // terslimAlinanlarDataGridViewTextBoxColumn
            // 
            terslimAlinanlarDataGridViewTextBoxColumn.DataPropertyName = "TerslimAlinanlar";
            terslimAlinanlarDataGridViewTextBoxColumn.HeaderText = "TerslimAlinanlar";
            terslimAlinanlarDataGridViewTextBoxColumn.Name = "terslimAlinanlarDataGridViewTextBoxColumn";
            terslimAlinanlarDataGridViewTextBoxColumn.Visible = false;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // personelBindingSource
            // 
            personelBindingSource.DataSource = typeof(Model.Entity.Personel);
            // 
            // btnAra
            // 
            btnAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAra.Location = new Point(982, 12);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 23);
            btnAra.TabIndex = 7;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(662, 16);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 6;
            label5.Text = "Ara:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_Ara.Location = new Point(696, 13);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "TC Kimlik No / Pasaport No / Ad Soyad ile arayın";
            textBox_Ara.Size = new Size(280, 23);
            textBox_Ara.TabIndex = 5;
            // 
            // frmPersonelIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 612);
            Controls.Add(btnAra);
            Controls.Add(label5);
            Controls.Add(textBox_Ara);
            Controls.Add(dataGrid_Personel);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPersonelIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Personel İşlemleri";
            Load += frmPersonelIslemleri_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Personel).EndInit();
            ((System.ComponentModel.ISupportInitialize)personelBindingSource).EndInit();
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
        private BindingSource personelBindingSource;
        private Button btnAra;
        private Label label5;
        private TextBox textBox_Ara;
        private DataGridViewTextBoxColumn personelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinsiyetIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teslimEdilenlerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn terslimAlinanlarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private ComboBox comboBox_Cinsiyet;
        private Label label6;
        private TextBox textBox_Soyad;
        private Label label7;
    }
}