using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.Entity;

namespace Kutuphane.UI
{
    public partial class frmKitapIslemleri : Form
    {
        KitapManager _kitapManager;
        YazarManager _yazarManager;
        KategoriManager _kategoriManager;
        YayineviManager _yayineviManager;
        DilManager _dilManager;

        public frmKitapIslemleri()
        {
            InitializeComponent();

            _kitapManager = new KitapManager(new KitapDal());
            _yazarManager = new YazarManager(new YazarDal());
            _kategoriManager = new KategoriManager(new KategoriDal());
            _yayineviManager = new YayineviManager(new YayineviDal());
            _dilManager = new DilManager(new DilDal());
        }

        private void frmKitapIslemleri_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
            dataGrid_Kitap.ClearSelection();
        }

        //EKSİK,HATA
        private void Listele()
        {
            var kitapResult = _kitapManager.KitapListeDetayliGetirServis(x =>
                x.Aktif == true &&
                (x.KitapAdi.Contains(textBox_Ara.Text) || x.ISBN.Contains(textBox_Ara.Text))
            );

            if (!kitapResult.IsSuccess)
            {
                MessageBox.Show(kitapResult.Message);
                return;
            }

            dataGrid_Kitap.DataSource = kitapResult.Data;
        }

        private void ComboDoldur()
        {
            YazarComboDoldur();
            KategoriComboDoldur();
            YayineviComboDoldur();
            DilComboDoldur();
        }
        private void YazarComboDoldur()
        {
            var result = _yazarManager.GetListByFilterService(x => x.AktifMi);

            if (!result.IsSuccess)
                throw new Exception(result.Message);

            comboBox_Yazar.DataSource = result.Data
                .Select(x => new
                {
                    x.YazarId,
                    AdSoyad = x.Ad + " " + x.Soyad
                })
                .ToList();

            comboBox_Yazar.DisplayMember = "AdSoyad";
            comboBox_Yazar.ValueMember = "YazarId";
            comboBox_Yazar.SelectedIndex = -1;
        }
        private void KategoriComboDoldur()
        {
            var result = _kategoriManager.GetListByFilterService(x => x.AktifMi);

            if (!result.IsSuccess)
                throw new Exception(result.Message);

            comboBox_Kategori.DataSource = result.Data;
            comboBox_Kategori.DisplayMember = "KategoriAdi";
            comboBox_Kategori.ValueMember = "KategoriId";
            comboBox_Kategori.SelectedIndex = -1;
        }
        private void YayineviComboDoldur()
        {
            var result = _yayineviManager.GetListByFilterService(x => x.AktifMi);

            if (!result.IsSuccess)
                throw new Exception(result.Message);

            comboBox_Yayinevi.DataSource = result.Data;
            comboBox_Yayinevi.DisplayMember = "Ad";
            comboBox_Yayinevi.ValueMember = "YayineviId";
            comboBox_Yayinevi.SelectedIndex = -1;
        }
        private void DilComboDoldur()
        {
            var result = _dilManager.GetListByFilterService();

            if (!result.IsSuccess)
                throw new Exception(result.Message);

            comboBox_Dil.DataSource = result.Data;
            comboBox_Dil.DisplayMember = "DilAdi";
            comboBox_Dil.ValueMember = "DilId";
            comboBox_Dil.SelectedIndex = -1;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap
            {
                ISBN = textBox_ISBN.Text.Trim(),
                KitapAdi = textBox_KitapAdi.Text.Trim(),
                YazarId = (int)comboBox_Yazar.SelectedValue,
                KategoriId = (int)comboBox_Kategori.SelectedValue,
                YayineviId = (int)comboBox_Yayinevi.SelectedValue,
                DilId = Convert.ToInt16(comboBox_Dil.SelectedValue),
                BasimYili = string.IsNullOrWhiteSpace(textBox_BasimYili.Text)
                    ? null
                    : Convert.ToInt32(textBox_BasimYili.Text),
                SayfaSayisi = string.IsNullOrWhiteSpace(textBox_SayfaSayisi.Text)
                    ? null
                    : Convert.ToInt32(textBox_SayfaSayisi.Text),
                Stok = Convert.ToInt32(textBox_StokMiktari.Text),
                Aktif = true
            };

            var result = _kitapManager.AddService(kitap);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Kitap başarıyla eklendi.", "Başarılı");
            Listele();
            Temizle();
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {

        }
        private void btnSil_Click(object sender, EventArgs e)
        {

        }
        private void Temizle()
        {
            textBox_KitapId.Clear();
            textBox_ISBN.Clear();
            textBox_KitapAdi.Clear();
            comboBox_Kategori.SelectedIndex = -1;
            comboBox_Yazar.SelectedIndex = -1;
            comboBox_Yayinevi.SelectedIndex = -1;
            comboBox_Dil.SelectedIndex = -1;
            textBox_BasimYili.Clear();
            textBox_SayfaSayisi.Clear();
            textBox_StokMiktari.Clear();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGrid_Kitap.ClearSelection();
            Temizle();
        }
        private void PasifUyeKontrol()
        {

        }
        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {

        }
        private void btnGeriYukle_Click(object sender, EventArgs e)
        {

        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
            dataGrid_Kitap.ClearSelection();
        }
        private void kategoriİşlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategoriIslemleri frm = new frmKategoriIslemleri();
            frm.ShowDialog();
        }
        private void yazarİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYazarIslemleri frm = new frmYazarIslemleri();
            frm.ShowDialog();
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
        private void dataGrid_Kitap_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
