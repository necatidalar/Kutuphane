using Core.Helpers;
using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.DTO;

namespace Kutuphane.UI
{
    public partial class frmGiris : Form
    {

        private readonly IPersonelService _personelService;

        internal PersonelBilgileriDto GirisYapanPersonel = new();

        public frmGiris()
        {
            InitializeComponent();
            _personelService = new PersonelManager(new PersonelDal());
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

        private void btnGiris_Click(object sender, EventArgs e)
        {
            LoginUserDto loginUserDto = new()
            {
                KullaniciAdi = textBox_KullaniciAdi.Text,
                Sifre = SecurityHelper.EncodeBase64(textBox_Sifre.Text)
            };

            var result = _personelService.Login(loginUserDto);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Giriş Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBox_BeniHatirla.Checked)
            {
                Properties.Settings.Default.SavedUserName = textBox_KullaniciAdi.Text;
                Properties.Settings.Default.SavedPassword = textBox_Sifre.Text;
                Properties.Settings.Default.RememberMe = true;
            }
            else
            {
                Properties.Settings.Default.SavedUserName = "";
                Properties.Settings.Default.SavedPassword = "";
                Properties.Settings.Default.RememberMe = false;
            }

            Properties.Settings.Default.Save();

            var personelResult = _personelService.PersonelBilgiGetirServis(p => p.KullaniciAdi == loginUserDto.KullaniciAdi);
            if (!personelResult.IsSuccess || personelResult.Data.Count == 0)
            {
                MessageBox.Show("Giriş yapan personel bilgileri alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GirisYapanPersonel = personelResult.Data.FirstOrDefault();

            this.DialogResult = DialogResult.OK;
            this.Close();
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
    }
}