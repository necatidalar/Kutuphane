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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKategoriIslemleri));
            groupBox1 = new GroupBox();
            btnTemizle = new Button();
            btnSil = new Button();
            btnDuzenle = new Button();
            btnKaydet = new Button();
            btnGeriYukle = new Button();
            btnSilinenleriGoster = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox_KategoriAdi = new TextBox();
            textBox_KategoriId = new TextBox();
            label_txtAra = new Label();
            textBox_Ara = new TextBox();
            dataGrid_Kategori = new DataGridView();
            kategoriBindingSource = new BindingSource(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Kategori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kategoriBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnDuzenle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(btnGeriYukle);
            groupBox1.Controls.Add(btnSilinenleriGoster);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_KategoriAdi);
            groupBox1.Controls.Add(textBox_KategoriId);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(41, 128, 185);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 372);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Tag = "KATEGORI_LISTELE";
            groupBox1.Text = "📚 Kategori İşlemleri";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(149, 165, 166);
            btnTemizle.Cursor = Cursors.Hand;
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(18, 230);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(265, 38);
            btnTemizle.TabIndex = 6;
            btnTemizle.Tag = "KATEGORI_EKLE";
            btnTemizle.Text = "\U0001f9f9 TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 57, 43);
            btnSil.Cursor = Cursors.Hand;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(18, 186);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(265, 38);
            btnSil.TabIndex = 5;
            btnSil.Tag = "KATEGORI_SIL";
            btnSil.Text = "❌ SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.FromArgb(52, 152, 219);
            btnDuzenle.Cursor = Cursors.Hand;
            btnDuzenle.FlatAppearance.BorderSize = 0;
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDuzenle.ForeColor = Color.White;
            btnDuzenle.Location = new Point(18, 142);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(265, 38);
            btnDuzenle.TabIndex = 4;
            btnDuzenle.Tag = "KATEGORI_GUNCELLE";
            btnDuzenle.Text = "✏️ DÜZENLE";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(39, 174, 96);
            btnKaydet.Cursor = Cursors.Hand;
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(18, 98);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(265, 38);
            btnKaydet.TabIndex = 3;
            btnKaydet.Tag = "KATEGORI_EKLE";
            btnKaydet.Text = "💾 KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.BackColor = Color.FromArgb(52, 73, 94);
            btnGeriYukle.Cursor = Cursors.Hand;
            btnGeriYukle.FlatAppearance.BorderSize = 0;
            btnGeriYukle.FlatStyle = FlatStyle.Flat;
            btnGeriYukle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeriYukle.ForeColor = Color.White;
            btnGeriYukle.Location = new Point(18, 318);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(265, 38);
            btnGeriYukle.TabIndex = 8;
            btnGeriYukle.Tag = "KATEGORI_SIL";
            btnGeriYukle.Text = "↩️ Seçili Kategoriyi Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = false;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.BackColor = Color.FromArgb(236, 240, 241);
            btnSilinenleriGoster.Cursor = Cursors.Hand;
            btnSilinenleriGoster.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnSilinenleriGoster.FlatStyle = FlatStyle.Flat;
            btnSilinenleriGoster.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSilinenleriGoster.ForeColor = Color.FromArgb(41, 128, 185);
            btnSilinenleriGoster.Location = new Point(18, 274);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(265, 38);
            btnSilinenleriGoster.TabIndex = 7;
            btnSilinenleriGoster.Tag = "KATEGORI_SIL";
            btnSilinenleriGoster.Text = "🗑️ Silinen Kategorileri Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(6, 64);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 14;
            label1.Text = "Kategori Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(15, 35);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 14;
            label2.Text = "Kategori Id:";
            // 
            // textBox_KategoriAdi
            // 
            textBox_KategoriAdi.Font = new Font("Segoe UI", 10F);
            textBox_KategoriAdi.Location = new Point(102, 61);
            textBox_KategoriAdi.Name = "textBox_KategoriAdi";
            textBox_KategoriAdi.Size = new Size(181, 25);
            textBox_KategoriAdi.TabIndex = 2;
            // 
            // textBox_KategoriId
            // 
            textBox_KategoriId.BackColor = Color.FromArgb(236, 240, 241);
            textBox_KategoriId.Enabled = false;
            textBox_KategoriId.Font = new Font("Segoe UI", 10F);
            textBox_KategoriId.Location = new Point(102, 32);
            textBox_KategoriId.Name = "textBox_KategoriId";
            textBox_KategoriId.ReadOnly = true;
            textBox_KategoriId.Size = new Size(181, 25);
            textBox_KategoriId.TabIndex = 1;
            // 
            // label_txtAra
            // 
            label_txtAra.AutoSize = true;
            label_txtAra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label_txtAra.ForeColor = Color.FromArgb(64, 64, 64);
            label_txtAra.Location = new Point(325, 27);
            label_txtAra.Name = "label_txtAra";
            label_txtAra.Size = new Size(51, 17);
            label_txtAra.TabIndex = 6;
            label_txtAra.Tag = "KATEGORI_LISTELE";
            label_txtAra.Text = "Arama:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Font = new Font("Segoe UI", 10F);
            textBox_Ara.Location = new Point(382, 24);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Kategori adı ile arayın...";
            textBox_Ara.Size = new Size(250, 25);
            textBox_Ara.TabIndex = 9;
            textBox_Ara.Tag = "KATEGORI_LISTELE";
            textBox_Ara.TextChanged += textBox_Ara_TextChanged;
            // 
            // dataGrid_Kategori
            // 
            dataGrid_Kategori.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGrid_Kategori.AutoGenerateColumns = false;
            dataGrid_Kategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Kategori.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewCheckBoxColumn1, dataGridViewTextBoxColumn3 });
            dataGrid_Kategori.DataSource = kategoriBindingSource;
            dataGrid_Kategori.Location = new Point(318, 55);
            dataGrid_Kategori.Name = "dataGrid_Kategori";
            dataGrid_Kategori.Size = new Size(567, 484);
            dataGrid_Kategori.TabIndex = 10;
            dataGrid_Kategori.CellFormatting += dataGrid_Kategori_CellFormatting;
            dataGrid_Kategori.ColumnHeaderMouseClick += dataGrid_Kategori_ColumnHeaderMouseClick;
            dataGrid_Kategori.SelectionChanged += dataGrid_Kategori_SelectionChanged;
            // 
            // kategoriBindingSource
            // 
            kategoriBindingSource.DataSource = typeof(Model.Entity.Kategori);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "KategoriId";
            dataGridViewTextBoxColumn1.HeaderText = "KategoriId";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "KategoriAdi";
            dataGridViewTextBoxColumn2.HeaderText = "Kategori Adı";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.DataPropertyName = "AktifMi";
            dataGridViewCheckBoxColumn1.HeaderText = "AktifMi";
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "KitapKategoriler";
            dataGridViewTextBoxColumn3.HeaderText = "KitapKategoriler";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Visible = false;
            // 
            // frmKategoriIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(897, 551);
            Controls.Add(dataGrid_Kategori);
            Controls.Add(label_txtAra);
            Controls.Add(textBox_Ara);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 590);
            Name = "frmKategoriIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "KATEGORI_LISTELE";
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
        private Label label2;
        private TextBox textBox_KategoriId;
        private Label label1;
        private TextBox textBox_KategoriAdi;
        private Label label_txtAra;
        private TextBox textBox_Ara;
        private Button btnTemizle;
        private Button btnSil;
        private Button btnDuzenle;
        private Button btnKaydet;
        private DataGridView dataGrid_Kategori;
        private DataGridViewTextBoxColumn kategoriIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriAdiDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn kitapKategorilerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private BindingSource kategoriBindingSource;
    }
}