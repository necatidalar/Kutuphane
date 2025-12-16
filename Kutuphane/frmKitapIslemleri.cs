using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using Kutuphane.UI.UIMetodlar;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Kutuphane.UI
{
    public partial class frmKitapIslemleri : Form
    {

        List<KitapDto> kitapListe = new();

        public frmKitapIslemleri()
        {
            InitializeComponent();
        }

        private void frmKitapIslemleri_Load(object sender, EventArgs e)
        {

            ComboDoldur();
            Listele();
            dataGrid_Kitap.ClearSelection();
        }


        private void ComboDoldur()
        {
            IYazarService _yazarManager = new YazarManager(new YazarDal());
            var yazarResult = _yazarManager.YazarListeGetirServis(x => x.AktifMi);
            if (yazarResult.IsSuccess)
                Metodlar.ComboDoldur(comboBox_Yazar, yazarResult.Data, "AdSoyad", "YazarId");

            IKategoriService _kategoriManager = new KategoriManager(new KategoriDal());
            var kategoriResult = _kategoriManager.GetListByFilterService(x => x.AktifMi);
            if (kategoriResult.IsSuccess)
                Metodlar.ComboDoldur(comboBox_Kategori, kategoriResult.Data, "KategoriAdi", "KategoriId");

            IYayineviService _yayineviManager = new YayineviManager(new YayineviDal());
            var yayineviResult = _yayineviManager.GetListByFilterService(x => x.AktifMi);
            if (yayineviResult.IsSuccess)
                Metodlar.ComboDoldur(comboBox_Yayinevi, yayineviResult.Data, "Ad", "YayineviId");

            IDilService _dilManager = new DilManager(new DilDal());
            var dilResult = _dilManager.GetListByFilterService();
            if (dilResult.IsSuccess)
                Metodlar.ComboDoldur(comboBox_Dil, dilResult.Data, "DilAdi", "DilId");

        }

        private void Listele(string? aramMetin = null)
        {
            IKitapService _kitapManager = new KitapManager(new KitapDal());
            if (aramMetin != null)
            {
                // necoş sonra düzelt
            }

            var kitapResult = _kitapManager.KitapListeDetayliGetirServis(x => x.Aktif);

            if (!kitapResult.IsSuccess)
            {
                MessageBox.Show(kitapResult.Message);
                return;
            }

            Metodlar.gridDoldur(kitapDtoBindingSource, kitapResult.Data);
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            IKitapService _kitapManager = new KitapManager(new KitapDal());
            Kitap kitap = new Kitap
            {
                ISBN = textBox_ISBN.Text.Trim(),
                KitapAdi = textBox_KitapAdi.Text.Trim(),
                YazarId = (int)comboBox_Yazar.SelectedValue,
                KategoriId = (int)comboBox_Kategori.SelectedValue,
                YayineviId = (int)comboBox_Yayinevi.SelectedValue,
                DilId = Convert.ToInt16(comboBox_Dil.SelectedValue),
                BasimYili = string.IsNullOrWhiteSpace(textBox_BasimYili.Text)
                    ? null
                    : Convert.ToInt32(textBox_BasimYili.Text),
                SayfaSayisi = string.IsNullOrWhiteSpace(textBox_SayfaSayisi.Text)
                    ? null
                    : Convert.ToInt32(textBox_SayfaSayisi.Text),
                Stok = Convert.ToInt32(textBox_StokMiktari.Text),
                Aktif = true
            };

            var result = _kitapManager.AddService(kitap);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Kitap başarıyla eklendi.", "Başarılı");
            Listele();
            Temizle();
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {

        }
        private void btnSil_Click(object sender, EventArgs e)
        {

        }
        private void Temizle()
        {
            textBox_KitapId.Clear();
            textBox_ISBN.Clear();
            textBox_KitapAdi.Clear();
            comboBox_Kategori.SelectedIndex = -1;
            comboBox_Yazar.SelectedIndex = -1;
            comboBox_Yayinevi.SelectedIndex = -1;
            comboBox_Dil.SelectedIndex = -1;
            textBox_BasimYili.Clear();
            textBox_SayfaSayisi.Clear();
            textBox_StokMiktari.Clear();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGrid_Kitap.ClearSelection();
            Temizle();
        }
        private void PasifUyeKontrol()
        {

        }
        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {

        }
        private void btnGeriYukle_Click(object sender, EventArgs e)
        {

        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
            dataGrid_Kitap.ClearSelection();
        }

        private void dataGrid_Kitap_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid_Kitap.SelectedRows.Count > 0)
            {
                DataGridViewRow? selectedRow = dataGrid_Kitap.SelectedRows[0];
                if (selectedRow != null)
                {
                    KitapDto selectedKitap = (KitapDto)selectedRow.DataBoundItem;
                    textBox_KitapId.Text = selectedKitap.KitapId.ToString();
                    textBox_ISBN.Text = selectedKitap.ISBN;
                    textBox_KitapAdi.Text = selectedKitap.KitapAdi;
                    comboBox_Yazar.SelectedValue = selectedKitap.YazarId;
                    comboBox_Kategori.SelectedValue = selectedKitap.KategoriId;
                    comboBox_Yayinevi.SelectedValue = selectedKitap.YayineviId;
                    comboBox_Dil.SelectedValue = selectedKitap.DilId;
                    textBox_BasimYili.Text = selectedKitap.BasimYili?.ToString() ?? string.Empty;
                    textBox_SayfaSayisi.Text = selectedKitap.SayfaSayisi?.ToString() ?? string.Empty;
                    textBox_StokMiktari.Text = selectedKitap.Stok.ToString();

                }
            }
            


            // Form alanlarını doldur

        }

        private void dataGrid_Kitap_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }
    }
}
