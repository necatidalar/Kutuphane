using Kutuphane.UI;
using System.Windows.Forms;

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
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnKaydet = new Button();
            btnDuzenle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            btnSilinenleriGoster = new Button();
            btnGeriYukle = new Button();
            panel1 = new Panel();
            textBox_KitapId = new TextBox();
            textBox_ISBN = new TextBox();
            textBox_KitapAdi = new TextBox();
            textBox_StokMiktari = new TextBox();
            textBox_BasimYili = new TextBox();
            textBox_SayfaSayisi = new TextBox();
            comboBox_Dil = new ComboBox();
            label2 = new Label();
            comboBox_Yayinevi = new ComboBox();
            label3 = new Label();
            label10 = new Label();
            label4 = new Label();
            comboBox_Yazar = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            comboBox_Kategori = new ComboBox();
            label11 = new Label();
            label6 = new Label();
            label5 = new Label();
            kitapDtoBindingSource = new BindingSource(components);
            textBox_Ara = new TextBox();
            label_txtAra = new Label();
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
            dilIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dilDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stokDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kitapDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Kitap).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.MinimumSize = new Size(300, 628);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 628);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap İşlemleri";
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
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 347);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(360, 278);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(39, 174, 96);
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(72, 13);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(265, 38);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "💾 KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.FromArgb(41, 128, 185);
            btnDuzenle.FlatAppearance.BorderSize = 0;
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDuzenle.ForeColor = Color.White;
            btnDuzenle.Location = new Point(72, 57);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(265, 38);
            btnDuzenle.TabIndex = 11;
            btnDuzenle.Text = "✏️ Düzenle";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 57, 43);
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(72, 101);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(265, 38);
            btnSil.TabIndex = 12;
            btnSil.Text = "❌ Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(149, 165, 166);
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(72, 145);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(265, 38);
            btnTemizle.TabIndex = 13;
            btnTemizle.Text = "\U0001f9f9 Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.BackColor = Color.FromArgb(236, 240, 241);
            btnSilinenleriGoster.FlatAppearance.BorderColor = Color.FromArgb(52, 73, 94);
            btnSilinenleriGoster.FlatStyle = FlatStyle.Flat;
            btnSilinenleriGoster.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSilinenleriGoster.ForeColor = Color.FromArgb(52, 73, 94);
            btnSilinenleriGoster.Location = new Point(72, 189);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(265, 38);
            btnSilinenleriGoster.TabIndex = 14;
            btnSilinenleriGoster.Text = "🗑️ Silinen Kitapları Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.BackColor = Color.FromArgb(52, 73, 94);
            btnGeriYukle.FlatAppearance.BorderSize = 0;
            btnGeriYukle.FlatStyle = FlatStyle.Flat;
            btnGeriYukle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeriYukle.ForeColor = Color.White;
            btnGeriYukle.Location = new Point(72, 233);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(265, 38);
            btnGeriYukle.TabIndex = 16;
            btnGeriYukle.Text = "↩️ Seçili Kitapları Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = false;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox_KitapId);
            panel1.Controls.Add(textBox_ISBN);
            panel1.Controls.Add(textBox_KitapAdi);
            panel1.Controls.Add(textBox_StokMiktari);
            panel1.Controls.Add(textBox_BasimYili);
            panel1.Controls.Add(textBox_SayfaSayisi);
            panel1.Controls.Add(comboBox_Dil);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox_Yayinevi);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox_Yazar);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(comboBox_Kategori);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 23);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 324);
            panel1.TabIndex = 22;
            // 
            // textBox_KitapId
            // 
            textBox_KitapId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_KitapId.Enabled = false;
            textBox_KitapId.Font = new Font("Segoe UI", 10F);
            textBox_KitapId.Location = new Point(101, 10);
            textBox_KitapId.Name = "textBox_KitapId";
            textBox_KitapId.Size = new Size(254, 25);
            textBox_KitapId.TabIndex = 0;
            // 
            // textBox_ISBN
            // 
            textBox_ISBN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_ISBN.Font = new Font("Segoe UI", 10F);
            textBox_ISBN.Location = new Point(101, 40);
            textBox_ISBN.Name = "textBox_ISBN";
            textBox_ISBN.Size = new Size(254, 25);
            textBox_ISBN.TabIndex = 1;
            // 
            // textBox_KitapAdi
            // 
            textBox_KitapAdi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_KitapAdi.Font = new Font("Segoe UI", 10F);
            textBox_KitapAdi.Location = new Point(101, 71);
            textBox_KitapAdi.Name = "textBox_KitapAdi";
            textBox_KitapAdi.Size = new Size(254, 25);
            textBox_KitapAdi.TabIndex = 2;
            // 
            // textBox_StokMiktari
            // 
            textBox_StokMiktari.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_StokMiktari.Font = new Font("Segoe UI", 10F);
            textBox_StokMiktari.Location = new Point(101, 289);
            textBox_StokMiktari.Name = "textBox_StokMiktari";
            textBox_StokMiktari.Size = new Size(254, 25);
            textBox_StokMiktari.TabIndex = 9;
            // 
            // textBox_BasimYili
            // 
            textBox_BasimYili.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_BasimYili.Font = new Font("Segoe UI", 10F);
            textBox_BasimYili.Location = new Point(101, 226);
            textBox_BasimYili.Name = "textBox_BasimYili";
            textBox_BasimYili.Size = new Size(254, 25);
            textBox_BasimYili.TabIndex = 7;
            // 
            // textBox_SayfaSayisi
            // 
            textBox_SayfaSayisi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_SayfaSayisi.Font = new Font("Segoe UI", 10F);
            textBox_SayfaSayisi.Location = new Point(101, 257);
            textBox_SayfaSayisi.Name = "textBox_SayfaSayisi";
            textBox_SayfaSayisi.Size = new Size(254, 25);
            textBox_SayfaSayisi.TabIndex = 8;
            // 
            // comboBox_Dil
            // 
            comboBox_Dil.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_Dil.Font = new Font("Segoe UI", 10F);
            comboBox_Dil.FormattingEnabled = true;
            comboBox_Dil.Location = new Point(101, 196);
            comboBox_Dil.Name = "comboBox_Dil";
            comboBox_Dil.Size = new Size(254, 25);
            comboBox_Dil.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(33, 13);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 0;
            label2.Text = "Kitap Id:";
            // 
            // comboBox_Yayinevi
            // 
            comboBox_Yayinevi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_Yayinevi.Font = new Font("Segoe UI", 10F);
            comboBox_Yayinevi.FormattingEnabled = true;
            comboBox_Yayinevi.Location = new Point(101, 164);
            comboBox_Yayinevi.Name = "comboBox_Yayinevi";
            comboBox_Yayinevi.Size = new Size(254, 25);
            comboBox_Yayinevi.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(52, 44);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 0;
            label3.Text = "ISBN:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.Location = new Point(5, 292);
            label10.Name = "label10";
            label10.Size = new Size(89, 19);
            label10.TabIndex = 0;
            label10.Text = "Stok Miktarı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(24, 74);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 0;
            label4.Text = "Kitap Adı:";
            // 
            // comboBox_Yazar
            // 
            comboBox_Yazar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_Yazar.Font = new Font("Segoe UI", 10F);
            comboBox_Yazar.FormattingEnabled = true;
            comboBox_Yazar.Location = new Point(101, 134);
            comboBox_Yazar.Name = "comboBox_Yazar";
            comboBox_Yazar.Size = new Size(254, 25);
            comboBox_Yazar.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(65, 199);
            label8.Name = "label8";
            label8.Size = new Size(30, 19);
            label8.TabIndex = 0;
            label8.Text = "Dil:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(32, 167);
            label7.Name = "label7";
            label7.Size = new Size(63, 19);
            label7.TabIndex = 0;
            label7.Text = "Yayınevi:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(22, 230);
            label9.Name = "label9";
            label9.Size = new Size(73, 19);
            label9.TabIndex = 0;
            label9.Text = "Basım Yılı:";
            // 
            // comboBox_Kategori
            // 
            comboBox_Kategori.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_Kategori.Font = new Font("Segoe UI", 10F);
            comboBox_Kategori.FormattingEnabled = true;
            comboBox_Kategori.Location = new Point(101, 103);
            comboBox_Kategori.Name = "comboBox_Kategori";
            comboBox_Kategori.Size = new Size(254, 25);
            comboBox_Kategori.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.Location = new Point(9, 260);
            label11.Name = "label11";
            label11.Size = new Size(86, 19);
            label11.TabIndex = 0;
            label11.Text = "Sayfa Sayısı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(48, 136);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 0;
            label6.Text = "Yazar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(30, 106);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 0;
            label5.Text = "Kategori:";
            // 
            // kitapDtoBindingSource
            // 
            kitapDtoBindingSource.DataSource = typeof(Model.DTO.KitapDto);
            // 
            // textBox_Ara
            // 
            textBox_Ara.Font = new Font("Segoe UI", 10F);
            textBox_Ara.Location = new Point(441, 12);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Arama için metin girin";
            textBox_Ara.Size = new Size(276, 25);
            textBox_Ara.TabIndex = 17;
            textBox_Ara.TextChanged += textBox_Ara_TextChanged;
            // 
            // label_txtAra
            // 
            label_txtAra.AutoSize = true;
            label_txtAra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label_txtAra.ForeColor = Color.FromArgb(64, 64, 64);
            label_txtAra.Location = new Point(384, 15);
            label_txtAra.Name = "label_txtAra";
            label_txtAra.Size = new Size(51, 17);
            label_txtAra.TabIndex = 20;
            label_txtAra.Text = "Arama:";
            // 
            // dataGrid_Kitap
            // 
            dataGrid_Kitap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Kitap.AutoGenerateColumns = false;
            dataGrid_Kitap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Kitap.Columns.AddRange(new DataGridViewColumn[] { kitapIdDataGridViewTextBoxColumn, kitapAdiDataGridViewTextBoxColumn, ıSBNDataGridViewTextBoxColumn, yazarIdDataGridViewTextBoxColumn, yazarAdDataGridViewTextBoxColumn, yazarSoyadDataGridViewTextBoxColumn, yayineviIdDataGridViewTextBoxColumn, yayineviAdDataGridViewTextBoxColumn, kategoriIdDataGridViewTextBoxColumn, kategoriAdiDataGridViewTextBoxColumn, basimYiliDataGridViewTextBoxColumn, sayfaSayisiDataGridViewTextBoxColumn, dilIdDataGridViewTextBoxColumn, dilDataGridViewTextBoxColumn, stokDataGridViewTextBoxColumn, aktifDataGridViewCheckBoxColumn });
            dataGrid_Kitap.DataSource = kitapDtoBindingSource;
            dataGrid_Kitap.Location = new Point(384, 46);
            dataGrid_Kitap.Name = "dataGrid_Kitap";
            dataGrid_Kitap.RowHeadersWidth = 51;
            dataGrid_Kitap.Size = new Size(536, 594);
            dataGrid_Kitap.TabIndex = 21;
            dataGrid_Kitap.CellFormatting += dataGrid_Kitap_CellFormatting;
            dataGrid_Kitap.CellPainting += dataGrid_Kitap_CellPainting;
            dataGrid_Kitap.ColumnHeaderMouseClick += dataGrid_Kitap_ColumnHeaderMouseClick;
            dataGrid_Kitap.SelectionChanged += dataGrid_Kitap_SelectionChanged;
            // 
            // kitapIdDataGridViewTextBoxColumn
            // 
            kitapIdDataGridViewTextBoxColumn.DataPropertyName = "KitapId";
            kitapIdDataGridViewTextBoxColumn.HeaderText = "KitapId";
            kitapIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            kitapIdDataGridViewTextBoxColumn.Name = "kitapIdDataGridViewTextBoxColumn";
            kitapIdDataGridViewTextBoxColumn.Visible = false;
            kitapIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "KitapAdi";
            kitapAdiDataGridViewTextBoxColumn.HeaderText = "Kitap Adı";
            kitapAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            kitapAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıSBNDataGridViewTextBoxColumn
            // 
            ıSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            ıSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            ıSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            ıSBNDataGridViewTextBoxColumn.Name = "ıSBNDataGridViewTextBoxColumn";
            ıSBNDataGridViewTextBoxColumn.Width = 125;
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
            // yazarAdDataGridViewTextBoxColumn
            // 
            yazarAdDataGridViewTextBoxColumn.DataPropertyName = "YazarAd";
            yazarAdDataGridViewTextBoxColumn.HeaderText = "Yazar Adı";
            yazarAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            yazarAdDataGridViewTextBoxColumn.Name = "yazarAdDataGridViewTextBoxColumn";
            yazarAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // yazarSoyadDataGridViewTextBoxColumn
            // 
            yazarSoyadDataGridViewTextBoxColumn.DataPropertyName = "YazarSoyad";
            yazarSoyadDataGridViewTextBoxColumn.HeaderText = "Yazar Soyadı";
            yazarSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            yazarSoyadDataGridViewTextBoxColumn.Name = "yazarSoyadDataGridViewTextBoxColumn";
            yazarSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayineviIdDataGridViewTextBoxColumn
            // 
            yayineviIdDataGridViewTextBoxColumn.DataPropertyName = "YayineviId";
            yayineviIdDataGridViewTextBoxColumn.HeaderText = "YayineviId";
            yayineviIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            yayineviIdDataGridViewTextBoxColumn.Name = "yayineviIdDataGridViewTextBoxColumn";
            yayineviIdDataGridViewTextBoxColumn.Visible = false;
            yayineviIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayineviAdDataGridViewTextBoxColumn
            // 
            yayineviAdDataGridViewTextBoxColumn.DataPropertyName = "YayineviAd";
            yayineviAdDataGridViewTextBoxColumn.HeaderText = "Yayinevi Adı";
            yayineviAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            yayineviAdDataGridViewTextBoxColumn.Name = "yayineviAdDataGridViewTextBoxColumn";
            yayineviAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategoriIdDataGridViewTextBoxColumn
            // 
            kategoriIdDataGridViewTextBoxColumn.DataPropertyName = "KategoriId";
            kategoriIdDataGridViewTextBoxColumn.HeaderText = "KategoriId";
            kategoriIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            kategoriIdDataGridViewTextBoxColumn.Name = "kategoriIdDataGridViewTextBoxColumn";
            kategoriIdDataGridViewTextBoxColumn.Visible = false;
            kategoriIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategoriAdiDataGridViewTextBoxColumn
            // 
            kategoriAdiDataGridViewTextBoxColumn.DataPropertyName = "KategoriAdi";
            kategoriAdiDataGridViewTextBoxColumn.HeaderText = "Kategori Adı";
            kategoriAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            kategoriAdiDataGridViewTextBoxColumn.Name = "kategoriAdiDataGridViewTextBoxColumn";
            kategoriAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // basimYiliDataGridViewTextBoxColumn
            // 
            basimYiliDataGridViewTextBoxColumn.DataPropertyName = "BasimYili";
            basimYiliDataGridViewTextBoxColumn.HeaderText = "Basım Yılı";
            basimYiliDataGridViewTextBoxColumn.MinimumWidth = 6;
            basimYiliDataGridViewTextBoxColumn.Name = "basimYiliDataGridViewTextBoxColumn";
            basimYiliDataGridViewTextBoxColumn.Width = 125;
            // 
            // sayfaSayisiDataGridViewTextBoxColumn
            // 
            sayfaSayisiDataGridViewTextBoxColumn.DataPropertyName = "SayfaSayisi";
            sayfaSayisiDataGridViewTextBoxColumn.HeaderText = "Sayfa Sayısı";
            sayfaSayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            sayfaSayisiDataGridViewTextBoxColumn.Name = "sayfaSayisiDataGridViewTextBoxColumn";
            sayfaSayisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // dilIdDataGridViewTextBoxColumn
            // 
            dilIdDataGridViewTextBoxColumn.DataPropertyName = "DilId";
            dilIdDataGridViewTextBoxColumn.HeaderText = "DilId";
            dilIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            dilIdDataGridViewTextBoxColumn.Name = "dilIdDataGridViewTextBoxColumn";
            dilIdDataGridViewTextBoxColumn.Visible = false;
            dilIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dilDataGridViewTextBoxColumn
            // 
            dilDataGridViewTextBoxColumn.DataPropertyName = "Dil";
            dilDataGridViewTextBoxColumn.HeaderText = "Dil";
            dilDataGridViewTextBoxColumn.MinimumWidth = 6;
            dilDataGridViewTextBoxColumn.Name = "dilDataGridViewTextBoxColumn";
            dilDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            stokDataGridViewTextBoxColumn.MinimumWidth = 6;
            stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            stokDataGridViewTextBoxColumn.Width = 125;
            // 
            // aktifDataGridViewCheckBoxColumn
            // 
            aktifDataGridViewCheckBoxColumn.DataPropertyName = "Aktif";
            aktifDataGridViewCheckBoxColumn.HeaderText = "Aktif";
            aktifDataGridViewCheckBoxColumn.MinimumWidth = 6;
            aktifDataGridViewCheckBoxColumn.Name = "aktifDataGridViewCheckBoxColumn";
            aktifDataGridViewCheckBoxColumn.Visible = false;
            aktifDataGridViewCheckBoxColumn.Width = 125;
            // 
            // frmKitapIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 646);
            Controls.Add(groupBox1);
            Controls.Add(textBox_Ara);
            Controls.Add(label_txtAra);
            Controls.Add(dataGrid_Kitap);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmKitapIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Kitap İşlemleri";
            Load += frmKitapIslemleri_Load;
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kitapDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Kitap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label label11;
        private TextBox textBox_SayfaSayisi;
        private BindingSource kitapDtoBindingSource;
        private TextBox textBox_Ara;
        private Button btnTemizle;
        private Button btnSil;
        private Button btnDuzenle;
        private Button btnKaydet;
        private Button btnGeriYukle;
        private Button btnSilinenleriGoster;
        private Label label_txtAra;
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
        private DataGridViewTextBoxColumn dilIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dilDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}