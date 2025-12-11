using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.ComponentModel;
namespace Kutuphane.UI
{
    public partial class frmPersonelIslemleri : Form
    {
        public frmPersonelIslemleri()
        {
            InitializeComponent();
            dataGrid_Personel.DataSource = bilPersonel;
        }

        private void frmPersonelIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
            ComboDoldur();
            PasifUyeKontrol();
            btnTemizle.PerformClick();
        }

        BindingList<PersonelBilgileriDto> bilPersonel = new BindingList<PersonelBilgileriDto>();
        IPersonelService personelService = new PersonelManager(new PersonelDal());
        bool silinenModu = false;

        private void Listele()
        {
            try
            {
                var uyeResult = personelService.PersonelBilgiGetirServis(x =>
                    x.AktifMi == true &&
                    (x.Ad.Contains(textBox_Ara.Text) ||
                     x.Soyad.Contains(textBox_Ara.Text) ||
                     x.KullaniciAdi.Contains(textBox_Ara.Text))
                );

                if (!uyeResult.IsSuccess)
                {
                    MessageBox.Show(uyeResult.Message, "Hata");
                    return;
                }

                bilPersonel.Clear();
                foreach (var item in uyeResult.Data)
                    bilPersonel.Add(item);

                dataGrid_Personel.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme sırasında hata oluştu:\n" + ex.Message);
            }
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

                var uyeResult = personelService.AddService(yeniPersonel);

                if (uyeResult.IsSuccess)
                {
                    MessageBox.Show("Personel başarıyla kaydedildi.", "Başarılı");
                    Listele();
                }
                else
                    MessageBox.Show(uyeResult.Message, "Hata");
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

                Personel yeniPersonel = new Personel
                {
                    PersonelId = idResult,
                    Ad = textBox_Ad.Text,
                    Soyad = textBox_Soyad.Text,
                    CinsiyetId = (byte)comboBox_Cinsiyet.SelectedValue,
                    KullaniciAdi = textBox_KullaniciAdi.Text,
                    Sifre = textBox_Sifre.Text
                };

                var uyeResult = personelService.UpdateService(yeniPersonel);

                if (uyeResult.IsSuccess)
                {
                    MessageBox.Show("Personel başarıyla güncellendi.", "Başarılı");
                    Listele();
                }
                else
                    MessageBox.Show(uyeResult.Message, "Hata");
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
                    MessageBox.Show("Lütfen geçerli bir üye seçiniz.", "Hata");
                    return;
                }

                var uyeFromDbResult = personelService.GetByFilterService(x => x.PersonelId == idResult);

                if (!uyeFromDbResult.IsSuccess || uyeFromDbResult.Data == null)
                {
                    MessageBox.Show("Üye bulunamadı.", "Hata");
                    return;
                }

                var uyeFromDb = uyeFromDbResult.Data;
                uyeFromDb.AktifMi = false;

                var uyeResult = personelService.UpdateService(uyeFromDb);

                if (uyeResult.IsSuccess)
                {
                    MessageBox.Show("Üye başarıyla silindi.", "Başarılı");
                    Listele();
                    PasifUyeKontrol();

                }
                else
                    MessageBox.Show(uyeResult.Message, "Hata");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında hata oluştu:\n" + ex.Message);
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textBox_Ad.Clear();
            textBox_Soyad.Clear();
            comboBox_Cinsiyet.SelectedIndex = -1;
            textBox_KullaniciAdi.Clear();
            textBox_Sifre.Clear();
            textBox_PersonelId.Clear();
            dataGrid_Personel.ClearSelection();
        }
        private void PasifUyeKontrol()
        {
            dataGrid_Personel.ClearSelection();

            var pasifResult = personelService.GetListByFilterService(x => x.AktifMi == false);

            btnSilinenleriGoster.Visible = pasifResult.IsSuccess && pasifResult.Data.Any();
        }
        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {
            if (!silinenModu)
            {
                var sonuc = personelService.PersonelBilgiGetirServis(x => x.AktifMi == false);

                bilPersonel.Clear();
                foreach (var item in sonuc.Data)
                    bilPersonel.Add(item);

                btnGeriYukle.Visible = true;
                btnKaydet.Enabled = false;
                btnDuzenle.Enabled = false;
                btnSil.Enabled = false;
                silinenModu = true;
                btnSilinenleriGoster.Text = "Aktif Üyeleri Göster";
            }
            else
            {
                Listele();
                btnGeriYukle.Visible = false;
                btnKaydet.Enabled = true;
                btnDuzenle.Enabled = true;
                btnSil.Enabled = true;
                silinenModu = false;
                btnSilinenleriGoster.Text = "Silinen Üyeleri Göster";
            }
        }
        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox_PersonelId.Text, out int id))
                {
                    MessageBox.Show("Lütfen bir üye seçiniz.");
                    return;
                }

                var uyeResult = personelService.GetByFilterService(x => x.PersonelId == id);

                if (!uyeResult.IsSuccess || uyeResult.Data == null)
                {
                    MessageBox.Show("Üye bulunamadı.");
                    return;
                }

                var uye = uyeResult.Data;
                uye.AktifMi = true;

                var updateResult = personelService.UpdateService(uye);

                if (!updateResult.IsSuccess)
                {
                    MessageBox.Show(updateResult.Message);
                    return;
                }

                MessageBox.Show("Üye başarıyla geri yüklendi.");
                Listele();
                silinenModu = false;
                btnSilinenleriGoster.Text = "Silinen Üyeleri Göster";
                btnGeriYukle.Visible = false;
                btnKaydet.Enabled = true;
                btnDuzenle.Enabled = true;
                btnSil.Enabled = true;
                PasifUyeKontrol();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üye geri yüklenirken hata oluştu:\n" + ex.Message);
            }
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
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
                textBox_KullaniciAdi.Text = row.KullaniciAdi;
                return;
            }
            btnTemizle.PerformClick();
        }
        private void dataGrid_Personel_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGrid_Personel.Columns[e.ColumnIndex].Name == "sifreDataGridViewTextBoxColumn")
            {
                if (e.Value != null)
                {
                    string sifre = e.Value.ToString();
                    e.Value = new string('●', sifre.Length);
                    e.FormattingApplied = true;
                }
            }
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
    }
}