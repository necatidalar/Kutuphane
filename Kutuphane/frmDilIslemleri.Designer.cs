namespace Kutuphane.UI
{
    partial class frmDilIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDilIslemleri));
            dataGrid_Dil = new DataGridView();
            dilIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dilAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dilKoduDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dilBindingSource = new BindingSource(components);
            btnAra = new Button();
            label3 = new Label();
            textBox_Ara = new TextBox();
            groupBox1 = new GroupBox();
            textBox_DilAdi = new TextBox();
            textBox_DilId = new TextBox();
            btnGeriYukle = new Button();
            btnSilinenleriGoster = new Button();
            btnTemizle = new Button();
            btnSil = new Button();
            btnDuzenle = new Button();
            btnKaydet = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox_DilKodu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Dil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dilBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGrid_Dil
            // 
            dataGrid_Dil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Dil.AutoGenerateColumns = false;
            dataGrid_Dil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Dil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Dil.Columns.AddRange(new DataGridViewColumn[] { dilIdDataGridViewTextBoxColumn, dilAdiDataGridViewTextBoxColumn, dilKoduDataGridViewTextBoxColumn });
            dataGrid_Dil.DataSource = dilBindingSource;
            dataGrid_Dil.Location = new Point(318, 41);
            dataGrid_Dil.Name = "dataGrid_Dil";
            dataGrid_Dil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Dil.Size = new Size(354, 488);
            dataGrid_Dil.TabIndex = 12;
            dataGrid_Dil.SelectionChanged += dataGrid_Dil_SelectionChanged;
            // 
            // dilIdDataGridViewTextBoxColumn
            // 
            dilIdDataGridViewTextBoxColumn.DataPropertyName = "DilId";
            dilIdDataGridViewTextBoxColumn.HeaderText = "DilId";
            dilIdDataGridViewTextBoxColumn.Name = "dilIdDataGridViewTextBoxColumn";
            dilIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dilAdiDataGridViewTextBoxColumn
            // 
            dilAdiDataGridViewTextBoxColumn.DataPropertyName = "DilAdi";
            dilAdiDataGridViewTextBoxColumn.HeaderText = "Dil Adı";
            dilAdiDataGridViewTextBoxColumn.Name = "dilAdiDataGridViewTextBoxColumn";
            // 
            // dilKoduDataGridViewTextBoxColumn
            // 
            dilKoduDataGridViewTextBoxColumn.DataPropertyName = "DilKodu";
            dilKoduDataGridViewTextBoxColumn.HeaderText = "Dil Kodu";
            dilKoduDataGridViewTextBoxColumn.Name = "dilKoduDataGridViewTextBoxColumn";
            // 
            // dilBindingSource
            // 
            dilBindingSource.DataSource = typeof(Model.Entity.Dil);
            // 
            // btnAra
            // 
            btnAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAra.Location = new Point(597, 12);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 23);
            btnAra.TabIndex = 11;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(333, 16);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 14;
            label3.Text = "Ara:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_Ara.Location = new Point(367, 13);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Dil adı ya da koduyla arayın";
            textBox_Ara.Size = new Size(224, 23);
            textBox_Ara.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_DilAdi);
            groupBox1.Controls.Add(textBox_DilId);
            groupBox1.Controls.Add(btnGeriYukle);
            groupBox1.Controls.Add(btnSilinenleriGoster);
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnDuzenle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_DilKodu);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 488);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dil İşlemleri";
            // 
            // textBox_DilAdi
            // 
            textBox_DilAdi.Location = new Point(93, 61);
            textBox_DilAdi.Name = "textBox_DilAdi";
            textBox_DilAdi.Size = new Size(201, 23);
            textBox_DilAdi.TabIndex = 2;
            // 
            // textBox_DilId
            // 
            textBox_DilId.Enabled = false;
            textBox_DilId.Location = new Point(93, 32);
            textBox_DilId.Name = "textBox_DilId";
            textBox_DilId.Size = new Size(201, 23);
            textBox_DilId.TabIndex = 1;
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.Location = new Point(118, 285);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(150, 25);
            btnGeriYukle.TabIndex = 9;
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
            btnSilinenleriGoster.TabIndex = 8;
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
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(118, 192);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(150, 25);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(118, 161);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(150, 25);
            btnDuzenle.TabIndex = 5;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(118, 130);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(150, 25);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 93);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 17;
            label4.Text = "Dil Kodu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 64);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 18;
            label1.Text = "Dil Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 35);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 19;
            label2.Text = "Dil Id:";
            // 
            // textBox_DilKodu
            // 
            textBox_DilKodu.Location = new Point(93, 90);
            textBox_DilKodu.Name = "textBox_DilKodu";
            textBox_DilKodu.Size = new Size(201, 23);
            textBox_DilKodu.TabIndex = 3;
            // 
            // frmDilIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 541);
            Controls.Add(groupBox1);
            Controls.Add(btnAra);
            Controls.Add(label3);
            Controls.Add(textBox_Ara);
            Controls.Add(dataGrid_Dil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(700, 580);
            Name = "frmDilIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Dil İşlemleri";
            Load += frmDilIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_Dil).EndInit();
            ((System.ComponentModel.ISupportInitialize)dilBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGrid_Dil;
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
        private TextBox textBox_KategoriAdi;
        private TextBox textBox_KategoriId;
        private Label label4;
        private TextBox textBox_DilKodu;
        private BindingSource dilBindingSource;
        private DataGridViewTextBoxColumn dilIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dilAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dilKoduDataGridViewTextBoxColumn;
        private TextBox textBox_DilAdi;
        private TextBox textBox_DilId;
    }
}