using Kutuphane.UI;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapIslemleri));
            dataGrid_Kitap = new DataGridView();
            kitapIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kitapAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ıSBNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yazarIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yazarAdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yazarSoyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yayineviIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yayineviAdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            basimYiliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sayfaSayisiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dilDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stokDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            kitapDtoBindingSource = new BindingSource(components);
            btnAra = new Button();
            label1 = new Label();
            textBox_Ara = new TextBox();
            groupBox1 = new GroupBox();
            btnGeriYukle = new Button();
            btnSilinenleriGoster = new Button();
            btnTemizle = new Button();
            btnSil = new Button();
            btnDuzenle = new Button();
            btnKaydet = new Button();
            comboBox_Dil = new ComboBox();
            comboBox_Yayinevi = new ComboBox();
            label10 = new Label();
            comboBox_Yazar = new ComboBox();
            label7 = new Label();
            comboBox_Kategori = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox_SayfaSayisi = new TextBox();
            textBox_BasimYili = new TextBox();
            textBox_StokMiktari = new TextBox();
            textBox_KitapAdi = new TextBox();
            textBox_ISBN = new TextBox();
            textBox_KitapId = new TextBox();
            menuStrip1 = new MenuStrip();
            kategoriİşlemToolStripMenuItem = new ToolStripMenuItem();
            yazarİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            dilİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            yayıneviİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Kitap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kitapDtoBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGrid_Kitap
            // 
            dataGrid_Kitap.AllowUserToDeleteRows = false;
            dataGrid_Kitap.AllowUserToOrderColumns = true;
            dataGrid_Kitap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Kitap.AutoGenerateColumns = false;
            dataGrid_Kitap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Kitap.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid_Kitap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Kitap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Kitap.Columns.AddRange(new DataGridViewColumn[] { kitapIdDataGridViewTextBoxColumn, kitapAdiDataGridViewTextBoxColumn, ıSBNDataGridViewTextBoxColumn, yazarIdDataGridViewTextBoxColumn, yazarAdDataGridViewTextBoxColumn, yazarSoyadDataGridViewTextBoxColumn, yayineviIdDataGridViewTextBoxColumn, yayineviAdDataGridViewTextBoxColumn, kategoriIdDataGridViewTextBoxColumn, kategoriAdiDataGridViewTextBoxColumn, basimYiliDataGridViewTextBoxColumn, sayfaSayisiDataGridViewTextBoxColumn, dilDataGridViewTextBoxColumn, stokDataGridViewTextBoxColumn, aktifDataGridViewCheckBoxColumn });
            dataGrid_Kitap.DataSource = kitapDtoBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGrid_Kitap.DefaultCellStyle = dataGridViewCellStyle2;
            dataGrid_Kitap.GridColor = SystemColors.ControlLight;
            dataGrid_Kitap.Location = new Point(363, 104);
            dataGrid_Kitap.Margin = new Padding(3, 4, 3, 4);
            dataGrid_Kitap.MultiSelect = false;
            dataGrid_Kitap.Name = "dataGrid_Kitap";
            dataGrid_Kitap.RowHeadersVisible = false;
            dataGrid_Kitap.RowHeadersWidth = 51;
            dataGrid_Kitap.RowTemplate.Height = 25;
            dataGrid_Kitap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Kitap.Size = new Size(1022, 873);
            dataGrid_Kitap.TabIndex = 19;
            dataGrid_Kitap.RowsAdded += dataGrid_Kitap_RowsAdded;
            dataGrid_Kitap.SelectionChanged += dataGrid_Kitap_SelectionChanged;
            // 
            // kitapIdDataGridViewTextBoxColumn
            // 
            kitapIdDataGridViewTextBoxColumn.DataPropertyName = "KitapId";
            kitapIdDataGridViewTextBoxColumn.HeaderText = "KitapId";
            kitapIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            kitapIdDataGridViewTextBoxColumn.Name = "kitapIdDataGridViewTextBoxColumn";
            kitapIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "KitapAdi";
            kitapAdiDataGridViewTextBoxColumn.HeaderText = "Kitap Adı";
            kitapAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            // 
            // ıSBNDataGridViewTextBoxColumn
            // 
            ıSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            ıSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            ıSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            ıSBNDataGridViewTextBoxColumn.Name = "ıSBNDataGridViewTextBoxColumn";
            // 
            // yazarIdDataGridViewTextBoxColumn
            // 
            yazarIdDataGridViewTextBoxColumn.DataPropertyName = "YazarId";
            yazarIdDataGridViewTextBoxColumn.HeaderText = "YazarId";
            yazarIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            yazarIdDataGridViewTextBoxColumn.Name = "yazarIdDataGridViewTextBoxColumn";
            yazarIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // yazarAdDataGridViewTextBoxColumn
            // 
            yazarAdDataGridViewTextBoxColumn.DataPropertyName = "YazarAd";
            yazarAdDataGridViewTextBoxColumn.HeaderText = "Yazar Adı";
            yazarAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            yazarAdDataGridViewTextBoxColumn.Name = "yazarAdDataGridViewTextBoxColumn";
            // 
            // yazarSoyadDataGridViewTextBoxColumn
            // 
            yazarSoyadDataGridViewTextBoxColumn.DataPropertyName = "YazarSoyad";
            yazarSoyadDataGridViewTextBoxColumn.HeaderText = "Yazar Soyadı";
            yazarSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            yazarSoyadDataGridViewTextBoxColumn.Name = "yazarSoyadDataGridViewTextBoxColumn";
            // 
            // yayineviIdDataGridViewTextBoxColumn
            // 
            yayineviIdDataGridViewTextBoxColumn.DataPropertyName = "YayineviId";
            yayineviIdDataGridViewTextBoxColumn.HeaderText = "YayineviId";
            yayineviIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            yayineviIdDataGridViewTextBoxColumn.Name = "yayineviIdDataGridViewTextBoxColumn";
            yayineviIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // yayineviAdDataGridViewTextBoxColumn
            // 
            yayineviAdDataGridViewTextBoxColumn.DataPropertyName = "YayineviAd";
            yayineviAdDataGridViewTextBoxColumn.HeaderText = "Yayınevi Adı";
            yayineviAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            yayineviAdDataGridViewTextBoxColumn.Name = "yayineviAdDataGridViewTextBoxColumn";
            // 
            // kategoriIdDataGridViewTextBoxColumn
            // 
            kategoriIdDataGridViewTextBoxColumn.DataPropertyName = "KategoriId";
            kategoriIdDataGridViewTextBoxColumn.HeaderText = "KategoriId";
            kategoriIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            kategoriIdDataGridViewTextBoxColumn.Name = "kategoriIdDataGridViewTextBoxColumn";
            kategoriIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // kategoriAdiDataGridViewTextBoxColumn
            // 
            kategoriAdiDataGridViewTextBoxColumn.DataPropertyName = "KategoriAdi";
            kategoriAdiDataGridViewTextBoxColumn.HeaderText = "Kategori Adı";
            kategoriAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            kategoriAdiDataGridViewTextBoxColumn.Name = "kategoriAdiDataGridViewTextBoxColumn";
            // 
            // basimYiliDataGridViewTextBoxColumn
            // 
            basimYiliDataGridViewTextBoxColumn.DataPropertyName = "BasimYili";
            basimYiliDataGridViewTextBoxColumn.HeaderText = "Basım Yılı";
            basimYiliDataGridViewTextBoxColumn.MinimumWidth = 6;
            basimYiliDataGridViewTextBoxColumn.Name = "basimYiliDataGridViewTextBoxColumn";
            // 
            // sayfaSayisiDataGridViewTextBoxColumn
            // 
            sayfaSayisiDataGridViewTextBoxColumn.DataPropertyName = "SayfaSayisi";
            sayfaSayisiDataGridViewTextBoxColumn.HeaderText = "Sayfa Sayısı";
            sayfaSayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            sayfaSayisiDataGridViewTextBoxColumn.Name = "sayfaSayisiDataGridViewTextBoxColumn";
            // 
            // dilDataGridViewTextBoxColumn
            // 
            dilDataGridViewTextBoxColumn.DataPropertyName = "Dil";
            dilDataGridViewTextBoxColumn.HeaderText = "Dil";
            dilDataGridViewTextBoxColumn.MinimumWidth = 6;
            dilDataGridViewTextBoxColumn.Name = "dilDataGridViewTextBoxColumn";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            stokDataGridViewTextBoxColumn.HeaderText = "Stok Miktarı";
            stokDataGridViewTextBoxColumn.MinimumWidth = 6;
            stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // aktifDataGridViewCheckBoxColumn
            // 
            aktifDataGridViewCheckBoxColumn.DataPropertyName = "Aktif";
            aktifDataGridViewCheckBoxColumn.HeaderText = "Aktif";
            aktifDataGridViewCheckBoxColumn.MinimumWidth = 6;
            aktifDataGridViewCheckBoxColumn.Name = "aktifDataGridViewCheckBoxColumn";
            aktifDataGridViewCheckBoxColumn.Visible = false;
            // 
            // kitapDtoBindingSource
            // 
            kitapDtoBindingSource.DataSource = typeof(Model.DTO.KitapDto);
            // 
            // btnAra
            // 
            btnAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAra.Location = new Point(1299, 65);
            btnAra.Margin = new Padding(3, 4, 3, 4);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(86, 31);
            btnAra.TabIndex = 17;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(934, 71);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Ara:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_Ara.Location = new Point(973, 67);
            textBox_Ara.Margin = new Padding(3, 4, 3, 4);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "ISBN / Kitap Adı ile arayın";
            textBox_Ara.Size = new Size(319, 27);
            textBox_Ara.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGeriYukle);
            groupBox1.Controls.Add(btnSilinenleriGoster);
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnDuzenle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(comboBox_Dil);
            groupBox1.Controls.Add(comboBox_Yayinevi);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(comboBox_Yazar);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBox_Kategori);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_SayfaSayisi);
            groupBox1.Controls.Add(textBox_BasimYili);
            groupBox1.Controls.Add(textBox_StokMiktari);
            groupBox1.Controls.Add(textBox_KitapAdi);
            groupBox1.Controls.Add(textBox_ISBN);
            groupBox1.Controls.Add(textBox_KitapId);
            groupBox1.Location = new Point(14, 104);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(343, 721);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap İşlemleri";
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.Location = new Point(123, 673);
            btnGeriYukle.Margin = new Padding(3, 4, 3, 4);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(171, 33);
            btnGeriYukle.TabIndex = 15;
            btnGeriYukle.Text = "Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = true;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.Location = new Point(123, 632);
            btnSilinenleriGoster.Margin = new Padding(3, 4, 3, 4);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(171, 33);
            btnSilinenleriGoster.TabIndex = 14;
            btnSilinenleriGoster.Text = "Silinen Kitapları Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = true;
            btnSilinenleriGoster.Visible = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(123, 591);
            btnTemizle.Margin = new Padding(3, 4, 3, 4);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(171, 33);
            btnTemizle.TabIndex = 13;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(123, 549);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(171, 33);
            btnSil.TabIndex = 12;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(123, 508);
            btnDuzenle.Margin = new Padding(3, 4, 3, 4);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(171, 33);
            btnDuzenle.TabIndex = 11;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(123, 467);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(171, 33);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // comboBox_Dil
            // 
            comboBox_Dil.FormattingEnabled = true;
            comboBox_Dil.Location = new Point(95, 299);
            comboBox_Dil.Margin = new Padding(3, 4, 3, 4);
            comboBox_Dil.Name = "comboBox_Dil";
            comboBox_Dil.Size = new Size(229, 28);
            comboBox_Dil.TabIndex = 6;
            // 
            // comboBox_Yayinevi
            // 
            comboBox_Yayinevi.FormattingEnabled = true;
            comboBox_Yayinevi.Location = new Point(95, 260);
            comboBox_Yayinevi.Margin = new Padding(3, 4, 3, 4);
            comboBox_Yayinevi.Name = "comboBox_Yayinevi";
            comboBox_Yayinevi.Size = new Size(229, 28);
            comboBox_Yayinevi.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 419);
            label10.Name = "label10";
            label10.Size = new Size(91, 20);
            label10.TabIndex = 0;
            label10.Text = "Stok Miktarı:";
            // 
            // comboBox_Yazar
            // 
            comboBox_Yazar.FormattingEnabled = true;
            comboBox_Yazar.Location = new Point(95, 221);
            comboBox_Yazar.Margin = new Padding(3, 4, 3, 4);
            comboBox_Yazar.Name = "comboBox_Yazar";
            comboBox_Yazar.Size = new Size(229, 28);
            comboBox_Yazar.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 264);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 0;
            label7.Text = "Yayınevi:";
            // 
            // comboBox_Kategori
            // 
            comboBox_Kategori.FormattingEnabled = true;
            comboBox_Kategori.Location = new Point(95, 183);
            comboBox_Kategori.Margin = new Padding(3, 4, 3, 4);
            comboBox_Kategori.Name = "comboBox_Kategori";
            comboBox_Kategori.Size = new Size(229, 28);
            comboBox_Kategori.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 225);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 0;
            label6.Text = "Yazar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 187);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 0;
            label5.Text = "Kategori:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 380);
            label11.Name = "label11";
            label11.Size = new Size(89, 20);
            label11.TabIndex = 0;
            label11.Text = "Sayfa Sayısı:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 341);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 0;
            label9.Text = "Basım Yılı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 303);
            label8.Name = "label8";
            label8.Size = new Size(31, 20);
            label8.TabIndex = 0;
            label8.Text = "Dil:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 148);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 0;
            label4.Text = "Kitap Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 109);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 0;
            label3.Text = "ISBN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 71);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 0;
            label2.Text = "Kitap Id:";
            // 
            // textBox_SayfaSayisi
            // 
            textBox_SayfaSayisi.Location = new Point(95, 376);
            textBox_SayfaSayisi.Margin = new Padding(3, 4, 3, 4);
            textBox_SayfaSayisi.Name = "textBox_SayfaSayisi";
            textBox_SayfaSayisi.Size = new Size(229, 27);
            textBox_SayfaSayisi.TabIndex = 8;
            // 
            // textBox_BasimYili
            // 
            textBox_BasimYili.Location = new Point(95, 337);
            textBox_BasimYili.Margin = new Padding(3, 4, 3, 4);
            textBox_BasimYili.Name = "textBox_BasimYili";
            textBox_BasimYili.Size = new Size(229, 27);
            textBox_BasimYili.TabIndex = 7;
            // 
            // textBox_StokMiktari
            // 
            textBox_StokMiktari.Location = new Point(95, 415);
            textBox_StokMiktari.Margin = new Padding(3, 4, 3, 4);
            textBox_StokMiktari.Name = "textBox_StokMiktari";
            textBox_StokMiktari.Size = new Size(229, 27);
            textBox_StokMiktari.TabIndex = 9;
            // 
            // textBox_KitapAdi
            // 
            textBox_KitapAdi.Location = new Point(95, 144);
            textBox_KitapAdi.Margin = new Padding(3, 4, 3, 4);
            textBox_KitapAdi.Name = "textBox_KitapAdi";
            textBox_KitapAdi.Size = new Size(229, 27);
            textBox_KitapAdi.TabIndex = 2;
            // 
            // textBox_ISBN
            // 
            textBox_ISBN.Location = new Point(95, 105);
            textBox_ISBN.Margin = new Padding(3, 4, 3, 4);
            textBox_ISBN.Name = "textBox_ISBN";
            textBox_ISBN.Size = new Size(229, 27);
            textBox_ISBN.TabIndex = 1;
            // 
            // textBox_KitapId
            // 
            textBox_KitapId.Enabled = false;
            textBox_KitapId.Location = new Point(95, 67);
            textBox_KitapId.Margin = new Padding(3, 4, 3, 4);
            textBox_KitapId.Name = "textBox_KitapId";
            textBox_KitapId.Size = new Size(229, 27);
            textBox_KitapId.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kategoriİşlemToolStripMenuItem, yazarİşlemleriToolStripMenuItem, dilİşlemleriToolStripMenuItem, yayıneviİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1399, 33);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // kategoriİşlemToolStripMenuItem
            // 
            kategoriİşlemToolStripMenuItem.Name = "kategoriİşlemToolStripMenuItem";
            kategoriİşlemToolStripMenuItem.Size = new Size(166, 27);
            kategoriİşlemToolStripMenuItem.Text = "Kategori İşlemleri";
            // 
            // yazarİşlemleriToolStripMenuItem
            // 
            yazarİşlemleriToolStripMenuItem.Name = "yazarİşlemleriToolStripMenuItem";
            yazarİşlemleriToolStripMenuItem.Size = new Size(138, 27);
            yazarİşlemleriToolStripMenuItem.Text = "Yazar İşlemleri";
            // 
            // dilİşlemleriToolStripMenuItem
            // 
            dilİşlemleriToolStripMenuItem.Name = "dilİşlemleriToolStripMenuItem";
            dilİşlemleriToolStripMenuItem.Size = new Size(120, 27);
            dilİşlemleriToolStripMenuItem.Text = "Dil İşlemleri";
            // 
            // yayıneviİşlemleriToolStripMenuItem
            // 
            yayıneviİşlemleriToolStripMenuItem.Name = "yayıneviİşlemleriToolStripMenuItem";
            yayıneviİşlemleriToolStripMenuItem.Size = new Size(161, 27);
            yayıneviİşlemleriToolStripMenuItem.Text = "Yayınevi İşlemleri";
            // 
            // frmKitapIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 993);
            Controls.Add(dataGrid_Kitap);
            Controls.Add(groupBox1);
            Controls.Add(btnAra);
            Controls.Add(label1);
            Controls.Add(textBox_Ara);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmKitapIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Kitap İşlemleri";
            Load += frmKitapIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_Kitap).EndInit();
            ((System.ComponentModel.ISupportInitialize)kitapDtoBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAra;
        private Label label1;
        private TextBox textBox_Ara;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox_KitapId;
        private ComboBox comboBox_Dil;
        private ComboBox comboBox_Yayinevi;
        private Label label10;
        private ComboBox comboBox_Yazar;
        private Label label7;
        private ComboBox comboBox_Kategori;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label4;
        private Label label3;
        private TextBox textBox_BasimYili;
        private TextBox textBox_StokMiktari;
        private TextBox textBox_KitapAdi;
        private TextBox textBox_ISBN;
        private Button btnGeriYukle;
        private Button btnSilinenleriGoster;
        private Button btnTemizle;
        private Button btnSil;
        private Button btnDuzenle;
        private Button btnKaydet;
        private Label label11;
        private TextBox textBox_SayfaSayisi;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kategoriİşlemToolStripMenuItem;
        private ToolStripMenuItem yazarİşlemleriToolStripMenuItem;
        private ToolStripMenuItem dilİşlemleriToolStripMenuItem;
        private ToolStripMenuItem yayıneviİşlemleriToolStripMenuItem;
        private DataGridView dataGrid_Kitap;
        private DataGridViewTextBoxColumn kitapIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ıSBNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarAdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarSoyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yayineviIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yayineviAdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn basimYiliDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sayfaSayisiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dilDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn;
        private BindingSource kitapDtoBindingSource;
    }
}