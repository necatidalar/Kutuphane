using Core.Entity;

namespace Kutuphane.Model.DTO
{
    public class UyeDto : IDto
    {
        public int UyeId { get; set; }
        public string TcPass { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public byte CinsiyetId { get; set; }
        public string? Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string Adres { get; set; }
        public string AdresDetay { get; set; }
        public bool AktifMi { get; set; }
    }
}
