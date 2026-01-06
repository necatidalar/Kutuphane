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
            panel_Giris = new Panel();
            panel_Sol = new Panel();
            label_Logo = new Label();
            label_Baslik2 = new Label();
            label_Baslik1 = new Label();
            checkBox_BeniHatirla = new CheckBox();
            btnCikis = new Button();
            btnGiris = new Button();
            label7 = new Label();
            textBox_Sifre = new TextBox();
            textBox_KullaniciAdi = new TextBox();
            label9 = new Label();
            flowLayoutPanel_Kartlar = new FlowLayoutPanel();
            panel_Kitap = new Panel();
            label_KitapSayisi = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label_YazarSayisi = new Label();
            label8 = new Label();
            panel2 = new Panel();
            label_YayineviSayisi = new Label();
            label6 = new Label();
            panel_Uye = new Panel();
            label_UyeKadinSayisi = new Label();
            label_UyeErkekSayisi = new Label();
            label_UyeSayisi = new Label();
            label2 = new Label();
            panel_Odunc = new Panel();
            label_OduncSayisi = new Label();
            label3 = new Label();
            panel_Geciklis = new Panel();
            label_GecikmisUyeSayisi = new Label();
            label4 = new Label();
            timer_Dashboard = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            gostergePaneliToolStripMenuItem = new ToolStripMenuItem();
            yerlesimAyarlariToolStripMenuItem = new ToolStripMenuItem();
            kitapIslemleriToolStripMenuItem = new ToolStripMenuItem();
            kitapToolStripMenuItem = new ToolStripMenuItem();
            kategoriIslemleriToolStripMenuItem = new ToolStripMenuItem();
            yazarToolStripMenuItem = new ToolStripMenuItem();
            yayineviToolStripMenuItem = new ToolStripMenuItem();
            dilToolStripMenuItem = new ToolStripMenuItem();
            oduncToolStripMenuItem = new ToolStripMenuItem();
            uyeToolStripMenuItem = new ToolStripMenuItem();
            personelToolStripMenuItem = new ToolStripMenuItem();
            raporlamaToolStripMenuItem = new ToolStripMenuItem();
            yonetimToolStripMenuItem = new ToolStripMenuItem();
            ayarlarToolStripMenuItem = new ToolStripMenuItem();
            cikisToolStripMenuItem = new ToolStripMenuItem();
            panel_Ust.SuspendLayout();
            panel_Giris.SuspendLayout();
            panel_Sol.SuspendLayout();
            flowLayoutPanel_Kartlar.SuspendLayout();
            panel_Kitap.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel_Uye.SuspendLayout();
            panel_Odunc.SuspendLayout();
            panel_Geciklis.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Ust
            // 
            panel_Ust.BackColor = Color.FromArgb(44, 62, 80);
            panel_Ust.Controls.Add(label_Mesaj);
            panel_Ust.Controls.Add(lblKullaniciAdi);
            panel_Ust.Dock = DockStyle.Top;
            panel_Ust.Location = new Point(0, 28);
            panel_Ust.Name = "panel_Ust";
            panel_Ust.Size = new Size(1521, 60);
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
            // panel_Giris
            // 
            panel_Giris.Controls.Add(panel_Sol);
            panel_Giris.Controls.Add(checkBox_BeniHatirla);
            panel_Giris.Controls.Add(btnCikis);
            panel_Giris.Controls.Add(btnGiris);
            panel_Giris.Controls.Add(label7);
            panel_Giris.Controls.Add(textBox_Sifre);
            panel_Giris.Controls.Add(textBox_KullaniciAdi);
            panel_Giris.Controls.Add(label9);
            panel_Giris.Location = new Point(700, 341);
            panel_Giris.MaximumSize = new Size(635, 350);
            panel_Giris.Name = "panel_Giris";
            panel_Giris.Size = new Size(635, 350);
            panel_Giris.TabIndex = 8;
            // 
            // panel_Sol
            // 
            panel_Sol.BackColor = Color.FromArgb(41, 128, 185);
            panel_Sol.Controls.Add(label_Logo);
            panel_Sol.Controls.Add(label_Baslik2);
            panel_Sol.Controls.Add(label_Baslik1);
            panel_Sol.Dock = DockStyle.Left;
            panel_Sol.Location = new Point(0, 0);
            panel_Sol.Name = "panel_Sol";
            panel_Sol.Size = new Size(250, 350);
            panel_Sol.TabIndex = 5;
            // 
            // label_Logo
            // 
            label_Logo.AutoSize = true;
            label_Logo.Font = new Font("Segoe UI", 60F);
            label_Logo.ForeColor = Color.White;
            label_Logo.Location = new Point(55, 60);
            label_Logo.Name = "label_Logo";
            label_Logo.Size = new Size(155, 106);
            label_Logo.TabIndex = 2;
            label_Logo.Text = "🔐";
            // 
            // label_Baslik2
            // 
            label_Baslik2.AutoSize = true;
            label_Baslik2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label_Baslik2.ForeColor = Color.White;
            label_Baslik2.Location = new Point(48, 208);
            label_Baslik2.Name = "label_Baslik2";
            label_Baslik2.Size = new Size(137, 30);
            label_Baslik2.TabIndex = 1;
            label_Baslik2.Text = "Otomasyonu";
            // 
            // label_Baslik1
            // 
            label_Baslik1.AutoSize = true;
            label_Baslik1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_Baslik1.ForeColor = Color.White;
            label_Baslik1.Location = new Point(45, 171);
            label_Baslik1.Name = "label_Baslik1";
            label_Baslik1.Size = new Size(157, 37);
            label_Baslik1.TabIndex = 0;
            label_Baslik1.Text = "Kütüphane";
            // 
            // checkBox_BeniHatirla
            // 
            checkBox_BeniHatirla.AutoSize = true;
            checkBox_BeniHatirla.Font = new Font("Segoe UI", 10F);
            checkBox_BeniHatirla.ForeColor = Color.FromArgb(64, 64, 64);
            checkBox_BeniHatirla.Location = new Point(285, 202);
            checkBox_BeniHatirla.Name = "checkBox_BeniHatirla";
            checkBox_BeniHatirla.Size = new Size(98, 23);
            checkBox_BeniHatirla.TabIndex = 3;
            checkBox_BeniHatirla.Text = "Beni Hatırla";
            checkBox_BeniHatirla.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCikis.ForeColor = Color.FromArgb(192, 57, 43);
            btnCikis.Location = new Point(592, 1);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(40, 40);
            btnCikis.TabIndex = 6;
            btnCikis.Text = "X";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Visible = false;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(39, 174, 96);
            btnGiris.Cursor = Cursors.Hand;
            btnGiris.FlatAppearance.BorderSize = 0;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiris.ForeColor = Color.White;
            btnGiris.Location = new Point(285, 245);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(301, 44);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "GİRİŞ YAP";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(285, 135);
            label7.Name = "label7";
            label7.Size = new Size(65, 19);
            label7.TabIndex = 3;
            label7.Text = "🔑 Şifre:";
            // 
            // textBox_Sifre
            // 
            textBox_Sifre.Font = new Font("Segoe UI", 12F);
            textBox_Sifre.Location = new Point(285, 158);
            textBox_Sifre.Margin = new Padding(4);
            textBox_Sifre.Name = "textBox_Sifre";
            textBox_Sifre.PasswordChar = '●';
            textBox_Sifre.PlaceholderText = "Şifrenizi giriniz";
            textBox_Sifre.Size = new Size(298, 29);
            textBox_Sifre.TabIndex = 2;
            textBox_Sifre.UseSystemPasswordChar = true;
            // 
            // textBox_KullaniciAdi
            // 
            textBox_KullaniciAdi.Font = new Font("Segoe UI", 12F);
            textBox_KullaniciAdi.Location = new Point(285, 82);
            textBox_KullaniciAdi.Margin = new Padding(4);
            textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            textBox_KullaniciAdi.PlaceholderText = "Kullanıcı adınızı giriniz";
            textBox_KullaniciAdi.Size = new Size(298, 29);
            textBox_KullaniciAdi.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(285, 59);
            label9.Name = "label9";
            label9.Size = new Size(113, 19);
            label9.TabIndex = 3;
            label9.Text = "👤 Kullanıcı Adı:";
            // 
            // flowLayoutPanel_Kartlar
            // 
            flowLayoutPanel_Kartlar.BackColor = Color.FromArgb(236, 240, 241);
            flowLayoutPanel_Kartlar.Controls.Add(panel_Kitap);
            flowLayoutPanel_Kartlar.Controls.Add(panel1);
            flowLayoutPanel_Kartlar.Controls.Add(panel2);
            flowLayoutPanel_Kartlar.Controls.Add(panel_Uye);
            flowLayoutPanel_Kartlar.Controls.Add(panel_Odunc);
            flowLayoutPanel_Kartlar.Controls.Add(panel_Geciklis);
            flowLayoutPanel_Kartlar.Dock = DockStyle.Fill;
            flowLayoutPanel_Kartlar.Location = new Point(0, 88);
            flowLayoutPanel_Kartlar.Margin = new Padding(6);
            flowLayoutPanel_Kartlar.Name = "flowLayoutPanel_Kartlar";
            flowLayoutPanel_Kartlar.Padding = new Padding(10);
            flowLayoutPanel_Kartlar.Size = new Size(1521, 623);
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
            panel_Kitap.Size = new Size(280, 160);
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(155, 89, 182);
            panel1.Controls.Add(label_YazarSayisi);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(320, 20);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 160);
            panel1.TabIndex = 4;
            // 
            // label_YazarSayisi
            // 
            label_YazarSayisi.AutoSize = true;
            label_YazarSayisi.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            label_YazarSayisi.ForeColor = Color.White;
            label_YazarSayisi.Location = new Point(15, 45);
            label_YazarSayisi.Name = "label_YazarSayisi";
            label_YazarSayisi.Size = new Size(74, 86);
            label_YazarSayisi.TabIndex = 4;
            label_YazarSayisi.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(155, 89, 182);
            label8.Font = new Font("Segoe UI", 14F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(15, 15);
            label8.Name = "label8";
            label8.Size = new Size(149, 25);
            label8.TabIndex = 5;
            label8.Text = "✍️ Toplam Yazar";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 160, 133);
            panel2.Controls.Add(label_YayineviSayisi);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(620, 20);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 160);
            panel2.TabIndex = 5;
            // 
            // label_YayineviSayisi
            // 
            label_YayineviSayisi.AutoSize = true;
            label_YayineviSayisi.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            label_YayineviSayisi.ForeColor = Color.White;
            label_YayineviSayisi.Location = new Point(15, 45);
            label_YayineviSayisi.Name = "label_YayineviSayisi";
            label_YayineviSayisi.Size = new Size(74, 86);
            label_YayineviSayisi.TabIndex = 4;
            label_YayineviSayisi.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(15, 15);
            label6.Name = "label6";
            label6.Size = new Size(172, 25);
            label6.TabIndex = 5;
            label6.Text = "🏢 Toplam Yayınevi";
            // 
            // panel_Uye
            // 
            panel_Uye.BackColor = Color.FromArgb(41, 128, 185);
            panel_Uye.Controls.Add(label_UyeKadinSayisi);
            panel_Uye.Controls.Add(label_UyeErkekSayisi);
            panel_Uye.Controls.Add(label_UyeSayisi);
            panel_Uye.Controls.Add(label2);
            panel_Uye.Location = new Point(920, 20);
            panel_Uye.Margin = new Padding(10);
            panel_Uye.Name = "panel_Uye";
            panel_Uye.Size = new Size(280, 160);
            panel_Uye.TabIndex = 1;
            // 
            // label_UyeKadinSayisi
            // 
            label_UyeKadinSayisi.AutoSize = true;
            label_UyeKadinSayisi.ForeColor = Color.FromArgb(236, 240, 241);
            label_UyeKadinSayisi.Location = new Point(92, 135);
            label_UyeKadinSayisi.Name = "label_UyeKadinSayisi";
            label_UyeKadinSayisi.Size = new Size(49, 15);
            label_UyeKadinSayisi.TabIndex = 2;
            label_UyeKadinSayisi.Text = "Kadın: 0";
            // 
            // label_UyeErkekSayisi
            // 
            label_UyeErkekSayisi.AutoSize = true;
            label_UyeErkekSayisi.ForeColor = Color.FromArgb(236, 240, 241);
            label_UyeErkekSayisi.Location = new Point(29, 135);
            label_UyeErkekSayisi.Name = "label_UyeErkekSayisi";
            label_UyeErkekSayisi.Size = new Size(47, 15);
            label_UyeErkekSayisi.TabIndex = 2;
            label_UyeErkekSayisi.Text = "Erkek: 0";
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
            panel_Odunc.Location = new Point(1220, 20);
            panel_Odunc.Margin = new Padding(10);
            panel_Odunc.Name = "panel_Odunc";
            panel_Odunc.Size = new Size(280, 160);
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
            panel_Geciklis.Location = new Point(20, 200);
            panel_Geciklis.Margin = new Padding(10);
            panel_Geciklis.Name = "panel_Geciklis";
            panel_Geciklis.Size = new Size(280, 160);
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
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gostergePaneliToolStripMenuItem, yerlesimAyarlariToolStripMenuItem, kitapIslemleriToolStripMenuItem, oduncToolStripMenuItem, uyeToolStripMenuItem, personelToolStripMenuItem, raporlamaToolStripMenuItem, yonetimToolStripMenuItem, ayarlarToolStripMenuItem, cikisToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1521, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // gostergePaneliToolStripMenuItem
            // 
            gostergePaneliToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            gostergePaneliToolStripMenuItem.Name = "gostergePaneliToolStripMenuItem";
            gostergePaneliToolStripMenuItem.Size = new Size(156, 24);
            gostergePaneliToolStripMenuItem.Text = "📊 Gösterge Paneli";
            gostergePaneliToolStripMenuItem.Click += gostergePaneliToolStripMenuItem_Click;
            // 
            // yerlesimAyarlariToolStripMenuItem
            // 
            yerlesimAyarlariToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            yerlesimAyarlariToolStripMenuItem.Name = "yerlesimAyarlariToolStripMenuItem";
            yerlesimAyarlariToolStripMenuItem.Size = new Size(165, 24);
            yerlesimAyarlariToolStripMenuItem.Tag = "frmYeslesimAyarlari";
            yerlesimAyarlariToolStripMenuItem.Text = "⚙ Yerleşim Ayarları";
            yerlesimAyarlariToolStripMenuItem.Click += menuStrip_Click;
            // 
            // kitapIslemleriToolStripMenuItem
            // 
            kitapIslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapToolStripMenuItem, kategoriIslemleriToolStripMenuItem, yazarToolStripMenuItem, yayineviToolStripMenuItem, dilToolStripMenuItem });
            kitapIslemleriToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            kitapIslemleriToolStripMenuItem.Name = "kitapIslemleriToolStripMenuItem";
            kitapIslemleriToolStripMenuItem.Size = new Size(146, 24);
            kitapIslemleriToolStripMenuItem.Text = "📚 Kitap İşlemleri";
            kitapIslemleriToolStripMenuItem.Click += menuStrip_Click;
            // 
            // kitapToolStripMenuItem
            // 
            kitapToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            kitapToolStripMenuItem.Name = "kitapToolStripMenuItem";
            kitapToolStripMenuItem.Size = new Size(202, 24);
            kitapToolStripMenuItem.Tag = "frmKitapIslemleri";
            kitapToolStripMenuItem.Text = "Kitap İşlemleri";
            kitapToolStripMenuItem.Click += menuStrip_Click;
            // 
            // kategoriIslemleriToolStripMenuItem
            // 
            kategoriIslemleriToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            kategoriIslemleriToolStripMenuItem.Name = "kategoriIslemleriToolStripMenuItem";
            kategoriIslemleriToolStripMenuItem.Size = new Size(202, 24);
            kategoriIslemleriToolStripMenuItem.Tag = "frmKategoriIslemleri";
            kategoriIslemleriToolStripMenuItem.Text = "Kategori İşlemleri";
            kategoriIslemleriToolStripMenuItem.Click += menuStrip_Click;
            // 
            // yazarToolStripMenuItem
            // 
            yazarToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            yazarToolStripMenuItem.Name = "yazarToolStripMenuItem";
            yazarToolStripMenuItem.Size = new Size(202, 24);
            yazarToolStripMenuItem.Tag = "frmYazarIslemleri";
            yazarToolStripMenuItem.Text = "Yazar İşlemleri";
            yazarToolStripMenuItem.Click += menuStrip_Click;
            // 
            // yayineviToolStripMenuItem
            // 
            yayineviToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            yayineviToolStripMenuItem.Name = "yayineviToolStripMenuItem";
            yayineviToolStripMenuItem.Size = new Size(202, 24);
            yayineviToolStripMenuItem.Tag = "frmYayineviIslemleri";
            yayineviToolStripMenuItem.Text = "Yayınevi İşlemleri";
            yayineviToolStripMenuItem.Click += menuStrip_Click;
            // 
            // dilToolStripMenuItem
            // 
            dilToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            dilToolStripMenuItem.Name = "dilToolStripMenuItem";
            dilToolStripMenuItem.Size = new Size(202, 24);
            dilToolStripMenuItem.Tag = "frmDilIslemleri";
            dilToolStripMenuItem.Text = "Dil İşlemleri";
            dilToolStripMenuItem.Click += menuStrip_Click;
            // 
            // oduncToolStripMenuItem
            // 
            oduncToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            oduncToolStripMenuItem.Name = "oduncToolStripMenuItem";
            oduncToolStripMenuItem.Size = new Size(156, 24);
            oduncToolStripMenuItem.Tag = "frmOduncIslemleri";
            oduncToolStripMenuItem.Text = "🔄 Ödünç İşlemleri";
            oduncToolStripMenuItem.Click += menuStrip_Click;
            // 
            // uyeToolStripMenuItem
            // 
            uyeToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            uyeToolStripMenuItem.Name = "uyeToolStripMenuItem";
            uyeToolStripMenuItem.Size = new Size(138, 24);
            uyeToolStripMenuItem.Tag = "frmUyeIslemleri";
            uyeToolStripMenuItem.Text = "👥 Üye İşlemleri";
            uyeToolStripMenuItem.Click += menuStrip_Click;
            // 
            // personelToolStripMenuItem
            // 
            personelToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            personelToolStripMenuItem.Size = new Size(170, 24);
            personelToolStripMenuItem.Tag = "frmPersonelIslemleri";
            personelToolStripMenuItem.Text = "👔 Personel İşlemleri";
            personelToolStripMenuItem.Click += menuStrip_Click;
            // 
            // raporlamaToolStripMenuItem
            // 
            raporlamaToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            raporlamaToolStripMenuItem.Size = new Size(123, 24);
            raporlamaToolStripMenuItem.Text = "📝 Raporlama";
            raporlamaToolStripMenuItem.Click += menuStrip_Click;
            // 
            // yonetimToolStripMenuItem
            // 
            yonetimToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            yonetimToolStripMenuItem.Name = "yonetimToolStripMenuItem";
            yonetimToolStripMenuItem.Size = new Size(164, 24);
            yonetimToolStripMenuItem.Tag = "frmAdmin";
            yonetimToolStripMenuItem.Text = "🔐 Yönetim Ayarları";
            yonetimToolStripMenuItem.Click += menuStrip_Click;
            // 
            // ayarlarToolStripMenuItem
            // 
            ayarlarToolStripMenuItem.ForeColor = Color.FromArgb(44, 62, 80);
            ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            ayarlarToolStripMenuItem.Size = new Size(98, 24);
            ayarlarToolStripMenuItem.Text = "⚙ Ayarlar";
            ayarlarToolStripMenuItem.Click += menuStrip_Click;
            // 
            // cikisToolStripMenuItem
            // 
            cikisToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            cikisToolStripMenuItem.ForeColor = Color.FromArgb(192, 57, 43);
            cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            cikisToolStripMenuItem.Size = new Size(104, 24);
            cikisToolStripMenuItem.Text = "🔒 Çıkış Yap";
            cikisToolStripMenuItem.Click += cikisYapToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1521, 711);
            Controls.Add(panel_Giris);
            Controls.Add(flowLayoutPanel_Kartlar);
            Controls.Add(panel_Ust);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            panel_Ust.ResumeLayout(false);
            panel_Ust.PerformLayout();
            panel_Giris.ResumeLayout(false);
            panel_Giris.PerformLayout();
            panel_Sol.ResumeLayout(false);
            panel_Sol.PerformLayout();
            flowLayoutPanel_Kartlar.ResumeLayout(false);
            panel_Kitap.ResumeLayout(false);
            panel_Kitap.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_Uye.ResumeLayout(false);
            panel_Uye.PerformLayout();
            panel_Odunc.ResumeLayout(false);
            panel_Odunc.PerformLayout();
            panel_Geciklis.ResumeLayout(false);
            panel_Geciklis.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Ust;
        private Label lblKullaniciAdi;
        private Panel panel_Kitap;
        private Panel panel_Uye;
        private Panel panel_Odunc;
        private Panel panel_Geciklis;
        private Panel panel_Yazar;
        private Panel panel_Yayinevi;
        private Label label_KitapSayisi;
        private Label label_UyeSayisi;
        private Label label_OduncSayisi;
        private Label label_GecikmisUyeSayisi;
        private Label label_YayineviSayisi;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel_Kartlar;
        private System.Windows.Forms.Timer timer_Dashboard;
        private Label label_Mesaj;
        private Label label_UyeKadinSayisi;
        private Label label_UyeErkekSayisi;
        private Panel panel1;
        private Label label_YazarSayisi;
        private Label label8;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gostergePaneliToolStripMenuItem;
        private ToolStripMenuItem yerlesimAyarlariToolStripMenuItem;
        private ToolStripMenuItem kitapIslemleriToolStripMenuItem;
        private ToolStripMenuItem kategoriIslemleriToolStripMenuItem;
        private ToolStripMenuItem yazarToolStripMenuItem;
        private ToolStripMenuItem yayineviToolStripMenuItem;
        private ToolStripMenuItem dilToolStripMenuItem;
        private ToolStripMenuItem oduncToolStripMenuItem;
        private ToolStripMenuItem uyeToolStripMenuItem;
        private ToolStripMenuItem personelToolStripMenuItem;
        private ToolStripMenuItem raporlamaToolStripMenuItem;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem cikisToolStripMenuItem;
        private ToolStripMenuItem kitapToolStripMenuItem;
        private Panel panel_Giris;
        private Panel panel_Sol;
        private Label label_Logo;
        private Label label_Baslik2;
        private Label label_Baslik1;
        private CheckBox checkBox_BeniHatirla;
        private Button btnCikis;
        private Button btnGiris;
        private Label label7;
        private TextBox textBox_Sifre;
        private TextBox textBox_KullaniciAdi;
        private Label label9;
        private ToolStripMenuItem yonetimToolStripMenuItem;
    }
}