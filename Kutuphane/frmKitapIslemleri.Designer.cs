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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ıSBNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kitapAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            kategoriAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            basimYiliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sayfaSayisiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            stokDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            kitapDtoBindingSource = new BindingSource(components);
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
            // btnAra
            // 
            btnAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAra.Location = new Point(1137, 49);
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
            label1.Location = new Point(817, 53);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 7;
            label1.Text = "Ara:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_Ara.Location = new Point(851, 50);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "ISBN / Kitap Adı ile arayın";
            textBox_Ara.Size = new Size(280, 23);
            textBox_Ara.TabIndex = 6;
            // 
            // dataGrid_Kitap
            // 
            dataGrid_Kitap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Kitap.AutoGenerateColumns = false;
            dataGrid_Kitap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Kitap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Kitap.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, ıSBNDataGridViewTextBoxColumn, kitapAdiDataGridViewTextBoxColumn, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, kategoriAdiDataGridViewTextBoxColumn, basimYiliDataGridViewTextBoxColumn, sayfaSayisiDataGridViewTextBoxColumn, dataGridViewTextBoxColumn8, stokDataGridViewTextBoxColumn, aktifDataGridViewCheckBoxColumn });
            dataGrid_Kitap.DataSource = kitapDtoBindingSource;
            dataGrid_Kitap.Location = new Point(318, 78);
            dataGrid_Kitap.Name = "dataGrid_Kitap";
            dataGrid_Kitap.RowHeadersWidth = 51;
            dataGrid_Kitap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Kitap.Size = new Size(900, 655);
            dataGrid_Kitap.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "KitapID";
            dataGridViewTextBoxColumn1.HeaderText = "KitapID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // ıSBNDataGridViewTextBoxColumn
            // 
            ıSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            ıSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            ıSBNDataGridViewTextBoxColumn.Name = "ıSBNDataGridViewTextBoxColumn";
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "KitapAdi";
            kitapAdiDataGridViewTextBoxColumn.HeaderText = "Kitap Adı";
            kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "YazarID";
            dataGridViewTextBoxColumn2.HeaderText = "YazarID";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "YazarAd";
            dataGridViewTextBoxColumn3.HeaderText = "Yazar Adı";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "YazarSoyad";
            dataGridViewTextBoxColumn4.HeaderText = "Yazar Soyadı";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "YayineviID";
            dataGridViewTextBoxColumn5.HeaderText = "YayineviID";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "YayineviAd";
            dataGridViewTextBoxColumn6.HeaderText = "Yayinevi Adı";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "KategoriID";
            dataGridViewTextBoxColumn7.HeaderText = "KategoriID";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Visible = false;
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
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Dil";
            dataGridViewTextBoxColumn8.HeaderText = "Dil";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
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
            // kitapDtoBindingSource
            // 
            kitapDtoBindingSource.DataSource = typeof(Model.DTO.KitapDto);
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
            groupBox1.Location = new Point(12, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 616);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap İşlemleri";
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.Location = new Point(108, 505);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(150, 25);
            btnGeriYukle.TabIndex = 18;
            btnGeriYukle.Text = "Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = true;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.Location = new Point(108, 474);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(150, 25);
            btnSilinenleriGoster.TabIndex = 17;
            btnSilinenleriGoster.Text = "Silinen Üyeleri Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = true;
            btnSilinenleriGoster.Visible = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(108, 443);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(150, 25);
            btnTemizle.TabIndex = 15;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(108, 412);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(150, 25);
            btnSil.TabIndex = 16;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(108, 381);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(150, 25);
            btnDuzenle.TabIndex = 14;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(108, 350);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(150, 25);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // comboBox_Dil
            // 
            comboBox_Dil.FormattingEnabled = true;
            comboBox_Dil.Location = new Point(83, 224);
            comboBox_Dil.Name = "comboBox_Dil";
            comboBox_Dil.Size = new Size(201, 23);
            comboBox_Dil.TabIndex = 2;
            // 
            // comboBox_Yayinevi
            // 
            comboBox_Yayinevi.FormattingEnabled = true;
            comboBox_Yayinevi.Location = new Point(83, 195);
            comboBox_Yayinevi.Name = "comboBox_Yayinevi";
            comboBox_Yayinevi.Size = new Size(201, 23);
            comboBox_Yayinevi.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 314);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 1;
            label10.Text = "Stok Miktarı:";
            // 
            // comboBox_Yazar
            // 
            comboBox_Yazar.FormattingEnabled = true;
            comboBox_Yazar.Location = new Point(83, 166);
            comboBox_Yazar.Name = "comboBox_Yazar";
            comboBox_Yazar.Size = new Size(201, 23);
            comboBox_Yazar.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 198);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 1;
            label7.Text = "Yayınevi:";
            // 
            // comboBox_Kategori
            // 
            comboBox_Kategori.FormattingEnabled = true;
            comboBox_Kategori.Location = new Point(83, 137);
            comboBox_Kategori.Name = "comboBox_Kategori";
            comboBox_Kategori.Size = new Size(201, 23);
            comboBox_Kategori.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 169);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 1;
            label6.Text = "Yazar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 140);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 1;
            label5.Text = "Kategori:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 285);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 1;
            label11.Text = "Sayfa Sayısı:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 256);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 1;
            label9.Text = "Basım Yılı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 227);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 1;
            label8.Text = "Dil:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 111);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 1;
            label4.Text = "Kitap Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 82);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 1;
            label3.Text = "ISBN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 53);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Kitap Id:";
            // 
            // textBox_SayfaSayisi
            // 
            textBox_SayfaSayisi.Location = new Point(83, 282);
            textBox_SayfaSayisi.Name = "textBox_SayfaSayisi";
            textBox_SayfaSayisi.Size = new Size(201, 23);
            textBox_SayfaSayisi.TabIndex = 0;
            // 
            // textBox_BasimYili
            // 
            textBox_BasimYili.Location = new Point(83, 253);
            textBox_BasimYili.Name = "textBox_BasimYili";
            textBox_BasimYili.Size = new Size(201, 23);
            textBox_BasimYili.TabIndex = 0;
            // 
            // textBox_StokMiktari
            // 
            textBox_StokMiktari.Location = new Point(83, 311);
            textBox_StokMiktari.Name = "textBox_StokMiktari";
            textBox_StokMiktari.Size = new Size(201, 23);
            textBox_StokMiktari.TabIndex = 0;
            // 
            // textBox_KitapAdi
            // 
            textBox_KitapAdi.Location = new Point(83, 108);
            textBox_KitapAdi.Name = "textBox_KitapAdi";
            textBox_KitapAdi.Size = new Size(201, 23);
            textBox_KitapAdi.TabIndex = 0;
            // 
            // textBox_ISBN
            // 
            textBox_ISBN.Location = new Point(83, 79);
            textBox_ISBN.Name = "textBox_ISBN";
            textBox_ISBN.Size = new Size(201, 23);
            textBox_ISBN.TabIndex = 0;
            // 
            // textBox_KitapId
            // 
            textBox_KitapId.Location = new Point(83, 50);
            textBox_KitapId.Name = "textBox_KitapId";
            textBox_KitapId.Size = new Size(201, 23);
            textBox_KitapId.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kategoriİşlemToolStripMenuItem, yazarİşlemleriToolStripMenuItem, dilİşlemleriToolStripMenuItem, yayıneviİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1224, 25);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // kategoriİşlemToolStripMenuItem
            // 
            kategoriİşlemToolStripMenuItem.Name = "kategoriİşlemToolStripMenuItem";
            kategoriİşlemToolStripMenuItem.Size = new Size(129, 21);
            kategoriİşlemToolStripMenuItem.Text = "Kategori İşlemleri";
            kategoriİşlemToolStripMenuItem.Click += kategoriİşlemToolStripMenuItem_Click;
            // 
            // yazarİşlemleriToolStripMenuItem
            // 
            yazarİşlemleriToolStripMenuItem.Name = "yazarİşlemleriToolStripMenuItem";
            yazarİşlemleriToolStripMenuItem.Size = new Size(109, 21);
            yazarİşlemleriToolStripMenuItem.Text = "Yazar İşlemleri";
            yazarİşlemleriToolStripMenuItem.Click += yazarİşlemleriToolStripMenuItem_Click;
            // 
            // dilİşlemleriToolStripMenuItem
            // 
            dilİşlemleriToolStripMenuItem.Name = "dilİşlemleriToolStripMenuItem";
            dilİşlemleriToolStripMenuItem.Size = new Size(95, 21);
            dilİşlemleriToolStripMenuItem.Text = "Dil İşlemleri";
            dilİşlemleriToolStripMenuItem.Click += dilİşlemleriToolStripMenuItem_Click;
            // 
            // yayıneviİşlemleriToolStripMenuItem
            // 
            yayıneviİşlemleriToolStripMenuItem.Name = "yayıneviİşlemleriToolStripMenuItem";
            yayıneviİşlemleriToolStripMenuItem.Size = new Size(128, 21);
            yayıneviİşlemleriToolStripMenuItem.Text = "Yayınevi İşlemleri";
            yayıneviİşlemleriToolStripMenuItem.Click += yayıneviİşlemleriToolStripMenuItem_Click;
            // 
            // frmKitapIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 745);
            Controls.Add(groupBox1);
            Controls.Add(btnAra);
            Controls.Add(label1);
            Controls.Add(textBox_Ara);
            Controls.Add(dataGrid_Kitap);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
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
        private DataGridView dataGrid_Kitap;
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
        private DataGridViewTextBoxColumn dilIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarAdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarSoyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yayineviIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yayineviAdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dilDataGridViewTextBoxColumn;
        private Label label11;
        private TextBox textBox_SayfaSayisi;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kategoriİşlemToolStripMenuItem;
        private ToolStripMenuItem yazarİşlemleriToolStripMenuItem;
        private ToolStripMenuItem dilİşlemleriToolStripMenuItem;
        private ToolStripMenuItem yayıneviİşlemleriToolStripMenuItem;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ıSBNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn kategoriAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn basimYiliDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sayfaSayisiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn;
        private BindingSource kitapDtoBindingSource;
    }
}