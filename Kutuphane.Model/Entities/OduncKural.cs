using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class OduncKural : IEntity
    {
        public int OduncKuralId { get; set; }
        public int KurumId { get; set; }
        public int UyeTipiId { get; set; }
        public int MaksimumKitapSayisi { get; set; }
        public int OduncSuresiGun { get; set; }
        public bool GecikmisKitabiOlanOduncAlabilirMi { get; set; }
        public bool AyniKitaptanTekrarAlabilirMi { get; set; }
        public bool AktifMi { get; set; } = true;
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }

        public Kurum? Kurum { get; set; }
        public UyeTipi? UyeTipi { get; set; }
    }
}
