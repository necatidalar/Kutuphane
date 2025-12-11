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
            çokluKatYönetimiToolStripMenuItem = new ToolStripMenuItem();
            kitapİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            ödünçİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            üyeİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            personelİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            lblKullaniciAdi = new Label();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { göstergePaneliToolStripMenuItem, çokluKatYönetimiToolStripMenuItem, kitapİşlemleriToolStripMenuItem, ödünçİşlemleriToolStripMenuItem, üyeİşlemleriToolStripMenuItem, personelİşlemleriToolStripMenuItem, çıkışToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1199, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // göstergePaneliToolStripMenuItem
            // 
            göstergePaneliToolStripMenuItem.Name = "göstergePaneliToolStripMenuItem";
            göstergePaneliToolStripMenuItem.Size = new Size(142, 25);
            göstergePaneliToolStripMenuItem.Text = "Gösterge Paneli";
            // 
            // çokluKatYönetimiToolStripMenuItem
            // 
            çokluKatYönetimiToolStripMenuItem.Name = "çokluKatYönetimiToolStripMenuItem";
            çokluKatYönetimiToolStripMenuItem.Size = new Size(168, 25);
            çokluKatYönetimiToolStripMenuItem.Text = "Çoklu Kat Yönetimi";
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            kitapİşlemleriToolStripMenuItem.Size = new Size(132, 25);
            kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            kitapİşlemleriToolStripMenuItem.Click += kitapİşlemleriToolStripMenuItem_Click;
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
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(58, 25);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(3, 11);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(204, 21);
            lblKullaniciAdi.TabIndex = 1;
            lblKullaniciAdi.Text = "Hoşgeldiniz, Kullanıcı adı";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblKullaniciAdi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 44);
            panel1.TabIndex = 4;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1199, 748);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Gösterge Paneli";
            WindowState = FormWindowState.Maximized;
            FormClosed += frmDashboard_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem göstergePaneliToolStripMenuItem;
        private ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private ToolStripMenuItem çokluKatYönetimiToolStripMenuItem;
        private ToolStripMenuItem ödünçİşlemleriToolStripMenuItem;
        private ToolStripMenuItem üyeİşlemleriToolStripMenuItem;
        private ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private Label lblKullaniciAdi;
        private Panel panel1;
    }
}