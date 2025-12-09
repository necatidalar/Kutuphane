using Core.Entity;

namespace Kutuphane.Model.Entity{
    public class Personel : IEntity
    {
        public int PersonelId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public byte CinsiyetId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public ICollection<Odunc> TeslimEdilenler { get; set; }
        public ICollection<Odunc> TerslimAlinanlar { get; set; }
        public Cinsiyet Cinsiyet { get; set; } 
    }
}
