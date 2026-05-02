using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class AlanSecenek : IEntity
    {
        public int AlanSecenekId { get; set; }
        public int AlanTanimId { get; set; }
        public string Deger { get; set; } = string.Empty;
        public string Etiket { get; set; } = string.Empty;
        public int SiraNo { get; set; }
        public bool AktifMi { get; set; } = true;
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }

        public AlanTanim? AlanTanim { get; set; }
    }
}
