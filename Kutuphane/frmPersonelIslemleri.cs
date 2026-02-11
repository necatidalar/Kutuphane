using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.DAL.Contexes;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using Kutuphane.UI.Theme;
using Kutuphane.UI.UIMetodlar;
using System.ComponentModel;

namespace Kutuphane.UI
{
    public partial class frmPersonelIslemleri : Form
    {
        BindingList<PersonelBilgileriDto> bilPersonel = new BindingList<PersonelBilgileriDto>();
        private List<PersonelBilgileriDto> _tumPersoneller = new();
        IPersonelService personelService = new PersonelManager(new PersonelDal());
        bool silinenModu = false;

        private readonly YetkiKontrol _yetkiKontrol;
        private readonly int _personelId;
        private HashSet<string> _userPermissions;
        public frmPersonelIslemleri(int personelId)
        {
            InitializeComponent();
            _personelId = personelId;
            _yetkiKontrol = new YetkiKontrol(new KutuphaneDbContext());
            _userPermissions = _yetkiKontrol.KullaniciYetkileriniAl(_personelId);
            dataGrid_Personel.DataSource = bilPersonel;
        }
        private void frmPersonelIslemleri_Load(object sender, EventArgs e)
        {
            YetkiKontrol();
            if (_userPermissions.Contains("PERSONEL_LISTELE"))
            {
                PersonelleriYukle();
                ComboDoldur();
                PasifKontrol();
            }
            btnTemizle.PerformClick();
            DataGridThemeManager.Apply(dataGrid_Personel);
        }
        private void YetkiKontrol()
        {
            bool listele = _userPermissions.Contains("PERSONEL_LISTELE");
            bool ekle = _userPermissions.Contains("PERSONEL_EKLE");
            bool guncelle = _userPermissions.Contains("PERSONEL_GUNCELLE");
            bool sil = _userPermissions.Contains("PERSONEL_SIL");

            dataGrid_Personel.Enabled = listele;
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
        private void PersonelleriYukle()
        {
            var result = personelService.PersonelBilgiGetirServis(x => x.AktifMi);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Hata");
                return;
            }

            _tumPersoneller = result.Data.ToList();

            bilPersonel.Clear();
            foreach (var p in _tumPersoneller)
                bilPersonel.Add(p);
        }
        private void Ara()
        {
            string arama = textBox_Ara.Text.Trim().ToLower();

            var filtreliListe = string.IsNullOrWhiteSpace(arama)
                ? _tumPersoneller
                : _tumPersoneller.Where(x =>
                    x.Ad.ToLower().Contains(arama) ||
                    x.Soyad.ToLower().Contains(arama)
                ).ToList();

            bilPersonel.Clear();
            foreach (var p in filtreliListe)
                bilPersonel.Add(p);
        }
        private void ComboDoldur()
        {
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Cinsiyet listesi yüklenemedi:\n" + ex.Message);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (!BoslukKontrol()) return;

                Personel yeniPersonel = new Personel
                {
                    Ad = textBox_Ad.Text,
                    Soyad = textBox_Soyad.Text,
                    CinsiyetId = (byte)comboBox_Cinsiyet.SelectedValue,
                    KullaniciAdi = textBox_KullaniciAdi.Text,
                    Sifre = textBox_Sifre.Text
                };

                var personelResult = personelService.AddService(yeniPersonel);

                if (personelResult.IsSuccess)
                {
                    MessageBox.Show("Personel başarıyla kaydedildi.", "Başarılı");
                    PersonelleriYukle();
                }
                else
                    MessageBox.Show(personelResult.Message, "Hata");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında hata oluştu:\n" + ex.Message);
            }
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!BoslukKontrol()) return;

                if (!int.TryParse(textBox_PersonelId.Text, out int idResult))
                {
                    MessageBox.Show("Geçerli bir personel seçiniz.");
                    return;
                }

                var soru = MessageBox.Show("Bu personeli düzenlemek istediğine emin misin?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (soru == DialogResult.No)
                {
                    return;
                }

                Personel yeniPersonel = new Personel
                {
                    PersonelId = idResult,
                    Ad = textBox_Ad.Text,
                    Soyad = textBox_Soyad.Text,
                    CinsiyetId = (byte)comboBox_Cinsiyet.SelectedValue,
                    KullaniciAdi = textBox_KullaniciAdi.Text,
                    Sifre = textBox_Sifre.Text
                };

                var personelResult = personelService.UpdateService(yeniPersonel);

                if (personelResult.IsSuccess)
                {
                    MessageBox.Show("Personel başarıyla güncellendi.", "Başarılı");
                    PersonelleriYukle();
                }
                else
                    MessageBox.Show(personelResult.Message, "Hata");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu:\n" + ex.Message);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox_PersonelId.Text, out int idResult))
                {
                    MessageBox.Show("Lütfen geçerli bir personel seçiniz.", "Hata");
                    return;
                }

                var personelFromDbResult = personelService.GetByFilterService(x => x.PersonelId == idResult);

                if (!personelFromDbResult.IsSuccess || personelFromDbResult.Data == null)
                {
                    MessageBox.Show("Personel bulunamadı.", "Hata");
                    return;
                }

                var soru = MessageBox.Show("Bu personeli silmek istediğine emin misin?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (soru == DialogResult.No)
                {
                    return;
                }

                var uyeFromDb = personelFromDbResult.Data;
                uyeFromDb.AktifMi = false;

                var personelResult = personelService.UpdateService(uyeFromDb);

                if (personelResult.IsSuccess)
                {
                    MessageBox.Show("Personel başarıyla silindi.", "Başarılı");
                    PersonelleriYukle();
                    PasifKontrol();

                }
                else
                    MessageBox.Show(personelResult.Message, "Hata");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında hata oluştu:\n" + ex.Message);
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            KutulariTemizle();
        }
        private void KutulariTemizle()
        {
            textBox_Ad.Clear();
            textBox_Soyad.Clear();
            comboBox_Cinsiyet.SelectedIndex = -1;
            textBox_KullaniciAdi.Clear();
            textBox_Sifre.Clear();
            textBox_PersonelId.Clear();
            dataGrid_Personel.ClearSelection();
        }
        private void PasifKontrol()
        {
            bool listele = _userPermissions.Contains("PERSONEL_LISTELE");
            if (!listele)
            {
                btnSilinenleriGoster.Visible = false;
                return;
            }

            dataGrid_Personel.ClearSelection();
            var pasifResult = personelService.GetListByFilterService(x => x.AktifMi == false);

            bool silinmisVarMi = pasifResult.IsSuccess && pasifResult.Data.Any();
            btnSilinenleriGoster.Visible = silinmisVarMi;
        }
        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {
            if (!silinenModu)
            {
                var sonuc = personelService.PersonelBilgiGetirServis(x => x.AktifMi == false);

                if (!sonuc.IsSuccess || !sonuc.Data.Any())
                {
                    MessageBox.Show("Silinmiş personel bulunamadı.", "Bilgi");
                    return;
                }

                bilPersonel.Clear();
                foreach (var item in sonuc.Data)
                    bilPersonel.Add(item);

                btnGeriYukle.Visible = true;
                btnKaydet.Enabled = false;
                btnDuzenle.Enabled = false;
                btnSil.Enabled = false;

                silinenModu = true;
                btnSilinenleriGoster.Text = "Aktif Personelleri Göster";
            }
            else
            {
                PersonelleriYukle();
                btnGeriYukle.Visible = false;
                btnKaydet.Enabled = true;
                btnDuzenle.Enabled = true;
                btnSil.Enabled = true;

                silinenModu = false;
                btnSilinenleriGoster.Text = "🗑️ Silinen Personelleri Göster";
            }
        }
        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox_PersonelId.Text, out int id))
                {
                    MessageBox.Show("Lütfen bir personel seçiniz.");
                    return;
                }

                var personelResult = personelService.GetByFilterService(x => x.PersonelId == id);

                if (!personelResult.IsSuccess || personelResult.Data == null)
                {
                    MessageBox.Show("Personel bulunamadı.");
                    return;
                }

                var personel = personelResult.Data;
                personel.AktifMi = true;

                var updateResult = personelService.UpdateService(personel);

                if (!updateResult.IsSuccess)
                {
                    MessageBox.Show(updateResult.Message);
                    return;
                }

                MessageBox.Show("Personel başarıyla geri yüklendi.");
                PersonelleriYukle();
                silinenModu = false;
                btnSilinenleriGoster.Text = "🗑️ Silinen Personelleri Göster";
                btnGeriYukle.Visible = false;
                btnKaydet.Enabled = true;
                btnDuzenle.Enabled = true;
                btnSil.Enabled = true;
                PasifKontrol();
                btnTemizle.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel geri yüklenirken hata oluştu:\n" + ex.Message);
            }
        }
        private void dataGrid_Personel_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid_Personel.CurrentRow != null && !dataGrid_Personel.CurrentRow.IsNewRow)
            {
                PersonelBilgileriDto row = (PersonelBilgileriDto)dataGrid_Personel.CurrentRow.DataBoundItem;

                textBox_PersonelId.Text = row.PersonelId.ToString();
                textBox_Ad.Text = row.Ad;
                textBox_Soyad.Text = row.Soyad;
                comboBox_Cinsiyet.SelectedValue = row.CinsiyetId;
                return;
            }
            btnTemizle.PerformClick();
        }
        private void dataGrid_Personel_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
        private bool BoslukKontrol()
        {
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

            if (comboBox_Cinsiyet.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox_KullaniciAdi.Text))
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox_Sifre.Text))
            {
                MessageBox.Show("Şifre boş bırakılamaz.");
                return false;
            }

            return true;
        }
        private void textBox_Ara_TextChanged(object sender, EventArgs e)
        {
            Ara();
        }
        Dictionary<string, bool> sortDirections = new();
        private void dataGrid_Personel_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridSortHelper.SortByColumn<PersonelBilgileriDto>(dataGrid_Personel, bilPersonel, e.ColumnIndex, sortDirections);
            dataGrid_Personel.ClearSelection();
            KutulariTemizle();
        }
    }
}