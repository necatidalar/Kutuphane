using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;

namespace Kutuphane.UI
{
    public partial class frmOduncIslemleri : Form
    {
        private readonly UyeManager _uyeManager;
        private readonly KitapManager _kitapManager;
        private readonly OduncManager _oduncManager;

        private int _secilenUyeId = 0;
        private int _girisYapanPersonelId = 0;
        private List<KitapDto> _sepetiKitaplar = new();


        public int GirisYapanPersonelId
        {
            get => _girisYapanPersonelId;
            set => _girisYapanPersonelId = value;
        }

        public frmOduncIslemleri()
        {
            InitializeComponent();
            _uyeManager = new UyeManager(new UyeDal());
            _kitapManager = new KitapManager(new KitapDal());
            _oduncManager = new OduncManager(new OduncDal());
        }

        private void frmOduncIslemleri_Load(object sender, EventArgs e)
        {
            SepetListViewDuzenle();
            KitapListeListViewDuzenle();
            UyeninAldigiKitapListViewDuzenle();
        }

        private void SepetListViewDuzenle()
        {
            listView_Sepet.Columns.Clear();
            listView_Sepet.Columns.Add("Kitap Adı", 200);
            listView_Sepet.Columns.Add("ISBN", 100);
            listView_Sepet.Columns.Add("Yazar", 150);
        }

        private void KitapListeListViewDuzenle()
        {
            listView_KitapListesi.Columns.Clear();
            listView_KitapListesi.Columns.Add("Kitap Adı", 180);
            listView_KitapListesi.Columns.Add("ISBN", 110);
            listView_KitapListesi.Columns.Add("Yazar", 110);
            listView_KitapListesi.DoubleClick += ListViewKitap_DoubleClick;
        }

        private void UyeninAldigiKitapListViewDuzenle()
        {
            listView_UyeninAldigiKitapListesi.Columns.Clear();
            listView_UyeninAldigiKitapListesi.Columns.Add("Kitap Adı", 180);
            listView_UyeninAldigiKitapListesi.Columns.Add("Alış Tarihi", 120);
            listView_UyeninAldigiKitapListesi.Columns.Add("Teslim Tarihi", 120);
            listView_UyeninAldigiKitapListesi.Columns.Add("Durum", 120);
        }

        private void button_UyeAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = textBox_UyeAra.Text.Trim();

            if (string.IsNullOrWhiteSpace(aramaMetni))
            {
                MessageBox.Show("Lütfen arama metni girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var result = _uyeManager.GetListByFilterService(x =>
                    x.AktifMi &&
                    (x.TcPass.Contains(aramaMetni) ||
                     x.Ad.Contains(aramaMetni) ||
                     x.Soyad.Contains(aramaMetni))
                );

                if (!result.IsSuccess || result.Data.Count == 0)
                {
                    MessageBox.Show("Üye bulunamadı.", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _secilenUyeId = 0;
                    label_AdSoyad.Text = "Seçili Üye: YOK";
                    label_ToplamAlinanKitapSayisi.Text = "Toplam Alınan: 0 | Şu an Ödünçte: 0";
                    listView_UyeninAldigiKitapListesi.Items.Clear();
                    return;
                }

                if (result.Data.Count == 1)
                {
                    UyeSecimi(result.Data[0]);
                }
                else
                {
                    UyeSecimi(result.Data[0]);
                    MessageBox.Show($"{result.Data.Count} üye bulundu. İlki seçildi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UyeSecimi(Uye uye)
        {
            _secilenUyeId = uye.UyeId;
            label_AdSoyad.Text = $"Seçili Üye: {uye.Ad} {uye.Soyad}";
            UyeninAldigiKitaplarıListele();
        }

        private void UyeninAldigiKitaplarıListele()
        {
            try
            {
                listView_UyeninAldigiKitapListesi.Items.Clear();

                var result = _oduncManager.OduncBilgileriGetirServis(x => x.UyeId == _secilenUyeId);

                if (!result.IsSuccess)
                {
                    MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int toplamKitap = result.Data.Count;
                int oduncteOlanlar = result.Data.Count(x => x.TeslimEdildi == false);

                label_ToplamAlinanKitapSayisi.Text = $"Toplam Alınan: {toplamKitap}";
                label_SuanOduncteKitapSayisi.Text = $"Şu an Ödünçte: {oduncteOlanlar}";

                foreach (var odunc in result.Data)
                {
                    var item = new ListViewItem(odunc.KitapAdi);
                    item.SubItems.Add(odunc.AlisTarihi.ToString("dd.MM.yyyy"));
                    item.SubItems.Add(odunc.TeslimTarihi?.ToString("dd.MM.yyyy") ?? "Teslim Edilmedi");
                    item.SubItems.Add(odunc.TeslimEdildi ? "✅ Teslim Edildi" : "⏳ Ödünçte");
                    item.Tag = odunc.OduncId;

                    listView_UyeninAldigiKitapListesi.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_KitapAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = textBox_KitapAra.Text.Trim();

            if (string.IsNullOrWhiteSpace(aramaMetni))
            {
                MessageBox.Show("Lütfen arama metni girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var result = _kitapManager.KitapListeDetayliGetirServis(x =>
                    x.Aktif &&
                    x.Stok > 0 &&
                    (x.KitapAdi.Contains(aramaMetni) ||
                     x.ISBN.Contains(aramaMetni))
                );

                if (!result.IsSuccess || result.Data.Count == 0)
                {
                    MessageBox.Show("Kitap bulunamadı veya stok tükendi.", "Sonuç",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listView_KitapListesi.Items.Clear();
                    return;
                }

                listView_KitapListesi.Items.Clear();
                foreach (var kitap in result.Data)
                {
                    var item = new ListViewItem(kitap.KitapAdi);
                    item.SubItems.Add(kitap.ISBN ?? string.Empty);
                    item.SubItems.Add($"{kitap.YazarAd} {kitap.YazarSoyad}");
                    item.Tag = kitap;

                    listView_KitapListesi.Items.Add(item);
                }

                MessageBox.Show($"Ekrana {result.Data.Count} kitap yüklendi. Çift tıkla ile sepete ekleyin.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            var kitap = secilenItem.Tag as KitapDto;

            if (kitap == null)
                return;

            if (_sepetiKitaplar.Any(k => k.KitapId == kitap.KitapId))
            {
                MessageBox.Show("Bu kitap zaten sepette bulunuyor.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
                item.SubItems.Add($"{kitap.YazarAd} {kitap.YazarSoyad}");
                item.Tag = kitap.KitapId;

                listView_Sepet.Items.Add(item);
            }
        }
        private void button_OduncVer_Click(object sender, EventArgs e)
        {
            if (_secilenUyeId == 0)
            {
                MessageBox.Show("Lütfen bir üye seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_sepetiKitaplar.Count == 0)
            {
                MessageBox.Show("Lütfen sepete kitap ekleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_girisYapanPersonelId <= 0)
            {
                MessageBox.Show("Sistem hatası: Giriş yapan personel bilgisi bulunamadı.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int basariSayisi = 0;
                int basarısızSayisi = 0;

                foreach (var kitap in _sepetiKitaplar)
                {
                    var odunc = new Odunc
                    {
                        UyeId = _secilenUyeId,
                        KitapId = kitap.KitapId,
                        AlisTarihi = DateTime.Now,
                        TeslimTarihi = DateTime.Now.AddDays(45),
                        TeslimEdildi = false,
                        TeslimEdenPersonelId = _girisYapanPersonelId
                    };

                    var result = _oduncManager.AddService(odunc);
                    if (result.IsSuccess)
                    {
                        var kitapResult = _kitapManager.GetByFilterService(x => x.KitapId == kitap.KitapId);
                        if (kitapResult.IsSuccess && kitapResult.Data != null)
                        {
                            kitapResult.Data.Stok--;
                            _kitapManager.UpdateService(kitapResult.Data);
                        }

                        basariSayisi++;
                    }
                    else
                    {
                        basarısızSayisi++;
                    }
                }

                _sepetiKitaplar.Clear();
                SepetGuncelle();

                string mesaj = $"✅ {basariSayisi} kitap ödünç verildi.";
                if (basarısızSayisi > 0)
                    mesaj += $"\n❌ {basarısızSayisi} kitap ödünç verilemedi.";

                MessageBox.Show(mesaj, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UyeninAldigiKitaplarıListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_IadeAl_Click(object sender, EventArgs e)
        {
            if (listView_UyeninAldigiKitapListesi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen teslim alınacak bir kitap seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_girisYapanPersonelId <= 0)
            {
                MessageBox.Show("Sistem hatası: Giriş yapan personel bilgisi bulunamadı.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var secilenItem = listView_UyeninAldigiKitapListesi.SelectedItems[0];
                int oduncId = (int)secilenItem.Tag;

                var oduncResult = _oduncManager.GetByFilterService(x => x.OduncId == oduncId);
                if (!oduncResult.IsSuccess || oduncResult.Data == null)
                {
                    MessageBox.Show("Ödünç kaydı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var odunc = oduncResult.Data;

                if (odunc.TeslimEdildi)
                {
                    MessageBox.Show("Bu kitap zaten teslim alınmış.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                odunc.TeslimTarihi = DateTime.Now;
                odunc.TeslimEdildi = true;
                odunc.TeslimAlanPersonelId = _girisYapanPersonelId;

                var result = _oduncManager.UpdateService(odunc);

                if (!result.IsSuccess)
                {
                    MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var kitapResult = _kitapManager.GetByFilterService(x => x.KitapId == odunc.KitapId);
                if (kitapResult.IsSuccess && kitapResult.Data != null)
                {
                    kitapResult.Data.Stok++;
                    _kitapManager.UpdateService(kitapResult.Data);
                }

                MessageBox.Show("✅ Kitap başarıyla teslim alındı.", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                UyeninAldigiKitaplarıListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
