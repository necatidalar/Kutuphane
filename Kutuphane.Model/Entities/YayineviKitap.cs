

using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class YayineviKitap : IEntity
    {
        public int Id { get; set; }
        public int YayineviId { get; set; }
        public Yayinevi Yayinevi { get; set; }
        public int KitapId { get; set; }
        public DateTime DonemBaslangici { get; set; }
        public DateTime? DonemBitisi { get; set; }
        public Kitap Kitap { get; set; }
    }
}
