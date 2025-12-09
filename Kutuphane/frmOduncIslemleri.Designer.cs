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
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            textBox2 = new TextBox();
            listView1 = new ListView();
            listView2 = new ListView();
            label3 = new Label();
            label4 = new Label();
            btnOdunc = new Button();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            button3 = new Button();
            listView3 = new ListView();
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
            label1.Location = new Point(7, 39);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Üye Ara:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 158);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üye İşlemleri";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOdunc);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(listView2);
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(13, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(425, 500);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ödünç Ver";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(listView3);
            groupBox3.Location = new Point(444, 176);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(425, 500);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
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
            textBox2.Size = new Size(293, 23);
            textBox2.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Location = new Point(84, 72);
            listView1.Name = "listView1";
            listView1.Size = new Size(293, 139);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(84, 217);
            listView2.Name = "listView2";
            listView2.Size = new Size(293, 139);
            listView2.TabIndex = 6;
            listView2.UseCompatibleStateImageBehavior = false;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 217);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Sepet:";
            // 
            // btnOdunc
            // 
            btnOdunc.Location = new Point(160, 362);
            btnOdunc.Name = "btnOdunc";
            btnOdunc.Size = new Size(141, 23);
            btnOdunc.TabIndex = 8;
            btnOdunc.Text = "Ödünç Ver";
            btnOdunc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(99, 98);
            button1.Name = "button1";
            button1.Size = new Size(222, 23);
            button1.TabIndex = 9;
            button1.Text = "Üyenin Ödünç Aldıği Kitapları Listele";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(363, 34);
            button2.Name = "button2";
            button2.Size = new Size(43, 23);
            button2.TabIndex = 10;
            button2.Text = "Ara";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 61);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 11;
            label5.Text = "Üye: Ad Soyad";
            // 
            // button3
            // 
            button3.Location = new Point(142, 461);
            button3.Name = "button3";
            button3.Size = new Size(141, 23);
            button3.TabIndex = 9;
            button3.Text = "İade Al";
            button3.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            listView3.Location = new Point(6, 22);
            listView3.Name = "listView3";
            listView3.Size = new Size(413, 423);
            listView3.TabIndex = 6;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // frmOduncIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 686);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmOduncIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Ödünç İşlemleri";
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
        private ListView listView1;
        private ListView listView2;
        private Label label4;
        private Label label3;
        private Button btnOdunc;
        private Label label5;
        private Button button2;
        private Button button1;
        private Button button3;
        private ListView listView3;
    }
}