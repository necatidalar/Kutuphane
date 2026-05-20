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
    public partial class frmYazarIslemleri : Form
    {
        BindingList<YazarDto> bilYazar = new BindingList<YazarDto>();
        private List<YazarDto> _tumYazarlar = new();
        IYazarService yazarService = new YazarManager(new YazarDal());
        bool silinenModu = false;

        private readonly YetkiKontrol _yetkiKontrol;
        private readonly int _personelId;
        private HashSet<string> _userPermissions;

        public frmYazarIslemleri(int personelId)
        {
            InitializeComponent();
            _personelId = personelId;
            _yetkiKontrol = new YetkiKontrol(new KutuphaneDbContext());
            _userPermissions = _yetkiKontrol.KullaniciYetkileriniAl(_personelId);
            dataGrid_Yazar.DataSource = bilYazar;
        }
        private void frmYazarIslemleri_Load(object sender, EventArgs e)
        {
            dateTimePicker_DogumTarihi.ShowCheckBox = true;
            dateTimePicker_DogumTarihi.Checked = false;
            dateTimePicker_OlumTarihi.ShowCheckBox = true;
            dateTimePicker_OlumTarihi.Checked = false;

            YetkiKontrol();
            if (_userPermissions.Contains("YAZAR_LISTELE"))
            {
                YazarlariYukle();
                PasifKontrol();
            }
            KutulariTemizle();
            dataGrid_Yazar.ClearSelection();
            DataGridThemeManager.Apply(dataGrid_Yazar);
        }
        private void YetkiKontrol()
        {
            bool listele = _userPermissions.Contains("YAZAR_LISTELE");
            bool ekle = _userPermissions.Contains("YAZAR_EKLE");
            bool guncelle = _userPermissions.Contains("YAZAR_GUNCELLE");
            bool sil = _userPermissions.Contains("YAZAR_SIL");

            dataGrid_Yazar.Enabled = listele;
            btnKaydet.Visible = ekle;
            btnDuzenle.Visible = listele && guncelle;
            btnSil.Visible = listele && sil;

            btnSilinenleriGoster.Visible = false;
            btnGeriYukle.Visible = false;

            btnTemizle.Visible = ekle || guncelle;
            groupBox1.Visible = ekle || guncelle || sil;

            label_txtAra.Visible = listele;
            textBox_Ara.Visible = listele;
        }
        private void YazarlariYukle()
        {
            var result = yazarService.YazarListeGetirServis(x => x.AktifMi);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message);
                return;
            }

            _tumYazarlar = result.Data.ToList();

            bilYazar.Clear();
            foreach (var y in _tumYazarlar)
                bilYazar.Add(y);
        }
        private void Ara()
        {
            string arama = textBox_Ara.Text.Trim().ToLower();

            var filtreliListe = string.IsNullOrWhiteSpace(arama)
                ? _tumYazarlar
                : _tumYazarlar.Where(x =>
                    x.Ad.ToLower().Contains(arama) ||
                    x.Soyad.ToLower().Contains(arama)
                ).ToList();

            bilYazar.Clear();
            foreach (var y in filtreliListe)
                bilYazar.Add(y);
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Yazar yeniYazar = new Yazar
            {
                Ad = textBox_Ad.Text,
                Soyad = textBox_Soyad.Text,
                DogumTarihi = dateTimePicker_DogumTarihi.Checked
                    ? dateTimePicker_DogumTarihi.Value
                    : (DateTime?)null,

                OlumTarihi = dateTimePicker_OlumTarihi.Checked
                    ? dateTimePicker_OlumTarihi.Value
                    : (DateTime?)null,

                AktifMi = true
            };

            var yazarResult = yazarService.AddService(yeniYazar);

            if (yazarResult.IsSuccess)
            {
                MessageBox.Show("Yazar başarıyla kaydedildi.", "Başarılı");
                YazarlariYukle();
            }
            else
                MessageBox.Show(yazarResult.Message, "Hata");
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox_YazarId.Text, out int idResult);

            Yazar yeniYazar = new Yazar
            {
                YazarId = idResult,
                Ad = textBox_Ad.Text,
                Soyad = textBox_Soyad.Text,
                DogumTarihi = dateTimePicker_DogumTarihi.Checked
                    ? dateTimePicker_DogumTarihi.Value
                    : (DateTime?)null,

                OlumTarihi = dateTimePicker_OlumTarihi.Checked
                    ? dateTimePicker_OlumTarihi.Value
                    : (DateTime?)null,
                AktifMi = true
            };


            var yazarResult = yazarService.UpdateService(yeniYazar);

            if (yazarResult.IsSuccess)
            {
                MessageBox.Show("Yazar başarıyla güncellendi.", "Başarılı");
                YazarlariYukle();
            }
            else
                MessageBox.Show(yazarResult.Message, "Hata");
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_YazarId.Text, out int idResult))
            {
                MessageBox.Show("Lütfen geçerli bir yazar seçiniz.", "Hata");
                return;
            }

            var YazarFromDbResult = yazarService.GetByFilterService(x => x.YazarId == idResult);

            if (!YazarFromDbResult.IsSuccess || YazarFromDbResult.Data == null)
            {
                MessageBox.Show("Yazar bulunamadı.", "Hata");
                return;
            }

            var YazarFromDb = YazarFromDbResult.Data;
            YazarFromDb.AktifMi = false;

            var uyeResult = yazarService.UpdateService(YazarFromDb);

            if (uyeResult.IsSuccess)
            {
                MessageBox.Show("Yazar başarıyla silindi (pasif edildi).", "Başarılı");
                YazarlariYukle();
                PasifKontrol();
            }
            else
                MessageBox.Show(uyeResult.Message, "Hata");
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGrid_Yazar.ClearSelection();
            KutulariTemizle();
        }
        private void KutulariTemizle()
        {
            textBox_YazarId.Clear();
            textBox_Ad.Clear();
            textBox_Soyad.Clear();
            dateTimePicker_DogumTarihi.Value = DateTime.Today;
            dateTimePicker_OlumTarihi.Value = DateTime.Today;
            dateTimePicker_DogumTarihi.Checked = false;
            dateTimePicker_OlumTarihi.Checked = false;

            dataGrid_Yazar.ClearSelection();
        }
        private void PasifKontrol()
        {
            bool listele = _userPermissions.Contains("YAZAR_LISTELE");
            if (!listele)
            {
                btnSilinenleriGoster.Visible = false;
                return;
            }

            dataGrid_Yazar.ClearSelection();
            var pasifResult = yazarService.GetListByFilterService(x => x.AktifMi == false);

            bool silinmisVarMi = pasifResult.IsSuccess && pasifResult.Data.Any();
            btnSilinenleriGoster.Visible = silinmisVarMi;
        }
        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {
            if (!silinenModu)
            {
                var sonuc = yazarService.YazarListeGetirServis(x => x.AktifMi == false);

                if (!sonuc.IsSuccess || !sonuc.Data.Any())
                {
                    MessageBox.Show("Silinmiş yazar bulunamadı.", "Bilgi");
                    return;
                }

                bilYazar.Clear();
                foreach (var item in sonuc.Data)
                    bilYazar.Add(item);

                btnGeriYukle.Visible = true;
                btnKaydet.Enabled = false;
                btnDuzenle.Enabled = false;
                btnSil.Enabled = false;

                silinenModu = true;
                btnSilinenleriGoster.Text = "Aktif Yazarları Göster";
            }
            else
            {
                YazarlariYukle();
                btnGeriYukle.Visible = false;
                btnKaydet.Enabled = true;
                btnDuzenle.Enabled = true;
                btnSil.Enabled = true;

                silinenModu = false;
                btnSilinenleriGoster.Text = "🗑️ Silinenleri Göster";
            }

            dataGrid_Yazar.ClearSelection();
            KutulariTemizle();
        }
        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_YazarId.Text, out int id))
            {
                MessageBox.Show("Lütfen bir Yazar seçiniz.");
                return;
            }

            var yazarResult = yazarService.GetByFilterService(x => x.YazarId == id);

            if (!yazarResult.IsSuccess || yazarResult.Data == null)
            {
                MessageBox.Show("Yazar bulunamadı.");
                return;
            }

            var yazar = yazarResult.Data;
            yazar.AktifMi = true;

            var updateResult = yazarService.UpdateService(yazar);

            if (!updateResult.IsSuccess)
            {
                MessageBox.Show(updateResult.Message);
                return;
            }

            MessageBox.Show("Yazar başarıyla geri yüklendi.");

            YazarlariYukle();
            silinenModu = false;
            btnSilinenleriGoster.Text = "🗑️ Silinenleri Göster";
            btnGeriYukle.Visible = false;
            btnKaydet.Enabled = true;
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            PasifKontrol();
            KutulariTemizle();
            dataGrid_Yazar.ClearSelection();
        }
        private void dataGrid_Yazar_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid_Yazar.CurrentRow != null && !dataGrid_Yazar.CurrentRow.IsNewRow)
            {
                YazarDto row = (YazarDto)dataGrid_Yazar.CurrentRow.DataBoundItem;
                textBox_YazarId.Text = row.YazarId.ToString();
                textBox_Ad.Text = row.Ad;
                textBox_Soyad.Text = row.Soyad;

                if (row.DogumTarihi.HasValue)
                {
                    dateTimePicker_DogumTarihi.Checked = true;
                    dateTimePicker_DogumTarihi.Value = row.DogumTarihi.Value;
                }
                else
                {
                    dateTimePicker_DogumTarihi.Checked = false;
                }

                if (row.OlumTarihi.HasValue)
                {
                    dateTimePicker_OlumTarihi.Checked = true;
                    dateTimePicker_OlumTarihi.Value = row.OlumTarihi.Value;
                }
                else
                {
                    dateTimePicker_OlumTarihi.Checked = false;
                }

                return;
            }
            dataGrid_Yazar.ClearSelection();
            KutulariTemizle();
        }
        private void textBox_Ara_TextChanged(object sender, EventArgs e)
        {
            Ara();
        }
        private void comboBox_Sirala_SelectedIndexChanged(object sender, EventArgs e)
        {
            YazarlariYukle();
        }
        Dictionary<String, bool> sortDirections = new();
        private void dataGrid_Yazar_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridSortHelper.SortByColumn<YazarDto>(dataGrid_Yazar, bilYazar, e.ColumnIndex, sortDirections);
            dataGrid_Yazar.ClearSelection();
            KutulariTemizle();
        }
    }
}