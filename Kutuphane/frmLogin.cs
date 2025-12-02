using Kutuphane.BLL.Services;
using Kutuphane.DAL.Repository;
using Kutuphane.Model.Entity;

namespace Kutuphane.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            _service = new PersonelService(new Repository<Personel>());
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
        }

        private readonly PersonelService _service;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //var personel = new Personel
            //{
            //    AdSoyad = textBox1.Text,
            //    KullaniciAdi = txtKullaniciAdi.Text,
            //    Sifre = txtSifre.Text
            //};

            //_service.Add(personel);

            //MessageBox.Show("Personel başarıyla kaydedildi.");


            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            Personel personel;
            var result = _service.Login(kullaniciAdi, sifre, out personel);

            if (!result.Basarili)
            {
                MessageBox.Show(result.Mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmDashboard dashboard = new frmDashboard();
            dashboard.GirisYapanKullanici = personel.AdSoyad;
            dashboard.Show();
            this.Hide();

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
