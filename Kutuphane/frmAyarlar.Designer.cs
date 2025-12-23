namespace Kutuphane.UI
{
    partial class frmAyarlar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyarlar));
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Ayarlar";
            // 
            // frmAyarlar
            // 
            ClientSize = new Size(823, 532);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAyarlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistem ve Profil Ayarları";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}