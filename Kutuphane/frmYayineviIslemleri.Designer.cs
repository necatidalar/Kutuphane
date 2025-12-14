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
            dataGrid_Yayinevi = new DataGridView();
            yayineviIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kurulusYiliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifMiDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            yayineviKitaplariDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yayineviBindingSource = new BindingSource(components);
            btnAra = new Button();
            label3 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dataGrid_Yayinevi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yayineviBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGrid_Yayinevi
            // 
            dataGrid_Yayinevi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Yayinevi.AutoGenerateColumns = false;
            dataGrid_Yayinevi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Yayinevi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Yayinevi.Columns.AddRange(new DataGridViewColumn[] { yayineviIdDataGridViewTextBoxColumn, adDataGridViewTextBoxColumn, kurulusYiliDataGridViewTextBoxColumn, aktifMiDataGridViewCheckBoxColumn, yayineviKitaplariDataGridViewTextBoxColumn });
            dataGrid_Yayinevi.DataSource = yayineviBindingSource;
            dataGrid_Yayinevi.Location = new Point(318, 42);
            dataGrid_Yayinevi.Name = "dataGrid_Yayinevi";
            dataGrid_Yayinevi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Yayinevi.Size = new Size(354, 487);
            dataGrid_Yayinevi.TabIndex = 2;
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
            kurulusYiliDataGridViewTextBoxColumn.HeaderText = "Kuruluş Yılı";
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
            // yayineviBindingSource
            // 
            yayineviBindingSource.DataSource = typeof(Model.Entity.Yayinevi);
            // 
            // btnAra
            // 
            btnAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAra.Location = new Point(597, 12);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 23);
            btnAra.TabIndex = 13;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(389, 16);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 11;
            label3.Text = "Ara:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_Ara.Location = new Point(423, 13);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Yayınevi adı ile arayın";
            textBox_Ara.Size = new Size(168, 23);
            textBox_Ara.TabIndex = 12;
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
            groupBox1.Location = new Point(12, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 320);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yayınevi İşlemleri";
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.Location = new Point(118, 285);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(150, 25);
            btnGeriYukle.TabIndex = 8;
            btnGeriYukle.Text = "Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = true;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.Location = new Point(118, 254);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(150, 25);
            btnSilinenleriGoster.TabIndex = 7;
            btnSilinenleriGoster.Text = "Silinenleri Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = true;
            btnSilinenleriGoster.Visible = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(118, 223);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(150, 25);
            btnTemizle.TabIndex = 6;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(118, 192);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(150, 25);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(118, 161);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(150, 25);
            btnDuzenle.TabIndex = 4;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(118, 130);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(150, 25);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 93);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 14;
            label4.Text = "Kuruluş Yılı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 64);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 14;
            label1.Text = "Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 35);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 14;
            label2.Text = "Yayınevi Id:";
            // 
            // textBox_KurulusYili
            // 
            textBox_KurulusYili.Location = new Point(93, 90);
            textBox_KurulusYili.Name = "textBox_KurulusYili";
            textBox_KurulusYili.Size = new Size(201, 23);
            textBox_KurulusYili.TabIndex = 2;
            // 
            // textBox_YayineviAdi
            // 
            textBox_YayineviAdi.Location = new Point(93, 61);
            textBox_YayineviAdi.Name = "textBox_YayineviAdi";
            textBox_YayineviAdi.Size = new Size(201, 23);
            textBox_YayineviAdi.TabIndex = 2;
            // 
            // textBox_YayineviId
            // 
            textBox_YayineviId.Enabled = false;
            textBox_YayineviId.Location = new Point(93, 32);
            textBox_YayineviId.Name = "textBox_YayineviId";
            textBox_YayineviId.Size = new Size(201, 23);
            textBox_YayineviId.TabIndex = 1;
            // 
            // frmYayineviIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 541);
            Controls.Add(groupBox1);
            Controls.Add(btnAra);
            Controls.Add(label3);
            Controls.Add(textBox_Ara);
            Controls.Add(dataGrid_Yayinevi);
            Cursor = Cursors.Default;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(700, 580);
            Name = "frmYayineviIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Yayınevi İşlemleri";
            Load += frmYayineviIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_Yayinevi).EndInit();
            ((System.ComponentModel.ISupportInitialize)yayineviBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid_Yayinevi;
        private Button btnAra;
        private Label label3;
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
        private DataGridViewTextBoxColumn yayineviIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kurulusYiliDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn yayineviKitaplariDataGridViewTextBoxColumn;
        private BindingSource yayineviBindingSource;
    }
}