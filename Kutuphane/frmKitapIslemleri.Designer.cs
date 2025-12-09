namespace Kutuphane.UI
{
    partial class frmKitapIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapIslemleri));
            btnAra = new Button();
            label1 = new Label();
            textBox_Ara = new TextBox();
            dataGrid_Kitap = new DataGridView();
            kitapDtoBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            kitapIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kitapAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ıSBNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yazarIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yazarAdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yazarSoyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yayineviIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yayineviAdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            basimYiliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sayfaSayisiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dilDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stokDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Kitap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kitapDtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAra
            // 
            btnAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAra.Location = new Point(1056, 12);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 23);
            btnAra.TabIndex = 8;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(816, 16);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 7;
            label1.Text = "Ara:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_Ara.Location = new Point(850, 12);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Arama için Kitap adı gir";
            textBox_Ara.Size = new Size(200, 23);
            textBox_Ara.TabIndex = 6;
            // 
            // dataGrid_Kitap
            // 
            dataGrid_Kitap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Kitap.AutoGenerateColumns = false;
            dataGrid_Kitap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Kitap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Kitap.Columns.AddRange(new DataGridViewColumn[] { kitapIDDataGridViewTextBoxColumn, kitapAdiDataGridViewTextBoxColumn, ıSBNDataGridViewTextBoxColumn, yazarIDDataGridViewTextBoxColumn, yazarAdDataGridViewTextBoxColumn, yazarSoyadDataGridViewTextBoxColumn, yayineviIDDataGridViewTextBoxColumn, yayineviAdDataGridViewTextBoxColumn, kategoriIDDataGridViewTextBoxColumn, kategoriAdiDataGridViewTextBoxColumn, basimYiliDataGridViewTextBoxColumn, sayfaSayisiDataGridViewTextBoxColumn, dilDataGridViewTextBoxColumn, stokDataGridViewTextBoxColumn, aktifDataGridViewCheckBoxColumn });
            dataGrid_Kitap.DataSource = kitapDtoBindingSource;
            dataGrid_Kitap.Location = new Point(341, 41);
            dataGrid_Kitap.Name = "dataGrid_Kitap";
            dataGrid_Kitap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Kitap.Size = new Size(791, 578);
            dataGrid_Kitap.TabIndex = 5;
            // 
            // kitapDtoBindingSource
            // 
            kitapDtoBindingSource.DataSource = typeof(Model.DTO.KitapDto);
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 578);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap İşlemleri";
            // 
            // kitapIDDataGridViewTextBoxColumn
            // 
            kitapIDDataGridViewTextBoxColumn.DataPropertyName = "KitapID";
            kitapIDDataGridViewTextBoxColumn.HeaderText = "KitapID";
            kitapIDDataGridViewTextBoxColumn.Name = "kitapIDDataGridViewTextBoxColumn";
            kitapIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "KitapAdi";
            kitapAdiDataGridViewTextBoxColumn.HeaderText = "Kitap Adı";
            kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            // 
            // ıSBNDataGridViewTextBoxColumn
            // 
            ıSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            ıSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            ıSBNDataGridViewTextBoxColumn.Name = "ıSBNDataGridViewTextBoxColumn";
            // 
            // yazarIDDataGridViewTextBoxColumn
            // 
            yazarIDDataGridViewTextBoxColumn.DataPropertyName = "YazarID";
            yazarIDDataGridViewTextBoxColumn.HeaderText = "YazarID";
            yazarIDDataGridViewTextBoxColumn.Name = "yazarIDDataGridViewTextBoxColumn";
            yazarIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // yazarAdDataGridViewTextBoxColumn
            // 
            yazarAdDataGridViewTextBoxColumn.DataPropertyName = "YazarAd";
            yazarAdDataGridViewTextBoxColumn.HeaderText = "Yazar Adı";
            yazarAdDataGridViewTextBoxColumn.Name = "yazarAdDataGridViewTextBoxColumn";
            // 
            // yazarSoyadDataGridViewTextBoxColumn
            // 
            yazarSoyadDataGridViewTextBoxColumn.DataPropertyName = "YazarSoyad";
            yazarSoyadDataGridViewTextBoxColumn.HeaderText = "Yazar Soyadı";
            yazarSoyadDataGridViewTextBoxColumn.Name = "yazarSoyadDataGridViewTextBoxColumn";
            // 
            // yayineviIDDataGridViewTextBoxColumn
            // 
            yayineviIDDataGridViewTextBoxColumn.DataPropertyName = "YayineviID";
            yayineviIDDataGridViewTextBoxColumn.HeaderText = "YayineviID";
            yayineviIDDataGridViewTextBoxColumn.Name = "yayineviIDDataGridViewTextBoxColumn";
            yayineviIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // yayineviAdDataGridViewTextBoxColumn
            // 
            yayineviAdDataGridViewTextBoxColumn.DataPropertyName = "YayineviAd";
            yayineviAdDataGridViewTextBoxColumn.HeaderText = "Yayınevi Adı";
            yayineviAdDataGridViewTextBoxColumn.Name = "yayineviAdDataGridViewTextBoxColumn";
            // 
            // kategoriIDDataGridViewTextBoxColumn
            // 
            kategoriIDDataGridViewTextBoxColumn.DataPropertyName = "KategoriID";
            kategoriIDDataGridViewTextBoxColumn.HeaderText = "KategoriID";
            kategoriIDDataGridViewTextBoxColumn.Name = "kategoriIDDataGridViewTextBoxColumn";
            kategoriIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // kategoriAdiDataGridViewTextBoxColumn
            // 
            kategoriAdiDataGridViewTextBoxColumn.DataPropertyName = "KategoriAdi";
            kategoriAdiDataGridViewTextBoxColumn.HeaderText = "Kategori Adı";
            kategoriAdiDataGridViewTextBoxColumn.Name = "kategoriAdiDataGridViewTextBoxColumn";
            // 
            // basimYiliDataGridViewTextBoxColumn
            // 
            basimYiliDataGridViewTextBoxColumn.DataPropertyName = "BasimYili";
            basimYiliDataGridViewTextBoxColumn.HeaderText = "Basım Yılı";
            basimYiliDataGridViewTextBoxColumn.Name = "basimYiliDataGridViewTextBoxColumn";
            // 
            // sayfaSayisiDataGridViewTextBoxColumn
            // 
            sayfaSayisiDataGridViewTextBoxColumn.DataPropertyName = "SayfaSayisi";
            sayfaSayisiDataGridViewTextBoxColumn.HeaderText = "Sayfa Sayısı";
            sayfaSayisiDataGridViewTextBoxColumn.Name = "sayfaSayisiDataGridViewTextBoxColumn";
            // 
            // dilDataGridViewTextBoxColumn
            // 
            dilDataGridViewTextBoxColumn.DataPropertyName = "Dil";
            dilDataGridViewTextBoxColumn.HeaderText = "Dil";
            dilDataGridViewTextBoxColumn.Name = "dilDataGridViewTextBoxColumn";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // aktifDataGridViewCheckBoxColumn
            // 
            aktifDataGridViewCheckBoxColumn.DataPropertyName = "Aktif";
            aktifDataGridViewCheckBoxColumn.HeaderText = "Aktif";
            aktifDataGridViewCheckBoxColumn.Name = "aktifDataGridViewCheckBoxColumn";
            aktifDataGridViewCheckBoxColumn.Visible = false;
            // 
            // frmKitapIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 631);
            Controls.Add(groupBox1);
            Controls.Add(btnAra);
            Controls.Add(label1);
            Controls.Add(textBox_Ara);
            Controls.Add(dataGrid_Kitap);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmKitapIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Kitap İşlemleri";
            Load += frmKitapIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_Kitap).EndInit();
            ((System.ComponentModel.ISupportInitialize)kitapDtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAra;
        private Label label1;
        private TextBox textBox_Ara;
        private DataGridView dataGrid_Kitap;
        private GroupBox groupBox1;
        private BindingSource kitapDtoBindingSource;
        private DataGridViewTextBoxColumn kitapIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ıSBNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarAdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarSoyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yayineviIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yayineviAdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn basimYiliDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sayfaSayisiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dilDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn;
    }
}