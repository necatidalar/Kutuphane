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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapIslemleri));
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
            kitapDtoBindingSource = new BindingSource(components);
            textBox_Ara = new TextBox();
            aktifDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            stokDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dilDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dilIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sayfaSayisiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            basimYiliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yayineviAdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yayineviIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yazarSoyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yazarAdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yazarIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ıSBNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kitapAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kitapIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGrid_Kitap = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kitapDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Kitap).BeginInit();
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
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 600);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap İşlemleri";
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.BackColor = Color.FromArgb(52, 73, 94);
            btnGeriYukle.FlatAppearance.BorderSize = 0;
            btnGeriYukle.FlatStyle = FlatStyle.Flat;
            btnGeriYukle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeriYukle.ForeColor = Color.White;
            btnGeriYukle.Location = new Point(125, 541);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(201, 35);
            btnGeriYukle.TabIndex = 16;
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
            btnSilinenleriGoster.Location = new Point(125, 500);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(201, 35);
            btnSilinenleriGoster.TabIndex = 14;
            btnSilinenleriGoster.Text = "🗑️ Silinen Kategorileri Göster";
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
            btnTemizle.Location = new Point(125, 459);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(201, 35);
            btnTemizle.TabIndex = 13;
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
            btnSil.Location = new Point(125, 418);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(201, 35);
            btnSil.TabIndex = 12;
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
            btnDuzenle.Location = new Point(125, 377);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(201, 35);
            btnDuzenle.TabIndex = 11;
            btnDuzenle.Text = "✏️ Düzenle";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(39, 174, 96);
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(125, 336);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(201, 35);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "➕ Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // comboBox_Dil
            // 
            comboBox_Dil.Font = new Font("Segoe UI", 10F);
            comboBox_Dil.FormattingEnabled = true;
            comboBox_Dil.Location = new Point(111, 212);
            comboBox_Dil.Name = "comboBox_Dil";
            comboBox_Dil.Size = new Size(228, 25);
            comboBox_Dil.TabIndex = 6;
            // 
            // comboBox_Yayinevi
            // 
            comboBox_Yayinevi.Font = new Font("Segoe UI", 10F);
            comboBox_Yayinevi.FormattingEnabled = true;
            comboBox_Yayinevi.Location = new Point(111, 181);
            comboBox_Yayinevi.Name = "comboBox_Yayinevi";
            comboBox_Yayinevi.Size = new Size(228, 25);
            comboBox_Yayinevi.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.Location = new Point(16, 308);
            label10.Name = "label10";
            label10.Size = new Size(89, 19);
            label10.TabIndex = 0;
            label10.Text = "Stok Miktarı:";
            // 
            // comboBox_Yazar
            // 
            comboBox_Yazar.Font = new Font("Segoe UI", 10F);
            comboBox_Yazar.FormattingEnabled = true;
            comboBox_Yazar.Location = new Point(111, 150);
            comboBox_Yazar.Name = "comboBox_Yazar";
            comboBox_Yazar.Size = new Size(228, 25);
            comboBox_Yazar.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(42, 184);
            label7.Name = "label7";
            label7.Size = new Size(63, 19);
            label7.TabIndex = 0;
            label7.Text = "Yayınevi:";
            // 
            // comboBox_Kategori
            // 
            comboBox_Kategori.Font = new Font("Segoe UI", 10F);
            comboBox_Kategori.FormattingEnabled = true;
            comboBox_Kategori.Location = new Point(111, 119);
            comboBox_Kategori.Name = "comboBox_Kategori";
            comboBox_Kategori.Size = new Size(228, 25);
            comboBox_Kategori.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(59, 153);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 0;
            label6.Text = "Yazar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(40, 122);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 0;
            label5.Text = "Kategori:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.Location = new Point(19, 277);
            label11.Name = "label11";
            label11.Size = new Size(86, 19);
            label11.TabIndex = 0;
            label11.Text = "Sayfa Sayısı:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(32, 246);
            label9.Name = "label9";
            label9.Size = new Size(73, 19);
            label9.TabIndex = 0;
            label9.Text = "Basım Yılı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(75, 215);
            label8.Name = "label8";
            label8.Size = new Size(30, 19);
            label8.TabIndex = 0;
            label8.Text = "Dil:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(35, 91);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 0;
            label4.Text = "Kitap Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(62, 60);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 0;
            label3.Text = "ISBN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(44, 29);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 0;
            label2.Text = "Kitap Id:";
            // 
            // textBox_SayfaSayisi
            // 
            textBox_SayfaSayisi.Font = new Font("Segoe UI", 10F);
            textBox_SayfaSayisi.Location = new Point(111, 274);
            textBox_SayfaSayisi.Name = "textBox_SayfaSayisi";
            textBox_SayfaSayisi.Size = new Size(228, 25);
            textBox_SayfaSayisi.TabIndex = 8;
            // 
            // textBox_BasimYili
            // 
            textBox_BasimYili.Font = new Font("Segoe UI", 10F);
            textBox_BasimYili.Location = new Point(111, 243);
            textBox_BasimYili.Name = "textBox_BasimYili";
            textBox_BasimYili.Size = new Size(228, 25);
            textBox_BasimYili.TabIndex = 7;
            // 
            // textBox_StokMiktari
            // 
            textBox_StokMiktari.Font = new Font("Segoe UI", 10F);
            textBox_StokMiktari.Location = new Point(111, 305);
            textBox_StokMiktari.Name = "textBox_StokMiktari";
            textBox_StokMiktari.Size = new Size(228, 25);
            textBox_StokMiktari.TabIndex = 9;
            // 
            // textBox_KitapAdi
            // 
            textBox_KitapAdi.Font = new Font("Segoe UI", 10F);
            textBox_KitapAdi.Location = new Point(111, 88);
            textBox_KitapAdi.Name = "textBox_KitapAdi";
            textBox_KitapAdi.Size = new Size(228, 25);
            textBox_KitapAdi.TabIndex = 2;
            // 
            // textBox_ISBN
            // 
            textBox_ISBN.Font = new Font("Segoe UI", 10F);
            textBox_ISBN.Location = new Point(111, 57);
            textBox_ISBN.Name = "textBox_ISBN";
            textBox_ISBN.Size = new Size(228, 25);
            textBox_ISBN.TabIndex = 1;
            // 
            // textBox_KitapId
            // 
            textBox_KitapId.Enabled = false;
            textBox_KitapId.Font = new Font("Segoe UI", 10F);
            textBox_KitapId.Location = new Point(111, 26);
            textBox_KitapId.Name = "textBox_KitapId";
            textBox_KitapId.Size = new Size(228, 25);
            textBox_KitapId.TabIndex = 0;
            // 
            // kitapDtoBindingSource
            // 
            kitapDtoBindingSource.DataSource = typeof(Model.DTO.KitapDto);
            // 
            // textBox_Ara
            // 
            textBox_Ara.Font = new Font("Segoe UI", 10F);
            textBox_Ara.Location = new Point(438, 13);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Arama için metin girin";
            textBox_Ara.Size = new Size(276, 25);
            textBox_Ara.TabIndex = 17;
            textBox_Ara.TextChanged += textBox_Ara_TextChanged;
            // 
            // aktifDataGridViewCheckBoxColumn
            // 
            aktifDataGridViewCheckBoxColumn.DataPropertyName = "Aktif";
            aktifDataGridViewCheckBoxColumn.HeaderText = "Aktif";
            aktifDataGridViewCheckBoxColumn.Name = "aktifDataGridViewCheckBoxColumn";
            aktifDataGridViewCheckBoxColumn.Visible = false;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            stokDataGridViewTextBoxColumn.HeaderText = "Stok Miktarı";
            stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // dilDataGridViewTextBoxColumn
            // 
            dilDataGridViewTextBoxColumn.DataPropertyName = "Dil";
            dilDataGridViewTextBoxColumn.HeaderText = "Dil";
            dilDataGridViewTextBoxColumn.Name = "dilDataGridViewTextBoxColumn";
            // 
            // dilIdDataGridViewTextBoxColumn
            // 
            dilIdDataGridViewTextBoxColumn.DataPropertyName = "DilId";
            dilIdDataGridViewTextBoxColumn.HeaderText = "DilId";
            dilIdDataGridViewTextBoxColumn.Name = "dilIdDataGridViewTextBoxColumn";
            dilIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // sayfaSayisiDataGridViewTextBoxColumn
            // 
            sayfaSayisiDataGridViewTextBoxColumn.DataPropertyName = "SayfaSayisi";
            sayfaSayisiDataGridViewTextBoxColumn.HeaderText = "Sayfa Sayısı";
            sayfaSayisiDataGridViewTextBoxColumn.Name = "sayfaSayisiDataGridViewTextBoxColumn";
            // 
            // basimYiliDataGridViewTextBoxColumn
            // 
            basimYiliDataGridViewTextBoxColumn.DataPropertyName = "BasimYili";
            basimYiliDataGridViewTextBoxColumn.HeaderText = "Basım Yılı";
            basimYiliDataGridViewTextBoxColumn.Name = "basimYiliDataGridViewTextBoxColumn";
            // 
            // kategoriAdiDataGridViewTextBoxColumn
            // 
            kategoriAdiDataGridViewTextBoxColumn.DataPropertyName = "KategoriAdi";
            kategoriAdiDataGridViewTextBoxColumn.HeaderText = "Kategori Adı";
            kategoriAdiDataGridViewTextBoxColumn.Name = "kategoriAdiDataGridViewTextBoxColumn";
            // 
            // kategoriIdDataGridViewTextBoxColumn
            // 
            kategoriIdDataGridViewTextBoxColumn.DataPropertyName = "KategoriId";
            kategoriIdDataGridViewTextBoxColumn.HeaderText = "KategoriId";
            kategoriIdDataGridViewTextBoxColumn.Name = "kategoriIdDataGridViewTextBoxColumn";
            kategoriIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // yayineviAdDataGridViewTextBoxColumn
            // 
            yayineviAdDataGridViewTextBoxColumn.DataPropertyName = "YayineviAd";
            yayineviAdDataGridViewTextBoxColumn.HeaderText = "Yayınevi Adı";
            yayineviAdDataGridViewTextBoxColumn.Name = "yayineviAdDataGridViewTextBoxColumn";
            // 
            // yayineviIdDataGridViewTextBoxColumn
            // 
            yayineviIdDataGridViewTextBoxColumn.DataPropertyName = "YayineviId";
            yayineviIdDataGridViewTextBoxColumn.HeaderText = "YayineviId";
            yayineviIdDataGridViewTextBoxColumn.Name = "yayineviIdDataGridViewTextBoxColumn";
            yayineviIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // yazarSoyadDataGridViewTextBoxColumn
            // 
            yazarSoyadDataGridViewTextBoxColumn.DataPropertyName = "YazarSoyad";
            yazarSoyadDataGridViewTextBoxColumn.HeaderText = "Yazar Soyadı";
            yazarSoyadDataGridViewTextBoxColumn.Name = "yazarSoyadDataGridViewTextBoxColumn";
            // 
            // yazarAdDataGridViewTextBoxColumn
            // 
            yazarAdDataGridViewTextBoxColumn.DataPropertyName = "YazarAd";
            yazarAdDataGridViewTextBoxColumn.HeaderText = "Yazar Adı";
            yazarAdDataGridViewTextBoxColumn.Name = "yazarAdDataGridViewTextBoxColumn";
            // 
            // yazarIdDataGridViewTextBoxColumn
            // 
            yazarIdDataGridViewTextBoxColumn.DataPropertyName = "YazarId";
            yazarIdDataGridViewTextBoxColumn.HeaderText = "YazarId";
            yazarIdDataGridViewTextBoxColumn.Name = "yazarIdDataGridViewTextBoxColumn";
            yazarIdDataGridViewTextBoxColumn.Visible = false;
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
            // kitapIdDataGridViewTextBoxColumn
            // 
            kitapIdDataGridViewTextBoxColumn.DataPropertyName = "KitapId";
            kitapIdDataGridViewTextBoxColumn.HeaderText = "KitapId";
            kitapIdDataGridViewTextBoxColumn.Name = "kitapIdDataGridViewTextBoxColumn";
            kitapIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGrid_Kitap
            // 
            dataGrid_Kitap.AllowUserToDeleteRows = false;
            dataGrid_Kitap.AllowUserToOrderColumns = true;
            dataGrid_Kitap.AllowUserToResizeRows = false;
            dataGrid_Kitap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Kitap.AutoGenerateColumns = false;
            dataGrid_Kitap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Kitap.BackgroundColor = Color.White;
            dataGrid_Kitap.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid_Kitap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Kitap.ColumnHeadersHeight = 30;
            dataGrid_Kitap.Columns.AddRange(new DataGridViewColumn[] { kitapIdDataGridViewTextBoxColumn, kitapAdiDataGridViewTextBoxColumn, ıSBNDataGridViewTextBoxColumn, yazarIdDataGridViewTextBoxColumn, yazarAdDataGridViewTextBoxColumn, yazarSoyadDataGridViewTextBoxColumn, yayineviIdDataGridViewTextBoxColumn, yayineviAdDataGridViewTextBoxColumn, kategoriIdDataGridViewTextBoxColumn, kategoriAdiDataGridViewTextBoxColumn, basimYiliDataGridViewTextBoxColumn, sayfaSayisiDataGridViewTextBoxColumn, dilIdDataGridViewTextBoxColumn, dilDataGridViewTextBoxColumn, stokDataGridViewTextBoxColumn, aktifDataGridViewCheckBoxColumn });
            dataGrid_Kitap.DataSource = kitapDtoBindingSource;
            dataGrid_Kitap.EnableHeadersVisualStyles = false;
            dataGrid_Kitap.GridColor = Color.LightGray;
            dataGrid_Kitap.Location = new Point(381, 44);
            dataGrid_Kitap.MultiSelect = false;
            dataGrid_Kitap.Name = "dataGrid_Kitap";
            dataGrid_Kitap.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(170, 204, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGrid_Kitap.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGrid_Kitap.RowTemplate.Height = 32;
            dataGrid_Kitap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Kitap.Size = new Size(831, 600);
            dataGrid_Kitap.TabIndex = 19;
            dataGrid_Kitap.CellPainting += dataGrid_Kitap_CellPainting;
            dataGrid_Kitap.ColumnHeaderMouseClick += dataGrid_Kitap_ColumnHeaderMouseClick;
            dataGrid_Kitap.SelectionChanged += dataGrid_Kitap_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(381, 16);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 20;
            label1.Text = "Arama:";
            // 
            // frmKitapIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 661);
            Controls.Add(label1);
            Controls.Add(textBox_Ara);
            Controls.Add(dataGrid_Kitap);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmKitapIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Kitap İşlemleri";
            Load += frmKitapIslemleri_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        private DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        private DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dilDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dilIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sayfaSayisiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn basimYiliDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yayineviAdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yayineviIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarSoyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarAdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ıSBNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapIdDataGridViewTextBoxColumn;
        private DataGridView dataGrid_Kitap;
        private Button btnGeriYukle;
        private Button btnSilinenleriGoster;
        private Label label1;
    }
}