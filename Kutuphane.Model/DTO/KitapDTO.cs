using Core.Entity;

namespace Kutuphane.Model.DTO
{
    public class KitapDto : IDto
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string ISBN { get; set; }
        public int YazarID { get; set; }
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }
        public int YayineviID { get; set; }
        public string YayineviAd { get; set; }
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public int? BasimYili { get; set; }
        public int? SayfaSayisi { get; set; }
        public string Dil { get; set; }
        public int Stok { get; set; }
        public bool Aktif { get; set; }
    }
}
