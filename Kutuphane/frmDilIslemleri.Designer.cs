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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDilIslemleri));
            dataGrid_Dil = new DataGridView();
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
            dilIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dilAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dilKoduDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Dil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dilBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGrid_Dil
            // 
            dataGrid_Dil.AllowUserToAddRows = false;
            dataGrid_Dil.AllowUserToDeleteRows = false;
            dataGrid_Dil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Dil.AutoGenerateColumns = false;
            dataGrid_Dil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Dil.BackgroundColor = Color.White;
            dataGrid_Dil.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid_Dil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Dil.ColumnHeadersHeight = 30;
            dataGrid_Dil.Columns.AddRange(new DataGridViewColumn[] { dilIdDataGridViewTextBoxColumn, dilAdiDataGridViewTextBoxColumn, dilKoduDataGridViewTextBoxColumn });
            dataGrid_Dil.DataSource = dilBindingSource;
            dataGrid_Dil.EnableHeadersVisualStyles = false;
            dataGrid_Dil.GridColor = Color.LightGray;
            dataGrid_Dil.Location = new Point(318, 51);
            dataGrid_Dil.MultiSelect = false;
            dataGrid_Dil.Name = "dataGrid_Dil";
            dataGrid_Dil.ReadOnly = true;
            dataGrid_Dil.RowHeadersVisible = false;
            dataGrid_Dil.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGrid_Dil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Dil.Size = new Size(472, 488);
            dataGrid_Dil.TabIndex = 12;
            dataGrid_Dil.SelectionChanged += dataGrid_Dil_SelectionChanged;
            // 
            // dilBindingSource
            // 
            dilBindingSource.DataSource = typeof(Model.Entity.Dil);
            // 
            // btnAra
            // 
            btnAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAra.BackColor = Color.FromArgb(52, 152, 219);
            btnAra.FlatAppearance.BorderSize = 0;
            btnAra.FlatStyle = FlatStyle.Flat;
            btnAra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAra.ForeColor = Color.White;
            btnAra.Location = new Point(726, 12);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(64, 30);
            btnAra.TabIndex = 11;
            btnAra.Text = "🔎 ARA";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(329, 18);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 14;
            label3.Text = "Arama:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_Ara.Font = new Font("Segoe UI", 10F);
            textBox_Ara.Location = new Point(384, 15);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Dil adı veya koduyla arayın";
            textBox_Ara.Size = new Size(336, 25);
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
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
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
            textBox_DilAdi.Size = new Size(201, 25);
            textBox_DilAdi.TabIndex = 2;
            // 
            // textBox_DilId
            // 
            textBox_DilId.Enabled = false;
            textBox_DilId.Font = new Font("Segoe UI", 10F);
            textBox_DilId.Location = new Point(93, 32);
            textBox_DilId.Name = "textBox_DilId";
            textBox_DilId.ReadOnly = true;
            textBox_DilId.Size = new Size(201, 25);
            textBox_DilId.TabIndex = 1;
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.BackColor = Color.FromArgb(52, 73, 94);
            btnGeriYukle.FlatAppearance.BorderSize = 0;
            btnGeriYukle.FlatStyle = FlatStyle.Flat;
            btnGeriYukle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeriYukle.ForeColor = Color.White;
            btnGeriYukle.Location = new Point(12, 364);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(282, 30);
            btnGeriYukle.TabIndex = 9;
            btnGeriYukle.Text = "↩️ Seçili Dili Geri Yükle";
            btnGeriYukle.UseVisualStyleBackColor = false;
            btnGeriYukle.Visible = false;
            btnGeriYukle.Click += btnGeriYukle_Click;
            // 
            // btnSilinenleriGoster
            // 
            btnSilinenleriGoster.BackColor = Color.FromArgb(236, 240, 241);
            btnSilinenleriGoster.FlatAppearance.BorderColor = Color.FromArgb(52, 73, 94);
            btnSilinenleriGoster.FlatStyle = FlatStyle.Flat;
            btnSilinenleriGoster.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSilinenleriGoster.ForeColor = Color.FromArgb(52, 73, 94);
            btnSilinenleriGoster.Location = new Point(12, 328);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(282, 30);
            btnSilinenleriGoster.TabIndex = 8;
            btnSilinenleriGoster.Text = "🗑️ Silinen Dilleri Göster";
            btnSilinenleriGoster.UseVisualStyleBackColor = false;
            btnSilinenleriGoster.Click += btnSilinenleriGoster_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.Silver;
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTemizle.ForeColor = Color.Black;
            btnTemizle.Location = new Point(12, 256);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(282, 35);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "\U0001f9f9 TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 57, 43);
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(12, 215);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(282, 35);
            btnSil.TabIndex = 6;
            btnSil.Text = "❌ SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.FromArgb(52, 152, 219);
            btnDuzenle.FlatAppearance.BorderSize = 0;
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDuzenle.ForeColor = Color.White;
            btnDuzenle.Location = new Point(12, 174);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(282, 35);
            btnDuzenle.TabIndex = 5;
            btnDuzenle.Text = "✏️ DÜZENLE";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(39, 174, 96);
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(12, 133);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(282, 35);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "💾 KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(23, 93);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 17;
            label4.Text = "Dil Kodu:";
            label4.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(36, 64);
            label1.Name = "label1";
            label1.Size = new Size(55, 19);
            label1.TabIndex = 18;
            label1.Text = "Dil Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(48, 35);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 19;
            label2.Text = "Dil Id:";
            // 
            // textBox_DilKodu
            // 
            textBox_DilKodu.Font = new Font("Segoe UI", 10F);
            textBox_DilKodu.Location = new Point(93, 90);
            textBox_DilKodu.Name = "textBox_DilKodu";
            textBox_DilKodu.Size = new Size(201, 25);
            textBox_DilKodu.TabIndex = 3;
            // 
            // dilIdDataGridViewTextBoxColumn
            // 
            dilIdDataGridViewTextBoxColumn.DataPropertyName = "DilId";
            dilIdDataGridViewTextBoxColumn.HeaderText = "ID";
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
            dilKoduDataGridViewTextBoxColumn.HeaderText = "Kodu";
            dilKoduDataGridViewTextBoxColumn.Name = "dilKoduDataGridViewTextBoxColumn";
            dilKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmDilIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(802, 551);
            Controls.Add(groupBox1);
            Controls.Add(btnAra);
            Controls.Add(label3);
            Controls.Add(textBox_Ara);
            Controls.Add(dataGrid_Dil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 590);
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
        private Label label4;
        private TextBox textBox_DilKodu;
        private BindingSource dilBindingSource;
        private TextBox textBox_DilAdi;
        private TextBox textBox_DilId;
        private DataGridViewTextBoxColumn dilIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dilAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dilKoduDataGridViewTextBoxColumn;
    }
}