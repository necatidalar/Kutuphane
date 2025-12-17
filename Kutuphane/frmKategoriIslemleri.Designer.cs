namespace Kutuphane.UI
{
    partial class frmKategoriIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKategoriIslemleri));
            groupBox1 = new GroupBox();
            btnGeriYukle = new Button();
            btnSilinenleriGoster = new Button();
            btnTemizle = new Button();
            btnSil = new Button();
            btnDuzenle = new Button();
            btnKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox_KategoriAdi = new TextBox();
            textBox_KategoriId = new TextBox();
            dataGrid_Kategori = new DataGridView();
            kategoriIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kitapKategorilerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriBindingSource = new BindingSource(components);
            btnAra = new Button();
            label3 = new Label();
            textBox_Ara = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Kategori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kategoriBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGeriYukle);
            groupBox1.Controls.Add(btnSilinenleriGoster);
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnDuzenle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_KategoriAdi);
            groupBox1.Controls.Add(textBox_KategoriId);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 527);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "📚 Kategori İşlemleri";
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.BackColor = Color.FromArgb(52, 73, 94);
            btnGeriYukle.FlatAppearance.BorderSize = 0;
            btnGeriYukle.FlatStyle = FlatStyle.Flat;
            btnGeriYukle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeriYukle.ForeColor = Color.White;
            btnGeriYukle.Location = new Point(12, 335);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(282, 30);
            btnGeriYukle.TabIndex = 8;
            btnGeriYukle.Text = "↩️ Seçili Kategoriyi Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = false;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.BackColor = Color.FromArgb(236, 240, 241);
            btnSilinenleriGoster.FlatAppearance.BorderColor = Color.FromArgb(52, 73, 94);
            btnSilinenleriGoster.FlatStyle = FlatStyle.Flat;
            btnSilinenleriGoster.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSilinenleriGoster.ForeColor = Color.FromArgb(52, 73, 94);
            btnSilinenleriGoster.Location = new Point(12, 299);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(282, 30);
            btnSilinenleriGoster.TabIndex = 7;
            btnSilinenleriGoster.Text = "🗑️ Silinen Kategorileri Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.Silver;
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTemizle.ForeColor = Color.Black;
            btnTemizle.Location = new Point(12, 227);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(282, 35);
            btnTemizle.TabIndex = 6;
            btnTemizle.Text = "\U0001f9f9 TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 57, 43);
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(12, 186);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(282, 35);
            btnSil.TabIndex = 5;
            btnSil.Text = "❌ SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.FromArgb(52, 152, 219);
            btnDuzenle.FlatAppearance.BorderSize = 0;
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDuzenle.ForeColor = Color.White;
            btnDuzenle.Location = new Point(12, 145);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(282, 35);
            btnDuzenle.TabIndex = 4;
            btnDuzenle.Text = "✏️ DÜZENLE";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(39, 174, 96);
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(12, 104);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(282, 35);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "💾 KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(-3, 64);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 14;
            label1.Text = "Kategori Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 14;
            label2.Text = "Kategori Id:";
            // 
            // textBox_KategoriAdi
            // 
            textBox_KategoriAdi.Font = new Font("Segoe UI", 10F);
            textBox_KategoriAdi.Location = new Point(93, 61);
            textBox_KategoriAdi.Name = "textBox_KategoriAdi";
            textBox_KategoriAdi.Size = new Size(201, 25);
            textBox_KategoriAdi.TabIndex = 2;
            // 
            // textBox_KategoriId
            // 
            textBox_KategoriId.Enabled = false;
            textBox_KategoriId.Font = new Font("Segoe UI", 10F);
            textBox_KategoriId.Location = new Point(93, 32);
            textBox_KategoriId.Name = "textBox_KategoriId";
            textBox_KategoriId.ReadOnly = true;
            textBox_KategoriId.Size = new Size(201, 25);
            textBox_KategoriId.TabIndex = 1;
            // 
            // dataGrid_Kategori
            // 
            dataGrid_Kategori.AllowUserToDeleteRows = false;
            dataGrid_Kategori.AllowUserToOrderColumns = true;
            dataGrid_Kategori.AllowUserToResizeRows = false;
            dataGrid_Kategori.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGrid_Kategori.AutoGenerateColumns = false;
            dataGrid_Kategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Kategori.BackgroundColor = Color.White;
            dataGrid_Kategori.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid_Kategori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Kategori.ColumnHeadersHeight = 30;
            dataGrid_Kategori.Columns.AddRange(new DataGridViewColumn[] { kategoriIdDataGridViewTextBoxColumn, kategoriAdiDataGridViewTextBoxColumn, kitapKategorilerDataGridViewTextBoxColumn });
            dataGrid_Kategori.DataSource = kategoriBindingSource;
            dataGrid_Kategori.EnableHeadersVisualStyles = false;
            dataGrid_Kategori.GridColor = Color.LightGray;
            dataGrid_Kategori.Location = new Point(318, 51);
            dataGrid_Kategori.MultiSelect = false;
            dataGrid_Kategori.Name = "dataGrid_Kategori";
            dataGrid_Kategori.RowHeadersVisible = false;
            dataGrid_Kategori.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGrid_Kategori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Kategori.Size = new Size(454, 488);
            dataGrid_Kategori.TabIndex = 1;
            dataGrid_Kategori.SelectionChanged += dataGrid_Kategori_SelectionChanged;
            // 
            // kategoriIdDataGridViewTextBoxColumn
            // 
            kategoriIdDataGridViewTextBoxColumn.DataPropertyName = "KategoriId";
            kategoriIdDataGridViewTextBoxColumn.HeaderText = "ID";
            kategoriIdDataGridViewTextBoxColumn.Name = "kategoriIdDataGridViewTextBoxColumn";
            kategoriIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // kategoriAdiDataGridViewTextBoxColumn
            // 
            kategoriAdiDataGridViewTextBoxColumn.DataPropertyName = "KategoriAdi";
            kategoriAdiDataGridViewTextBoxColumn.HeaderText = "Kategori Adı";
            kategoriAdiDataGridViewTextBoxColumn.Name = "kategoriAdiDataGridViewTextBoxColumn";
            // 
            // kitapKategorilerDataGridViewTextBoxColumn
            // 
            kitapKategorilerDataGridViewTextBoxColumn.DataPropertyName = "KitapKategoriler";
            kitapKategorilerDataGridViewTextBoxColumn.HeaderText = "KitapKategoriler";
            kitapKategorilerDataGridViewTextBoxColumn.Name = "kitapKategorilerDataGridViewTextBoxColumn";
            kitapKategorilerDataGridViewTextBoxColumn.Visible = false;
            // 
            // kategoriBindingSource
            // 
            kategoriBindingSource.DataSource = typeof(Model.Entity.Kategori);
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.FromArgb(52, 152, 219);
            btnAra.FlatAppearance.BorderSize = 0;
            btnAra.FlatStyle = FlatStyle.Flat;
            btnAra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAra.ForeColor = Color.White;
            btnAra.Location = new Point(708, 12);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(64, 30);
            btnAra.TabIndex = 10;
            btnAra.Text = "🔎 ARA";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(318, 19);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 6;
            label3.Text = "Arama:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Font = new Font("Segoe UI", 10F);
            textBox_Ara.Location = new Point(373, 15);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Kategori adı ile arayın";
            textBox_Ara.Size = new Size(329, 25);
            textBox_Ara.TabIndex = 9;
            // 
            // frmKategoriIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 551);
            Controls.Add(btnAra);
            Controls.Add(label3);
            Controls.Add(textBox_Ara);
            Controls.Add(dataGrid_Kategori);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 590);
            Name = "frmKategoriIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Kategori İşlemleri";
            Load += frmKategori_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Kategori).EndInit();
            ((System.ComponentModel.ISupportInitialize)kategoriBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnGeriYukle;
        private Button btnSilinenleriGoster;
        private Button btnTemizle;
        private Button btnSil;
        private Button btnDuzenle;
        private Button btnKaydet;
        private Label label2;
        private TextBox textBox_KategoriId;
        private Label label1;
        private TextBox textBox_KategoriAdi;
        private DataGridView dataGrid_Kategori;
        private BindingSource kategoriBindingSource;
        private Button btnAra;
        private Label label3;
        private TextBox textBox_Ara;
        private DataGridViewTextBoxColumn kategoriIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapKategorilerDataGridViewTextBoxColumn;
    }
}