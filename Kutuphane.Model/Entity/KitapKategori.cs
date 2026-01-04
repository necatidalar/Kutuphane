

using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class KitapKategori : IEntity
    {
        public int Id { get; set; }
        public int KitapId { get; set; }
        public Kitap Kitap { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
    }
}
