using Core.Entity;

namespace Kutuphane.Model.Entity{
    public class Personel : IEntity
    {
        public int PersonelID { get; set; }
        public string AdSoyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public ICollection<Odunc> Oduncler { get; set; }
    }
}
