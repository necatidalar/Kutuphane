using Core.Entity;
using Kutuphane.Model.Entity;

namespace Kutuphane.Model.DTO
{
    public class KitapDTO : IEntity
    {
        public int KitapID { get; set; }        // Gerekiyor ama DataGrid’de gizleyebiliriz
        public string KitapAdi { get; set; }
        public string ISBN { get; set; }
        public int? BasimYili { get; set; }
        public int? SayfaSayisi { get; set; }
        public string Dil { get; set; }

        // ID’ler DataGrid’de görünmesin, sadece DTO’da saklı kalabilir
        public int YazarID { get; set; }
        public int YayineviID { get; set; }
        public int KategoriID { get; set; }

        // Görünecek isimler
        public string YazarAdi { get; set; }
        public string YayineviAdi { get; set; }
        public string KategoriAdi { get; set; }
    }
}
