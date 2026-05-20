using Core.Entity;

namespace Kutuphane.Model.DTO
{
    public class UyeDto : IDto
    {
        public int UyeId { get; set; }
        public string TcPass { get; set; } = string.Empty;
        public string? OkulNo { get; set; }
        public string? Sinif { get; set; }
        public string? Sube { get; set; }
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public byte CinsiyetId { get; set; }
        public string? Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Telefon { get; set; } = string.Empty;
        public string Eposta { get; set; } = string.Empty;
        public string? VeliAdSoyad { get; set; }
        public string? VeliTelefon { get; set; }
        public string Adres { get; set; } = string.Empty;
        public string AdresDetay { get; set; } = string.Empty;
        public bool AktifMi { get; set; }
    }
}
