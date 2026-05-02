using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Kurum : IEntity
    {
        public int KurumId { get; set; }
        public string KurumAdi { get; set; } = string.Empty;
        public string KurumKodu { get; set; } = string.Empty;
        public string KurumTipi { get; set; } = string.Empty;
        public bool AktifMi { get; set; } = true;
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }

        public ICollection<Uye>? Uyeler { get; set; }
        public ICollection<OduncKural>? OduncKurallari { get; set; }
        public ICollection<FormAlanAyari>? FormAlanAyarlari { get; set; }
        public ICollection<DashboardWidgetAyari>? DashboardWidgetAyarlari { get; set; }
        public ICollection<MenuAyari>? MenuAyarlari { get; set; }
        public ICollection<SistemAyari>? SistemAyarlari { get; set; }
    }
}
