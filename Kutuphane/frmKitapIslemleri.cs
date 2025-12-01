using Kutuphane.BLL.Services;
using Kutuphane.DAL.Repository;
using Kutuphane.Model.Entity;

namespace Kutuphane.UI
{
    public partial class frmKitapIslemleri : Form
    {
        public frmKitapIslemleri()
        {
            InitializeComponent();

            _kitapService = new KitapService(new Repository<Kitap>());
            _yazarService = new YazarService(new Repository<Yazar>());
            _yayineviService = new YayineviService(new Repository<Yayinevi>());
            _kategoriService = new KategoriService(new Repository<Kategori>());
        }

        private void frmKitapIslemleri_Load(object sender, EventArgs e)
        {
            KitaplariListele();
            CombosDoldur();
        }

        private readonly KitapService _kitapService;
        private readonly YazarService _yazarService;
        private readonly YayineviService _yayineviService;
        private readonly KategoriService _kategoriService;        

        private void KitaplariListele()
        {
            dataGridView1.DataSource = _kitapService.Listele();
        }
        private void CombosDoldur()
        {
            var yazarlar = _yazarService.Listele();
            cmbYazar.DataSource = yazarlar;
            cmbYazar.DisplayMember = "AdSoyad";
            cmbYazar.ValueMember = "YazarID";
            cmbYazar.SelectedIndex = -1;

            var yayinevleri = _yayineviService.Listele();
            cmbYayinevi.DataSource = yayinevleri;
            cmbYayinevi.DisplayMember = "Ad";
            cmbYayinevi.ValueMember = "YayineviID";
            cmbYayinevi.SelectedIndex = -1;

            var kategoriler = _kategoriService.Listele();
            cmbKategori.DataSource = kategoriler;
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "KategoriID";
            cmbKategori.SelectedIndex = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbYazar.SelectedValue == null || cmbYayinevi.SelectedValue == null || cmbKategori.SelectedValue == null)
            {
                MessageBox.Show("Yazar, yayınevi ve kategori seçmelisin.");
                return;
            }

            var kitap = new Kitap
            {
                KitapAdi = txtKitapAdi.Text,
                ISBN = txtISBN.Text,
                YazarID = Convert.ToInt32(cmbYazar.SelectedValue),
                YayineviID = Convert.ToInt32(cmbYayinevi.SelectedValue),
                KategoriID = Convert.ToInt32(cmbKategori.SelectedValue),
                BasimYili = string.IsNullOrEmpty(txtBasimYili.Text) ? null : int.Parse(txtBasimYili.Text),
                SayfaSayisi = string.IsNullOrEmpty(txtSayfaSayisi.Text) ? null : int.Parse(txtSayfaSayisi.Text),
                Dil = txtDil.Text
            };

            _kitapService.Ekle(kitap);

            MessageBox.Show("Kitap eklendi.");
            KitaplariListele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            var kitap = new Kitap
            {
                KitapID = int.Parse(txtKitapID.Text),
                KitapAdi = txtKitapAdi.Text,
                ISBN = txtISBN.Text,
                YazarID = Convert.ToInt32(cmbYazar.SelectedValue),
                YayineviID = Convert.ToInt32(cmbYayinevi.SelectedValue),
                KategoriID = Convert.ToInt32(cmbKategori.SelectedValue),
                BasimYili = string.IsNullOrEmpty(txtBasimYili.Text) ? null : int.Parse(txtBasimYili.Text),
                SayfaSayisi = string.IsNullOrEmpty(txtSayfaSayisi.Text) ? null : int.Parse(txtSayfaSayisi.Text),
                Dil = txtDil.Text
            };

            _kitapService.Guncelle(kitap);

            MessageBox.Show("Kitap güncellendi.");
            KitaplariListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bir kitap seç.");
                return;
            }

            int id = (int)dataGridView1.SelectedRows[0].Cells["KitapID"].Value;

            _kitapService.Sil(id);

            MessageBox.Show("Kitap silindi.");
            KitaplariListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtKitapID.Text = row.Cells["KitapID"].Value.ToString();
                txtKitapAdi.Text = row.Cells["KitapAdi"].Value.ToString();
                txtISBN.Text = row.Cells["ISBN"].Value.ToString();
                txtBasimYili.Text = row.Cells["BasimYili"].Value?.ToString();
                txtSayfaSayisi.Text = row.Cells["SayfaSayisi"].Value?.ToString();
                txtDil.Text = row.Cells["Dil"].Value?.ToString();
                cmbYazar.SelectedValue = row.Cells["YazarID"].Value;
                cmbYayinevi.SelectedValue = row.Cells["YayineviID"].Value;
                cmbKategori.SelectedValue = row.Cells["KategoriID"].Value;
            }
        }

        private void frmKitapIslemleri_Paint(object sender, PaintEventArgs e)
        {
            int borderSize = 2;
            Color borderColor = Color.DimGray;

            ControlPaint.DrawBorder(e.Graphics,
                                    this.ClientRectangle,
                                    borderColor, borderSize, ButtonBorderStyle.Solid,
                                    borderColor, borderSize, ButtonBorderStyle.Solid,
                                    borderColor, borderSize, ButtonBorderStyle.Solid,
                                    borderColor, borderSize, ButtonBorderStyle.Solid);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
