using Core.Entity;

namespace Kutuphane.Model.DTO
{
    public class KurumDto : IDto
    {
        public int KurumId { get; set; }
        public string KurumAdi { get; set; } = string.Empty;
        public string KurumKodu { get; set; } = string.Empty;
        public string KurumTipi { get; set; } = string.Empty;
        public bool AktifMi { get; set; }
    }

    public class UyeTipiDto : IDto
    {
        public int UyeTipiId { get; set; }
        public string UyeTipiAdi { get; set; } = string.Empty;
        public string UyeTipiKodu { get; set; } = string.Empty;
        public bool AktifMi { get; set; }
    }

    public class OduncKuralDto : IDto
    {
        public int OduncKuralId { get; set; }
        public int KurumId { get; set; }
        public string? KurumAdi { get; set; }
        public int UyeTipiId { get; set; }
        public string? UyeTipiAdi { get; set; }
        public string? UyeTipiKodu { get; set; }
        public int MaksimumKitapSayisi { get; set; }
        public int OduncSuresiGun { get; set; }
        public bool GecikmisKitabiOlanOduncAlabilirMi { get; set; }
        public bool AyniKitaptanTekrarAlabilirMi { get; set; }
        public bool AktifMi { get; set; }
    }

    public class OduncVerSonucDto : IDto
    {
        public bool Basarili { get; set; }
        public string Mesaj { get; set; } = string.Empty;
        public int OduncId { get; set; }
        public DateTime PlanlananIadeTarihi { get; set; }
    }

    public class IadeAlSonucDto : IDto
    {
        public bool Basarili { get; set; }
        public string Mesaj { get; set; } = string.Empty;
        public int OduncId { get; set; }
        public string IadeDurum { get; set; } = string.Empty;
        public int GecikmeGunSayisi { get; set; }
        public bool StokArtirildiMi { get; set; }
    }

    public class AlanTanimDto : IDto
    {
        public int AlanTanimId { get; set; }
        public string EntityAdi { get; set; } = string.Empty;
        public string AlanKodu { get; set; } = string.Empty;
        public string AlanAdi { get; set; } = string.Empty;
        public string VeriTipi { get; set; } = string.Empty;
        public int? MaxLength { get; set; }
        public bool SistemAlaniMi { get; set; }
        public bool AktifMi { get; set; }
    }

    public class AlanSecenekDto : IDto
    {
        public int AlanSecenekId { get; set; }
        public int AlanTanimId { get; set; }
        public string Deger { get; set; } = string.Empty;
        public string Etiket { get; set; } = string.Empty;
        public int SiraNo { get; set; }
        public bool AktifMi { get; set; }
    }

    public class FormAlanAyariDto : IDto
    {
        public int FormAlanAyariId { get; set; }
        public int KurumId { get; set; }
        public string? KurumAdi { get; set; }
        public int? UyeTipiId { get; set; }
        public string? UyeTipiAdi { get; set; }
        public string FormKodu { get; set; } = string.Empty;
        public int AlanTanimId { get; set; }
        public string EntityAdi { get; set; } = string.Empty;
        public string AlanKodu { get; set; } = string.Empty;
        public string AlanAdi { get; set; } = string.Empty;
        public string VeriTipi { get; set; } = string.Empty;
        public int? MaxLength { get; set; }
        public bool GorunurMu { get; set; }
        public bool ZorunluMu { get; set; }
        public bool DegistirilebilirMi { get; set; }
        public bool ListedeGorunsunMu { get; set; }
        public int SiraNo { get; set; }
        public bool AktifMi { get; set; }
    }

    public class EntityEkAlanDegeriDto : IDto
    {
        public int EntityEkAlanDegeriId { get; set; }
        public string EntityAdi { get; set; } = string.Empty;
        public int EntityId { get; set; }
        public int AlanTanimId { get; set; }
        public string AlanKodu { get; set; } = string.Empty;
        public string AlanAdi { get; set; } = string.Empty;
        public string VeriTipi { get; set; } = string.Empty;
        public string? DegerText { get; set; }
        public int? DegerNumber { get; set; }
        public decimal? DegerDecimal { get; set; }
        public DateTime? DegerDate { get; set; }
        public bool? DegerBool { get; set; }
        public string? DegerGosterim { get; set; }
    }

    public class DashboardWidgetDto : IDto
    {
        public int DashboardWidgetId { get; set; }
        public string WidgetKodu { get; set; } = string.Empty;
        public string Baslik { get; set; } = string.Empty;
        public string? Aciklama { get; set; }
        public string WidgetTipi { get; set; } = string.Empty;
        public string VeriKaynagi { get; set; } = string.Empty;
        public string? Icon { get; set; }
        public bool GorunurMu { get; set; }
        public int SiraNo { get; set; }
    }

    public class DashboardOzetDto : IDto
    {
        public int ToplamKitap { get; set; }
        public int ToplamUye { get; set; }
        public int ToplamOgrenci { get; set; }
        public int ToplamOgretmen { get; set; }
        public int AktifOduncSayisi { get; set; }
        public int GecikenIadeSayisi { get; set; }
        public int BugunIadeSayisi { get; set; }
        public int StoksuzKitapSayisi { get; set; }
    }

    public class MenuTanimDto : IDto
    {
        public int MenuTanimId { get; set; }
        public int? UstMenuId { get; set; }
        public string? UstMenuKodu { get; set; }
        public string? UstMenuAdi { get; set; }
        public string MenuKodu { get; set; } = string.Empty;
        public string MenuAdi { get; set; } = string.Empty;
        public string? FormAdi { get; set; }
        public string? YetkiKodu { get; set; }
        public string? Icon { get; set; }
        public bool GorunurMu { get; set; }
        public int SiraNo { get; set; }
        public bool SistemMenusuMu { get; set; }
        public bool AktifMi { get; set; }
    }

    public class SistemAyariDto : IDto
    {
        public int SistemAyariId { get; set; }
        public int? KurumId { get; set; }
        public string? KurumAdi { get; set; }
        public string AyarKodu { get; set; } = string.Empty;
        public string AyarAdi { get; set; } = string.Empty;
        public string? AyarDegeri { get; set; }
        public string VeriTipi { get; set; } = string.Empty;
        public string? Aciklama { get; set; }
        public bool AktifMi { get; set; }
    }

    public class AuditLogDto : IDto
    {
        public long AuditLogId { get; set; }
        public string TabloAdi { get; set; } = string.Empty;
        public string IslemTipi { get; set; } = string.Empty;
        public string? KayitId { get; set; }
        public string? EskiDegerJson { get; set; }
        public string? YeniDegerJson { get; set; }
        public int? KullaniciId { get; set; }
        public string? KullaniciAdi { get; set; }
        public string? HostAdi { get; set; }
        public string? UygulamaAdi { get; set; }
        public DateTime IslemTarihi { get; set; }
    }
}
