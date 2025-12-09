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
            dataGrid_Uye = new DataGridView();
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
            uyeDtoBindingSource = new BindingSource(components);
            textBox_Ara = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnGeriYukle = new Button();
            btnSilinenleriGoster = new Button();
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
            btnAra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Uye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uyeDtoBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGrid_Uye
            // 
            dataGrid_Uye.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Uye.AutoGenerateColumns = false;
            dataGrid_Uye.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Uye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Uye.Columns.AddRange(new DataGridViewColumn[] { uyeIdDataGridViewTextBoxColumn, tcPassDataGridViewTextBoxColumn, adDataGridViewTextBoxColumn, soyadDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, cinsiyetDataGridViewTextBoxColumn, dogumTarihiDataGridViewTextBoxColumn, telefonDataGridViewTextBoxColumn, epostaDataGridViewTextBoxColumn, adresDataGridViewTextBoxColumn, adresDetayDataGridViewTextBoxColumn, aktifMiDataGridViewCheckBoxColumn });
            dataGrid_Uye.DataSource = uyeDtoBindingSource;
            dataGrid_Uye.Location = new Point(331, 43);
            dataGrid_Uye.Name = "dataGrid_Uye";
            dataGrid_Uye.RowHeadersWidth = 51;
            dataGrid_Uye.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Uye.Size = new Size(801, 621);
            dataGrid_Uye.TabIndex = 0;
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
            tcPassDataGridViewTextBoxColumn.HeaderText = "TcPass";
            tcPassDataGridViewTextBoxColumn.Name = "tcPassDataGridViewTextBoxColumn";
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "CinsiyetId";
            dataGridViewTextBoxColumn1.HeaderText = "CinsiyetId";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Visible = false;
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
            dogumTarihiDataGridViewTextBoxColumn.HeaderText = "DogumTarihi";
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
            epostaDataGridViewTextBoxColumn.HeaderText = "Eposta";
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
            adresDetayDataGridViewTextBoxColumn.HeaderText = "AdresDetay";
            adresDetayDataGridViewTextBoxColumn.Name = "adresDetayDataGridViewTextBoxColumn";
            // 
            // aktifMiDataGridViewCheckBoxColumn
            // 
            aktifMiDataGridViewCheckBoxColumn.DataPropertyName = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.HeaderText = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.Name = "aktifMiDataGridViewCheckBoxColumn";
            aktifMiDataGridViewCheckBoxColumn.Visible = false;
            // 
            // uyeDtoBindingSource
            // 
            uyeDtoBindingSource.DataSource = typeof(Model.DTO.UyeDto);
            // 
            // textBox_Ara
            // 
            textBox_Ara.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_Ara.Location = new Point(771, 16);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "TC Kimlik No / Pasaport No / Ad Soyad ile arayın";
            textBox_Ara.Size = new Size(280, 23);
            textBox_Ara.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(737, 19);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 2;
            label1.Text = "Ara:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGeriYukle);
            groupBox1.Controls.Add(btnSilinenleriGoster);
            groupBox1.Controls.Add(dateTimePicker1);
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
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 620);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üye İşlemleri";
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.Location = new Point(118, 562);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(150, 25);
            btnGeriYukle.TabIndex = 12;
            btnGeriYukle.Text = "Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = true;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.Location = new Point(118, 531);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(150, 25);
            btnSilinenleriGoster.TabIndex = 11;
            btnSilinenleriGoster.Text = "Silinen Üyeleri Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = true;
            btnSilinenleriGoster.Visible = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(93, 180);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(201, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // comboBox_Cinsiyet
            // 
            comboBox_Cinsiyet.FormattingEnabled = true;
            comboBox_Cinsiyet.Location = new Point(93, 150);
            comboBox_Cinsiyet.Name = "comboBox_Cinsiyet";
            comboBox_Cinsiyet.Size = new Size(201, 23);
            comboBox_Cinsiyet.TabIndex = 9;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(118, 500);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(150, 25);
            btnTemizle.TabIndex = 8;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(118, 469);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(150, 25);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(118, 438);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(150, 25);
            btnDuzenle.TabIndex = 7;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(118, 407);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(150, 25);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // richTextBox_AdresDetay
            // 
            richTextBox_AdresDetay.Location = new Point(93, 295);
            richTextBox_AdresDetay.Name = "richTextBox_AdresDetay";
            richTextBox_AdresDetay.Size = new Size(201, 96);
            richTextBox_AdresDetay.TabIndex = 5;
            richTextBox_AdresDetay.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 298);
            label11.Name = "label11";
            label11.Size = new Size(73, 15);
            label11.TabIndex = 1;
            label11.Text = "Adres Detay:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(47, 269);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 1;
            label10.Text = "Adres:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 240);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 1;
            label9.Text = "E-Posta:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 211);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 1;
            label8.Text = "Telefon:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 182);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 1;
            label7.Text = "Doğum Yılı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 153);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 1;
            label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 124);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 1;
            label5.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 95);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 1;
            label4.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 66);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 1;
            label3.Text = "Tc/Pass:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 37);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Üye ID:";
            // 
            // textBox_Adres
            // 
            textBox_Adres.Location = new Point(93, 266);
            textBox_Adres.Name = "textBox_Adres";
            textBox_Adres.Size = new Size(201, 23);
            textBox_Adres.TabIndex = 0;
            // 
            // textBox_Eposta
            // 
            textBox_Eposta.Location = new Point(93, 237);
            textBox_Eposta.Name = "textBox_Eposta";
            textBox_Eposta.Size = new Size(201, 23);
            textBox_Eposta.TabIndex = 0;
            // 
            // textBox_Telefon
            // 
            textBox_Telefon.Location = new Point(93, 208);
            textBox_Telefon.Name = "textBox_Telefon";
            textBox_Telefon.Size = new Size(201, 23);
            textBox_Telefon.TabIndex = 0;
            // 
            // textBox_Soyad
            // 
            textBox_Soyad.Location = new Point(93, 121);
            textBox_Soyad.Name = "textBox_Soyad";
            textBox_Soyad.Size = new Size(201, 23);
            textBox_Soyad.TabIndex = 0;
            // 
            // textBox_Ad
            // 
            textBox_Ad.Location = new Point(93, 92);
            textBox_Ad.Name = "textBox_Ad";
            textBox_Ad.Size = new Size(201, 23);
            textBox_Ad.TabIndex = 0;
            // 
            // textBox_TcPass
            // 
            textBox_TcPass.Location = new Point(93, 63);
            textBox_TcPass.Name = "textBox_TcPass";
            textBox_TcPass.Size = new Size(201, 23);
            textBox_TcPass.TabIndex = 0;
            // 
            // textBox_UyeId
            // 
            textBox_UyeId.Location = new Point(93, 34);
            textBox_UyeId.Name = "textBox_UyeId";
            textBox_UyeId.Size = new Size(201, 23);
            textBox_UyeId.TabIndex = 0;
            // 
            // btnAra
            // 
            btnAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAra.Location = new Point(1057, 15);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 23);
            btnAra.TabIndex = 4;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // frmUyeIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1144, 676);
            Controls.Add(btnAra);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(textBox_Ara);
            Controls.Add(dataGrid_Uye);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1160, 715);
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
        private Button btnAra;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox_Telefon;
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
        private DateTimePicker dateTimePicker1;
        private Button btnTemizle;
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
        private BindingSource uyeDtoBindingSource;
        private Button btnSilinenleriGoster;
        private Button btnGeriYukle;
    }
}