using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class AlanTanim : IEntity
    {
        public int AlanTanimId { get; set; }
        public string EntityAdi { get; set; } = string.Empty;
        public string AlanKodu { get; set; } = string.Empty;
        public string AlanAdi { get; set; } = string.Empty;
        public string VeriTipi { get; set; } = string.Empty;
        public int? MaxLength { get; set; }
        public bool SistemAlaniMi { get; set; }
        public bool AktifMi { get; set; } = true;
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }

        public ICollection<AlanSecenek>? AlanSecenekleri { get; set; }
        public ICollection<FormAlanAyari>? FormAlanAyarlari { get; set; }
        public ICollection<EntityEkAlanDegeri>? EntityEkAlanDegerleri { get; set; }
    }
}
