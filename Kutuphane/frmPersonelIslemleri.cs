using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
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
        }

        BindingList<Personel> bilPersonel = new BindingList<Personel>();
        IPersonelService personelService = new PersonelManager(new PersonelDal());
        bool silinenModu = false;

        private void Listele()
        {
            var uyeResult = personelService.PersonelListeDetayliGetirServis(x =>
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
        private void ComboDoldur()
        {
            ICinsiyetService cinsiyetService = new CinsiyetManager(new CinsiyetDal<>());
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
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Personel yeniPersonel = new Personel
            {
                Ad = textBox_Ad.Text,
                Soyad = textBox_Soyad.Text,
                CinsiyetId = (byte)(comboBox_Cinsiyet.SelectedIndex + 1),
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

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox_PersonelId.Text, out int idResult);

            Personel yeniPersonel = new Personel
            {
                Ad = textBox_Ad.Text,
                Soyad = textBox_Soyad.Text,
                CinsiyetId = (byte)(comboBox_Cinsiyet.SelectedIndex + 1),
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

        private void btnSil_Click(object sender, EventArgs e)
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
                MessageBox.Show("Üye başarıyla silindi (pasif edildi).", "Başarılı");
                Listele();
                PasifUyeKontrol();

            }
            else
                MessageBox.Show(uyeResult.Message, "Hata");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textBox_Ad.Clear();
            textBox_Soyad.Clear();
            comboBox_Cinsiyet.SelectedIndex = -1;
            textBox_KullaniciAdi.Clear();
            textBox_Sifre.Clear();
            textBox_PersonelId.Clear();
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
                var sonuc = personelService.PersonelListeDetayliGetirServis(x => x.AktifMi == false);

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

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGrid_Personel_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid_Personel.CurrentRow != null && !dataGrid_Personel.CurrentRow.IsNewRow)
            {
                Personel row = (Personel)dataGrid_Personel.CurrentRow.DataBoundItem;

                textBox_PersonelId.Text = row.PersonelId.ToString();
                textBox_Ad.Text = row.Ad;
                textBox_Soyad.Text = row.Soyad;
                comboBox_Cinsiyet.SelectedValue = row.CinsiyetId;
                textBox_KullaniciAdi.Text = row.KullaniciAdi;
                textBox_Sifre.Text = row.Sifre;
                return;
            }
            btnTemizle.PerformClick();
        }
    }
}
