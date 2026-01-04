using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Yazar : IEntity
    {
        public int YazarId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public DateTime? OlumTarihi { get; set; }
        public bool AktifMi { get; set; }
        public ICollection<YazarKitap> YazarKitaplari { get; set; }
    }
}