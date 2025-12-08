using Kutuphane.BLL.Services;
using Kutuphane.Model.Entity;

namespace Kutuphane.UI
{
    public partial class frmUyeIslemleri : Form
    {
  //      private readonly UyeService _service;

  //      public frmUyeIslemleri()
  //      {
  //          InitializeComponent();
  //          _service = new UyeService(new EfRepositoryBase<Uye>());
  //      }

  //      private void frmUyeIslemleri_Load(object sender, EventArgs e)
  //      {
  //          Listele();
  //          dgvUyeler.ForeColor = Color.Black;
  //      }

  //      private void Listele()
  //      {
  //          dgvUyeler.DataSource = _service.Listele();
  //          dgvUyeler.Columns["UyeID"].Visible = false;
  //          dgvUyeler.Columns["Oduncler"].Visible = false;
  //      }

  //      private Uye FormToUye()
  //      {
  //          int? dogumYili = null;
  //          if (int.TryParse(txtDogumYili.Text, out int yil))
  //          {
  //              dogumYili = yil;
  //          }

  //          string cinsiyet = rbErkek.Checked ? "Erkek" :
  //                            rbKadin.Checked ? "Kadın" : null;

  //          if (cinsiyet == null)
  //              throw new Exception("Cinsiyet seçmelisin.");

  //          return new Uye
  //          {
  //              UyeID = string.IsNullOrEmpty(txtID.Text) ? 0 : Convert.ToInt32(txtID.Text),
  //              TcPass = txtTCPASS.Text,
  //              Ad = txtAd.Text,
  //              Soyad = txtSoyad.Text,
  //              Cinsiyet = cinsiyet,
  //              DogumYili = dogumYili,
  //              Telefon = txtTel.Text,
  //              Eposta = txtEposta.Text,
  //              Adres = txtAdres.Text,
  //              AdresDetay = richTextAdresDetay.Text
  //          };
  //      }

  //      private void UyeToForm(Uye uye)
  //      {
  //          txtID.Text = uye.UyeID.ToString();
  //          txtTCPASS.Text = uye.TcPass;
  //          txtAd.Text = uye.Ad;
  //          txtSoyad.Text = uye.Soyad;

  //          rbErkek.Checked = uye.Cinsiyet == "Erkek";
  //          rbKadin.Checked = uye.Cinsiyet == "Kadın";

  //          txtDogumYili.Text = uye.DogumYili?.ToString();
  //          txtTel.Text = uye.Telefon;
  //          txtEposta.Text = uye.Eposta;
  //          txtAdres.Text = uye.Adres;
  //          richTextAdresDetay.Text = uye.AdresDetay;
  //      }

  //      private void btnKaydet_Click(object sender, EventArgs e)
  //      {
  //          try
  //          {
  //              var uye = FormToUye();

  //              var sonuc = _service.Ekle(uye);

  //              MessageBox.Show(sonuc.Mesaj);

  //              if (sonuc.Basarili)
  //              {
  //                  Listele();
  //                  Temizle();
  //              }
  //          }
  //          catch (Exception ex)
  //          {
  //              MessageBox.Show(ex.Message);
  //          }
  //      }

  //      private void btnDuzenle_Click(object sender, EventArgs e)
  //      {
  //          try
  //          {
  //              var uye = FormToUye();

  //              var sonuc = _service.Guncelle(uye);

  //              MessageBox.Show(sonuc.Mesaj);

  //              if (sonuc.Basarili)
  //              {
  //                  Listele();
  //                  Temizle();
  //              }
  //          }
  //          catch (Exception ex)
  //          {
  //              MessageBox.Show(ex.Message);
  //          }
  //      }

  //      private void btnSil_Click(object sender, EventArgs e)
  //      {
  //          if (string.IsNullOrEmpty(txtID.Text))
  //          {
  //              MessageBox.Show("Silmek için bir üye seç.");
  //              return;
  //          }

  //          int id = Convert.ToInt32(txtID.Text);

  //          var onay = MessageBox.Show(
  //              "Bu üyeyi silmek istediğine emin misin?",
  //              "Onay",
  //              MessageBoxButtons.YesNo,
  //              MessageBoxIcon.Warning);

  //          if (onay != DialogResult.Yes)
  //              return;

  //          var sonuc = _service.Sil(id);

  //          MessageBox.Show(sonuc.Mesaj);

  //          if (sonuc.Basarili)
  //          {
  //              Listele();
  //              Temizle();
  //          }
  //      }

  //      private void dgvUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
  //      {
  //          if (dgvUyeler.CurrentRow == null)
  //              return;

  //          var uye = new Uye
  //          {
  //              UyeID = (int)dgvUyeler.CurrentRow.Cells["UyeID"].Value,
  //              TcPass = dgvUyeler.CurrentRow.Cells["TcPass"].Value.ToString(),
  //              Ad = dgvUyeler.CurrentRow.Cells["Ad"].Value.ToString(),
  //              Soyad = dgvUyeler.CurrentRow.Cells["Soyad"].Value.ToString(),
  //              Cinsiyet = dgvUyeler.CurrentRow.Cells["Cinsiyet"].Value.ToString(),
  //              DogumYili = dgvUyeler.CurrentRow.Cells["DogumYili"].Value as int?,
  //              Telefon = dgvUyeler.CurrentRow.Cells["Telefon"].Value.ToString(),
  //              Eposta = dgvUyeler.CurrentRow.Cells["Eposta"].Value.ToString(),
  //              Adres = dgvUyeler.CurrentRow.Cells["Adres"].Value.ToString(),
  //              AdresDetay = dgvUyeler.CurrentRow.Cells["AdresDetay"].Value.ToString()
  //          };

  //          UyeToForm(uye);
  //      }

		//private void Temizle()
  //      {
  //          txtID.Text = "";
  //          txtTCPASS.Text = "";
  //          txtAd.Text = "";
  //          txtSoyad.Text = "";
  //          txtDogumYili.Text = "";
  //          txtTel.Text = "";
  //          txtEposta.Text = "";
  //          txtAdres.Text = "";
  //          richTextAdresDetay.Text = "";
  //          rbErkek.Checked = false;
  //          rbKadin.Checked = false;
  //      }
  //      private void frmUyeIslemleri_Paint(object sender, PaintEventArgs e)
  //      {
  //          int borderSize = 2;
  //          Color borderColor = Color.DimGray;

  //          ControlPaint.DrawBorder(e.Graphics,
  //                                  this.ClientRectangle,
  //                                  borderColor, borderSize, ButtonBorderStyle.Solid,
  //                                  borderColor, borderSize, ButtonBorderStyle.Solid,
  //                                  borderColor, borderSize, ButtonBorderStyle.Solid,
  //                                  borderColor, borderSize, ButtonBorderStyle.Solid);
  //      }

  //      private void btnCikis_Click(object sender, EventArgs e)
  //      {
  //          this.Close();
  //      }
    }
}
