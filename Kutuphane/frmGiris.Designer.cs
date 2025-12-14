namespace Kutuphane.UI
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            panel_Sol = new Panel();
            label_Logo = new Label();
            label_Baslik2 = new Label();
            label_Baslik1 = new Label();
            textBox_KullaniciAdi = new TextBox();
            textBox_Sifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGiris = new Button();
            checkBox_BeniHatirla = new CheckBox();
            btnCikis = new Button();
            panel_Sol.SuspendLayout();
            SuspendLayout();
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
            label_Logo.Size = new Size(132, 106);
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
            label_Baslik2.Size = new Size(147, 30);
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
            // textBox_KullaniciAdi
            // 
            textBox_KullaniciAdi.Font = new Font("Segoe UI", 12F);
            textBox_KullaniciAdi.Location = new Point(286, 95);
            textBox_KullaniciAdi.Margin = new Padding(4);
            textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            textBox_KullaniciAdi.PlaceholderText = "Kullanıcı adınızı giriniz";
            textBox_KullaniciAdi.Size = new Size(298, 29);
            textBox_KullaniciAdi.TabIndex = 1;
            // 
            // textBox_Sifre
            // 
            textBox_Sifre.Font = new Font("Segoe UI", 12F);
            textBox_Sifre.Location = new Point(286, 171);
            textBox_Sifre.Margin = new Padding(4);
            textBox_Sifre.Name = "textBox_Sifre";
            textBox_Sifre.PasswordChar = '●';
            textBox_Sifre.PlaceholderText = "Şifrenizi giriniz";
            textBox_Sifre.Size = new Size(298, 29);
            textBox_Sifre.TabIndex = 2;
            textBox_Sifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(286, 72);
            label1.Name = "label1";
            label1.Size = new Size(111, 19);
            label1.TabIndex = 3;
            label1.Text = "👤 Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(286, 148);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 3;
            label2.Text = "🔑 Şifre:";
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(39, 174, 96);
            btnGiris.Cursor = Cursors.Hand;
            btnGiris.FlatAppearance.BorderSize = 0;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiris.ForeColor = Color.White;
            btnGiris.Location = new Point(286, 258);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(301, 44);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "GİRİŞ YAP";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // checkBox_BeniHatirla
            // 
            checkBox_BeniHatirla.AutoSize = true;
            checkBox_BeniHatirla.Font = new Font("Segoe UI", 10F);
            checkBox_BeniHatirla.ForeColor = Color.FromArgb(64, 64, 64);
            checkBox_BeniHatirla.Location = new Point(286, 215);
            checkBox_BeniHatirla.Name = "checkBox_BeniHatirla";
            checkBox_BeniHatirla.Size = new Size(99, 23);
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
            btnCikis.Location = new Point(595, 0);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(40, 40);
            btnCikis.TabIndex = 6;
            btnCikis.Text = "X";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // frmGiris
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(635, 350);
            Controls.Add(btnCikis);
            Controls.Add(checkBox_BeniHatirla);
            Controls.Add(btnGiris);
            Controls.Add(panel_Sol);
            Controls.Add(label2);
            Controls.Add(textBox_KullaniciAdi);
            Controls.Add(label1);
            Controls.Add(textBox_Sifre);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Giriş";
            Load += frmGiris_Load;
            panel_Sol.ResumeLayout(false);
            panel_Sol.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Sol;
        private Label label_Logo;
        private Label label_Baslik2;
        private Label label_Baslik1;
        private TextBox textBox_KullaniciAdi;
        private TextBox textBox_Sifre;
        private Label label1;
        private Label label2;
        private Button btnGiris;
        private CheckBox checkBox_BeniHatirla;
        private Button btnCikis;
    }
}