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
            textBox_Ara.Location = new Point(375, 12);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Arama metni giriniz";
            textBox_Ara.Size = new Size(280, 25);
            textBox_Ara.TabIndex = 17;
            textBox_Ara.TextChanged += textBox_Ara_TextChanged;
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 652);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "👤 Üye Kayıt ve Güncelleme";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Location = new Point(93, 179);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(201, 25);
            dateTimePicker1.TabIndex = 6;
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.BackColor = Color.FromArgb(39, 174, 96);
            btnGeriYukle.FlatAppearance.BorderSize = 0;
            btnGeriYukle.FlatStyle = FlatStyle.Flat;
            btnGeriYukle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGeriYukle.ForeColor = Color.White;
            btnGeriYukle.Location = new Point(93, 562);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(150, 35);
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
            btnSilinenleriGoster.Location = new Point(93, 521);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(150, 35);
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
            comboBox_Cinsiyet.Location = new Point(93, 150);
            comboBox_Cinsiyet.Name = "comboBox_Cinsiyet";
            comboBox_Cinsiyet.Size = new Size(201, 25);
            comboBox_Cinsiyet.TabIndex = 5;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(149, 165, 166);
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(93, 480);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(150, 35);
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
            btnSil.Location = new Point(93, 439);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(150, 35);
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
            btnDuzenle.Location = new Point(93, 398);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(150, 35);
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
            btnKaydet.Location = new Point(93, 357);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(150, 35);
            btnKaydet.TabIndex = 11;
            btnKaydet.Text = "➕ Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // richTextBox_AdresDetay
            // 
            richTextBox_AdresDetay.Font = new Font("Segoe UI", 10F);
            richTextBox_AdresDetay.Location = new Point(93, 298);
            richTextBox_AdresDetay.Name = "richTextBox_AdresDetay";
            richTextBox_AdresDetay.Size = new Size(201, 53);
            richTextBox_AdresDetay.TabIndex = 10;
            richTextBox_AdresDetay.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.Location = new Point(1, 301);
            label11.Name = "label11";
            label11.Size = new Size(87, 19);
            label11.TabIndex = 1;
            label11.Text = "Adres Detay:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.Location = new Point(41, 270);
            label10.Name = "label10";
            label10.Size = new Size(47, 19);
            label10.TabIndex = 1;
            label10.Text = "Adres:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(29, 241);
            label9.Name = "label9";
            label9.Size = new Size(59, 19);
            label9.TabIndex = 1;
            label9.Text = "E-Posta:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(34, 212);
            label8.Name = "label8";
            label8.Size = new Size(58, 19);
            label8.TabIndex = 1;
            label8.Text = "Telefon:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(2, 182);
            label7.Name = "label7";
            label7.Size = new Size(93, 19);
            label7.TabIndex = 1;
            label7.Text = "Doğum Tarih:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(31, 153);
            label6.Name = "label6";
            label6.Size = new Size(62, 19);
            label6.TabIndex = 1;
            label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(43, 124);
            label5.Name = "label5";
            label5.Size = new Size(50, 19);
            label5.TabIndex = 1;
            label5.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(64, 95);
            label4.Name = "label4";
            label4.Size = new Size(29, 19);
            label4.TabIndex = 1;
            label4.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(13, 66);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 1;
            label3.Text = "TC/Pas No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(37, 37);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 1;
            label2.Text = "Üye Id:";
            // 
            // textBox_Adres
            // 
            textBox_Adres.Font = new Font("Segoe UI", 10F);
            textBox_Adres.Location = new Point(93, 267);
            textBox_Adres.Name = "textBox_Adres";
            textBox_Adres.Size = new Size(201, 25);
            textBox_Adres.TabIndex = 9;
            // 
            // textBox_Eposta
            // 
            textBox_Eposta.Font = new Font("Segoe UI", 10F);
            textBox_Eposta.Location = new Point(93, 238);
            textBox_Eposta.Name = "textBox_Eposta";
            textBox_Eposta.Size = new Size(201, 25);
            textBox_Eposta.TabIndex = 8;
            // 
            // textBox_Telefon
            // 
            textBox_Telefon.Font = new Font("Segoe UI", 10F);
            textBox_Telefon.Location = new Point(93, 209);
            textBox_Telefon.Name = "textBox_Telefon";
            textBox_Telefon.Size = new Size(201, 25);
            textBox_Telefon.TabIndex = 7;
            // 
            // textBox_Soyad
            // 
            textBox_Soyad.Font = new Font("Segoe UI", 10F);
            textBox_Soyad.Location = new Point(93, 121);
            textBox_Soyad.Name = "textBox_Soyad";
            textBox_Soyad.Size = new Size(201, 25);
            textBox_Soyad.TabIndex = 4;
            // 
            // textBox_Ad
            // 
            textBox_Ad.Font = new Font("Segoe UI", 10F);
            textBox_Ad.Location = new Point(93, 92);
            textBox_Ad.Name = "textBox_Ad";
            textBox_Ad.Size = new Size(201, 25);
            textBox_Ad.TabIndex = 3;
            // 
            // textBox_TcPass
            // 
            textBox_TcPass.Font = new Font("Segoe UI", 10F);
            textBox_TcPass.Location = new Point(93, 63);
            textBox_TcPass.Name = "textBox_TcPass";
            textBox_TcPass.Size = new Size(201, 25);
            textBox_TcPass.TabIndex = 2;
            // 
            // textBox_UyeId
            // 
            textBox_UyeId.Enabled = false;
            textBox_UyeId.Font = new Font("Segoe UI", 10F);
            textBox_UyeId.Location = new Point(93, 34);
            textBox_UyeId.Name = "textBox_UyeId";
            textBox_UyeId.Size = new Size(201, 25);
            textBox_UyeId.TabIndex = 1;
            // 
            // comboBox_Filtre
            // 
            comboBox_Filtre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox_Filtre.Font = new Font("Segoe UI", 10F);
            comboBox_Filtre.FormattingEnabled = true;
            comboBox_Filtre.Location = new Point(998, 12);
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
            label_txtAra.Location = new Point(318, 15);
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
            dataGrid_Uye.Location = new Point(318, 43);
            dataGrid_Uye.Name = "dataGrid_Uye";
            dataGrid_Uye.Size = new Size(814, 621);
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
            uyeIdDataGridViewTextBoxColumn.Name = "uyeIdDataGridViewTextBoxColumn";
            uyeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // tcPassDataGridViewTextBoxColumn
            // 
            tcPassDataGridViewTextBoxColumn.DataPropertyName = "TcPass";
            tcPassDataGridViewTextBoxColumn.HeaderText = "TC No / Pasaport No ";
            tcPassDataGridViewTextBoxColumn.Name = "tcPassDataGridViewTextBoxColumn";
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
            // cinsiyetDataGridViewTextBoxColumn
            // 
            cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            dogumTarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            epostaDataGridViewTextBoxColumn.DataPropertyName = "Eposta";
            epostaDataGridViewTextBoxColumn.HeaderText = "E-Posta";
            epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // adresDetayDataGridViewTextBoxColumn
            // 
            adresDetayDataGridViewTextBoxColumn.DataPropertyName = "AdresDetay";
            adresDetayDataGridViewTextBoxColumn.HeaderText = "Adres Detay";
            adresDetayDataGridViewTextBoxColumn.Name = "adresDetayDataGridViewTextBoxColumn";
            // 
            // aktifMiDataGridViewCheckBoxColumn
            // 
            aktifMiDataGridViewCheckBoxColumn.DataPropertyName = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.HeaderText = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.Name = "aktifMiDataGridViewCheckBoxColumn";
            aktifMiDataGridViewCheckBoxColumn.Visible = false;
            // 
            // frmUyeIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1144, 676);
            Controls.Add(dataGrid_Uye);
            Controls.Add(label_txtAra);
            Controls.Add(comboBox_Filtre);
            Controls.Add(groupBox1);
            Controls.Add(textBox_Ara);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1160, 713);
            Name = "frmUyeIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Üye İşlemleri";
            Load += frmUyeIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)uyeDtoBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button btnSilinenleriGoster;
        private Button btnGeriYukle;
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
    }
}