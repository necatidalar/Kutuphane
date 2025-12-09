using Core.Entity;
using System.Collections.Generic;

namespace Kutuphane.Model.Entity
{
    public class Cinsiyet : IEntity
    {
        public byte Id { get; set; }
        public string CinsiyetAdi { get; set; }
        public ICollection<Personel> Personeller { get; set; }
    }
}
