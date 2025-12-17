using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.Entity;
using System.ComponentModel;

namespace Kutuphane.UI
{
    public partial class frmDilIslemleri : Form
    {
        public frmDilIslemleri()
        {
            InitializeComponent();
            dataGrid_Dil.DataSource = bilDil;

        }

        BindingList<Dil> bilDil = new BindingList<Dil>();
        IDilService dilService = new DilManager(new DilDal());
        bool silinenModu = false;

        private void frmDilIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
            PasifUyeKontrol();
            KutulariTemizle();
            dataGrid_Dil.ClearSelection();
        }
        private void Listele()
        {
            var dilResult = dilService.GetListByFilterService(x =>
                x.AktifMi == true &&
                (x.DilAdi.Contains(textBox_Ara.Text) || x.DilKodu.Contains(textBox_Ara.Text))
            );

            if (!dilResult.IsSuccess)
            {
                MessageBox.Show(dilResult.Message, "Hata");
                return;
            }

            bilDil.Clear();

            foreach (var item in dilResult.Data)
                bilDil.Add(item);

            dataGrid_Dil.ClearSelection();
            KutulariTemizle();
            PasifUyeKontrol();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Dil yeniDil = new Dil
            {
                DilAdi = textBox_DilAdi.Text,
                DilKodu = textBox_DilKodu.Text,
                AktifMi = true
            };

            var dilResult = dilService.AddService(yeniDil);

            if (dilResult.IsSuccess)
            {
                MessageBox.Show("Dil başarıyla kaydedildi.", "Başarılı");
                Listele();
            }
            else
                MessageBox.Show(dilResult.Message, "Hata");
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            short.TryParse(textBox_DilId.Text, out short idResult);

            Dil yeniDil = new Dil
            {
                DilId = idResult,
                DilAdi = textBox_DilAdi.Text,
                DilKodu = textBox_DilKodu.Text,
                AktifMi = true
            };


            var dilResult = dilService.UpdateService(yeniDil);

            if (dilResult.IsSuccess)
            {
                MessageBox.Show("Dil başarıyla güncellendi.", "Başarılı");
                Listele();
            }
            else
                MessageBox.Show(dilResult.Message, "Hata");
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_DilId.Text, out int idResult))
            {
                MessageBox.Show("Lütfen geçerli bir dil seçiniz.", "Hata");
                return;
            }

            var YazarFromDbResult = dilService.GetByFilterService(x => x.DilId == idResult);

            if (!YazarFromDbResult.IsSuccess || YazarFromDbResult.Data == null)
            {
                MessageBox.Show("Dil bulunamadı.", "Hata");
                return;
            }

            var YazarFromDb = YazarFromDbResult.Data;
            YazarFromDb.AktifMi = false;

            var uyeResult = dilService.UpdateService(YazarFromDb);

            if (uyeResult.IsSuccess)
            {
                MessageBox.Show("Dil başarıyla silindi (pasif edildi).", "Başarılı");
                Listele();
                PasifUyeKontrol();
            }
            else
                MessageBox.Show(uyeResult.Message, "Hata");
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGrid_Dil.ClearSelection();
            KutulariTemizle();
        }
        private void KutulariTemizle()
        {
            textBox_DilId.Clear();
            textBox_DilAdi.Clear();
            textBox_DilKodu.Clear();
            dataGrid_Dil.ClearSelection();
        }
        private void PasifUyeKontrol()
        {
            dataGrid_Dil.ClearSelection();

            var pasifResult = dilService.GetListByFilterService(x => x.AktifMi == false);

            btnSilinenleriGoster.Visible = pasifResult.IsSuccess && pasifResult.Data.Any();
        }
        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {
            if (!silinenModu)
            {
                var sonuc = dilService.GetListByFilterService(x => x.AktifMi == false);

                bilDil.Clear();
                foreach (var item in sonuc.Data)
                    bilDil.Add(item);

                btnGeriYukle.Visible = true;
                btnKaydet.Enabled = false;
                btnDuzenle.Enabled = false;
                btnSil.Enabled = false;
                silinenModu = true;
                btnSilinenleriGoster.Text = "Aktif Dilleri Göster";
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
            dataGrid_Dil.ClearSelection();
            KutulariTemizle();
        }
        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_DilId.Text, out int id))
            {
                MessageBox.Show("Lütfen bir Yazar seçiniz.");
                return;
            }

            var dilResult = dilService.GetByFilterService(x => x.DilId == id);

            if (!dilResult.IsSuccess || dilResult.Data == null)
            {
                MessageBox.Show("Yazar bulunamadı.");
                return;
            }

            var uye = dilResult.Data;
            uye.AktifMi = true;

            var updateResult = dilService.UpdateService(uye);

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
            dataGrid_Dil.ClearSelection();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
            dataGrid_Dil.ClearSelection();
        }
        private void dataGrid_Dil_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid_Dil.CurrentRow != null && !dataGrid_Dil.CurrentRow.IsNewRow)
            {
                Dil row = (Dil)dataGrid_Dil.CurrentRow.DataBoundItem;
                textBox_DilId.Text = row.DilId.ToString();
                textBox_DilAdi.Text = row.DilAdi;
                textBox_DilKodu.Text = row.DilKodu;

                return;
            }
            dataGrid_Dil.ClearSelection();
            KutulariTemizle();
        }
    }
}