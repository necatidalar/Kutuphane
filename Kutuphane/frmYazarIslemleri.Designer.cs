namespace Kutuphane.UI
{
    partial class frmYazarIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYazarIslemleri));
            btnAra = new Button();
            label3 = new Label();
            textBox_Ara = new TextBox();
            groupBox1 = new GroupBox();
            textBox_Soyad = new TextBox();
            dateTimePicker_OlumTarihi = new DateTimePicker();
            dateTimePicker_DogumTarihi = new DateTimePicker();
            btnGeriYukle = new Button();
            btnSilinenleriGoster = new Button();
            btnTemizle = new Button();
            btnSil = new Button();
            btnDuzenle = new Button();
            label6 = new Label();
            btnKaydet = new Button();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox_Ad = new TextBox();
            textBox_YazarId = new TextBox();
            dataGrid_Yazar = new DataGridView();
            yazarIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dogumTarihiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            olumTarihiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adSoyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yazarDtoBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Yazar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yazarDtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAra
            // 
            btnAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAra.Location = new Point(822, 12);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 23);
            btnAra.TabIndex = 13;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(558, 16);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 11;
            label3.Text = "Ara:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_Ara.Location = new Point(592, 13);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Yazarın adı ya da soyadıyla arayın";
            textBox_Ara.Size = new Size(224, 23);
            textBox_Ara.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_Soyad);
            groupBox1.Controls.Add(dateTimePicker_OlumTarihi);
            groupBox1.Controls.Add(dateTimePicker_DogumTarihi);
            groupBox1.Controls.Add(btnGeriYukle);
            groupBox1.Controls.Add(btnSilinenleriGoster);
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnDuzenle);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_Ad);
            groupBox1.Controls.Add(textBox_YazarId);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 374);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yazar İşlemleri";
            // 
            // textBox_Soyad
            // 
            textBox_Soyad.Location = new Point(93, 90);
            textBox_Soyad.Name = "textBox_Soyad";
            textBox_Soyad.Size = new Size(201, 23);
            textBox_Soyad.TabIndex = 3;
            // 
            // dateTimePicker_OlumTarihi
            // 
            dateTimePicker_OlumTarihi.Location = new Point(93, 148);
            dateTimePicker_OlumTarihi.Name = "dateTimePicker_OlumTarihi";
            dateTimePicker_OlumTarihi.Size = new Size(201, 23);
            dateTimePicker_OlumTarihi.TabIndex = 5;
            // 
            // dateTimePicker_DogumTarihi
            // 
            dateTimePicker_DogumTarihi.Location = new Point(93, 119);
            dateTimePicker_DogumTarihi.Name = "dateTimePicker_DogumTarihi";
            dateTimePicker_DogumTarihi.Size = new Size(201, 23);
            dateTimePicker_DogumTarihi.TabIndex = 4;
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.Location = new Point(118, 332);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(150, 25);
            btnGeriYukle.TabIndex = 11;
            btnGeriYukle.Text = "Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = true;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.Location = new Point(118, 301);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(150, 25);
            btnSilinenleriGoster.TabIndex = 10;
            btnSilinenleriGoster.Text = "Silinenleri Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = true;
            btnSilinenleriGoster.Visible = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(118, 270);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(150, 25);
            btnTemizle.TabIndex = 9;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(118, 239);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(150, 25);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(118, 208);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(150, 25);
            btnDuzenle.TabIndex = 7;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 151);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 14;
            label6.Text = "Ölüm Tarihi:";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(118, 177);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(150, 25);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 122);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 14;
            label4.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 93);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 14;
            label5.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 64);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 14;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 35);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 14;
            label2.Text = "Yazar Id:";
            // 
            // textBox_Ad
            // 
            textBox_Ad.Location = new Point(93, 61);
            textBox_Ad.Name = "textBox_Ad";
            textBox_Ad.Size = new Size(201, 23);
            textBox_Ad.TabIndex = 2;
            // 
            // textBox_YazarId
            // 
            textBox_YazarId.Enabled = false;
            textBox_YazarId.Location = new Point(93, 32);
            textBox_YazarId.Name = "textBox_YazarId";
            textBox_YazarId.Size = new Size(201, 23);
            textBox_YazarId.TabIndex = 1;
            // 
            // dataGrid_Yazar
            // 
            dataGrid_Yazar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Yazar.AutoGenerateColumns = false;
            dataGrid_Yazar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Yazar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Yazar.Columns.AddRange(new DataGridViewColumn[] { yazarIdDataGridViewTextBoxColumn, adDataGridViewTextBoxColumn, soyadDataGridViewTextBoxColumn, dogumTarihiDataGridViewTextBoxColumn, olumTarihiDataGridViewTextBoxColumn, adSoyadDataGridViewTextBoxColumn, yasDataGridViewTextBoxColumn });
            dataGrid_Yazar.DataSource = yazarDtoBindingSource;
            dataGrid_Yazar.Location = new Point(318, 41);
            dataGrid_Yazar.Name = "dataGrid_Yazar";
            dataGrid_Yazar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Yazar.Size = new Size(579, 488);
            dataGrid_Yazar.TabIndex = 14;
            dataGrid_Yazar.SelectionChanged += dataGrid_Yazar_SelectionChanged;
            // 
            // yazarIdDataGridViewTextBoxColumn
            // 
            yazarIdDataGridViewTextBoxColumn.DataPropertyName = "YazarId";
            yazarIdDataGridViewTextBoxColumn.HeaderText = "YazarId";
            yazarIdDataGridViewTextBoxColumn.Name = "yazarIdDataGridViewTextBoxColumn";
            yazarIdDataGridViewTextBoxColumn.Visible = false;
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
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            dogumTarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            // 
            // olumTarihiDataGridViewTextBoxColumn
            // 
            olumTarihiDataGridViewTextBoxColumn.DataPropertyName = "OlumTarihi";
            olumTarihiDataGridViewTextBoxColumn.HeaderText = "Ölüm Tarihi";
            olumTarihiDataGridViewTextBoxColumn.Name = "olumTarihiDataGridViewTextBoxColumn";
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            adSoyadDataGridViewTextBoxColumn.DataPropertyName = "AdSoyad";
            adSoyadDataGridViewTextBoxColumn.HeaderText = "AdSoyad";
            adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            adSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            adSoyadDataGridViewTextBoxColumn.Visible = false;
            // 
            // yasDataGridViewTextBoxColumn
            // 
            yasDataGridViewTextBoxColumn.DataPropertyName = "Yas";
            yasDataGridViewTextBoxColumn.HeaderText = "Yaşı";
            yasDataGridViewTextBoxColumn.Name = "yasDataGridViewTextBoxColumn";
            yasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yazarDtoBindingSource
            // 
            yazarDtoBindingSource.DataSource = typeof(Model.DTO.YazarDto);
            // 
            // frmYazarIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 541);
            Controls.Add(dataGrid_Yazar);
            Controls.Add(btnAra);
            Controls.Add(label3);
            Controls.Add(textBox_Ara);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(700, 580);
            Name = "frmYazarIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Yazar İşlemleri";
            Load += frmYazarIslemleri_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Yazar).EndInit();
            ((System.ComponentModel.ISupportInitialize)yazarDtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAra;
        private Label label3;
        private TextBox textBox_Ara;
        private GroupBox groupBox1;
        private Button btnGeriYukle;
        private Button btnSilinenleriGoster;
        private Button btnTemizle;
        private Button btnSil;
        private Button btnDuzenle;
        private Button btnKaydet;
        private Label label1;
        private Label label2;
        private TextBox textBox_Ad;
        private TextBox textBox_YazarId;
        private DateTimePicker dateTimePicker_DogumTarihi;
        private Label label4;
        private TextBox textBox_Soyad;
        private Label label5;
        private DataGridView dataGrid_Yazar;
        private DateTimePicker dateTimePicker_OlumTarihi;
        private Label label6;
        private BindingSource yazarDtoBindingSource;
        private DataGridViewTextBoxColumn yazarIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn olumTarihiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yasDataGridViewTextBoxColumn;
    }
}