using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Cinsiyet : IEntity
    {
        public byte CinsiyetId { get; set; }
        public string CinsiyetAdi { get; set; }
    }
}
