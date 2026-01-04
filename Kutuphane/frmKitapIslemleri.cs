using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.DAL.Contexes;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using Kutuphane.UI.Theme;
using Kutuphane.UI.UIMetodlar;
using System.ComponentModel;
using static Kutuphane.UI.frmMain;

namespace Kutuphane.UI
{
    public partial class frmKitapIslemleri : Form
    {
        private readonly IKitapService kitapService = new KitapManager(new KitapDal());
        private bool silinenModu = false;

        private readonly YetkiKontrol _yetkiKontrol;
        private readonly int _personelId;
        private HashSet<string> _userPermissions;
        public frmKitapIslemleri(int personelId)
        {
            InitializeComponent();
            _personelId = personelId;
            _yetkiKontrol = new YetkiKontrol(new KutuphaneDbContext());
            _userPermissions = _yetkiKontrol.KullaniciYetkileriniAl(_personelId);
        }
        private void frmKitapIslemleri_Load(object sender, EventArgs e)
        {
            YetkiKontrol();
            if (_userPermissions.Contains("KITAP_LISTELE"))
            {
                Listele();
                PasifKontrol();
            }
            ComboDoldur();
            Temizle();
            DataGridThemeManager.Apply(dataGrid_Kitap);
        }
        private void YetkiKontrol()
        {
            bool listele = _userPermissions.Contains("KITAP_LISTELE");
            bool ekle = _userPermissions.Contains("KITAP_EKLE");
            bool guncelle = _userPermissions.Contains("KITAP_GUNCELLE");
            bool sil = _userPermissions.Contains("KITAP_SIL");

            dataGrid_Kitap.Enabled = listele;
            btnKaydet.Visible = ekle;
            btnDuzenle.Visible = listele && guncelle;
            btnSil.Visible = listele && sil;

            btnSilinenleriGoster.Visible = listele;
            btnGeriYukle.Visible = listele && sil;

            btnTemizle.Visible = ekle || guncelle;
            groupBox1.Visible = ekle || guncelle || sil;

            label_txtAra.Visible = listele;
            textBox_Ara.Visible = listele;
        }
        private void Listele(string? aramaMetni = null)
        {
            dataGrid_Kitap.Rows.Clear();

            aramaMetni ??= textBox_Ara.Text.Trim();

            var kitapResult = kitapService.KitapListeDetayliGetirServis(x => x.Aktif);

            if (!kitapResult.IsSuccess)
            {
                MessageBox.Show(kitapResult.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var liste = kitapResult.Data;

            if (!string.IsNullOrWhiteSpace(aramaMetni))
            {
                aramaMetni = aramaMetni.ToLower();

                liste = liste.Where(x =>
                     x.KitapAdi.ToLower().Contains(aramaMetni) ||
                     x.ISBN.ToLower().Contains(aramaMetni) ||
                     x.YazarAd.ToLower().Contains(aramaMetni) ||
                     x.YazarSoyad.ToLower().Contains(aramaMetni) ||
                     x.KategoriAdi.ToLower().Contains(aramaMetni) ||
                     x.YayineviAd.ToLower().Contains(aramaMetni) ||
                     (x.BasimYili.HasValue &&
                      x.BasimYili.Value.ToString().Contains(aramaMetni)) ||
                     x.Dil.ToLower().Contains(aramaMetni)
                ).ToList();

            }

            Metodlar.gridDoldur(kitapDtoBindingSource, liste);

            dataGrid_Kitap.ClearSelection();
            dataGrid_Kitap.CurrentCell = null;
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
            bool listele = _userPermissions.Contains("KITAP_LISTELE");
            if (!listele)
            {
                btnSilinenleriGoster.Visible = false;
                return;
            }
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
        private void dataGrid_Kitap_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (string.IsNullOrWhiteSpace(textBox_Ara.Text))
                return;

            if (e.Value == null)
                return;

            string hucreMetni = e.Value.ToString();
            string aranan = textBox_Ara.Text;

            int index = hucreMetni.IndexOf(aranan, StringComparison.OrdinalIgnoreCase);
            if (index < 0)
                return;

            e.Handled = true;

            e.PaintBackground(e.ClipBounds, true);

            Font font = e.CellStyle.Font;
            Color normalRenk = e.CellStyle.ForeColor;
            Color bulunanRenk = Color.DarkRed;

            string once = hucreMetni.Substring(0, index);
            string bulunan = hucreMetni.Substring(index, aranan.Length);
            string sonra = hucreMetni.Substring(index + aranan.Length);

            float x = e.CellBounds.X + 2;
            float y = e.CellBounds.Y + 4;

            using (Brush normalBrush = new SolidBrush(normalRenk))
            using (Brush bulunanBrush = new SolidBrush(bulunanRenk))
            {
                // önceki metin
                e.Graphics.DrawString(once, font, normalBrush, x, y);
                x += e.Graphics.MeasureString(once, font).Width;

                // bulunan metin
                e.Graphics.DrawString(bulunan, font, bulunanBrush, x, y);
                x += e.Graphics.MeasureString(bulunan, font).Width;

                // sonrası
                e.Graphics.DrawString(sonra, font, normalBrush, x, y);
            }

            e.Paint(e.ClipBounds, DataGridViewPaintParts.Border);
        }
        private void textBox_Ara_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }
        Dictionary<string, bool> sortDirections = new();
        private void dataGrid_Kitap_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (kitapDtoBindingSource.DataSource is BindingList<KitapDto> bindingList)
            {
                DataGridSortHelper.SortByColumn<KitapDto>(dataGrid_Kitap, bindingList, e.ColumnIndex, sortDirections);
            }
            dataGrid_Kitap.ClearSelection();
            Temizle();
        }
        private void dataGrid_Kitap_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Ara.Text))
                return;

            if (e.Value != null)
            {
                string aranan = textBox_Ara.Text.ToLower();
                string hucreMetni = e.Value.ToString().ToLower();

                if (hucreMetni.Contains(aranan))
                {
                    e.CellStyle.BackColor = Color.Yellow;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else
                {
                    e.CellStyle.BackColor = Color.White;
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}