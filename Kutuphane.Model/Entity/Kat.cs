using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Kat : IEntity
    {
        public int KatID { get; set; }
        public string KatAdi { get; set; }

        public ICollection<Kitaplik> Kitapliklar { get; set; }
    }
}
