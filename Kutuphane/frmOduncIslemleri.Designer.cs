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
            button_OduncVer = new Button();
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
            button_TumIadeAl = new Button();
            listView_AlinanTumKitaplarinListesi = new ListView();
            groupBox_IadeIslemleri = new GroupBox();
            button_IadeAl = new Button();
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
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            mainLayout.Controls.Add(panelLeft, 0, 0);
            mainLayout.Controls.Add(panelRight, 1, 0);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(10);
            mainLayout.RowCount = 1;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(1184, 905);
            mainLayout.TabIndex = 5;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(groupBox_KitapSecimi_OduncVerme);
            panelLeft.Controls.Add(groupBox_UyeIslemleri);
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(13, 13);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(0, 0, 5, 0);
            panelLeft.Size = new Size(634, 879);
            panelLeft.TabIndex = 0;
            // 
            // groupBox_KitapSecimi_OduncVerme
            // 
            groupBox_KitapSecimi_OduncVerme.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_KitapSecimi_OduncVerme.Controls.Add(label5);
            groupBox_KitapSecimi_OduncVerme.Controls.Add(dateTimePicker_TeslimTarihi);
            groupBox_KitapSecimi_OduncVerme.Controls.Add(button_OduncVer);
            groupBox_KitapSecimi_OduncVerme.Controls.Add(label4);
            groupBox_KitapSecimi_OduncVerme.Controls.Add(listView_Sepet);
            groupBox_KitapSecimi_OduncVerme.Controls.Add(listView_KitapListesi);
            groupBox_KitapSecimi_OduncVerme.Controls.Add(label3);
            groupBox_KitapSecimi_OduncVerme.Controls.Add(label2);
            groupBox_KitapSecimi_OduncVerme.Controls.Add(textBox_KitapAra);
            groupBox_KitapSecimi_OduncVerme.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox_KitapSecimi_OduncVerme.ForeColor = Color.DimGray;
            groupBox_KitapSecimi_OduncVerme.Location = new Point(3, 314);
            groupBox_KitapSecimi_OduncVerme.Name = "groupBox_KitapSecimi_OduncVerme";
            groupBox_KitapSecimi_OduncVerme.Padding = new Padding(10);
            groupBox_KitapSecimi_OduncVerme.Size = new Size(628, 562);
            groupBox_KitapSecimi_OduncVerme.TabIndex = 3;
            groupBox_KitapSecimi_OduncVerme.TabStop = false;
            groupBox_KitapSecimi_OduncVerme.Text = "➡️ Kitap Seçimi ve Ödünç Verme";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(15, 476);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 12;
            label5.Text = "En geç teslim tarihi:";
            // 
            // dateTimePicker_TeslimTarihi
            // 
            dateTimePicker_TeslimTarihi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dateTimePicker_TeslimTarihi.CalendarTitleBackColor = SystemColors.ControlText;
            dateTimePicker_TeslimTarihi.CalendarTitleForeColor = Color.DimGray;
            dateTimePicker_TeslimTarihi.Format = DateTimePickerFormat.Short;
            dateTimePicker_TeslimTarihi.Location = new Point(167, 473);
            dateTimePicker_TeslimTarihi.Name = "dateTimePicker_TeslimTarihi";
            dateTimePicker_TeslimTarihi.Size = new Size(105, 27);
            dateTimePicker_TeslimTarihi.TabIndex = 11;
            // 
            // button_OduncVer
            // 
            button_OduncVer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_OduncVer.BackColor = Color.FromArgb(39, 174, 96);
            button_OduncVer.Cursor = Cursors.Hand;
            button_OduncVer.FlatAppearance.BorderSize = 0;
            button_OduncVer.FlatStyle = FlatStyle.Flat;
            button_OduncVer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_OduncVer.ForeColor = Color.White;
            button_OduncVer.Location = new Point(13, 506);
            button_OduncVer.Name = "button_OduncVer";
            button_OduncVer.Size = new Size(602, 45);
            button_OduncVer.TabIndex = 10;
            button_OduncVer.Text = "✅ SEPETTEKİLERİ ÖDÜNÇ VER";
            button_OduncVer.UseVisualStyleBackColor = false;
            button_OduncVer.Click += button_OduncVer_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(13, 299);
            label4.Name = "label4";
            label4.Size = new Size(169, 19);
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
            listView_Sepet.Location = new Point(13, 321);
            listView_Sepet.MultiSelect = false;
            listView_Sepet.Name = "listView_Sepet";
            listView_Sepet.Size = new Size(602, 146);
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
            listView_KitapListesi.Location = new Point(13, 107);
            listView_KitapListesi.Name = "listView_KitapListesi";
            listView_KitapListesi.RightToLeft = RightToLeft.Yes;
            listView_KitapListesi.Size = new Size(602, 184);
            listView_KitapListesi.TabIndex = 5;
            listView_KitapListesi.UseCompatibleStateImageBehavior = false;
            listView_KitapListesi.View = View.Details;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(13, 85);
            label3.Name = "label3";
            label3.Size = new Size(133, 19);
            label3.TabIndex = 3;
            label3.Text = "📚 Arama Sonucu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(13, 31);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 3;
            label2.Text = "Kitap Ara:";
            // 
            // textBox_KitapAra
            // 
            textBox_KitapAra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_KitapAra.Font = new Font("Segoe UI", 11F);
            textBox_KitapAra.Location = new Point(13, 53);
            textBox_KitapAra.Name = "textBox_KitapAra";
            textBox_KitapAra.PlaceholderText = "🔍 ISBN / Kitap Adı / Yazar ile arayın";
            textBox_KitapAra.Size = new Size(602, 27);
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
            groupBox_UyeIslemleri.Name = "groupBox_UyeIslemleri";
            groupBox_UyeIslemleri.Size = new Size(629, 308);
            groupBox_UyeIslemleri.TabIndex = 2;
            groupBox_UyeIslemleri.TabStop = false;
            groupBox_UyeIslemleri.Text = "👤 Üye İşlemleri";
            // 
            // listView_Uyeler
            // 
            listView_Uyeler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView_Uyeler.BorderStyle = BorderStyle.FixedSingle;
            listView_Uyeler.Font = new Font("Segoe UI", 10F);
            listView_Uyeler.FullRowSelect = true;
            listView_Uyeler.GridLines = true;
            listView_Uyeler.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView_Uyeler.Location = new Point(18, 126);
            listView_Uyeler.Name = "listView_Uyeler";
            listView_Uyeler.RightToLeft = RightToLeft.Yes;
            listView_Uyeler.Size = new Size(597, 170);
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
            label_SuanOduncteKitapSayisi.Location = new Point(383, 95);
            label_SuanOduncteKitapSayisi.Name = "label_SuanOduncteKitapSayisi";
            label_SuanOduncteKitapSayisi.Size = new Size(115, 19);
            label_SuanOduncteKitapSayisi.TabIndex = 11;
            label_SuanOduncteKitapSayisi.Text = "Şu an Ödünçte: 0";
            // 
            // label_ToplamAlinanKitapSayisi
            // 
            label_ToplamAlinanKitapSayisi.AutoSize = true;
            label_ToplamAlinanKitapSayisi.Font = new Font("Segoe UI", 10F);
            label_ToplamAlinanKitapSayisi.ForeColor = Color.FromArgb(41, 128, 185);
            label_ToplamAlinanKitapSayisi.Location = new Point(244, 95);
            label_ToplamAlinanKitapSayisi.Name = "label_ToplamAlinanKitapSayisi";
            label_ToplamAlinanKitapSayisi.Size = new Size(110, 19);
            label_ToplamAlinanKitapSayisi.TabIndex = 11;
            label_ToplamAlinanKitapSayisi.Text = "Toplam Alınan: 0";
            // 
            // label_AdSoyad
            // 
            label_AdSoyad.AutoSize = true;
            label_AdSoyad.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label_AdSoyad.ForeColor = Color.FromArgb(44, 62, 80);
            label_AdSoyad.Location = new Point(18, 90);
            label_AdSoyad.Name = "label_AdSoyad";
            label_AdSoyad.Size = new Size(160, 25);
            label_AdSoyad.TabIndex = 11;
            label_AdSoyad.Text = "Seçili Üye: -YOK-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 28);
            label1.Name = "label1";
            label1.Size = new Size(61, 19);
            label1.TabIndex = 1;
            label1.Text = "Üye Ara:";
            // 
            // textBox_UyeAra
            // 
            textBox_UyeAra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_UyeAra.Font = new Font("Segoe UI", 11F);
            textBox_UyeAra.Location = new Point(18, 50);
            textBox_UyeAra.Name = "textBox_UyeAra";
            textBox_UyeAra.PlaceholderText = "TC Kimlik No / Pasaport No / Ad Soyad ile arayın";
            textBox_UyeAra.Size = new Size(597, 27);
            textBox_UyeAra.TabIndex = 0;
            textBox_UyeAra.TextChanged += textBox_UyeAra_TextChanged;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(groupBox_TumOduncler);
            panelRight.Controls.Add(groupBox_IadeIslemleri);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(653, 13);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(5, 0, 0, 0);
            panelRight.Size = new Size(518, 879);
            panelRight.TabIndex = 1;
            // 
            // groupBox_TumOduncler
            // 
            groupBox_TumOduncler.Controls.Add(button_TumIadeAl);
            groupBox_TumOduncler.Controls.Add(listView_AlinanTumKitaplarinListesi);
            groupBox_TumOduncler.Dock = DockStyle.Fill;
            groupBox_TumOduncler.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox_TumOduncler.ForeColor = Color.DimGray;
            groupBox_TumOduncler.Location = new Point(5, 364);
            groupBox_TumOduncler.Name = "groupBox_TumOduncler";
            groupBox_TumOduncler.Padding = new Padding(10);
            groupBox_TumOduncler.Size = new Size(513, 515);
            groupBox_TumOduncler.TabIndex = 5;
            groupBox_TumOduncler.TabStop = false;
            groupBox_TumOduncler.Text = "Tüm Ödünç Kitaplar";
            // 
            // button_TumIadeAl
            // 
            button_TumIadeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_TumIadeAl.BackColor = Color.FromArgb(192, 57, 43);
            button_TumIadeAl.Cursor = Cursors.Hand;
            button_TumIadeAl.FlatAppearance.BorderSize = 0;
            button_TumIadeAl.FlatStyle = FlatStyle.Flat;
            button_TumIadeAl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_TumIadeAl.ForeColor = Color.White;
            button_TumIadeAl.Location = new Point(13, 456);
            button_TumIadeAl.Name = "button_TumIadeAl";
            button_TumIadeAl.Size = new Size(487, 45);
            button_TumIadeAl.TabIndex = 10;
            button_TumIadeAl.Text = "❌ SEÇİLİ KİTABI İADE AL";
            button_TumIadeAl.UseVisualStyleBackColor = false;
            button_TumIadeAl.Click += button_TumIadeAl_Click;
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
            listView_AlinanTumKitaplarinListesi.Location = new Point(13, 35);
            listView_AlinanTumKitaplarinListesi.MultiSelect = false;
            listView_AlinanTumKitaplarinListesi.Name = "listView_AlinanTumKitaplarinListesi";
            listView_AlinanTumKitaplarinListesi.Size = new Size(487, 415);
            listView_AlinanTumKitaplarinListesi.TabIndex = 6;
            listView_AlinanTumKitaplarinListesi.UseCompatibleStateImageBehavior = false;
            listView_AlinanTumKitaplarinListesi.View = View.Details;
            // 
            // groupBox_IadeIslemleri
            // 
            groupBox_IadeIslemleri.Controls.Add(button_IadeAl);
            groupBox_IadeIslemleri.Controls.Add(listView_UyeninAldigiKitapListesi);
            groupBox_IadeIslemleri.Dock = DockStyle.Top;
            groupBox_IadeIslemleri.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox_IadeIslemleri.ForeColor = Color.DimGray;
            groupBox_IadeIslemleri.Location = new Point(5, 0);
            groupBox_IadeIslemleri.Name = "groupBox_IadeIslemleri";
            groupBox_IadeIslemleri.Padding = new Padding(10);
            groupBox_IadeIslemleri.Size = new Size(513, 364);
            groupBox_IadeIslemleri.TabIndex = 4;
            groupBox_IadeIslemleri.TabStop = false;
            groupBox_IadeIslemleri.Text = "↩️ İade Alma İşlemi (Üye Üzerindekiler)";
            // 
            // button_IadeAl
            // 
            button_IadeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_IadeAl.BackColor = Color.FromArgb(192, 57, 43);
            button_IadeAl.Cursor = Cursors.Hand;
            button_IadeAl.FlatAppearance.BorderSize = 0;
            button_IadeAl.FlatStyle = FlatStyle.Flat;
            button_IadeAl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button_IadeAl.ForeColor = Color.White;
            button_IadeAl.Location = new Point(13, 305);
            button_IadeAl.Name = "button_IadeAl";
            button_IadeAl.Size = new Size(487, 45);
            button_IadeAl.TabIndex = 9;
            button_IadeAl.Text = "❌ SEÇİLİ KİTABI İADE AL";
            button_IadeAl.UseVisualStyleBackColor = false;
            button_IadeAl.Click += button_IadeAl_Click;
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
            listView_UyeninAldigiKitapListesi.Location = new Point(13, 34);
            listView_UyeninAldigiKitapListesi.MultiSelect = false;
            listView_UyeninAldigiKitapListesi.Name = "listView_UyeninAldigiKitapListesi";
            listView_UyeninAldigiKitapListesi.RightToLeft = RightToLeft.Yes;
            listView_UyeninAldigiKitapListesi.Size = new Size(487, 262);
            listView_UyeninAldigiKitapListesi.TabIndex = 6;
            listView_UyeninAldigiKitapListesi.UseCompatibleStateImageBehavior = false;
            listView_UyeninAldigiKitapListesi.View = View.Details;
            // 
            // frmOduncIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1184, 905);
            Controls.Add(mainLayout);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(950, 700);
            Name = "frmOduncIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Ödünç ve İade Yönetimi";
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
        private System.Windows.Forms.Button button_OduncVer;

        // İade
        private System.Windows.Forms.Button button_IadeAl;
        private System.Windows.Forms.ListView listView_UyeninAldigiKitapListesi;
        private GroupBox groupBox4;
        private Button button1;
        private DateTimePicker dateTimePicker_TeslimTarihi;
        private Label label5;
        private GroupBox groupBox_TumOduncler;
        private ListView listView_AlinanTumKitaplarinListesi;
        private Button button_TumIadeAl;
    }
}