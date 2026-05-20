using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Uye : IEntity
    {
        public int UyeId { get; set; }

        // Mevcut sistemi bozmamak için alan adı korunmuştur.
        // Okul kütüphanesi akışında TC/Pass alanı opsiyonel tutulur; boşsa OkulNo ile doldurulur.
        public string TcPass { get; set; } = string.Empty;

        // Okul kütüphanesi için eklenen öğrenci alanları
        public string? OkulNo { get; set; }
        public string? Sinif { get; set; }
        public string? Sube { get; set; }
        public string? VeliAdSoyad { get; set; }
        public string? VeliTelefon { get; set; }

        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public byte CinsiyetId { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Telefon { get; set; } = string.Empty;
        public string Eposta { get; set; } = string.Empty;
        public string Adres { get; set; } = string.Empty;
        public string AdresDetay { get; set; } = string.Empty;
        public bool AktifMi { get; set; }
        public ICollection<Odunc> Oduncler { get; set; } = new List<Odunc>();
        public Cinsiyet? Cinsiyet { get; set; }
    }
}
