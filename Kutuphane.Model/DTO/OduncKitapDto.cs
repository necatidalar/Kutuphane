using Core.Entity;

namespace Kutuphane.Model.DTO
{
    public class OduncKitapDto : IDto
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public int YazarId { get; set; }
        public string Yazar { get; set; } = string.Empty;
        public int Stok { get; set; }
        public bool UygunMu => Stok > 0;
    }
}
