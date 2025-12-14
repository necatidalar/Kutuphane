using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;

namespace Kutuphane.UI
{
    public partial class frmMain : Form
    {
        KitapManager _kitapManager;
        UyeManager _uyeManager;

        //public string GirisYapanKullanici { get; set; }
        public int GirisYapanPersonelId { get; set; }
        public string GirisYapanPersonelAd { get; private set; }
        public string GirisYapanPersonelSoyad { get; private set; }

        public frmMain()
        {
            InitializeComponent();

            _kitapManager = new KitapManager(new KitapDal());
            _uyeManager = new UyeManager(new UyeDal());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            flowLayoutPanel_Kartlar.Visible = false;
            lblKullaniciAdi.Visible = false;
            frmGiris girisForm = new frmGiris();
            if (girisForm.ShowDialog() == DialogResult.OK)
            {
                this.GirisYapanPersonelAd = girisForm.GirisYapanPersonelAd;
                this.GirisYapanPersonelSoyad = girisForm.GirisYapanPersonelSoyad;
                this.GirisYapanPersonelId = girisForm.GirisYapanPersonelId;
                lblKullaniciAdi.Text = $"Hoşgeldin, {this.GirisYapanPersonelAd} {this.GirisYapanPersonelSoyad}";
                flowLayoutPanel_Kartlar.Visible = true;
                lblKullaniciAdi.Visible = true;
                Listele();
            }
            else
            {
                this.Close();
            }
        }

        private void Listele()
        {
            var kitapResult = _kitapManager.GetListByFilterService(x => x.Aktif == true);
            int toplamKitap = kitapResult.IsSuccess ? kitapResult.Data.Count : 0;
            label_KitapSayisi.Text = toplamKitap.ToString();

            var uyeResult = _uyeManager.GetListByFilterService(x => x.AktifMi == true);
            int toplamUye = uyeResult.IsSuccess ? uyeResult.Data.Count : 0;
            label_UyeSayisi.Text = toplamUye.ToString();

            var oduncVerilenKitapResult = _kitapManager.GetListByFilterService();
            int oduncVerilenKitapSayisi = oduncVerilenKitapResult.IsSuccess ? oduncVerilenKitapResult.Data.Count : 0;
            label_OduncSayisi.Text = oduncVerilenKitapSayisi.ToString();
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
            frmOduncIslemleri frm = new frmOduncIslemleri
            {
                GirisYapanPersonelId = this.GirisYapanPersonelId
            };
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

        private void göstergePaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}