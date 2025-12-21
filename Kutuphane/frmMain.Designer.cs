using Kutuphane.UI;

namespace Kutuphane.UI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            panel_Ust = new Panel();
            label_Mesaj = new Label();
            lblKullaniciAdi = new Label();
            menuStrip1 = new MenuStrip();
            gostergePaneliToolStripMenuItem = new ToolStripMenuItem();
            yerlesimAyarlariToolStripMenuItem = new ToolStripMenuItem();
            kitapIslemleriToolStripMenuItem = new ToolStripMenuItem();
            kitapToolStripMenuItem = new ToolStripMenuItem();
            kategoriIslemleriiToolStripMenuItem = new ToolStripMenuItem();
            yazarIslemleriToolStripMenuItem = new ToolStripMenuItem();
            dilIslemleriToolStripMenuItem = new ToolStripMenuItem();
            yayineviIslemleriToolStripMenuItem = new ToolStripMenuItem();
            oduncIslemleriToolStripMenuItem = new ToolStripMenuItem();
            uyeIslemleriToolStripMenuItem = new ToolStripMenuItem();
            personelIslemleriToolStripMenuItem = new ToolStripMenuItem();
            raporlamaToolStripMenuItem = new ToolStripMenuItem();
            cikisYapToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanel_Kartlar = new FlowLayoutPanel();
            panel_Kitap = new Panel();
            label_KitapSayisi = new Label();
            label1 = new Label();
            panel_Uye = new Panel();
            label_UyeSayisi = new Label();
            label2 = new Label();
            panel_Odunc = new Panel();
            label_OduncSayisi = new Label();
            label3 = new Label();
            panel_Geciklis = new Panel();
            label_GecikmisUyeSayisi = new Label();
            label4 = new Label();
            timer_Dashboard = new System.Windows.Forms.Timer(components);
            timer_baglanti = new System.Windows.Forms.Timer(components);
            panel_Ust.SuspendLayout();
            menuStrip1.SuspendLayout();
            flowLayoutPanel_Kartlar.SuspendLayout();
            panel_Kitap.SuspendLayout();
            panel_Uye.SuspendLayout();
            panel_Odunc.SuspendLayout();
            panel_Geciklis.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Ust
            // 
            panel_Ust.BackColor = Color.FromArgb(44, 62, 80);
            panel_Ust.Controls.Add(label_Mesaj);
            panel_Ust.Controls.Add(lblKullaniciAdi);
            panel_Ust.Dock = DockStyle.Top;
            panel_Ust.Location = new Point(0, 32);
            panel_Ust.Name = "panel_Ust";
            panel_Ust.Size = new Size(1234, 60);
            panel_Ust.TabIndex = 4;
            // 
            // label_Mesaj
            // 
            label_Mesaj.Anchor = AnchorStyles.Left;
            label_Mesaj.AutoSize = true;
            label_Mesaj.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_Mesaj.ForeColor = Color.White;
            label_Mesaj.Location = new Point(12, 13);
            label_Mesaj.Name = "label_Mesaj";
            label_Mesaj.Size = new Size(22, 30);
            label_Mesaj.TabIndex = 2;
            label_Mesaj.Text = "•";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKullaniciAdi.ForeColor = Color.White;
            lblKullaniciAdi.Location = new Point(12, 17);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(131, 25);
            lblKullaniciAdi.TabIndex = 1;
            lblKullaniciAdi.Text = "👤 Hoşgeldin,";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gostergePaneliToolStripMenuItem, yerlesimAyarlariToolStripMenuItem, kitapIslemleriToolStripMenuItem, oduncIslemleriToolStripMenuItem, uyeIslemleriToolStripMenuItem, personelIslemleriToolStripMenuItem, raporlamaToolStripMenuItem, cikisYapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 4, 0, 4);
            menuStrip1.Size = new Size(1234, 32);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // gostergePaneliToolStripMenuItem
            // 
            gostergePaneliToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            gostergePaneliToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            gostergePaneliToolStripMenuItem.Name = "gostergePaneliToolStripMenuItem";
            gostergePaneliToolStripMenuItem.Size = new Size(153, 24);
            gostergePaneliToolStripMenuItem.Text = "📊 Gösterge Paneli";
            gostergePaneliToolStripMenuItem.Click += gostergePaneliToolStripMenuItem_Click;
            // 
            // yerlesimAyarlariToolStripMenuItem
            // 
            yerlesimAyarlariToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            yerlesimAyarlariToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            yerlesimAyarlariToolStripMenuItem.Name = "yerlesimAyarlariToolStripMenuItem";
            yerlesimAyarlariToolStripMenuItem.Size = new Size(162, 24);
            yerlesimAyarlariToolStripMenuItem.Tag = "frmYeslesimAyarlari";
            yerlesimAyarlariToolStripMenuItem.Text = "⚙ Yerleşim Ayarları";
            yerlesimAyarlariToolStripMenuItem.Click += menuStrip_Click;
            // 
            // kitapIslemleriToolStripMenuItem
            // 
            kitapIslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapToolStripMenuItem, kategoriIslemleriiToolStripMenuItem, yazarIslemleriToolStripMenuItem, dilIslemleriToolStripMenuItem, yayineviIslemleriToolStripMenuItem });
            kitapIslemleriToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            kitapIslemleriToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            kitapIslemleriToolStripMenuItem.Name = "kitapIslemleriToolStripMenuItem";
            kitapIslemleriToolStripMenuItem.Size = new Size(141, 24);
            kitapIslemleriToolStripMenuItem.Text = "📚 Kitap İşlemleri";
            // 
            // kitapToolStripMenuItem
            // 
            kitapToolStripMenuItem.Name = "kitapToolStripMenuItem";
            kitapToolStripMenuItem.Size = new Size(197, 24);
            kitapToolStripMenuItem.Tag = "frmKitapIslemleri";
            kitapToolStripMenuItem.Text = "Kitap İşlemleri";
            kitapToolStripMenuItem.Click += menuStrip_Click;
            // 
            // kategoriIslemleriiToolStripMenuItem
            // 
            kategoriIslemleriiToolStripMenuItem.Name = "kategoriIslemleriiToolStripMenuItem";
            kategoriIslemleriiToolStripMenuItem.Size = new Size(197, 24);
            kategoriIslemleriiToolStripMenuItem.Tag = "frmKategoriIslemleri";
            kategoriIslemleriiToolStripMenuItem.Text = "Kategori İşlemleri";
            kategoriIslemleriiToolStripMenuItem.Click += menuStrip_Click;
            // 
            // yazarIslemleriToolStripMenuItem
            // 
            yazarIslemleriToolStripMenuItem.Name = "yazarIslemleriToolStripMenuItem";
            yazarIslemleriToolStripMenuItem.Size = new Size(197, 24);
            yazarIslemleriToolStripMenuItem.Tag = "frmYazarIslemleri";
            yazarIslemleriToolStripMenuItem.Text = "Yazar İşlemleri";
            yazarIslemleriToolStripMenuItem.Click += menuStrip_Click;
            // 
            // dilIslemleriToolStripMenuItem
            // 
            dilIslemleriToolStripMenuItem.Name = "dilIslemleriToolStripMenuItem";
            dilIslemleriToolStripMenuItem.Size = new Size(197, 24);
            dilIslemleriToolStripMenuItem.Tag = "frmDilIslemleri";
            dilIslemleriToolStripMenuItem.Text = "Dil İşlemleri";
            dilIslemleriToolStripMenuItem.Click += menuStrip_Click;
            // 
            // yayineviIslemleriToolStripMenuItem
            // 
            yayineviIslemleriToolStripMenuItem.Name = "yayineviIslemleriToolStripMenuItem";
            yayineviIslemleriToolStripMenuItem.Size = new Size(197, 24);
            yayineviIslemleriToolStripMenuItem.Tag = "frmYayineviIslemleri";
            yayineviIslemleriToolStripMenuItem.Text = "Yayınevi İşlemleri";
            yayineviIslemleriToolStripMenuItem.Click += menuStrip_Click;
            // 
            // oduncIslemleriToolStripMenuItem
            // 
            oduncIslemleriToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            oduncIslemleriToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            oduncIslemleriToolStripMenuItem.Name = "oduncIslemleriToolStripMenuItem";
            oduncIslemleriToolStripMenuItem.Size = new Size(153, 24);
            oduncIslemleriToolStripMenuItem.Tag = "frmOduncIslemleri";
            oduncIslemleriToolStripMenuItem.Text = "🔄 Ödünç İşlemleri";
            oduncIslemleriToolStripMenuItem.Click += menuStrip_Click;
            // 
            // uyeIslemleriToolStripMenuItem
            // 
            uyeIslemleriToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            uyeIslemleriToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            uyeIslemleriToolStripMenuItem.Name = "uyeIslemleriToolStripMenuItem";
            uyeIslemleriToolStripMenuItem.Size = new Size(135, 24);
            uyeIslemleriToolStripMenuItem.Tag = "frmUyeIslemleri";
            uyeIslemleriToolStripMenuItem.Text = "👥 Üye İşlemleri";
            uyeIslemleriToolStripMenuItem.Click += menuStrip_Click;
            // 
            // personelIslemleriToolStripMenuItem
            // 
            personelIslemleriToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            personelIslemleriToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            personelIslemleriToolStripMenuItem.Name = "personelIslemleriToolStripMenuItem";
            personelIslemleriToolStripMenuItem.Size = new Size(165, 24);
            personelIslemleriToolStripMenuItem.Tag = "frmPersonelIslemleri";
            personelIslemleriToolStripMenuItem.Text = "👔 Personel İşlemleri";
            personelIslemleriToolStripMenuItem.Click += menuStrip_Click;
            // 
            // raporlamaToolStripMenuItem
            // 
            raporlamaToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            raporlamaToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            raporlamaToolStripMenuItem.Size = new Size(121, 24);
            raporlamaToolStripMenuItem.Text = "📝 Raporlama";
            // 
            // cikisYapToolStripMenuItem
            // 
            cikisYapToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cikisYapToolStripMenuItem.ForeColor = Color.FromArgb(192, 57, 43);
            cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            cikisYapToolStripMenuItem.Size = new Size(103, 24);
            cikisYapToolStripMenuItem.Text = "🔒 Çıkış Yap";
            cikisYapToolStripMenuItem.Click += cikisYapToolStripMenuItem_Click;
            // 
            // flowLayoutPanel_Kartlar
            // 
            flowLayoutPanel_Kartlar.BackColor = Color.FromArgb(236, 240, 241);
            flowLayoutPanel_Kartlar.Controls.Add(panel_Kitap);
            flowLayoutPanel_Kartlar.Controls.Add(panel_Uye);
            flowLayoutPanel_Kartlar.Controls.Add(panel_Odunc);
            flowLayoutPanel_Kartlar.Controls.Add(panel_Geciklis);
            flowLayoutPanel_Kartlar.Dock = DockStyle.Fill;
            flowLayoutPanel_Kartlar.Location = new Point(0, 92);
            flowLayoutPanel_Kartlar.Margin = new Padding(6);
            flowLayoutPanel_Kartlar.Name = "flowLayoutPanel_Kartlar";
            flowLayoutPanel_Kartlar.Padding = new Padding(10);
            flowLayoutPanel_Kartlar.Size = new Size(1234, 619);
            flowLayoutPanel_Kartlar.TabIndex = 7;
            // 
            // panel_Kitap
            // 
            panel_Kitap.BackColor = Color.FromArgb(39, 174, 96);
            panel_Kitap.Controls.Add(label_KitapSayisi);
            panel_Kitap.Controls.Add(label1);
            panel_Kitap.Location = new Point(20, 20);
            panel_Kitap.Margin = new Padding(10);
            panel_Kitap.Name = "panel_Kitap";
            panel_Kitap.Size = new Size(280, 150);
            panel_Kitap.TabIndex = 0;
            // 
            // label_KitapSayisi
            // 
            label_KitapSayisi.AutoSize = true;
            label_KitapSayisi.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            label_KitapSayisi.ForeColor = Color.White;
            label_KitapSayisi.Location = new Point(13, 45);
            label_KitapSayisi.Name = "label_KitapSayisi";
            label_KitapSayisi.Size = new Size(74, 86);
            label_KitapSayisi.TabIndex = 0;
            label_KitapSayisi.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 1;
            label1.Text = "📚 Toplam Kitap";
            // 
            // panel_Uye
            // 
            panel_Uye.BackColor = Color.FromArgb(41, 128, 185);
            panel_Uye.Controls.Add(label_UyeSayisi);
            panel_Uye.Controls.Add(label2);
            panel_Uye.Location = new Point(320, 20);
            panel_Uye.Margin = new Padding(10);
            panel_Uye.Name = "panel_Uye";
            panel_Uye.Size = new Size(280, 150);
            panel_Uye.TabIndex = 1;
            // 
            // label_UyeSayisi
            // 
            label_UyeSayisi.AutoSize = true;
            label_UyeSayisi.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            label_UyeSayisi.ForeColor = Color.White;
            label_UyeSayisi.Location = new Point(15, 45);
            label_UyeSayisi.Name = "label_UyeSayisi";
            label_UyeSayisi.Size = new Size(74, 86);
            label_UyeSayisi.TabIndex = 0;
            label_UyeSayisi.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 15);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 1;
            label2.Text = "👥 Toplam Üye";
            // 
            // panel_Odunc
            // 
            panel_Odunc.BackColor = Color.FromArgb(230, 126, 34);
            panel_Odunc.Controls.Add(label_OduncSayisi);
            panel_Odunc.Controls.Add(label3);
            panel_Odunc.Location = new Point(620, 20);
            panel_Odunc.Margin = new Padding(10);
            panel_Odunc.Name = "panel_Odunc";
            panel_Odunc.Size = new Size(280, 150);
            panel_Odunc.TabIndex = 2;
            // 
            // label_OduncSayisi
            // 
            label_OduncSayisi.AutoSize = true;
            label_OduncSayisi.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            label_OduncSayisi.ForeColor = Color.White;
            label_OduncSayisi.Location = new Point(15, 45);
            label_OduncSayisi.Name = "label_OduncSayisi";
            label_OduncSayisi.Size = new Size(74, 86);
            label_OduncSayisi.TabIndex = 2;
            label_OduncSayisi.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 15);
            label3.Name = "label3";
            label3.Size = new Size(171, 25);
            label3.TabIndex = 3;
            label3.Text = "🔄 Emanet Kitaplar";
            // 
            // panel_Geciklis
            // 
            panel_Geciklis.BackColor = Color.FromArgb(192, 57, 43);
            panel_Geciklis.Controls.Add(label_GecikmisUyeSayisi);
            panel_Geciklis.Controls.Add(label4);
            panel_Geciklis.Location = new Point(920, 20);
            panel_Geciklis.Margin = new Padding(10);
            panel_Geciklis.Name = "panel_Geciklis";
            panel_Geciklis.Size = new Size(280, 150);
            panel_Geciklis.TabIndex = 3;
            // 
            // label_GecikmisUyeSayisi
            // 
            label_GecikmisUyeSayisi.AutoSize = true;
            label_GecikmisUyeSayisi.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            label_GecikmisUyeSayisi.ForeColor = Color.White;
            label_GecikmisUyeSayisi.Location = new Point(15, 45);
            label_GecikmisUyeSayisi.Name = "label_GecikmisUyeSayisi";
            label_GecikmisUyeSayisi.Size = new Size(74, 86);
            label_GecikmisUyeSayisi.TabIndex = 4;
            label_GecikmisUyeSayisi.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 15);
            label4.Name = "label4";
            label4.Size = new Size(183, 25);
            label4.TabIndex = 5;
            label4.Text = "⚠️ Gecikmiş Kitaplar";
            // 
            // timer_Dashboard
            // 
            timer_Dashboard.Interval = 10000;
            timer_Dashboard.Tick += timer_Dashboard_Tick;
            // 
            // timer_baglanti
            // 
            timer_baglanti.Interval = 10000;
            timer_baglanti.Tick += timer_baglanti_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1234, 711);
            Controls.Add(flowLayoutPanel_Kartlar);
            Controls.Add(panel_Ust);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kütüphane Otomasyonu";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            panel_Ust.ResumeLayout(false);
            panel_Ust.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            flowLayoutPanel_Kartlar.ResumeLayout(false);
            panel_Kitap.ResumeLayout(false);
            panel_Kitap.PerformLayout();
            panel_Uye.ResumeLayout(false);
            panel_Uye.PerformLayout();
            panel_Odunc.ResumeLayout(false);
            panel_Odunc.PerformLayout();
            panel_Geciklis.ResumeLayout(false);
            panel_Geciklis.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Ust;
        private Label lblKullaniciAdi;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gostergePaneliToolStripMenuItem;
        private ToolStripMenuItem yerlesimAyarlariToolStripMenuItem;
        private ToolStripMenuItem kitapIslemleriToolStripMenuItem;
        private ToolStripMenuItem kategoriIslemleriiToolStripMenuItem;
        private ToolStripMenuItem yazarIslemleriToolStripMenuItem;
        private ToolStripMenuItem dilIslemleriToolStripMenuItem;
        private ToolStripMenuItem yayineviIslemleriToolStripMenuItem;
        private ToolStripMenuItem oduncIslemleriToolStripMenuItem;
        private ToolStripMenuItem uyeIslemleriToolStripMenuItem;
        private ToolStripMenuItem personelIslemleriToolStripMenuItem;
        private ToolStripMenuItem cikisYapToolStripMenuItem;
        private ToolStripMenuItem raporlamaToolStripMenuItem;
        private Panel panel_Kitap;
        private Panel panel_Uye;
        private Panel panel_Odunc;
        private Panel panel_Geciklis;
        private Label label_KitapSayisi;
        private Label label_UyeSayisi;
        private Label label_OduncSayisi;
        private Label label_GecikmisUyeSayisi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel_Kartlar;
        private System.Windows.Forms.Timer timer_Dashboard;
        private ToolStripMenuItem kitapToolStripMenuItem;
        private Label label_Mesaj;
        private System.Windows.Forms.Timer timer_baglanti;
    }
}