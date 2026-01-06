using Core.Helpers;
using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.DAL.Contexes;
using Kutuphane.Model.DTO;
using Kutuphane.UI.UIMetodlar;

namespace Kutuphane.UI
{
    public partial class frmMain : Form
    {
        KitapManager _kitapManager;
        UyeManager _uyeManager;
        OduncManager _oduncManager;
        YayineviManager _yayineviManager;
        YazarManager _yazarManager;

        public int GirisYapanPersonelId { get; set; }
        public string GirisYapanPersonelAd { get; private set; }
        public string GirisYapanPersonelSoyad { get; private set; }
        public PersonelBilgileriDto loginPersoneli { get; set; }
        private readonly YetkiKontrol _yetkiKontrol;
        private readonly IPersonelService _personelService;
        private HashSet<string> _userPermissions = new HashSet<string>();

        public frmMain()
        {
            InitializeComponent();

            _kitapManager = new KitapManager(new KitapDal());
            _uyeManager = new UyeManager(new UyeDal());
            _oduncManager = new OduncManager(new OduncDal());
            _yazarManager = new YazarManager(new YazarDal());
            _yayineviManager = new YayineviManager(new YayineviDal());
            loginPersoneli = new PersonelBilgileriDto();
            _yetkiKontrol = new YetkiKontrol(new KutuphaneDbContext());
            _personelService = new PersonelManager(new PersonelDal());
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //panel_Giris.Location = new Point(0, 0);
            panel_Giris.Anchor = AnchorStyles.None;
            CheckDatabaseConnection();

            if (Properties.Settings.Default.RememberMe)
            {
                textBox_KullaniciAdi.Text = Properties.Settings.Default.SavedUserName;
                textBox_Sifre.Text = Properties.Settings.Default.SavedPassword;
                checkBox_BeniHatirla.Checked = true;
            }
            this.Resize += (s, e) =>
            {
                if (panel_Giris.Visible)
                    CenterLoginPanel();
            };
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
                MessageBox.Show(result.Message, "Giriş Hatalı",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var personelResult = _personelService.PersonelBilgiGetirServis(
                p => p.KullaniciAdi == loginUserDto.KullaniciAdi);

            if (!personelResult.IsSuccess || personelResult.Data.Count == 0)
            {
                MessageBox.Show("Personel bilgileri alınamadı", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBox_BeniHatirla.Checked)
            {
                Properties.Settings.Default.SavedUserName = textBox_KullaniciAdi.Text;
                Properties.Settings.Default.SavedPassword = textBox_Sifre.Text;
                Properties.Settings.Default.RememberMe = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.SavedUserName = "";
                Properties.Settings.Default.SavedPassword = "";
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.Save();
            }
            gostegePanelGoster();
            girisBasarili(personelResult.Data.First());
        }
        private void girisBasarili(PersonelBilgileriDto personel)
        {
            loginPersoneli = personel;

            GirisYapanPersonelId = personel.PersonelId;
            GirisYapanPersonelAd = personel.Ad;
            GirisYapanPersonelSoyad = personel.Soyad;

            _userPermissions = _yetkiKontrol.KullaniciYetkileriniAl(GirisYapanPersonelId);
            MenuYetkiKontrol();

            lblKullaniciAdi.Text = $"Hoşgeldin, {GirisYapanPersonelAd} {GirisYapanPersonelSoyad}";

            panel_Giris.Visible = false;
            panel_Ust.Visible = true;
            menuStrip1.Visible = true;

            SetForLoginView(false);
            ShowHideTopPanels(true, true);

            Listele();
        }
        private void MenuYetkiKontrol()
        {
            bool dashboardMenu = _userPermissions.Contains("DASHBOARD");

            gostergePaneliToolStripMenuItem.Visible = dashboardMenu;
            flowLayoutPanel_Kartlar.Visible = dashboardMenu;

            yerlesimAyarlariToolStripMenuItem.Visible = _userPermissions.Contains("YERLESIM_AYARLARI");
            raporlamaToolStripMenuItem.Visible = _userPermissions.Contains("RAPORLAMA");
            ayarlarToolStripMenuItem.Visible = _userPermissions.Contains("AYARLAR");

            bool dilMenu =
                _userPermissions.Contains("DIL_LISTELE") ||
                _userPermissions.Contains("DIL_EKLE") ||
                _userPermissions.Contains("DIL_GUNCELLE") ||
                _userPermissions.Contains("DIL_SIL");

            dilToolStripMenuItem.Visible = dilMenu;

            bool kitapMenu =
                _userPermissions.Contains("KITAP_LISTELE") ||
                _userPermissions.Contains("KITAP_EKLE") ||
                _userPermissions.Contains("KITAP_GUNCELLE") ||
                _userPermissions.Contains("KITAP_SIL");

            kitapToolStripMenuItem.Visible = kitapMenu;

            bool kategoriMenu =
                _userPermissions.Contains("KATEGORI_LISTELE") ||
                _userPermissions.Contains("KATEGORI_EKLE") ||
                _userPermissions.Contains("KATEGORI_GUNCELLE") ||
                _userPermissions.Contains("KATEGORI_SIL");

            kategoriIslemleriToolStripMenuItem.Visible = kategoriMenu;

            bool yazarMenu =
                _userPermissions.Contains("YAZAR_LISTELE") ||
                _userPermissions.Contains("YAZAR_EKLE") ||
                _userPermissions.Contains("YAZAR_GUNCELLE") ||
                _userPermissions.Contains("YAZAR_SIL");

            yazarToolStripMenuItem.Visible = yazarMenu;

            bool yayineviMenu =
                _userPermissions.Contains("YAYINEVI_LISTELE") ||
                _userPermissions.Contains("YAYINEVI_EKLE") ||
                _userPermissions.Contains("YAYINEVI_GUNCELLE") ||
                _userPermissions.Contains("YAYINEVI_SIL");

            yayineviToolStripMenuItem.Visible = yayineviMenu;

            bool oduncMenu =
                _userPermissions.Contains("ODUNC_LISTELE") ||
                _userPermissions.Contains("ODUNC_VER") ||
                _userPermissions.Contains("IADE_AL");

            oduncToolStripMenuItem.Visible = oduncMenu;

            bool uyeMenu =
                _userPermissions.Contains("UYE_LISTELE") ||
                _userPermissions.Contains("UYE_EKLE") ||
                _userPermissions.Contains("UYE_GUNCELLE") ||
                _userPermissions.Contains("UYE_SIL");

            uyeToolStripMenuItem.Visible = uyeMenu;

            bool personelMenu =
                _userPermissions.Contains("PERSONEL_LISTELE") ||
                _userPermissions.Contains("PERSONEL_EKLE") ||
                _userPermissions.Contains("PERSONEL_GUNCELLE") ||
                _userPermissions.Contains("PERSONEL_SIL");

            personelToolStripMenuItem.Visible = personelMenu;

            bool yonetimMenu =
                _userPermissions.Contains("YONETIM_LISTELE") ||
                _userPermissions.Contains("YONETIM_EKLE") ||
                _userPermissions.Contains("YONETIM_GUNCELLE") ||
                _userPermissions.Contains("YONETIM_SIL");

            yonetimToolStripMenuItem.Visible = yonetimMenu;
        }
        private void CheckDatabaseConnection()
        {
            try
            {
                using (var context = new KutuphaneDbContext())
                {
                    if (context.Database.CanConnect())
                    {
                        Logout();
                        label_Mesaj.Visible = false;
                    }
                    else
                    {
                        label_Mesaj.Visible = true;
                        label_Mesaj.Text = "Veritabanı: Bağlantı Yok";
                        label_Mesaj.ForeColor = Color.Red;
                        menuStrip1.Enabled = false;
                        flowLayoutPanel_Kartlar.Visible = false;
                        lblKullaniciAdi.Visible = false;
                        panel_Giris.Visible = false;
                    }
                }
            }
            catch
            {
                label_Mesaj.Text = "Veritabanı: Hata";
                label_Mesaj.ForeColor = Color.DarkRed;
            }
        }
        private void ShowHideTopPanels(bool showDashboard, bool showMenu)
        {
            bool hasDashboardPermission = _userPermissions.Contains("DASHBOARD");

            flowLayoutPanel_Kartlar.Visible = showDashboard && hasDashboardPermission;
            menuStrip1.Visible = showMenu;

            if (showDashboard && flowLayoutPanel_Kartlar.Visible)
                timer_Dashboard.Start();
            else
                timer_Dashboard.Stop();
        }
        private void SetForLoginView(bool login)
        {
            panel_Ust.Visible = !login;
            ShowHideTopPanels(!login, !login);

            if (login)
            {
                MinimumSize = new Size(635, 350);
                ClientSize = new Size(635, 350);
                WindowState = FormWindowState.Normal;
                StartPosition = FormStartPosition.CenterScreen;
                MaximizeBox = true;
                FormBorderStyle = FormBorderStyle.Sizable;
                CenterLoginPanel();
            }
            else
            {
                MinimumSize = new Size(1024, 768);
                MaximizeBox = true;
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.Sizable;
            }

            AutoSize = false;
        }
        private void CenterLoginPanel()
        {
            panel_Giris.Left = (this.ClientSize.Width - panel_Giris.Width) / 2;
            panel_Giris.Top = (this.ClientSize.Height - panel_Giris.Height) / 2;
        }
        private void Logout()
        {
            GirisYapanPersonelId = 0;
            GirisYapanPersonelAd = null;
            GirisYapanPersonelSoyad = null;
            loginPersoneli = null;

            lblKullaniciAdi.Text = string.Empty;

            foreach (Form child in MdiChildren)
                child.Close();

            timer_Dashboard.Stop();

            panel_Giris.Visible = true;
            panel_Ust.Visible = false;
            flowLayoutPanel_Kartlar.Visible = false;
            menuStrip1.Visible = false;

            SetForLoginView(true);
        }
        private void Listele()
        {
            if (WindowState != FormWindowState.Maximized)
            {
                menuStrip1.Dock = DockStyle.Left;
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
            }
            var kitapResult = _kitapManager.GetListByFilterService(x => x.Aktif == true);
            label_KitapSayisi.Text = kitapResult.IsSuccess
                ? kitapResult.Data.Count.ToString()
                : "0";

            var uyeResult = _uyeManager.GetListByFilterService(x => x.AktifMi == true);
            label_UyeSayisi.Text = uyeResult.IsSuccess
                ? uyeResult.Data.Count.ToString()
                : "0";

            int erkekSayisi = _uyeManager
                .GetListByFilterService(x => x.AktifMi && x.Cinsiyet.CinsiyetAdi == "Erkek")
                .Data?.Count ?? 0;

            int kadinSayisi = _uyeManager
                .GetListByFilterService(x => x.AktifMi && x.Cinsiyet.CinsiyetAdi == "Kadın")
                .Data?.Count ?? 0;

            label_UyeErkekSayisi.Text = $"Erkek: {erkekSayisi}";
            label_UyeKadinSayisi.Text = $"Kadın: {kadinSayisi}";


            var oduncResult = _oduncManager.GetListByFilterService(x =>
                x.TeslimEdildi == false);

            int oduncSayisi = oduncResult.IsSuccess ? oduncResult.Data.Count : 0;
            label_OduncSayisi.Text = oduncSayisi.ToString();

            var gecikmisResult = _oduncManager.GetListByFilterService(x =>
                x.TeslimEdildi == false &&
                x.TeslimTarihi < DateTime.Now);

            int gecikmisSayisi = gecikmisResult.IsSuccess ? gecikmisResult.Data.Count : 0;
            label_GecikmisUyeSayisi.Text = gecikmisSayisi.ToString();

            var yazarResult = _yazarManager.GetListByFilterService(x => x.AktifMi == true);
            label_YazarSayisi.Text = yazarResult.IsSuccess
                ? yazarResult.Data.Count.ToString()
                : "0";

            var yayineviResult = _yayineviManager.GetListByFilterService(x => x.AktifMi == true);
            label_YayineviSayisi.Text = yayineviResult.IsSuccess
                ? yayineviResult.Data.Count.ToString()
                : "0";
        }
        private void menuStrip_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem == null || menuItem.Tag == null) return;

            FormAcByFormAdi(menuItem.Tag.ToString());

            label_Mesaj.Text = $" {menuItem.Text}";
        }
        private void timer_Dashboard_Tick(object sender, EventArgs e)
        {
            Listele();
        }
        private Type FormAdindanFormBul(string searchTag)
        {
            try
            {
                var formTypes = System.Reflection.Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.IsSubclassOf(typeof(Form)) && !t.IsAbstract);

                foreach (var formType in formTypes)
                {
                    var constructorWithParam = formType.GetConstructor(new[] { typeof(int) });

                    if (constructorWithParam != null)
                    {
                        using (var tempForm = (Form)Activator.CreateInstance(formType, new object[] { GirisYapanPersonelId }))
                        {
                            if (tempForm.Name != null &&
                                tempForm.Name.Equals(searchTag, StringComparison.OrdinalIgnoreCase))
                            {
                                return formType;
                            }
                        }
                    }
                    else
                    {
                        using (var tempForm = (Form)Activator.CreateInstance(formType))
                        {
                            if (tempForm.Name != null &&
                                tempForm.Name.Equals(searchTag, StringComparison.OrdinalIgnoreCase))
                            {
                                return formType;
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Form arama hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void FormAcByFormAdi(string FormName)
        {
            var formType = FormAdindanFormBul(FormName);

            if (formType == null)
            {
                MessageBox.Show($"'{FormName}' tag'ine sahip form bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowHideTopPanels(false, true);

            Form? childForm;
            var constructorWithParam = formType.GetConstructor(new[] { typeof(int) });

            if (constructorWithParam != null)
            {
                childForm = (Form)Activator.CreateInstance(formType, new object[] { GirisYapanPersonelId });
            }
            else
            {
                childForm = (Form)Activator.CreateInstance(formType);
            }

            if (childForm == null) return;

            if (childForm is frmOduncIslemleri oduncForm)
            {
                oduncForm.GirisYapanPersonelId = this.GirisYapanPersonelId;
            }

            ActiveMdiChild?.Close();
            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            lblKullaniciAdi.Visible = false;
            label_Mesaj.Visible = true;

            string baslik = string.IsNullOrEmpty(childForm.Text) ? FormName : childForm.Text;
            label_Mesaj.Text = $" {baslik}";
            label_Mesaj.ForeColor = Color.White;
            childForm.Show();
        }
        private void gostergePaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gostegePanelGoster();
        }
        private void gostegePanelGoster()
        {
            Listele();
            ShowHideTopPanels(true, true);

            label_Mesaj.Visible = false;
            lblKullaniciAdi.Visible = true;
            lblKullaniciAdi.Text = $"Hoşgeldin, {GirisYapanPersonelAd} {GirisYapanPersonelSoyad}";
        }
        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }
    }
}