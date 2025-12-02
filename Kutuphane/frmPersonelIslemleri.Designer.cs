namespace Kutuphane.UI
{
    partial class frmPersonelIslemleri
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
            label1 = new Label();
            btnCikis = new Button();
            label9 = new Label();
            txtPersonelID = new TextBox();
            label2 = new Label();
            txtAdSoyad = new TextBox();
            txtKullaniciAdi = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnSil = new Button();
            btnDuzenle = new Button();
            txtSifre = new TextBox();
            label3 = new Label();
            btnKaydet = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(428, 28);
            label1.TabIndex = 0;
            label1.Text = "Kütüphane Otomasyonu - Personel İşlemleri";
            // 
            // btnCikis
            // 
            btnCikis.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(1226, 12);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(30, 30);
            btnCikis.TabIndex = 40;
            btnCikis.Text = "X";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 37);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(124, 28);
            label9.TabIndex = 14;
            label9.Text = "Personel ID:";
            // 
            // txtPersonelID
            // 
            txtPersonelID.Location = new Point(153, 34);
            txtPersonelID.Margin = new Padding(4);
            txtPersonelID.Name = "txtPersonelID";
            txtPersonelID.Size = new Size(250, 34);
            txtPersonelID.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 79);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 14;
            label2.Text = "Ad Soyad:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(153, 76);
            txtAdSoyad.Margin = new Padding(4);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(250, 34);
            txtAdSoyad.TabIndex = 13;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(153, 118);
            txtKullaniciAdi.Margin = new Padding(4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(250, 34);
            txtKullaniciAdi.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 121);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(137, 28);
            label4.TabIndex = 26;
            label4.Text = "Kullanıcı Adı:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtPersonelID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnDuzenle);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(txtKullaniciAdi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(label4);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(20, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 372);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel İşlemleri";
            // 
            // btnSil
            // 
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(153, 308);
            btnSil.Margin = new Padding(4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(250, 45);
            btnSil.TabIndex = 28;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnDuzenle
            // 
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDuzenle.Location = new Point(153, 255);
            btnDuzenle.Margin = new Padding(4);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(250, 45);
            btnDuzenle.TabIndex = 27;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(153, 160);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(250, 34);
            txtSifre.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 163);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 26;
            label3.Text = "Şifre:";
            // 
            // btnKaydet
            // 
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(153, 202);
            btnKaydet.Margin = new Padding(4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(250, 45);
            btnKaydet.TabIndex = 30;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(444, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(801, 689);
            dataGridView1.TabIndex = 43;
            // 
            // frmPersonelIslemleri
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(1268, 783);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(btnCikis);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmPersonelIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Personel İşlemleri";
            Load += frmPersonelIslemleri_Load;
            Paint += frmPersonelIslemleri_Paint;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCikis;
        private Label label9;
        private TextBox txtPersonelID;
        private Label label2;
        private TextBox txtAdSoyad;
        private TextBox txtKullaniciAdi;
        private Label label4;
        private GroupBox groupBox1;
        private Button btnSil;
        private Button btnDuzenle;
        private Button btnKaydet;
        private TextBox txtSifre;
        private Label label3;
        private DataGridView dataGridView1;
    }
}