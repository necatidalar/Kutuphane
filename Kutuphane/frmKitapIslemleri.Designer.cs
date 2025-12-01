namespace Kutuphane.UI
{
    partial class frmKitapIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapIslemleri));
            cmbKategori = new ComboBox();
            label2 = new Label();
            btnSil = new Button();
            txtBasimYili = new TextBox();
            btnDuzenle = new Button();
            btnKaydet = new Button();
            txtDil = new TextBox();
            label8 = new Label();
            label1 = new Label();
            label7 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbYayinevi = new ComboBox();
            txtKitapAdi = new TextBox();
            txtISBN = new TextBox();
            cmbYazar = new ComboBox();
            txtSayfaSayisi = new TextBox();
            dataGridView1 = new DataGridView();
            txtKitapID = new TextBox();
            label9 = new Label();
            label10 = new Label();
            btnCikis = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(125, 228);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(250, 29);
            cmbKategori.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 88);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 14;
            label2.Text = "Kitap Adı:";
            // 
            // btnSil
            // 
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(125, 481);
            btnSil.Margin = new Padding(4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(250, 45);
            btnSil.TabIndex = 28;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtBasimYili
            // 
            txtBasimYili.Location = new Point(125, 264);
            txtBasimYili.Margin = new Padding(4);
            txtBasimYili.Name = "txtBasimYili";
            txtBasimYili.Size = new Size(250, 29);
            txtBasimYili.TabIndex = 16;
            // 
            // btnDuzenle
            // 
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDuzenle.Location = new Point(125, 428);
            btnDuzenle.Margin = new Padding(4);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(250, 45);
            btnDuzenle.TabIndex = 27;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(125, 375);
            btnKaydet.Margin = new Padding(4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(250, 45);
            btnKaydet.TabIndex = 30;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtDil
            // 
            txtDil.Location = new Point(125, 338);
            txtDil.Margin = new Padding(4);
            txtDil.Name = "txtDil";
            txtDil.Size = new Size(250, 29);
            txtDil.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(81, 341);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(36, 21);
            label8.TabIndex = 24;
            label8.Text = "Dil:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 125);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 26;
            label1.Text = "ISBN:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 304);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(104, 21);
            label7.TabIndex = 23;
            label7.Text = "Sayfa Sayısı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 161);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 22;
            label3.Text = "Yazar:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 267);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 21);
            label6.TabIndex = 21;
            label6.Text = "Basım Yılı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 196);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 20;
            label4.Text = "Yayınevi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 231);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 25;
            label5.Text = "Kategori:";
            // 
            // cmbYayinevi
            // 
            cmbYayinevi.FormattingEnabled = true;
            cmbYayinevi.Location = new Point(125, 193);
            cmbYayinevi.Name = "cmbYayinevi";
            cmbYayinevi.Size = new Size(250, 29);
            cmbYayinevi.TabIndex = 32;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(125, 85);
            txtKitapAdi.Margin = new Padding(4);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(250, 29);
            txtKitapAdi.TabIndex = 13;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(125, 122);
            txtISBN.Margin = new Padding(4);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(250, 29);
            txtISBN.TabIndex = 19;
            // 
            // cmbYazar
            // 
            cmbYazar.FormattingEnabled = true;
            cmbYazar.Location = new Point(125, 158);
            cmbYazar.Name = "cmbYazar";
            cmbYazar.Size = new Size(250, 29);
            cmbYazar.TabIndex = 33;
            // 
            // txtSayfaSayisi
            // 
            txtSayfaSayisi.Location = new Point(125, 301);
            txtSayfaSayisi.Margin = new Padding(4);
            txtSayfaSayisi.Name = "txtSayfaSayisi";
            txtSayfaSayisi.Size = new Size(250, 29);
            txtSayfaSayisi.TabIndex = 34;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(382, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1161, 788);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.ForeColor = Color.Black;
            // 
            // txtKitapID
            // 
            txtKitapID.Location = new Point(125, 48);
            txtKitapID.Margin = new Padding(4);
            txtKitapID.Name = "txtKitapID";
            txtKitapID.Size = new Size(250, 29);
            txtKitapID.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 51);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(75, 21);
            label9.TabIndex = 14;
            label9.Text = "Kitap ID:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Size = new Size(320, 21);
            label10.TabIndex = 37;
            label10.Text = "Kütüphane Otomasyonu - Kitap İşlemleri";
            // 
            // btnCikis
            // 
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(1513, 12);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(30, 30);
            btnCikis.TabIndex = 39;
            btnCikis.Text = "X";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // frmKitapIslemleri
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(1555, 848);
            Controls.Add(btnCikis);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(txtSayfaSayisi);
            Controls.Add(cmbKategori);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(btnSil);
            Controls.Add(txtBasimYili);
            Controls.Add(btnDuzenle);
            Controls.Add(btnKaydet);
            Controls.Add(txtDil);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(cmbYayinevi);
            Controls.Add(txtKitapID);
            Controls.Add(txtKitapAdi);
            Controls.Add(txtISBN);
            Controls.Add(cmbYazar);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmKitapIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Kitap İşlemleri";
            Load += frmKitapIslemleri_Load;
            Paint += frmKitapIslemleri_Paint;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbKategori;
        private Label label2;
        private Button btnSil;
        private TextBox txtBasimYili;
        private Button btnDuzenle;
        private TextBox textBox6;
        private Button btnKaydet;
        private TextBox txtDil;
        private Label label8;
        private Label label1;
        private Label label7;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label5;
        private ComboBox cmbYayinevi;
        private TextBox txtKitapAdi;
        private TextBox txtISBN;
        private ComboBox cmbYazar;
        private TextBox txtSayfaSayisi;
        private DataGridView dataGridView1;
        private TextBox txtKitapID;
        private Label label9;
        private Label label10;
        private Button btnCikis;
    }
}