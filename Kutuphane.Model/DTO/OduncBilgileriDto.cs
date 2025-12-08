

using Core.Entity;
using Kutuphane.Model.Entity;

namespace Kutuphane.Model.DTO
{
    public class OduncBilgileriDto : IDto
    {
        public int OduncID { get; set; }
        public int UyeID { get; set; }
        public string UyeAd { get; set; }
        public string UyeSoyad { get; set; }
        public string UyeTelefon { get; set; }
        public string UyeEposta { get; set; }
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public DateTime AlisTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public bool TeslimEdildi { get; set; }
    }
}
