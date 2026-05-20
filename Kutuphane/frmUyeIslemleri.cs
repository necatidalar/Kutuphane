using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.DAL.Contexes;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using Kutuphane.UI.UIMetodlar;
using System.ComponentModel;

namespace Kutuphane.UI
{
    public partial class frmUyeIslemleri : Form
    {
        private readonly BindingList<UyeDto> bilUyeDto = new();
        private List<UyeDto> _tumUyeler = new();
        private readonly IUyeService uyeService = new UyeManager(new UyeDal());
        private bool silinenModu = false;

        private readonly YetkiKontrol _yetkiKontrol;
        private readonly int _personelId;
        private readonly HashSet<string> _userPermissions;

        public frmUyeIslemleri(int personelId)
        {
            InitializeComponent();
            dataGrid_Uye.DataSource = bilUyeDto;
            _personelId = personelId;
            _yetkiKontrol = new YetkiKontrol(new KutuphaneDbContext());
            _userPermissions = _yetkiKontrol.KullaniciYetkileriniAl(_personelId);
        }

        private void frmUyeIslemleri_Load(object sender, EventArgs e)
        {
            YetkiKontrol();
            if (_userPermissions.Contains("UYE_LISTELE"))
            {
                UyeleriYukle();
                ComboDoldur();
                PasifKontrol();
            }
            DataGridThemeManager.Apply(dataGrid_Uye);
        }

        private void YetkiKontrol()
        {
            bool listele = _userPermissions.Contains("UYE_LISTELE");
            bool ekle = _userPermissions.Contains("UYE_EKLE");
            bool guncelle = _userPermissions.Contains("UYE_GUNCELLE");
            bool sil = _userPermissions.Contains("UYE_SIL");

            dataGrid_Uye.Enabled = listele;
            btnKaydet.Visible = ekle;
            btnDuzenle.Visible = listele && guncelle;
            btnSil.Visible = listele && sil;

            btnSilinenleriGoster.Visible = false;
            btnGeriYukle.Visible = false;

            btnTemizle.Visible = ekle || guncelle;
            groupBox1.Visible = ekle || guncelle || sil;

            label_txtAra.Visible = listele;
            textBox_Ara.Visible = listele;
            comboBox_Filtre.Visible = listele;
        }

        private void UyeleriYukle()
        {
            var result = uyeService.UyeListeDetayliGetirServis(x => x.AktifMi);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Hata");
                return;
            }

            _tumUyeler = result.Data.OrderBy(x => x.OkulNo).ThenBy(x => x.Ad).ToList();
            GridiDoldur(_tumUyeler);
        }

        private void GridiDoldur(IEnumerable<UyeDto> liste)
        {
            bilUyeDto.Clear();
            foreach (var uye in liste)
                bilUyeDto.Add(uye);
        }

        private static bool ContainsText(string? value, string search)
        {
            return !string.IsNullOrWhiteSpace(value) && value.Contains(search, StringComparison.OrdinalIgnoreCase);
        }

        private void Ara()
        {
            string arama = textBox_Ara.Text.Trim();

            var filtreliListe = string.IsNullOrWhiteSpace(arama)
                ? _tumUyeler
                : _tumUyeler.Where(x =>
                    ContainsText(x.OkulNo, arama) ||
                    ContainsText(x.Sinif, arama) ||
                    ContainsText(x.Sube, arama) ||
                    ContainsText(x.TcPass, arama) ||
                    ContainsText(x.Ad, arama) ||
                    ContainsText(x.Soyad, arama) ||
                    ContainsText(x.Adres, arama) ||
                    ContainsText(x.AdresDetay, arama) ||
                    ContainsText(x.Eposta, arama) ||
                    ContainsText(x.Telefon, arama) ||
                    ContainsText(x.VeliAdSoyad, arama) ||
                    ContainsText(x.VeliTelefon, arama)
                ).ToList();

            switch (comboBox_Filtre.SelectedItem?.ToString())
            {
                case "Erkek":
                    filtreliListe = filtreliListe.Where(x => x.Cinsiyet == "Erkek").ToList();
                    break;
                case "Kadın":
                    filtreliListe = filtreliListe.Where(x => x.Cinsiyet == "Kadın").ToList();
                    break;
                case "Belirtilmemiş":
                    filtreliListe = filtreliListe.Where(x => x.Cinsiyet == "Belirtilmemiş").ToList();
                    break;
            }

            GridiDoldur(filtreliListe);
        }

        private void ComboDoldur()
        {
            comboBox_Filtre.Items.Clear();
            comboBox_Filtre.Items.Add("Tümü");
            comboBox_Filtre.Items.Add("Erkek");
            comboBox_Filtre.Items.Add("Kadın");
            comboBox_Filtre.Items.Add("Belirtilmemiş");
            comboBox_Filtre.SelectedIndex = 0;

            ICinsiyetService cinsiyetService = new CinsiyetManager(new CinsiyetDal());
            var cinsiyetResult = cinsiyetService.GetListByFilterService();

            if (!cinsiyetResult.IsSuccess)
            {
                MessageBox.Show(cinsiyetResult.Message);
                return;
            }

            comboBox_Cinsiyet.DataSource = cinsiyetResult.Data;
            comboBox_Cinsiyet.DisplayMember = "CinsiyetAdi";
            comboBox_Cinsiyet.ValueMember = "Id";
            comboBox_Cinsiyet.SelectedIndex = -1;
        }

        private Uye FormdanUyeOlustur(int uyeId = 0, bool aktifMi = true)
        {
            string okulNo = textBox_OkulNo.Text.Trim();
            string tcPass = string.IsNullOrWhiteSpace(textBox_TcPass.Text) ? okulNo : textBox_TcPass.Text.Trim();

            return new Uye
            {
                UyeId = uyeId,
                OkulNo = okulNo,
                Sinif = textBox_Sinif.Text.Trim(),
                Sube = textBox_Sube.Text.Trim().ToUpper(),
                TcPass = tcPass,
                Ad = textBox_Ad.Text.Trim(),
                Soyad = textBox_Soyad.Text.Trim(),
                CinsiyetId = ((Cinsiyet)comboBox_Cinsiyet.SelectedItem).Id,
                Telefon = textBox_Telefon.Text.Trim(),
                Eposta = textBox_Eposta.Text.Trim(),
                VeliAdSoyad = textBox_VeliAdSoyad.Text.Trim(),
                VeliTelefon = textBox_VeliTelefon.Text.Trim(),
                Adres = textBox_Adres.Text.Trim(),
                AdresDetay = richTextBox_AdresDetay.Text.Trim(),
                DogumTarihi = dateTimePicker1.Value,
                AktifMi = aktifMi
            };
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!BoslukKontrol())
                return;

            var yeniOgrenci = FormdanUyeOlustur();
            var result = uyeService.AddService(yeniOgrenci);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Hata");
                return;
            }

            MessageBox.Show("Öğrenci başarıyla kaydedildi.");
            UyeleriYukle();
            KutulariTemizle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_UyeId.Text, out int id))
            {
                MessageBox.Show("Geçerli bir öğrenci seçiniz.");
                return;
            }

            if (!BoslukKontrol())
                return;

            var mevcut = uyeService.GetByFilterService(x => x.UyeId == id);
            bool aktifMi = mevcut.IsSuccess && mevcut.Data != null ? mevcut.Data.AktifMi : true;
            var ogrenci = FormdanUyeOlustur(id, aktifMi);
            var result = uyeService.UpdateService(ogrenci);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Hata");
                return;
            }

            MessageBox.Show("Öğrenci güncellendi.");
            UyeleriYukle();
            KutulariTemizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_UyeId.Text, out int idResult))
            {
                MessageBox.Show("Lütfen geçerli bir öğrenci seçiniz.", "Hata");
                return;
            }

            var uyeFromDbResult = uyeService.GetByFilterService(x => x.UyeId == idResult);

            if (!uyeFromDbResult.IsSuccess || uyeFromDbResult.Data == null)
            {
                MessageBox.Show("Öğrenci bulunamadı.", "Hata");
                return;
            }

            var soru = MessageBox.Show("Bu öğrenciyi pasif etmek istediğine emin misin?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.No)
                return;

            var uyeFromDb = uyeFromDbResult.Data;
            uyeFromDb.AktifMi = false;

            var uyeResult = uyeService.UpdateService(uyeFromDb);

            if (uyeResult.IsSuccess)
            {
                MessageBox.Show("Öğrenci başarıyla pasif edildi.", "Başarılı");
                UyeleriYukle();
                PasifKontrol();
            }
            else
            {
                MessageBox.Show(uyeResult.Message, "Hata");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGrid_Uye.ClearSelection();
            KutulariTemizle();
        }

        private void KutulariTemizle()
        {
            textBox_UyeId.Clear();
            textBox_OkulNo.Clear();
            textBox_Sinif.Clear();
            textBox_Sube.Clear();
            textBox_TcPass.Clear();
            textBox_Ad.Clear();
            textBox_Soyad.Clear();
            textBox_Telefon.Clear();
            textBox_Eposta.Clear();
            textBox_VeliAdSoyad.Clear();
            textBox_VeliTelefon.Clear();
            textBox_Adres.Clear();
            richTextBox_AdresDetay.Clear();
            comboBox_Cinsiyet.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void dataGrid_Uye_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid_Uye.CurrentRow != null && !dataGrid_Uye.CurrentRow.IsNewRow && dataGrid_Uye.CurrentRow.DataBoundItem is UyeDto row)
            {
                textBox_UyeId.Text = row.UyeId.ToString();
                textBox_OkulNo.Text = row.OkulNo ?? string.Empty;
                textBox_Sinif.Text = row.Sinif ?? string.Empty;
                textBox_Sube.Text = row.Sube ?? string.Empty;
                textBox_TcPass.Text = row.TcPass ?? string.Empty;
                textBox_Ad.Text = row.Ad;
                textBox_Soyad.Text = row.Soyad;
                comboBox_Cinsiyet.SelectedValue = row.CinsiyetId;
                textBox_Telefon.Text = row.Telefon;
                textBox_Eposta.Text = row.Eposta;
                textBox_VeliAdSoyad.Text = row.VeliAdSoyad ?? string.Empty;
                textBox_VeliTelefon.Text = row.VeliTelefon ?? string.Empty;
                textBox_Adres.Text = row.Adres;
                richTextBox_AdresDetay.Text = row.AdresDetay;
                dateTimePicker1.Value = row.DogumTarihi == default ? DateTime.Now : row.DogumTarihi;
                return;
            }

            KutulariTemizle();
        }

        private void PasifKontrol()
        {
            bool listele = _userPermissions.Contains("UYE_LISTELE");
            if (!listele)
            {
                btnSilinenleriGoster.Visible = false;
                return;
            }

            dataGrid_Uye.ClearSelection();
            var pasifResult = uyeService.GetListByFilterService(x => x.AktifMi == false);
            bool silinmisVarMi = pasifResult.IsSuccess && pasifResult.Data.Any();
            btnSilinenleriGoster.Visible = silinmisVarMi;
        }

        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {
            if (!silinenModu)
            {
                var sonuc = uyeService.UyeListeDetayliGetirServis(x => x.AktifMi == false);
                if (!sonuc.IsSuccess)
                {
                    MessageBox.Show(sonuc.Message, "Hata");
                    return;
                }

                GridiDoldur(sonuc.Data);
                btnGeriYukle.Visible = true;
                btnKaydet.Enabled = false;
                btnDuzenle.Enabled = false;
                btnSil.Enabled = false;
                silinenModu = true;
                btnSilinenleriGoster.Text = "Aktif Öğrencileri Göster";
            }
            else
            {
                UyeleriYukle();
                btnGeriYukle.Visible = false;
                btnKaydet.Enabled = true;
                btnDuzenle.Enabled = true;
                btnSil.Enabled = true;
                silinenModu = false;
                btnSilinenleriGoster.Text = "🗑️ Pasif Öğrencileri Göster";
            }

            dataGrid_Uye.ClearSelection();
            KutulariTemizle();
        }

        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_UyeId.Text, out int id))
            {
                MessageBox.Show("Lütfen bir öğrenci seçiniz.");
                return;
            }

            var uyeResult = uyeService.GetByFilterService(x => x.UyeId == id);

            if (!uyeResult.IsSuccess || uyeResult.Data == null)
            {
                MessageBox.Show("Öğrenci bulunamadı.");
                return;
            }

            var uye = uyeResult.Data;
            uye.AktifMi = true;

            var updateResult = uyeService.UpdateService(uye);

            if (!updateResult.IsSuccess)
            {
                MessageBox.Show(updateResult.Message);
                return;
            }

            MessageBox.Show("Öğrenci başarıyla geri yüklendi.");
            UyeleriYukle();
            silinenModu = false;
            btnSilinenleriGoster.Text = "🗑️ Pasif Öğrencileri Göster";
            btnGeriYukle.Visible = false;
            btnKaydet.Enabled = true;
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            PasifKontrol();
        }

        private bool BoslukKontrol()
        {
            if (string.IsNullOrWhiteSpace(textBox_OkulNo.Text))
            {
                MessageBox.Show("Okul numarası boş bırakılamaz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_Ad.Text))
            {
                MessageBox.Show("Ad boş bırakılamaz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_Soyad.Text))
            {
                MessageBox.Show("Soyad boş bırakılamaz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_Sinif.Text))
            {
                MessageBox.Show("Sınıf boş bırakılamaz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_Sube.Text))
            {
                MessageBox.Show("Şube boş bırakılamaz.");
                return false;
            }
            if (comboBox_Cinsiyet.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir cinsiyet seçiniz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_Telefon.Text))
            {
                MessageBox.Show("Telefon boş bırakılamaz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_Eposta.Text))
            {
                MessageBox.Show("E-posta boş bırakılamaz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_VeliAdSoyad.Text))
            {
                MessageBox.Show("Veli adı soyadı boş bırakılamaz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_VeliTelefon.Text))
            {
                MessageBox.Show("Veli telefonu boş bırakılamaz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_Adres.Text))
            {
                MessageBox.Show("Adres boş bırakılamaz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(richTextBox_AdresDetay.Text))
            {
                MessageBox.Show("Adres detay boş bırakılamaz.");
                return false;
            }
            return true;
        }

        private void textBox_Ara_TextChanged(object sender, EventArgs e)
        {
            Ara();
        }

        private void comboBox_Filtre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ara();
        }

        private void dataGrid_Uye_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Ara.Text) || e.Value == null)
                return;

            string aranan = textBox_Ara.Text.ToLower();
            string hucreMetni = e.Value.ToString()?.ToLower() ?? string.Empty;

            if (hucreMetni.Contains(aranan))
            {
                e.CellStyle.BackColor = Color.Yellow;
                e.CellStyle.ForeColor = Color.Black;
            }
        }

        private void dataGrid_Uye_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Hücre biçimlendirme DataGrid temasını bozmasın diye vurgulama CellFormatting üzerinden tutuldu.
        }

        private readonly Dictionary<string, bool> sortDirections = new();
        private void dataGrid_Uye_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridSortHelper.SortByColumn<UyeDto>(dataGrid_Uye, bilUyeDto, e.ColumnIndex, sortDirections);
            dataGrid_Uye.ClearSelection();
            KutulariTemizle();
        }
    }
}
