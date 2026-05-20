using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.DAL.Contexes;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using Kutuphane.UI.UIMetodlar;

namespace Kutuphane.UI
{
    public partial class frmOduncIslemleri : Form
    {
        private readonly IUyeService _uyeService;
        private readonly IKitapService _kitapService;
        private readonly OduncManager _oduncManager;

        private int _secilenUyeId = 0;
        private int _girisYapanPersonelId = 0;
        private List<OduncKitapDto> _sepetiKitaplar = new();
        private List<OduncKitapDto> oduncKitapListe = new();
        private List<OduncUyeDto> oduncUyeListe = new();

        public int GirisYapanPersonelId
        {
            get => _girisYapanPersonelId;
            set => _girisYapanPersonelId = value;
        }

        private readonly YetkiKontrol _yetkiKontrol;
        private readonly int _personelId;
        private readonly HashSet<string> _userPermissions;

        public frmOduncIslemleri(int personelId)
        {
            InitializeComponent();
            _uyeService = new UyeManager(new UyeDal());
            _kitapService = new KitapManager(new KitapDal());
            _oduncManager = new OduncManager(new OduncDal());

            _personelId = personelId;
            _yetkiKontrol = new YetkiKontrol(new KutuphaneDbContext());
            _userPermissions = _yetkiKontrol.KullaniciYetkileriniAl(_personelId);
        }

        private void frmOduncIslemleri_Load(object sender, EventArgs e)
        {
            YetkiKontrol();
            InitializeDataLoads();
            InitialieUIComponents();
            TumOduncleriListele();
        }

        private void YetkiKontrol()
        {
            bool oduncVer = _userPermissions.Contains("ODUNC_VER");
            bool iade = _userPermissions.Contains("IADE_AL");
            bool listele = _userPermissions.Contains("ODUNC_LISTELE");

            groupBox_UyeIslemleri.Enabled = oduncVer || iade;
            groupBox_KitapSecimi_OduncVerme.Enabled = oduncVer;
            btnOduncVer.Enabled = oduncVer;
            groupBox_IadeIslemleri.Enabled = iade;
            btnIadeAl.Enabled = iade;
            groupBox_TumOduncler.Visible = listele || iade;
            btnTumIadeAl.Enabled = iade;
        }

        private void InitializeDataLoads()
        {
            var odunckitapresult = _kitapService.OduncIcinListeGetir(k => k.Aktif == true);
            oduncKitapListe = odunckitapresult.IsSuccess ? odunckitapresult.Data.OrderBy(x => x.KitapAdi).ToList() : new();

            var oduncUyeresult = _uyeService.OduncUyeListeDetayliGetirServis(x => x.AktifMi == true);
            oduncUyeListe = oduncUyeresult.IsSuccess ? oduncUyeresult.Data.OrderBy(x => x.OkulNo).ThenBy(x => x.Ad).ToList() : new();
        }

        private void InitialieUIComponents()
        {
            TumOdunclerListViewDuzenle();
            SepetListViewDuzenle();
            KitapListeListViewDuzenle();
            UyeninAldigiKitapListViewDuzenle();
            UyeListViewDuzenle();
            dateTimePicker_TeslimTarihi.Value = DateTime.Now.AddDays(45);
        }

        private void TumOduncleriListele()
        {
            listView_AlinanTumKitaplarinListesi.Items.Clear();
            var result = _oduncManager.OduncBilgileriGetirServis(x => x.TeslimEdildi == false);
            if (!result.IsSuccess)
                return;

            foreach (var o in result.Data.OrderBy(x => x.TeslimTarihi))
            {
                bool geciktiMi = o.TeslimTarihi.HasValue && o.TeslimTarihi.Value.Date < DateTime.Today;
                string sinifSube = $"{o.UyeSinif}/{o.UyeSube}".Replace("/", "").Trim();
                if (!string.IsNullOrWhiteSpace(o.UyeSinif) || !string.IsNullOrWhiteSpace(o.UyeSube))
                    sinifSube = $"{o.UyeSinif}/{o.UyeSube}";

                var item = new ListViewItem(o.UyeOkulNo ?? "-");
                item.SubItems.Add($"{o.UyeAd} {o.UyeSoyad}");
                item.SubItems.Add(sinifSube);
                item.SubItems.Add(o.KitapAdi);
                item.SubItems.Add(o.AlisTarihi.ToString("dd.MM.yyyy"));
                item.SubItems.Add(o.TeslimTarihi?.ToString("dd.MM.yyyy") ?? "-");
                item.SubItems.Add(geciktiMi ? "❌ GECİKMİŞ" : "✅ Ödünçte");
                item.Tag = o.OduncId;

                if (geciktiMi)
                {
                    item.BackColor = Color.DarkRed;
                    item.ForeColor = Color.White;
                }
                else
                {
                    item.BackColor = Color.DarkGreen;
                    item.ForeColor = Color.White;
                }

                listView_AlinanTumKitaplarinListesi.Items.Add(item);
            }
        }

        private void TumOdunclerListViewDuzenle()
        {
            listView_AlinanTumKitaplarinListesi.View = View.Details;
            listView_AlinanTumKitaplarinListesi.FullRowSelect = true;
            listView_AlinanTumKitaplarinListesi.GridLines = true;
            listView_AlinanTumKitaplarinListesi.CheckBoxes = true;

            listView_AlinanTumKitaplarinListesi.Columns.Clear();
            listView_AlinanTumKitaplarinListesi.Columns.Add("Okul No", 100);
            listView_AlinanTumKitaplarinListesi.Columns.Add("Öğrenci", 170);
            listView_AlinanTumKitaplarinListesi.Columns.Add("Sınıf", 70);
            listView_AlinanTumKitaplarinListesi.Columns.Add("Kitap", 220);
            listView_AlinanTumKitaplarinListesi.Columns.Add("Alış", 95);
            listView_AlinanTumKitaplarinListesi.Columns.Add("Teslim", 95);
            listView_AlinanTumKitaplarinListesi.Columns.Add("Durum", 120);
        }

        private void UyeListViewDuzenle()
        {
            listView_Uyeler.View = View.Details;
            listView_Uyeler.GridLines = true;
            listView_Uyeler.FullRowSelect = true;

            listView_Uyeler.Columns.Clear();
            listView_Uyeler.Columns.Add("Okul No", 100);
            listView_Uyeler.Columns.Add("Ad", 140);
            listView_Uyeler.Columns.Add("Soyad", 140);
            listView_Uyeler.Columns.Add("Sınıf", 80);
            listView_Uyeler.Columns.Add("Telefon", 130);
            listView_Uyeler.SelectedIndexChanged -= listView_Uyeler_SelectedIndexChanged;
            listView_Uyeler.SelectedIndexChanged += listView_Uyeler_SelectedIndexChanged;
        }

        private void SepetListViewDuzenle()
        {
            listView_Sepet.Columns.Clear();
            listView_Sepet.Columns.Add("Kitap Adı", 240);
            listView_Sepet.Columns.Add("ISBN", 130);
            listView_Sepet.Columns.Add("Yazar", 190);
            listView_Sepet.Columns.Add("Stok", 70);
        }

        private void KitapListeListViewDuzenle()
        {
            listView_KitapListesi.Columns.Clear();
            listView_KitapListesi.Columns.Add("Kitap Adı", 240);
            listView_KitapListesi.Columns.Add("ISBN", 130);
            listView_KitapListesi.Columns.Add("Yazar", 190);
            listView_KitapListesi.Columns.Add("Stok", 70);
            listView_KitapListesi.DoubleClick -= ListViewKitap_DoubleClick;
            listView_KitapListesi.DoubleClick += ListViewKitap_DoubleClick;
        }

        private void UyeninAldigiKitapListViewDuzenle()
        {
            listView_UyeninAldigiKitapListesi.Columns.Clear();
            listView_UyeninAldigiKitapListesi.Columns.Add("Kitap Adı", 240);
            listView_UyeninAldigiKitapListesi.Columns.Add("Alış Tarihi", 120);
            listView_UyeninAldigiKitapListesi.Columns.Add("Teslim Tarihi", 120);
            listView_UyeninAldigiKitapListesi.Columns.Add("Durum", 130);
        }

        private void button_TumIadeAl_Click(object sender, EventArgs e)
        {
            var secili = listView_AlinanTumKitaplarinListesi.Items
                .Cast<ListViewItem>()
                .Where(x => x.Checked)
                .ToList();

            if (!secili.Any())
            {
                MessageBox.Show("Lütfen iade alınacak kitapları işaretleyin.");
                return;
            }

            int basarili = 0;
            int basarisiz = 0;

            foreach (var item in secili)
            {
                int oduncId = (int)item.Tag;
                if (IadeEt(oduncId))
                    basarili++;
                else
                    basarisiz++;
            }

            MessageBox.Show($"✅ {basarili} kitap topluca iade alındı.\n❌ {basarisiz} kitap iade alınamadı.");
            InitializeDataLoads();
            TumOduncleriListele();
            UyeninAldigiKitaplarıListele();
        }

        private void UyeSecimi(OduncUyeDto uye)
        {
            _secilenUyeId = uye.UyeId;
            label_AdSoyad.Text = $"Seçili Öğrenci: {uye.OkulNo} - {uye.Ad} {uye.Soyad} ({uye.Sinif}/{uye.Sube})";
            UyeninAldigiKitaplarıListele();
        }

        private void listView_Uyeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Uyeler.SelectedItems.Count == 0)
                return;

            var secilenSatir = listView_Uyeler.SelectedItems[0];
            var secilenUye = (OduncUyeDto)secilenSatir.Tag;
            UyeSecimi(secilenUye);
        }

        private void UyeninAldigiKitaplarıListele()
        {
            try
            {
                listView_UyeninAldigiKitapListesi.Items.Clear();

                if (_secilenUyeId <= 0)
                {
                    label_ToplamAlinanKitapSayisi.Text = "Toplam Alınan: 0";
                    label_SuanOduncteKitapSayisi.Text = "Şu an Ödünçte: 0";
                    return;
                }

                var tumResult = _oduncManager.OduncBilgileriGetirServis(x => x.UyeId == _secilenUyeId);
                if (!tumResult.IsSuccess)
                {
                    MessageBox.Show(tumResult.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int toplamKitap = tumResult.Data.Count;
                var oduncteOlanlar = tumResult.Data.Where(x => x.TeslimEdildi == false).OrderBy(x => x.TeslimTarihi).ToList();

                label_ToplamAlinanKitapSayisi.Text = $"Toplam Alınan: {toplamKitap}";
                label_SuanOduncteKitapSayisi.Text = $"Şu an Ödünçte: {oduncteOlanlar.Count}";

                foreach (var odunc in oduncteOlanlar)
                {
                    bool geciktiMi = odunc.TeslimTarihi.HasValue && odunc.TeslimTarihi.Value.Date < DateTime.Today;
                    var item = new ListViewItem(odunc.KitapAdi);
                    item.SubItems.Add(odunc.AlisTarihi.ToString("dd.MM.yyyy"));
                    item.SubItems.Add(odunc.TeslimTarihi?.ToString("dd.MM.yyyy") ?? "-");
                    item.SubItems.Add(geciktiMi ? "❌ Gecikti" : "⏳ Ödünçte");
                    item.Tag = odunc.OduncId;
                    listView_UyeninAldigiKitapListesi.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListViewKitap_DoubleClick(object sender, EventArgs e)
        {
            if (listView_KitapListesi.SelectedItems.Count == 0)
                return;

            var secilenItem = listView_KitapListesi.SelectedItems[0];
            var kitap = (OduncKitapDto)secilenItem.Tag;

            if (kitap.Stok <= 0)
            {
                MessageBox.Show("Bu kitabın uygun stoğu yok.", "Stok Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_sepetiKitaplar.Any(x => x.Id == kitap.Id))
            {
                MessageBox.Show("Bu kitap zaten sepette.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_secilenUyeId > 0)
            {
                var aktifOdunc = _oduncManager.GetListByFilterService(x => x.UyeId == _secilenUyeId && x.KitapId == kitap.Id && x.TeslimEdildi == false);
                if (aktifOdunc.IsSuccess && aktifOdunc.Data.Any())
                {
                    MessageBox.Show("Bu kitap seçili öğrenci üzerinde zaten ödünçte.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            _sepetiKitaplar.Add(kitap);
            SepetGuncelle();
        }

        private void SepetGuncelle()
        {
            listView_Sepet.Items.Clear();
            foreach (var kitap in _sepetiKitaplar)
            {
                var item = new ListViewItem(kitap.KitapAdi);
                item.SubItems.Add(kitap.ISBN ?? string.Empty);
                item.SubItems.Add(kitap.Yazar ?? string.Empty);
                item.SubItems.Add(kitap.Stok.ToString());
                item.Tag = kitap.Id;
                listView_Sepet.Items.Add(item);
            }
        }

        private void button_OduncVer_Click(object sender, EventArgs e)
        {
            if (_secilenUyeId == 0)
            {
                MessageBox.Show("Lütfen okul numarasıyla bir öğrenci seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_sepetiKitaplar.Count == 0)
            {
                MessageBox.Show("Lütfen sepete kitap ekleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_girisYapanPersonelId <= 0)
            {
                MessageBox.Show("Sistem hatası: Giriş yapan personel bilgisi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dateTimePicker_TeslimTarihi.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Teslim tarihi bugünden önce olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int basariSayisi = 0;
                int basarisizSayisi = 0;

                foreach (var kitap in _sepetiKitaplar.ToList())
                {
                    var kitapResult = _kitapService.GetByFilterService(x => x.KitapId == kitap.Id);
                    if (!kitapResult.IsSuccess || kitapResult.Data == null || kitapResult.Data.Stok <= 0)
                    {
                        basarisizSayisi++;
                        continue;
                    }

                    var aktifOdunc = _oduncManager.GetListByFilterService(x => x.UyeId == _secilenUyeId && x.KitapId == kitap.Id && x.TeslimEdildi == false);
                    if (aktifOdunc.IsSuccess && aktifOdunc.Data.Any())
                    {
                        basarisizSayisi++;
                        continue;
                    }

                    var odunc = new Odunc
                    {
                        UyeId = _secilenUyeId,
                        KitapId = kitap.Id,
                        AlisTarihi = DateTime.Now,
                        TeslimTarihi = dateTimePicker_TeslimTarihi.Value.Date,
                        TeslimEdildi = false,
                        TeslimEdenPersonelId = _girisYapanPersonelId
                    };

                    var result = _oduncManager.AddService(odunc);
                    if (result.IsSuccess)
                    {
                        kitapResult.Data.Stok--;
                        _kitapService.UpdateService(kitapResult.Data);
                        basariSayisi++;
                    }
                    else
                    {
                        basarisizSayisi++;
                    }
                }

                _sepetiKitaplar.Clear();
                SepetGuncelle();
                InitializeDataLoads();

                string mesaj = $"✅ {basariSayisi} kitap ödünç verildi.";
                if (basarisizSayisi > 0)
                    mesaj += $"\n❌ {basarisizSayisi} kitap stok yetersizliği, mükerrer ödünç veya hata nedeniyle verilemedi.";

                MessageBox.Show(mesaj, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UyeninAldigiKitaplarıListele();
                TumOduncleriListele();
                textBox_KitapAra_TextChanged(textBox_KitapAra, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IadeEt(int oduncId)
        {
            var oduncResult = _oduncManager.GetByFilterService(x => x.OduncId == oduncId);
            if (!oduncResult.IsSuccess || oduncResult.Data == null || oduncResult.Data.TeslimEdildi)
                return false;

            var odunc = oduncResult.Data;
            odunc.TeslimTarihi = DateTime.Now;
            odunc.TeslimEdildi = true;
            odunc.TeslimAlanPersonelId = _girisYapanPersonelId;

            if (!_oduncManager.UpdateService(odunc).IsSuccess)
                return false;

            var kitapResult = _kitapService.GetByFilterService(x => x.KitapId == odunc.KitapId);
            if (kitapResult.IsSuccess && kitapResult.Data != null)
            {
                kitapResult.Data.Stok++;
                _kitapService.UpdateService(kitapResult.Data);
            }

            return true;
        }

        private void button_IadeAl_Click(object sender, EventArgs e)
        {
            var seciliItemler = listView_UyeninAldigiKitapListesi.Items
                .Cast<ListViewItem>()
                .Where(x => x.Checked)
                .ToList();

            if (!seciliItemler.Any())
            {
                MessageBox.Show("Lütfen teslim alınacak kitapları işaretleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int basarili = 0;
                int basarisiz = 0;

                foreach (var item in seciliItemler)
                {
                    int oduncId = (int)item.Tag;
                    if (IadeEt(oduncId))
                        basarili++;
                    else
                        basarisiz++;
                }

                MessageBox.Show($"✅ {basarili} kitap teslim alındı.\n❌ {basarisiz} kitap teslim alınamadı.", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeDataLoads();
                UyeninAldigiKitaplarıListele();
                TumOduncleriListele();
                textBox_KitapAra_TextChanged(textBox_KitapAra, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool ContainsText(string? value, string search)
        {
            return !string.IsNullOrWhiteSpace(value) && value.Contains(search, StringComparison.OrdinalIgnoreCase);
        }

        private void textBox_KitapAra_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = textBox_KitapAra.Text.Trim();
            listView_KitapListesi.Items.Clear();

            if (aramaMetni.Length < 2)
                return;

            try
            {
                var kitaplar = oduncKitapListe.Where(k =>
                    ContainsText(k.ISBN, aramaMetni) ||
                    ContainsText(k.KitapAdi, aramaMetni) ||
                    ContainsText(k.Yazar, aramaMetni))
                    .OrderByDescending(k => k.Stok > 0)
                    .ThenBy(k => k.KitapAdi)
                    .ToList();

                foreach (var kitap in kitaplar)
                {
                    var item = new ListViewItem(kitap.KitapAdi);
                    item.SubItems.Add(kitap.ISBN ?? string.Empty);
                    item.SubItems.Add(kitap.Yazar ?? string.Empty);
                    item.SubItems.Add(kitap.Stok.ToString());
                    item.Tag = kitap;

                    if (kitap.Stok <= 0)
                    {
                        item.BackColor = Color.MistyRose;
                        item.ForeColor = Color.DarkRed;
                    }

                    listView_KitapListesi.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_UyeAra_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = textBox_UyeAra.Text.Trim();
            listView_Uyeler.Items.Clear();

            if (string.IsNullOrWhiteSpace(aramaMetni))
            {
                _secilenUyeId = 0;
                label_AdSoyad.Text = "Seçili Öğrenci: -YOK-";
                UyeninAldigiKitaplarıListele();
                return;
            }

            var tamOkulNo = oduncUyeListe.FirstOrDefault(u =>
                string.Equals(u.OkulNo, aramaMetni, StringComparison.OrdinalIgnoreCase));

            if (tamOkulNo != null)
            {
                ListeyeOgrenciEkle(tamOkulNo);
                listView_Uyeler.Items[0].Selected = true;
                UyeSecimi(tamOkulNo);
                return;
            }

            if (aramaMetni.Length < 2)
                return;

            listView_Uyeler.BeginUpdate();
            foreach (var uye in oduncUyeListe.Where(u =>
                ContainsText(u.OkulNo, aramaMetni) ||
                ContainsText(u.TcPass, aramaMetni) ||
                ContainsText(u.Soyad, aramaMetni) ||
                ContainsText(u.Ad, aramaMetni) ||
                ContainsText(u.Sinif, aramaMetni) ||
                ContainsText(u.Sube, aramaMetni)))
            {
                ListeyeOgrenciEkle(uye);
            }
            listView_Uyeler.EndUpdate();
        }

        private void ListeyeOgrenciEkle(OduncUyeDto uye)
        {
            ListViewItem item = new ListViewItem(uye.OkulNo ?? "-");
            item.SubItems.Add(uye.Ad);
            item.SubItems.Add(uye.Soyad);
            item.SubItems.Add($"{uye.Sinif}/{uye.Sube}");
            item.SubItems.Add(uye.Telefon ?? string.Empty);
            item.Tag = uye;
            listView_Uyeler.Items.Add(item);
        }

        private void listView_Sepet_DoubleClick(object sender, EventArgs e)
        {
            if (listView_Sepet.SelectedItems.Count == 0)
                return;

            var secilenItem = listView_Sepet.SelectedItems[0];
            int kitapId = (int)secilenItem.Tag;
            var kitap = _sepetiKitaplar.FirstOrDefault(x => x.Id == kitapId);
            if (kitap == null)
                return;

            _sepetiKitaplar.Remove(kitap);
            SepetGuncelle();
        }
    }
}
