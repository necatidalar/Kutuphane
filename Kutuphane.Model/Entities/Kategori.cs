using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Kategori : IEntity
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public bool AktifMi { get; set; }
        public ICollection<KitapKategori> KitapKategoriler { get; set; }
    }
}
