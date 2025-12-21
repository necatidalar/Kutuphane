namespace Kutuphane.UI
{
    partial class frmOduncIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOduncIslemleri));
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_OduncVer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listView_Sepet = new System.Windows.Forms.ListView();
            this.colSepetAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSepetYazar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_KitapListesi = new System.Windows.Forms.ListView();
            this.colKitapAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colYazar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_KitapAra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_SuanOduncteKitapSayisi = new System.Windows.Forms.Label();
            this.label_ToplamAlinanKitapSayisi = new System.Windows.Forms.Label();
            this.label_AdSoyad = new System.Windows.Forms.Label();
            this.button_UyeAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_UyeAra = new System.Windows.Forms.TextBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_IadeAl = new System.Windows.Forms.Button();
            this.listView_UyeninAldigiKitapListesi = new System.Windows.Forms.ListView();
            this.colUyeKitapAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVerilisTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTeslimTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainLayout.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.Controls.Add(this.panelLeft, 0, 0);
            this.mainLayout.Controls.Add(this.panelRight, 1, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Padding = new System.Windows.Forms.Padding(10);
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(1100, 750);
            this.mainLayout.TabIndex = 5;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBox2);
            this.panelLeft.Controls.Add(this.groupBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(13, 13);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(534, 724);
            this.panelLeft.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button_OduncVer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listView_Sepet);
            this.groupBox2.Controls.Add(this.listView_KitapListesi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_KitapAra);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(3, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(528, 553);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "➡️ Ödünç Verme İşlemleri";
            // 
            // button_OduncVer
            // 
            this.button_OduncVer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OduncVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button_OduncVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OduncVer.FlatAppearance.BorderSize = 0;
            this.button_OduncVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OduncVer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_OduncVer.ForeColor = System.Drawing.Color.White;
            this.button_OduncVer.Location = new System.Drawing.Point(13, 497);
            this.button_OduncVer.Name = "button_OduncVer";
            this.button_OduncVer.Size = new System.Drawing.Size(502, 45);
            this.button_OduncVer.TabIndex = 10;
            this.button_OduncVer.Text = "✅ İŞLEMİ TAMAMLA VE ÖDÜNÇ VER";
            this.button_OduncVer.UseVisualStyleBackColor = false;
            this.button_OduncVer.Click += new System.EventHandler(this.button_OduncVer_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(13, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "🧺 Sepet (Eklenecekler)";
            // 
            // listView_Sepet
            // 
            this.listView_Sepet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Sepet.BackColor = System.Drawing.Color.FloralWhite;
            this.listView_Sepet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_Sepet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSepetAd,
            this.colSepetYazar});
            this.listView_Sepet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listView_Sepet.FullRowSelect = true;
            this.listView_Sepet.GridLines = true;
            this.listView_Sepet.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Sepet.HideSelection = false;
            this.listView_Sepet.Location = new System.Drawing.Point(13, 312);
            this.listView_Sepet.Name = "listView_Sepet";
            this.listView_Sepet.Size = new System.Drawing.Size(502, 170);
            this.listView_Sepet.TabIndex = 6;
            this.listView_Sepet.UseCompatibleStateImageBehavior = false;
            this.listView_Sepet.View = System.Windows.Forms.View.Details;
            // 
            // colSepetAd
            // 
            this.colSepetAd.Text = "Kitap Adı";
            this.colSepetAd.Width = 250;
            // 
            // colSepetYazar
            // 
            this.colSepetYazar.Text = "Yazar";
            this.colSepetYazar.Width = 150;
            // 
            // listView_KitapListesi
            // 
            this.listView_KitapListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_KitapListesi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_KitapListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colKitapAd,
            this.colYazar,
            this.colStok});
            this.listView_KitapListesi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listView_KitapListesi.FullRowSelect = true;
            this.listView_KitapListesi.GridLines = true;
            this.listView_KitapListesi.HideSelection = false;
            this.listView_KitapListesi.Location = new System.Drawing.Point(13, 107);
            this.listView_KitapListesi.Name = "listView_KitapListesi";
            this.listView_KitapListesi.Size = new System.Drawing.Size(502, 170);
            this.listView_KitapListesi.TabIndex = 5;
            this.listView_KitapListesi.UseCompatibleStateImageBehavior = false;
            this.listView_KitapListesi.View = System.Windows.Forms.View.Details;
            // 
            // colKitapAd
            // 
            this.colKitapAd.Text = "Kitap Adı";
            this.colKitapAd.Width = 200;
            // 
            // colYazar
            // 
            this.colYazar.Text = "Yazar";
            this.colYazar.Width = 130;
            // 
            // colStok
            // 
            this.colStok.Text = "Stok";
            this.colStok.Width = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "📚 Arama Sonucu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Ara:";
            // 
            // textBox_KitapAra
            // 
            this.textBox_KitapAra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_KitapAra.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox_KitapAra.Location = new System.Drawing.Point(13, 53);
            this.textBox_KitapAra.Name = "textBox_KitapAra";
            this.textBox_KitapAra.PlaceholderText = "🔍 ISBN / Kitap Adı / Yazar ile arayın";
            this.textBox_KitapAra.Size = new System.Drawing.Size(502, 27);
            this.textBox_KitapAra.TabIndex = 2;
            this.textBox_KitapAra.TextChanged += new System.EventHandler(this.textBox_KitapAra_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label_SuanOduncteKitapSayisi);
            this.groupBox1.Controls.Add(this.label_ToplamAlinanKitapSayisi);
            this.groupBox1.Controls.Add(this.label_AdSoyad);
            this.groupBox1.Controls.Add(this.button_UyeAra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_UyeAra);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 159);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "👤 Üye İşlemleri";
            // 
            // label_SuanOduncteKitapSayisi
            // 
            this.label_SuanOduncteKitapSayisi.AutoSize = true;
            this.label_SuanOduncteKitapSayisi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_SuanOduncteKitapSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.label_SuanOduncteKitapSayisi.Location = new System.Drawing.Point(267, 107);
            this.label_SuanOduncteKitapSayisi.Name = "label_SuanOduncteKitapSayisi";
            this.label_SuanOduncteKitapSayisi.Size = new System.Drawing.Size(120, 19);
            this.label_SuanOduncteKitapSayisi.TabIndex = 11;
            this.label_SuanOduncteKitapSayisi.Text = "Şu an Ödünçte: 0";
            // 
            // label_ToplamAlinanKitapSayisi
            // 
            this.label_ToplamAlinanKitapSayisi.AutoSize = true;
            this.label_ToplamAlinanKitapSayisi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ToplamAlinanKitapSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label_ToplamAlinanKitapSayisi.Location = new System.Drawing.Point(267, 86);
            this.label_ToplamAlinanKitapSayisi.Name = "label_ToplamAlinanKitapSayisi";
            this.label_ToplamAlinanKitapSayisi.Size = new System.Drawing.Size(107, 19);
            this.label_ToplamAlinanKitapSayisi.TabIndex = 11;
            this.label_ToplamAlinanKitapSayisi.Text = "Toplam Alınan: 0";
            // 
            // label_AdSoyad
            // 
            this.label_AdSoyad.AutoSize = true;
            this.label_AdSoyad.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_AdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label_AdSoyad.Location = new System.Drawing.Point(15, 86);
            this.label_AdSoyad.Name = "label_AdSoyad";
            this.label_AdSoyad.Size = new System.Drawing.Size(155, 25);
            this.label_AdSoyad.TabIndex = 11;
            this.label_AdSoyad.Text = "Seçili Üye: -YOK-";
            // 
            // button_UyeAra
            // 
            this.button_UyeAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_UyeAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_UyeAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_UyeAra.FlatAppearance.BorderSize = 0;
            this.button_UyeAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UyeAra.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_UyeAra.ForeColor = System.Drawing.Color.White;
            this.button_UyeAra.Location = new System.Drawing.Point(440, 50);
            this.button_UyeAra.Name = "button_UyeAra";
            this.button_UyeAra.Size = new System.Drawing.Size(75, 27);
            this.button_UyeAra.TabIndex = 10;
            this.button_UyeAra.Text = "🔍 ARA";
            this.button_UyeAra.UseVisualStyleBackColor = false;
            this.button_UyeAra.Click += new System.EventHandler(this.button_UyeAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Üye Ara:";
            // 
            // textBox_UyeAra
            // 
            this.textBox_UyeAra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_UyeAra.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox_UyeAra.Location = new System.Drawing.Point(18, 50);
            this.textBox_UyeAra.Name = "textBox_UyeAra";
            this.textBox_UyeAra.PlaceholderText = "TC Kimlik No / Pasaport No / Ad Soyad ile arayın";
            this.textBox_UyeAra.Size = new System.Drawing.Size(416, 27);
            this.textBox_UyeAra.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.groupBox3);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(553, 13);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(534, 724);
            this.panelRight.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_IadeAl);
            this.groupBox3.Controls.Add(this.listView_UyeninAldigiKitapListesi);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(534, 724);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "↩️ İade Alma İşlemi";
            // 
            // button_IadeAl
            // 
            this.button_IadeAl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_IadeAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.button_IadeAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_IadeAl.FlatAppearance.BorderSize = 0;
            this.button_IadeAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_IadeAl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_IadeAl.ForeColor = System.Drawing.Color.White;
            this.button_IadeAl.Location = new System.Drawing.Point(13, 665);
            this.button_IadeAl.Name = "button_IadeAl";
            this.button_IadeAl.Size = new System.Drawing.Size(508, 45);
            this.button_IadeAl.TabIndex = 9;
            this.button_IadeAl.Text = "❌ SEÇİLİ KİTABI İADE AL";
            this.button_IadeAl.UseVisualStyleBackColor = false;
            this.button_IadeAl.Click += new System.EventHandler(this.button_IadeAl_Click);
            // 
            // listView_UyeninAldigiKitapListesi
            // 
            this.listView_UyeninAldigiKitapListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_UyeninAldigiKitapListesi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_UyeninAldigiKitapListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUyeKitapAd,
            this.colVerilisTarihi,
            this.colTeslimTarihi});
            this.listView_UyeninAldigiKitapListesi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listView_UyeninAldigiKitapListesi.FullRowSelect = true;
            this.listView_UyeninAldigiKitapListesi.GridLines = true;
            this.listView_UyeninAldigiKitapListesi.HideSelection = false;
            this.listView_UyeninAldigiKitapListesi.Location = new System.Drawing.Point(13, 34);
            this.listView_UyeninAldigiKitapListesi.Name = "listView_UyeninAldigiKitapListesi";
            this.listView_UyeninAldigiKitapListesi.Size = new System.Drawing.Size(508, 620);
            this.listView_UyeninAldigiKitapListesi.TabIndex = 6;
            this.listView_UyeninAldigiKitapListesi.UseCompatibleStateImageBehavior = false;
            this.listView_UyeninAldigiKitapListesi.View = System.Windows.Forms.View.Details;
            // 
            // colUyeKitapAd
            // 
            this.colUyeKitapAd.Text = "Kitap Adı";
            this.colUyeKitapAd.Width = 200;
            // 
            // colVerilisTarihi
            // 
            this.colVerilisTarihi.Text = "Veriliş Tarihi";
            this.colVerilisTarihi.Width = 120;
            // 
            // colTeslimTarihi
            // 
            this.colTeslimTarihi.Text = "Son Teslim";
            this.colTeslimTarihi.Width = 120;
            // 
            // frmOduncIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.mainLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "frmOduncIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyonu - Ödünç ve İade Yönetimi";
            this.Load += new System.EventHandler(this.frmOduncIslemleri_Load);
            this.mainLayout.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TextBox textBox_UyeAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_KitapAra;
        private System.Windows.Forms.ListView listView_KitapListesi;
        private System.Windows.Forms.ListView listView_Sepet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_OduncVer;
        private System.Windows.Forms.Label label_AdSoyad;
        private System.Windows.Forms.Button button_UyeAra;
        private System.Windows.Forms.Button button_IadeAl;
        private System.Windows.Forms.ListView listView_UyeninAldigiKitapListesi;
        private System.Windows.Forms.Label label_ToplamAlinanKitapSayisi;
        private System.Windows.Forms.Label label_SuanOduncteKitapSayisi;
        private System.Windows.Forms.ColumnHeader colKitapAd;
        private System.Windows.Forms.ColumnHeader colYazar;
        private System.Windows.Forms.ColumnHeader colStok;
        private System.Windows.Forms.ColumnHeader colSepetAd;
        private System.Windows.Forms.ColumnHeader colSepetYazar;
        private System.Windows.Forms.ColumnHeader colUyeKitapAd;
        private System.Windows.Forms.ColumnHeader colVerilisTarihi;
        private System.Windows.Forms.ColumnHeader colTeslimTarihi;
    }
}