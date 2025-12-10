using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.Entity;
using System.ComponentModel;

namespace Kutuphane.UI
{
    public partial class frmYazarIslemleri : Form
    {
        public frmYazarIslemleri()
        {
            InitializeComponent();
            dataGrid_Yazar.DataSource = bilYazar;
        }
        BindingList<Yazar> bilYazar = new BindingList<Yazar>();
        IYazarService yazarService = new YazarManager(new YazarDal());
        bool silinenModu = false;

        private void frmYazarIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
            PasifUyeKontrol();
            KutulariTemizle();
            dataGrid_Yazar.ClearSelection();
        }
        private void Listele()
        {
            var yazarResult = yazarService.YazarListeDetayliGetirServis(x =>
                x.AktifMi == true &&
                (x.AdSoyad.Contains(textBox_Ara.Text))
            );

            if (!yazarResult.IsSuccess)
            {
                MessageBox.Show(yazarResult.Message, "Hata");
                return;
            }

            bilYazar.Clear();

            foreach (var item in yazarResult.Data)
                bilYazar.Add(item);

            dataGrid_Yazar.ClearSelection();
            KutulariTemizle();
            PasifUyeKontrol();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Yazar yeniYazar = new Yazar
            {
                AdSoyad = textBox_AdSoyad.Text,
                AktifMi = true
            };

            var yazarResult = yazarService.AddService(yeniYazar);

            if (yazarResult.IsSuccess)
            {
                MessageBox.Show("Yazar başarıyla kaydedildi.", "Başarılı");
                Listele();
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
                AdSoyad = textBox_AdSoyad.Text,
                AktifMi = true
            };

            var yazarResult = yazarService.UpdateService(yeniYazar);

            if (yazarResult.IsSuccess)
            {
                MessageBox.Show("Üye başarıyla güncellendi.", "Başarılı");
                Listele();
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
                Listele();
                PasifUyeKontrol();
            }
            else
                MessageBox.Show(uyeResult.Message, "Hata");
        }

        private void KutulariTemizle()
        {
            textBox_YazarId.Clear();
            textBox_AdSoyad.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGrid_Yazar.ClearSelection();
            KutulariTemizle();
        }

        private void PasifUyeKontrol()
        {
            dataGrid_Yazar.ClearSelection();

            var pasifResult = yazarService.GetListByFilterService(x => x.AktifMi == false);

            btnSilinenleriGoster.Visible = pasifResult.IsSuccess && pasifResult.Data.Any();
        }

        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {
            if (!silinenModu)
            {
                var sonuc = yazarService.YazarListeDetayliGetirServis(x => x.AktifMi == false);

                bilYazar.Clear();
                foreach (var item in sonuc.Data)
                    bilYazar.Add(item);

                btnGeriYukle.Visible = true;
                btnKaydet.Enabled = false;
                btnDuzenle.Enabled = false;
                btnSil.Enabled = false;
                silinenModu = true;
                btnSilinenleriGoster.Text = "Aktif Yazarleri Göster";
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

            var uye = yazarResult.Data;
            uye.AktifMi = true;

            var updateResult = yazarService.UpdateService(uye);

            if (!updateResult.IsSuccess)
            {
                MessageBox.Show(updateResult.Message);
                return;
            }

            MessageBox.Show("Yazar başarıyla geri yüklendi.");
            Listele();
            silinenModu = false;
            btnSilinenleriGoster.Text = "Silinenleri Göster";
            btnGeriYukle.Visible = false;
            btnKaydet.Enabled = true;
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            PasifUyeKontrol();
            KutulariTemizle();
            dataGrid_Yazar.ClearSelection();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
            dataGrid_Yazar.ClearSelection();
        }

        private void dataGrid_Yazar_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid_Yazar.CurrentRow != null && !dataGrid_Yazar.CurrentRow.IsNewRow)
            {
                Yazar row = (Yazar)dataGrid_Yazar.CurrentRow.DataBoundItem;
                textBox_YazarId.Text = row.YazarId.ToString();
                textBox_AdSoyad.Text = row.AdSoyad;

                return;
            }
            dataGrid_Yazar.ClearSelection();
            KutulariTemizle();
        }
    }
}
