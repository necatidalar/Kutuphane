using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.Entity;
using System.ComponentModel;

namespace Kutuphane.UI
{
    public partial class frmKategoriIslemleri : Form
    {
        public frmKategoriIslemleri()
        {
            InitializeComponent();
            dataGrid_Kategori.DataSource = bilKategori;
        }

        BindingList<Kategori> bilKategori = new BindingList<Kategori>();
        IKategoriService kategoriService = new KategoriManager(new KategoriDal());
        bool silinenModu = false;

        private void frmKategori_Load(object sender, EventArgs e)
        {
            Listele();
            PasifUyeKontrol();
            KutulariTemizle();
            dataGrid_Kategori.ClearSelection();
        }

        private void Listele()
        {
            var kategoriResult = kategoriService.KategoriListeDetayliGetirServis(x =>
                x.AktifMi == true &&
                (x.KategoriAdi.Contains(textBox_Ara.Text))
            );

            if (!kategoriResult.IsSuccess)
            {
                MessageBox.Show(kategoriResult.Message, "Hata");
                return;
            }

            bilKategori.Clear();

            foreach (var item in kategoriResult.Data)
                bilKategori.Add(item);

            dataGrid_Kategori.ClearSelection();
            KutulariTemizle();
            PasifUyeKontrol();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kategori yeniKategori = new Kategori
            {
                KategoriAdi = textBox_KategoriAdi.Text,
                AktifMi = true
            };

            var kategoriResult = kategoriService.AddService(yeniKategori);

            if (kategoriResult.IsSuccess)
            {
                MessageBox.Show("Kategori başarıyla kaydedildi.", "Başarılı");
                Listele();
            }
            else
                MessageBox.Show(kategoriResult.Message, "Hata");
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox_KategoriId.Text, out int idResult);

            Kategori yeniKategori = new Kategori
            {
                KategoriId = idResult,
                KategoriAdi = textBox_KategoriAdi.Text,
                AktifMi = true
            };

            var kategoriResult = kategoriService.UpdateService(yeniKategori);

            if (kategoriResult.IsSuccess)
            {
                MessageBox.Show("Üye başarıyla güncellendi.", "Başarılı");
                Listele();
            }
            else
                MessageBox.Show(kategoriResult.Message, "Hata");
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
                PasifUyeKontrol();
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

        private void PasifUyeKontrol()
        {
            dataGrid_Kategori.ClearSelection();

            var pasifResult = kategoriService.GetListByFilterService(x => x.AktifMi == false);

            btnSilinenleriGoster.Visible = pasifResult.IsSuccess && pasifResult.Data.Any();
        }

        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {
            if (!silinenModu)
            {
                var sonuc = kategoriService.KategoriListeDetayliGetirServis(x => x.AktifMi == false);

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
                btnSilinenleriGoster.Text = "Silinenleri Göster";
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
            btnSilinenleriGoster.Text = "Silinenleri Göster";
            btnGeriYukle.Visible = false;
            btnKaydet.Enabled = true;
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            PasifUyeKontrol();
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
    }
}
