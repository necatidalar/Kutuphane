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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapIslemleri));
            btnAra = new Button();
            label1 = new Label();
            textBox_Ara = new TextBox();
            dataGrid_Kitap = new DataGridView();
            kitapIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kitapAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ıSBNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yazarIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yazarAdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yazarSoyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yayineviIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yayineviAdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            basimYiliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sayfaSayisiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dilDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stokDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            kitapDtoBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Kitap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kitapDtoBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAra
            // 
            btnAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAra.Location = new Point(1297, 16);
            btnAra.Margin = new Padding(3, 4, 3, 4);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(86, 31);
            btnAra.TabIndex = 8;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1023, 21);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 7;
            label1.Text = "Ara:";
            // 
            // textBox_Ara
            // 
            textBox_Ara.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_Ara.Location = new Point(1061, 16);
            textBox_Ara.Margin = new Padding(3, 4, 3, 4);
            textBox_Ara.Name = "textBox_Ara";
            textBox_Ara.PlaceholderText = "Arama için Kitap adı gir";
            textBox_Ara.Size = new Size(228, 27);
            textBox_Ara.TabIndex = 6;
            // 
            // dataGrid_Kitap
            // 
            dataGrid_Kitap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Kitap.AutoGenerateColumns = false;
            dataGrid_Kitap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Kitap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Kitap.Columns.AddRange(new DataGridViewColumn[] { kitapIDDataGridViewTextBoxColumn, kitapAdiDataGridViewTextBoxColumn, ıSBNDataGridViewTextBoxColumn, yazarIDDataGridViewTextBoxColumn, yazarAdDataGridViewTextBoxColumn, yazarSoyadDataGridViewTextBoxColumn, yayineviIDDataGridViewTextBoxColumn, yayineviAdDataGridViewTextBoxColumn, kategoriIDDataGridViewTextBoxColumn, kategoriAdiDataGridViewTextBoxColumn, basimYiliDataGridViewTextBoxColumn, sayfaSayisiDataGridViewTextBoxColumn, dilDataGridViewTextBoxColumn, stokDataGridViewTextBoxColumn, aktifDataGridViewCheckBoxColumn });
            dataGrid_Kitap.DataSource = kitapDtoBindingSource;
            dataGrid_Kitap.Location = new Point(390, 55);
            dataGrid_Kitap.Margin = new Padding(3, 4, 3, 4);
            dataGrid_Kitap.Name = "dataGrid_Kitap";
            dataGrid_Kitap.RowHeadersWidth = 51;
            dataGrid_Kitap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_Kitap.Size = new Size(994, 771);
            dataGrid_Kitap.TabIndex = 5;
            // 
            // kitapIDDataGridViewTextBoxColumn
            // 
            kitapIDDataGridViewTextBoxColumn.DataPropertyName = "KitapID";
            kitapIDDataGridViewTextBoxColumn.HeaderText = "KitapID";
            kitapIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            kitapIDDataGridViewTextBoxColumn.Name = "kitapIDDataGridViewTextBoxColumn";
            kitapIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "KitapAdi";
            kitapAdiDataGridViewTextBoxColumn.HeaderText = "Kitap Adı";
            kitapAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            // 
            // ıSBNDataGridViewTextBoxColumn
            // 
            ıSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            ıSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            ıSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            ıSBNDataGridViewTextBoxColumn.Name = "ıSBNDataGridViewTextBoxColumn";
            // 
            // yazarIDDataGridViewTextBoxColumn
            // 
            yazarIDDataGridViewTextBoxColumn.DataPropertyName = "YazarID";
            yazarIDDataGridViewTextBoxColumn.HeaderText = "YazarID";
            yazarIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            yazarIDDataGridViewTextBoxColumn.Name = "yazarIDDataGridViewTextBoxColumn";
            yazarIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // yazarAdDataGridViewTextBoxColumn
            // 
            yazarAdDataGridViewTextBoxColumn.DataPropertyName = "YazarAd";
            yazarAdDataGridViewTextBoxColumn.HeaderText = "Yazar Adı";
            yazarAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            yazarAdDataGridViewTextBoxColumn.Name = "yazarAdDataGridViewTextBoxColumn";
            // 
            // yazarSoyadDataGridViewTextBoxColumn
            // 
            yazarSoyadDataGridViewTextBoxColumn.DataPropertyName = "YazarSoyad";
            yazarSoyadDataGridViewTextBoxColumn.HeaderText = "Yazar Soyadı";
            yazarSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            yazarSoyadDataGridViewTextBoxColumn.Name = "yazarSoyadDataGridViewTextBoxColumn";
            // 
            // yayineviIDDataGridViewTextBoxColumn
            // 
            yayineviIDDataGridViewTextBoxColumn.DataPropertyName = "YayineviID";
            yayineviIDDataGridViewTextBoxColumn.HeaderText = "YayineviID";
            yayineviIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            yayineviIDDataGridViewTextBoxColumn.Name = "yayineviIDDataGridViewTextBoxColumn";
            yayineviIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // yayineviAdDataGridViewTextBoxColumn
            // 
            yayineviAdDataGridViewTextBoxColumn.DataPropertyName = "YayineviAd";
            yayineviAdDataGridViewTextBoxColumn.HeaderText = "Yayınevi Adı";
            yayineviAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            yayineviAdDataGridViewTextBoxColumn.Name = "yayineviAdDataGridViewTextBoxColumn";
            // 
            // kategoriIDDataGridViewTextBoxColumn
            // 
            kategoriIDDataGridViewTextBoxColumn.DataPropertyName = "KategoriID";
            kategoriIDDataGridViewTextBoxColumn.HeaderText = "KategoriID";
            kategoriIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            kategoriIDDataGridViewTextBoxColumn.Name = "kategoriIDDataGridViewTextBoxColumn";
            kategoriIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // kategoriAdiDataGridViewTextBoxColumn
            // 
            kategoriAdiDataGridViewTextBoxColumn.DataPropertyName = "KategoriAdi";
            kategoriAdiDataGridViewTextBoxColumn.HeaderText = "Kategori Adı";
            kategoriAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            kategoriAdiDataGridViewTextBoxColumn.Name = "kategoriAdiDataGridViewTextBoxColumn";
            // 
            // basimYiliDataGridViewTextBoxColumn
            // 
            basimYiliDataGridViewTextBoxColumn.DataPropertyName = "BasimYili";
            basimYiliDataGridViewTextBoxColumn.HeaderText = "Basım Yılı";
            basimYiliDataGridViewTextBoxColumn.MinimumWidth = 6;
            basimYiliDataGridViewTextBoxColumn.Name = "basimYiliDataGridViewTextBoxColumn";
            // 
            // sayfaSayisiDataGridViewTextBoxColumn
            // 
            sayfaSayisiDataGridViewTextBoxColumn.DataPropertyName = "SayfaSayisi";
            sayfaSayisiDataGridViewTextBoxColumn.HeaderText = "Sayfa Sayısı";
            sayfaSayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            sayfaSayisiDataGridViewTextBoxColumn.Name = "sayfaSayisiDataGridViewTextBoxColumn";
            // 
            // dilDataGridViewTextBoxColumn
            // 
            dilDataGridViewTextBoxColumn.DataPropertyName = "Dil";
            dilDataGridViewTextBoxColumn.HeaderText = "Dil";
            dilDataGridViewTextBoxColumn.MinimumWidth = 6;
            dilDataGridViewTextBoxColumn.Name = "dilDataGridViewTextBoxColumn";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            stokDataGridViewTextBoxColumn.MinimumWidth = 6;
            stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // aktifDataGridViewCheckBoxColumn
            // 
            aktifDataGridViewCheckBoxColumn.DataPropertyName = "Aktif";
            aktifDataGridViewCheckBoxColumn.HeaderText = "Aktif";
            aktifDataGridViewCheckBoxColumn.MinimumWidth = 6;
            aktifDataGridViewCheckBoxColumn.Name = "aktifDataGridViewCheckBoxColumn";
            aktifDataGridViewCheckBoxColumn.Visible = false;
            // 
            // kitapDtoBindingSource
            // 
            kitapDtoBindingSource.DataSource = typeof(Model.DTO.KitapDto);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(15, 55);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(369, 771);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap İşlemleri";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(121, 220);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(215, 28);
            comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(121, 184);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(215, 28);
            comboBox1.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(121, 143);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(215, 27);
            textBox4.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(121, 108);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 27);
            textBox3.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(121, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 27);
            textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 27);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 37);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 74);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 108);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 143);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 187);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 7;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 220);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 8;
            label7.Text = "label7";
            // 
            // frmKitapIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 841);
            Controls.Add(groupBox1);
            Controls.Add(btnAra);
            Controls.Add(label1);
            Controls.Add(textBox_Ara);
            Controls.Add(dataGrid_Kitap);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmKitapIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Kitap İşlemleri";
            Load += frmKitapIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_Kitap).EndInit();
            ((System.ComponentModel.ISupportInitialize)kitapDtoBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAra;
        private Label label1;
        private TextBox textBox_Ara;
        private DataGridView dataGrid_Kitap;
        private GroupBox groupBox1;
        private BindingSource kitapDtoBindingSource;
        private DataGridViewTextBoxColumn kitapIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ıSBNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarAdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarSoyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yayineviIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yayineviAdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn basimYiliDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sayfaSayisiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dilDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
    }
}