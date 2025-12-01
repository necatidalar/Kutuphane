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

            var personel = _service.Login(kullaniciAdi, sifre);

            if (personel != null)
            {
                MessageBox.Show($"Hoşgeldiniz {personel.AdSoyad}!");
                frmDashboard dashboard = new frmDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
