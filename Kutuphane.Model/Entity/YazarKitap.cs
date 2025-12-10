

using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class YazarKitap :IEntity
    {
        public int Id { get; set; }
        public int YazarId { get; set; }
        public int KitapId { get; set; }
        public Yazar Yazar { get; set; }
        public Kitap Kitap { get; set; }
    }
}
