namespace Kutuphane.UI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnGiris = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(16, 52);
            txtKullaniciAdi.Margin = new Padding(4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(344, 29);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(16, 132);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(344, 29);
            txtSifre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 5;
            label2.Text = "Kullanıcı Adı: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 100);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 6;
            label3.Text = "Şifre: ";
            // 
            // btnGiris
            // 
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiris.Location = new Point(13, 225);
            btnGiris.Margin = new Padding(4);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(347, 45);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 173);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 25);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(384, 291);
            Controls.Add(checkBox1);
            Controls.Add(btnGiris);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(400, 330);
            MinimumSize = new Size(400, 330);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Giriş";
            FormClosed += frmLogin_FormClosed;
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Label label2;
        private Label label3;
        private Button btnGiris;
        private CheckBox checkBox1;
    }
}