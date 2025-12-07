namespace Kutuphane.UI
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        public string GirisYapanKullanici { get; set; }
        public int GirisYapanPersonelID { get; set; }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblKullaniciAdi.Text = "Hoşgeldiniz, " + GirisYapanKullanici;
        }
        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitapIslemleri kitapIslemleriForm = new frmKitapIslemleri();
            kitapIslemleriForm.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();

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
            frmOdunc.GuncelPersonelID = GirisYapanPersonelID;
            frmOdunc.ShowDialog();
        }
    }
}
