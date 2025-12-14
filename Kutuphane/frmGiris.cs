using Core.Utility.Results;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.Entity;

namespace Kutuphane.UI
{
    public partial class frmGiris : Form
    {

        private readonly PersonelManager _personelManager;
        //public string GirisYapanKullanici { get; private set; }
        public int GirisYapanPersonelId { get; private set; }
        public string GirisYapanPersonelAd { get; private set; }
        public string GirisYapanPersonelSoyad { get; private set; }

        public frmGiris()
        {
            InitializeComponent();
            _personelManager = new PersonelManager(new PersonelDal());
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            textBox_Sifre.UseSystemPasswordChar = true;

            if (Properties.Settings.Default.RememberMe)
            {
                textBox_KullaniciAdi.Text = Properties.Settings.Default.SavedUserName;
                textBox_Sifre.Text = Properties.Settings.Default.SavedPassword;
                checkBox_BeniHatirla.Checked = true;
            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox_KullaniciAdi.Text;
            string sifre = textBox_Sifre.Text;

            IDataResult<Personel> result = _personelManager.Login(kullaniciAdi, sifre);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Giriş Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBox_BeniHatirla.Checked)
            {
                Properties.Settings.Default.SavedUserName = kullaniciAdi;
                Properties.Settings.Default.SavedPassword = sifre;
                Properties.Settings.Default.RememberMe = true;
            }
            else
            {
                Properties.Settings.Default.SavedUserName = "";
                Properties.Settings.Default.SavedPassword = "";
                Properties.Settings.Default.RememberMe = false;
            }

            Properties.Settings.Default.Save();


            //GirisYapanKullanici = result.Data.KullaniciAdi;
            GirisYapanPersonelId = result.Data.PersonelId;
            GirisYapanPersonelAd = result.Data.Ad;
            GirisYapanPersonelSoyad = result.Data.Soyad;

            MessageBox.Show(result.Message, "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}