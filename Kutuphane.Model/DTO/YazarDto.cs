

using Core.Entity;
using Kutuphane.Model.Entity;

namespace Kutuphane.Model.DTO
{
    public class YazarDto :IDto
    {
        public int YazarID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public int Yas 
        { get
            {
                TimeSpan fark = DateTime.Now - (DogumTarihi ?? DateTime.Now);
                return (int)(fark.TotalDays / 365.25);
            } 
        }

        public List<Kitap>? Kitaplar { get; set; }
    }
}
