using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class MenuAyari : IEntity
    {
        public int MenuAyariId { get; set; }
        public int KurumId { get; set; }
        public int MenuTanimId { get; set; }
        public bool GorunurMu { get; set; } = true;
        public int SiraNo { get; set; }
        public bool AktifMi { get; set; } = true;
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }

        public Kurum? Kurum { get; set; }
        public MenuTanim? MenuTanim { get; set; }
    }
}
