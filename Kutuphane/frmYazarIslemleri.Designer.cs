namespace Kutuphane.UI
{
    partial class frmYazarIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYazarIslemleri));
            btnAra = new Button();
            label3 = new Label();
            textBox_Ara = new TextBox();
            dataGrid_Yazar = new DataGridView();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            btnGeriYukle = new Button();
            btnSilinenleriGoster = new Button();
            btnTemizle = new Button();
            btnSil = new Button();
            btnDuzenle = new Button();
            btnKaydet = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox_AdSoyad = new TextBox();
            textBox_YazarId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Yazar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAra
            // 
            btnAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAra.Location = new Point(823, 12);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 23);
            btnAra.TabIndex = 12;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(615, 16);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 11;
            label3.Text = "Ara:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_Ara.Location = new Point(649, 13);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Yazar adı ile arayın";
            textBox_Ara.Size = new Size(168, 23);
            textBox_Ara.TabIndex = 10;
            // 
            // dataGrid_Yazar
            // 
            dataGrid_Yazar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Yazar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Yazar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Yazar.Location = new Point(318, 42);
            dataGrid_Yazar.Name = "dataGrid_Yazar";
            dataGrid_Yazar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Yazar.Size = new Size(580, 481);
            dataGrid_Yazar.TabIndex = 9;
            dataGrid_Yazar.SelectionChanged += dataGrid_Yazar_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(btnGeriYukle);
            groupBox1.Controls.Add(btnSilinenleriGoster);
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnDuzenle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_AdSoyad);
            groupBox1.Controls.Add(textBox_YazarId);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 517);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kategori İşlemleri";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(93, 90);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(201, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.Location = new Point(118, 274);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(150, 25);
            btnGeriYukle.TabIndex = 20;
            btnGeriYukle.Text = "Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = true;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.Location = new Point(118, 243);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(150, 25);
            btnSilinenleriGoster.TabIndex = 19;
            btnSilinenleriGoster.Text = "Silinenleri Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = true;
            btnSilinenleriGoster.Visible = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(118, 212);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(150, 25);
            btnTemizle.TabIndex = 17;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(118, 181);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(150, 25);
            btnSil.TabIndex = 18;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(118, 150);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(150, 25);
            btnDuzenle.TabIndex = 16;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(118, 119);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(150, 25);
            btnKaydet.TabIndex = 15;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 96);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 14;
            label4.Text = "Doğum Tarihi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 64);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 14;
            label1.Text = "Adı Soyadı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 35);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 14;
            label2.Text = "Yazar Id:";
            // 
            // textBox_AdSoyad
            // 
            textBox_AdSoyad.Location = new Point(93, 61);
            textBox_AdSoyad.Name = "textBox_AdSoyad";
            textBox_AdSoyad.Size = new Size(201, 23);
            textBox_AdSoyad.TabIndex = 13;
            // 
            // textBox_YazarId
            // 
            textBox_YazarId.Location = new Point(93, 32);
            textBox_YazarId.Name = "textBox_YazarId";
            textBox_YazarId.Size = new Size(201, 23);
            textBox_YazarId.TabIndex = 13;
            // 
            // frmYazarIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 541);
            Controls.Add(btnAra);
            Controls.Add(label3);
            Controls.Add(textBox_Ara);
            Controls.Add(dataGrid_Yazar);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmYazarIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Yazar İşlemleri";
            Load += frmYazarIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_Yazar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAra;
        private Label label3;
        private TextBox textBox_Ara;
        private DataGridView dataGrid_Yazar;
        private GroupBox groupBox1;
        private Button btnGeriYukle;
        private Button btnSilinenleriGoster;
        private Button btnTemizle;
        private Button btnSil;
        private Button btnDuzenle;
        private Button btnKaydet;
        private Label label1;
        private Label label2;
        private TextBox textBox_AdSoyad;
        private TextBox textBox_YazarId;
        private DateTimePicker dateTimePicker1;
        private Label label4;
    }
}