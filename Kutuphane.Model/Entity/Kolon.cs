using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Kolon : IEntity
    {
        public int KolonID { get; set; }
        public int KitaplikID { get; set; }
        public string KolonAdi { get; set; }

        public Kitaplik Kitaplik { get; set; }
        public ICollection<Raf> Raflar { get; set; }
    }
}
