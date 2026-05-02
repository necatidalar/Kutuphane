using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class EntityEkAlanDegeri : IEntity
    {
        public int EntityEkAlanDegeriId { get; set; }
        public string EntityAdi { get; set; } = string.Empty;
        public int EntityId { get; set; }
        public int AlanTanimId { get; set; }
        public string? DegerText { get; set; }
        public int? DegerNumber { get; set; }
        public decimal? DegerDecimal { get; set; }
        public DateTime? DegerDate { get; set; }
        public bool? DegerBool { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }

        public AlanTanim? AlanTanim { get; set; }
    }
}
