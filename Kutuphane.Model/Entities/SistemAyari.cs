using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class SistemAyari : IEntity
    {
        public int SistemAyariId { get; set; }
        public int? KurumId { get; set; }
        public string AyarKodu { get; set; } = string.Empty;
        public string AyarAdi { get; set; } = string.Empty;
        public string? AyarDegeri { get; set; }
        public string VeriTipi { get; set; } = string.Empty;
        public string? Aciklama { get; set; }
        public bool AktifMi { get; set; } = true;
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }

        public Kurum? Kurum { get; set; }
    }
}
