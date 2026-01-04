namespace Kutuphane.UI
{
    partial class frmYeslesimAyarlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYeslesimAyarlari));
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(194, 296);
            label1.Name = "label1";
            label1.Size = new Size(509, 32);
            label1.TabIndex = 0;
            label1.Text = "Kütüphane Otomasyonu - Yerleşim Ayarları";
            // 
            // frmYeslesimAyarlari
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 542);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmYeslesimAyarlari";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Yerleşim Ayarları";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}