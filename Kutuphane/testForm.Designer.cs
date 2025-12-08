namespace Kutuphane.UI
{
    partial class testForm
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
            dataGrid_kitap = new DataGridView();
            kitapIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kitapAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ıSBNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yazarIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yayineviIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            basimYiliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sayfaSayisiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dilDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stokDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktifDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            yazarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yayineviDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kitapSiralariDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kitapBindingSource = new BindingSource(components);
            dataGrid_kitapDto = new DataGridView();
            kitapIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            kitapAdiDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ıSBNDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            yazarIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            yazarAdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yazarSoyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yayineviIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            yayineviAdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            kategoriAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            basimYiliDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            sayfaSayisiDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dilDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            stokDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            aktifDataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            kitapDtoBindingSource = new BindingSource(components);
            tablePanelGrid = new TableLayoutPanel();
            panelBtn = new Panel();
            textBox_arama = new TextBox();
            button_dto = new Button();
            button_entity = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid_kitap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kitapBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_kitapDto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kitapDtoBindingSource).BeginInit();
            tablePanelGrid.SuspendLayout();
            panelBtn.SuspendLayout();
            SuspendLayout();
            // 
            // dataGrid_kitap
            // 
            dataGrid_kitap.AllowUserToOrderColumns = true;
            dataGrid_kitap.AutoGenerateColumns = false;
            dataGrid_kitap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_kitap.Columns.AddRange(new DataGridViewColumn[] { kitapIDDataGridViewTextBoxColumn, kitapAdiDataGridViewTextBoxColumn, ıSBNDataGridViewTextBoxColumn, yazarIDDataGridViewTextBoxColumn, yayineviIDDataGridViewTextBoxColumn, kategoriIDDataGridViewTextBoxColumn, basimYiliDataGridViewTextBoxColumn, sayfaSayisiDataGridViewTextBoxColumn, dilDataGridViewTextBoxColumn, stokDataGridViewTextBoxColumn, aktifDataGridViewCheckBoxColumn, yazarDataGridViewTextBoxColumn, yayineviDataGridViewTextBoxColumn, kategoriDataGridViewTextBoxColumn, kitapSiralariDataGridViewTextBoxColumn });
            dataGrid_kitap.DataSource = kitapBindingSource;
            dataGrid_kitap.Dock = DockStyle.Fill;
            dataGrid_kitap.Location = new Point(3, 2);
            dataGrid_kitap.Margin = new Padding(3, 2, 3, 2);
            dataGrid_kitap.Name = "dataGrid_kitap";
            dataGrid_kitap.RowHeadersWidth = 51;
            dataGrid_kitap.Size = new Size(1048, 238);
            dataGrid_kitap.TabIndex = 0;
            // 
            // kitapIDDataGridViewTextBoxColumn
            // 
            kitapIDDataGridViewTextBoxColumn.DataPropertyName = "KitapID";
            kitapIDDataGridViewTextBoxColumn.HeaderText = "KitapID";
            kitapIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            kitapIDDataGridViewTextBoxColumn.Name = "kitapIDDataGridViewTextBoxColumn";
            kitapIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "KitapAdi";
            kitapAdiDataGridViewTextBoxColumn.HeaderText = "KitapAdi";
            kitapAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            kitapAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıSBNDataGridViewTextBoxColumn
            // 
            ıSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            ıSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            ıSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            ıSBNDataGridViewTextBoxColumn.Name = "ıSBNDataGridViewTextBoxColumn";
            ıSBNDataGridViewTextBoxColumn.Width = 125;
            // 
            // yazarIDDataGridViewTextBoxColumn
            // 
            yazarIDDataGridViewTextBoxColumn.DataPropertyName = "YazarID";
            yazarIDDataGridViewTextBoxColumn.HeaderText = "YazarID";
            yazarIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            yazarIDDataGridViewTextBoxColumn.Name = "yazarIDDataGridViewTextBoxColumn";
            yazarIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayineviIDDataGridViewTextBoxColumn
            // 
            yayineviIDDataGridViewTextBoxColumn.DataPropertyName = "YayineviID";
            yayineviIDDataGridViewTextBoxColumn.HeaderText = "YayineviID";
            yayineviIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            yayineviIDDataGridViewTextBoxColumn.Name = "yayineviIDDataGridViewTextBoxColumn";
            yayineviIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategoriIDDataGridViewTextBoxColumn
            // 
            kategoriIDDataGridViewTextBoxColumn.DataPropertyName = "KategoriID";
            kategoriIDDataGridViewTextBoxColumn.HeaderText = "KategoriID";
            kategoriIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            kategoriIDDataGridViewTextBoxColumn.Name = "kategoriIDDataGridViewTextBoxColumn";
            kategoriIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // basimYiliDataGridViewTextBoxColumn
            // 
            basimYiliDataGridViewTextBoxColumn.DataPropertyName = "BasimYili";
            basimYiliDataGridViewTextBoxColumn.HeaderText = "BasimYili";
            basimYiliDataGridViewTextBoxColumn.MinimumWidth = 6;
            basimYiliDataGridViewTextBoxColumn.Name = "basimYiliDataGridViewTextBoxColumn";
            basimYiliDataGridViewTextBoxColumn.Width = 125;
            // 
            // sayfaSayisiDataGridViewTextBoxColumn
            // 
            sayfaSayisiDataGridViewTextBoxColumn.DataPropertyName = "SayfaSayisi";
            sayfaSayisiDataGridViewTextBoxColumn.HeaderText = "SayfaSayisi";
            sayfaSayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            sayfaSayisiDataGridViewTextBoxColumn.Name = "sayfaSayisiDataGridViewTextBoxColumn";
            sayfaSayisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // dilDataGridViewTextBoxColumn
            // 
            dilDataGridViewTextBoxColumn.DataPropertyName = "Dil";
            dilDataGridViewTextBoxColumn.HeaderText = "Dil";
            dilDataGridViewTextBoxColumn.MinimumWidth = 6;
            dilDataGridViewTextBoxColumn.Name = "dilDataGridViewTextBoxColumn";
            dilDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            stokDataGridViewTextBoxColumn.MinimumWidth = 6;
            stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            stokDataGridViewTextBoxColumn.Width = 125;
            // 
            // aktifDataGridViewCheckBoxColumn
            // 
            aktifDataGridViewCheckBoxColumn.DataPropertyName = "Aktif";
            aktifDataGridViewCheckBoxColumn.HeaderText = "Aktif";
            aktifDataGridViewCheckBoxColumn.MinimumWidth = 6;
            aktifDataGridViewCheckBoxColumn.Name = "aktifDataGridViewCheckBoxColumn";
            aktifDataGridViewCheckBoxColumn.Width = 125;
            // 
            // yazarDataGridViewTextBoxColumn
            // 
            yazarDataGridViewTextBoxColumn.DataPropertyName = "Yazar";
            yazarDataGridViewTextBoxColumn.HeaderText = "Yazar";
            yazarDataGridViewTextBoxColumn.MinimumWidth = 6;
            yazarDataGridViewTextBoxColumn.Name = "yazarDataGridViewTextBoxColumn";
            yazarDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayineviDataGridViewTextBoxColumn
            // 
            yayineviDataGridViewTextBoxColumn.DataPropertyName = "Yayinevi";
            yayineviDataGridViewTextBoxColumn.HeaderText = "Yayinevi";
            yayineviDataGridViewTextBoxColumn.MinimumWidth = 6;
            yayineviDataGridViewTextBoxColumn.Name = "yayineviDataGridViewTextBoxColumn";
            yayineviDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            kategoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            kategoriDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapSiralariDataGridViewTextBoxColumn
            // 
            kitapSiralariDataGridViewTextBoxColumn.DataPropertyName = "KitapSiralari";
            kitapSiralariDataGridViewTextBoxColumn.HeaderText = "KitapSiralari";
            kitapSiralariDataGridViewTextBoxColumn.MinimumWidth = 6;
            kitapSiralariDataGridViewTextBoxColumn.Name = "kitapSiralariDataGridViewTextBoxColumn";
            kitapSiralariDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapBindingSource
            // 
            kitapBindingSource.DataSource = typeof(Model.Entity.Kitap);
            // 
            // dataGrid_kitapDto
            // 
            dataGrid_kitapDto.AutoGenerateColumns = false;
            dataGrid_kitapDto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_kitapDto.Columns.AddRange(new DataGridViewColumn[] { kitapIDDataGridViewTextBoxColumn1, kitapAdiDataGridViewTextBoxColumn1, ıSBNDataGridViewTextBoxColumn1, yazarIDDataGridViewTextBoxColumn1, yazarAdDataGridViewTextBoxColumn, yazarSoyadDataGridViewTextBoxColumn, yayineviIDDataGridViewTextBoxColumn1, yayineviAdDataGridViewTextBoxColumn, kategoriIDDataGridViewTextBoxColumn1, kategoriAdiDataGridViewTextBoxColumn, basimYiliDataGridViewTextBoxColumn1, sayfaSayisiDataGridViewTextBoxColumn1, dilDataGridViewTextBoxColumn1, stokDataGridViewTextBoxColumn1, aktifDataGridViewCheckBoxColumn1 });
            dataGrid_kitapDto.DataSource = kitapDtoBindingSource;
            dataGrid_kitapDto.Dock = DockStyle.Fill;
            dataGrid_kitapDto.Location = new Point(3, 244);
            dataGrid_kitapDto.Margin = new Padding(3, 2, 3, 2);
            dataGrid_kitapDto.Name = "dataGrid_kitapDto";
            dataGrid_kitapDto.RowHeadersWidth = 51;
            dataGrid_kitapDto.Size = new Size(1048, 239);
            dataGrid_kitapDto.TabIndex = 1;
            // 
            // kitapIDDataGridViewTextBoxColumn1
            // 
            kitapIDDataGridViewTextBoxColumn1.DataPropertyName = "KitapID";
            kitapIDDataGridViewTextBoxColumn1.HeaderText = "KitapID";
            kitapIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            kitapIDDataGridViewTextBoxColumn1.Name = "kitapIDDataGridViewTextBoxColumn1";
            kitapIDDataGridViewTextBoxColumn1.Visible = false;
            kitapIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // kitapAdiDataGridViewTextBoxColumn1
            // 
            kitapAdiDataGridViewTextBoxColumn1.DataPropertyName = "KitapAdi";
            kitapAdiDataGridViewTextBoxColumn1.HeaderText = "KitapAdi";
            kitapAdiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            kitapAdiDataGridViewTextBoxColumn1.Name = "kitapAdiDataGridViewTextBoxColumn1";
            kitapAdiDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ıSBNDataGridViewTextBoxColumn1
            // 
            ıSBNDataGridViewTextBoxColumn1.DataPropertyName = "ISBN";
            ıSBNDataGridViewTextBoxColumn1.HeaderText = "ISBN";
            ıSBNDataGridViewTextBoxColumn1.MinimumWidth = 6;
            ıSBNDataGridViewTextBoxColumn1.Name = "ıSBNDataGridViewTextBoxColumn1";
            ıSBNDataGridViewTextBoxColumn1.Width = 125;
            // 
            // yazarIDDataGridViewTextBoxColumn1
            // 
            yazarIDDataGridViewTextBoxColumn1.DataPropertyName = "YazarID";
            yazarIDDataGridViewTextBoxColumn1.HeaderText = "YazarID";
            yazarIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            yazarIDDataGridViewTextBoxColumn1.Name = "yazarIDDataGridViewTextBoxColumn1";
            yazarIDDataGridViewTextBoxColumn1.Visible = false;
            yazarIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // yazarAdDataGridViewTextBoxColumn
            // 
            yazarAdDataGridViewTextBoxColumn.DataPropertyName = "YazarAd";
            yazarAdDataGridViewTextBoxColumn.HeaderText = "YazarAd";
            yazarAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            yazarAdDataGridViewTextBoxColumn.Name = "yazarAdDataGridViewTextBoxColumn";
            yazarAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // yazarSoyadDataGridViewTextBoxColumn
            // 
            yazarSoyadDataGridViewTextBoxColumn.DataPropertyName = "YazarSoyad";
            yazarSoyadDataGridViewTextBoxColumn.HeaderText = "YazarSoyad";
            yazarSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            yazarSoyadDataGridViewTextBoxColumn.Name = "yazarSoyadDataGridViewTextBoxColumn";
            yazarSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayineviIDDataGridViewTextBoxColumn1
            // 
            yayineviIDDataGridViewTextBoxColumn1.DataPropertyName = "YayineviID";
            yayineviIDDataGridViewTextBoxColumn1.HeaderText = "YayineviID";
            yayineviIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            yayineviIDDataGridViewTextBoxColumn1.Name = "yayineviIDDataGridViewTextBoxColumn1";
            yayineviIDDataGridViewTextBoxColumn1.Visible = false;
            yayineviIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // yayineviAdDataGridViewTextBoxColumn
            // 
            yayineviAdDataGridViewTextBoxColumn.DataPropertyName = "YayineviAd";
            yayineviAdDataGridViewTextBoxColumn.HeaderText = "YayineviAd";
            yayineviAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            yayineviAdDataGridViewTextBoxColumn.Name = "yayineviAdDataGridViewTextBoxColumn";
            yayineviAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategoriIDDataGridViewTextBoxColumn1
            // 
            kategoriIDDataGridViewTextBoxColumn1.DataPropertyName = "KategoriID";
            kategoriIDDataGridViewTextBoxColumn1.HeaderText = "KategoriID";
            kategoriIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            kategoriIDDataGridViewTextBoxColumn1.Name = "kategoriIDDataGridViewTextBoxColumn1";
            kategoriIDDataGridViewTextBoxColumn1.Visible = false;
            kategoriIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // kategoriAdiDataGridViewTextBoxColumn
            // 
            kategoriAdiDataGridViewTextBoxColumn.DataPropertyName = "KategoriAdi";
            kategoriAdiDataGridViewTextBoxColumn.HeaderText = "KategoriAdi";
            kategoriAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            kategoriAdiDataGridViewTextBoxColumn.Name = "kategoriAdiDataGridViewTextBoxColumn";
            kategoriAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // basimYiliDataGridViewTextBoxColumn1
            // 
            basimYiliDataGridViewTextBoxColumn1.DataPropertyName = "BasimYili";
            basimYiliDataGridViewTextBoxColumn1.HeaderText = "BasimYili";
            basimYiliDataGridViewTextBoxColumn1.MinimumWidth = 6;
            basimYiliDataGridViewTextBoxColumn1.Name = "basimYiliDataGridViewTextBoxColumn1";
            basimYiliDataGridViewTextBoxColumn1.Width = 125;
            // 
            // sayfaSayisiDataGridViewTextBoxColumn1
            // 
            sayfaSayisiDataGridViewTextBoxColumn1.DataPropertyName = "SayfaSayisi";
            sayfaSayisiDataGridViewTextBoxColumn1.HeaderText = "SayfaSayisi";
            sayfaSayisiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            sayfaSayisiDataGridViewTextBoxColumn1.Name = "sayfaSayisiDataGridViewTextBoxColumn1";
            sayfaSayisiDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dilDataGridViewTextBoxColumn1
            // 
            dilDataGridViewTextBoxColumn1.DataPropertyName = "Dil";
            dilDataGridViewTextBoxColumn1.HeaderText = "Dil";
            dilDataGridViewTextBoxColumn1.MinimumWidth = 6;
            dilDataGridViewTextBoxColumn1.Name = "dilDataGridViewTextBoxColumn1";
            dilDataGridViewTextBoxColumn1.Width = 125;
            // 
            // stokDataGridViewTextBoxColumn1
            // 
            stokDataGridViewTextBoxColumn1.DataPropertyName = "Stok";
            stokDataGridViewTextBoxColumn1.HeaderText = "Stok";
            stokDataGridViewTextBoxColumn1.MinimumWidth = 6;
            stokDataGridViewTextBoxColumn1.Name = "stokDataGridViewTextBoxColumn1";
            stokDataGridViewTextBoxColumn1.Width = 125;
            // 
            // aktifDataGridViewCheckBoxColumn1
            // 
            aktifDataGridViewCheckBoxColumn1.DataPropertyName = "Aktif";
            aktifDataGridViewCheckBoxColumn1.HeaderText = "Aktif";
            aktifDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            aktifDataGridViewCheckBoxColumn1.Name = "aktifDataGridViewCheckBoxColumn1";
            aktifDataGridViewCheckBoxColumn1.Visible = false;
            aktifDataGridViewCheckBoxColumn1.Width = 125;
            // 
            // kitapDtoBindingSource
            // 
            kitapDtoBindingSource.DataSource = typeof(Model.DTO.KitapDto);
            // 
            // tablePanelGrid
            // 
            tablePanelGrid.ColumnCount = 1;
            tablePanelGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.4F));
            tablePanelGrid.Controls.Add(dataGrid_kitap, 0, 0);
            tablePanelGrid.Controls.Add(dataGrid_kitapDto, 0, 1);
            tablePanelGrid.Dock = DockStyle.Fill;
            tablePanelGrid.Location = new Point(0, 0);
            tablePanelGrid.Margin = new Padding(3, 2, 3, 2);
            tablePanelGrid.Name = "tablePanelGrid";
            tablePanelGrid.RowCount = 2;
            tablePanelGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablePanelGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablePanelGrid.Size = new Size(1054, 485);
            tablePanelGrid.TabIndex = 2;
            // 
            // panelBtn
            // 
            panelBtn.Controls.Add(textBox_arama);
            panelBtn.Controls.Add(button_dto);
            panelBtn.Controls.Add(button_entity);
            panelBtn.Dock = DockStyle.Bottom;
            panelBtn.Location = new Point(0, 485);
            panelBtn.Margin = new Padding(3, 2, 3, 2);
            panelBtn.Name = "panelBtn";
            panelBtn.Size = new Size(1054, 82);
            panelBtn.TabIndex = 3;
            // 
            // textBox_arama
            // 
            textBox_arama.Location = new Point(362, 27);
            textBox_arama.Margin = new Padding(3, 2, 3, 2);
            textBox_arama.Name = "textBox_arama";
            textBox_arama.PlaceholderText = "arama için ad gir";
            textBox_arama.Size = new Size(409, 23);
            textBox_arama.TabIndex = 1;
            // 
            // button_dto
            // 
            button_dto.Location = new Point(264, 28);
            button_dto.Margin = new Padding(3, 2, 3, 2);
            button_dto.Name = "button_dto";
            button_dto.Size = new Size(82, 22);
            button_dto.TabIndex = 0;
            button_dto.Text = "dto getir";
            button_dto.UseVisualStyleBackColor = true;
            button_dto.Click += button_dto_Click;
            // 
            // button_entity
            // 
            button_entity.Location = new Point(81, 28);
            button_entity.Margin = new Padding(3, 2, 3, 2);
            button_entity.Name = "button_entity";
            button_entity.Size = new Size(82, 22);
            button_entity.TabIndex = 0;
            button_entity.Text = "entity getir";
            button_entity.UseVisualStyleBackColor = true;
            button_entity.Click += button_entity_Click;
            // 
            // testForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 567);
            Controls.Add(tablePanelGrid);
            Controls.Add(panelBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "testForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "testForm";
            Load += testForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_kitap).EndInit();
            ((System.ComponentModel.ISupportInitialize)kitapBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_kitapDto).EndInit();
            ((System.ComponentModel.ISupportInitialize)kitapDtoBindingSource).EndInit();
            tablePanelGrid.ResumeLayout(false);
            panelBtn.ResumeLayout(false);
            panelBtn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGrid_kitap;
        private DataGridView dataGrid_kitapDto;
        private DataGridViewTextBoxColumn kitapIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ıSBNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yayineviIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn basimYiliDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sayfaSayisiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dilDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yayineviDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapSiralariDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn odunclerDataGridViewTextBoxColumn;
        private BindingSource kitapBindingSource;
        private BindingSource kitapDtoBindingSource;
        private TableLayoutPanel tablePanelGrid;
        private Panel panelBtn;
        private Button button_dto;
        private Button button_entity;
        private TextBox textBox_arama;
        private DataGridViewTextBoxColumn kitapIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ıSBNDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn yazarIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn yazarAdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarSoyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yayineviIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn yayineviAdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn kategoriAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn basimYiliDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sayfaSayisiDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dilDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn1;
    }
}