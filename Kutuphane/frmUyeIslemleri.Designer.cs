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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUyeIslemleri));
            dataGrid_Uye = new DataGridView();
            uyeDtoBindingSource = new BindingSource(components);
            textBox_Ara = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            btnGeriYukle = new Button();
            btnSilinenleriGoster = new Button();
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
            comboBox_Sirala = new ComboBox();
            comboBox_Filtre = new ComboBox();
            uyeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tcPassDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            cinsiyetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dogumTarihiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            epostaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresDetayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifMiDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Uye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uyeDtoBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGrid_Uye
            // 
            dataGrid_Uye.AllowUserToAddRows = false;
            dataGrid_Uye.AllowUserToDeleteRows = false;
            dataGrid_Uye.AllowUserToOrderColumns = true;
            dataGrid_Uye.AllowUserToResizeRows = false;
            dataGrid_Uye.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Uye.AutoGenerateColumns = false;
            dataGrid_Uye.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Uye.BackgroundColor = Color.White;
            dataGrid_Uye.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid_Uye.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Uye.ColumnHeadersHeight = 30;
            dataGrid_Uye.Columns.AddRange(new DataGridViewColumn[] { uyeIdDataGridViewTextBoxColumn, tcPassDataGridViewTextBoxColumn, adDataGridViewTextBoxColumn, soyadDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, cinsiyetDataGridViewTextBoxColumn, dogumTarihiDataGridViewTextBoxColumn, telefonDataGridViewTextBoxColumn, epostaDataGridViewTextBoxColumn, adresDataGridViewTextBoxColumn, adresDetayDataGridViewTextBoxColumn, aktifMiDataGridViewCheckBoxColumn });
            dataGrid_Uye.DataSource = uyeDtoBindingSource;
            dataGrid_Uye.EnableHeadersVisualStyles = false;
            dataGrid_Uye.GridColor = Color.LightGray;
            dataGrid_Uye.Location = new Point(363, 57);
            dataGrid_Uye.Margin = new Padding(3, 4, 3, 4);
            dataGrid_Uye.Name = "dataGrid_Uye";
            dataGrid_Uye.ReadOnly = true;
            dataGrid_Uye.RowHeadersVisible = false;
            dataGrid_Uye.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(170, 204, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGrid_Uye.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGrid_Uye.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Uye.Size = new Size(930, 828);
            dataGrid_Uye.TabIndex = 19;
            dataGrid_Uye.CellFormatting += dataGrid_Uye_CellFormatting;
            dataGrid_Uye.CellPainting += dataGrid_Uye_CellPainting;
            dataGrid_Uye.SelectionChanged += dataGrid_Uye_SelectionChanged;
            // 
            // uyeDtoBindingSource
            // 
            uyeDtoBindingSource.DataSource = typeof(Model.DTO.UyeDto);
            // 
            // textBox_Ara
            // 
            textBox_Ara.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_Ara.Font = new Font("Segoe UI", 10F);
            textBox_Ara.Location = new Point(654, 16);
            textBox_Ara.Margin = new Padding(3, 4, 3, 4);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Arama metni giriniz";
            textBox_Ara.Size = new Size(319, 30);
            textBox_Ara.TabIndex = 17;
            textBox_Ara.TextChanged += textBox_Ara_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(609, 20);
            label1.Name = "label1";
            label1.Size = new Size(40, 23);
            label1.TabIndex = 2;
            label1.Text = "Ara:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(btnGeriYukle);
            groupBox1.Controls.Add(btnSilinenleriGoster);
            groupBox1.Controls.Add(comboBox_Cinsiyet);
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnDuzenle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(richTextBox_AdresDetay);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_Adres);
            groupBox1.Controls.Add(textBox_Eposta);
            groupBox1.Controls.Add(textBox_Telefon);
            groupBox1.Controls.Add(textBox_Soyad);
            groupBox1.Controls.Add(textBox_Ad);
            groupBox1.Controls.Add(textBox_TcPass);
            groupBox1.Controls.Add(textBox_UyeId);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(343, 869);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "👤 Üye Kayıt ve Güncelleme";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Location = new Point(106, 239);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 30);
            dateTimePicker1.TabIndex = 6;
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.BackColor = Color.FromArgb(39, 174, 96);
            btnGeriYukle.FlatAppearance.BorderSize = 0;
            btnGeriYukle.FlatStyle = FlatStyle.Flat;
            btnGeriYukle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGeriYukle.ForeColor = Color.White;
            btnGeriYukle.Location = new Point(106, 749);
            btnGeriYukle.Margin = new Padding(3, 4, 3, 4);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(171, 47);
            btnGeriYukle.TabIndex = 16;
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
            btnSilinenleriGoster.Location = new Point(106, 695);
            btnSilinenleriGoster.Margin = new Padding(3, 4, 3, 4);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(171, 47);
            btnSilinenleriGoster.TabIndex = 15;
            btnSilinenleriGoster.Text = "🗑️ Silinenleri Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // comboBox_Cinsiyet
            // 
            comboBox_Cinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Cinsiyet.Font = new Font("Segoe UI", 10F);
            comboBox_Cinsiyet.FormattingEnabled = true;
            comboBox_Cinsiyet.Location = new Point(106, 200);
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
            btnTemizle.Location = new Point(106, 640);
            btnTemizle.Margin = new Padding(3, 4, 3, 4);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(171, 47);
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
            btnSil.Location = new Point(106, 585);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(171, 47);
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
            btnDuzenle.Location = new Point(106, 531);
            btnDuzenle.Margin = new Padding(3, 4, 3, 4);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(171, 47);
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
            btnKaydet.Location = new Point(106, 476);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(171, 47);
            btnKaydet.TabIndex = 11;
            btnKaydet.Text = "➕ Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // richTextBox_AdresDetay
            // 
            richTextBox_AdresDetay.Font = new Font("Segoe UI", 10F);
            richTextBox_AdresDetay.Location = new Point(106, 397);
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
            label11.Location = new Point(1, 401);
            label11.Name = "label11";
            label11.Size = new Size(107, 23);
            label11.TabIndex = 1;
            label11.Text = "Adres Detay:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.Location = new Point(47, 360);
            label10.Name = "label10";
            label10.Size = new Size(57, 23);
            label10.TabIndex = 1;
            label10.Text = "Adres:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(33, 321);
            label9.Name = "label9";
            label9.Size = new Size(71, 23);
            label9.TabIndex = 1;
            label9.Text = "E-Posta:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(39, 283);
            label8.Name = "label8";
            label8.Size = new Size(69, 23);
            label8.TabIndex = 1;
            label8.Text = "Telefon:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(2, 243);
            label7.Name = "label7";
            label7.Size = new Size(112, 23);
            label7.TabIndex = 1;
            label7.Text = "Doğum Tarih:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(35, 204);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 1;
            label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(49, 165);
            label5.Name = "label5";
            label5.Size = new Size(61, 23);
            label5.TabIndex = 1;
            label5.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(73, 127);
            label4.Name = "label4";
            label4.Size = new Size(35, 23);
            label4.TabIndex = 1;
            label4.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(15, 88);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 1;
            label3.Text = "TC/Pas No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(42, 49);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 1;
            label2.Text = "Üye Id:";
            // 
            // textBox_Adres
            // 
            textBox_Adres.Font = new Font("Segoe UI", 10F);
            textBox_Adres.Location = new Point(106, 356);
            textBox_Adres.Margin = new Padding(3, 4, 3, 4);
            textBox_Adres.Name = "textBox_Adres";
            textBox_Adres.Size = new Size(229, 30);
            textBox_Adres.TabIndex = 9;
            // 
            // textBox_Eposta
            // 
            textBox_Eposta.Font = new Font("Segoe UI", 10F);
            textBox_Eposta.Location = new Point(106, 317);
            textBox_Eposta.Margin = new Padding(3, 4, 3, 4);
            textBox_Eposta.Name = "textBox_Eposta";
            textBox_Eposta.Size = new Size(229, 30);
            textBox_Eposta.TabIndex = 8;
            // 
            // textBox_Telefon
            // 
            textBox_Telefon.Font = new Font("Segoe UI", 10F);
            textBox_Telefon.Location = new Point(106, 279);
            textBox_Telefon.Margin = new Padding(3, 4, 3, 4);
            textBox_Telefon.Name = "textBox_Telefon";
            textBox_Telefon.Size = new Size(229, 30);
            textBox_Telefon.TabIndex = 7;
            // 
            // textBox_Soyad
            // 
            textBox_Soyad.Font = new Font("Segoe UI", 10F);
            textBox_Soyad.Location = new Point(106, 161);
            textBox_Soyad.Margin = new Padding(3, 4, 3, 4);
            textBox_Soyad.Name = "textBox_Soyad";
            textBox_Soyad.Size = new Size(229, 30);
            textBox_Soyad.TabIndex = 4;
            // 
            // textBox_Ad
            // 
            textBox_Ad.Font = new Font("Segoe UI", 10F);
            textBox_Ad.Location = new Point(106, 123);
            textBox_Ad.Margin = new Padding(3, 4, 3, 4);
            textBox_Ad.Name = "textBox_Ad";
            textBox_Ad.Size = new Size(229, 30);
            textBox_Ad.TabIndex = 3;
            // 
            // textBox_TcPass
            // 
            textBox_TcPass.Font = new Font("Segoe UI", 10F);
            textBox_TcPass.Location = new Point(106, 84);
            textBox_TcPass.Margin = new Padding(3, 4, 3, 4);
            textBox_TcPass.Name = "textBox_TcPass";
            textBox_TcPass.Size = new Size(229, 30);
            textBox_TcPass.TabIndex = 2;
            // 
            // textBox_UyeId
            // 
            textBox_UyeId.Enabled = false;
            textBox_UyeId.Font = new Font("Segoe UI", 10F);
            textBox_UyeId.Location = new Point(106, 45);
            textBox_UyeId.Margin = new Padding(3, 4, 3, 4);
            textBox_UyeId.Name = "textBox_UyeId";
            textBox_UyeId.Size = new Size(229, 30);
            textBox_UyeId.TabIndex = 1;
            // 
            // comboBox_Sirala
            // 
            comboBox_Sirala.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox_Sirala.Font = new Font("Segoe UI", 10F);
            comboBox_Sirala.FormattingEnabled = true;
            comboBox_Sirala.Location = new Point(1141, 16);
            comboBox_Sirala.Margin = new Padding(3, 4, 3, 4);
            comboBox_Sirala.Name = "comboBox_Sirala";
            comboBox_Sirala.Size = new Size(153, 31);
            comboBox_Sirala.TabIndex = 21;
            comboBox_Sirala.SelectedIndexChanged += comboBox_Sirala_SelectedIndexChanged;
            // 
            // comboBox_Filtre
            // 
            comboBox_Filtre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox_Filtre.Font = new Font("Segoe UI", 10F);
            comboBox_Filtre.FormattingEnabled = true;
            comboBox_Filtre.Location = new Point(981, 16);
            comboBox_Filtre.Margin = new Padding(3, 4, 3, 4);
            comboBox_Filtre.Name = "comboBox_Filtre";
            comboBox_Filtre.Size = new Size(153, 31);
            comboBox_Filtre.TabIndex = 22;
            comboBox_Filtre.SelectedIndexChanged += comboBox_Filtre_SelectedIndexChanged;
            // 
            // uyeIdDataGridViewTextBoxColumn
            // 
            uyeIdDataGridViewTextBoxColumn.DataPropertyName = "UyeId";
            uyeIdDataGridViewTextBoxColumn.HeaderText = "UyeId";
            uyeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            uyeIdDataGridViewTextBoxColumn.Name = "uyeIdDataGridViewTextBoxColumn";
            uyeIdDataGridViewTextBoxColumn.ReadOnly = true;
            uyeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // tcPassDataGridViewTextBoxColumn
            // 
            tcPassDataGridViewTextBoxColumn.DataPropertyName = "TcPass";
            tcPassDataGridViewTextBoxColumn.HeaderText = "TC/Pasaport No";
            tcPassDataGridViewTextBoxColumn.MinimumWidth = 6;
            tcPassDataGridViewTextBoxColumn.Name = "tcPassDataGridViewTextBoxColumn";
            tcPassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            adDataGridViewTextBoxColumn.HeaderText = "Adı";
            adDataGridViewTextBoxColumn.MinimumWidth = 6;
            adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            soyadDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            soyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "CinsiyetId";
            dataGridViewTextBoxColumn1.HeaderText = "CinsiyetId";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            cinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            cinsiyetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd.MM.yyyy";
            dogumTarihiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            dogumTarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            dogumTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            dogumTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            epostaDataGridViewTextBoxColumn.DataPropertyName = "Eposta";
            epostaDataGridViewTextBoxColumn.HeaderText = "E-Posta";
            epostaDataGridViewTextBoxColumn.MinimumWidth = 6;
            epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            epostaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            adresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDetayDataGridViewTextBoxColumn
            // 
            adresDetayDataGridViewTextBoxColumn.DataPropertyName = "AdresDetay";
            adresDetayDataGridViewTextBoxColumn.HeaderText = "Adres Detay";
            adresDetayDataGridViewTextBoxColumn.MinimumWidth = 6;
            adresDetayDataGridViewTextBoxColumn.Name = "adresDetayDataGridViewTextBoxColumn";
            adresDetayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aktifMiDataGridViewCheckBoxColumn
            // 
            aktifMiDataGridViewCheckBoxColumn.DataPropertyName = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.HeaderText = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.MinimumWidth = 6;
            aktifMiDataGridViewCheckBoxColumn.Name = "aktifMiDataGridViewCheckBoxColumn";
            aktifMiDataGridViewCheckBoxColumn.ReadOnly = true;
            aktifMiDataGridViewCheckBoxColumn.Visible = false;
            // 
            // frmUyeIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1307, 901);
            Controls.Add(comboBox_Filtre);
            Controls.Add(comboBox_Sirala);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(textBox_Ara);
            Controls.Add(dataGrid_Uye);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1323, 938);
            Name = "frmUyeIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Üye İşlemleri";
            Load += frmUyeIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_Uye).EndInit();
            ((System.ComponentModel.ISupportInitialize)uyeDtoBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DataGridView dataGrid_Uye;
        private DataGridViewTextBoxColumn cinsiyetIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dogumYiliDataGridViewTextBoxColumn;
        private TextBox textBox_Ara;
        private Label label1;
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
        private Button btnSilinenleriGoster;
        private Button btnGeriYukle;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox_Telefon;
        private ComboBox comboBox_Sirala;
        private ComboBox comboBox_Filtre;
        private DataGridViewTextBoxColumn uyeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tcPassDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresDetayDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
    }
}