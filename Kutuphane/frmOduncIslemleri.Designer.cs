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
            groupBox1 = new GroupBox();
            dgvUyeOdunc = new DataGridView();
            btnAra = new Button();
            btnKaydet = new Button();
            label2 = new Label();
            txtAra = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeOdunc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(330, 21);
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
            btnCikis.Location = new Point(1269, 12);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(30, 30);
            btnCikis.TabIndex = 40;
            btnCikis.Text = "X";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvUyeOdunc);
            groupBox1.Controls.Add(btnAra);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAra);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(916, 380);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üye İşlemleri";
            // 
            // dgvUyeOdunc
            // 
            dgvUyeOdunc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUyeOdunc.Location = new Point(55, 65);
            dgvUyeOdunc.Name = "dgvUyeOdunc";
            dgvUyeOdunc.Size = new Size(840, 238);
            dgvUyeOdunc.TabIndex = 44;
            // 
            // btnAra
            // 
            btnAra.FlatStyle = FlatStyle.Flat;
            btnAra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAra.Location = new Point(373, 29);
            btnAra.Margin = new Padding(4);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(57, 29);
            btnAra.TabIndex = 43;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(55, 310);
            btnKaydet.Margin = new Padding(4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(105, 51);
            btnKaydet.TabIndex = 43;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 32;
            label2.Text = "Ara:";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(55, 29);
            txtAra.Margin = new Padding(4);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(311, 29);
            txtAra.TabIndex = 31;
            // 
            // frmOduncIslemleri
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(1311, 735);
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
            Load += frmOduncIslemleri_Load;
            Paint += frmOduncIslemleri_Paint;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeOdunc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCikis;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtAra;
        private Button btnKaydet;
        private DataGridView dgvUyeOdunc;
        private Button btnAra;
    }
}