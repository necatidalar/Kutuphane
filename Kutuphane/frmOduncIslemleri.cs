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
            UyeListViewDuzenle();

            dateTimePicker_TeslimTarihi.Value = DateTime.Now.AddDays(45);
        }
        private void UyeListViewDuzenle()
        {
            listView_Uyeler.View = View.Details;
            listView_Uyeler.GridLines = true;
            listView_Uyeler.FullRowSelect = true;

            listView_Uyeler.Columns.Clear();
            listView_Uyeler.Columns.Add("TC/Pass", 150);
            listView_Uyeler.Columns.Add("Ad", 170);
            listView_Uyeler.Columns.Add("Soyad", 170);
            listView_Uyeler.SelectedIndexChanged += listView_Uyeler_SelectedIndexChanged;
        }
        private void SepetListViewDuzenle()
        {
            listView_Sepet.Columns.Clear();
            listView_Sepet.Columns.Add("Kitap Adı", 250);
            listView_Sepet.Columns.Add("ISBN", 150);
            listView_Sepet.Columns.Add("Yazar", 250);
        }
        private void KitapListeListViewDuzenle()
        {
            listView_KitapListesi.Columns.Clear();
            listView_KitapListesi.Columns.Add("Kitap Adı", 250);
            listView_KitapListesi.Columns.Add("ISBN", 150);
            listView_KitapListesi.Columns.Add("Yazar", 250);
            listView_KitapListesi.DoubleClick += ListViewKitap_DoubleClick;
        }
        private void UyeninAldigiKitapListViewDuzenle()
        {
            listView_UyeninAldigiKitapListesi.Columns.Clear();
            listView_UyeninAldigiKitapListesi.Columns.Add("Kitap Adı", 200);
            listView_UyeninAldigiKitapListesi.Columns.Add("Alış Tarihi", 150);
            listView_UyeninAldigiKitapListesi.Columns.Add("Teslim Tarihi", 150);
            listView_UyeninAldigiKitapListesi.Columns.Add("Durum", 150);
        }
        private void UyeSecimi(Uye uye)
        {
            _secilenUyeId = uye.UyeId;
            label_AdSoyad.Text = $"Seçili Üye: {uye.Ad} {uye.Soyad}";
            UyeninAldigiKitaplarıListele();
        }
        private void listView_Uyeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Uyeler.SelectedItems.Count > 0)
            {
                ListViewItem secilenSatir = listView_Uyeler.SelectedItems[0];
                Uye secilenUye = (Uye)secilenSatir.Tag;
                UyeSecimi(secilenUye);
            }
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
        private void ListViewKitap_DoubleClick(object sender, EventArgs e)
        {
            if (listView_KitapListesi.SelectedItems.Count == 0)
                return;

            var secilenItem = listView_KitapListesi.SelectedItems[0];
            var kitap = secilenItem.Tag as KitapDto;

            if (kitap == null)
                return;

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
            if (dateTimePicker_TeslimTarihi.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Teslim tarihi bugünden önce olamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int basariSayisi = 0;
                int basarisizSayisi = 0;

                foreach (var kitap in _sepetiKitaplar)
                {
                    var kitapResult = _kitapManager.GetByFilterService(x => x.KitapId == kitap.KitapId);

                    if (!kitapResult.IsSuccess || kitapResult.Data == null || kitapResult.Data.Stok <= 0)
                    {
                        basarisizSayisi++;
                        continue;
                    }

                    var odunc = new Odunc
                    {
                        UyeId = _secilenUyeId,
                        KitapId = kitap.KitapId,
                        AlisTarihi = DateTime.Now,
                        //TeslimTarihi = DateTime.Now.AddDays(45),
                        TeslimTarihi = dateTimePicker_TeslimTarihi.Value.Date,
                        TeslimEdildi = false,
                        TeslimEdenPersonelId = _girisYapanPersonelId
                    };

                    var result = _oduncManager.AddService(odunc);

                    if (result.IsSuccess)
                    {
                        kitapResult.Data.Stok--;
                        _kitapManager.UpdateService(kitapResult.Data);

                        basariSayisi++;
                    }
                    else
                    {
                        basarisizSayisi++;
                    }
                }

                _sepetiKitaplar.Clear();
                SepetGuncelle();

                string mesaj = $"✅ {basariSayisi} kitap ödünç verildi.";
                if (basarisizSayisi > 0)
                    mesaj += $"\n❌ {basarisizSayisi} kitap stok yetersizliği veya hata nedeniyle verilemedi.";

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
            var seciliItemler = listView_UyeninAldigiKitapListesi.Items
                .Cast<ListViewItem>()
                .Where(x => x.Checked)
                .ToList();

            if (!seciliItemler.Any())
            {
                MessageBox.Show("Lütfen teslim alınacak kitapları işaretleyin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int basarili = 0;
                int basarisiz = 0;

                foreach (var item in seciliItemler)
                {
                    int oduncId = (int)item.Tag;

                    var oduncResult = _oduncManager.GetByFilterService(x => x.OduncId == oduncId);
                    if (!oduncResult.IsSuccess || oduncResult.Data == null || oduncResult.Data.TeslimEdildi)
                    {
                        basarisiz++;
                        continue;
                    }

                    var odunc = oduncResult.Data;
                    odunc.TeslimTarihi = DateTime.Now;
                    odunc.TeslimEdildi = true;
                    odunc.TeslimAlanPersonelId = _girisYapanPersonelId;

                    if (!_oduncManager.UpdateService(odunc).IsSuccess)
                    {
                        basarisiz++;
                        continue;
                    }

                    var kitapResult = _kitapManager.GetByFilterService(x => x.KitapId == odunc.KitapId);
                    if (kitapResult.IsSuccess && kitapResult.Data != null)
                    {
                        kitapResult.Data.Stok++;
                        _kitapManager.UpdateService(kitapResult.Data);
                    }

                    basarili++;
                }

                MessageBox.Show(
                    $"✅ {basarili} kitap teslim alındı.\n❌ {basarisiz} kitap teslim alınamadı.",
                    "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UyeninAldigiKitaplarıListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox_KitapAra_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = textBox_KitapAra.Text.Trim();

            try
            {
                var result = _kitapManager.KitapListeDetayliGetirServis(x =>
                    x.Aktif &&
                    x.Stok > 0 &&
                    (x.KitapAdi.Contains(aramaMetni) ||
                     x.ISBN.Contains(aramaMetni) ||
                     x.Yazar.Ad.Contains(aramaMetni) ||
                     x.Yazar.Soyad.Contains(aramaMetni))
                );

                listView_KitapListesi.Items.Clear();
                foreach (var kitap in result.Data)
                {
                    var item = new ListViewItem(kitap.KitapAdi);
                    item.SubItems.Add(kitap.ISBN ?? string.Empty);
                    item.SubItems.Add($"{kitap.YazarAd} {kitap.YazarSoyad}");
                    item.Tag = kitap;

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

            if (string.IsNullOrEmpty(aramaMetni)) return;

            var result = _uyeManager.GetListByFilterService(x =>
                x.AktifMi &&
                (x.TcPass.Contains(aramaMetni) ||
                 x.Ad.Contains(aramaMetni) ||
                 x.Soyad.Contains(aramaMetni))
            );

            if (result.IsSuccess && result.Data.Count > 0)
            {
                listView_Uyeler.BeginUpdate();
                foreach (var uye in result.Data)
                {
                    ListViewItem item = new ListViewItem(uye.TcPass);
                    item.SubItems.Add(uye.Ad);
                    item.SubItems.Add(uye.Soyad);
                    item.Tag = uye;

                    listView_Uyeler.Items.Add(item);
                }
                listView_Uyeler.EndUpdate();
            }
        }
        private void listView_Sepet_DoubleClick(object sender, EventArgs e)
        {
            if (listView_Sepet.SelectedItems.Count == 0)
                return;

            var secilenItem = listView_Sepet.SelectedItems[0];
            int kitapId = (int)secilenItem.Tag;

            var kitap = _sepetiKitaplar.FirstOrDefault(x => x.KitapId == kitapId);
            if (kitap == null)
                return;

            _sepetiKitaplar.Remove(kitap);
            SepetGuncelle();
        }
    }
}