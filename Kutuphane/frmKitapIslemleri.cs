using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using Kutuphane.UI.UIMetodlar;

namespace Kutuphane.UI
{
    public partial class frmKitapIslemleri : Form
    {
        private readonly IKitapService kitapService = new KitapManager(new KitapDal());
        private bool silinenModu = false;

        public frmKitapIslemleri()
        {
            InitializeComponent();
        }

        private void frmKitapIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
            ComboDoldur();
            dataGrid_Kitap.ClearSelection();
            dataGrid_Kitap.CurrentCell = null;
            Temizle();
            PasifKontrol();
        }
        private void ComboDoldur()
        {
            IYazarService yazarService = new YazarManager(new YazarDal());
            var yazarResult = yazarService.YazarListeGetirServis(x => x.AktifMi);
            if (yazarResult.IsSuccess)
                Metodlar.ComboDoldur(comboBox_Yazar, yazarResult.Data, "AdSoyad", "YazarId");

            IKategoriService kategoriService = new KategoriManager(new KategoriDal());
            var kategoriResult = kategoriService.GetListByFilterService(x => x.AktifMi);
            if (kategoriResult.IsSuccess)
                Metodlar.ComboDoldur(comboBox_Kategori, kategoriResult.Data, "KategoriAdi", "KategoriId");

            IYayineviService yayineviService = new YayineviManager(new YayineviDal());
            var yayineviResult = yayineviService.GetListByFilterService(x => x.AktifMi);
            if (yayineviResult.IsSuccess)
                Metodlar.ComboDoldur(comboBox_Yayinevi, yayineviResult.Data, "Ad", "YayineviId");

            IDilService dilService = new DilManager(new DilDal());
            var dilResult = dilService.GetListByFilterService();
            if (dilResult.IsSuccess)
                Metodlar.ComboDoldur(comboBox_Dil, dilResult.Data, "DilAdi", "DilId");
        }
        private void Listele(string? aramMetin = null)
        {
            dataGrid_Kitap.Rows.Clear();

            if (aramMetin != null)
            {
                // necoş sonra düzelt
            }

            var kitapResult = kitapService.KitapListeDetayliGetirServis(x => x.Aktif);

            if (!kitapResult.IsSuccess)
            {
                MessageBox.Show(kitapResult.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Metodlar.gridDoldur(kitapDtoBindingSource, kitapResult.Data);
            dataGrid_Kitap.ClearSelection();
            dataGrid_Kitap.CurrentCell = null;
            Temizle();
        }
        private Kitap KitapNesnesiniOlustur(int? kitapId = null)
        {
            return new Kitap
            {
                KitapId = kitapId ?? 0,
                ISBN = textBox_ISBN.Text,
                KitapAdi = textBox_KitapAdi.Text,
                YazarId = (int)comboBox_Yazar.SelectedValue,
                KategoriId = (int)comboBox_Kategori.SelectedValue,
                YayineviId = (int)comboBox_Yayinevi.SelectedValue,
                DilId = (short)comboBox_Dil.SelectedValue,
                BasimYili = string.IsNullOrWhiteSpace(textBox_BasimYili.Text) ? null : int.Parse(textBox_BasimYili.Text),
                SayfaSayisi = string.IsNullOrWhiteSpace(textBox_SayfaSayisi.Text) ? null : int.Parse(textBox_SayfaSayisi.Text),
                Stok = int.Parse(textBox_StokMiktari.Text),
                Aktif = true
            };
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var kitap = KitapNesnesiniOlustur();
            var result = kitapService.AddService(kitap);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Kitap başarıyla eklendi.", "Başarılı");
            Listele();
            Temizle();
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_KitapId.Text, out int idResult))
            {
                MessageBox.Show("Lütfen geçerli bir kitap seçiniz.", "Hata");
                return;
            }

            var kitap = KitapNesnesiniOlustur(idResult);
            var result = kitapService.UpdateService(kitap);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Kitap başarıyla güncellendi.", "Başarılı");
            Listele();
            Temizle();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_KitapId.Text, out int idResult))
            {
                MessageBox.Show("Lütfen geçerli bir kitap seçiniz.", "Hata");
                return;
            }

            var kitapFromDbResult = kitapService.GetByFilterService(x => x.KitapId == idResult);

            if (!kitapFromDbResult.IsSuccess || kitapFromDbResult.Data == null)
            {
                MessageBox.Show("Kitap bulunamadı.", "Hata");
                return;
            }

            var soru = MessageBox.Show("Bu kitabı silmek istediğine emin misin?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (soru == DialogResult.No)
                return;

            var kitapFromDb = kitapFromDbResult.Data;
            kitapFromDb.Aktif = false;

            var result = kitapService.UpdateService(kitapFromDb);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Kitap başarıyla silindi (pasif edildi).", "Başarılı");
            Listele();
            Temizle();
            PasifKontrol();
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
            dataGrid_Kitap.ClearSelection();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGrid_Kitap.ClearSelection();
            Temizle();
        }
        private void PasifKontrol()
        {
            dataGrid_Kitap.ClearSelection();
            var pasifResult = kitapService.GetListByFilterService(x => !x.Aktif);
            btnSilinenleriGoster.Visible = pasifResult.IsSuccess && pasifResult.Data?.Any() == true;
        }
        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {
            if (!silinenModu)
            {
                var sonuc = kitapService.KitapListeDetayliGetirServis(x => x.Aktif == false);
                dataGrid_Kitap.Rows.Clear();
                Metodlar.gridDoldur(kitapDtoBindingSource, sonuc.Data);
                btnGeriYukle.Visible = true;
                btnKaydet.Enabled = false;
                btnDuzenle.Enabled = false;
                btnSil.Enabled = false;
                silinenModu = true;
                btnSilinenleriGoster.Text = "Aktif Kitapları Göster";

            }
            else
            {
                Listele();
                btnGeriYukle.Visible = false;
                btnKaydet.Enabled = true;
                btnDuzenle.Enabled = true;
                btnSil.Enabled = true;
                silinenModu = false;
                btnSilinenleriGoster.Text = "🗑️ Silinenleri Göster";

            }
        }
        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_KitapId.Text, out int id))
            {
                MessageBox.Show("Lütfen bir kitap seçiniz.", "Hata");
                return;
            }

            var kitapResult = kitapService.GetByFilterService(x => x.KitapId == id);

            if (!kitapResult.IsSuccess || kitapResult.Data == null)
            {
                MessageBox.Show("Kitap bulunamadı.", "Hata");
                return;
            }

            var kitap = kitapResult.Data;
            kitap.Aktif = true;

            var updateResult = kitapService.UpdateService(kitap);

            if (!updateResult.IsSuccess)
            {
                MessageBox.Show(updateResult.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Kitap başarıyla geri yüklendi.", "Başarılı");
            Listele();
            silinenModu = false;
            btnSilinenleriGoster.Text = "🗑️ Silinenleri Göster";
            btnGeriYukle.Visible = false;
            btnKaydet.Enabled = true;
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            PasifKontrol();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
        private void dataGrid_Kitap_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid_Kitap.SelectedRows.Count > 0)
            {
                DataGridViewRow? selectedRow = dataGrid_Kitap.SelectedRows[0];
                if (selectedRow != null && !selectedRow.IsNewRow)
                {
                    KitapDto selectedKitap = (KitapDto)selectedRow.DataBoundItem;
                    textBox_KitapId.Text = selectedKitap.KitapId.ToString();
                    textBox_ISBN.Text = selectedKitap.ISBN;
                    textBox_KitapAdi.Text = selectedKitap.KitapAdi;
                    comboBox_Yazar.SelectedValue = selectedKitap.YazarId;
                    comboBox_Kategori.SelectedValue = selectedKitap.KategoriId;
                    comboBox_Yayinevi.SelectedValue = selectedKitap.YayineviId;
                    comboBox_Dil.SelectedValue = selectedKitap.DilId;
                    textBox_BasimYili.Text = selectedKitap.BasimYili?.ToString() ?? string.Empty;
                    textBox_SayfaSayisi.Text = selectedKitap.SayfaSayisi?.ToString() ?? string.Empty;
                    textBox_StokMiktari.Text = selectedKitap.Stok.ToString();
                }
            }
            //Doldurdum
        }
    }
}