using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.DAL.Contexes;
using Kutuphane.Model.Entity;
using Kutuphane.UI.Theme;
using Kutuphane.UI.UIMetodlar;
using System.ComponentModel;

namespace Kutuphane.UI
{
    public partial class frmYayineviIslemleri : Form
    {
        BindingList<Yayinevi> bilYayinevi = new BindingList<Yayinevi>();
        private List<Yayinevi> _tumYayinevleri = new();
        IYayineviService yayineviService = new YayineviManager(new YayineviDal());
        bool silinenModu = false;

        private readonly YetkiKontrol _yetkiKontrol;
        private readonly int _personelId;
        private HashSet<string> _userPermissions;
        public frmYayineviIslemleri(int personelId)
        {
            InitializeComponent();
            _personelId = personelId;
            _yetkiKontrol = new YetkiKontrol(new KutuphaneDbContext());
            _userPermissions = _yetkiKontrol.KullaniciYetkileriniAl(_personelId);
        }
        private void frmYayineviIslemleri_Load(object sender, EventArgs e)
        {
            dataGrid_Yayinevi.DataSource = bilYayinevi;
            YetkiKontrol();
            if (_userPermissions.Contains("YAYINEVI_LISTELE"))
            {
                YayinevleriniYukle();
                PasifKontrol();
            }
            DataGridThemeManager.Apply(dataGrid_Yayinevi);
        }
        private void YetkiKontrol()
        {
            bool listele = _userPermissions.Contains("YAYINEVI_LISTELE");
            bool ekle = _userPermissions.Contains("YAYINEVI_EKLE");
            bool guncelle = _userPermissions.Contains("YAYINEVI_GUNCELLE");
            bool sil = _userPermissions.Contains("YAYINEVI_SIL");

            dataGrid_Yayinevi.Enabled = listele;
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
        private void YayinevleriniYukle()
        {
            var result = yayineviService.GetListByFilterService(x => x.AktifMi);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Hata");
                return;
            }

            _tumYayinevleri = result.Data.ToList();

            bilYayinevi.Clear();
            foreach (var y in _tumYayinevleri)
                bilYayinevi.Add(y);
        }
        private void Ara()
        {
            string arama = textBox_Ara.Text.Trim().ToLower();

            var filtreliListe = string.IsNullOrWhiteSpace(arama)
                ? _tumYayinevleri
                : _tumYayinevleri.Where(x =>
                    x.Ad.ToLower().Contains(arama) ||
                    (x.KurulusYili != null && x.KurulusYili.ToString().Contains(arama))
                ).ToList();

            bilYayinevi.Clear();
            foreach (var y in filtreliListe)
                bilYayinevi.Add(y);
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Yayinevi yeniYayinevi = new Yayinevi
            {
                Ad = textBox_YayineviAdi.Text.Trim(),
                KurulusYili = string.IsNullOrWhiteSpace(textBox_KurulusYili.Text) ? null : int.Parse(textBox_KurulusYili.Text),
                AktifMi = true
            };

            var result = yayineviService.AddService(yeniYayinevi);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Hata");
                return;
            }

            MessageBox.Show("Yayınevi başarıyla kaydedildi.", "Başarılı");
            YayinevleriniYukle();
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox_YayineviId.Text, out int idResult);

            Yayinevi yeniYayinevi = new Yayinevi
            {
                YayineviId = idResult,
                Ad = textBox_YayineviAdi.Text.Trim(),
                KurulusYili = string.IsNullOrWhiteSpace(textBox_KurulusYili.Text) ? null : int.Parse(textBox_KurulusYili.Text),
                AktifMi = true
            };

            var YayineviResult = yayineviService.UpdateService(yeniYayinevi);

            if (!YayineviResult.IsSuccess)
            {
                MessageBox.Show(YayineviResult.Message, "Hata");
                return;
            }

            MessageBox.Show("Yayınevi başarıyla güncellendi.", "Başarılı");
            YayinevleriniYukle();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_YayineviId.Text, out int idResult))
            {
                MessageBox.Show("Lütfen geçerli bir Yayınevi seçiniz.", "Hata");
                return;
            }

            var YayineviFromDbResult = yayineviService.GetByFilterService(x => x.YayineviId == idResult);

            if (!YayineviFromDbResult.IsSuccess || YayineviFromDbResult.Data == null)
            {
                MessageBox.Show("Yayınevi bulunamadı.", "Hata");
                return;
            }

            var YayineviFromDb = YayineviFromDbResult.Data;
            YayineviFromDb.AktifMi = false;

            var uyeResult = yayineviService.UpdateService(YayineviFromDb);

            if (uyeResult.IsSuccess)
            {
                MessageBox.Show("Yayınevi başarıyla silindi (pasif edildi).", "Başarılı");
                YayinevleriniYukle();
                PasifKontrol();
            }
            else
                MessageBox.Show(uyeResult.Message, "Hata");
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGrid_Yayinevi.ClearSelection();
            KutulariTemizle();
        }
        private void KutulariTemizle()
        {
            textBox_YayineviId.Clear();
            textBox_YayineviAdi.Clear();
            textBox_KurulusYili.Clear();
            dataGrid_Yayinevi.ClearSelection();
        }
        private void PasifKontrol()
        {
            bool listele = _userPermissions.Contains("YAYINEVI_LISTELE");
            if (!listele)
            {
                btnSilinenleriGoster.Visible = false;
                return;
            }

            dataGrid_Yayinevi.ClearSelection();
            var pasifResult = yayineviService.GetListByFilterService(x => x.AktifMi == false);

            bool silinmisVarMi = pasifResult.IsSuccess && pasifResult.Data.Any();
            btnSilinenleriGoster.Visible = silinmisVarMi;
        }
        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {
            if (!silinenModu)
            {
                var sonuc = yayineviService.GetListByFilterService(x => x.AktifMi == false);

                bilYayinevi.Clear();
                foreach (var item in sonuc.Data)
                    bilYayinevi.Add(item);

                btnGeriYukle.Visible = true;
                btnKaydet.Enabled = false;
                btnDuzenle.Enabled = false;
                btnSil.Enabled = false;

                silinenModu = true;
                btnSilinenleriGoster.Text = "Aktif Yayınevlerini Göster";
            }
            else
            {
                YayinevleriniYukle();

                btnGeriYukle.Visible = false;
                btnKaydet.Enabled = true;
                btnDuzenle.Enabled = true;
                btnSil.Enabled = true;

                silinenModu = false;
                btnSilinenleriGoster.Text = "🗑️ Silinenleri Göster";
            }

            dataGrid_Yayinevi.ClearSelection();
            KutulariTemizle();
        }
        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_YayineviId.Text, out int id))
            {
                MessageBox.Show("Lütfen bir Yayınevi seçiniz.");
                return;
            }

            var YayineviResult = yayineviService.GetByFilterService(x => x.YayineviId == id);

            if (!YayineviResult.IsSuccess || YayineviResult.Data == null)
            {
                MessageBox.Show("Yayınevi bulunamadı.");
                return;
            }

            var yayinevi = YayineviResult.Data;
            yayinevi.AktifMi = true;

            var updateResult = yayineviService.UpdateService(yayinevi);

            if (!updateResult.IsSuccess)
            {
                MessageBox.Show(updateResult.Message);
                return;
            }

            MessageBox.Show("Yayınevi başarıyla geri yüklendi.");
            YayinevleriniYukle();
            silinenModu = false;
            btnSilinenleriGoster.Text = "🗑️ Silinenleri Göster";
            btnGeriYukle.Visible = false;
            btnKaydet.Enabled = true;
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            PasifKontrol();
            KutulariTemizle();
            dataGrid_Yayinevi.ClearSelection();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            YayinevleriniYukle();
            dataGrid_Yayinevi.ClearSelection();
        }
        private void dataGrid_Yayinevi_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid_Yayinevi.CurrentRow != null && !dataGrid_Yayinevi.CurrentRow.IsNewRow)
            {
                Yayinevi row = (Yayinevi)dataGrid_Yayinevi.CurrentRow.DataBoundItem;
                textBox_YayineviId.Text = row.YayineviId.ToString();
                textBox_YayineviAdi.Text = row.Ad;
                textBox_KurulusYili.Text = row.KurulusYili?.ToString() ?? string.Empty;
                return;
            }
            dataGrid_Yayinevi.ClearSelection();
            KutulariTemizle();
        }
        private void textBox_Ara_TextChanged(object sender, EventArgs e)
        {
            Ara();
        }
        Dictionary<string, bool> sortDirections = new();
        private void dataGrid_Yayinevi_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridSortHelper.SortByColumn<Yayinevi>(dataGrid_Yayinevi, bilYayinevi, e.ColumnIndex, sortDirections);
            dataGrid_Yayinevi.ClearSelection();
            KutulariTemizle();
        }
    }
}