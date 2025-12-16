using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.DTO;

namespace Kutuphane.UI
{
    public partial class frmMain : Form
    {
        KitapManager _kitapManager;
        UyeManager _uyeManager;

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
            SetForLoginView(true);

            frmGiris girisForm = new frmGiris();
            girisForm.MdiParent = this;
            ActivateMdiChild(girisForm);
            girisForm.Show();
            girisForm.FormClosed += (s, args) =>
            {
                if (girisForm.GirisYapanPersonel != null && girisForm.GirisYapanPersonel.PersonelId > 0)
                {
                    loginPersoneli = girisForm.GirisYapanPersonel;
                    this.GirisYapanPersonelId = loginPersoneli.PersonelId;
                    this.GirisYapanPersonelAd = loginPersoneli.Ad;
                    this.GirisYapanPersonelSoyad = loginPersoneli.Soyad;
                    lblKullaniciAdi.Text = $"Hoşgeldin, {this.GirisYapanPersonelAd} {this.GirisYapanPersonelSoyad}";
                    SetForLoginView(false);
                    ShowHideTopPanels(true, true);
                    Listele();
                }
                else
                {
                    Application.Exit();
                }
            };

        }
        private void ShowHideTopPanels(bool showDashboard, bool showMenu)
        {
            panel_Ust.Visible = showDashboard;
            flowLayoutPanel_Kartlar.Visible = showDashboard;
            menuStrip1.Visible = showMenu;
            if (showDashboard)
                timer_Dashboard.Start();
            else
                timer_Dashboard.Stop();
        }
        private void SetForLoginView(bool login)
        {
            ShowHideTopPanels(!login, !login);
            //FormBorderStyle = login ? FormBorderStyle.None : FormBorderStyle.Sizable;
            WindowState = login ? FormWindowState.Normal : FormWindowState.Maximized;
            //AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoSize = false /*login*/;
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
        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
        }
        private void menuStrip_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem == null)
                return;
            if (menuItem.Tag == null)
                return;

            FormAcByFormAdi(menuItem.Tag.ToString());
        }
        private void timer_Dashboard_Tick(object sender, EventArgs e)
        {
            Listele();
        }
        private Type FormAdindanFormBul(string searchTag)
        {
            try
            {
                // Assembly'deki tüm Form türlerini al
                var formTypes = System.Reflection.Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.IsSubclassOf(typeof(Form)) && !t.IsAbstract);

                foreach (var formType in formTypes)
                {
                    // Form instance'ı oluştur (geçici olarak)
                    using (var tempForm = (Form)Activator.CreateInstance(formType))
                    {
                        // Tag özelliğini kontrol et
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

            // Form'u aç
            ShowHideTopPanels(false, true);
            Form? childForm = (Form)Activator.CreateInstance(formType);
            if (childForm == ActiveMdiChild || childForm == null)
                return;

            ActiveMdiChild?.Close();
            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            ActivateMdiChild(childForm);
            childForm.Dock = DockStyle.Fill;
            childForm.Show();

        }
        private void gostergePaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele();
        }
        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHideTopPanels(false, true);
            frmGiris girisForm = new frmGiris();
            girisForm.MdiParent = this;
            ActivateMdiChild(girisForm);

            girisForm.Show();
        }
    }
}