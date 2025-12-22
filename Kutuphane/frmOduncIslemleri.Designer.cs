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
            mainLayout = new TableLayoutPanel();
            panelLeft = new Panel();
            groupBox2 = new GroupBox();
            button_OduncVer = new Button();
            label4 = new Label();
            listView_Sepet = new ListView();
            colSepetAd = new ColumnHeader();
            colSepetYazar = new ColumnHeader();
            listView_KitapListesi = new ListView();
            colKitapAd = new ColumnHeader();
            colYazar = new ColumnHeader();
            colStok = new ColumnHeader();
            label3 = new Label();
            label2 = new Label();
            textBox_KitapAra = new TextBox();
            groupBox1 = new GroupBox();
            label_SuanOduncteKitapSayisi = new Label();
            label_ToplamAlinanKitapSayisi = new Label();
            label_AdSoyad = new Label();
            button_UyeAra = new Button();
            label1 = new Label();
            textBox_UyeAra = new TextBox();
            panelRight = new Panel();
            groupBox3 = new GroupBox();
            button_IadeAl = new Button();
            listView_UyeninAldigiKitapListesi = new ListView();
            colUyeKitapAd = new ColumnHeader();
            colVerilisTarihi = new ColumnHeader();
            colTeslimTarihi = new ColumnHeader();
            mainLayout.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panelRight.SuspendLayout();
            groupBox3.SuspendLayout();
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
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(10);
            mainLayout.RowCount = 1;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(1100, 750);
            mainLayout.TabIndex = 5;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(groupBox2);
            panelLeft.Controls.Add(groupBox1);
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(13, 13);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(534, 724);
            panelLeft.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(button_OduncVer);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(listView_Sepet);
            groupBox2.Controls.Add(listView_KitapListesi);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox_KitapAra);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.DimGray;
            groupBox2.Location = new Point(3, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10);
            groupBox2.Size = new Size(528, 553);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "➡️ Ödünç Verme İşlemleri";
            // 
            // button_OduncVer
            // 
            button_OduncVer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_OduncVer.BackColor = Color.FromArgb(39, 174, 96);
            button_OduncVer.Cursor = Cursors.Hand;
            button_OduncVer.FlatAppearance.BorderSize = 0;
            button_OduncVer.FlatStyle = FlatStyle.Flat;
            button_OduncVer.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_OduncVer.ForeColor = Color.White;
            button_OduncVer.Location = new Point(13, 497);
            button_OduncVer.Name = "button_OduncVer";
            button_OduncVer.Size = new Size(502, 45);
            button_OduncVer.TabIndex = 10;
            button_OduncVer.Text = "✅ İŞLEMİ TAMAMLA VE ÖDÜNÇ VER";
            button_OduncVer.UseVisualStyleBackColor = false;
            button_OduncVer.Click += button_OduncVer_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(13, 290);
            label4.Name = "label4";
            label4.Size = new Size(169, 19);
            label4.TabIndex = 7;
            label4.Text = "\U0001f9fa Sepet (Eklenecekler)";
            // 
            // listView_Sepet
            // 
            listView_Sepet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView_Sepet.BackColor = Color.FloralWhite;
            listView_Sepet.BorderStyle = BorderStyle.FixedSingle;
            listView_Sepet.Columns.AddRange(new ColumnHeader[] { colSepetAd, colSepetYazar });
            listView_Sepet.Font = new Font("Segoe UI", 10F);
            listView_Sepet.FullRowSelect = true;
            listView_Sepet.GridLines = true;
            listView_Sepet.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView_Sepet.Location = new Point(13, 312);
            listView_Sepet.Name = "listView_Sepet";
            listView_Sepet.Size = new Size(502, 170);
            listView_Sepet.TabIndex = 6;
            listView_Sepet.UseCompatibleStateImageBehavior = false;
            listView_Sepet.View = View.Details;
            // 
            // colSepetAd
            // 
            colSepetAd.Text = "Kitap Adı";
            colSepetAd.Width = 250;
            // 
            // colSepetYazar
            // 
            colSepetYazar.Text = "Yazar";
            colSepetYazar.Width = 150;
            // 
            // listView_KitapListesi
            // 
            listView_KitapListesi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView_KitapListesi.BorderStyle = BorderStyle.FixedSingle;
            listView_KitapListesi.Columns.AddRange(new ColumnHeader[] { colKitapAd, colYazar, colStok });
            listView_KitapListesi.Font = new Font("Segoe UI", 10F);
            listView_KitapListesi.FullRowSelect = true;
            listView_KitapListesi.GridLines = true;
            listView_KitapListesi.Location = new Point(13, 107);
            listView_KitapListesi.Name = "listView_KitapListesi";
            listView_KitapListesi.Size = new Size(502, 170);
            listView_KitapListesi.TabIndex = 5;
            listView_KitapListesi.UseCompatibleStateImageBehavior = false;
            listView_KitapListesi.View = View.Details;
            // 
            // colKitapAd
            // 
            colKitapAd.Text = "Kitap Adı";
            colKitapAd.Width = 200;
            // 
            // colYazar
            // 
            colYazar.Text = "Yazar";
            colYazar.Width = 130;
            // 
            // colStok
            // 
            colStok.Text = "Stok";
            colStok.Width = 50;
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
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
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
            textBox_KitapAra.Size = new Size(502, 27);
            textBox_KitapAra.TabIndex = 2;
            textBox_KitapAra.TextChanged += textBox_KitapAra_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label_SuanOduncteKitapSayisi);
            groupBox1.Controls.Add(label_ToplamAlinanKitapSayisi);
            groupBox1.Controls.Add(label_AdSoyad);
            groupBox1.Controls.Add(button_UyeAra);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_UyeAra);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.DimGray;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(528, 159);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "👤 Üye İşlemleri";
            // 
            // label_SuanOduncteKitapSayisi
            // 
            label_SuanOduncteKitapSayisi.AutoSize = true;
            label_SuanOduncteKitapSayisi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label_SuanOduncteKitapSayisi.ForeColor = Color.FromArgb(192, 57, 43);
            label_SuanOduncteKitapSayisi.Location = new Point(267, 107);
            label_SuanOduncteKitapSayisi.Name = "label_SuanOduncteKitapSayisi";
            label_SuanOduncteKitapSayisi.Size = new Size(115, 19);
            label_SuanOduncteKitapSayisi.TabIndex = 11;
            label_SuanOduncteKitapSayisi.Text = "Şu an Ödünçte: 0";
            // 
            // label_ToplamAlinanKitapSayisi
            // 
            label_ToplamAlinanKitapSayisi.AutoSize = true;
            label_ToplamAlinanKitapSayisi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label_ToplamAlinanKitapSayisi.ForeColor = Color.FromArgb(41, 128, 185);
            label_ToplamAlinanKitapSayisi.Location = new Point(267, 86);
            label_ToplamAlinanKitapSayisi.Name = "label_ToplamAlinanKitapSayisi";
            label_ToplamAlinanKitapSayisi.Size = new Size(110, 19);
            label_ToplamAlinanKitapSayisi.TabIndex = 11;
            label_ToplamAlinanKitapSayisi.Text = "Toplam Alınan: 0";
            // 
            // label_AdSoyad
            // 
            label_AdSoyad.AutoSize = true;
            label_AdSoyad.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_AdSoyad.ForeColor = Color.FromArgb(44, 62, 80);
            label_AdSoyad.Location = new Point(15, 86);
            label_AdSoyad.Name = "label_AdSoyad";
            label_AdSoyad.Size = new Size(160, 25);
            label_AdSoyad.TabIndex = 11;
            label_AdSoyad.Text = "Seçili Üye: -YOK-";
            // 
            // button_UyeAra
            // 
            button_UyeAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_UyeAra.BackColor = Color.FromArgb(52, 152, 219);
            button_UyeAra.Cursor = Cursors.Hand;
            button_UyeAra.FlatAppearance.BorderSize = 0;
            button_UyeAra.FlatStyle = FlatStyle.Flat;
            button_UyeAra.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_UyeAra.ForeColor = Color.White;
            button_UyeAra.Location = new Point(440, 50);
            button_UyeAra.Name = "button_UyeAra";
            button_UyeAra.Size = new Size(75, 27);
            button_UyeAra.TabIndex = 10;
            button_UyeAra.Text = "🔍 ARA";
            button_UyeAra.UseVisualStyleBackColor = false;
            button_UyeAra.Click += button_UyeAra_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
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
            textBox_UyeAra.Size = new Size(416, 27);
            textBox_UyeAra.TabIndex = 0;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(groupBox3);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(553, 13);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(534, 724);
            panelRight.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button_IadeAl);
            groupBox3.Controls.Add(listView_UyeninAldigiKitapListesi);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.DimGray;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10);
            groupBox3.Size = new Size(534, 724);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "↩️ İade Alma İşlemi";
            // 
            // button_IadeAl
            // 
            button_IadeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_IadeAl.BackColor = Color.FromArgb(192, 57, 43);
            button_IadeAl.Cursor = Cursors.Hand;
            button_IadeAl.FlatAppearance.BorderSize = 0;
            button_IadeAl.FlatStyle = FlatStyle.Flat;
            button_IadeAl.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_IadeAl.ForeColor = Color.White;
            button_IadeAl.Location = new Point(13, 665);
            button_IadeAl.Name = "button_IadeAl";
            button_IadeAl.Size = new Size(508, 45);
            button_IadeAl.TabIndex = 9;
            button_IadeAl.Text = "❌ SEÇİLİ KİTABI İADE AL";
            button_IadeAl.UseVisualStyleBackColor = false;
            button_IadeAl.Click += button_IadeAl_Click;
            // 
            // listView_UyeninAldigiKitapListesi
            // 
            listView_UyeninAldigiKitapListesi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView_UyeninAldigiKitapListesi.BorderStyle = BorderStyle.FixedSingle;
            listView_UyeninAldigiKitapListesi.Columns.AddRange(new ColumnHeader[] { colUyeKitapAd, colVerilisTarihi, colTeslimTarihi });
            listView_UyeninAldigiKitapListesi.Font = new Font("Segoe UI", 10F);
            listView_UyeninAldigiKitapListesi.FullRowSelect = true;
            listView_UyeninAldigiKitapListesi.GridLines = true;
            listView_UyeninAldigiKitapListesi.Location = new Point(13, 34);
            listView_UyeninAldigiKitapListesi.Name = "listView_UyeninAldigiKitapListesi";
            listView_UyeninAldigiKitapListesi.Size = new Size(508, 620);
            listView_UyeninAldigiKitapListesi.TabIndex = 6;
            listView_UyeninAldigiKitapListesi.UseCompatibleStateImageBehavior = false;
            listView_UyeninAldigiKitapListesi.View = View.Details;
            // 
            // colUyeKitapAd
            // 
            colUyeKitapAd.Text = "Kitap Adı";
            colUyeKitapAd.Width = 200;
            // 
            // colVerilisTarihi
            // 
            colVerilisTarihi.Text = "Veriliş Tarihi";
            colVerilisTarihi.Width = 120;
            // 
            // colTeslimTarihi
            // 
            colTeslimTarihi.Text = "Son Teslim";
            colTeslimTarihi.Width = 120;
            // 
            // frmOduncIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1100, 750);
            Controls.Add(mainLayout);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 700);
            Name = "frmOduncIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Ödünç ve İade Yönetimi";
            Load += frmOduncIslemleri_Load;
            mainLayout.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelRight.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);

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