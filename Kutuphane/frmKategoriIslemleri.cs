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
    public partial class frmKategoriIslemleri : Form
    {

        BindingList<Kategori> bilKategori = new BindingList<Kategori>();
        IKategoriService kategoriService = new KategoriManager(new KategoriDal());
        bool silinenModu = false;

        private readonly YetkiKontrol _yetkiKontrol;
        private readonly int _personelId;
        private HashSet<string> _userPermissions;
        public frmKategoriIslemleri(int personelId)
        {
            InitializeComponent();
            _personelId = personelId;
            _yetkiKontrol = new YetkiKontrol(new KutuphaneDbContext());
            _userPermissions = _yetkiKontrol.KullaniciYetkileriniAl(_personelId);

            dataGrid_Kategori.DataSource = bilKategori;
        }
        private void frmKategori_Load(object sender, EventArgs e)
        {
            YetkiKontrol();
            if (_userPermissions.Contains("KATEGORI_LISTELE"))
            {
                Listele();
                PasifKontrol();
            }
            KutulariTemizle();
            DataGridThemeManager.Apply(dataGrid_Kategori);
            dataGrid_Kategori.ClearSelection();
        }
        private void YetkiKontrol()
        {
            bool listele = _userPermissions.Contains("KATEGORI_LISTELE");
            bool ekle = _userPermissions.Contains("KATEGORI_EKLE");
            bool guncelle = _userPermissions.Contains("KATEGORI_GUNCELLE");
            bool sil = _userPermissions.Contains("KATEGORI_SIL");

            dataGrid_Kategori.Enabled = listele;
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
        private void Listele()
        {
            var result = kategoriService.GetListByFilterService(x =>
                x.AktifMi &&
                x.KategoriAdi.Contains(textBox_Ara.Text)
            );

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Hata");
                return;
            }

            bilKategori.Clear();
            foreach (var item in result.Data)
                bilKategori.Add(item);

            dataGrid_Kategori.ClearSelection();
            KutulariTemizle();
            PasifKontrol();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!BoslukKontrol()) return;

            Kategori yeniKategori = new Kategori
            {
                KategoriAdi = textBox_KategoriAdi.Text,
                AktifMi = true
            };

            var kategoriResult = kategoriService.AddService(yeniKategori);

            if (!kategoriResult.IsSuccess)
            {
                MessageBox.Show(kategoriResult.Message, "Hata");
                return;
            }

            MessageBox.Show("Kategori başarıyla kaydedildi.", "Başarılı");
            Listele();
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (!BoslukKontrol()) return;

            int.TryParse(textBox_KategoriId.Text, out int idResult);

            Kategori yeniKategori = new Kategori
            {
                KategoriId = idResult,
                KategoriAdi = textBox_KategoriAdi.Text,
                AktifMi = true
            };

            var kategoriResult = kategoriService.UpdateService(yeniKategori);

            if (!kategoriResult.IsSuccess)
            {
                MessageBox.Show(kategoriResult.Message, "Hata");
                return;
            }

            MessageBox.Show("Kategori başarıyla güncellendi.", "Başarılı");
            Listele();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_KategoriId.Text, out int idResult))
            {
                MessageBox.Show("Lütfen geçerli bir kategori seçiniz.", "Hata");
                return;
            }

            var kategoriFromDbResult = kategoriService.GetByFilterService(x => x.KategoriId == idResult);

            if (!kategoriFromDbResult.IsSuccess || kategoriFromDbResult.Data == null)
            {
                MessageBox.Show("Kategori bulunamadı.", "Hata");
                return;
            }

            var kategoriFromDb = kategoriFromDbResult.Data;
            kategoriFromDb.AktifMi = false;

            var uyeResult = kategoriService.UpdateService(kategoriFromDb);

            if (uyeResult.IsSuccess)
            {
                MessageBox.Show("Kategori başarıyla silindi (pasif edildi).", "Başarılı");
                Listele();
                PasifKontrol();
            }
            else
                MessageBox.Show(uyeResult.Message, "Hata");
        }
        private void KutulariTemizle()
        {
            textBox_KategoriId.Clear();
            textBox_KategoriAdi.Clear();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGrid_Kategori.ClearSelection();
            KutulariTemizle();
        }
        private void PasifKontrol()
        {
            bool listele = _userPermissions.Contains("KATEGORI_LISTELE");
            if (!listele)
            {
                btnSilinenleriGoster.Visible = false;
                return;
            }
            var pasifResult = kategoriService.GetListByFilterService(x => x.AktifMi == false);

            bool silinmisVarMi = pasifResult.IsSuccess && pasifResult.Data.Any();
            btnSilinenleriGoster.Visible = silinmisVarMi;
        }
        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {
            if (!silinenModu)
            {
                var sonuc = kategoriService.GetListByFilterService(x => x.AktifMi == false);

                if (!sonuc.IsSuccess || !sonuc.Data.Any())
                {
                    MessageBox.Show("Silinmiş kategori bulunamadı.", "Bilgi");
                    return;
                }

                bilKategori.Clear();
                foreach (var item in sonuc.Data)
                    bilKategori.Add(item);

                btnGeriYukle.Visible = true;
                btnKaydet.Enabled = false;
                btnDuzenle.Enabled = false;
                btnSil.Enabled = false;

                silinenModu = true;
                btnSilinenleriGoster.Text = "Aktif Kategorileri Göster";
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
            dataGrid_Kategori.ClearSelection();
            KutulariTemizle();
        }
        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_KategoriId.Text, out int id))
            {
                MessageBox.Show("Lütfen bir Kategori seçiniz.");
                return;
            }

            var kategoriResult = kategoriService.GetByFilterService(x => x.KategoriId == id);

            if (!kategoriResult.IsSuccess || kategoriResult.Data == null)
            {
                MessageBox.Show("Kategori bulunamadı.");
                return;
            }

            var uye = kategoriResult.Data;
            uye.AktifMi = true;

            var updateResult = kategoriService.UpdateService(uye);

            if (!updateResult.IsSuccess)
            {
                MessageBox.Show(updateResult.Message);
                return;
            }

            MessageBox.Show("Kategori başarıyla geri yüklendi.");
            Listele();
            silinenModu = false;
            btnSilinenleriGoster.Text = "🗑️ Silinenleri Göster";
            btnGeriYukle.Visible = false;
            btnKaydet.Enabled = true;
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            PasifKontrol();
            KutulariTemizle();
            dataGrid_Kategori.ClearSelection();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
            dataGrid_Kategori.ClearSelection();
        }
        private void dataGrid_Kategori_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid_Kategori.CurrentRow != null && !dataGrid_Kategori.CurrentRow.IsNewRow)
            {
                Kategori row = (Kategori)dataGrid_Kategori.CurrentRow.DataBoundItem;
                textBox_KategoriId.Text = row.KategoriId.ToString();
                textBox_KategoriAdi.Text = row.KategoriAdi;

                return;
            }
            dataGrid_Kategori.ClearSelection();
            KutulariTemizle();
        }
        private bool BoslukKontrol()
        {
            if (string.IsNullOrWhiteSpace(textBox_KategoriAdi.Text))
            {
                MessageBox.Show("Lütfen kategori adını boş bırakmayınız.", "Uyarı");
                return false;
            }
            return true;
        }
        private void dataGrid_Kategori_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(textBox_Ara.Text))
            //    return;

            //if (e.Value != null)
            //{
            //    string aranan = textBox_Ara.Text.ToLower();
            //    string hucreMetni = e.Value.ToString().ToLower();

            //    if (hucreMetni.Contains(aranan))
            //    {
            //        e.CellStyle.BackColor = Color.Yellow;
            //        e.CellStyle.ForeColor = Color.Black;
            //    }
            //    else
            //    {
            //        e.CellStyle.BackColor = Color.White;
            //        e.CellStyle.ForeColor = Color.Black;
            //    }
            //}
        }
        private void textBox_Ara_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }
        Dictionary<string, bool> sortDirections = new();
        private void dataGrid_Kategori_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridSortHelper.SortByColumn<Kategori>(dataGrid_Kategori, bilKategori, e.ColumnIndex, sortDirections);
            dataGrid_Kategori.ClearSelection();
            KutulariTemizle();
        }
    }
}