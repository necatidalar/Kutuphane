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
            textBox_Ara = new TextBox();
            groupBox1 = new GroupBox();
            textBox_Soyad = new TextBox();
            dateTimePicker_OlumTarihi = new DateTimePicker();
            dateTimePicker_DogumTarihi = new DateTimePicker();
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
            yazarDtoBindingSource = new BindingSource(components);
            label_txtAra = new Label();
            dataGrid_Yazar = new DataGridView();
            yazarIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dogumTarihiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            olumTarihiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adSoyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSilinenleriGoster = new Button();
            btnGeriYukle = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yazarDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Yazar).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_Ara
            // 
            textBox_Ara.Font = new Font("Segoe UI", 10F);
            textBox_Ara.Location = new Point(453, 17);
            textBox_Ara.Margin = new Padding(3, 4, 3, 4);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Yazarın adı ya da soyadıyla arayın";
            textBox_Ara.Size = new Size(348, 30);
            textBox_Ara.TabIndex = 12;
            textBox_Ara.TextChanged += textBox_Ara_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(41, 128, 185);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(353, 632);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "✍️ Yazar İşlemleri";
            // 
            // textBox_Soyad
            // 
            textBox_Soyad.Font = new Font("Segoe UI", 10F);
            textBox_Soyad.Location = new Point(124, 100);
            textBox_Soyad.Margin = new Padding(3, 4, 3, 4);
            textBox_Soyad.Name = "textBox_Soyad";
            textBox_Soyad.Size = new Size(217, 30);
            textBox_Soyad.TabIndex = 3;
            // 
            // dateTimePicker_OlumTarihi
            // 
            dateTimePicker_OlumTarihi.Font = new Font("Segoe UI", 10F);
            dateTimePicker_OlumTarihi.Format = DateTimePickerFormat.Short;
            dateTimePicker_OlumTarihi.Location = new Point(124, 180);
            dateTimePicker_OlumTarihi.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker_OlumTarihi.Name = "dateTimePicker_OlumTarihi";
            dateTimePicker_OlumTarihi.Size = new Size(217, 30);
            dateTimePicker_OlumTarihi.TabIndex = 5;
            // 
            // dateTimePicker_DogumTarihi
            // 
            dateTimePicker_DogumTarihi.Font = new Font("Segoe UI", 10F);
            dateTimePicker_DogumTarihi.Format = DateTimePickerFormat.Short;
            dateTimePicker_DogumTarihi.Location = new Point(124, 139);
            dateTimePicker_DogumTarihi.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker_DogumTarihi.Name = "dateTimePicker_DogumTarihi";
            dateTimePicker_DogumTarihi.Size = new Size(217, 30);
            dateTimePicker_DogumTarihi.TabIndex = 4;
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
            btnSil.Location = new Point(14, 135);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(303, 51);
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
            btnDuzenle.Location = new Point(14, 76);
            btnDuzenle.Margin = new Padding(3, 4, 3, 4);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(303, 51);
            btnDuzenle.TabIndex = 7;
            btnDuzenle.Text = "✏️ Düzenle";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(11, 180);
            label6.Name = "label6";
            label6.Size = new Size(101, 23);
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
            btnKaydet.Location = new Point(14, 17);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(303, 51);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "➕ Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(2, 145);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 14;
            label4.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(57, 103);
            label5.Name = "label5";
            label5.Size = new Size(61, 23);
            label5.TabIndex = 14;
            label5.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(83, 64);
            label1.Name = "label1";
            label1.Size = new Size(35, 23);
            label1.TabIndex = 14;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(44, 26);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 14;
            label2.Text = "Yazar Id:";
            // 
            // textBox_Ad
            // 
            textBox_Ad.Font = new Font("Segoe UI", 10F);
            textBox_Ad.Location = new Point(124, 61);
            textBox_Ad.Margin = new Padding(3, 4, 3, 4);
            textBox_Ad.Name = "textBox_Ad";
            textBox_Ad.Size = new Size(217, 30);
            textBox_Ad.TabIndex = 2;
            // 
            // textBox_YazarId
            // 
            textBox_YazarId.Enabled = false;
            textBox_YazarId.Font = new Font("Segoe UI", 10F);
            textBox_YazarId.Location = new Point(124, 23);
            textBox_YazarId.Margin = new Padding(3, 4, 3, 4);
            textBox_YazarId.Name = "textBox_YazarId";
            textBox_YazarId.Size = new Size(217, 30);
            textBox_YazarId.TabIndex = 1;
            // 
            // yazarDtoBindingSource
            // 
            yazarDtoBindingSource.DataSource = typeof(Model.DTO.YazarDto);
            // 
            // label_txtAra
            // 
            label_txtAra.AutoSize = true;
            label_txtAra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label_txtAra.ForeColor = Color.FromArgb(64, 64, 64);
            label_txtAra.Location = new Point(387, 21);
            label_txtAra.Name = "label_txtAra";
            label_txtAra.Size = new Size(64, 23);
            label_txtAra.TabIndex = 22;
            label_txtAra.Text = "Arama:";
            // 
            // dataGrid_Yazar
            // 
            dataGrid_Yazar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Yazar.AutoGenerateColumns = false;
            dataGrid_Yazar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Yazar.Columns.AddRange(new DataGridViewColumn[] { yazarIdDataGridViewTextBoxColumn, adDataGridViewTextBoxColumn, soyadDataGridViewTextBoxColumn, dogumTarihiDataGridViewTextBoxColumn, olumTarihiDataGridViewTextBoxColumn, adSoyadDataGridViewTextBoxColumn, yasDataGridViewTextBoxColumn });
            dataGrid_Yazar.DataSource = yazarDtoBindingSource;
            dataGrid_Yazar.Location = new Point(385, 55);
            dataGrid_Yazar.Margin = new Padding(3, 4, 3, 4);
            dataGrid_Yazar.Name = "dataGrid_Yazar";
            dataGrid_Yazar.RowHeadersWidth = 51;
            dataGrid_Yazar.Size = new Size(640, 589);
            dataGrid_Yazar.TabIndex = 23;
            dataGrid_Yazar.ColumnHeaderMouseClick += dataGrid_Yazar_ColumnHeaderMouseClick;
            dataGrid_Yazar.SelectionChanged += dataGrid_Yazar_SelectionChanged;
            // 
            // yazarIdDataGridViewTextBoxColumn
            // 
            yazarIdDataGridViewTextBoxColumn.DataPropertyName = "YazarId";
            yazarIdDataGridViewTextBoxColumn.HeaderText = "YazarId";
            yazarIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            yazarIdDataGridViewTextBoxColumn.Name = "yazarIdDataGridViewTextBoxColumn";
            yazarIdDataGridViewTextBoxColumn.Visible = false;
            yazarIdDataGridViewTextBoxColumn.Width = 125;
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
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            dogumTarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            dogumTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            dogumTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // olumTarihiDataGridViewTextBoxColumn
            // 
            olumTarihiDataGridViewTextBoxColumn.DataPropertyName = "OlumTarihi";
            olumTarihiDataGridViewTextBoxColumn.HeaderText = "Ölüm Tarihi";
            olumTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            olumTarihiDataGridViewTextBoxColumn.Name = "olumTarihiDataGridViewTextBoxColumn";
            olumTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            adSoyadDataGridViewTextBoxColumn.DataPropertyName = "AdSoyad";
            adSoyadDataGridViewTextBoxColumn.HeaderText = "AdSoyad";
            adSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            adSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            adSoyadDataGridViewTextBoxColumn.Visible = false;
            adSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // yasDataGridViewTextBoxColumn
            // 
            yasDataGridViewTextBoxColumn.DataPropertyName = "Yas";
            yasDataGridViewTextBoxColumn.HeaderText = "Yaşı";
            yasDataGridViewTextBoxColumn.MinimumWidth = 6;
            yasDataGridViewTextBoxColumn.Name = "yasDataGridViewTextBoxColumn";
            yasDataGridViewTextBoxColumn.ReadOnly = true;
            yasDataGridViewTextBoxColumn.Width = 125;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox_Soyad);
            panel1.Controls.Add(textBox_YazarId);
            panel1.Controls.Add(dateTimePicker_OlumTarihi);
            panel1.Controls.Add(textBox_Ad);
            panel1.Controls.Add(dateTimePicker_DogumTarihi);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 219);
            panel1.TabIndex = 24;
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
            flowLayoutPanel1.Location = new Point(3, 248);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(11, 13, 11, 13);
            flowLayoutPanel1.Size = new Size(347, 380);
            flowLayoutPanel1.TabIndex = 24;
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
            btnSilinenleriGoster.TabIndex = 10;
            btnSilinenleriGoster.Text = "🗑️ Silinen Yazarları Göster";
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
            btnGeriYukle.TabIndex = 11;
            btnGeriYukle.Text = "↩️ Seçili Yazarı Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = false;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // frmYazarIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1039, 656);
            Controls.Add(dataGrid_Yazar);
            Controls.Add(label_txtAra);
            Controls.Add(textBox_Ara);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmYazarIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Yazar İşlemleri";
            Load += frmYazarIslemleri_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)yazarDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Yazar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private TextBox textBox_Ara;
        private GroupBox groupBox1;
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
        private DateTimePicker dateTimePicker_OlumTarihi;
        private Label label6;
        private BindingSource yazarDtoBindingSource;
        private Label label_txtAra;
        private DataGridView dataGrid_Yazar;
        private DataGridViewTextBoxColumn yazarIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn olumTarihiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yasDataGridViewTextBoxColumn;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSilinenleriGoster;
        private Button btnGeriYukle;
    }
}