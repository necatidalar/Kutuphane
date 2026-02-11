using System.Globalization;

namespace Kutuphane.UI
{
    partial class frmUyeIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUyeIslemleri));
            uyeDtoBindingSource = new BindingSource(components);
            textBox_Ara = new TextBox();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnKaydet = new Button();
            btnDuzenle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            btnSilinenleriGoster = new Button();
            btnGeriYukle = new Button();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            textBox_UyeId = new TextBox();
            textBox_TcPass = new TextBox();
            textBox_Ad = new TextBox();
            comboBox_Cinsiyet = new ComboBox();
            textBox_Soyad = new TextBox();
            textBox_Telefon = new TextBox();
            textBox_Eposta = new TextBox();
            textBox_Adres = new TextBox();
            label2 = new Label();
            richTextBox_AdresDetay = new RichTextBox();
            label3 = new Label();
            label11 = new Label();
            label4 = new Label();
            label10 = new Label();
            label5 = new Label();
            label9 = new Label();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            comboBox_Filtre = new ComboBox();
            label_txtAra = new Label();
            dataGrid_Uye = new DataGridView();
            uyeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tcPassDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cinsiyetIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cinsiyetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dogumTarihiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            epostaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresDetayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifMiDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)uyeDtoBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Uye).BeginInit();
            SuspendLayout();
            // 
            // uyeDtoBindingSource
            // 
            uyeDtoBindingSource.DataSource = typeof(Model.DTO.UyeDto);
            // 
            // textBox_Ara
            // 
            textBox_Ara.Font = new Font("Segoe UI", 10F);
            textBox_Ara.Location = new Point(392, 12);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Arama metni giriniz";
            textBox_Ara.Size = new Size(280, 25);
            textBox_Ara.TabIndex = 17;
            textBox_Ara.TextChanged += textBox_Ara_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(41, 128, 185);
            groupBox1.Location = new Point(12, 12);
            groupBox1.MinimumSize = new Size(300, 652);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 652);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "👤 Üye Kayıt İşlemleri";
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
            flowLayoutPanel1.Location = new Point(3, 362);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 10, 10, 10);
            flowLayoutPanel1.Size = new Size(314, 287);
            flowLayoutPanel1.TabIndex = 26;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(39, 174, 96);
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(23, 13);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(265, 38);
            btnKaydet.TabIndex = 11;
            btnKaydet.Text = "💾 KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.FromArgb(41, 128, 185);
            btnDuzenle.FlatAppearance.BorderSize = 0;
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDuzenle.ForeColor = Color.White;
            btnDuzenle.Location = new Point(23, 57);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(265, 38);
            btnDuzenle.TabIndex = 12;
            btnDuzenle.Text = "✏️ Düzenle";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 57, 43);
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(23, 101);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(265, 38);
            btnSil.TabIndex = 13;
            btnSil.Text = "❌ Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(149, 165, 166);
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(23, 145);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(265, 38);
            btnTemizle.TabIndex = 14;
            btnTemizle.Text = "\U0001f9f9 Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.BackColor = Color.FromArgb(236, 240, 241);
            btnSilinenleriGoster.Cursor = Cursors.Hand;
            btnSilinenleriGoster.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnSilinenleriGoster.FlatStyle = FlatStyle.Flat;
            btnSilinenleriGoster.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSilinenleriGoster.ForeColor = Color.FromArgb(41, 128, 185);
            btnSilinenleriGoster.Location = new Point(23, 189);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(265, 38);
            btnSilinenleriGoster.TabIndex = 15;
            btnSilinenleriGoster.Text = "🗑️ Silinen Üyeleri Göster";
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
            btnGeriYukle.Location = new Point(23, 233);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(265, 38);
            btnGeriYukle.TabIndex = 16;
            btnGeriYukle.Text = "↩️ Seçili Üyeyi Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = false;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox_UyeId);
            panel1.Controls.Add(textBox_TcPass);
            panel1.Controls.Add(textBox_Ad);
            panel1.Controls.Add(comboBox_Cinsiyet);
            panel1.Controls.Add(textBox_Soyad);
            panel1.Controls.Add(textBox_Telefon);
            panel1.Controls.Add(textBox_Eposta);
            panel1.Controls.Add(textBox_Adres);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(richTextBox_AdresDetay);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 23);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 339);
            panel1.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Location = new Point(101, 157);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(201, 25);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox_UyeId
            // 
            textBox_UyeId.Enabled = false;
            textBox_UyeId.Font = new Font("Segoe UI", 10F);
            textBox_UyeId.Location = new Point(101, 11);
            textBox_UyeId.Name = "textBox_UyeId";
            textBox_UyeId.Size = new Size(201, 25);
            textBox_UyeId.TabIndex = 1;
            // 
            // textBox_TcPass
            // 
            textBox_TcPass.Font = new Font("Segoe UI", 10F);
            textBox_TcPass.Location = new Point(101, 40);
            textBox_TcPass.Name = "textBox_TcPass";
            textBox_TcPass.Size = new Size(201, 25);
            textBox_TcPass.TabIndex = 2;
            // 
            // textBox_Ad
            // 
            textBox_Ad.Font = new Font("Segoe UI", 10F);
            textBox_Ad.Location = new Point(101, 70);
            textBox_Ad.Name = "textBox_Ad";
            textBox_Ad.Size = new Size(201, 25);
            textBox_Ad.TabIndex = 3;
            // 
            // comboBox_Cinsiyet
            // 
            comboBox_Cinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Cinsiyet.Font = new Font("Segoe UI", 10F);
            comboBox_Cinsiyet.FormattingEnabled = true;
            comboBox_Cinsiyet.Location = new Point(101, 128);
            comboBox_Cinsiyet.Name = "comboBox_Cinsiyet";
            comboBox_Cinsiyet.Size = new Size(201, 25);
            comboBox_Cinsiyet.TabIndex = 5;
            // 
            // textBox_Soyad
            // 
            textBox_Soyad.Font = new Font("Segoe UI", 10F);
            textBox_Soyad.Location = new Point(101, 98);
            textBox_Soyad.Name = "textBox_Soyad";
            textBox_Soyad.Size = new Size(201, 25);
            textBox_Soyad.TabIndex = 4;
            // 
            // textBox_Telefon
            // 
            textBox_Telefon.Font = new Font("Segoe UI", 10F);
            textBox_Telefon.Location = new Point(101, 187);
            textBox_Telefon.Name = "textBox_Telefon";
            textBox_Telefon.Size = new Size(201, 25);
            textBox_Telefon.TabIndex = 7;
            // 
            // textBox_Eposta
            // 
            textBox_Eposta.Font = new Font("Segoe UI", 10F);
            textBox_Eposta.Location = new Point(101, 215);
            textBox_Eposta.Name = "textBox_Eposta";
            textBox_Eposta.Size = new Size(201, 25);
            textBox_Eposta.TabIndex = 8;
            // 
            // textBox_Adres
            // 
            textBox_Adres.Font = new Font("Segoe UI", 10F);
            textBox_Adres.Location = new Point(101, 244);
            textBox_Adres.Name = "textBox_Adres";
            textBox_Adres.Size = new Size(201, 25);
            textBox_Adres.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(45, 14);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 1;
            label2.Text = "Üye Id:";
            // 
            // richTextBox_AdresDetay
            // 
            richTextBox_AdresDetay.Font = new Font("Segoe UI", 10F);
            richTextBox_AdresDetay.Location = new Point(101, 275);
            richTextBox_AdresDetay.Name = "richTextBox_AdresDetay";
            richTextBox_AdresDetay.Size = new Size(201, 53);
            richTextBox_AdresDetay.TabIndex = 10;
            richTextBox_AdresDetay.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(21, 44);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 1;
            label3.Text = "TC/Pas No:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(9, 278);
            label11.Name = "label11";
            label11.Size = new Size(87, 19);
            label11.TabIndex = 1;
            label11.Text = "Adres Detay:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(72, 73);
            label4.Name = "label4";
            label4.Size = new Size(29, 19);
            label4.TabIndex = 1;
            label4.Text = "Ad:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(64, 64, 64);
            label10.Location = new Point(49, 248);
            label10.Name = "label10";
            label10.Size = new Size(47, 19);
            label10.TabIndex = 1;
            label10.Text = "Adres:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(51, 101);
            label5.Name = "label5";
            label5.Size = new Size(50, 19);
            label5.TabIndex = 1;
            label5.Text = "Soyad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(37, 218);
            label9.Name = "label9";
            label9.Size = new Size(59, 19);
            label9.TabIndex = 1;
            label9.Text = "E-Posta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(38, 130);
            label6.Name = "label6";
            label6.Size = new Size(62, 19);
            label6.TabIndex = 1;
            label6.Text = "Cinsiyet:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(42, 190);
            label8.Name = "label8";
            label8.Size = new Size(58, 19);
            label8.TabIndex = 1;
            label8.Text = "Telefon:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(10, 160);
            label7.Name = "label7";
            label7.Size = new Size(93, 19);
            label7.TabIndex = 1;
            label7.Text = "Doğum Tarih:";
            // 
            // comboBox_Filtre
            // 
            comboBox_Filtre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox_Filtre.Font = new Font("Segoe UI", 10F);
            comboBox_Filtre.FormattingEnabled = true;
            comboBox_Filtre.Location = new Point(997, 12);
            comboBox_Filtre.Name = "comboBox_Filtre";
            comboBox_Filtre.Size = new Size(134, 25);
            comboBox_Filtre.TabIndex = 22;
            comboBox_Filtre.SelectedIndexChanged += comboBox_Filtre_SelectedIndexChanged;
            // 
            // label_txtAra
            // 
            label_txtAra.AutoSize = true;
            label_txtAra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label_txtAra.ForeColor = Color.FromArgb(64, 64, 64);
            label_txtAra.Location = new Point(335, 15);
            label_txtAra.Name = "label_txtAra";
            label_txtAra.Size = new Size(51, 17);
            label_txtAra.TabIndex = 23;
            label_txtAra.Text = "Arama:";
            // 
            // dataGrid_Uye
            // 
            dataGrid_Uye.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Uye.AutoGenerateColumns = false;
            dataGrid_Uye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Uye.Columns.AddRange(new DataGridViewColumn[] { uyeIdDataGridViewTextBoxColumn, tcPassDataGridViewTextBoxColumn, adDataGridViewTextBoxColumn, soyadDataGridViewTextBoxColumn, cinsiyetIdDataGridViewTextBoxColumn, cinsiyetDataGridViewTextBoxColumn, dogumTarihiDataGridViewTextBoxColumn, telefonDataGridViewTextBoxColumn, epostaDataGridViewTextBoxColumn, adresDataGridViewTextBoxColumn, adresDetayDataGridViewTextBoxColumn, aktifMiDataGridViewCheckBoxColumn });
            dataGrid_Uye.DataSource = uyeDtoBindingSource;
            dataGrid_Uye.Location = new Point(335, 43);
            dataGrid_Uye.Name = "dataGrid_Uye";
            dataGrid_Uye.RowHeadersWidth = 51;
            dataGrid_Uye.Size = new Size(795, 611);
            dataGrid_Uye.TabIndex = 24;
            dataGrid_Uye.CellFormatting += dataGrid_Uye_CellFormatting;
            dataGrid_Uye.CellPainting += dataGrid_Uye_CellPainting;
            dataGrid_Uye.ColumnHeaderMouseClick += dataGrid_Uye_ColumnHeaderMouseClick;
            dataGrid_Uye.SelectionChanged += dataGrid_Uye_SelectionChanged;
            // 
            // uyeIdDataGridViewTextBoxColumn
            // 
            uyeIdDataGridViewTextBoxColumn.DataPropertyName = "UyeId";
            uyeIdDataGridViewTextBoxColumn.HeaderText = "UyeId";
            uyeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            uyeIdDataGridViewTextBoxColumn.Name = "uyeIdDataGridViewTextBoxColumn";
            uyeIdDataGridViewTextBoxColumn.Visible = false;
            uyeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // tcPassDataGridViewTextBoxColumn
            // 
            tcPassDataGridViewTextBoxColumn.DataPropertyName = "TcPass";
            tcPassDataGridViewTextBoxColumn.HeaderText = "TC No / Pasaport No ";
            tcPassDataGridViewTextBoxColumn.MinimumWidth = 6;
            tcPassDataGridViewTextBoxColumn.Name = "tcPassDataGridViewTextBoxColumn";
            tcPassDataGridViewTextBoxColumn.Width = 125;
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
            // cinsiyetDataGridViewTextBoxColumn
            // 
            cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            cinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            cinsiyetDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            dogumTarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            dogumTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            dogumTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            epostaDataGridViewTextBoxColumn.DataPropertyName = "Eposta";
            epostaDataGridViewTextBoxColumn.HeaderText = "E-Posta";
            epostaDataGridViewTextBoxColumn.MinimumWidth = 6;
            epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            epostaDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDetayDataGridViewTextBoxColumn
            // 
            adresDetayDataGridViewTextBoxColumn.DataPropertyName = "AdresDetay";
            adresDetayDataGridViewTextBoxColumn.HeaderText = "Adres Detay";
            adresDetayDataGridViewTextBoxColumn.MinimumWidth = 6;
            adresDetayDataGridViewTextBoxColumn.Name = "adresDetayDataGridViewTextBoxColumn";
            adresDetayDataGridViewTextBoxColumn.Width = 125;
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
            // frmUyeIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1144, 672);
            Controls.Add(dataGrid_Uye);
            Controls.Add(label_txtAra);
            Controls.Add(comboBox_Filtre);
            Controls.Add(groupBox1);
            Controls.Add(textBox_Ara);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1160, 711);
            Name = "frmUyeIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Üye İşlemleri";
            Load += frmUyeIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)uyeDtoBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Uye).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private DataGridViewTextBoxColumn cinsiyetIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dogumYiliDataGridViewTextBoxColumn;
        private TextBox textBox_Ara;
        private GroupBox groupBox1;
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
        private DataGridViewTextBoxColumn tcPassDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinsiyetIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresDetayDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSilinenleriGoster;
        private Button btnGeriYukle;
    }
}