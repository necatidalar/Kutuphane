using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Uye : IEntity
    {
        public int UyeID { get; set; }
        public string TcPass { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public byte CinsiyetId { get; set; }
        public int? DogumYili { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string Adres { get; set; }
        public string AdresDetay { get; set; }

        public ICollection<Odunc> Oduncler { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
    }
}
