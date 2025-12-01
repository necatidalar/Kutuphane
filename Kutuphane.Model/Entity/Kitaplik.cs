using Core.Entity;

namespace Kutuphane.Model.Entity
{


    public class Kitaplik:IEntity
    {
        public int KitaplikID { get; set; }
        public int KatID { get; set; }
        public string KitaplikAdi { get; set; }

        public Kat Kat { get; set; }
        public ICollection<Kolon> Kolonlar { get; set; }
    }
}
