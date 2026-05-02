using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class FormAlanAyari : IEntity
    {
        public int FormAlanAyariId { get; set; }
        public int KurumId { get; set; }
        public int? UyeTipiId { get; set; }
        public string FormKodu { get; set; } = string.Empty;
        public int AlanTanimId { get; set; }
        public bool GorunurMu { get; set; } = true;
        public bool ZorunluMu { get; set; }
        public bool DegistirilebilirMi { get; set; } = true;
        public bool ListedeGorunsunMu { get; set; }
        public int SiraNo { get; set; }
        public bool AktifMi { get; set; } = true;
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }

        public Kurum? Kurum { get; set; }
        public UyeTipi? UyeTipi { get; set; }
        public AlanTanim? AlanTanim { get; set; }
    }
}
