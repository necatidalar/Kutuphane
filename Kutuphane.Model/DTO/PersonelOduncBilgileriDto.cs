

using Core.Entity;

namespace Kutuphane.Model.DTO
{
    public class PersonelOduncBilgileriDto : IDto
    {
        public int PersonelId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int OduncSayisi { get; set; }
        public List<OduncBilgileriDto>? TeslimEdilenler { get; set; }
        public List<OduncBilgileriDto>? TeslimAlinanlar { get; set; }
    }
}
