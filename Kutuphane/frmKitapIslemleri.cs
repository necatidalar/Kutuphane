using Kutuphane.BLL.Abstract;
using Kutuphane.DAL;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;

namespace Kutuphane.UI
{
    public partial class frmKitapIslemleri : Form
    {
        public frmKitapIslemleri()
        {
            InitializeComponent();

        }

        private void frmKitapIslemleri_Load(object sender, EventArgs e)
        {
            KitaplariListele();
            CombosDoldur();
            dataGridView1.ForeColor = Color.Black;
        }

        //private readonly YazarService _yazarService;
        //private readonly YayineviService _yayineviService;
        //private readonly KategoriService _kategoriService;

        private void KitaplariListele()
        {
            
            using (var db = new KutuphaneDbContext())
            {
                var liste = db.Kitaplar
                    .Where(k => k.Aktif)
                    .Select(x => new KitapDto
                    {
                        KitapID = x.KitapID,
                        KitapAdi = x.KitapAdi,
                        ISBN = x.ISBN,
                        BasimYili = x.BasimYili,
                        SayfaSayisi = x.SayfaSayisi,
                        Dil = x.Dil,
                        Stok = x.Stok,
                        YazarID = x.YazarID,
                        YayineviID = x.YayineviID,
                        KategoriID = x.KategoriID,
                        //YazarAdi = x.Yazar.Ad + " " + x.Yazar.Soyad,
                        //YayineviAdi = x.Yayinevi.Ad,
                        //KategoriAdi = x.Kategori.KategoriAdi
                    })
                    .OrderBy(x => x.KitapAdi)
                    .ToList();


                dataGridView1.DataSource = liste;

                dataGridView1.Columns["KitapID"].Visible = false;
                dataGridView1.Columns["YazarID"].Visible = false;
                dataGridView1.Columns["YayineviID"].Visible = false;
                dataGridView1.Columns["KategoriID"].Visible = false;

                dataGridView1.Columns["YazarAdi"].HeaderText = "Yazar";
                dataGridView1.Columns["YayineviAdi"].HeaderText = "Yayınevi";
                dataGridView1.Columns["KategoriAdi"].HeaderText = "Kategori";

                var silinenVar = db.Kitaplar.Any(k => !k.Aktif);
                btnSilinenleriGoster.Visible = silinenVar;
                btnGeriYukle.Visible = false;
            }
        }


        private void CombosDoldur()
        {
            //var yazarlar = _yazarService.Listele()
            //    .Select(y => new
            //    {
            //        YazarID = y.YazarID,
            //        AdSoyad = y.Ad + " " + y.Soyad
            //    })
            //    .ToList();
            //cmbYazar.DataSource = yazarlar;
            //cmbYazar.DisplayMember = "AdSoyad";
            //cmbYazar.ValueMember = "YazarID";
            //cmbYazar.SelectedIndex = -1;

            //var yayinevleri = _yayineviService.Listele()
            //    .Select(y => new
            //    {
            //        y.YayineviID,
            //        y.Ad
            //    })
            //    .ToList();
            //cmbYayinevi.DataSource = yayinevleri;
            //cmbYayinevi.DisplayMember = "Ad";
            //cmbYayinevi.ValueMember = "YayineviID";
            //cmbYayinevi.SelectedIndex = -1;

            //var kategoriler = _kategoriService.Listele()
            //    .Select(k => new
            //    {
            //        k.KategoriID,
            //        k.KategoriAdi
            //    })
            //    .ToList();
            //cmbKategori.DataSource = kategoriler;
            //cmbKategori.DisplayMember = "KategoriAdi";
            //cmbKategori.ValueMember = "KategoriID";
            //cmbKategori.SelectedIndex = -1;
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
                BasimYili = string.IsNullOrEmpty(txtBasimYili.Text) ? (int?)null : int.Parse(txtBasimYili.Text),
                SayfaSayisi = string.IsNullOrEmpty(txtSayfaSayisi.Text) ? (int?)null : int.Parse(txtSayfaSayisi.Text),
                Dil = txtDil.Text,
                Stok = string.IsNullOrEmpty(txtStok.Text) ? 0 : int.Parse(txtStok.Text)
            };

            //var result = _kitapService.Ekle(kitap);
            //MessageBox.Show(result.Mesaj);
            //if (result.Basarili)
            //    KitaplariListele();

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
                BasimYili = string.IsNullOrEmpty(txtBasimYili.Text) ? (int?)null : int.Parse(txtBasimYili.Text),
                SayfaSayisi = string.IsNullOrEmpty(txtSayfaSayisi.Text) ? (int?)null : int.Parse(txtSayfaSayisi.Text),
                Dil = txtDil.Text,
                Stok = string.IsNullOrEmpty(txtStok.Text) ? 0 : int.Parse(txtStok.Text)
            };

            //var result = _kitapService.Guncelle(kitap);
            //MessageBox.Show(result.Mesaj);

            //if (result.Basarili)
            //    KitaplariListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Bir kitap seç.");
            //    return;
            //}

            //int id = (int)dataGridView1.SelectedRows[0].Cells["KitapID"].Value;

            //var confirmResult = MessageBox.Show(
            //    "Bu kitabı silmek istediğinizden emin misiniz?",
            //    "Onay",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question
            //);

            //if (confirmResult == DialogResult.Yes)
            //{
            //    var result = _kitapService.Sil(id);
            //    MessageBox.Show(result.Mesaj);

            //    if (result.Basarili)
            //        KitaplariListele();
            //}
            //else
            //{
            //    return;
            //}
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
                txtStok.Text = row.Cells["Stok"].Value?.ToString();
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

        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {
            //using (var db = new KutuphaneDbContext())
            //{
            //    var liste = db.Kitaplar
            //        .Where(k => k.Aktif)
            //        .Select(x => new KitapDTO
            //        {
            //            KitapID = x.KitapID,
            //            KitapAdi = x.KitapAdi,
            //            ISBN = x.ISBN,
            //            BasimYili = x.BasimYili,
            //            SayfaSayisi = x.SayfaSayisi,
            //            Dil = x.Dil,
            //            Stok = x.Stok,
            //            YazarID = x.YazarID,
            //            YayineviID = x.YayineviID,
            //            KategoriID = x.KategoriID,
            //            YazarAdi = x.Yazar.Ad + " " + x.Yazar.Soyad,
            //            YayineviAdi = x.Yayinevi.Ad,
            //            KategoriAdi = x.Kategori.KategoriAdi
            //        })
            //        .OrderBy(x => x.KitapAdi)
            //        .ToList();


            //    dataGridView1.DataSource = liste;

            //    btnGeriYukle.Visible = liste.Any();
            //}
        }
        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Geri yüklemek için bir kitap seçin.");
            //    return;
            //}

            //int id = (int)dataGridView1.SelectedRows[0].Cells["KitapID"].Value;

            //var confirmResult = MessageBox.Show(
            //    "Bu kitabı tekrar aktif hale getirmek istiyor musunuz?",
            //    "Onay",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question
            //);

            //if (confirmResult == DialogResult.Yes)
            //{
            //    var result = _kitapService.GeriYukle(id);
            //    MessageBox.Show(result.Mesaj);

            //    if (result.Basarili)
            //    {
            //        btnSilinenleriGoster_Click(null, null);

            //        using (var db = new KutuphaneDbContext())
            //        {
            //            var silinenVar = db.Kitaplar.Any(k => !k.Aktif);
            //            btnSilinenleriGoster.Visible = silinenVar;
            //            btnGeriYukle.Visible = silinenVar;
            //        }
            //    }
            //}
            //KitaplariListele();
        }
    }
}