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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 320);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kategori İşlemleri";
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.Location = new Point(118, 256);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(150, 25);
            btnGeriYukle.TabIndex = 8;
            btnGeriYukle.Text = "Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = true;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.Location = new Point(118, 225);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(150, 25);
            btnSilinenleriGoster.TabIndex = 7;
            btnSilinenleriGoster.Text = "Silinenleri Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = true;
            btnSilinenleriGoster.Visible = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(118, 194);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(150, 25);
            btnTemizle.TabIndex = 6;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(118, 163);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(150, 25);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(118, 132);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(150, 25);
            btnDuzenle.TabIndex = 4;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(118, 101);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(150, 25);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 14;
            label1.Text = "Kategori Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 35);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 14;
            label2.Text = "Kategori Id:";
            // 
            // textBox_KategoriAdi
            // 
            textBox_KategoriAdi.Location = new Point(93, 61);
            textBox_KategoriAdi.Name = "textBox_KategoriAdi";
            textBox_KategoriAdi.Size = new Size(201, 23);
            textBox_KategoriAdi.TabIndex = 2;
            // 
            // textBox_KategoriId
            // 
            textBox_KategoriId.Enabled = false;
            textBox_KategoriId.Location = new Point(93, 32);
            textBox_KategoriId.Name = "textBox_KategoriId";
            textBox_KategoriId.Size = new Size(201, 23);
            textBox_KategoriId.TabIndex = 1;
            // 
            // dataGrid_Kategori
            // 
            dataGrid_Kategori.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Kategori.AutoGenerateColumns = false;
            dataGrid_Kategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Kategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Kategori.Columns.AddRange(new DataGridViewColumn[] { kategoriIdDataGridViewTextBoxColumn, kategoriAdiDataGridViewTextBoxColumn, kitapKategorilerDataGridViewTextBoxColumn });
            dataGrid_Kategori.DataSource = kategoriBindingSource;
            dataGrid_Kategori.Location = new Point(318, 42);
            dataGrid_Kategori.Name = "dataGrid_Kategori";
            dataGrid_Kategori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Kategori.Size = new Size(354, 479);
            dataGrid_Kategori.TabIndex = 1;
            dataGrid_Kategori.SelectionChanged += dataGrid_Kategori_SelectionChanged;
            // 
            // kategoriIdDataGridViewTextBoxColumn
            // 
            kategoriIdDataGridViewTextBoxColumn.DataPropertyName = "KategoriId";
            kategoriIdDataGridViewTextBoxColumn.HeaderText = "KategoriId";
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
            btnAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAra.Location = new Point(597, 12);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 23);
            btnAra.TabIndex = 10;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(389, 16);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 6;
            label3.Text = "Ara:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_Ara.Location = new Point(423, 13);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Kategori adı ile arayın";
            textBox_Ara.Size = new Size(168, 23);
            textBox_Ara.TabIndex = 9;
            // 
            // frmKategoriIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 541);
            Controls.Add(btnAra);
            Controls.Add(label3);
            Controls.Add(textBox_Ara);
            Controls.Add(dataGrid_Kategori);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(700, 580);
            MinimumSize = new Size(700, 580);
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
        private DataGridViewTextBoxColumn kategoriIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapKategorilerDataGridViewTextBoxColumn;
        private Button btnAra;
        private Label label3;
        private TextBox textBox_Ara;
    }
}