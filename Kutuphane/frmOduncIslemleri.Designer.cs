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
            listBox1 = new ListBox();
            label2 = new Label();
            txtDil = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
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
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDil);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 418);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üye İşlemleri";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(6, 65);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(360, 235);
            listBox1.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 32;
            label2.Text = "TC/PASS Ara:";
            // 
            // txtDil
            // 
            txtDil.Location = new Point(122, 29);
            txtDil.Margin = new Padding(4);
            txtDil.Name = "txtDil";
            txtDil.Size = new Size(244, 29);
            txtDil.TabIndex = 31;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(32, 338);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(114, 51);
            button1.TabIndex = 43;
            button1.Text = "Ödünç Ver";
            button1.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCikis;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtDil;
        private ListBox listBox1;
        private Button button1;
    }
}