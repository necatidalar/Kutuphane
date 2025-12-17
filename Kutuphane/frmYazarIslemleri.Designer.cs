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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            btnAra.BackColor = Color.FromArgb(41, 128, 185);
            btnAra.FlatAppearance.BorderSize = 0;
            btnAra.FlatStyle = FlatStyle.Flat;
            btnAra.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAra.ForeColor = Color.White;
            btnAra.Location = new Point(822, 12);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 25);
            btnAra.TabIndex = 13;
            btnAra.Text = "🔍 ARA";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(556, 15);
            label3.Name = "label3";
            label3.Size = new Size(33, 19);
            label3.TabIndex = 11;
            label3.Text = "Ara:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Font = new Font("Segoe UI", 10F);
            textBox_Ara.Location = new Point(592, 13);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Yazarın adı ya da soyadıyla arayın";
            textBox_Ara.Size = new Size(224, 25);
            textBox_Ara.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
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
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 517);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "✍️ Yazar İşlemleri";
            // 
            // textBox_Soyad
            // 
            textBox_Soyad.Font = new Font("Segoe UI", 10F);
            textBox_Soyad.Location = new Point(93, 90);
            textBox_Soyad.Name = "textBox_Soyad";
            textBox_Soyad.Size = new Size(201, 25);
            textBox_Soyad.TabIndex = 3;
            // 
            // dateTimePicker_OlumTarihi
            // 
            dateTimePicker_OlumTarihi.Font = new Font("Segoe UI", 10F);
            dateTimePicker_OlumTarihi.Format = DateTimePickerFormat.Short;
            dateTimePicker_OlumTarihi.Location = new Point(93, 150);
            dateTimePicker_OlumTarihi.Name = "dateTimePicker_OlumTarihi";
            dateTimePicker_OlumTarihi.Size = new Size(201, 25);
            dateTimePicker_OlumTarihi.TabIndex = 5;
            // 
            // dateTimePicker_DogumTarihi
            // 
            dateTimePicker_DogumTarihi.Font = new Font("Segoe UI", 10F);
            dateTimePicker_DogumTarihi.Format = DateTimePickerFormat.Short;
            dateTimePicker_DogumTarihi.Location = new Point(93, 119);
            dateTimePicker_DogumTarihi.Name = "dateTimePicker_DogumTarihi";
            dateTimePicker_DogumTarihi.Size = new Size(201, 25);
            dateTimePicker_DogumTarihi.TabIndex = 4;
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.BackColor = Color.FromArgb(39, 174, 96);
            btnGeriYukle.FlatAppearance.BorderSize = 0;
            btnGeriYukle.FlatStyle = FlatStyle.Flat;
            btnGeriYukle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGeriYukle.ForeColor = Color.White;
            btnGeriYukle.Location = new Point(118, 396);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(150, 35);
            btnGeriYukle.TabIndex = 11;
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
            btnSilinenleriGoster.Location = new Point(118, 355);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(150, 35);
            btnSilinenleriGoster.TabIndex = 10;
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
            btnTemizle.Location = new Point(118, 314);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(150, 35);
            btnTemizle.TabIndex = 9;
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
            btnSil.Location = new Point(118, 273);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(150, 35);
            btnSil.TabIndex = 8;
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
            btnDuzenle.Location = new Point(118, 232);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(150, 35);
            btnDuzenle.TabIndex = 7;
            btnDuzenle.Text = "✏️ Düzenle";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(8, 151);
            label6.Name = "label6";
            label6.Size = new Size(86, 19);
            label6.TabIndex = 14;
            label6.Text = "Ölüm Tarihi:";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(39, 174, 96);
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(118, 191);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(150, 35);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "➕ Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(0, 122);
            label4.Name = "label4";
            label4.Size = new Size(97, 19);
            label4.TabIndex = 14;
            label4.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(41, 93);
            label5.Name = "label5";
            label5.Size = new Size(50, 19);
            label5.TabIndex = 14;
            label5.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(62, 64);
            label1.Name = "label1";
            label1.Size = new Size(29, 19);
            label1.TabIndex = 14;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(27, 35);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 14;
            label2.Text = "Yazar Id:";
            // 
            // textBox_Ad
            // 
            textBox_Ad.Font = new Font("Segoe UI", 10F);
            textBox_Ad.Location = new Point(93, 61);
            textBox_Ad.Name = "textBox_Ad";
            textBox_Ad.Size = new Size(201, 25);
            textBox_Ad.TabIndex = 2;
            // 
            // textBox_YazarId
            // 
            textBox_YazarId.Enabled = false;
            textBox_YazarId.Font = new Font("Segoe UI", 10F);
            textBox_YazarId.Location = new Point(93, 32);
            textBox_YazarId.Name = "textBox_YazarId";
            textBox_YazarId.Size = new Size(201, 25);
            textBox_YazarId.TabIndex = 1;
            // 
            // dataGrid_Yazar
            // 
            dataGrid_Yazar.AllowUserToAddRows = false;
            dataGrid_Yazar.AllowUserToDeleteRows = false;
            dataGrid_Yazar.AllowUserToResizeRows = false;
            dataGrid_Yazar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGrid_Yazar.AutoGenerateColumns = false;
            dataGrid_Yazar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Yazar.BackgroundColor = Color.White;
            dataGrid_Yazar.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid_Yazar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Yazar.ColumnHeadersHeight = 30;
            dataGrid_Yazar.Columns.AddRange(new DataGridViewColumn[] { yazarIdDataGridViewTextBoxColumn, adDataGridViewTextBoxColumn, soyadDataGridViewTextBoxColumn, dogumTarihiDataGridViewTextBoxColumn, olumTarihiDataGridViewTextBoxColumn, adSoyadDataGridViewTextBoxColumn, yasDataGridViewTextBoxColumn });
            dataGrid_Yazar.DataSource = yazarDtoBindingSource;
            dataGrid_Yazar.EnableHeadersVisualStyles = false;
            dataGrid_Yazar.GridColor = Color.LightGray;
            dataGrid_Yazar.Location = new Point(318, 41);
            dataGrid_Yazar.Name = "dataGrid_Yazar";
            dataGrid_Yazar.ReadOnly = true;
            dataGrid_Yazar.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(170, 204, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGrid_Yazar.RowsDefaultCellStyle = dataGridViewCellStyle2;
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
            yazarIdDataGridViewTextBoxColumn.ReadOnly = true;
            yazarIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // adDataGridViewTextBoxColumn
            // 
            adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            adDataGridViewTextBoxColumn.HeaderText = "Adı";
            adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            soyadDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            soyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            dogumTarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            dogumTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // olumTarihiDataGridViewTextBoxColumn
            // 
            olumTarihiDataGridViewTextBoxColumn.DataPropertyName = "OlumTarihi";
            olumTarihiDataGridViewTextBoxColumn.HeaderText = "Ölüm Tarihi";
            olumTarihiDataGridViewTextBoxColumn.Name = "olumTarihiDataGridViewTextBoxColumn";
            olumTarihiDataGridViewTextBoxColumn.ReadOnly = true;
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
            BackColor = Color.White;
            ClientSize = new Size(909, 541);
            Controls.Add(dataGrid_Yazar);
            Controls.Add(btnAra);
            Controls.Add(label3);
            Controls.Add(textBox_Ara);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(925, 580);
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