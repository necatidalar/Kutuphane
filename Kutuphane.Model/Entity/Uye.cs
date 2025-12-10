using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Uye : IEntity
    {
        public int UyeId { get; set; }
        public string TcPass { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public byte CinsiyetId { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string Adres { get; set; }
        public string AdresDetay { get; set; }
        public bool AktifMi { get; set; }
        public ICollection<Odunc> Oduncler { get; set; }
        public Cinsiyet? Cinsiyet { get; set; }
    }
}
