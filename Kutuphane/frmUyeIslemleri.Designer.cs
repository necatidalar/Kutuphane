namespace Kutuphane.UI
{
    partial class frmUyeIslemleri
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

        #region Windows Form Desig#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUyeIslemleri));
            label1 = new Label();
            btnCikis = new Button();
            dgvUyeler = new DataGridView();
            groupBox1 = new GroupBox();
            richTextAdresDetay = new RichTextBox();
            rbKadin = new RadioButton();
            rbErkek = new RadioButton();
            btnSil = new Button();
            btnDuzenle = new Button();
            btnKaydet = new Button();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            txtID = new TextBox();
            txtDogumYili = new TextBox();
            label2 = new Label();
            txtEposta = new TextBox();
            txtTCPASS = new TextBox();
            txtAdres = new TextBox();
            txtTel = new TextBox();
            label11 = new Label();
            txtSoyad = new TextBox();
            label6 = new Label();
            label10 = new Label();
            txtAd = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 21);
            label1.TabIndex = 1;
            label1.Text = "Kütüphane Otomasyonu - Üye İşlemleri";
            // 
            // btnCikis
            // 
            btnCikis.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(1228, 12);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(30, 30);
            btnCikis.TabIndex = 41;
            btnCikis.Text = "X";
            btnCikis.UseVisualStyleBackColor = true;
            // 
            // dgvUyeler
            // 
            dgvUyeler.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgvUyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUyeler.Location = new Point(444, 86);
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.RowHeadersWidth = 51;
            dgvUyeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUyeler.Size = new Size(814, 620);
            dgvUyeler.TabIndex = 45;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextAdresDetay);
            groupBox1.Controls.Add(rbKadin);
            groupBox1.Controls.Add(rbErkek);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnDuzenle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(txtDogumYili);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEposta);
            groupBox1.Controls.Add(txtTCPASS);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(txtTel);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(21, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 630);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üye İşlemleri";
            // 
            // richTextAdresDetay
            // 
            richTextAdresDetay.Location = new Point(153, 366);
            richTextAdresDetay.Name = "richTextAdresDetay";
            richTextAdresDetay.Size = new Size(250, 96);
            richTextAdresDetay.TabIndex = 35;
            richTextAdresDetay.Text = "";
            // 
            // rbKadin
            // 
            rbKadin.AutoSize = true;
            rbKadin.Location = new Point(228, 183);
            rbKadin.Name = "rbKadin";
            rbKadin.Size = new Size(72, 25);
            rbKadin.TabIndex = 34;
            rbKadin.Text = "Kadın";
            rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(152, 183);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(70, 25);
            rbErkek.TabIndex = 34;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(152, 575);
            btnSil.Margin = new Padding(4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(250, 45);
            btnSil.TabIndex = 32;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnDuzenle
            // 
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDuzenle.Location = new Point(152, 522);
            btnDuzenle.Margin = new Padding(4);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(250, 45);
            btnDuzenle.TabIndex = 31;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(153, 469);
            btnKaydet.Margin = new Padding(4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(250, 45);
            btnKaydet.TabIndex = 33;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 185);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 21);
            label8.TabIndex = 14;
            label8.Text = "Cinsiyet:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(80, 37);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(65, 21);
            label9.TabIndex = 14;
            label9.Text = "Üye ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 222);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 21);
            label7.TabIndex = 14;
            label7.Text = "Doğum Yılı:";
            // 
            // txtID
            // 
            txtID.Location = new Point(153, 34);
            txtID.Margin = new Padding(4);
            txtID.Name = "txtID";
            txtID.Size = new Size(250, 29);
            txtID.TabIndex = 13;
            // 
            // txtDogumYili
            // 
            txtDogumYili.Location = new Point(153, 219);
            txtDogumYili.Margin = new Padding(4);
            txtDogumYili.Name = "txtDogumYili";
            txtDogumYili.Size = new Size(250, 29);
            txtDogumYili.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 14;
            label2.Text = "TC/PASS:";
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(153, 293);
            txtEposta.Margin = new Padding(4);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(250, 29);
            txtEposta.TabIndex = 19;
            // 
            // txtTCPASS
            // 
            txtTCPASS.Location = new Point(153, 71);
            txtTCPASS.Margin = new Padding(4);
            txtTCPASS.Name = "txtTCPASS";
            txtTCPASS.Size = new Size(250, 29);
            txtTCPASS.TabIndex = 13;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(153, 330);
            txtAdres.Margin = new Padding(4);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(250, 29);
            txtAdres.TabIndex = 19;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(153, 256);
            txtTel.Margin = new Padding(4);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(250, 29);
            txtTel.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 370);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(106, 21);
            label11.TabIndex = 26;
            label11.Text = "Adres Detay:";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(153, 145);
            txtSoyad.Margin = new Padding(4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(250, 29);
            txtSoyad.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 296);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 26;
            label6.Text = "E-Posta:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(88, 333);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(57, 21);
            label10.TabIndex = 26;
            label10.Text = "Adres:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(153, 108);
            txtAd.Margin = new Padding(4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(250, 29);
            txtAd.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 259);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 26;
            label5.Text = "Telefon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 148);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 26;
            label3.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 111);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(35, 21);
            label4.TabIndex = 26;
            label4.Text = "Ad:";
            // 
            // frmUyeIslemleri
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(1270, 721);
            Controls.Add(dgvUyeler);
            Controls.Add(groupBox1);
            Controls.Add(btnCikis);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmUyeIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Üye İşlemleri";
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCikis;
        private DataGridView dgvUyeler;
        private GroupBox groupBox1;
        private Button btnSil;
        private Button btnDuzenle;
        private Button btnKaydet;
        private Label label9;
        private TextBox txtID;
        private TextBox txtPersonelID;
        private Label label2;
        private TextBox txtTCPASS;
        private TextBox txtAdSoyad;
        private TextBox txtSifre;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label3;
        private Label label4;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private TextBox txtDogumYili;
        private TextBox txtEposta;
        private TextBox txtAdres;
        private TextBox txtTel;
        private Label label11;
        private Label label6;
        private Label label10;
        private Label label5;
        private RadioButton radioKadin;
        private RadioButton rbErkek;
        private RichTextBox richTextAdresDetay;
        private RadioButton rbKadin;
    }
}