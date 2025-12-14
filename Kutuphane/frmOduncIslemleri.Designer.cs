namespace Kutuphane.UI
{
    partial class frmOduncIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOduncIslemleri));
            textBox_UyeAra = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label_AdSoyad = new Label();
            button_UyeAra = new Button();
            btn_UyeListele = new Button();
            groupBox2 = new GroupBox();
            button_OduncVer = new Button();
            button_KitapAra = new Button();
            label4 = new Label();
            listView_Sepet = new ListView();
            listView_KitapListesi = new ListView();
            label3 = new Label();
            label2 = new Label();
            textBox_KitapAra = new TextBox();
            groupBox3 = new GroupBox();
            button_IadeAl = new Button();
            listView_UyeninAldigiKitapListesi = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_UyeAra
            // 
            textBox_UyeAra.Font = new Font("Segoe UI", 10F);
            textBox_UyeAra.Location = new Point(78, 34);
            textBox_UyeAra.Name = "textBox_UyeAra";
            textBox_UyeAra.PlaceholderText = "TC Kimlik No / Pasaport No / Ad Soyad ile arayın";
            textBox_UyeAra.Size = new Size(318, 25);
            textBox_UyeAra.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(14, 37);
            label1.Name = "label1";
            label1.Size = new Size(61, 19);
            label1.TabIndex = 1;
            label1.Text = "Üye Ara:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_AdSoyad);
            groupBox1.Controls.Add(button_UyeAra);
            groupBox1.Controls.Add(btn_UyeListele);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_UyeAra);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(504, 179);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "👤 Üye İşlemleri";
            // 
            // label_AdSoyad
            // 
            label_AdSoyad.AutoSize = true;
            label_AdSoyad.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_AdSoyad.ForeColor = Color.FromArgb(41, 128, 185);
            label_AdSoyad.Location = new Point(78, 67);
            label_AdSoyad.Name = "label_AdSoyad";
            label_AdSoyad.Size = new Size(111, 19);
            label_AdSoyad.TabIndex = 11;
            label_AdSoyad.Text = "Seçili Üye: YOK";
            // 
            // button_UyeAra
            // 
            button_UyeAra.BackColor = Color.FromArgb(52, 152, 219);
            button_UyeAra.FlatAppearance.BorderSize = 0;
            button_UyeAra.FlatStyle = FlatStyle.Flat;
            button_UyeAra.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_UyeAra.ForeColor = Color.White;
            button_UyeAra.Location = new Point(402, 34);
            button_UyeAra.Name = "button_UyeAra";
            button_UyeAra.Size = new Size(45, 25);
            button_UyeAra.TabIndex = 10;
            button_UyeAra.Text = "ARA";
            button_UyeAra.UseVisualStyleBackColor = false;
            button_UyeAra.Click += button_UyeAra_Click;
            // 
            // btn_UyeListele
            // 
            btn_UyeListele.BackColor = Color.FromArgb(52, 73, 94);
            btn_UyeListele.FlatAppearance.BorderSize = 0;
            btn_UyeListele.FlatStyle = FlatStyle.Flat;
            btn_UyeListele.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_UyeListele.ForeColor = Color.White;
            btn_UyeListele.Location = new Point(78, 100);
            btn_UyeListele.Name = "btn_UyeListele";
            btn_UyeListele.Size = new Size(369, 35);
            btn_UyeListele.TabIndex = 9;
            btn_UyeListele.Text = "Üyenin Ödünç Aldıği Kitapları Listele";
            btn_UyeListele.UseVisualStyleBackColor = false;
            btn_UyeListele.Click += btn_UyeListele_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_OduncVer);
            groupBox2.Controls.Add(button_KitapAra);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(listView_Sepet);
            groupBox2.Controls.Add(listView_KitapListesi);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox_KitapAra);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(12, 197);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(504, 533);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "➡️ Ödünç Ver / Sepet";
            // 
            // button_OduncVer
            // 
            button_OduncVer.BackColor = Color.FromArgb(39, 174, 96);
            button_OduncVer.FlatAppearance.BorderSize = 0;
            button_OduncVer.FlatStyle = FlatStyle.Flat;
            button_OduncVer.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_OduncVer.ForeColor = Color.White;
            button_OduncVer.Location = new Point(123, 478);
            button_OduncVer.Name = "button_OduncVer";
            button_OduncVer.Size = new Size(331, 35);
            button_OduncVer.TabIndex = 10;
            button_OduncVer.Text = "✅ ÖDÜNÇ VER";
            button_OduncVer.UseVisualStyleBackColor = false;
            button_OduncVer.Click += button_OduncVer_Click;
            // 
            // button_KitapAra
            // 
            button_KitapAra.BackColor = Color.FromArgb(52, 152, 219);
            button_KitapAra.FlatAppearance.BorderSize = 0;
            button_KitapAra.FlatStyle = FlatStyle.Flat;
            button_KitapAra.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_KitapAra.ForeColor = Color.White;
            button_KitapAra.Location = new Point(453, 43);
            button_KitapAra.Name = "button_KitapAra";
            button_KitapAra.Size = new Size(45, 25);
            button_KitapAra.TabIndex = 12;
            button_KitapAra.Text = "ARA";
            button_KitapAra.UseVisualStyleBackColor = false;
            button_KitapAra.Click += button_KitapAra_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(28, 294);
            label4.Name = "label4";
            label4.Size = new Size(47, 19);
            label4.TabIndex = 7;
            label4.Text = "Sepet:";
            // 
            // listView_Sepet
            // 
            listView_Sepet.BorderStyle = BorderStyle.FixedSingle;
            listView_Sepet.FullRowSelect = true;
            listView_Sepet.Location = new Point(78, 294);
            listView_Sepet.Name = "listView_Sepet";
            listView_Sepet.Size = new Size(420, 178);
            listView_Sepet.TabIndex = 6;
            listView_Sepet.UseCompatibleStateImageBehavior = false;
            listView_Sepet.View = View.Details;
            // 
            // listView_KitapListesi
            // 
            listView_KitapListesi.BorderStyle = BorderStyle.FixedSingle;
            listView_KitapListesi.FullRowSelect = true;
            listView_KitapListesi.Location = new Point(78, 74);
            listView_KitapListesi.Name = "listView_KitapListesi";
            listView_KitapListesi.Size = new Size(420, 214);
            listView_KitapListesi.TabIndex = 5;
            listView_KitapListesi.UseCompatibleStateImageBehavior = false;
            listView_KitapListesi.View = View.Details;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(7, 74);
            label3.Name = "label3";
            label3.Size = new Size(62, 19);
            label3.TabIndex = 3;
            label3.Text = "Kitaplar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(5, 46);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 3;
            label2.Text = "Kitap Ara:";
            // 
            // textBox_KitapAra
            // 
            textBox_KitapAra.Font = new Font("Segoe UI", 10F);
            textBox_KitapAra.Location = new Point(78, 43);
            textBox_KitapAra.Name = "textBox_KitapAra";
            textBox_KitapAra.PlaceholderText = "ISBN / Kitap Adı / Yazar ile arayın";
            textBox_KitapAra.Size = new Size(369, 25);
            textBox_KitapAra.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(button_IadeAl);
            groupBox3.Controls.Add(listView_UyeninAldigiKitapListesi);
            groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(522, 11);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(455, 719);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "↩️ İade Alma";
            // 
            // button_IadeAl
            // 
            button_IadeAl.Anchor = AnchorStyles.Bottom;
            button_IadeAl.BackColor = Color.FromArgb(192, 57, 43);
            button_IadeAl.FlatAppearance.BorderSize = 0;
            button_IadeAl.FlatStyle = FlatStyle.Flat;
            button_IadeAl.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_IadeAl.ForeColor = Color.White;
            button_IadeAl.Location = new Point(62, 669);
            button_IadeAl.Name = "button_IadeAl";
            button_IadeAl.Size = new Size(331, 35);
            button_IadeAl.TabIndex = 9;
            button_IadeAl.Text = "❌ SEÇİLİ KİTABI İADE AL";
            button_IadeAl.UseVisualStyleBackColor = false;
            button_IadeAl.Click += button_IadeAl_Click;
            // 
            // listView_UyeninAldigiKitapListesi
            // 
            listView_UyeninAldigiKitapListesi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView_UyeninAldigiKitapListesi.BorderStyle = BorderStyle.FixedSingle;
            listView_UyeninAldigiKitapListesi.FullRowSelect = true;
            listView_UyeninAldigiKitapListesi.Location = new Point(6, 26);
            listView_UyeninAldigiKitapListesi.Name = "listView_UyeninAldigiKitapListesi";
            listView_UyeninAldigiKitapListesi.Size = new Size(443, 632);
            listView_UyeninAldigiKitapListesi.TabIndex = 6;
            listView_UyeninAldigiKitapListesi.UseCompatibleStateImageBehavior = false;
            listView_UyeninAldigiKitapListesi.View = View.Details;
            // 
            // frmOduncIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(989, 742);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(889, 657);
            Name = "frmOduncIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Ödünç ve İade İşlemleri";
            Load += frmOduncIslemleri_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox_UyeAra;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox textBox_KitapAra;
        private ListView listView_KitapListesi;
        private ListView listView_Sepet;
        private Label label4;
        private Label label3;
        private Button button_OduncVer;
        private Label label_AdSoyad;
        private Button button_UyeAra;
        private Button btn_UyeListele;
        private Button button_IadeAl;
        private ListView listView_UyeninAldigiKitapListesi;
        private Button button_KitapAra;
    }
}