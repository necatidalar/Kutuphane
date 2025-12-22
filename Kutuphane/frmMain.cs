using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.DAL.Contexes;
using Kutuphane.Model.DTO;

namespace Kutuphane.UI
{
    public partial class frmMain : Form
    {
        KitapManager _kitapManager;
        UyeManager _uyeManager;
        OduncManager _oduncManager;
        public int GirisYapanPersonelId { get; set; }
        public string GirisYapanPersonelAd { get; private set; }
        public string GirisYapanPersonelSoyad { get; private set; }
        public PersonelBilgileriDto loginPersoneli { get; set; }
        public frmMain()
        {
            InitializeComponent();

            _kitapManager = new KitapManager(new KitapDal());
            _uyeManager = new UyeManager(new UyeDal());
            loginPersoneli = new PersonelBilgileriDto();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            CheckDatabaseConnection();
            //SetForLoginView(true);
            //Logout();
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
            //panel_Ust.Visible = showDashboard;
            flowLayoutPanel_Kartlar.Visible = showDashboard;
            menuStrip1.Visible = showMenu;

            if (showDashboard)
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
                ClientSize = new Size(635, 350);
                WindowState = FormWindowState.Normal;
                StartPosition = FormStartPosition.CenterScreen;
                //FormBorderStyle = FormBorderStyle.None;
                MaximizeBox = false;
                FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            else
            {
                MaximizeBox = true;
                //FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.Sizable;
            }

            AutoSize = false;
        }
        private void Listele()
        {
            var kitapResult = _kitapManager.GetListByFilterService(x => x.Aktif == true);
            int toplamKitap = kitapResult.IsSuccess ? kitapResult.Data.Count : 0;
            label_KitapSayisi.Text = toplamKitap.ToString();

            var uyeResult = _uyeManager.GetListByFilterService(x => x.AktifMi == true);
            int toplamUye = uyeResult.IsSuccess ? uyeResult.Data.Count : 0;
            label_UyeSayisi.Text = toplamUye.ToString();

            var oduncVerilenKitapResult = _kitapManager.GetListByFilterService();
            int oduncVerilenKitapSayisi = oduncVerilenKitapResult.IsSuccess ? oduncVerilenKitapResult.Data.Count : 0;
            label_OduncSayisi.Text = oduncVerilenKitapSayisi.ToString();
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
                    using (var tempForm = (Form)Activator.CreateInstance(formType))
                    {
                        if (tempForm.Name != null &&
                            tempForm.Name.Equals(searchTag, StringComparison.OrdinalIgnoreCase))
                        {
                            return formType;
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
                MessageBox.Show($"'{FormName}' tag'ine sahip form bulunamadı.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowHideTopPanels(false, true);

            Form? childForm = (Form)Activator.CreateInstance(formType);
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

            SetForLoginView(true);

            frmGiris girisForm = new frmGiris();
            girisForm.MdiParent = this;
            girisForm.FormClosed += LoginFormClosed;
            girisForm.Show();
        }
        private void LoginFormClosed(object sender, FormClosedEventArgs e)
        {
            frmGiris girisForm = sender as frmGiris;

            if (girisForm?.GirisYapanPersonel == null)
            {
                Application.Exit();
                return;
            }

            loginPersoneli = girisForm.GirisYapanPersonel;

            GirisYapanPersonelId = loginPersoneli.PersonelId;
            GirisYapanPersonelAd = loginPersoneli.Ad;
            GirisYapanPersonelSoyad = loginPersoneli.Soyad;

            lblKullaniciAdi.Text =
                $"Hoşgeldin, {GirisYapanPersonelAd} {GirisYapanPersonelSoyad}";

            SetForLoginView(false);
            ShowHideTopPanels(true, true);
            timer_Dashboard.Start();
            Listele();
        }
    }
}