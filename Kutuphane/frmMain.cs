using Core.Helpers;
using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.DAL.Contexes;
using Kutuphane.Model.DTO;
using Kutuphane.UI.UIMetodlar;
using System.Data;

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
        private readonly IPersonelRolService _personelRolService;
        private HashSet<string> _userPermissions = new HashSet<string>();
        private const int VarsayilanKurumId = 1;

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
            _personelRolService = new PersonelRolManager(new PersonelRolDal());

            AyarMenuleriniHazirla();
        }
        private void AyarMenuleriniHazirla()
        {
            if (ayarlarToolStripMenuItem == null)
                return;

            bool dashboardAyariVar = ayarlarToolStripMenuItem.DropDownItems
                .Cast<ToolStripItem>()
                .Any(x => x.Name == "dashboardAyarlariToolStripMenuItem");

            if (dashboardAyariVar)
                return;

            var dashboardAyarlariMenu = new ToolStripMenuItem
            {
                Name = "dashboardAyarlariToolStripMenuItem",
                Text = "📊 Dashboard Ayarları",
                Tag = "frmDashboardAyarlari",
                ForeColor = Color.FromArgb(44, 62, 80)
            };

            dashboardAyarlariMenu.Click += menuStrip_Click;
            ayarlarToolStripMenuItem.DropDownItems.Add(dashboardAyarlariMenu);
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
            girisBasarili(personelResult.Data.First());
        }
        private void girisBasarili(PersonelBilgileriDto personel)
        {
            loginPersoneli = personel;

            GirisYapanPersonelId = personel.PersonelId;
            GirisYapanPersonelAd = personel.Ad;
            GirisYapanPersonelSoyad = personel.Soyad;

            _userPermissions = _yetkiKontrol.KullaniciYetkileriniAl(GirisYapanPersonelId);

            if (!DinamikMenuleriYukle())
            {
                SabitMenuleriYukle();
                AyarMenuleriniHazirla();
                MenuYetkiKontrol();
            }

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
            if (DinamikDashboardKartlariniYukle())
                return;

            SabitDashboardVerileriniYukle();
        }

        private bool DinamikDashboardKartlariniYukle()
        {
            try
            {
                var v2Dashboard = Helpers.V2ServiceFactory.DashboardMenuService();
                var widgetResult = v2Dashboard.DashboardWidgetlariniGetir(VarsayilanKurumId, AktifRolIdGetir());

                if (!widgetResult.IsSuccess || widgetResult.Data == null || !widgetResult.Data.Any())
                    return false;

                var widgetlar = widgetResult.Data
                    .Where(x => x.GorunurMu)
                    .OrderBy(x => x.SiraNo)
                    .ThenBy(x => x.Baslik)
                    .ToList();

                if (!widgetlar.Any())
                    return false;

                flowLayoutPanel_Kartlar.SuspendLayout();
                flowLayoutPanel_Kartlar.Controls.Clear();

                for (int i = 0; i < widgetlar.Count; i++)
                {
                    var widget = widgetlar[i];
                    var deger = DashboardWidgetDegeriniOku(v2Dashboard, widget);
                    var kart = DashboardKartiOlustur(widget, deger.Deger, deger.AltBilgi, i);
                    flowLayoutPanel_Kartlar.Controls.Add(kart);
                }

                flowLayoutPanel_Kartlar.ResumeLayout();
                return true;
            }
            catch
            {
                flowLayoutPanel_Kartlar.ResumeLayout();
                return false;
            }
        }

        private int? AktifRolIdGetir()
        {
            try
            {
                if (GirisYapanPersonelId <= 0)
                    return null;

                var rolResult = _personelRolService.GetListByFilterService(x => x.PersonelId == GirisYapanPersonelId);

                if (!rolResult.IsSuccess || rolResult.Data == null || rolResult.Data.Count == 0)
                    return null;

                return rolResult.Data.First().RolId;
            }
            catch
            {
                return null;
            }
        }

        private DashboardKartDegeri DashboardWidgetDegeriniOku(IV2DashboardMenuService v2Dashboard, DashboardWidgetDto widget)
        {
            var result = v2Dashboard.DashboardWidgetVerisiGetir(widget.VeriKaynagi);

            if (!result.IsSuccess)
                return new DashboardKartDegeri("0", result.Message);

            var table = result.Data;

            if (table == null || table.Rows.Count == 0 || table.Columns.Count == 0)
                return new DashboardKartDegeri("0", widget.Aciklama ?? "Veri bulunamadı.");

            var row = table.Rows[0];

            var deger = IlkDoluKolonDegeri(row,
                "DegerGosterim",
                "Deger",
                "Sayi",
                "Adet",
                "Toplam",
                "Count",
                "Value",
                "Sonuc",
                "Miktar",
                widget.WidgetKodu,
                widget.VeriKaynagi);

            if (string.IsNullOrWhiteSpace(deger))
                deger = DegerFormatla(row[0]);

            var altBilgi = IlkDoluKolonDegeri(row,
                "AltBaslik",
                "AltBilgi",
                "Aciklama",
                "Detay",
                "Durum",
                "Oran");

            if (string.IsNullOrWhiteSpace(altBilgi))
                altBilgi = widget.Aciklama;

            return new DashboardKartDegeri(deger, altBilgi);
        }

        private string? IlkDoluKolonDegeri(DataRow row, params string[] kolonAdlari)
        {
            foreach (var kolonAdi in kolonAdlari.Where(x => !string.IsNullOrWhiteSpace(x)))
            {
                var kolon = row.Table.Columns
                    .Cast<DataColumn>()
                    .FirstOrDefault(x => x.ColumnName.Equals(kolonAdi, StringComparison.OrdinalIgnoreCase));

                if (kolon == null || row[kolon] == DBNull.Value)
                    continue;

                var deger = DegerFormatla(row[kolon]);

                if (!string.IsNullOrWhiteSpace(deger))
                    return deger;
            }

            return null;
        }

        private string DegerFormatla(object? deger)
        {
            if (deger == null || deger == DBNull.Value)
                return string.Empty;

            if (deger is byte or short or int or long)
                return Convert.ToInt64(deger).ToString("N0");

            if (deger is float or double or decimal)
            {
                var sayi = Convert.ToDecimal(deger);
                return sayi % 1 == 0 ? sayi.ToString("N0") : sayi.ToString("N2");
            }

            if (deger is DateTime tarih)
                return tarih.ToString("dd.MM.yyyy");

            return deger.ToString()?.Trim() ?? string.Empty;
        }

        private Panel DashboardKartiOlustur(DashboardWidgetDto widget, string deger, string? altBilgi, int index)
        {
            var panel = new Panel
            {
                Width = 280,
                Height = 160,
                Margin = new Padding(10),
                BackColor = DashboardKartRengiSec(widget, index),
                Cursor = Cursors.Hand,
                Tag = widget
            };

            var baslikLabel = new Label
            {
                AutoSize = false,
                Location = new Point(18, 16),
                Size = new Size(244, 34),
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.White,
                Text = $"{DashboardWidgetIconGetir(widget)} {widget.Baslik}".Trim()
            };

            var degerLabel = new Label
            {
                AutoSize = false,
                Location = new Point(18, 50),
                Size = new Size(244, 72),
                Font = new Font("Segoe UI", deger.Length > 7 ? 30F : 46F, FontStyle.Bold),
                ForeColor = Color.White,
                Text = string.IsNullOrWhiteSpace(deger) ? "0" : deger,
                TextAlign = ContentAlignment.MiddleLeft
            };

            var altBilgiLabel = new Label
            {
                AutoSize = false,
                Location = new Point(20, 124),
                Size = new Size(240, 28),
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = Color.FromArgb(236, 240, 241),
                Text = string.IsNullOrWhiteSpace(altBilgi) ? widget.VeriKaynagi : altBilgi,
                AutoEllipsis = true
            };

            panel.Controls.Add(baslikLabel);
            panel.Controls.Add(degerLabel);
            panel.Controls.Add(altBilgiLabel);

            panel.Click += DashboardKarti_Click;
            baslikLabel.Click += DashboardKarti_Click;
            degerLabel.Click += DashboardKarti_Click;
            altBilgiLabel.Click += DashboardKarti_Click;

            return panel;
        }

        private string DashboardWidgetIconGetir(DashboardWidgetDto widget)
        {
            if (!string.IsNullOrWhiteSpace(widget.Icon) && widget.Icon.Length <= 3)
                return widget.Icon;

            var anahtar = $"{widget.Icon} {widget.WidgetKodu} {widget.Baslik} {widget.VeriKaynagi}".ToUpperInvariant();

            if (anahtar.Contains("KITAP") || anahtar.Contains("BOOK")) return "📚";
            if (anahtar.Contains("UYE") || anahtar.Contains("ÜYE") || anahtar.Contains("OGRENCI") || anahtar.Contains("ÖĞRENCI") || anahtar.Contains("OGRETMEN")) return "👥";
            if (anahtar.Contains("ODUNC") || anahtar.Contains("ÖDÜNÇ") || anahtar.Contains("IADE") || anahtar.Contains("İADE")) return "🔄";
            if (anahtar.Contains("GECIK") || anahtar.Contains("GECİK")) return "⚠️";
            if (anahtar.Contains("YAZAR")) return "✍️";
            if (anahtar.Contains("YAYINEVI") || anahtar.Contains("YAYINEVİ")) return "🏢";
            if (anahtar.Contains("STOK")) return "📦";

            return "📌";
        }

        private Color DashboardKartRengiSec(DashboardWidgetDto widget, int index)
        {
            var anahtar = $"{widget.WidgetKodu} {widget.Baslik} {widget.VeriKaynagi}".ToUpperInvariant();

            if (anahtar.Contains("GECIK") || anahtar.Contains("GECİK")) return Color.FromArgb(192, 57, 43);
            if (anahtar.Contains("ODUNC") || anahtar.Contains("ÖDÜNÇ") || anahtar.Contains("IADE") || anahtar.Contains("İADE")) return Color.FromArgb(230, 126, 34);
            if (anahtar.Contains("KITAP")) return Color.FromArgb(39, 174, 96);
            if (anahtar.Contains("UYE") || anahtar.Contains("ÜYE") || anahtar.Contains("OGRENCI") || anahtar.Contains("ÖĞRENCI")) return Color.FromArgb(41, 128, 185);
            if (anahtar.Contains("YAZAR")) return Color.FromArgb(155, 89, 182);
            if (anahtar.Contains("YAYINEVI") || anahtar.Contains("YAYINEVİ")) return Color.FromArgb(22, 160, 133);
            if (anahtar.Contains("STOK")) return Color.FromArgb(52, 73, 94);

            var renkler = new[]
            {
                Color.FromArgb(39, 174, 96),
                Color.FromArgb(41, 128, 185),
                Color.FromArgb(155, 89, 182),
                Color.FromArgb(22, 160, 133),
                Color.FromArgb(230, 126, 34),
                Color.FromArgb(192, 57, 43),
                Color.FromArgb(52, 73, 94)
            };

            return renkler[index % renkler.Length];
        }

        private void DashboardKarti_Click(object? sender, EventArgs e)
        {
            var control = sender as Control;
            var widget = control?.Tag as DashboardWidgetDto ?? control?.Parent?.Tag as DashboardWidgetDto;

            if (widget == null)
                return;

            var formAdi = DashboardWidgetFormAdiBul(widget);

            if (string.IsNullOrWhiteSpace(formAdi))
                return;

            FormAcByFormAdi(formAdi);
        }

        private string? DashboardWidgetFormAdiBul(DashboardWidgetDto widget)
        {
            var anahtar = $"{widget.WidgetKodu} {widget.Baslik} {widget.VeriKaynagi}".ToUpperInvariant();

            if (anahtar.Contains("KITAP")) return "frmKitapIslemleri";
            if (anahtar.Contains("YAZAR")) return "frmYazarIslemleri";
            if (anahtar.Contains("YAYINEVI") || anahtar.Contains("YAYINEVİ")) return "frmYayineviIslemleri";
            if (anahtar.Contains("UYE") || anahtar.Contains("ÜYE") || anahtar.Contains("OGRENCI") || anahtar.Contains("ÖĞRENCI") || anahtar.Contains("OGRETMEN")) return "frmUyeIslemleri";
            if (anahtar.Contains("ODUNC") || anahtar.Contains("ÖDÜNÇ") || anahtar.Contains("IADE") || anahtar.Contains("İADE") || anahtar.Contains("GECIK") || anahtar.Contains("GECİK")) return "frmOduncIslemleri";

            return null;
        }

        private void SabitDashboardVerileriniYukle()
        {
            SabitDashboardKartlariniYerlestir();

            try
            {
                var v2Dashboard = Helpers.V2ServiceFactory.DashboardMenuService();
                var ozetResult = v2Dashboard.DashboardOzetGetir();

                if (ozetResult.IsSuccess && ozetResult.Data?.Any() == true)
                {
                    var ozet = ozetResult.Data.First();
                    label_KitapSayisi.Text = ozet.ToplamKitap.ToString();
                    label_UyeSayisi.Text = ozet.ToplamUye.ToString();
                    label_OduncSayisi.Text = ozet.AktifOduncSayisi.ToString();
                    label_GecikmisUyeSayisi.Text = ozet.GecikenIadeSayisi.ToString();

                    var erkekSayisi = _uyeManager.GetListByFilterService(x => x.AktifMi && x.Cinsiyet.CinsiyetAdi == "Erkek").Data?.Count ?? 0;
                    var kadinSayisi = _uyeManager.GetListByFilterService(x => x.AktifMi && x.Cinsiyet.CinsiyetAdi == "Kadın").Data?.Count ?? 0;
                    label_UyeErkekSayisi.Text = $"Erkek: {erkekSayisi}";
                    label_UyeKadinSayisi.Text = $"Kadın: {kadinSayisi}";

                    var yazarResult = _yazarManager.GetListByFilterService(x => x.AktifMi == true);
                    label_YazarSayisi.Text = yazarResult.IsSuccess ? yazarResult.Data.Count.ToString() : "0";

                    var yayineviResult = _yayineviManager.GetListByFilterService(x => x.AktifMi == true);
                    label_YayineviSayisi.Text = yayineviResult.IsSuccess ? yayineviResult.Data.Count.ToString() : "0";
                    return;
                }
            }
            catch
            {
                // V2 dashboard servisinde sorun olursa eski hesaplama mantığına düş.
            }

            var kitapResult = _kitapManager.GetListByFilterService(x => x.Aktif == true);
            label_KitapSayisi.Text = kitapResult.IsSuccess
                ? kitapResult.Data.Count.ToString()
                : "0";

            var uyeResult = _uyeManager.GetListByFilterService(x => x.AktifMi == true);
            label_UyeSayisi.Text = uyeResult.IsSuccess
                ? uyeResult.Data.Count.ToString()
                : "0";

            int erkekSayisiFallback = _uyeManager
                .GetListByFilterService(x => x.AktifMi && x.Cinsiyet.CinsiyetAdi == "Erkek")
                .Data?.Count ?? 0;

            int kadinSayisiFallback = _uyeManager
                .GetListByFilterService(x => x.AktifMi && x.Cinsiyet.CinsiyetAdi == "Kadın")
                .Data?.Count ?? 0;

            label_UyeErkekSayisi.Text = $"Erkek: {erkekSayisiFallback}";
            label_UyeKadinSayisi.Text = $"Kadın: {kadinSayisiFallback}";

            var oduncResult = _oduncManager.GetListByFilterService(x => x.TeslimEdildi == false);
            int oduncSayisi = oduncResult.IsSuccess ? oduncResult.Data.Count : 0;
            label_OduncSayisi.Text = oduncSayisi.ToString();

            var gecikmisResult = _oduncManager.GetListByFilterService(x =>
                x.TeslimEdildi == false &&
                x.TeslimTarihi < DateTime.Now);

            int gecikmisSayisi = gecikmisResult.IsSuccess ? gecikmisResult.Data.Count : 0;
            label_GecikmisUyeSayisi.Text = gecikmisSayisi.ToString();

            var yazarResultFallback = _yazarManager.GetListByFilterService(x => x.AktifMi == true);
            label_YazarSayisi.Text = yazarResultFallback.IsSuccess
                ? yazarResultFallback.Data.Count.ToString()
                : "0";

            var yayineviResultFallback = _yayineviManager.GetListByFilterService(x => x.AktifMi == true);
            label_YayineviSayisi.Text = yayineviResultFallback.IsSuccess
                ? yayineviResultFallback.Data.Count.ToString()
                : "0";
        }

        private void SabitDashboardKartlariniYerlestir()
        {
            flowLayoutPanel_Kartlar.SuspendLayout();
            flowLayoutPanel_Kartlar.Controls.Clear();

            var sabitKartlar = new Control[]
            {
                panel_Kitap,
                panel1,
                panel2,
                panel_Uye,
                panel_Odunc,
                panel_Geciklis
            };

            foreach (var kart in sabitKartlar)
            {
                if (kart != null && !kart.IsDisposed)
                    flowLayoutPanel_Kartlar.Controls.Add(kart);
            }

            flowLayoutPanel_Kartlar.ResumeLayout();
        }

        private class DashboardKartDegeri
        {
            public DashboardKartDegeri(string deger, string? altBilgi)
            {
                Deger = deger;
                AltBilgi = altBilgi;
            }

            public string Deger { get; }
            public string? AltBilgi { get; }
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

            if (childForm is frmDashboardAyarlari dashboardAyarlariForm)
            {
                dashboardAyarlariForm.AyarlarKaydedildi += (s, e) => Listele();
                dashboardAyarlariForm.DashboardaDonIstendi += (s, e) => gostegePanelGoster();
            }

            if (childForm is frmFormAlanAyarlari formAlanAyarlariForm)
            {
                formAlanAyarlariForm.UyeFormunuAcIstendi += (s, e) => FormAcByFormAdi("frmUyeIslemleri");
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
            ActiveMdiChild?.Close();

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