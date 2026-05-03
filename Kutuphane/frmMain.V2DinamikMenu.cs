using Kutuphane.Model.DTO;
using System.Data;

namespace Kutuphane.UI
{
    public partial class frmMain
    {
        private const string MenuKomutDashboard = "__DASHBOARD__";
        private const string MenuKomutCikis = "__CIKIS__";

        private bool DinamikMenuleriYukle()
        {
            try
            {
                var v2DashboardMenu = Helpers.V2ServiceFactory.DashboardMenuService();
                var result = v2DashboardMenu.MenuTanimlariniGetir(VarsayilanKurumId, AktifRolIdGetir());

                if (!result.IsSuccess || result.Data == null || !result.Data.Any())
                    return false;

                var tumMenuler = result.Data
                    .Where(x => x.AktifMi && x.GorunurMu)
                    .OrderBy(x => x.SiraNo)
                    .ThenBy(x => x.MenuAdi)
                    .ToList();

                tumMenuler = DinamikMenuTekrarlariTemizle(tumMenuler);

                if (!tumMenuler.Any())
                    return false;

                var altMenuSozlugu = tumMenuler
                    .Where(x => x.UstMenuId.HasValue)
                    .GroupBy(x => x.UstMenuId!.Value)
                    .ToDictionary(
                        g => g.Key,
                        g => g.OrderBy(x => x.SiraNo).ThenBy(x => x.MenuAdi).ToList());

                var kokMenuler = tumMenuler
                    .Where(x => !x.UstMenuId.HasValue)
                    .OrderBy(x => x.SiraNo)
                    .ThenBy(x => x.MenuAdi)
                    .ToList();

                var olusturulanMenuler = new List<ToolStripMenuItem>();

                foreach (var menu in kokMenuler)
                {
                    if (!DinamikMenuGosterilebilirMi(menu, altMenuSozlugu))
                        continue;

                    var menuItem = DinamikMenuItemOlustur(menu, altMenuSozlugu);

                    if (menu.MenuKodu.Equals("CIKIS_YAP", StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(menu.FormAdi, MenuKomutCikis, StringComparison.OrdinalIgnoreCase))
                    {
                        menuItem.Alignment = ToolStripItemAlignment.Right;
                        menuItem.ForeColor = Color.FromArgb(192, 57, 43);
                    }

                    olusturulanMenuler.Add(menuItem);
                }

                if (olusturulanMenuler.Count == 0)
                    return false;

                menuStrip1.SuspendLayout();
                menuStrip1.Items.Clear();

                foreach (var menuItem in olusturulanMenuler)
                    menuStrip1.Items.Add(menuItem);

                menuStrip1.ResumeLayout();
                return true;
            }
            catch
            {
                try
                {
                    menuStrip1.ResumeLayout();
                }
                catch
                {
                    // Menü fallback akışında ResumeLayout hatası önemsenmez.
                }

                return false;
            }
        }


        private void SabitMenuleriYukle()
        {
            menuStrip1.SuspendLayout();
            menuStrip1.Items.Clear();

            menuStrip1.Items.AddRange(new ToolStripItem[]
            {
                gostergePaneliToolStripMenuItem,
                yerlesimAyarlariToolStripMenuItem,
                kitapIslemleriToolStripMenuItem,
                oduncToolStripMenuItem,
                uyeToolStripMenuItem,
                personelToolStripMenuItem,
                raporlamaToolStripMenuItem,
                yonetimToolStripMenuItem,
                ayarlarToolStripMenuItem,
                cikisToolStripMenuItem
            });

            menuStrip1.ResumeLayout();
        }

        private List<MenuTanimDto> DinamikMenuTekrarlariTemizle(List<MenuTanimDto> menuler)
        {
            if (menuler == null || menuler.Count == 0)
                return new List<MenuTanimDto>();

            var aktifMenuler = menuler
                .Where(x => x != null && x.AktifMi && x.GorunurMu)
                .ToList();

            var kullanilacakIdler = new HashSet<int>();
            var kokMenuler = aktifMenuler
                .Where(x => !x.UstMenuId.HasValue)
                .OrderBy(x => x.SiraNo)
                .ThenBy(x => x.MenuAdi)
                .ToList();

            foreach (var kokMenu in kokMenuler)
            {
                if (EskiTekrarMenuKaydiMi(kokMenu, aktifMenuler))
                    continue;

                kullanilacakIdler.Add(kokMenu.MenuTanimId);
                AltMenuIdleriniEkle(kokMenu.MenuTanimId, aktifMenuler, kullanilacakIdler);
            }

            return aktifMenuler
                .Where(x => kullanilacakIdler.Contains(x.MenuTanimId))
                .OrderBy(x => x.UstMenuId.HasValue ? 1 : 0)
                .ThenBy(x => x.SiraNo)
                .ThenBy(x => x.MenuAdi)
                .ToList();
        }

        private void AltMenuIdleriniEkle(int ustMenuId, List<MenuTanimDto> tumMenuler, HashSet<int> kullanilacakIdler)
        {
            var altMenuler = tumMenuler
                .Where(x => x.UstMenuId == ustMenuId)
                .OrderBy(x => x.SiraNo)
                .ThenBy(x => x.MenuAdi)
                .ToList();

            foreach (var altMenu in altMenuler)
            {
                if (EskiTekrarMenuKaydiMi(altMenu, tumMenuler))
                    continue;

                kullanilacakIdler.Add(altMenu.MenuTanimId);
                AltMenuIdleriniEkle(altMenu.MenuTanimId, tumMenuler, kullanilacakIdler);
            }
        }

        private bool EskiTekrarMenuKaydiMi(MenuTanimDto menu, List<MenuTanimDto> tumMenuler)
        {
            var canonicalKodlar = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "GOSTERGE_PANELI",
                "YERLESIM_AYARLARI",
                "KITAP_ISLEMLERI",
                "KITAP_LISTE",
                "KATEGORI_LISTE",
                "YAZAR_LISTE",
                "YAYINEVI_LISTE",
                "DIL_LISTE",
                "ODUNC_ISLEMLERI",
                "UYE_ISLEMLERI",
                "PERSONEL_ISLEMLERI",
                "RAPORLAMA",
                "YONETIM_AYARLARI",
                "AYARLAR",
                "DASHBOARD_AYARLARI",
                "FORM_ALAN_AYARLARI",
                "CIKIS_YAP"
            };

            if (canonicalKodlar.Contains(menu.MenuKodu ?? string.Empty))
                return false;

            bool canonicalKayitlarVar = tumMenuler.Any(x => canonicalKodlar.Contains(x.MenuKodu ?? string.Empty));
            if (!canonicalKayitlarVar)
                return false;

            string menuAdi = (menu.MenuAdi ?? string.Empty).Trim().ToUpperInvariant();
            string formAdi = (menu.FormAdi ?? string.Empty).Trim().ToUpperInvariant();
            string menuKodu = (menu.MenuKodu ?? string.Empty).Trim().ToUpperInvariant();

            if (!menu.UstMenuId.HasValue)
            {
                if (menuAdi is "DASHBOARD" or "GÖSTERGE" or "GOSTERGE")
                    return true;

                if (menuAdi is "KITAP YÖNETİMİ" or "KITAP YONETIMI" or "KİTAP YÖNETİMİ")
                    return true;

                if (menuAdi is "ÜYE YÖNETİMİ" or "UYE YONETIMI")
                    return true;

                if (menuAdi is "ÖDÜNÇ / İADE" or "ODUNC / IADE" or "ÖDÜNÇ/İADE" or "ODUNC/IADE")
                    return true;

                if (menuAdi == "AYARLAR" && !menuKodu.Equals("AYARLAR", StringComparison.OrdinalIgnoreCase))
                    return true;

                if ((menuAdi == "ÇIKIŞ YAP" || menuAdi == "CIKIS YAP") && !menuKodu.Equals("CIKIS_YAP", StringComparison.OrdinalIgnoreCase))
                    return true;

                if (formAdi is "__DASHBOARD__" or "__CIKIS__")
                    return true;

                if (formAdi is "FRMKITAPISLEMLERI" or "FRMUYEISLEMLERI" or "FRMODUNCISLEMLERI")
                    return true;
            }

            return false;
        }

        private ToolStripMenuItem DinamikMenuItemOlustur(
            MenuTanimDto menu,
            Dictionary<int, List<MenuTanimDto>> altMenuSozlugu)
        {
            var item = new ToolStripMenuItem
            {
                Name = $"{menu.MenuKodu}_ToolStripMenuItem",
                Text = DinamikMenuMetniOlustur(menu),
                Tag = menu,
                ForeColor = Color.FromArgb(44, 62, 80)
            };

            if (altMenuSozlugu.TryGetValue(menu.MenuTanimId, out var altMenuler))
            {
                foreach (var altMenu in altMenuler.OrderBy(x => x.SiraNo).ThenBy(x => x.MenuAdi))
                {
                    if (!DinamikMenuGosterilebilirMi(altMenu, altMenuSozlugu))
                        continue;

                    item.DropDownItems.Add(DinamikMenuItemOlustur(altMenu, altMenuSozlugu));
                }
            }

            bool komutVar = !string.IsNullOrWhiteSpace(menu.FormAdi) ||
                            menu.MenuKodu.Equals("GOSTERGE_PANELI", StringComparison.OrdinalIgnoreCase) ||
                            menu.MenuKodu.Equals("CIKIS_YAP", StringComparison.OrdinalIgnoreCase);

            if (komutVar)
                item.Click += DinamikMenuItem_Click;
            else if (item.DropDownItems.Count == 0)
                item.Enabled = false;

            return item;
        }

        private bool DinamikMenuGosterilebilirMi(
            MenuTanimDto menu,
            Dictionary<int, List<MenuTanimDto>> altMenuSozlugu)
        {
            if (!menu.AktifMi || !menu.GorunurMu)
                return false;

            bool kendiYetkisiVar = DinamikMenuYetkisiVar(menu);
            bool komutVar = !string.IsNullOrWhiteSpace(menu.FormAdi) ||
                            menu.MenuKodu.Equals("GOSTERGE_PANELI", StringComparison.OrdinalIgnoreCase) ||
                            menu.MenuKodu.Equals("CIKIS_YAP", StringComparison.OrdinalIgnoreCase);

            bool altindaGorunurMenuVar = false;

            if (altMenuSozlugu.TryGetValue(menu.MenuTanimId, out var altMenuler))
                altindaGorunurMenuVar = altMenuler.Any(x => DinamikMenuGosterilebilirMi(x, altMenuSozlugu));

            if (komutVar)
                return kendiYetkisiVar || altindaGorunurMenuVar;

            if (altMenulerVarMi(menu, altMenuSozlugu))
                return altindaGorunurMenuVar;

            return kendiYetkisiVar;
        }

        private bool altMenulerVarMi(MenuTanimDto menu, Dictionary<int, List<MenuTanimDto>> altMenuSozlugu)
        {
            return altMenuSozlugu.ContainsKey(menu.MenuTanimId);
        }

        private bool DinamikMenuYetkisiVar(MenuTanimDto menu)
        {
            if (string.IsNullOrWhiteSpace(menu.YetkiKodu))
                return true;

            if (_userPermissions == null || _userPermissions.Count == 0)
                return false;

            var yetkiKodlari = menu.YetkiKodu
                .Split(new[] { ',', ';', '|', ' ' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            if (yetkiKodlari.Length == 0)
                return true;

            return yetkiKodlari.Any(x => _userPermissions.Contains(x));
        }

        private string DinamikMenuMetniOlustur(MenuTanimDto menu)
        {
            var icon = DinamikMenuIconGetir(menu);
            var menuAdi = menu.MenuAdi?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(icon))
                return menuAdi;

            return $"{icon} {menuAdi}".Trim();
        }

        private string DinamikMenuIconGetir(MenuTanimDto menu)
        {
            if (!string.IsNullOrWhiteSpace(menu.Icon) && menu.Icon.Trim().Length <= 3)
                return menu.Icon.Trim();

            var anahtar = $"{menu.Icon} {menu.MenuKodu} {menu.MenuAdi} {menu.FormAdi}".ToUpperInvariant();

            if (anahtar.Contains("DASHBOARD") || anahtar.Contains("GOSTERGE") || anahtar.Contains("GÖSTERGE")) return "📊";
            if (anahtar.Contains("YERLESIM") || anahtar.Contains("YERLEŞIM") || anahtar.Contains("YERLEŞİM")) return "⚙";
            if (anahtar.Contains("KITAP") || anahtar.Contains("KİTAP")) return "📚";
            if (anahtar.Contains("KATEGORI") || anahtar.Contains("KATEGORİ")) return "🗂";
            if (anahtar.Contains("YAZAR")) return "✍️";
            if (anahtar.Contains("YAYINEVI") || anahtar.Contains("YAYINEVİ")) return "🏢";
            if (anahtar.Contains("DIL") || anahtar.Contains("DİL")) return "🌐";
            if (anahtar.Contains("ODUNC") || anahtar.Contains("ÖDÜNÇ") || anahtar.Contains("IADE") || anahtar.Contains("İADE")) return "🔄";
            if (anahtar.Contains("UYE") || anahtar.Contains("ÜYE")) return "👥";
            if (anahtar.Contains("PERSONEL")) return "👔";
            if (anahtar.Contains("RAPOR")) return "📝";
            if (anahtar.Contains("YONETIM") || anahtar.Contains("YÖNETİM")) return "🔐";
            if (anahtar.Contains("AYAR")) return "⚙";
            if (anahtar.Contains("CIKIS") || anahtar.Contains("ÇIKIŞ")) return "🔒";

            return string.Empty;
        }

        private void DinamikMenuItem_Click(object? sender, EventArgs e)
        {
            if (sender is not ToolStripMenuItem menuItem || menuItem.Tag is not MenuTanimDto menu)
                return;

            DinamikMenuKomutunuCalistir(menu);
        }

        private void DinamikMenuKomutunuCalistir(MenuTanimDto menu)
        {
            var formAdi = menu.FormAdi?.Trim();
            var menuKodu = menu.MenuKodu?.Trim() ?? string.Empty;

            if (menuKodu.Equals("GOSTERGE_PANELI", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(formAdi, MenuKomutDashboard, StringComparison.OrdinalIgnoreCase))
            {
                gostegePanelGoster();
                label_Mesaj.Text = $" {DinamikMenuMetniOlustur(menu)}";
                return;
            }

            if (menuKodu.Equals("CIKIS_YAP", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(formAdi, MenuKomutCikis, StringComparison.OrdinalIgnoreCase))
            {
                Logout();
                return;
            }

            if (string.IsNullOrWhiteSpace(formAdi))
                return;

            FormAcByFormAdi(formAdi);
            label_Mesaj.Text = $" {DinamikMenuMetniOlustur(menu)}";
        }
    }
}
