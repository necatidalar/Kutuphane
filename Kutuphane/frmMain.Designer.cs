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
            lblKullaniciAdi = new Label();
            menuStrip1 = new MenuStrip();
            göstergePaneliToolStripMenuItem = new ToolStripMenuItem();
            yerleşimAyarlarıToolStripMenuItem = new ToolStripMenuItem();
            kitapİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            kategoriİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            yazarİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            dilİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            yayıneviİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            kitapToolStripMenuItem = new ToolStripMenuItem();
            ödünçİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            üyeİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            personelİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            raporlamaToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
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
            panel_Ust.Controls.Add(lblKullaniciAdi);
            panel_Ust.Dock = DockStyle.Top;
            panel_Ust.Location = new Point(0, 39);
            panel_Ust.Margin = new Padding(3, 4, 3, 4);
            panel_Ust.Name = "panel_Ust";
            panel_Ust.Size = new Size(1441, 80);
            panel_Ust.TabIndex = 4;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKullaniciAdi.ForeColor = Color.White;
            lblKullaniciAdi.Location = new Point(14, 23);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(178, 32);
            lblKullaniciAdi.TabIndex = 1;
            lblKullaniciAdi.Text = "👤 Hoşgeldin,";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { göstergePaneliToolStripMenuItem, yerleşimAyarlarıToolStripMenuItem, kitapİşlemleriToolStripMenuItem, ödünçİşlemleriToolStripMenuItem, üyeİşlemleriToolStripMenuItem, personelİşlemleriToolStripMenuItem, raporlamaToolStripMenuItem, çıkışYapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 5, 0, 5);
            menuStrip1.Size = new Size(1441, 39);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // göstergePaneliToolStripMenuItem
            // 
            göstergePaneliToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            göstergePaneliToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            göstergePaneliToolStripMenuItem.Name = "göstergePaneliToolStripMenuItem";
            göstergePaneliToolStripMenuItem.Size = new Size(186, 29);
            göstergePaneliToolStripMenuItem.Text = "📊 Gösterge Paneli";
            göstergePaneliToolStripMenuItem.Click += göstergePaneliToolStripMenuItem_Click;
            // 
            // yerleşimAyarlarıToolStripMenuItem
            // 
            yerleşimAyarlarıToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            yerleşimAyarlarıToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            yerleşimAyarlarıToolStripMenuItem.Name = "yerleşimAyarlarıToolStripMenuItem";
            yerleşimAyarlarıToolStripMenuItem.Size = new Size(196, 29);
            yerleşimAyarlarıToolStripMenuItem.Text = "⚙ Yerleşim Ayarları";
            yerleşimAyarlarıToolStripMenuItem.Click += menuStrip_Click;
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            kitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kategoriİşlemleriToolStripMenuItem, yazarİşlemleriToolStripMenuItem, dilİşlemleriToolStripMenuItem, yayıneviİşlemleriToolStripMenuItem, kitapToolStripMenuItem });
            kitapİşlemleriToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            kitapİşlemleriToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            kitapİşlemleriToolStripMenuItem.Size = new Size(176, 29);
            kitapİşlemleriToolStripMenuItem.Text = "📚 Kitap İşlemleri";
            // 
            // kategoriİşlemleriToolStripMenuItem
            // 
            kategoriİşlemleriToolStripMenuItem.Name = "kategoriİşlemleriToolStripMenuItem";
            kategoriİşlemleriToolStripMenuItem.Size = new Size(249, 30);
            kategoriİşlemleriToolStripMenuItem.Text = "Kategori İşlemleri";
            kategoriİşlemleriToolStripMenuItem.Click += menuStrip_Click;
            // 
            // yazarİşlemleriToolStripMenuItem
            // 
            yazarİşlemleriToolStripMenuItem.Name = "yazarİşlemleriToolStripMenuItem";
            yazarİşlemleriToolStripMenuItem.Size = new Size(249, 30);
            yazarİşlemleriToolStripMenuItem.Text = "Yazar İşlemleri";
            yazarİşlemleriToolStripMenuItem.Click += menuStrip_Click;
            // 
            // dilİşlemleriToolStripMenuItem
            // 
            dilİşlemleriToolStripMenuItem.Name = "dilİşlemleriToolStripMenuItem";
            dilİşlemleriToolStripMenuItem.Size = new Size(249, 30);
            dilİşlemleriToolStripMenuItem.Tag = "frmDilIslemleri";
            dilİşlemleriToolStripMenuItem.Text = "Dil İşlemleri";
            dilİşlemleriToolStripMenuItem.Click += menuStrip_Click;
            // 
            // yayıneviİşlemleriToolStripMenuItem
            // 
            yayıneviİşlemleriToolStripMenuItem.Name = "yayıneviİşlemleriToolStripMenuItem";
            yayıneviİşlemleriToolStripMenuItem.Size = new Size(249, 30);
            yayıneviİşlemleriToolStripMenuItem.Text = "Yayınevi İşlemleri";
            yayıneviİşlemleriToolStripMenuItem.Click += menuStrip_Click;
            // 
            // kitapToolStripMenuItem
            // 
            kitapToolStripMenuItem.Name = "kitapToolStripMenuItem";
            kitapToolStripMenuItem.Size = new Size(249, 30);
            kitapToolStripMenuItem.Text = "Kitap";
            kitapToolStripMenuItem.Click += menuStrip_Click;
            // 
            // ödünçİşlemleriToolStripMenuItem
            // 
            ödünçİşlemleriToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            ödünçİşlemleriToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            ödünçİşlemleriToolStripMenuItem.Name = "ödünçİşlemleriToolStripMenuItem";
            ödünçİşlemleriToolStripMenuItem.Size = new Size(187, 29);
            ödünçİşlemleriToolStripMenuItem.Text = "🔄 Ödünç İşlemleri";
            ödünçİşlemleriToolStripMenuItem.Click += menuStrip_Click;
            // 
            // üyeİşlemleriToolStripMenuItem
            // 
            üyeİşlemleriToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            üyeİşlemleriToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            üyeİşlemleriToolStripMenuItem.Name = "üyeİşlemleriToolStripMenuItem";
            üyeİşlemleriToolStripMenuItem.Size = new Size(164, 29);
            üyeİşlemleriToolStripMenuItem.Text = "👥 Üye İşlemleri";
            üyeİşlemleriToolStripMenuItem.Click += menuStrip_Click;
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            personelİşlemleriToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            personelİşlemleriToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            personelİşlemleriToolStripMenuItem.Size = new Size(203, 29);
            personelİşlemleriToolStripMenuItem.Text = "👔 Personel İşlemleri";
            personelİşlemleriToolStripMenuItem.Click += menuStrip_Click;
            // 
            // raporlamaToolStripMenuItem
            // 
            raporlamaToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            raporlamaToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            raporlamaToolStripMenuItem.Size = new Size(146, 29);
            raporlamaToolStripMenuItem.Text = "📝 Raporlama";
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            çıkışYapToolStripMenuItem.ForeColor = Color.FromArgb(192, 57, 43);
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(128, 29);
            çıkışYapToolStripMenuItem.Text = "🔒 Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            // 
            // flowLayoutPanel_Kartlar
            // 
            flowLayoutPanel_Kartlar.BackColor = Color.FromArgb(236, 240, 241);
            flowLayoutPanel_Kartlar.Controls.Add(panel_Kitap);
            flowLayoutPanel_Kartlar.Controls.Add(panel_Uye);
            flowLayoutPanel_Kartlar.Controls.Add(panel_Odunc);
            flowLayoutPanel_Kartlar.Controls.Add(panel_Geciklis);
            flowLayoutPanel_Kartlar.Dock = DockStyle.Top;
            flowLayoutPanel_Kartlar.Location = new Point(0, 119);
            flowLayoutPanel_Kartlar.Margin = new Padding(7, 8, 7, 8);
            flowLayoutPanel_Kartlar.Name = "flowLayoutPanel_Kartlar";
            flowLayoutPanel_Kartlar.Padding = new Padding(11, 13, 11, 13);
            flowLayoutPanel_Kartlar.Size = new Size(1441, 253);
            flowLayoutPanel_Kartlar.TabIndex = 7;
            // 
            // panel_Kitap
            // 
            panel_Kitap.BackColor = Color.FromArgb(39, 174, 96);
            panel_Kitap.Controls.Add(label_KitapSayisi);
            panel_Kitap.Controls.Add(label1);
            panel_Kitap.Location = new Point(22, 26);
            panel_Kitap.Margin = new Padding(11, 13, 11, 13);
            panel_Kitap.Name = "panel_Kitap";
            panel_Kitap.Size = new Size(320, 200);
            panel_Kitap.TabIndex = 0;
            // 
            // label_KitapSayisi
            // 
            label_KitapSayisi.AutoSize = true;
            label_KitapSayisi.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            label_KitapSayisi.ForeColor = Color.White;
            label_KitapSayisi.Location = new Point(15, 60);
            label_KitapSayisi.Name = "label_KitapSayisi";
            label_KitapSayisi.Size = new Size(91, 106);
            label_KitapSayisi.TabIndex = 0;
            label_KitapSayisi.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 20);
            label1.Name = "label1";
            label1.Size = new Size(193, 32);
            label1.TabIndex = 1;
            label1.Text = "📚 Toplam Kitap";
            // 
            // panel_Uye
            // 
            panel_Uye.BackColor = Color.FromArgb(41, 128, 185);
            panel_Uye.Controls.Add(label_UyeSayisi);
            panel_Uye.Controls.Add(label2);
            panel_Uye.Location = new Point(364, 26);
            panel_Uye.Margin = new Padding(11, 13, 11, 13);
            panel_Uye.Name = "panel_Uye";
            panel_Uye.Size = new Size(320, 200);
            panel_Uye.TabIndex = 1;
            // 
            // label_UyeSayisi
            // 
            label_UyeSayisi.AutoSize = true;
            label_UyeSayisi.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            label_UyeSayisi.ForeColor = Color.White;
            label_UyeSayisi.Location = new Point(17, 60);
            label_UyeSayisi.Name = "label_UyeSayisi";
            label_UyeSayisi.Size = new Size(91, 106);
            label_UyeSayisi.TabIndex = 0;
            label_UyeSayisi.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 20);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 1;
            label2.Text = "👥 Toplam Üye";
            // 
            // panel_Odunc
            // 
            panel_Odunc.BackColor = Color.FromArgb(230, 126, 34);
            panel_Odunc.Controls.Add(label_OduncSayisi);
            panel_Odunc.Controls.Add(label3);
            panel_Odunc.Location = new Point(706, 26);
            panel_Odunc.Margin = new Padding(11, 13, 11, 13);
            panel_Odunc.Name = "panel_Odunc";
            panel_Odunc.Size = new Size(320, 200);
            panel_Odunc.TabIndex = 2;
            // 
            // label_OduncSayisi
            // 
            label_OduncSayisi.AutoSize = true;
            label_OduncSayisi.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            label_OduncSayisi.ForeColor = Color.White;
            label_OduncSayisi.Location = new Point(17, 60);
            label_OduncSayisi.Name = "label_OduncSayisi";
            label_OduncSayisi.Size = new Size(91, 106);
            label_OduncSayisi.TabIndex = 2;
            label_OduncSayisi.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 20);
            label3.Name = "label3";
            label3.Size = new Size(221, 32);
            label3.TabIndex = 3;
            label3.Text = "🔄 Emanet Kitaplar";
            // 
            // panel_Geciklis
            // 
            panel_Geciklis.BackColor = Color.FromArgb(192, 57, 43);
            panel_Geciklis.Controls.Add(label_GecikmisUyeSayisi);
            panel_Geciklis.Controls.Add(label4);
            panel_Geciklis.Location = new Point(1048, 26);
            panel_Geciklis.Margin = new Padding(11, 13, 11, 13);
            panel_Geciklis.Name = "panel_Geciklis";
            panel_Geciklis.Size = new Size(320, 200);
            panel_Geciklis.TabIndex = 3;
            // 
            // label_GecikmisUyeSayisi
            // 
            label_GecikmisUyeSayisi.AutoSize = true;
            label_GecikmisUyeSayisi.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            label_GecikmisUyeSayisi.ForeColor = Color.White;
            label_GecikmisUyeSayisi.Location = new Point(17, 60);
            label_GecikmisUyeSayisi.Name = "label_GecikmisUyeSayisi";
            label_GecikmisUyeSayisi.Size = new Size(91, 106);
            label_GecikmisUyeSayisi.TabIndex = 4;
            label_GecikmisUyeSayisi.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 20);
            label4.Name = "label4";
            label4.Size = new Size(236, 32);
            label4.TabIndex = 5;
            label4.Text = "⚠️ Gecikmiş Kitaplar";
            // 
            // timer_Dashboard
            // 
            timer_Dashboard.Interval = 10000;
            timer_Dashboard.Tick += timer_Dashboard_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1441, 948);
            Controls.Add(flowLayoutPanel_Kartlar);
            Controls.Add(panel_Ust);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(635, 350);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonı";
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
        private ToolStripMenuItem göstergePaneliToolStripMenuItem;
        private ToolStripMenuItem yerleşimAyarlarıToolStripMenuItem;
        private ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private ToolStripMenuItem kategoriİşlemleriToolStripMenuItem;
        private ToolStripMenuItem yazarİşlemleriToolStripMenuItem;
        private ToolStripMenuItem dilİşlemleriToolStripMenuItem;
        private ToolStripMenuItem yayıneviİşlemleriToolStripMenuItem;
        private ToolStripMenuItem ödünçİşlemleriToolStripMenuItem;
        private ToolStripMenuItem üyeİşlemleriToolStripMenuItem;
        private ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
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
    }
}