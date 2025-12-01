using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class KitapSirasi : IEntity
    {
        public int KitapSirasiID { get; set; }
        public int RafID { get; set; }
        public int KitapID { get; set; }

        public Raf Raf { get; set; }
        public Kitap Kitap { get; set; }
    }
}
