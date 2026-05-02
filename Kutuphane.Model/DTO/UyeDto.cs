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

        // V2
        public int KurumId { get; set; }
        public string? KurumAdi { get; set; }
        public string? KurumKodu { get; set; }
        public string? KurumTipi { get; set; }
        public int UyeTipiId { get; set; }
        public string? UyeTipiAdi { get; set; }
        public string? UyeTipiKodu { get; set; }
        public int AktifOduncSayisi { get; set; }
        public int GecikmisKitapSayisi { get; set; }
        public string? OkulNo { get; set; }
        public string? Sinif { get; set; }
        public string? Sube { get; set; }
        public string? VeliTelefonu { get; set; }
        public string? Brans { get; set; }
    }
}
