using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.ComponentModel;

namespace Kutuphane.UI
{
    public partial class frmUyeIslemleri : Form
    {
        public frmUyeIslemleri()
        {
            InitializeComponent();
            dataGrid_Uye.DataSource = bilUyeDto;
        }

        BindingList<UyeDto> bilUyeDto = new BindingList<UyeDto>();
        IUyeService uyeService = new UyeManager(new UyeDal());
        bool silinenModu = false;

        private void frmUyeIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
            PasifUyeKontrol();
            ComboDoldur();
        }
        private void Listele()
        {
            var uyeResult = uyeService.UyeListeDetayliGetirServis(x =>
                x.AktifMi == true &&
                (x.TcPass.Contains(textBox_Ara.Text) ||
                 x.Ad.Contains(textBox_Ara.Text) ||
                 x.Soyad.Contains(textBox_Ara.Text))
            );

            if (!uyeResult.IsSuccess)
            {
                MessageBox.Show(uyeResult.Message, "Hata");
                return;
            }

            bilUyeDto.Clear();

            foreach (var item in uyeResult.Data)
                bilUyeDto.Add(item);

            dataGrid_Uye.ClearSelection();
            KutulariTemizle();
        }
        private void ComboDoldur()
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
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!BoslukKontrol())
                return;

            Uye yeniUye = new Uye
            {
                TcPass = textBox_TcPass.Text.Trim(),
                Ad = textBox_Ad.Text.Trim(),
                Soyad = textBox_Soyad.Text.Trim(),
                CinsiyetId = ((Cinsiyet)comboBox_Cinsiyet.SelectedItem).Id,
                Telefon = textBox_Telefon.Text.Trim(),
                Eposta = textBox_Eposta.Text.Trim(),
                Adres = textBox_Adres.Text.Trim(),
                AdresDetay = richTextBox_AdresDetay.Text.Trim(),
                DogumTarihi = dateTimePicker1.Value,
                AktifMi = true
            };

            var result = uyeService.AddService(yeniUye);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Hata");
                return;
            }

            MessageBox.Show("Üye başarıyla kaydedildi.");
            Listele();
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_UyeId.Text, out int id))
            {
                MessageBox.Show("Geçerli bir üye seçiniz.");
                return;
            }

            if (!BoslukKontrol())
                return;

            Uye yeniUye = new Uye
            {
                UyeId = id,
                TcPass = textBox_TcPass.Text.Trim(),
                Ad = textBox_Ad.Text.Trim(),
                Soyad = textBox_Soyad.Text.Trim(),
                CinsiyetId = ((Cinsiyet)comboBox_Cinsiyet.SelectedItem).Id,
                Telefon = textBox_Telefon.Text.Trim(),
                Eposta = textBox_Eposta.Text.Trim(),
                Adres = textBox_Adres.Text.Trim(),
                AdresDetay = richTextBox_AdresDetay.Text.Trim(),
                DogumTarihi = dateTimePicker1.Value,
                AktifMi = true
            };

            var result = uyeService.UpdateService(yeniUye);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Hata");
                return;
            }

            MessageBox.Show("Üye güncellendi.");
            Listele();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_UyeId.Text, out int idResult))
            {
                MessageBox.Show("Lütfen geçerli bir üye seçiniz.", "Hata");
                return;
            }

            var uyeFromDbResult = uyeService.GetByFilterService(x => x.UyeId == idResult);

            if (!uyeFromDbResult.IsSuccess || uyeFromDbResult.Data == null)
            {
                MessageBox.Show("Üye bulunamadı.", "Hata");
                return;
            }
            var soru = MessageBox.Show("Bu üyeyi silmek istediğine emin misin?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (soru == DialogResult.No)
            {
                return;
            }

            var uyeFromDb = uyeFromDbResult.Data;
            uyeFromDb.AktifMi = false;

            var uyeResult = uyeService.UpdateService(uyeFromDb);

            if (uyeResult.IsSuccess)
            {
                MessageBox.Show("Üye başarıyla silindi (pasif edildi).", "Başarılı");
                Listele();
                PasifUyeKontrol();
            }
            else
                MessageBox.Show(uyeResult.Message, "Hata");
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGrid_Uye.ClearSelection();
            KutulariTemizle();
        }
        private void KutulariTemizle()
        {
            textBox_UyeId.Clear();
            textBox_TcPass.Clear();
            textBox_Ad.Clear();
            textBox_Soyad.Clear();
            textBox_Telefon.Clear();
            textBox_Eposta.Clear();
            textBox_Adres.Clear();
            richTextBox_AdresDetay.Clear();
            comboBox_Cinsiyet.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }
        private void dataGrid_Uye_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid_Uye.CurrentRow != null && !dataGrid_Uye.CurrentRow.IsNewRow)
            {
                UyeDto row = (UyeDto)dataGrid_Uye.CurrentRow.DataBoundItem;

                textBox_UyeId.Text = row.UyeId.ToString();
                textBox_TcPass.Text = row.TcPass;
                textBox_Ad.Text = row.Ad;
                textBox_Soyad.Text = row.Soyad;
                comboBox_Cinsiyet.SelectedValue = row.CinsiyetId;
                textBox_Telefon.Text = row.Telefon;
                textBox_Eposta.Text = row.Eposta;
                textBox_Adres.Text = row.Adres;
                richTextBox_AdresDetay.Text = row.AdresDetay;
                dateTimePicker1.Value = row.DogumTarihi;

                return;
            }

            KutulariTemizle();
        }
        private void PasifUyeKontrol()
        {
            dataGrid_Uye.ClearSelection();

            var pasifResult = uyeService.GetListByFilterService(x => x.AktifMi == false);

            btnSilinenleriGoster.Visible = pasifResult.IsSuccess && pasifResult.Data.Any();
        }
        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {
            if (!silinenModu)
            {
                var sonuc = uyeService.UyeListeDetayliGetirServis(x => x.AktifMi == false);

                bilUyeDto.Clear();
                foreach (var item in sonuc.Data)
                    bilUyeDto.Add(item);

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
            if (!int.TryParse(textBox_UyeId.Text, out int id))
            {
                MessageBox.Show("Lütfen bir üye seçiniz.");
                return;
            }

            var uyeResult = uyeService.GetByFilterService(x => x.UyeId == id);

            if (!uyeResult.IsSuccess || uyeResult.Data == null)
            {
                MessageBox.Show("Üye bulunamadı.");
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
        private bool BoslukKontrol()
        {
            if (string.IsNullOrWhiteSpace(textBox_TcPass.Text))
            {
                MessageBox.Show("Tc Pass boş bırakılamaz.");
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
                MessageBox.Show("Eposta boş bırakılamaz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_Adres.Text))
            {
                MessageBox.Show("Adres boş bırakılamaz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(richTextBox_AdresDetay.Text))
            {
                MessageBox.Show("Adres Detay boş bırakılamaz.");
                return false;
            }
            return true;
        }
    }
}
