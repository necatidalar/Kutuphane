using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class VeritabaniSurum : IEntity
    {
        public int VeritabaniSurumId { get; set; }
        public string SurumKodu { get; set; } = string.Empty;
        public string SurumAdi { get; set; } = string.Empty;
        public string? Aciklama { get; set; }
        public DateTime UygulamaTarihi { get; set; }
        public bool AktifMi { get; set; } = true;
    }
}
