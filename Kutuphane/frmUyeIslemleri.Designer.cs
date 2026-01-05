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
            dateTimePicker1 = new DateTimePicker();
            comboBox_Cinsiyet = new ComboBox();
            btnTemizle = new Button();
            btnSil = new Button();
            btnDuzenle = new Button();
            btnKaydet = new Button();
            richTextBox_AdresDetay = new RichTextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox_Adres = new TextBox();
            textBox_Eposta = new TextBox();
            textBox_Telefon = new TextBox();
            textBox_Soyad = new TextBox();
            textBox_Ad = new TextBox();
            textBox_TcPass = new TextBox();
            textBox_UyeId = new TextBox();
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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSilinenleriGoster = new Button();
            btnGeriYukle = new Button();
            ((System.ComponentModel.ISupportInitialize)uyeDtoBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Uye).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uyeDtoBindingSource
            // 
            uyeDtoBindingSource.DataSource = typeof(Model.DTO.UyeDto);
            // 
            // textBox_Ara
            // 
            textBox_Ara.Font = new Font("Segoe UI", 10F);
            textBox_Ara.Location = new Point(429, 16);
            textBox_Ara.Margin = new Padding(3, 4, 3, 4);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Arama metni giriniz";
            textBox_Ara.Size = new Size(319, 30);
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
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.MinimumSize = new Size(343, 869);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(343, 869);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "👤 Üye Kayıt İşlemleri";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Location = new Point(115, 209);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 30);
            dateTimePicker1.TabIndex = 6;
            // 
            // comboBox_Cinsiyet
            // 
            comboBox_Cinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Cinsiyet.Font = new Font("Segoe UI", 10F);
            comboBox_Cinsiyet.FormattingEnabled = true;
            comboBox_Cinsiyet.Location = new Point(115, 170);
            comboBox_Cinsiyet.Margin = new Padding(3, 4, 3, 4);
            comboBox_Cinsiyet.Name = "comboBox_Cinsiyet";
            comboBox_Cinsiyet.Size = new Size(229, 31);
            comboBox_Cinsiyet.TabIndex = 5;
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
            btnTemizle.TabIndex = 14;
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
            btnSil.TabIndex = 13;
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
            btnDuzenle.TabIndex = 12;
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
            btnKaydet.TabIndex = 11;
            btnKaydet.Text = "💾 KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // richTextBox_AdresDetay
            // 
            richTextBox_AdresDetay.Font = new Font("Segoe UI", 10F);
            richTextBox_AdresDetay.Location = new Point(115, 367);
            richTextBox_AdresDetay.Margin = new Padding(3, 4, 3, 4);
            richTextBox_AdresDetay.Name = "richTextBox_AdresDetay";
            richTextBox_AdresDetay.Size = new Size(229, 69);
            richTextBox_AdresDetay.TabIndex = 10;
            richTextBox_AdresDetay.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(10, 371);
            label11.Name = "label11";
            label11.Size = new Size(107, 23);
            label11.TabIndex = 1;
            label11.Text = "Adres Detay:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(64, 64, 64);
            label10.Location = new Point(56, 330);
            label10.Name = "label10";
            label10.Size = new Size(57, 23);
            label10.TabIndex = 1;
            label10.Text = "Adres:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(42, 291);
            label9.Name = "label9";
            label9.Size = new Size(71, 23);
            label9.TabIndex = 1;
            label9.Text = "E-Posta:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(48, 253);
            label8.Name = "label8";
            label8.Size = new Size(69, 23);
            label8.TabIndex = 1;
            label8.Text = "Telefon:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(11, 213);
            label7.Name = "label7";
            label7.Size = new Size(112, 23);
            label7.TabIndex = 1;
            label7.Text = "Doğum Tarih:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(44, 174);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 1;
            label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(58, 135);
            label5.Name = "label5";
            label5.Size = new Size(61, 23);
            label5.TabIndex = 1;
            label5.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(82, 97);
            label4.Name = "label4";
            label4.Size = new Size(35, 23);
            label4.TabIndex = 1;
            label4.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(24, 58);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 1;
            label3.Text = "TC/Pas No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(51, 19);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 1;
            label2.Text = "Üye Id:";
            // 
            // textBox_Adres
            // 
            textBox_Adres.Font = new Font("Segoe UI", 10F);
            textBox_Adres.Location = new Point(115, 326);
            textBox_Adres.Margin = new Padding(3, 4, 3, 4);
            textBox_Adres.Name = "textBox_Adres";
            textBox_Adres.Size = new Size(229, 30);
            textBox_Adres.TabIndex = 9;
            // 
            // textBox_Eposta
            // 
            textBox_Eposta.Font = new Font("Segoe UI", 10F);
            textBox_Eposta.Location = new Point(115, 287);
            textBox_Eposta.Margin = new Padding(3, 4, 3, 4);
            textBox_Eposta.Name = "textBox_Eposta";
            textBox_Eposta.Size = new Size(229, 30);
            textBox_Eposta.TabIndex = 8;
            // 
            // textBox_Telefon
            // 
            textBox_Telefon.Font = new Font("Segoe UI", 10F);
            textBox_Telefon.Location = new Point(115, 249);
            textBox_Telefon.Margin = new Padding(3, 4, 3, 4);
            textBox_Telefon.Name = "textBox_Telefon";
            textBox_Telefon.Size = new Size(229, 30);
            textBox_Telefon.TabIndex = 7;
            // 
            // textBox_Soyad
            // 
            textBox_Soyad.Font = new Font("Segoe UI", 10F);
            textBox_Soyad.Location = new Point(115, 131);
            textBox_Soyad.Margin = new Padding(3, 4, 3, 4);
            textBox_Soyad.Name = "textBox_Soyad";
            textBox_Soyad.Size = new Size(229, 30);
            textBox_Soyad.TabIndex = 4;
            // 
            // textBox_Ad
            // 
            textBox_Ad.Font = new Font("Segoe UI", 10F);
            textBox_Ad.Location = new Point(115, 93);
            textBox_Ad.Margin = new Padding(3, 4, 3, 4);
            textBox_Ad.Name = "textBox_Ad";
            textBox_Ad.Size = new Size(229, 30);
            textBox_Ad.TabIndex = 3;
            // 
            // textBox_TcPass
            // 
            textBox_TcPass.Font = new Font("Segoe UI", 10F);
            textBox_TcPass.Location = new Point(115, 54);
            textBox_TcPass.Margin = new Padding(3, 4, 3, 4);
            textBox_TcPass.Name = "textBox_TcPass";
            textBox_TcPass.Size = new Size(229, 30);
            textBox_TcPass.TabIndex = 2;
            // 
            // textBox_UyeId
            // 
            textBox_UyeId.Enabled = false;
            textBox_UyeId.Font = new Font("Segoe UI", 10F);
            textBox_UyeId.Location = new Point(115, 15);
            textBox_UyeId.Margin = new Padding(3, 4, 3, 4);
            textBox_UyeId.Name = "textBox_UyeId";
            textBox_UyeId.Size = new Size(229, 30);
            textBox_UyeId.TabIndex = 1;
            // 
            // comboBox_Filtre
            // 
            comboBox_Filtre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox_Filtre.Font = new Font("Segoe UI", 10F);
            comboBox_Filtre.FormattingEnabled = true;
            comboBox_Filtre.Location = new Point(1139, 16);
            comboBox_Filtre.Margin = new Padding(3, 4, 3, 4);
            comboBox_Filtre.Name = "comboBox_Filtre";
            comboBox_Filtre.Size = new Size(153, 31);
            comboBox_Filtre.TabIndex = 22;
            comboBox_Filtre.SelectedIndexChanged += comboBox_Filtre_SelectedIndexChanged;
            // 
            // label_txtAra
            // 
            label_txtAra.AutoSize = true;
            label_txtAra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label_txtAra.ForeColor = Color.FromArgb(64, 64, 64);
            label_txtAra.Location = new Point(363, 20);
            label_txtAra.Name = "label_txtAra";
            label_txtAra.Size = new Size(64, 23);
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
            dataGrid_Uye.Location = new Point(363, 57);
            dataGrid_Uye.Margin = new Padding(3, 4, 3, 4);
            dataGrid_Uye.Name = "dataGrid_Uye";
            dataGrid_Uye.RowHeadersWidth = 51;
            dataGrid_Uye.Size = new Size(928, 815);
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
            panel1.Location = new Point(3, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 452);
            panel1.TabIndex = 25;
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
            flowLayoutPanel1.Location = new Point(3, 481);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(11, 13, 11, 13);
            flowLayoutPanel1.Size = new Size(337, 384);
            flowLayoutPanel1.TabIndex = 26;
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
            btnGeriYukle.Location = new Point(14, 312);
            btnGeriYukle.Margin = new Padding(3, 4, 3, 4);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(303, 51);
            btnGeriYukle.TabIndex = 16;
            btnGeriYukle.Text = "↩️ Seçili Üyeyi Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = false;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // frmUyeIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1305, 888);
            Controls.Add(dataGrid_Uye);
            Controls.Add(label_txtAra);
            Controls.Add(comboBox_Filtre);
            Controls.Add(groupBox1);
            Controls.Add(textBox_Ara);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1323, 935);
            Name = "frmUyeIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Üye İşlemleri";
            Load += frmUyeIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)uyeDtoBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid_Uye).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
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