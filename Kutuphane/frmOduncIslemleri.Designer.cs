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
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label_AdSoyad = new Label();
            button_UyeAra = new Button();
            btn_UyeListele = new Button();
            groupBox2 = new GroupBox();
            button_KitapAra = new Button();
            label4 = new Label();
            listView_Sepet = new ListView();
            listView_KitapListesi = new ListView();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            groupBox3 = new GroupBox();
            button_IadeAl = new Button();
            listView_UyeninAldigiKitapListesi = new ListView();
            button_OduncVer = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 34);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "TC Kimlik No / Pasaport No / Ad Soyad ile arayın";
            textBox1.Size = new Size(293, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 37);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Üye Ara:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_AdSoyad);
            groupBox1.Controls.Add(button_UyeAra);
            groupBox1.Controls.Add(btn_UyeListele);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 179);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üye İşlemleri";
            // 
            // label_AdSoyad
            // 
            label_AdSoyad.AutoSize = true;
            label_AdSoyad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_AdSoyad.Location = new Point(64, 65);
            label_AdSoyad.Name = "label_AdSoyad";
            label_AdSoyad.Size = new Size(69, 15);
            label_AdSoyad.TabIndex = 11;
            label_AdSoyad.Text = "Ad Soyad: -";
            // 
            // button_UyeAra
            // 
            button_UyeAra.Location = new Point(363, 34);
            button_UyeAra.Name = "button_UyeAra";
            button_UyeAra.Size = new Size(43, 23);
            button_UyeAra.TabIndex = 10;
            button_UyeAra.Text = "Ara";
            button_UyeAra.UseVisualStyleBackColor = true;
            button_UyeAra.Click += button_UyeAra_Click;
            // 
            // btn_UyeListele
            // 
            btn_UyeListele.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_UyeListele.Location = new Point(64, 100);
            btn_UyeListele.Name = "btn_UyeListele";
            btn_UyeListele.Size = new Size(293, 35);
            btn_UyeListele.TabIndex = 9;
            btn_UyeListele.Text = "Üyenin Ödünç Aldıği Kitapları Listele";
            btn_UyeListele.UseVisualStyleBackColor = true;
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
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(12, 197);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(425, 410);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ödünç Ver";
            // 
            // button_KitapAra
            // 
            button_KitapAra.Location = new Point(334, 43);
            button_KitapAra.Name = "button_KitapAra";
            button_KitapAra.Size = new Size(43, 23);
            button_KitapAra.TabIndex = 12;
            button_KitapAra.Text = "Ara";
            button_KitapAra.UseVisualStyleBackColor = true;
            button_KitapAra.Click += button_KitapAra_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 217);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Sepet:";
            // 
            // listView_Sepet
            // 
            listView_Sepet.Location = new Point(84, 217);
            listView_Sepet.Name = "listView_Sepet";
            listView_Sepet.Size = new Size(293, 139);
            listView_Sepet.TabIndex = 6;
            listView_Sepet.UseCompatibleStateImageBehavior = false;
            // 
            // listView_KitapListesi
            // 
            listView_KitapListesi.Location = new Point(84, 72);
            listView_KitapListesi.Name = "listView_KitapListesi";
            listView_KitapListesi.Size = new Size(293, 139);
            listView_KitapListesi.TabIndex = 5;
            listView_KitapListesi.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 72);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "Kitap Listesi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 46);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Kitap Ara:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 43);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "ISBN / Kitap Adı / Yazar ile arayın";
            textBox2.Size = new Size(244, 23);
            textBox2.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button_IadeAl);
            groupBox3.Controls.Add(listView_UyeninAldigiKitapListesi);
            groupBox3.Location = new Point(443, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(425, 595);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Üyenin Aldığı Kitaplar";
            // 
            // button_IadeAl
            // 
            button_IadeAl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_IadeAl.Location = new Point(65, 547);
            button_IadeAl.Name = "button_IadeAl";
            button_IadeAl.Size = new Size(293, 35);
            button_IadeAl.TabIndex = 9;
            button_IadeAl.Text = "İade Al";
            button_IadeAl.UseVisualStyleBackColor = true;
            button_IadeAl.Click += button_IadeAl_Click;
            // 
            // listView_UyeninAldigiKitapListesi
            // 
            listView_UyeninAldigiKitapListesi.Location = new Point(5, 22);
            listView_UyeninAldigiKitapListesi.Name = "listView_UyeninAldigiKitapListesi";
            listView_UyeninAldigiKitapListesi.Size = new Size(413, 519);
            listView_UyeninAldigiKitapListesi.TabIndex = 6;
            listView_UyeninAldigiKitapListesi.UseCompatibleStateImageBehavior = false;
            // 
            // button_OduncVer
            // 
            button_OduncVer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_OduncVer.Location = new Point(84, 362);
            button_OduncVer.Name = "button_OduncVer";
            button_OduncVer.Size = new Size(293, 35);
            button_OduncVer.TabIndex = 10;
            button_OduncVer.Text = "Ödünç Ver";
            button_OduncVer.UseVisualStyleBackColor = true;
            button_OduncVer.Click += button_OduncVer_Click;
            // 
            // frmOduncIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 618);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmOduncIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Ödünç İşlemleri";
            Load += frmOduncIslemleri_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox textBox2;
        private ListView listView_KitapListesi;
        private ListView listView_Sepet;
        private Label label4;
        private Label label3;
        private Button btn_OduncVer;
        private Label label_AdSoyad;
        private Button button_UyeAra;
        private Button btn_UyeListele;
        private Button button_IadeAl;
        private ListView listView_UyeninAldigiKitapListesi;
        private Button button_KitapAra;
        private Button button_OduncVer;
    }
}