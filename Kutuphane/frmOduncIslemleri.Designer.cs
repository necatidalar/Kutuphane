namespace Kutuphane.UI
{
    partial class frmOduncIslemleri
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOduncIslemleri));
            mainLayout = new TableLayoutPanel();
            panelLeft = new Panel();
            groupBox_KitapSecimi_OduncVerme = new GroupBox();
            label5 = new Label();
            dateTimePicker_TeslimTarihi = new DateTimePicker();
            btnOduncVer = new Button();
            label4 = new Label();
            listView_Sepet = new ListView();
            listView_KitapListesi = new ListView();
            label3 = new Label();
            label2 = new Label();
            textBox_KitapAra = new TextBox();
            groupBox_UyeIslemleri = new GroupBox();
            listView_Uyeler = new ListView();
            label_SuanOduncteKitapSayisi = new Label();
            label_ToplamAlinanKitapSayisi = new Label();
            label_AdSoyad = new Label();
            label1 = new Label();
            textBox_UyeAra = new TextBox();
            panelRight = new Panel();
            groupBox_TumOduncler = new GroupBox();
            btnTumIadeAl = new Button();
            listView_AlinanTumKitaplarinListesi = new ListView();
            groupBox_IadeIslemleri = new GroupBox();
            btnIadeAl = new Button();
            listView_UyeninAldigiKitapListesi = new ListView();
            mainLayout.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBox_KitapSecimi_OduncVerme.SuspendLayout();
            groupBox_UyeIslemleri.SuspendLayout();
            panelRight.SuspendLayout();
            groupBox_TumOduncler.SuspendLayout();
            groupBox_IadeIslemleri.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayout.Controls.Add(panelLeft, 0, 0);
            mainLayout.Controls.Add(panelRight, 1, 0);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Margin = new Padding(3, 4, 3, 4);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(11, 13, 11, 13);
            mainLayout.RowCount = 1;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(1353, 1207);
            mainLayout.TabIndex = 5;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(groupBox_KitapSecimi_OduncVerme);
            panelLeft.Controls.Add(groupBox_UyeIslemleri);
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(14, 17);
            panelLeft.Margin = new Padding(3, 4, 3, 4);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(0, 0, 6, 0);
            panelLeft.Size = new Size(659, 1173);
            panelLeft.TabIndex = 0;
            // 
            // groupBox_KitapSecimi_OduncVerme
            // 
            groupBox_KitapSecimi_OduncVerme.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_KitapSecimi_OduncVerme.Controls.Add(label5);
            groupBox_KitapSecimi_OduncVerme.Controls.Add(dateTimePicker_TeslimTarihi);
            groupBox_KitapSecimi_OduncVerme.Controls.Add(btnOduncVer);
            groupBox_KitapSecimi_OduncVerme.Controls.Add(label4);
            groupBox_KitapSecimi_OduncVerme.Controls.Add(listView_Sepet);
            groupBox_KitapSecimi_OduncVerme.Controls.Add(listView_KitapListesi);
            groupBox_KitapSecimi_OduncVerme.Controls.Add(label3);
            groupBox_KitapSecimi_OduncVerme.Controls.Add(label2);
            groupBox_KitapSecimi_OduncVerme.Controls.Add(textBox_KitapAra);
            groupBox_KitapSecimi_OduncVerme.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox_KitapSecimi_OduncVerme.ForeColor = Color.DimGray;
            groupBox_KitapSecimi_OduncVerme.Location = new Point(3, 419);
            groupBox_KitapSecimi_OduncVerme.Margin = new Padding(3, 4, 3, 4);
            groupBox_KitapSecimi_OduncVerme.Name = "groupBox_KitapSecimi_OduncVerme";
            groupBox_KitapSecimi_OduncVerme.Padding = new Padding(11, 13, 11, 13);
            groupBox_KitapSecimi_OduncVerme.Size = new Size(652, 750);
            groupBox_KitapSecimi_OduncVerme.TabIndex = 3;
            groupBox_KitapSecimi_OduncVerme.TabStop = false;
            groupBox_KitapSecimi_OduncVerme.Text = "➡️ Kitap Seçimi ve Ödünç Verme";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(17, 636);
            label5.Name = "label5";
            label5.Size = new Size(183, 25);
            label5.TabIndex = 12;
            label5.Text = "En geç teslim tarihi:";
            // 
            // dateTimePicker_TeslimTarihi
            // 
            dateTimePicker_TeslimTarihi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dateTimePicker_TeslimTarihi.CalendarTitleBackColor = SystemColors.ControlText;
            dateTimePicker_TeslimTarihi.CalendarTitleForeColor = Color.DimGray;
            dateTimePicker_TeslimTarihi.Format = DateTimePickerFormat.Short;
            dateTimePicker_TeslimTarihi.Location = new Point(191, 632);
            dateTimePicker_TeslimTarihi.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker_TeslimTarihi.Name = "dateTimePicker_TeslimTarihi";
            dateTimePicker_TeslimTarihi.Size = new Size(119, 32);
            dateTimePicker_TeslimTarihi.TabIndex = 11;
            // 
            // btnOduncVer
            // 
            btnOduncVer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOduncVer.BackColor = Color.FromArgb(39, 174, 96);
            btnOduncVer.Cursor = Cursors.Hand;
            btnOduncVer.FlatAppearance.BorderSize = 0;
            btnOduncVer.FlatStyle = FlatStyle.Flat;
            btnOduncVer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnOduncVer.ForeColor = Color.White;
            btnOduncVer.Location = new Point(15, 676);
            btnOduncVer.Margin = new Padding(3, 4, 3, 4);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(622, 60);
            btnOduncVer.TabIndex = 10;
            btnOduncVer.Text = "✅ SEÇİLİ ÖĞRENCİYE ÖDÜNÇ VER";
            btnOduncVer.UseVisualStyleBackColor = false;
            btnOduncVer.Click += button_OduncVer_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(15, 400);
            label4.Name = "label4";
            label4.Size = new Size(202, 23);
            label4.TabIndex = 7;
            label4.Text = "\U0001f6d2 Sepet (Eklenecekler)";
            // 
            // listView_Sepet
            // 
            listView_Sepet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView_Sepet.BackColor = Color.FloralWhite;
            listView_Sepet.BorderStyle = BorderStyle.FixedSingle;
            listView_Sepet.Font = new Font("Segoe UI", 10F);
            listView_Sepet.FullRowSelect = true;
            listView_Sepet.GridLines = true;
            listView_Sepet.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView_Sepet.Location = new Point(15, 429);
            listView_Sepet.Margin = new Padding(3, 4, 3, 4);
            listView_Sepet.MultiSelect = false;
            listView_Sepet.Name = "listView_Sepet";
            listView_Sepet.Size = new Size(622, 194);
            listView_Sepet.TabIndex = 6;
            listView_Sepet.UseCompatibleStateImageBehavior = false;
            listView_Sepet.View = View.Details;
            listView_Sepet.DoubleClick += listView_Sepet_DoubleClick;
            // 
            // listView_KitapListesi
            // 
            listView_KitapListesi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView_KitapListesi.BorderStyle = BorderStyle.FixedSingle;
            listView_KitapListesi.Font = new Font("Segoe UI", 10F);
            listView_KitapListesi.FullRowSelect = true;
            listView_KitapListesi.GridLines = true;
            listView_KitapListesi.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView_KitapListesi.Location = new Point(15, 143);
            listView_KitapListesi.Margin = new Padding(3, 4, 3, 4);
            listView_KitapListesi.Name = "listView_KitapListesi";
            listView_KitapListesi.RightToLeft = RightToLeft.Yes;
            listView_KitapListesi.Size = new Size(622, 246);
            listView_KitapListesi.TabIndex = 5;
            listView_KitapListesi.UseCompatibleStateImageBehavior = false;
            listView_KitapListesi.View = View.Details;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(15, 113);
            label3.Name = "label3";
            label3.Size = new Size(160, 23);
            label3.TabIndex = 3;
            label3.Text = "📚 Arama Sonucu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(15, 41);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 3;
            label2.Text = "Kitap Ara:";
            // 
            // textBox_KitapAra
            // 
            textBox_KitapAra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_KitapAra.Font = new Font("Segoe UI", 11F);
            textBox_KitapAra.Location = new Point(15, 71);
            textBox_KitapAra.Margin = new Padding(3, 4, 3, 4);
            textBox_KitapAra.Name = "textBox_KitapAra";
            textBox_KitapAra.PlaceholderText = "🔍 Kitap adı, ISBN veya yazar ile ara; çift tıkla sepete ekle";
            textBox_KitapAra.Size = new Size(621, 32);
            textBox_KitapAra.TabIndex = 2;
            textBox_KitapAra.TextChanged += textBox_KitapAra_TextChanged;
            // 
            // groupBox_UyeIslemleri
            // 
            groupBox_UyeIslemleri.Controls.Add(listView_Uyeler);
            groupBox_UyeIslemleri.Controls.Add(label_SuanOduncteKitapSayisi);
            groupBox_UyeIslemleri.Controls.Add(label_ToplamAlinanKitapSayisi);
            groupBox_UyeIslemleri.Controls.Add(label_AdSoyad);
            groupBox_UyeIslemleri.Controls.Add(label1);
            groupBox_UyeIslemleri.Controls.Add(textBox_UyeAra);
            groupBox_UyeIslemleri.Dock = DockStyle.Top;
            groupBox_UyeIslemleri.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox_UyeIslemleri.ForeColor = Color.DimGray;
            groupBox_UyeIslemleri.Location = new Point(0, 0);
            groupBox_UyeIslemleri.Margin = new Padding(3, 4, 3, 4);
            groupBox_UyeIslemleri.Name = "groupBox_UyeIslemleri";
            groupBox_UyeIslemleri.Padding = new Padding(3, 4, 3, 4);
            groupBox_UyeIslemleri.Size = new Size(653, 411);
            groupBox_UyeIslemleri.TabIndex = 2;
            groupBox_UyeIslemleri.TabStop = false;
            groupBox_UyeIslemleri.Text = "🎓 Öğrenci Seçimi";
            // 
            // listView_Uyeler
            // 
            listView_Uyeler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView_Uyeler.BorderStyle = BorderStyle.FixedSingle;
            listView_Uyeler.Font = new Font("Segoe UI", 10F);
            listView_Uyeler.FullRowSelect = true;
            listView_Uyeler.GridLines = true;
            listView_Uyeler.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView_Uyeler.Location = new Point(21, 168);
            listView_Uyeler.Margin = new Padding(3, 4, 3, 4);
            listView_Uyeler.Name = "listView_Uyeler";
            listView_Uyeler.RightToLeft = RightToLeft.Yes;
            listView_Uyeler.Size = new Size(616, 226);
            listView_Uyeler.TabIndex = 12;
            listView_Uyeler.UseCompatibleStateImageBehavior = false;
            listView_Uyeler.View = View.Details;
            listView_Uyeler.SelectedIndexChanged += listView_Uyeler_SelectedIndexChanged;
            // 
            // label_SuanOduncteKitapSayisi
            // 
            label_SuanOduncteKitapSayisi.AutoSize = true;
            label_SuanOduncteKitapSayisi.Font = new Font("Segoe UI", 10F);
            label_SuanOduncteKitapSayisi.ForeColor = Color.FromArgb(192, 57, 43);
            label_SuanOduncteKitapSayisi.Location = new Point(438, 127);
            label_SuanOduncteKitapSayisi.Name = "label_SuanOduncteKitapSayisi";
            label_SuanOduncteKitapSayisi.Size = new Size(142, 23);
            label_SuanOduncteKitapSayisi.TabIndex = 11;
            label_SuanOduncteKitapSayisi.Text = "Şu an Ödünçte: 0";
            // 
            // label_ToplamAlinanKitapSayisi
            // 
            label_ToplamAlinanKitapSayisi.AutoSize = true;
            label_ToplamAlinanKitapSayisi.Font = new Font("Segoe UI", 10F);
            label_ToplamAlinanKitapSayisi.ForeColor = Color.FromArgb(41, 128, 185);
            label_ToplamAlinanKitapSayisi.Location = new Point(279, 127);
            label_ToplamAlinanKitapSayisi.Name = "label_ToplamAlinanKitapSayisi";
            label_ToplamAlinanKitapSayisi.Size = new Size(136, 23);
            label_ToplamAlinanKitapSayisi.TabIndex = 11;
            label_ToplamAlinanKitapSayisi.Text = "Toplam Alınan: 0";
            // 
            // label_AdSoyad
            // 
            label_AdSoyad.AutoSize = true;
            label_AdSoyad.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label_AdSoyad.ForeColor = Color.FromArgb(44, 62, 80);
            label_AdSoyad.Location = new Point(21, 120);
            label_AdSoyad.Name = "label_AdSoyad";
            label_AdSoyad.Size = new Size(205, 32);
            label_AdSoyad.TabIndex = 11;
            label_AdSoyad.Text = "Seçili Öğrenci: -YOK-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(16, 37);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 1;
            label1.Text = "Okul No / Öğrenci Ara:";
            // 
            // textBox_UyeAra
            // 
            textBox_UyeAra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_UyeAra.Font = new Font("Segoe UI", 11F);
            textBox_UyeAra.Location = new Point(21, 67);
            textBox_UyeAra.Margin = new Padding(3, 4, 3, 4);
            textBox_UyeAra.Name = "textBox_UyeAra";
            textBox_UyeAra.PlaceholderText = "Okul numarası yazınca öğrenci otomatik seçilir";
            textBox_UyeAra.Size = new Size(616, 32);
            textBox_UyeAra.TabIndex = 0;
            textBox_UyeAra.TextChanged += textBox_UyeAra_TextChanged;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(groupBox_TumOduncler);
            panelRight.Controls.Add(groupBox_IadeIslemleri);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(679, 17);
            panelRight.Margin = new Padding(3, 4, 3, 4);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(6, 0, 0, 0);
            panelRight.Size = new Size(660, 1173);
            panelRight.TabIndex = 1;
            // 
            // groupBox_TumOduncler
            // 
            groupBox_TumOduncler.Controls.Add(btnTumIadeAl);
            groupBox_TumOduncler.Controls.Add(listView_AlinanTumKitaplarinListesi);
            groupBox_TumOduncler.Dock = DockStyle.Fill;
            groupBox_TumOduncler.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox_TumOduncler.ForeColor = Color.DimGray;
            groupBox_TumOduncler.Location = new Point(6, 485);
            groupBox_TumOduncler.Margin = new Padding(3, 4, 3, 4);
            groupBox_TumOduncler.Name = "groupBox_TumOduncler";
            groupBox_TumOduncler.Padding = new Padding(11, 13, 11, 13);
            groupBox_TumOduncler.Size = new Size(654, 688);
            groupBox_TumOduncler.TabIndex = 5;
            groupBox_TumOduncler.TabStop = false;
            groupBox_TumOduncler.Text = "Tüm Ödünç Kitaplar";
            // 
            // btnTumIadeAl
            // 
            btnTumIadeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTumIadeAl.BackColor = Color.FromArgb(192, 57, 43);
            btnTumIadeAl.Cursor = Cursors.Hand;
            btnTumIadeAl.FlatAppearance.BorderSize = 0;
            btnTumIadeAl.FlatStyle = FlatStyle.Flat;
            btnTumIadeAl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnTumIadeAl.ForeColor = Color.White;
            btnTumIadeAl.Location = new Point(15, 609);
            btnTumIadeAl.Margin = new Padding(3, 4, 3, 4);
            btnTumIadeAl.Name = "btnTumIadeAl";
            btnTumIadeAl.Size = new Size(625, 60);
            btnTumIadeAl.TabIndex = 10;
            btnTumIadeAl.Text = "❌ SEÇİLİ KİTABI İADE AL";
            btnTumIadeAl.UseVisualStyleBackColor = false;
            btnTumIadeAl.Click += button_TumIadeAl_Click;
            // 
            // listView_AlinanTumKitaplarinListesi
            // 
            listView_AlinanTumKitaplarinListesi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView_AlinanTumKitaplarinListesi.BorderStyle = BorderStyle.FixedSingle;
            listView_AlinanTumKitaplarinListesi.CheckBoxes = true;
            listView_AlinanTumKitaplarinListesi.Font = new Font("Segoe UI", 10F);
            listView_AlinanTumKitaplarinListesi.ForeColor = SystemColors.WindowText;
            listView_AlinanTumKitaplarinListesi.FullRowSelect = true;
            listView_AlinanTumKitaplarinListesi.GridLines = true;
            listView_AlinanTumKitaplarinListesi.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView_AlinanTumKitaplarinListesi.Location = new Point(15, 47);
            listView_AlinanTumKitaplarinListesi.Margin = new Padding(3, 4, 3, 4);
            listView_AlinanTumKitaplarinListesi.MultiSelect = false;
            listView_AlinanTumKitaplarinListesi.Name = "listView_AlinanTumKitaplarinListesi";
            listView_AlinanTumKitaplarinListesi.Size = new Size(624, 554);
            listView_AlinanTumKitaplarinListesi.TabIndex = 6;
            listView_AlinanTumKitaplarinListesi.UseCompatibleStateImageBehavior = false;
            listView_AlinanTumKitaplarinListesi.View = View.Details;
            // 
            // groupBox_IadeIslemleri
            // 
            groupBox_IadeIslemleri.Controls.Add(btnIadeAl);
            groupBox_IadeIslemleri.Controls.Add(listView_UyeninAldigiKitapListesi);
            groupBox_IadeIslemleri.Dock = DockStyle.Top;
            groupBox_IadeIslemleri.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox_IadeIslemleri.ForeColor = Color.DimGray;
            groupBox_IadeIslemleri.Location = new Point(6, 0);
            groupBox_IadeIslemleri.Margin = new Padding(3, 4, 3, 4);
            groupBox_IadeIslemleri.Name = "groupBox_IadeIslemleri";
            groupBox_IadeIslemleri.Padding = new Padding(11, 13, 11, 13);
            groupBox_IadeIslemleri.Size = new Size(654, 485);
            groupBox_IadeIslemleri.TabIndex = 4;
            groupBox_IadeIslemleri.TabStop = false;
            groupBox_IadeIslemleri.Text = "↩️ İade Alma İşlemi (Öğrencinin Ödünçleri)";
            // 
            // btnIadeAl
            // 
            btnIadeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnIadeAl.BackColor = Color.FromArgb(192, 57, 43);
            btnIadeAl.Cursor = Cursors.Hand;
            btnIadeAl.FlatAppearance.BorderSize = 0;
            btnIadeAl.FlatStyle = FlatStyle.Flat;
            btnIadeAl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIadeAl.ForeColor = Color.White;
            btnIadeAl.Location = new Point(15, 407);
            btnIadeAl.Margin = new Padding(3, 4, 3, 4);
            btnIadeAl.Name = "btnIadeAl";
            btnIadeAl.Size = new Size(625, 60);
            btnIadeAl.TabIndex = 9;
            btnIadeAl.Text = "❌ SEÇİLİ KİTABI İADE AL";
            btnIadeAl.UseVisualStyleBackColor = false;
            btnIadeAl.Click += button_IadeAl_Click;
            // 
            // listView_UyeninAldigiKitapListesi
            // 
            listView_UyeninAldigiKitapListesi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView_UyeninAldigiKitapListesi.BorderStyle = BorderStyle.FixedSingle;
            listView_UyeninAldigiKitapListesi.CheckBoxes = true;
            listView_UyeninAldigiKitapListesi.Font = new Font("Segoe UI", 10F);
            listView_UyeninAldigiKitapListesi.ForeColor = SystemColors.WindowText;
            listView_UyeninAldigiKitapListesi.FullRowSelect = true;
            listView_UyeninAldigiKitapListesi.GridLines = true;
            listView_UyeninAldigiKitapListesi.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView_UyeninAldigiKitapListesi.Location = new Point(15, 45);
            listView_UyeninAldigiKitapListesi.Margin = new Padding(3, 4, 3, 4);
            listView_UyeninAldigiKitapListesi.MultiSelect = false;
            listView_UyeninAldigiKitapListesi.Name = "listView_UyeninAldigiKitapListesi";
            listView_UyeninAldigiKitapListesi.RightToLeft = RightToLeft.Yes;
            listView_UyeninAldigiKitapListesi.Size = new Size(624, 349);
            listView_UyeninAldigiKitapListesi.TabIndex = 6;
            listView_UyeninAldigiKitapListesi.UseCompatibleStateImageBehavior = false;
            listView_UyeninAldigiKitapListesi.View = View.Details;
            // 
            // frmOduncIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1353, 1207);
            Controls.Add(mainLayout);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1083, 918);
            Name = "frmOduncIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Okul No ile Ödünç ve İade Yönetimi";
            Load += frmOduncIslemleri_Load;
            mainLayout.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            groupBox_KitapSecimi_OduncVerme.ResumeLayout(false);
            groupBox_KitapSecimi_OduncVerme.PerformLayout();
            groupBox_UyeIslemleri.ResumeLayout(false);
            groupBox_UyeIslemleri.PerformLayout();
            panelRight.ResumeLayout(false);
            groupBox_TumOduncler.ResumeLayout(false);
            groupBox_IadeIslemleri.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;

        // GroupBoxes
        private System.Windows.Forms.GroupBox groupBox_UyeIslemleri;
        private System.Windows.Forms.GroupBox groupBox_KitapSecimi_OduncVerme;
        private System.Windows.Forms.GroupBox groupBox_IadeIslemleri;

        // Üye İşlemleri
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_UyeAra;
        private System.Windows.Forms.Label label_AdSoyad;
        private System.Windows.Forms.Label label_ToplamAlinanKitapSayisi;
        private System.Windows.Forms.Label label_SuanOduncteKitapSayisi;
        private System.Windows.Forms.ListView listView_Uyeler;

        // Kitap Seçimi
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_KitapAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView_KitapListesi;

        // Sepet
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView_Sepet;
        private System.Windows.Forms.Button btnOduncVer;

        // İade
        private System.Windows.Forms.Button btnIadeAl;
        private System.Windows.Forms.ListView listView_UyeninAldigiKitapListesi;
        private GroupBox groupBox4;
        private Button button1;
        private DateTimePicker dateTimePicker_TeslimTarihi;
        private Label label5;
        private GroupBox groupBox_TumOduncler;
        private ListView listView_AlinanTumKitaplarinListesi;
        private Button btnTumIadeAl;
    }
}