using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.ComponentModel;

namespace Kutuphane.UI
{
    public partial class frmKitapIslemleri : Form
    {
        public frmKitapIslemleri()
        {
            InitializeComponent();
            dataGrid_Kitap.DataSource = bilKitapDto;
        }

        private void frmKitapIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        IKitapService kitapService = new KitapManager(new KitapDal());
        IKategoriService kategoriService = new KategoriManager(new KategoriDal());
        IYazarService yazarService = new YazarManager(new YazarDal());
        IYayineviService yayineviService = new YayineviManager(new YayineviDal());

        BindingList<KitapDto> bilKitapDto = new BindingList<KitapDto>();

        private void Listele()
        {
            var uyeResult = kitapService.KitapListeDetayliGetirServis(x =>
                x.Aktif == true &&
                (x.ISBN.Contains(textBox_Ara.Text) ||
                 x.KitapAdi.Contains(textBox_Ara.Text))
            );

            if (!uyeResult.IsSuccess)
            {
                MessageBox.Show(uyeResult.Message, "Hata");
                return;
            }

            bilKitapDto.Clear();

            foreach (var item in uyeResult.Data)
                bilKitapDto.Add(item);

            ComboDoldur();
            dataGrid_Kitap.ClearSelection();
        }



        private void ComboDoldur()
        {
            try
            {
                // --- KATEGORİ ---
                var kategoriResult = kategoriService.GetListByFilterService();
                if (!kategoriResult.IsSuccess || kategoriResult.Data == null)
                    throw new Exception("Kategori listesi alınırken hata oluştu: " + kategoriResult.Message);

                comboBox_Kategori.DataSource = null;
                comboBox_Kategori.DataSource = kategoriResult.Data;
                comboBox_Kategori.DisplayMember = "KategoriAdi";
                comboBox_Kategori.ValueMember = "KategoriId";
                comboBox_Kategori.SelectedIndex = -1;

                // --- YAZAR ---
                var yazarResult = yazarService.GetListByFilterService();
                if (!yazarResult.IsSuccess || yazarResult.Data == null)
                    throw new Exception("Yazar listesi alınırken hata oluştu: " + yazarResult.Message);

                comboBox_Yazar.DataSource = null;
                comboBox_Yazar.DataSource = yazarResult.Data;
                comboBox_Yazar.DisplayMember = "YazarAdi";
                comboBox_Yazar.ValueMember = "YazarId";
                comboBox_Yazar.SelectedIndex = -1;

                // --- YAYINEVİ ---
                var yayineviResult = yayineviService.GetListByFilterService();
                if (!yayineviResult.IsSuccess || yayineviResult.Data == null)
                    throw new Exception("Yayınevi listesi alınırken hata oluştu: " + yayineviResult.Message);

                comboBox_Yayinevi.DataSource = null;
                comboBox_Yayinevi.DataSource = yayineviResult.Data;
                comboBox_Yayinevi.DisplayMember = "Ad";
                comboBox_Yayinevi.ValueMember = "YayineviId";
                comboBox_Yayinevi.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kitap yeniKitap = new Kitap
            {
                ISBN = textBox_ISBN.Text,
                KitapAdi = textBox_KitapAdi.Text,
                YazarId = (int)comboBox_Yazar.SelectedValue,
                YayineviId = (int)comboBox_Yayinevi.SelectedValue,
                KategoriId = (int)comboBox_Kategori.SelectedValue,
                BasimYili = int.TryParse(textBox_BasimYili.Text, out int basimYili) ? basimYili : (int?)null,
                SayfaSayisi = int.TryParse(textBox_SayfaSayisi.Text, out int sayfaSayisi) ? sayfaSayisi : (int?)null,
                DilId = 1,
                Stok = int.TryParse(textBox_StokMiktari.Text, out int stok) ? stok : 0,
                Aktif = true
            };

            var kitapResult = kitapService.AddService(yeniKitap);

            if (kitapResult.IsSuccess)
            {
                MessageBox.Show("Kitap başarıyla kaydedildi.", "Başarılı");
                Listele();
            }
            else
                MessageBox.Show(kitapResult.Message, "Hata");
        }


        private void btnDuzenle_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }

        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {

        }

        private void btnGeriYukle_Click(object sender, EventArgs e)
        {

        }
    }
}
