namespace Kutuphane.Model.DTO
{
    public class OduncUyeDto
    {
        public int UyeId { get; set; }
        public string TcPass { get; set; } = string.Empty;
        public string? OkulNo { get; set; }
        public string? Sinif { get; set; }
        public string? Sube { get; set; }
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;
        public string Eposta { get; set; } = string.Empty;
        public string? VeliAdSoyad { get; set; }
        public string? VeliTelefon { get; set; }
    }
}
