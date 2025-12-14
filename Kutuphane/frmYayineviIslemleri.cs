using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.Entity;
using System.ComponentModel;

namespace Kutuphane.UI
{
    public partial class frmYayineviIslemleri : Form
    {
        public frmYayineviIslemleri()
        {
            InitializeComponent();
        }

        private void frmYayineviIslemleri_Load(object sender, EventArgs e)
        {
            dataGrid_Yayinevi.DataSource = bilYayinevi;
            Listele();
            PasifUyeKontrol();
        }
        BindingList<Yayinevi> bilYayinevi = new BindingList<Yayinevi>();
        IYayineviService yayineviService = new YayineviManager(new YayineviDal());
        bool silinenModu = false;
        private void Listele()
        {
            var YayineviResult = yayineviService.GetListByFilterService(x =>
                x.AktifMi == true &&
                (x.Ad.Contains(textBox_Ara.Text))
            );

            if (!YayineviResult.IsSuccess)
            {
                MessageBox.Show(YayineviResult.Message, "Hata");
                return;
            }

            bilYayinevi.Clear();

            foreach (var item in YayineviResult.Data)
                bilYayinevi.Add(item);
            
            dataGrid_Yayinevi.ClearSelection();
            KutulariTemizle();
            PasifUyeKontrol();
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
            Listele();
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
            Listele();
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
                Listele();
                PasifUyeKontrol();
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
        private void PasifUyeKontrol()
        {
            dataGrid_Yayinevi.ClearSelection();

            var pasifResult = yayineviService.GetListByFilterService(x => x.AktifMi == false);

            btnSilinenleriGoster.Visible = pasifResult.IsSuccess && pasifResult.Data.Any();
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
                btnSilinenleriGoster.Text = "Aktif Yayınevilerini Göster";
            }
            else
            {
                Listele();
                btnGeriYukle.Visible = false;
                btnKaydet.Enabled = true;
                btnDuzenle.Enabled = true;
                btnSil.Enabled = true;
                silinenModu = false;
                btnSilinenleriGoster.Text = "Silinenleri Göster";
            }
            dataGrid_Yayinevi.ClearSelection();
            KutulariTemizle();
        }
        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_YayineviId.Text, out int id))
            {
                MessageBox.Show("Lütfen bir Yayinevi seçiniz.");
                return;
            }

            var YayineviResult = yayineviService.GetByFilterService(x => x.YayineviId == id);

            if (!YayineviResult.IsSuccess || YayineviResult.Data == null)
            {
                MessageBox.Show("Yayinevi bulunamadı.");
                return;
            }

            var uye = YayineviResult.Data;
            uye.AktifMi = true;

            var updateResult = yayineviService.UpdateService(uye);

            if (!updateResult.IsSuccess)
            {
                MessageBox.Show(updateResult.Message);
                return;
            }

            MessageBox.Show("Yayinevi başarıyla geri yüklendi.");
            Listele();
            silinenModu = false;
            btnSilinenleriGoster.Text = "Silinenleri Göster";
            btnGeriYukle.Visible = false;
            btnKaydet.Enabled = true;
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            PasifUyeKontrol();
            KutulariTemizle();
            dataGrid_Yayinevi.ClearSelection();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
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
    }
}