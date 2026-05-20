namespace Kutuphane.UI
{
    partial class frmUyeIslemleri
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUyeIslemleri));
            groupBox1 = new GroupBox();
            formLayout = new TableLayoutPanel();
            label2 = new Label();
            textBox_UyeId = new TextBox();
            labelOkulNo = new Label();
            textBox_OkulNo = new TextBox();
            labelSinif = new Label();
            textBox_Sinif = new TextBox();
            labelSube = new Label();
            textBox_Sube = new TextBox();
            label8 = new Label();
            textBox_TcPass = new TextBox();
            label3 = new Label();
            textBox_Ad = new TextBox();
            label4 = new Label();
            textBox_Soyad = new TextBox();
            label5 = new Label();
            comboBox_Cinsiyet = new ComboBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            textBox_Telefon = new TextBox();
            label9 = new Label();
            textBox_Eposta = new TextBox();
            labelVeliAdSoyad = new Label();
            textBox_VeliAdSoyad = new TextBox();
            labelVeliTelefon = new Label();
            textBox_VeliTelefon = new TextBox();
            label10 = new Label();
            textBox_Adres = new TextBox();
            label11 = new Label();
            richTextBox_AdresDetay = new RichTextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnKaydet = new Button();
            btnDuzenle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            btnSilinenleriGoster = new Button();
            btnGeriYukle = new Button();
            panelTop = new Panel();
            label_txtAra = new Label();
            textBox_Ara = new TextBox();
            comboBox_Filtre = new ComboBox();
            dataGrid_Uye = new DataGridView();
            uyeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            okulNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sinifDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            epostaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            veliAdSoyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            veliTelefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cinsiyetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dogumTarihiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresDetayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tcPassDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cinsiyetIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifMiDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            uyeDtoBindingSource = new BindingSource(components);
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            formLayout.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Uye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uyeDtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(formLayout);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(12);
            groupBox1.Size = new Size(1320, 315);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "🎓 Öğrenci Bilgileri";
            // 
            // formLayout
            // 
            formLayout.ColumnCount = 8;
            formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            formLayout.Controls.Add(label2, 0, 0);
            formLayout.Controls.Add(textBox_UyeId, 1, 0);
            formLayout.Controls.Add(labelOkulNo, 2, 0);
            formLayout.Controls.Add(textBox_OkulNo, 3, 0);
            formLayout.Controls.Add(labelSinif, 4, 0);
            formLayout.Controls.Add(textBox_Sinif, 5, 0);
            formLayout.Controls.Add(labelSube, 6, 0);
            formLayout.Controls.Add(textBox_Sube, 7, 0);
            formLayout.Controls.Add(label8, 0, 1);
            formLayout.Controls.Add(textBox_TcPass, 1, 1);
            formLayout.Controls.Add(label3, 2, 1);
            formLayout.Controls.Add(textBox_Ad, 3, 1);
            formLayout.Controls.Add(label4, 4, 1);
            formLayout.Controls.Add(textBox_Soyad, 5, 1);
            formLayout.Controls.Add(label5, 6, 1);
            formLayout.Controls.Add(comboBox_Cinsiyet, 7, 1);
            formLayout.Controls.Add(label6, 0, 2);
            formLayout.Controls.Add(dateTimePicker1, 1, 2);
            formLayout.Controls.Add(label7, 2, 2);
            formLayout.Controls.Add(textBox_Telefon, 3, 2);
            formLayout.Controls.Add(label9, 4, 2);
            formLayout.Controls.Add(textBox_Eposta, 5, 2);
            formLayout.Controls.Add(labelVeliAdSoyad, 6, 2);
            formLayout.Controls.Add(textBox_VeliAdSoyad, 7, 2);
            formLayout.Controls.Add(labelVeliTelefon, 0, 3);
            formLayout.Controls.Add(textBox_VeliTelefon, 1, 3);
            formLayout.Controls.Add(label10, 2, 3);
            formLayout.Controls.Add(textBox_Adres, 3, 3);
            formLayout.Controls.Add(label11, 4, 3);
            formLayout.Controls.Add(richTextBox_AdresDetay, 5, 3);
            formLayout.Controls.Add(flowLayoutPanel1, 0, 4);
            formLayout.Dock = DockStyle.Fill;
            formLayout.Location = new Point(12, 30);
            formLayout.Name = "formLayout";
            formLayout.RowCount = 5;
            formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            formLayout.Size = new Size(1296, 273);
            formLayout.TabIndex = 0;
            // common label settings
            label2.Text = "Kayıt Id";
            labelOkulNo.Text = "Okul No *";
            labelSinif.Text = "Sınıf *";
            labelSube.Text = "Şube *";
            label8.Text = "TC/Pass";
            label3.Text = "Ad *";
            label4.Text = "Soyad *";
            label5.Text = "Cinsiyet *";
            label6.Text = "Doğum Tarihi";
            label7.Text = "Telefon *";
            label9.Text = "E-posta *";
            labelVeliAdSoyad.Text = "Veli *";
            labelVeliTelefon.Text = "Veli Tel *";
            label10.Text = "Adres *";
            label11.Text = "Adres Detay *";
            foreach (Control c in new Control[] { label2, labelOkulNo, labelSinif, labelSube, label8, label3, label4, label5, label6, label7, label9, labelVeliAdSoyad, labelVeliTelefon, label10, label11 })
            {
                c.Anchor = AnchorStyles.Left;
                c.AutoSize = true;
                c.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                c.ForeColor = Color.FromArgb(52, 73, 94);
            }
            textBox_UyeId.ReadOnly = true;
            textBox_UyeId.BackColor = Color.Gainsboro;
            textBox_TcPass.PlaceholderText = "Boşsa okul no kullanılır";
            textBox_OkulNo.PlaceholderText = "Örn: 1345";
            textBox_Sinif.PlaceholderText = "Örn: 12";
            textBox_Sube.PlaceholderText = "Örn: C";
            textBox_Telefon.PlaceholderText = "05XXXXXXXXX";
            textBox_Eposta.PlaceholderText = "ogrenci@okul.com";
            textBox_VeliAdSoyad.PlaceholderText = "Veli adı soyadı";
            textBox_VeliTelefon.PlaceholderText = "05XXXXXXXXX";
            textBox_Adres.PlaceholderText = "Mahalle / ilçe / il";
            foreach (Control c in new Control[] { textBox_UyeId, textBox_OkulNo, textBox_Sinif, textBox_Sube, textBox_TcPass, textBox_Ad, textBox_Soyad, comboBox_Cinsiyet, dateTimePicker1, textBox_Telefon, textBox_Eposta, textBox_VeliAdSoyad, textBox_VeliTelefon, textBox_Adres })
            {
                c.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                c.Font = new Font("Segoe UI", 10F);
                c.Margin = new Padding(3, 5, 10, 5);
            }
            textBox_Sube.CharacterCasing = CharacterCasing.Upper;
            comboBox_Cinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            formLayout.SetColumnSpan(textBox_Adres, 1);
            richTextBox_AdresDetay.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            richTextBox_AdresDetay.Font = new Font("Segoe UI", 10F);
            formLayout.SetColumnSpan(richTextBox_AdresDetay, 3);
            // 
            // flowLayoutPanel1
            // 
            formLayout.SetColumnSpan(flowLayoutPanel1, 8);
            flowLayoutPanel1.Controls.Add(btnKaydet);
            flowLayoutPanel1.Controls.Add(btnDuzenle);
            flowLayoutPanel1.Controls.Add(btnSil);
            flowLayoutPanel1.Controls.Add(btnTemizle);
            flowLayoutPanel1.Controls.Add(btnSilinenleriGoster);
            flowLayoutPanel1.Controls.Add(btnGeriYukle);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.Location = new Point(3, 223);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1290, 47);
            flowLayoutPanel1.TabIndex = 30;
            // 
            // buttons
            // 
            ConfigureButton(btnKaydet, "💾 Kaydet", Color.FromArgb(39, 174, 96));
            ConfigureButton(btnDuzenle, "✏️ Güncelle", Color.FromArgb(41, 128, 185));
            ConfigureButton(btnSil, "🗑️ Pasif Et", Color.FromArgb(192, 57, 43));
            ConfigureButton(btnTemizle, "🧹 Temizle", Color.FromArgb(127, 140, 141));
            ConfigureButton(btnSilinenleriGoster, "🗑️ Pasif Öğrencileri Göster", Color.FromArgb(243, 156, 18));
            ConfigureButton(btnGeriYukle, "↩️ Geri Yükle", Color.FromArgb(22, 160, 133));
            btnKaydet.Click += btnKaydet_Click;
            btnDuzenle.Click += btnDuzenle_Click;
            btnSil.Click += btnSil_Click;
            btnTemizle.Click += btnTemizle_Click;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(comboBox_Filtre);
            panelTop.Controls.Add(textBox_Ara);
            panelTop.Controls.Add(label_txtAra);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 315);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(12, 8, 12, 8);
            panelTop.Size = new Size(1320, 56);
            panelTop.TabIndex = 1;
            // 
            // label_txtAra
            // 
            label_txtAra.AutoSize = true;
            label_txtAra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label_txtAra.Location = new Point(14, 18);
            label_txtAra.Name = "label_txtAra";
            label_txtAra.Size = new Size(132, 19);
            label_txtAra.TabIndex = 0;
            label_txtAra.Text = "Öğrenci ara:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_Ara.Font = new Font("Segoe UI", 10F);
            textBox_Ara.Location = new Point(145, 14);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Okul no, ad, soyad, sınıf, şube, veli veya telefon ile ara";
            textBox_Ara.Size = new Size(930, 25);
            textBox_Ara.TabIndex = 1;
            textBox_Ara.TextChanged += textBox_Ara_TextChanged;
            // 
            // comboBox_Filtre
            // 
            comboBox_Filtre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox_Filtre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Filtre.Font = new Font("Segoe UI", 10F);
            comboBox_Filtre.Location = new Point(1090, 13);
            comboBox_Filtre.Name = "comboBox_Filtre";
            comboBox_Filtre.Size = new Size(216, 25);
            comboBox_Filtre.TabIndex = 2;
            comboBox_Filtre.SelectedIndexChanged += comboBox_Filtre_SelectedIndexChanged;
            // 
            // dataGrid_Uye
            // 
            dataGrid_Uye.AllowUserToAddRows = false;
            dataGrid_Uye.AllowUserToDeleteRows = false;
            dataGrid_Uye.AutoGenerateColumns = false;
            dataGrid_Uye.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Uye.BackgroundColor = Color.White;
            dataGrid_Uye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Uye.Columns.AddRange(new DataGridViewColumn[] { uyeIdDataGridViewTextBoxColumn, okulNoDataGridViewTextBoxColumn, sinifDataGridViewTextBoxColumn, subeDataGridViewTextBoxColumn, adDataGridViewTextBoxColumn, soyadDataGridViewTextBoxColumn, telefonDataGridViewTextBoxColumn, epostaDataGridViewTextBoxColumn, veliAdSoyadDataGridViewTextBoxColumn, veliTelefonDataGridViewTextBoxColumn, cinsiyetDataGridViewTextBoxColumn, dogumTarihiDataGridViewTextBoxColumn, adresDataGridViewTextBoxColumn, adresDetayDataGridViewTextBoxColumn, tcPassDataGridViewTextBoxColumn, cinsiyetIdDataGridViewTextBoxColumn, aktifMiDataGridViewCheckBoxColumn });
            dataGrid_Uye.DataSource = uyeDtoBindingSource;
            dataGrid_Uye.Dock = DockStyle.Fill;
            dataGrid_Uye.Location = new Point(0, 371);
            dataGrid_Uye.MultiSelect = false;
            dataGrid_Uye.Name = "dataGrid_Uye";
            dataGrid_Uye.ReadOnly = true;
            dataGrid_Uye.RowHeadersWidth = 51;
            dataGrid_Uye.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Uye.Size = new Size(1320, 399);
            dataGrid_Uye.TabIndex = 2;
            dataGrid_Uye.CellFormatting += dataGrid_Uye_CellFormatting;
            dataGrid_Uye.CellPainting += dataGrid_Uye_CellPainting;
            dataGrid_Uye.SelectionChanged += dataGrid_Uye_SelectionChanged;
            dataGrid_Uye.ColumnHeaderMouseClick += dataGrid_Uye_ColumnHeaderMouseClick;
            // columns
            uyeIdDataGridViewTextBoxColumn.DataPropertyName = "UyeId";
            uyeIdDataGridViewTextBoxColumn.HeaderText = "Id";
            uyeIdDataGridViewTextBoxColumn.Name = "uyeIdDataGridViewTextBoxColumn";
            uyeIdDataGridViewTextBoxColumn.Visible = false;
            okulNoDataGridViewTextBoxColumn.DataPropertyName = "OkulNo";
            okulNoDataGridViewTextBoxColumn.HeaderText = "Okul No";
            okulNoDataGridViewTextBoxColumn.Name = "okulNoDataGridViewTextBoxColumn";
            sinifDataGridViewTextBoxColumn.DataPropertyName = "Sinif";
            sinifDataGridViewTextBoxColumn.HeaderText = "Sınıf";
            sinifDataGridViewTextBoxColumn.Name = "sinifDataGridViewTextBoxColumn";
            subeDataGridViewTextBoxColumn.DataPropertyName = "Sube";
            subeDataGridViewTextBoxColumn.HeaderText = "Şube";
            subeDataGridViewTextBoxColumn.Name = "subeDataGridViewTextBoxColumn";
            adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            adDataGridViewTextBoxColumn.HeaderText = "Ad";
            adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            epostaDataGridViewTextBoxColumn.DataPropertyName = "Eposta";
            epostaDataGridViewTextBoxColumn.HeaderText = "E-posta";
            epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            veliAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "VeliAdSoyad";
            veliAdSoyadDataGridViewTextBoxColumn.HeaderText = "Veli";
            veliAdSoyadDataGridViewTextBoxColumn.Name = "veliAdSoyadDataGridViewTextBoxColumn";
            veliTelefonDataGridViewTextBoxColumn.DataPropertyName = "VeliTelefon";
            veliTelefonDataGridViewTextBoxColumn.HeaderText = "Veli Tel";
            veliTelefonDataGridViewTextBoxColumn.Name = "veliTelefonDataGridViewTextBoxColumn";
            cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            dogumTarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            adresDetayDataGridViewTextBoxColumn.DataPropertyName = "AdresDetay";
            adresDetayDataGridViewTextBoxColumn.HeaderText = "Adres Detay";
            adresDetayDataGridViewTextBoxColumn.Name = "adresDetayDataGridViewTextBoxColumn";
            tcPassDataGridViewTextBoxColumn.DataPropertyName = "TcPass";
            tcPassDataGridViewTextBoxColumn.HeaderText = "TC/Pass";
            tcPassDataGridViewTextBoxColumn.Name = "tcPassDataGridViewTextBoxColumn";
            tcPassDataGridViewTextBoxColumn.Visible = false;
            cinsiyetIdDataGridViewTextBoxColumn.DataPropertyName = "CinsiyetId";
            cinsiyetIdDataGridViewTextBoxColumn.HeaderText = "CinsiyetId";
            cinsiyetIdDataGridViewTextBoxColumn.Name = "cinsiyetIdDataGridViewTextBoxColumn";
            cinsiyetIdDataGridViewTextBoxColumn.Visible = false;
            aktifMiDataGridViewCheckBoxColumn.DataPropertyName = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.HeaderText = "Aktif";
            aktifMiDataGridViewCheckBoxColumn.Name = "aktifMiDataGridViewCheckBoxColumn";
            aktifMiDataGridViewCheckBoxColumn.Visible = false;
            // 
            // frmUyeIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1320, 770);
            Controls.Add(dataGrid_Uye);
            Controls.Add(panelTop);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1180, 720);
            Name = "frmUyeIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Öğrenci İşlemleri";
            Load += frmUyeIslemleri_Load;
            groupBox1.ResumeLayout(false);
            formLayout.ResumeLayout(false);
            formLayout.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Uye).EndInit();
            ((System.ComponentModel.ISupportInitialize)uyeDtoBindingSource).EndInit();
            ResumeLayout(false);
        }

        private static void ConfigureButton(Button button, string text, Color color)
        {
            button.BackColor = color;
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            button.ForeColor = Color.White;
            button.Margin = new Padding(3, 5, 8, 5);
            button.Size = new Size(160, 36);
            button.Text = text;
            button.UseVisualStyleBackColor = false;
        }

        #endregion
        private TextBox textBox_Ara;
        private GroupBox groupBox1;
        private TableLayoutPanel formLayout;
        private Label label2;
        private TextBox textBox_UyeId;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox_Soyad;
        private TextBox textBox_Ad;
        private TextBox textBox_TcPass;
        private RichTextBox richTextBox_AdresDetay;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox textBox_Adres;
        private TextBox textBox_Eposta;
        private Button btnSil;
        private Button btnDuzenle;
        private Button btnKaydet;
        private ComboBox comboBox_Cinsiyet;
        private Button btnTemizle;
        private BindingSource uyeDtoBindingSource;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox_Telefon;
        private ComboBox comboBox_Filtre;
        private Label label_txtAra;
        private DataGridView dataGrid_Uye;
        private DataGridViewTextBoxColumn uyeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn okulNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sinifDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn veliAdSoyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn veliTelefonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresDetayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tcPassDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinsiyetIdDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSilinenleriGoster;
        private Button btnGeriYukle;
        private Panel panelTop;
        private Label labelOkulNo;
        private Label labelSinif;
        private Label labelSube;
        private Label labelVeliAdSoyad;
        private Label labelVeliTelefon;
        private TextBox textBox_OkulNo;
        private TextBox textBox_Sinif;
        private TextBox textBox_Sube;
        private TextBox textBox_VeliAdSoyad;
        private TextBox textBox_VeliTelefon;
    }
}
