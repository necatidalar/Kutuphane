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
            label1 = new Label();
            btnCikis = new Button();
            txtKitapAra = new TextBox();
            btnKaydet = new Button();
            label2 = new Label();
            txtTcPass = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lvKitaplar = new ListView();
            lvSepet = new ListView();
            label7 = new Label();
            label8 = new Label();
            dtpAlis = new DateTimePicker();
            dtpTeslim = new DateTimePicker();
            btnUyeAra = new Button();
            lblUyeBilgi = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnTeslimEt = new Button();
            lvOdunclar = new ListView();
            lvTumGecikenler = new ListView();
            groupBox4 = new GroupBox();
            btnTeslimEtTumGecikenler = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(409, 28);
            label1.TabIndex = 0;
            label1.Text = "Kütüphane Otomasyonu - Ödünç İşlemleri";
            // 
            // btnCikis
            // 
            btnCikis.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(1378, 12);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(30, 30);
            btnCikis.TabIndex = 40;
            btnCikis.Text = "X";
            btnCikis.UseVisualStyleBackColor = true;
            // 
            // txtKitapAra
            // 
            txtKitapAra.BackColor = SystemColors.InfoText;
            txtKitapAra.Location = new Point(7, 54);
            txtKitapAra.Margin = new Padding(4);
            txtKitapAra.Name = "txtKitapAra";
            txtKitapAra.Size = new Size(399, 34);
            txtKitapAra.TabIndex = 41;
            // 
            // btnKaydet
            // 
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(89, 612);
            btnKaydet.Margin = new Padding(4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(235, 45);
            btnKaydet.TabIndex = 43;
            btnKaydet.Text = "Ödünç Ver";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 39);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 42;
            label2.Text = "Üye TC/PASS:";
            // 
            // txtTcPass
            // 
            txtTcPass.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtTcPass.Location = new Point(150, 33);
            txtTcPass.Margin = new Padding(4);
            txtTcPass.Name = "txtTcPass";
            txtTcPass.Size = new Size(203, 39);
            txtTcPass.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 29);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 42;
            label3.Text = "Kitap  Ara:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 474);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
            label4.TabIndex = 42;
            label4.Text = "Alış Tarihi: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 534);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 28);
            label5.TabIndex = 42;
            label5.Text = "Teslim Tarihi(+45): ";
            // 
            // lvKitaplar
            // 
            lvKitaplar.BackColor = SystemColors.InfoText;
            lvKitaplar.Location = new Point(6, 132);
            lvKitaplar.Name = "lvKitaplar";
            lvKitaplar.Size = new Size(400, 173);
            lvKitaplar.TabIndex = 45;
            lvKitaplar.UseCompatibleStateImageBehavior = false;
            lvKitaplar.View = View.Details;
            // 
            // lvSepet
            // 
            lvSepet.BackColor = SystemColors.InfoText;
            lvSepet.Location = new Point(7, 332);
            lvSepet.Name = "lvSepet";
            lvSepet.Size = new Size(399, 129);
            lvSepet.TabIndex = 46;
            lvSepet.UseCompatibleStateImageBehavior = false;
            lvSepet.View = View.Details;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 308);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 28);
            label7.TabIndex = 42;
            label7.Text = "Sepet:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 108);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(132, 28);
            label8.TabIndex = 42;
            label8.Text = "Kitap Listesi:";
            // 
            // dtpAlis
            // 
            dtpAlis.Enabled = false;
            dtpAlis.Location = new Point(7, 499);
            dtpAlis.Name = "dtpAlis";
            dtpAlis.Size = new Size(230, 34);
            dtpAlis.TabIndex = 47;
            // 
            // dtpTeslim
            // 
            dtpTeslim.Enabled = false;
            dtpTeslim.Location = new Point(7, 561);
            dtpTeslim.Name = "dtpTeslim";
            dtpTeslim.Size = new Size(230, 34);
            dtpTeslim.TabIndex = 47;
            // 
            // btnUyeAra
            // 
            btnUyeAra.FlatStyle = FlatStyle.Flat;
            btnUyeAra.Location = new Point(360, 33);
            btnUyeAra.Name = "btnUyeAra";
            btnUyeAra.Size = new Size(58, 39);
            btnUyeAra.TabIndex = 48;
            btnUyeAra.Text = "Ara";
            btnUyeAra.UseVisualStyleBackColor = true;
            // 
            // lblUyeBilgi
            // 
            lblUyeBilgi.AutoSize = true;
            lblUyeBilgi.Location = new Point(126, 69);
            lblUyeBilgi.Name = "lblUyeBilgi";
            lblUyeBilgi.Size = new Size(17, 28);
            lblUyeBilgi.TabIndex = 49;
            lblUyeBilgi.Text = ".";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(dtpTeslim);
            groupBox1.Controls.Add(dtpAlis);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lvSepet);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lvKitaplar);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtKitapAra);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 180);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 667);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ödünç Ver";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTcPass);
            groupBox2.Controls.Add(btnUyeAra);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(lblUyeBilgi);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(458, 124);
            groupBox2.TabIndex = 51;
            groupBox2.TabStop = false;
            groupBox2.Text = "Üye İşlemleri";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnTeslimEt);
            groupBox3.Controls.Add(lvOdunclar);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(430, 180);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(487, 667);
            groupBox3.TabIndex = 52;
            groupBox3.TabStop = false;
            groupBox3.Text = "Teslim Al";
            // 
            // btnTeslimEt
            // 
            btnTeslimEt.FlatStyle = FlatStyle.Flat;
            btnTeslimEt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTeslimEt.Location = new Point(126, 612);
            btnTeslimEt.Margin = new Padding(4);
            btnTeslimEt.Name = "btnTeslimEt";
            btnTeslimEt.Size = new Size(235, 45);
            btnTeslimEt.TabIndex = 48;
            btnTeslimEt.Text = "Teslim Al";
            btnTeslimEt.UseVisualStyleBackColor = true;
            // 
            // lvOdunclar
            // 
            lvOdunclar.BackColor = SystemColors.MenuText;
            lvOdunclar.Location = new Point(6, 54);
            lvOdunclar.Name = "lvOdunclar";
            lvOdunclar.Size = new Size(475, 551);
            lvOdunclar.TabIndex = 48;
            lvOdunclar.UseCompatibleStateImageBehavior = false;
            lvOdunclar.View = View.Details;
            // 
            // lvTumGecikenler
            // 
            lvTumGecikenler.BackColor = SystemColors.MenuText;
            lvTumGecikenler.Location = new Point(6, 54);
            lvTumGecikenler.Name = "lvTumGecikenler";
            lvTumGecikenler.Size = new Size(475, 551);
            lvTumGecikenler.TabIndex = 49;
            lvTumGecikenler.UseCompatibleStateImageBehavior = false;
            lvTumGecikenler.View = View.Details;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnTeslimEtTumGecikenler);
            groupBox4.Controls.Add(lvTumGecikenler);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(923, 180);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(487, 667);
            groupBox4.TabIndex = 53;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tüm Gecikenler";
            // 
            // btnTeslimEtTumGecikenler
            // 
            btnTeslimEtTumGecikenler.FlatStyle = FlatStyle.Flat;
            btnTeslimEtTumGecikenler.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTeslimEtTumGecikenler.Location = new Point(109, 615);
            btnTeslimEtTumGecikenler.Margin = new Padding(4);
            btnTeslimEtTumGecikenler.Name = "btnTeslimEtTumGecikenler";
            btnTeslimEtTumGecikenler.Size = new Size(235, 45);
            btnTeslimEtTumGecikenler.TabIndex = 49;
            btnTeslimEtTumGecikenler.Text = "Teslim Al";
            btnTeslimEtTumGecikenler.UseVisualStyleBackColor = true;
            // 
            // frmOduncIslemleri
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(1420, 868);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCikis);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmOduncIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Ödünç İşlemleri";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCikis;
        private TextBox txtKitapAra;
        private Button btnKaydet;
        private Label label2;
        private TextBox txtTcPass;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListView lvKitaplar;
        private ListView lvSepet;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpAlis;
        private DateTimePicker dtpTeslim;
        private Button btnUyeAra;
        private Label lblUyeBilgi;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ListView lvOdunclar;
        private Button btnTeslimEt;
        private ListView lvTumGecikenler;
        private GroupBox groupBox4;
        private Button btnTeslimEtTumGecikenler;
    }
}