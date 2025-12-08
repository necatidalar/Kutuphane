using Kutuphane.BLL.Services;
using Kutuphane.Model.Entity;

namespace Kutuphane.UI
{
    public partial class frmPersonelIslemleri : Form
    {
        //private readonly PersonelService _service;

        //public frmPersonelIslemleri()
        //{
        //    InitializeComponent();
        //    _service = new PersonelService(new EfRepositoryBase<Personel>());
        //}

        //private void frmPersonelIslemleri_Load(object sender, EventArgs e)
        //{
        //    dataGridView1.ForeColor = Color.Black;
        //    LoadPersoneller();
        //}

        //private void LoadPersoneller()
        //{
        //    dataGridView1.DataSource = null;
        //    var personeller = _service.GetAll();
        //    dataGridView1.DataSource = personeller;
        //    dataGridView1.Columns["Oduncler"].Visible = false;
        //}

        //private void btnKaydet_Click(object sender, EventArgs e)
        //{
        //    var personel = new Personel
        //    {
        //        Ad = txtAdSoyad.Text,
        //        KullaniciAdi = txtKullaniciAdi.Text,
        //        Sifre = txtSifre.Text
        //    };

        //    var result = _service.Add(personel);
        //    MessageBox.Show(result.Mesaj);

        //    if (result.Basarili)
        //    {
        //        ClearForm();
        //        LoadPersoneller();
        //    }
        //}

        //private void btnDuzenle_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtPersonelID.Text))
        //    {
        //        MessageBox.Show("Lütfen güncellenecek personeli seçin.");
        //        return;
        //    }

        //    var personel = new Personel
        //    {
        //        PersonelID = int.Parse(txtPersonelID.Text),
        //        Ad = txtAdSoyad.Text,
        //        KullaniciAdi = txtKullaniciAdi.Text,
        //        Sifre = txtSifre.Text
        //    };

        //    var result = _service.Update(personel);
        //    MessageBox.Show(result.Mesaj);

        //    if (result.Basarili)
        //    {
        //        ClearForm();
        //        LoadPersoneller();
        //    }

        //}

        //private void btnSil_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtPersonelID.Text))
        //    {
        //        MessageBox.Show("Lütfen silinecek personeli seçin.");
        //        return;
        //    }

        //    int id = int.Parse(txtPersonelID.Text);
        //    var result = _service.Delete(id);
        //    MessageBox.Show(result.Mesaj);

        //    if (result.Basarili)
        //    {
        //        ClearForm();
        //        LoadPersoneller();
        //    }
        //}

        //private void frmPersonelIslemleri_Paint(object sender, PaintEventArgs e)
        //{
        //    int borderSize = 2;
        //    Color borderColor = Color.DimGray;

        //    ControlPaint.DrawBorder(e.Graphics,
        //                            this.ClientRectangle,
        //                            borderColor, borderSize, ButtonBorderStyle.Solid,
        //                            borderColor, borderSize, ButtonBorderStyle.Solid,
        //                            borderColor, borderSize, ButtonBorderStyle.Solid,
        //                            borderColor, borderSize, ButtonBorderStyle.Solid);
        //}

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        var row = dataGridView1.Rows[e.RowIndex];
        //        txtPersonelID.Text = row.Cells["PersonelID"].Value.ToString();
        //        txtAdSoyad.Text = row.Cells["AdSoyad"].Value.ToString();
        //        txtKullaniciAdi.Text = row.Cells["KullaniciAdi"].Value.ToString();
        //        txtSifre.Text = "";
        //    }
        //}

        //private void btnCikis_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void ClearForm()
        //{
        //    txtPersonelID.Text = "";
        //    txtAdSoyad.Text = "";
        //    txtKullaniciAdi.Text = "";
        //    txtSifre.Text = "";
        //}
    }
}
