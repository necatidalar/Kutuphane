using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Kategori : IEntity
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public ICollection<Kitap> Kitaplar { get; set; }
    }
}
