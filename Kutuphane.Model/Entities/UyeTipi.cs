using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class UyeTipi : IEntity
    {
        public int UyeTipiId { get; set; }
        public string UyeTipiAdi { get; set; } = string.Empty;
        public string UyeTipiKodu { get; set; } = string.Empty;
        public bool AktifMi { get; set; } = true;
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }

        public ICollection<Uye>? Uyeler { get; set; }
        public ICollection<OduncKural>? OduncKurallari { get; set; }
        public ICollection<FormAlanAyari>? FormAlanAyarlari { get; set; }
    }
}
