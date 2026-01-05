

using Core.Entity;

namespace Kutuphane.Model.DTO
{
    public class OduncKitapDto : IDto
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public string ISBN { get; set; }
        public int YazarId { get; set; }
        public string Yazar { get; set; }
    }
}
