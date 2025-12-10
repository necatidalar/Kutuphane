using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Dil : IEntity
    {
        public short DilId { get; set; }
        public string DilAdi { get; set; }
        public string DilKodu { get; set; }
    }
}
