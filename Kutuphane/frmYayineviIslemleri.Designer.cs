namespace Kutuphane.UI
{
    partial class frmYayineviIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYayineviIslemleri));
            yayineviBindingSource = new BindingSource(components);
            textBox_Ara = new TextBox();
            groupBox1 = new GroupBox();
            btnGeriYukle = new Button();
            btnSilinenleriGoster = new Button();
            btnTemizle = new Button();
            btnSil = new Button();
            btnDuzenle = new Button();
            btnKaydet = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox_KurulusYili = new TextBox();
            textBox_YayineviAdi = new TextBox();
            textBox_YayineviId = new TextBox();
            label_txtAra = new Label();
            dataGrid_Yayinevi = new DataGridView();
            yayineviIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kurulusYiliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifMiDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            yayineviKitaplariDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)yayineviBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Yayinevi).BeginInit();
            SuspendLayout();
            // 
            // yayineviBindingSource
            // 
            yayineviBindingSource.DataSource = typeof(Model.Entity.Yayinevi);
            // 
            // textBox_Ara
            // 
            textBox_Ara.Font = new Font("Segoe UI", 10F);
            textBox_Ara.Location = new Point(375, 11);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Yayınevi adı ile arayın";
            textBox_Ara.Size = new Size(252, 25);
            textBox_Ara.TabIndex = 12;
            textBox_Ara.TextChanged += textBox_Ara_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGeriYukle);
            groupBox1.Controls.Add(btnSilinenleriGoster);
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnDuzenle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_KurulusYili);
            groupBox1.Controls.Add(textBox_YayineviAdi);
            groupBox1.Controls.Add(textBox_YayineviId);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 379);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "📚 Yayınevi İşlemleri";
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.BackColor = Color.FromArgb(39, 174, 96);
            btnGeriYukle.FlatAppearance.BorderSize = 0;
            btnGeriYukle.FlatStyle = FlatStyle.Flat;
            btnGeriYukle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGeriYukle.ForeColor = Color.White;
            btnGeriYukle.Location = new Point(118, 328);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(150, 35);
            btnGeriYukle.TabIndex = 8;
            btnGeriYukle.Text = "♻️ Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = false;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.BackColor = Color.FromArgb(52, 73, 94);
            btnSilinenleriGoster.FlatAppearance.BorderSize = 0;
            btnSilinenleriGoster.FlatStyle = FlatStyle.Flat;
            btnSilinenleriGoster.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSilinenleriGoster.ForeColor = Color.White;
            btnSilinenleriGoster.Location = new Point(118, 287);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(150, 35);
            btnSilinenleriGoster.TabIndex = 7;
            btnSilinenleriGoster.Text = "🗑️ Silinenleri Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(149, 165, 166);
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(118, 246);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(150, 35);
            btnTemizle.TabIndex = 6;
            btnTemizle.Text = "\U0001f9f9 Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 57, 43);
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(118, 205);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(150, 35);
            btnSil.TabIndex = 5;
            btnSil.Text = "❌ Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.FromArgb(41, 128, 185);
            btnDuzenle.FlatAppearance.BorderSize = 0;
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDuzenle.ForeColor = Color.White;
            btnDuzenle.Location = new Point(118, 164);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(150, 35);
            btnDuzenle.TabIndex = 4;
            btnDuzenle.Text = "✏️ Düzenle";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(39, 174, 96);
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(118, 123);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(150, 35);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "➕ Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(3, 97);
            label4.Name = "label4";
            label4.Size = new Size(84, 19);
            label4.TabIndex = 14;
            label4.Text = "Kuruluş Yılı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(53, 66);
            label1.Name = "label1";
            label1.Size = new Size(33, 19);
            label1.TabIndex = 14;
            label1.Text = "Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(14, 35);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 14;
            label2.Text = "Yayınevi Id:";
            // 
            // textBox_KurulusYili
            // 
            textBox_KurulusYili.Font = new Font("Segoe UI", 10F);
            textBox_KurulusYili.Location = new Point(93, 94);
            textBox_KurulusYili.Name = "textBox_KurulusYili";
            textBox_KurulusYili.Size = new Size(201, 25);
            textBox_KurulusYili.TabIndex = 2;
            // 
            // textBox_YayineviAdi
            // 
            textBox_YayineviAdi.Font = new Font("Segoe UI", 10F);
            textBox_YayineviAdi.Location = new Point(92, 63);
            textBox_YayineviAdi.Name = "textBox_YayineviAdi";
            textBox_YayineviAdi.Size = new Size(201, 25);
            textBox_YayineviAdi.TabIndex = 2;
            // 
            // textBox_YayineviId
            // 
            textBox_YayineviId.Enabled = false;
            textBox_YayineviId.Font = new Font("Segoe UI", 10F);
            textBox_YayineviId.Location = new Point(93, 32);
            textBox_YayineviId.Name = "textBox_YayineviId";
            textBox_YayineviId.Size = new Size(201, 25);
            textBox_YayineviId.TabIndex = 1;
            // 
            // label_txtAra
            // 
            label_txtAra.AutoSize = true;
            label_txtAra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label_txtAra.ForeColor = Color.FromArgb(64, 64, 64);
            label_txtAra.Location = new Point(318, 14);
            label_txtAra.Name = "label_txtAra";
            label_txtAra.Size = new Size(51, 17);
            label_txtAra.TabIndex = 21;
            label_txtAra.Text = "Arama:";
            // 
            // dataGrid_Yayinevi
            // 
            dataGrid_Yayinevi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGrid_Yayinevi.AutoGenerateColumns = false;
            dataGrid_Yayinevi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Yayinevi.Columns.AddRange(new DataGridViewColumn[] { yayineviIdDataGridViewTextBoxColumn, adDataGridViewTextBoxColumn, kurulusYiliDataGridViewTextBoxColumn, aktifMiDataGridViewCheckBoxColumn, yayineviKitaplariDataGridViewTextBoxColumn });
            dataGrid_Yayinevi.DataSource = yayineviBindingSource;
            dataGrid_Yayinevi.Location = new Point(318, 42);
            dataGrid_Yayinevi.Name = "dataGrid_Yayinevi";
            dataGrid_Yayinevi.Size = new Size(605, 487);
            dataGrid_Yayinevi.TabIndex = 22;
            dataGrid_Yayinevi.ColumnHeaderMouseClick += dataGrid_Yayinevi_ColumnHeaderMouseClick;
            dataGrid_Yayinevi.SelectionChanged += dataGrid_Yayinevi_SelectionChanged;
            // 
            // yayineviIdDataGridViewTextBoxColumn
            // 
            yayineviIdDataGridViewTextBoxColumn.DataPropertyName = "YayineviId";
            yayineviIdDataGridViewTextBoxColumn.HeaderText = "YayineviId";
            yayineviIdDataGridViewTextBoxColumn.Name = "yayineviIdDataGridViewTextBoxColumn";
            yayineviIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // adDataGridViewTextBoxColumn
            // 
            adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            adDataGridViewTextBoxColumn.HeaderText = "Adı";
            adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // kurulusYiliDataGridViewTextBoxColumn
            // 
            kurulusYiliDataGridViewTextBoxColumn.DataPropertyName = "KurulusYili";
            kurulusYiliDataGridViewTextBoxColumn.HeaderText = "Kurulus Yılı";
            kurulusYiliDataGridViewTextBoxColumn.Name = "kurulusYiliDataGridViewTextBoxColumn";
            // 
            // aktifMiDataGridViewCheckBoxColumn
            // 
            aktifMiDataGridViewCheckBoxColumn.DataPropertyName = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.HeaderText = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.Name = "aktifMiDataGridViewCheckBoxColumn";
            aktifMiDataGridViewCheckBoxColumn.Visible = false;
            // 
            // yayineviKitaplariDataGridViewTextBoxColumn
            // 
            yayineviKitaplariDataGridViewTextBoxColumn.DataPropertyName = "YayineviKitaplari";
            yayineviKitaplariDataGridViewTextBoxColumn.HeaderText = "YayineviKitaplari";
            yayineviKitaplariDataGridViewTextBoxColumn.Name = "yayineviKitaplariDataGridViewTextBoxColumn";
            yayineviKitaplariDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmYayineviIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(935, 541);
            Controls.Add(dataGrid_Yayinevi);
            Controls.Add(label_txtAra);
            Controls.Add(groupBox1);
            Controls.Add(textBox_Ara);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(700, 580);
            Name = "frmYayineviIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Yayınevi İşlemleri";
            Load += frmYayineviIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)yayineviBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Yayinevi).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Button btnAra;
        private TextBox textBox_Ara;
        private GroupBox groupBox1;
        private Button btnGeriYukle;
        private Button btnSilinenleriGoster;
        private Button btnTemizle;
        private Button btnSil;
        private Button btnDuzenle;
        private Button btnKaydet;
        private Label label1;
        private Label label2;
        private TextBox textBox_YayineviAdi;
        private TextBox textBox_YayineviId;
        private Label label4;
        private TextBox textBox_KurulusYili;
        private BindingSource yayineviBindingSource;
        private Label label_txtAra;
        private DataGridView dataGrid_Yayinevi;
        private DataGridViewTextBoxColumn yayineviIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kurulusYiliDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn yayineviKitaplariDataGridViewTextBoxColumn;
    }
}