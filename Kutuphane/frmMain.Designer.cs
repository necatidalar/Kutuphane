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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            göstergePaneliToolStripMenuItem = new ToolStripMenuItem();
            yerleşimAyarlarıToolStripMenuItem = new ToolStripMenuItem();
            kitapİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            kategoriİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            yazarİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            dilİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            yayıneviİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            ödünçİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            üyeİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            personelİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            lblKullaniciAdi = new Label();
            toolStripContainer1 = new ToolStripContainer();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { göstergePaneliToolStripMenuItem, yerleşimAyarlarıToolStripMenuItem, kitapİşlemleriToolStripMenuItem, ödünçİşlemleriToolStripMenuItem, üyeİşlemleriToolStripMenuItem, personelİşlemleriToolStripMenuItem, çıkışYapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1209, 29);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // göstergePaneliToolStripMenuItem
            // 
            göstergePaneliToolStripMenuItem.Name = "göstergePaneliToolStripMenuItem";
            göstergePaneliToolStripMenuItem.Size = new Size(142, 25);
            göstergePaneliToolStripMenuItem.Text = "Gösterge Paneli";
            // 
            // yerleşimAyarlarıToolStripMenuItem
            // 
            yerleşimAyarlarıToolStripMenuItem.Name = "yerleşimAyarlarıToolStripMenuItem";
            yerleşimAyarlarıToolStripMenuItem.Size = new Size(151, 25);
            yerleşimAyarlarıToolStripMenuItem.Text = "Yerleşim Ayarları";
            yerleşimAyarlarıToolStripMenuItem.Click += yerleşimAyarlarıToolStripMenuItem_Click;
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            kitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kategoriİşlemleriToolStripMenuItem, yazarİşlemleriToolStripMenuItem, dilİşlemleriToolStripMenuItem, yayıneviİşlemleriToolStripMenuItem });
            kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            kitapİşlemleriToolStripMenuItem.Size = new Size(132, 25);
            kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            kitapİşlemleriToolStripMenuItem.Click += kitapİşlemleriToolStripMenuItem_Click;
            // 
            // kategoriİşlemleriToolStripMenuItem
            // 
            kategoriİşlemleriToolStripMenuItem.Name = "kategoriİşlemleriToolStripMenuItem";
            kategoriİşlemleriToolStripMenuItem.Size = new Size(215, 26);
            kategoriİşlemleriToolStripMenuItem.Text = "Kategori İşlemleri";
            kategoriİşlemleriToolStripMenuItem.Click += kategoriİşlemleriToolStripMenuItem_Click;
            // 
            // yazarİşlemleriToolStripMenuItem
            // 
            yazarİşlemleriToolStripMenuItem.Name = "yazarİşlemleriToolStripMenuItem";
            yazarİşlemleriToolStripMenuItem.Size = new Size(215, 26);
            yazarİşlemleriToolStripMenuItem.Text = "Yazar İşlemleri";
            yazarİşlemleriToolStripMenuItem.Click += yazarİşlemleriToolStripMenuItem_Click;
            // 
            // dilİşlemleriToolStripMenuItem
            // 
            dilİşlemleriToolStripMenuItem.Name = "dilİşlemleriToolStripMenuItem";
            dilİşlemleriToolStripMenuItem.Size = new Size(215, 26);
            dilİşlemleriToolStripMenuItem.Text = "Dil İşlemleri";
            dilİşlemleriToolStripMenuItem.Click += dilİşlemleriToolStripMenuItem_Click;
            // 
            // yayıneviİşlemleriToolStripMenuItem
            // 
            yayıneviİşlemleriToolStripMenuItem.Name = "yayıneviİşlemleriToolStripMenuItem";
            yayıneviİşlemleriToolStripMenuItem.Size = new Size(215, 26);
            yayıneviİşlemleriToolStripMenuItem.Text = "Yayınevi İşlemleri";
            yayıneviİşlemleriToolStripMenuItem.Click += yayıneviİşlemleriToolStripMenuItem_Click;
            // 
            // ödünçİşlemleriToolStripMenuItem
            // 
            ödünçİşlemleriToolStripMenuItem.Name = "ödünçİşlemleriToolStripMenuItem";
            ödünçİşlemleriToolStripMenuItem.Size = new Size(142, 25);
            ödünçİşlemleriToolStripMenuItem.Text = "Ödünç İşlemleri";
            ödünçİşlemleriToolStripMenuItem.Click += ödünçİşlemleriToolStripMenuItem_Click;
            // 
            // üyeİşlemleriToolStripMenuItem
            // 
            üyeİşlemleriToolStripMenuItem.Name = "üyeİşlemleriToolStripMenuItem";
            üyeİşlemleriToolStripMenuItem.Size = new Size(122, 25);
            üyeİşlemleriToolStripMenuItem.Text = "Üye İşlemleri";
            üyeİşlemleriToolStripMenuItem.Click += üyeİşlemleriToolStripMenuItem_Click;
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            personelİşlemleriToolStripMenuItem.Size = new Size(158, 25);
            personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            personelİşlemleriToolStripMenuItem.Click += personelİşlemleriToolStripMenuItem_Click;
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(90, 25);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblKullaniciAdi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1209, 37);
            panel1.TabIndex = 4;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKullaniciAdi.Location = new Point(12, 6);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(98, 20);
            lblKullaniciAdi.TabIndex = 1;
            lblKullaniciAdi.Text = "Hoşgeldiniz, ";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(panel1);
            toolStripContainer1.ContentPanel.Size = new Size(1209, 682);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(1209, 711);
            toolStripContainer1.TabIndex = 5;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(menuStrip1);
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 711);
            Controls.Add(toolStripContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

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
        private Panel panel1;
        private Label lblKullaniciAdi;
        private ToolStripContainer toolStripContainer1;
    }
}