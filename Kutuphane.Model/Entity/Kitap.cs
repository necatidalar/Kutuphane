using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Kitap : IEntity
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string ISBN { get; set; }
        public int YazarID { get; set; }
        public int YayineviID { get; set; }
        public int KategoriID { get; set; }
        public int? BasimYili { get; set; }
        public int? SayfaSayisi { get; set; }
        public string Dil { get; set; }
        public decimal? Fiyat { get; set; }

        
        public Yazar Yazar { get; set; }
        public Yayinevi Yayinevi { get; set; }
        public Kategori Kategori { get; set; }

        public ICollection<KitapSirasi> KitapSiralari { get; set; }
        public ICollection<Odunc> Oduncler { get; set; }
    }
}
