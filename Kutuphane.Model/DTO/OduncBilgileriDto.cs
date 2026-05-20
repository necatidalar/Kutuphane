using Core.Entity;

namespace Kutuphane.Model.DTO
{
    public class OduncBilgileriDto : IDto
    {
        public int OduncId { get; set; }
        public int UyeId { get; set; }
        public string? UyeOkulNo { get; set; }
        public string? UyeSinif { get; set; }
        public string? UyeSube { get; set; }
        public string UyeAd { get; set; } = string.Empty;
        public string UyeSoyad { get; set; } = string.Empty;
        public string UyeTelefon { get; set; } = string.Empty;
        public string UyeEposta { get; set; } = string.Empty;
        public int KitapId { get; set; }
        public string KitapAdi { get; set; } = string.Empty;
        public DateTime AlisTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public bool TeslimEdildi { get; set; }
    }
}
