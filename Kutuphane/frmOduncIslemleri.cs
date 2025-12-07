using Kutuphane.BLL.Services;
using Kutuphane.DAL.Repository;
using Kutuphane.Model.Entity;

namespace Kutuphane.UI
{
    public partial class frmOduncIslemleri : Form
    {

        private readonly OduncService _oduncService;
        private readonly UyeService _uyeService;
        private readonly KitapService _kitapService;

        private Uye _aktifUye;
        public int GuncelPersonelID { get; set; }
        public frmOduncIslemleri()
        {
            InitializeComponent();

            _kitapService = new KitapService(new Repository<Kitap>());
            _uyeService = new UyeService(new Repository<Uye>());
            _oduncService = new OduncService(new Repository<Odunc>(), _kitapService);
        }

        private void frmOduncIslemleri_Load(object sender, EventArgs e)
        {
            dtpAlis.Value = DateTime.Now;
            dtpTeslim.Value = DateTime.Now.AddDays(45);

            lvKitaplar.FullRowSelect = true;
            lvSepet.FullRowSelect = true;
            lvOdunclar.FullRowSelect = true;
            lvTumGecikenler.FullRowSelect = true;

            lvKitaplar.Columns.Add("ID", 50);
            lvKitaplar.Columns.Add("Kitap Adı", 200);

            lvSepet.Columns.Add("ID", 50);
            lvSepet.Columns.Add("Kitap Adı", 200);

            lvOdunclar.Columns.Add("Ödünç ID", 70);
            lvOdunclar.Columns.Add("Kitap Adı", 200);
            lvOdunclar.Columns.Add("Alış Tarihi", 100);
            lvOdunclar.Columns.Add("Teslim Tarihi", 100);

            lvTumGecikenler.Columns.Add("Ödünç ID", 70);
            lvTumGecikenler.Columns.Add("TC/Pass", 100);
            lvTumGecikenler.Columns.Add("Üye Adı", 150);
            lvTumGecikenler.Columns.Add("Kitap Adı", 200);
            lvTumGecikenler.Columns.Add("Alış Tarihi", 100);
            lvTumGecikenler.Columns.Add("Teslim Tarihi", 100);


            ListeleTumGecikenler();
        }

        private void ListeleTeslimEdilmeyenler()
        {
            lvOdunclar.Items.Clear();

            if (_aktifUye == null) return;

            var oduncler = _oduncService.GetByUye(_aktifUye.UyeID);

            foreach (var o in oduncler.Where(x => x.TeslimEdildi == false))
            {
                var kitap = _kitapService.GetById(o.KitapID);
                var item = new ListViewItem(o.OduncID.ToString());
                item.SubItems.Add(kitap?.KitapAdi ?? "-");
                item.SubItems.Add(o.AlisTarihi.ToShortDateString());

                if (o.TeslimTarihi.HasValue && o.TeslimTarihi.Value < DateTime.Now)
                {
                    item.SubItems.Add(o.TeslimTarihi.Value.ToShortDateString());
                    item.BackColor = Color.Red;
                    item.ForeColor = Color.White;
                }
                else
                {
                    item.SubItems.Add(o.TeslimTarihi.HasValue ? o.TeslimTarihi.Value.ToShortDateString() : "-");
                }

                lvOdunclar.Items.Add(item);
            }
        }

        private void btnTeslimEtTumGecikenler_Click(object sender, EventArgs e)
        {
            if (lvTumGecikenler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Teslim edilecek kitap seçiniz.");
                return;
            }

            var secili = lvTumGecikenler.SelectedItems[0];
            int oduncId = int.Parse(secili.Text);

            var sonuc = _oduncService.TeslimEt(oduncId);

            if (sonuc.Basarili)
            {
                MessageBox.Show("Kitap teslim edildi.");
                ListeleTumGecikenler();
            }
            else
            {
                MessageBox.Show("Hata: " + sonuc.Mesaj);
            }
        }

        
        private void lvKitaplar_DoubleClick(object sender, EventArgs e)
        {
            if (lvKitaplar.SelectedItems.Count == 0)
                return;

            var secili = lvKitaplar.SelectedItems[0];

            foreach (ListViewItem item in lvSepet.Items)
            {
                if (item.Text == secili.Text)
                {
                    MessageBox.Show("Bu kitap zaten sepette.");
                    return;
                }
            }

            var yeni = new ListViewItem(secili.Text);
            yeni.SubItems.Add(secili.SubItems[1].Text);

            lvSepet.Items.Add(yeni);
        }
        private void ListeleTumGecikenler()
        {
            lvTumGecikenler.Items.Clear();

            var oduncler = _oduncService.GetAll();

            foreach (var o in oduncler.Where(x => x.TeslimEdildi == false && x.TeslimTarihi.HasValue && x.TeslimTarihi.Value < DateTime.Now))
            {
                var kitap = _kitapService.GetById(o.KitapID);
                var uye = _uyeService.GetById(o.UyeID);

                var item = new ListViewItem(o.OduncID.ToString());
                item.SubItems.Add(uye?.TcPass ?? "-");
                item.SubItems.Add(uye != null ? uye.Ad + " " + uye.Soyad : "-");
                item.SubItems.Add(kitap?.KitapAdi ?? "-");
                item.SubItems.Add(o.AlisTarihi.ToShortDateString());

                if (o.TeslimTarihi.HasValue && o.TeslimTarihi.Value < DateTime.Now)
                {
                    item.BackColor = Color.Red;
                    item.ForeColor = Color.White;
                }

                item.SubItems.Add(o.TeslimTarihi.HasValue ? o.TeslimTarihi.Value.ToShortDateString() : "-");

                lvTumGecikenler.Items.Add(item);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_aktifUye == null)
            {
                MessageBox.Show("Üye seç.");
                return;
            }

            if (lvSepet.Items.Count == 0)
            {
                MessageBox.Show("Sepet boş.");
                return;
            }

            DateTime alis = dtpAlis.Value.Date;
            DateTime teslim = dtpTeslim.Value.Date;

            int personelId = GuncelPersonelID;

            bool tumuBasarili = true;

            foreach (ListViewItem item in lvSepet.Items)
            {
                int kitapId = int.Parse(item.Text);

                var sonuc = _oduncService.OduncVer(
                    _aktifUye.UyeID,
                    kitapId,
                    personelId,
                    alis,
                    teslim
                );

                if (!sonuc.Basarili)
                {
                    tumuBasarili = false;
                    MessageBox.Show($"Hata ({item.SubItems[1].Text}): {sonuc.Mesaj}");
                }
            }

            if (tumuBasarili)
            {
                MessageBox.Show("Kaydedildi.");
                lvSepet.Items.Clear();
            }
            ListeleTeslimEdilmeyenler();
        }

        private void btnUyeAra_Click(object sender, EventArgs e)
        {
            _aktifUye = _uyeService.UyeBul(txtTcPass.Text.Trim());

            if (_aktifUye == null)
            {
                MessageBox.Show("Üye bulunamadı.");
                lvOdunclar.Items.Clear();
                return;
            }

            lblUyeBilgi.Text = $"{_aktifUye.Ad} {_aktifUye.Soyad}";
            ListeleTeslimEdilmeyenler();
        }

        private void dtpAlis_ValueChanged(object sender, EventArgs e)
        {
            dtpTeslim.Value = dtpAlis.Value.AddDays(45);
        }

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            lvKitaplar.Items.Clear();
            var liste = _kitapService.Ara(txtKitapAra.Text.Trim());

            foreach (var k in liste)
            {
                var item = new ListViewItem(k.KitapID.ToString());
                item.SubItems.Add(k.KitapAdi);
                item.SubItems.Add(k.Yazar != null ? $"{k.Yazar.Ad} {k.Yazar.Soyad}" : "-");
                lvKitaplar.Items.Add(item);
            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOduncIslemleri_Paint(object sender, PaintEventArgs e)
        {
            int borderSize = 2;
            Color borderColor = Color.DimGray;

            ControlPaint.DrawBorder(e.Graphics,
                                    this.ClientRectangle,
                                    borderColor, borderSize, ButtonBorderStyle.Solid,
                                    borderColor, borderSize, ButtonBorderStyle.Solid,
                                    borderColor, borderSize, ButtonBorderStyle.Solid,
                                    borderColor, borderSize, ButtonBorderStyle.Solid);
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (lvOdunclar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Teslim edilecek kitap seçiniz.");
                return;
            }

            var secili = lvOdunclar.SelectedItems[0];
            int oduncId = int.Parse(secili.Text);

            var sonuc = _oduncService.TeslimEt(oduncId);

            if (sonuc.Basarili)
            {
                MessageBox.Show("Kitap teslim edildi.");
                ListeleTeslimEdilmeyenler();
            }
            else
            {
                MessageBox.Show("Hata: " + sonuc.Mesaj);
            }
        }

        
    }
}