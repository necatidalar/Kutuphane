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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDilIslemleri));
            dilBindingSource = new BindingSource(components);
            label_txtAra = new Label();
            textBox_Ara = new TextBox();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnKaydet = new Button();
            btnDuzenle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            btnSilinenleriGoster = new Button();
            btnGeriYukle = new Button();
            panel1 = new Panel();
            textBox_DilKodu = new TextBox();
            label2 = new Label();
            textBox_DilAdi = new TextBox();
            label1 = new Label();
            textBox_DilId = new TextBox();
            label4 = new Label();
            dataGrid_Dil = new DataGridView();
            dilIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dilAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dilKoduDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifMiDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dilBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Dil).BeginInit();
            SuspendLayout();
            // 
            // dilBindingSource
            // 
            dilBindingSource.DataSource = typeof(Model.Entity.Dil);
            // 
            // label_txtAra
            // 
            label_txtAra.AutoSize = true;
            label_txtAra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label_txtAra.ForeColor = Color.FromArgb(64, 64, 64);
            label_txtAra.Location = new Point(371, 36);
            label_txtAra.Name = "label_txtAra";
            label_txtAra.Size = new Size(64, 23);
            label_txtAra.TabIndex = 14;
            label_txtAra.Text = "Arama:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Font = new Font("Segoe UI", 10F);
            textBox_Ara.Location = new Point(437, 32);
            textBox_Ara.Margin = new Padding(3, 4, 3, 4);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Dil adı veya koduyla arayın...";
            textBox_Ara.Size = new Size(302, 30);
            textBox_Ara.TabIndex = 10;
            textBox_Ara.TextChanged += textBox_Ara_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(41, 128, 185);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.MaximumSize = new Size(343, 563);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(343, 563);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "🌎 Dil Kayıt İşlemleri";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btnKaydet);
            flowLayoutPanel1.Controls.Add(btnDuzenle);
            flowLayoutPanel1.Controls.Add(btnSil);
            flowLayoutPanel1.Controls.Add(btnTemizle);
            flowLayoutPanel1.Controls.Add(btnSilinenleriGoster);
            flowLayoutPanel1.Controls.Add(btnGeriYukle);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 185);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(11, 13, 11, 13);
            flowLayoutPanel1.Size = new Size(337, 374);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(39, 174, 96);
            btnKaydet.Cursor = Cursors.Hand;
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(14, 17);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(303, 51);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "💾 KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.FromArgb(52, 152, 219);
            btnDuzenle.Cursor = Cursors.Hand;
            btnDuzenle.FlatAppearance.BorderSize = 0;
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDuzenle.ForeColor = Color.White;
            btnDuzenle.Location = new Point(14, 76);
            btnDuzenle.Margin = new Padding(3, 4, 3, 4);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(303, 51);
            btnDuzenle.TabIndex = 5;
            btnDuzenle.Text = "✏️ DÜZENLE";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 57, 43);
            btnSil.Cursor = Cursors.Hand;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(14, 135);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(303, 51);
            btnSil.TabIndex = 6;
            btnSil.Text = "❌ SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(149, 165, 166);
            btnTemizle.Cursor = Cursors.Hand;
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(14, 194);
            btnTemizle.Margin = new Padding(3, 4, 3, 4);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(303, 51);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "\U0001f9f9 TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.BackColor = Color.FromArgb(236, 240, 241);
            btnSilinenleriGoster.Cursor = Cursors.Hand;
            btnSilinenleriGoster.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnSilinenleriGoster.FlatStyle = FlatStyle.Flat;
            btnSilinenleriGoster.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSilinenleriGoster.ForeColor = Color.FromArgb(41, 128, 185);
            btnSilinenleriGoster.Location = new Point(14, 253);
            btnSilinenleriGoster.Margin = new Padding(3, 4, 3, 4);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(303, 51);
            btnSilinenleriGoster.TabIndex = 8;
            btnSilinenleriGoster.Text = "🗑️ Silinen Dilleri Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.BackColor = Color.FromArgb(52, 73, 94);
            btnGeriYukle.Cursor = Cursors.Hand;
            btnGeriYukle.FlatAppearance.BorderSize = 0;
            btnGeriYukle.FlatStyle = FlatStyle.Flat;
            btnGeriYukle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGeriYukle.ForeColor = Color.White;
            btnGeriYukle.Location = new Point(14, 312);
            btnGeriYukle.Margin = new Padding(3, 4, 3, 4);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(303, 51);
            btnGeriYukle.TabIndex = 9;
            btnGeriYukle.Text = "↩️ Seçili Dili Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = false;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox_DilKodu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_DilAdi);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox_DilId);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 29);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 156);
            panel1.TabIndex = 31;
            // 
            // textBox_DilKodu
            // 
            textBox_DilKodu.Font = new Font("Segoe UI", 10F);
            textBox_DilKodu.Location = new Point(105, 112);
            textBox_DilKodu.Margin = new Padding(3, 4, 3, 4);
            textBox_DilKodu.Name = "textBox_DilKodu";
            textBox_DilKodu.Size = new Size(217, 30);
            textBox_DilKodu.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(46, 39);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 23;
            label2.Text = "Dil Id:";
            // 
            // textBox_DilAdi
            // 
            textBox_DilAdi.Font = new Font("Segoe UI", 10F);
            textBox_DilAdi.Location = new Point(105, 73);
            textBox_DilAdi.Margin = new Padding(3, 4, 3, 4);
            textBox_DilAdi.Name = "textBox_DilAdi";
            textBox_DilAdi.Size = new Size(217, 30);
            textBox_DilAdi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(33, 77);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 22;
            label1.Text = "Dil Adı:";
            // 
            // textBox_DilId
            // 
            textBox_DilId.BackColor = Color.FromArgb(236, 240, 241);
            textBox_DilId.Enabled = false;
            textBox_DilId.Font = new Font("Segoe UI", 10F);
            textBox_DilId.Location = new Point(105, 35);
            textBox_DilId.Margin = new Padding(3, 4, 3, 4);
            textBox_DilId.Name = "textBox_DilId";
            textBox_DilId.ReadOnly = true;
            textBox_DilId.Size = new Size(217, 30);
            textBox_DilId.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(19, 115);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 30;
            label4.Text = "Dil Kodu:";
            // 
            // dataGrid_Dil
            // 
            dataGrid_Dil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGrid_Dil.AutoGenerateColumns = false;
            dataGrid_Dil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Dil.Columns.AddRange(new DataGridViewColumn[] { dilIdDataGridViewTextBoxColumn, dilAdiDataGridViewTextBoxColumn, dilKoduDataGridViewTextBoxColumn, aktifMiDataGridViewCheckBoxColumn });
            dataGrid_Dil.DataSource = dilBindingSource;
            dataGrid_Dil.Location = new Point(360, 73);
            dataGrid_Dil.Margin = new Padding(3, 4, 3, 4);
            dataGrid_Dil.Name = "dataGrid_Dil";
            dataGrid_Dil.RowHeadersWidth = 51;
            dataGrid_Dil.Size = new Size(704, 645);
            dataGrid_Dil.TabIndex = 18;
            dataGrid_Dil.CellFormatting += dataGrid_Dil_CellFormatting;
            dataGrid_Dil.ColumnHeaderMouseClick += dataGrid_Dil_ColumnHeaderMouseClick;
            dataGrid_Dil.SelectionChanged += dataGrid_Dil_SelectionChanged;
            // 
            // dilIdDataGridViewTextBoxColumn
            // 
            dilIdDataGridViewTextBoxColumn.DataPropertyName = "DilId";
            dilIdDataGridViewTextBoxColumn.HeaderText = "DilId";
            dilIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            dilIdDataGridViewTextBoxColumn.Name = "dilIdDataGridViewTextBoxColumn";
            dilIdDataGridViewTextBoxColumn.Visible = false;
            dilIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dilAdiDataGridViewTextBoxColumn
            // 
            dilAdiDataGridViewTextBoxColumn.DataPropertyName = "DilAdi";
            dilAdiDataGridViewTextBoxColumn.HeaderText = "Dil Adı";
            dilAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            dilAdiDataGridViewTextBoxColumn.Name = "dilAdiDataGridViewTextBoxColumn";
            dilAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // dilKoduDataGridViewTextBoxColumn
            // 
            dilKoduDataGridViewTextBoxColumn.DataPropertyName = "DilKodu";
            dilKoduDataGridViewTextBoxColumn.HeaderText = "Dil Kodu";
            dilKoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            dilKoduDataGridViewTextBoxColumn.Name = "dilKoduDataGridViewTextBoxColumn";
            dilKoduDataGridViewTextBoxColumn.Width = 125;
            // 
            // aktifMiDataGridViewCheckBoxColumn
            // 
            aktifMiDataGridViewCheckBoxColumn.DataPropertyName = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.HeaderText = "AktifMi";
            aktifMiDataGridViewCheckBoxColumn.MinimumWidth = 6;
            aktifMiDataGridViewCheckBoxColumn.Name = "aktifMiDataGridViewCheckBoxColumn";
            aktifMiDataGridViewCheckBoxColumn.Visible = false;
            aktifMiDataGridViewCheckBoxColumn.Width = 125;
            // 
            // frmDilIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1078, 735);
            Controls.Add(dataGrid_Dil);
            Controls.Add(groupBox1);
            Controls.Add(label_txtAra);
            Controls.Add(textBox_Ara);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(932, 771);
            Name = "frmDilIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Dil İşlemleri";
            Load += frmDilIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dilBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Dil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_txtAra;
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
        private BindingSource dilBindingSource;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGrid_Dil;
        private DataGridViewTextBoxColumn dilIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dilAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dilKoduDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
    }
}