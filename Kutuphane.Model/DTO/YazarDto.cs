using Core.Entity;

namespace Kutuphane.Model.DTO
{
    public class YazarDto :IDto
    {
        public int YazarId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public DateTime? OlumTarihi { get; set; }
        public string AdSoyad { get { return $"{Ad} {Soyad}"; } }

        public int? Yas
        {
            get
            {
                if (!DogumTarihi.HasValue)
                    return null;

                var bitisTarihi = OlumTarihi ?? DateTime.Today;
                var yas = bitisTarihi.Year - DogumTarihi.Value.Year;

                if (DogumTarihi.Value.Date > bitisTarihi.AddYears(-yas))
                    yas--;

                return yas;
            }
        }
    }
}
