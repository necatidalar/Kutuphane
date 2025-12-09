using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Yazar : IEntity
    {
        public int YazarId { get; set; }
        public string AdSoyad{ get; set; }
        public DateTime? DogumTarihi { get; set; }

        public ICollection<YazarKitap> YazarKitaplari { get; set; }
    }
}
