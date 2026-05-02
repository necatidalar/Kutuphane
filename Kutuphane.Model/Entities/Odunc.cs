using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Odunc : IEntity
    {
        public int OduncId { get; set; }
        public int UyeId { get; set; }
        public int KitapId { get; set; }
        public DateTime AlisTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public bool TeslimEdildi { get; set; }
        public int TeslimEdenPersonelId { get; set; }
        public int? TeslimAlanPersonelId { get; set; }

        // V2 - İade / durum altyapısı
        public DateTime? PlanlananIadeTarihi { get; set; }
        public DateTime? GercekIadeTarihi { get; set; }
        public string? OduncDurum { get; set; }
        public string? IadeNotu { get; set; }
        public int? GecikmeGunSayisi { get; set; }

        public Uye Uye { get; set; }
        public Kitap Kitap { get; set; }
        public Personel TeslimEdenPersonel { get; set; }
        public Personel? TeslimAlanPersonel { get; set; }
    }
}
