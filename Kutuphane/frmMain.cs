using System.Windows.Forms;

namespace Kutuphane.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //public string GirisYapanKullanici { get; set; }
        public int GirisYapanPersonelId { get; set; }
        public string GirisYapanPersonelAd { get; private set; }
        public string GirisYapanPersonelSoyad { get; private set; }
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmGiris girisForm = new frmGiris();
            if (girisForm.ShowDialog() == DialogResult.OK)
            {
                this.GirisYapanPersonelAd = girisForm.GirisYapanPersonelAd;
                this.GirisYapanPersonelSoyad = girisForm.GirisYapanPersonelSoyad;
                this.GirisYapanPersonelId = girisForm.GirisYapanPersonelId;
                lblKullaniciAdi.Text = $"Hoşgeldin, {this.GirisYapanPersonelAd} {this.GirisYapanPersonelSoyad}";
            }
            else
            {
                this.Close();
            }
        }

        private void yerleşimAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYeslesimAyarlari frm = new frmYeslesimAyarlari();
            frm.ShowDialog();
        }

        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitapIslemleri frm = new frmKitapIslemleri();
            frm.ShowDialog();
        }

        private void kategoriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategoriIslemleri frm = new frmKategoriIslemleri();
            frm.ShowDialog();
        }

        private void yazarİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYazarIslemleri frm = new frmYazarIslemleri();
            frm.ShowDialog();
        }

        private void ödünçİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOduncIslemleri frm = new frmOduncIslemleri();
            frm.ShowDialog();
        }

        private void üyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUyeIslemleri frm = new frmUyeIslemleri();
            frm.ShowDialog();
        }

        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelIslemleri frm = new frmPersonelIslemleri();
            frm.ShowDialog();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
        }

        private void dilİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDilIslemleri frm = new frmDilIslemleri();
            frm.ShowDialog();
        }

        private void yayıneviİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYayineviIslemleri frm = new frmYayineviIslemleri();
            frm.ShowDialog();
        }
    }
}