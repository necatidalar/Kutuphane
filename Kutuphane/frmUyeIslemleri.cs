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

            ComboDoldur();
            dataGrid_Uye.ClearSelection();
            KutulariTemizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Uye yeniUye = new Uye
            {
                TcPass = textBox_TcPass.Text,
                Ad = textBox_Ad.Text,
                Soyad = textBox_Soyad.Text,
                CinsiyetId = ((Cinsiyet)comboBox_Cinsiyet.SelectedItem).Id,
                Telefon = textBox_Telefon.Text,
                Eposta = textBox_Eposta.Text,
                Adres = textBox_Adres.Text,
                AdresDetay = richTextBox_AdresDetay.Text,
                DogumTarihi = dateTimePicker1.Value,
                AktifMi = true
            };

            var uyeResult = uyeService.AddService(yeniUye);

            if (uyeResult.IsSuccess)
            {
                MessageBox.Show("Üye başarıyla kaydedildi.", "Başarılı");
                Listele();
            }
            else
                MessageBox.Show(uyeResult.Message, "Hata");
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox_UyeId.Text, out int idResult);

            Uye yeniUye = new Uye
            {
                UyeId = idResult,
                TcPass = textBox_TcPass.Text,
                Ad = textBox_Ad.Text,
                Soyad = textBox_Soyad.Text,
                CinsiyetId = ((Cinsiyet)comboBox_Cinsiyet.SelectedItem).Id,
                Telefon = textBox_Telefon.Text,
                Eposta = textBox_Eposta.Text,
                Adres = textBox_Adres.Text,
                AdresDetay = richTextBox_AdresDetay.Text,
                DogumTarihi = dateTimePicker1.Value,
                AktifMi = true
            };

            var uyeResult = uyeService.UpdateService(yeniUye);

            if (uyeResult.IsSuccess)
            {
                MessageBox.Show("Üye başarıyla güncellendi.", "Başarılı");
                Listele();
            }
            else
                MessageBox.Show(uyeResult.Message, "Hata");
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

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGrid_Uye.ClearSelection();
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
    }
}
