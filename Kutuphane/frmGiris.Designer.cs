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
            textBox_KullaniciAdi = new TextBox();
            textBox_Sifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGiris = new Button();
            checkBox_BeniHatirla = new CheckBox();
            SuspendLayout();
            // 
            // textBox_KullaniciAdi
            // 
            textBox_KullaniciAdi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox_KullaniciAdi.Location = new Point(13, 44);
            textBox_KullaniciAdi.Margin = new Padding(4);
            textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            textBox_KullaniciAdi.Size = new Size(298, 29);
            textBox_KullaniciAdi.TabIndex = 1;
            // 
            // textBox_Sifre
            // 
            textBox_Sifre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox_Sifre.Location = new Point(13, 111);
            textBox_Sifre.Margin = new Padding(4);
            textBox_Sifre.Name = "textBox_Sifre";
            textBox_Sifre.Size = new Size(298, 29);
            textBox_Sifre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiris.Location = new Point(12, 205);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(301, 44);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // checkBox_BeniHatirla
            // 
            checkBox_BeniHatirla.AutoSize = true;
            checkBox_BeniHatirla.Location = new Point(13, 147);
            checkBox_BeniHatirla.Name = "checkBox_BeniHatirla";
            checkBox_BeniHatirla.Size = new Size(109, 25);
            checkBox_BeniHatirla.TabIndex = 3;
            checkBox_BeniHatirla.Text = "Beni Hatırla";
            checkBox_BeniHatirla.UseVisualStyleBackColor = true;
            // 
            // frmGiris
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 261);
            Controls.Add(checkBox_BeniHatirla);
            Controls.Add(btnGiris);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Sifre);
            Controls.Add(textBox_KullaniciAdi);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(340, 300);
            MinimumSize = new Size(340, 300);
            Name = "frmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            Load += frmGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_KullaniciAdi;
        private TextBox textBox_Sifre;
        private Label label1;
        private Label label2;
        private Button btnGiris;
        private CheckBox checkBox_BeniHatirla;
    }
}