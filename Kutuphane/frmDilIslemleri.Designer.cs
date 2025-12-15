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
            dataGrid_Dil.AllowUserToAddRows = false;
            dataGrid_Dil.AllowUserToDeleteRows = false;
            dataGrid_Dil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
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
            dataGrid_Dil.Location = new Point(363, 68);
            dataGrid_Dil.Margin = new Padding(3, 4, 3, 4);
            dataGrid_Dil.MultiSelect = false;
            dataGrid_Dil.Name = "dataGrid_Dil";
            dataGrid_Dil.ReadOnly = true;
            dataGrid_Dil.RowHeadersVisible = false;
            dataGrid_Dil.RowHeadersWidth = 51;
            dataGrid_Dil.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGrid_Dil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Dil.Size = new Size(539, 651);
            dataGrid_Dil.TabIndex = 12;
            dataGrid_Dil.SelectionChanged += dataGrid_Dil_SelectionChanged;
            // 
            // dilIdDataGridViewTextBoxColumn
            // 
            dilIdDataGridViewTextBoxColumn.DataPropertyName = "DilId";
            dilIdDataGridViewTextBoxColumn.HeaderText = "ID";
            dilIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            dilIdDataGridViewTextBoxColumn.Name = "dilIdDataGridViewTextBoxColumn";
            dilIdDataGridViewTextBoxColumn.ReadOnly = true;
            dilIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dilAdiDataGridViewTextBoxColumn
            // 
            dilAdiDataGridViewTextBoxColumn.DataPropertyName = "DilAdi";
            dilAdiDataGridViewTextBoxColumn.HeaderText = "Dil Adı";
            dilAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            dilAdiDataGridViewTextBoxColumn.Name = "dilAdiDataGridViewTextBoxColumn";
            dilAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dilKoduDataGridViewTextBoxColumn
            // 
            dilKoduDataGridViewTextBoxColumn.DataPropertyName = "DilKodu";
            dilKoduDataGridViewTextBoxColumn.HeaderText = "Kodu";
            dilKoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            dilKoduDataGridViewTextBoxColumn.Name = "dilKoduDataGridViewTextBoxColumn";
            dilKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dilBindingSource
            // 
            dilBindingSource.DataSource = typeof(Model.Entity.Dil);
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.FromArgb(52, 152, 219);
            btnAra.FlatAppearance.BorderSize = 0;
            btnAra.FlatStyle = FlatStyle.Flat;
            btnAra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAra.ForeColor = Color.White;
            btnAra.Location = new Point(830, 16);
            btnAra.Margin = new Padding(3, 4, 3, 4);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(73, 40);
            btnAra.TabIndex = 11;
            btnAra.Text = "🔎 ARA";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(376, 24);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 14;
            label3.Text = "Arama:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Font = new Font("Segoe UI", 10F);
            textBox_Ara.Location = new Point(446, 20);
            textBox_Ara.Margin = new Padding(3, 4, 3, 4);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Dil adı veya koduyla arayın";
            textBox_Ara.Size = new Size(376, 30);
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
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(343, 703);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "🌎 Dil Kayıt İşlemleri";
            // 
            // textBox_DilAdi
            // 
            textBox_DilAdi.Font = new Font("Segoe UI", 10F);
            textBox_DilAdi.Location = new Point(106, 81);
            textBox_DilAdi.Margin = new Padding(3, 4, 3, 4);
            textBox_DilAdi.Name = "textBox_DilAdi";
            textBox_DilAdi.Size = new Size(229, 30);
            textBox_DilAdi.TabIndex = 2;
            // 
            // textBox_DilId
            // 
            textBox_DilId.Enabled = false;
            textBox_DilId.Font = new Font("Segoe UI", 10F);
            textBox_DilId.Location = new Point(106, 43);
            textBox_DilId.Margin = new Padding(3, 4, 3, 4);
            textBox_DilId.Name = "textBox_DilId";
            textBox_DilId.ReadOnly = true;
            textBox_DilId.Size = new Size(229, 30);
            textBox_DilId.TabIndex = 1;
            // 
            // btnGeriYukle
            // 
            btnGeriYukle.BackColor = Color.FromArgb(52, 73, 94);
            btnGeriYukle.FlatAppearance.BorderSize = 0;
            btnGeriYukle.FlatStyle = FlatStyle.Flat;
            btnGeriYukle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeriYukle.ForeColor = Color.White;
            btnGeriYukle.Location = new Point(14, 485);
            btnGeriYukle.Margin = new Padding(3, 4, 3, 4);
            btnGeriYukle.Name = "btnGeriYukle";
            btnGeriYukle.Size = new Size(322, 40);
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
            btnSilinenleriGoster.Location = new Point(14, 437);
            btnSilinenleriGoster.Margin = new Padding(3, 4, 3, 4);
            btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            btnSilinenleriGoster.Size = new Size(322, 40);
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
            btnTemizle.Location = new Point(14, 341);
            btnTemizle.Margin = new Padding(3, 4, 3, 4);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(322, 47);
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
            btnSil.Location = new Point(14, 287);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(322, 47);
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
            btnDuzenle.Location = new Point(14, 232);
            btnDuzenle.Margin = new Padding(3, 4, 3, 4);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(322, 47);
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
            btnKaydet.Location = new Point(14, 177);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(322, 47);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "💾 KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(21, 123);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 17;
            label4.Text = "Dil Kodu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(41, 85);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 18;
            label1.Text = "Dil Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(55, 47);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 19;
            label2.Text = "Dil Id:";
            // 
            // textBox_DilKodu
            // 
            textBox_DilKodu.Font = new Font("Segoe UI", 10F);
            textBox_DilKodu.Location = new Point(106, 120);
            textBox_DilKodu.Margin = new Padding(3, 4, 3, 4);
            textBox_DilKodu.Name = "textBox_DilKodu";
            textBox_DilKodu.Size = new Size(229, 30);
            textBox_DilKodu.TabIndex = 3;
            // 
            // frmDilIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(917, 735);
            Controls.Add(groupBox1);
            Controls.Add(btnAra);
            Controls.Add(label3);
            Controls.Add(textBox_Ara);
            Controls.Add(dataGrid_Dil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(912, 771);
            Name = "frmDilIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
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