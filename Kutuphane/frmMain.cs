using Kutuphane.BLL.Services;
using Kutuphane.DAL.Contexes;

namespace Kutuphane.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            ChangeDbContext(DbContextType.Supervisor);
        }

        // DbContext değiştirme metodu
        private void ChangeDbContext(DbContextType contextType)
        {
            DbContextSelector.CurrentContext = contextType;
            MessageBox.Show($"Veritabanı bağlantısı {contextType} olarak değiştirildi.", "Bilgi");
        }


        public string GirisYapanKullanici { get; set; }
        public int GirisYapanPersonelID { get; set; }

        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitapIslemleri kitapIslemleriForm = new frmKitapIslemleri();
            kitapIslemleriForm.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelIslemleri personelIslemleriForm = new frmPersonelIslemleri();
            personelIslemleriForm.ShowDialog();
        }

        private void üyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUyeIslemleri frmUye = new frmUyeIslemleri();
            frmUye.ShowDialog();
        }

        private void ödünçİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOduncIslemleri frmOdunc = new frmOduncIslemleri();
            frmOdunc.ShowDialog();
        }

        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form child = new frmKitapIslemleri();
            child.MdiParent = this;
            child.Show();
        }
    }
}
