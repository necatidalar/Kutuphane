using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Kitap : IEntity
    {
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public string? ISBN { get; set; }
        public int YazarId { get; set; }
        public int YayineviId { get; set; }
        public int KategoriId { get; set; }
        public int? BasimYili { get; set; }
        public int? SayfaSayisi { get; set; }
        public short DilId { get; set; }
        public int Stok { get; set; }
        public bool Aktif { get; set; }
        public Dil Diller { get; set; }

        public Yazar Yazar { get; set; }
        public Yayinevi Yayinevi { get; set; }
        public Kategori Kategori { get; set; }

        public ICollection<KitapKategori> KitapKategoriler { get; set; }
        public ICollection<YazarKitap> KitapYazarlari { get; set; }
        public ICollection<YayineviKitap> KitapYayinevleri { get; set; }
        public ICollection<Odunc>? Oduncler { get; set; }
    }
}
