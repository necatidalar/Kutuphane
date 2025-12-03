using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Odunc : IEntity
    {
        public int OduncID { get; set; }
        public int UyeID { get; set; }
        public int KitapID { get; set; }
        public DateTime AlisTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public bool TeslimEdildi { get; set; }
        public int PersonelID { get; set; }

        public Uye Uye { get; set; }
        public Kitap Kitap { get; set; }
        public Personel Personel { get; set; }
    }
}
