using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Raf : IEntity
    {
        public int RafID { get; set; }
        public int KolonID { get; set; }
        public int RafNumarasi { get; set; }

        public Kolon Kolon { get; set; }
        public ICollection<KitapSirasi> KitapSiralari { get; set; }
    }
}
