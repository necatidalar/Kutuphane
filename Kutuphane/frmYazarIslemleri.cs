using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.DTO;
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

        BindingList<YazarDto> bilYazar = new BindingList<YazarDto>();
        IYazarService yazarService = new YazarManager(new YazarDal());
        bool silinenModu = false;

        private void frmYazarIslemleri_Load(object sender, EventArgs e)
        {
            dateTimePicker_DogumTarihi.ShowCheckBox = true;
            dateTimePicker_DogumTarihi.Checked = false;
            dateTimePicker_OlumTarihi.ShowCheckBox = true;
            dateTimePicker_OlumTarihi.Checked = false;

            Listele();
            PasifUyeKontrol();
            KutulariTemizle();
            dataGrid_Yazar.ClearSelection();
        }
        private void Listele()
        {
            var yazarResult = yazarService.YazarListeGetirServis(x =>
                x.AktifMi == true &&
                (
                    x.Ad.Contains(textBox_Ara.Text) ||
                    x.Soyad.Contains(textBox_Ara.Text)
                )
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
                Ad = textBox_Ad.Text,
                Soyad = textBox_Soyad.Text,
                DogumTarihi = dateTimePicker_DogumTarihi.Checked
                    ? dateTimePicker_DogumTarihi.Value
                    : (DateTime?)null,

                OlumTarihi = dateTimePicker_OlumTarihi.Checked
                    ? dateTimePicker_OlumTarihi.Value
                    : (DateTime?)null,

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
                Ad = textBox_Ad.Text,
                Soyad = textBox_Soyad.Text,
                DogumTarihi = dateTimePicker_DogumTarihi.Checked
                    ? dateTimePicker_DogumTarihi.Value
                    : (DateTime?)null,

                OlumTarihi = dateTimePicker_OlumTarihi.Checked
                    ? dateTimePicker_OlumTarihi.Value
                    : (DateTime?)null,
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
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGrid_Yazar.ClearSelection();
            KutulariTemizle();
        }
        private void KutulariTemizle()
        {
            textBox_YazarId.Clear();
            textBox_Ad.Clear();
            textBox_Soyad.Clear();
            dateTimePicker_DogumTarihi.Value = DateTime.Today;
            dateTimePicker_OlumTarihi.Value = DateTime.Today;
            dateTimePicker_DogumTarihi.Checked = false;
            dateTimePicker_OlumTarihi.Checked = false;

            dataGrid_Yazar.ClearSelection();
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
                var sonuc = yazarService.YazarListeGetirServis(x => x.AktifMi == false);

                bilYazar.Clear();
                foreach (var item in sonuc.Data)
                    bilYazar.Add(item);

                btnGeriYukle.Visible = true;
                btnKaydet.Enabled = false;
                btnDuzenle.Enabled = false;
                btnSil.Enabled = false;
                silinenModu = true;
                btnSilinenleriGoster.Text = "Aktif Yazarları Göster";
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
                YazarDto row = (YazarDto)dataGrid_Yazar.CurrentRow.DataBoundItem;
                textBox_YazarId.Text = row.YazarId.ToString();
                textBox_Ad.Text = row.Ad;
                textBox_Soyad.Text = row.Soyad;
                //dateTimePicker_DogumTarihi.Value = row.DogumTarihi.Value;
                //dateTimePicker_DogumTarihi.Value = row.DogumTarihi ?? DateTime.Today;

                if (row.DogumTarihi.HasValue)
                {
                    dateTimePicker_DogumTarihi.Checked = true;
                    dateTimePicker_DogumTarihi.Value = row.DogumTarihi.Value;
                }
                else
                {
                    dateTimePicker_DogumTarihi.Checked = false;
                }

                if (row.OlumTarihi.HasValue)
                {
                    dateTimePicker_OlumTarihi.Checked = true;
                    dateTimePicker_OlumTarihi.Value = row.OlumTarihi.Value;
                }
                else
                {
                    dateTimePicker_OlumTarihi.Checked = false;
                }

                return;
            }
            dataGrid_Yazar.ClearSelection();
            KutulariTemizle();
        }

        private void textBox_Ara_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void comboBox_Sirala_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele();
        }
        Dictionary<String, bool> sortDirections = new();
        private void dataGrid_Yazar_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridSortHelper.SortByColumn<YazarDto>(dataGrid_Yazar, bilYazar, e.ColumnIndex, sortDirections);
            dataGrid_Yazar.ClearSelection();
            KutulariTemizle();
        }
    }
}
