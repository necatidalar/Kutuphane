using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Yazar : IEntity
    {
        public int YazarID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }

        public ICollection<Kitap> Kitaplar { get; set; }
    }
}
