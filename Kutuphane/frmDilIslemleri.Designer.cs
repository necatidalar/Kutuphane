namespace Kutuphane.UI
{
    partial class frmDilIslemleri
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDilIslemleri));
            dataGrid_Dil = new DataGridView();
            dilIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dilAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dilKoduDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifMiDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dilBindingSource = new BindingSource(components);
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
            dataGrid_Dil.AllowUserToAddRows = false;
            dataGrid_Dil.AllowUserToDeleteRows = false;
            dataGrid_Dil.AllowUserToResizeRows = false;
            dataGrid_Dil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGrid_Dil.AutoGenerateColumns = false;
            dataGrid_Dil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Dil.BackgroundColor = Color.FromArgb(245, 246, 250);
            dataGrid_Dil.BorderStyle = BorderStyle.None;
            dataGrid_Dil.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGrid_Dil.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid_Dil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Dil.ColumnHeadersHeight = 35;
            dataGrid_Dil.Columns.AddRange(new DataGridViewColumn[] { dilIdDataGridViewTextBoxColumn, dilAdiDataGridViewTextBoxColumn, dilKoduDataGridViewTextBoxColumn, aktifMiDataGridViewCheckBoxColumn });
            dataGrid_Dil.DataSource = dilBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGrid_Dil.DefaultCellStyle = dataGridViewCellStyle2;
            dataGrid_Dil.EnableHeadersVisualStyles = false;
            dataGrid_Dil.GridColor = Color.FromArgb(231, 229, 255);
            dataGrid_Dil.Location = new Point(325, 55);
            dataGrid_Dil.MultiSelect = false;
            dataGrid_Dil.Name = "dataGrid_Dil";
            dataGrid_Dil.ReadOnly = true;
            dataGrid_Dil.RowHeadersVisible = false;
            dataGrid_Dil.RowTemplate.Height = 32;
            dataGrid_Dil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Dil.Size = new Size(606, 484);
            dataGrid_Dil.TabIndex = 12;
            dataGrid_Dil.CellFormatting += dataGrid_Dil_CellFormatting;
            dataGrid_Dil.ColumnHeaderMouseClick += dataGrid_Dil_ColumnHeaderMouseClick;
            dataGrid_Dil.SelectionChanged += dataGrid_Dil_SelectionChanged;
            // 
            // dilIdDataGridViewTextBoxColumn
            // 
            dilIdDataGridViewTextBoxColumn.DataPropertyName = "DilId";
            dilIdDataGridViewTextBoxColumn.HeaderText = "DilId";
            dilIdDataGridViewTextBoxColumn.Name = "dilIdDataGridViewTextBoxColumn";
            dilIdDataGridViewTextBoxColumn.ReadOnly = true;
            dilIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dilAdiDataGridViewTextBoxColumn
            // 
            dilAdiDataGridViewTextBoxColumn.DataPropertyName = "DilAdi";
            dilAdiDataGridViewTextBoxColumn.HeaderText = "Dil Adı";
            dilAdiDataGridViewTextBoxColumn.Name = "dilAdiDataGridViewTextBoxColumn";
            dilAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dilKoduDataGridViewTextBoxColumn
            // 
            dilKoduDataGridViewTextBoxColumn.DataPropertyName = "DilKodu";
            dilKoduDataGridViewTextBoxColumn.HeaderText = "Dil Kodu";
            dilKoduDataGridViewTextBoxColumn.Name = "dilKoduDataGridViewTextBoxColumn";
            dilKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aktifMiDataGridViewCheckBoxColumn
            // 
            aktifMiDataGridViewCheckBoxColumn.DataPropertyName = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.HeaderText = "Durum";
            aktifMiDataGridViewCheckBoxColumn.Name = "aktifMiDataGridViewCheckBoxColumn";
            aktifMiDataGridViewCheckBoxColumn.ReadOnly = true;
            aktifMiDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dilBindingSource
            // 
            dilBindingSource.DataSource = typeof(Model.Entity.Dil);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(325, 27);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 14;
            label3.Text = "Arama:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Font = new Font("Segoe UI", 10F);
            textBox_Ara.Location = new Point(382, 24);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Dil adı veya koduyla arayın...";
            textBox_Ara.Size = new Size(265, 25);
            textBox_Ara.TabIndex = 10;
            textBox_Ara.TextChanged += textBox_Ara_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
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
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(41, 128, 185);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 527);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "🌎 Dil Kayıt İşlemleri";
            // 
            // textBox_DilAdi
            // 
            textBox_DilAdi.Font = new Font("Segoe UI", 10F);
            textBox_DilAdi.Location = new Point(93, 61);
            textBox_DilAdi.Name = "textBox_DilAdi";
            textBox_DilAdi.Size = new Size(190, 25);
            textBox_DilAdi.TabIndex = 2;
            // 
            // textBox_DilId
            // 
            textBox_DilId.BackColor = Color.FromArgb(236, 240, 241);
            textBox_DilId.Enabled = false;
            textBox_DilId.Font = new Font("Segoe UI", 10F);
            textBox_DilId.Location = new Point(93, 32);
            textBox_DilId.Name = "textBox_DilId";
            textBox_DilId.ReadOnly = true;
            textBox_DilId.Size = new Size(190, 25);
            textBox_DilId.TabIndex = 1;
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.BackColor = Color.FromArgb(52, 73, 94);
            btnGeriYukle.Cursor = Cursors.Hand;
            btnGeriYukle.FlatAppearance.BorderSize = 0;
            btnGeriYukle.FlatStyle = FlatStyle.Flat;
            btnGeriYukle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGeriYukle.ForeColor = Color.White;
            btnGeriYukle.Location = new Point(18, 412);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(265, 38);
            btnGeriYukle.TabIndex = 9;
            btnGeriYukle.Text = "↩️ Seçili Dili Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = false;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.BackColor = Color.FromArgb(236, 240, 241);
            btnSilinenleriGoster.Cursor = Cursors.Hand;
            btnSilinenleriGoster.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnSilinenleriGoster.FlatStyle = FlatStyle.Flat;
            btnSilinenleriGoster.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSilinenleriGoster.ForeColor = Color.FromArgb(41, 128, 185);
            btnSilinenleriGoster.Location = new Point(18, 368);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(265, 38);
            btnSilinenleriGoster.TabIndex = 8;
            btnSilinenleriGoster.Text = "🗑️ Silinen Dilleri Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(149, 165, 166);
            btnTemizle.Cursor = Cursors.Hand;
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(18, 324);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(265, 38);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "\U0001f9f9 TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 57, 43);
            btnSil.Cursor = Cursors.Hand;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(18, 280);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(265, 38);
            btnSil.TabIndex = 6;
            btnSil.Text = "❌ SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.FromArgb(52, 152, 219);
            btnDuzenle.Cursor = Cursors.Hand;
            btnDuzenle.FlatAppearance.BorderSize = 0;
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDuzenle.ForeColor = Color.White;
            btnDuzenle.Location = new Point(18, 236);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(265, 38);
            btnDuzenle.TabIndex = 5;
            btnDuzenle.Text = "✏️ DÜZENLE";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(39, 174, 96);
            btnKaydet.Cursor = Cursors.Hand;
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(18, 192);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(265, 38);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "💾 KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(18, 92);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 30;
            label4.Text = "Dil Kodu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(30, 64);
            label1.Name = "label1";
            label1.Size = new Size(55, 19);
            label1.TabIndex = 22;
            label1.Text = "Dil Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(41, 35);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 23;
            label2.Text = "Dil Id:";
            // 
            // textBox_DilKodu
            // 
            textBox_DilKodu.Font = new Font("Segoe UI", 10F);
            textBox_DilKodu.Location = new Point(93, 90);
            textBox_DilKodu.Name = "textBox_DilKodu";
            textBox_DilKodu.Size = new Size(190, 25);
            textBox_DilKodu.TabIndex = 3;
            // 
            // frmDilIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(943, 551);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(textBox_Ara);
            Controls.Add(dataGrid_Dil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(818, 590);
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
        private Label label4;
        private TextBox textBox_DilKodu;
        private TextBox textBox_DilAdi;
        private TextBox textBox_DilId;
        private DataGridViewTextBoxColumn dilIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dilAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dilKoduDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
        private BindingSource dilBindingSource;
    }
}