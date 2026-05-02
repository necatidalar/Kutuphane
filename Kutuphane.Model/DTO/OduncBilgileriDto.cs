using Core.Entity;

namespace Kutuphane.Model.DTO
{
    public class OduncBilgileriDto : IDto
    {
        public int OduncId { get; set; }
        public int UyeId { get; set; }
        public string UyeAd { get; set; }
        public string UyeSoyad { get; set; }
        public string UyeTelefon { get; set; }
        public string UyeEposta { get; set; }
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public DateTime AlisTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public bool TeslimEdildi { get; set; }

        // V2
        public DateTime? PlanlananIadeTarihi { get; set; }
        public DateTime? GercekIadeTarihi { get; set; }
        public string? OduncDurum { get; set; }
        public string? IadeNotu { get; set; }
        public int? GecikmeGunSayisi { get; set; }
        public int? OduncVerenPersonelId { get; set; }
        public string? OduncVerenPersonel { get; set; }
        public int? IadeAlanPersonelId { get; set; }
        public string? IadeAlanPersonel { get; set; }
    }
}
