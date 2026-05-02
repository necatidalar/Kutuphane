using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class AuditLog : IEntity
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
